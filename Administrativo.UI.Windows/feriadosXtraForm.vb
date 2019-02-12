Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler

Public Class feriadosXtraForm
    Dim objFeriados As New FeriadosBLL
    Dim strOperacao() As String = {"cadferinc|0", "cadferalt|0", "cadferexc|0", "cadfercon|0"}
    Dim blnApagaFeriado As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub feriadosXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaCalendario()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaCalendario()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            Dim intExercicioInicial As Int32 = administrativoInfo.Exercicio - 1
            Dim intExercicioFinal As Int32 = administrativoInfo.Exercicio + 1
            Dim strSqlExercicio As String = String.Empty
            For intIndex = intExercicioInicial To intExercicioFinal
                If Not String.IsNullOrEmpty(strSqlExercicio) Then
                    strSqlExercicio += " union all "
                End If
                strSqlExercicio += "select " + intIndex.ToString + " as exercicio "
            Next

            Dim strSqlCalendario As String = "select cast(" + intExercicioInicial.ToString + " as integer) as exercicio, af.tipoferiado, af.tipodata, cast('BRASIL' as varchar) as localizacao, " +
                                                    "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) as dataferiado, " +
                                                    "max(coalesce(af.descricao,'')) as descricao " +
                                               "from admferiados af " +
                                              "where af.tipodata = 'F' and af.tipoferiado = 'F' " +
                                           "group by af.tipoferiado, af.tipodata, " +
                                                    "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) " +
                                          "union all " +
                                             "select ex.exercicio, af.tipoferiado, af.tipodata, cast('BRASIL' as varchar) as localizacao, " +
                                                    "gd_feriadomovel(af.filtro,ex.exercicio)  as dataferiado, " +
                                                    "max(coalesce(af.descricao,'')) as descricao " +
                                               "from (" + strSqlExercicio + ") ex " +
                                               "join admferiados af on coalesce(af.dataferiado,'') = coalesce(af.dataferiado,'') " +
                                              "where af.tipodata = 'V' and af.tipoferiado = 'F' " +
                                           "group by ex.exercicio, af.tipoferiado, af.tipodata, gd_feriadomovel(af.filtro,ex.exercicio)  " +
                                          "union all " +
                                             "select cast(" + intExercicioInicial.ToString + " as integer) as exercicio, af.tipoferiado, af.tipodata, " +
                                                    "case when count(*) = 1 then max(coalesce(m.nome,'')) else 'em ' <concat> cast(count(*) as varchar) <concat> ' Municípios' end as localizacao, " +
                                                    "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) as dataferiado, " +
                                                    "max(coalesce(af.descricao,'')) as descricao " +
                                               "from admferiados af " +
                                               "join municipios m on m.municipio = af.filtro " +
                                              "where af.tipodata = 'F' and af.tipoferiado = 'M' " +
                                           "group by af.tipoferiado, af.tipodata, " +
                                                    "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) " +
                                          "union all " +
                                             "select cast(" + intExercicioInicial.ToString + " as integer) as exercicio, af.tipoferiado, af.tipodata, " +
                                                    "case when count(*) = 1 then max(coalesce(e.nome,'')) else 'em ' <concat> cast(count(*) as varchar) <concat> ' Estados' end as localizacao, " +
                                                    "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) as dataferiado, " +
                                                    "max(coalesce(af.descricao,'')) as descricao " +
                                               "from admferiados af " +
                                               "join estados e on e.estado = af.filtro " +
                                              "where af.tipodata = 'F' and af.tipoferiado = 'E' " +
                                           "group by af.tipoferiado, af.tipodata, " +
                                                    "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) " +
                                           "order by 3, 1, 5"

            objFeriados.CriaFeriados(strSqlCalendario, feriadosSchedulerControl)
            feriadosSchedulerControl.Start = Now
            feriadosSchedulerControl.LimitInterval = New TimeInterval(Convert.ToDateTime("01/01/" + intExercicioInicial.ToString).Date, Convert.ToDateTime("31/12/" + intExercicioFinal.ToString).Date)
            feriadosSchedulerControl.Refresh()
            CarregaOpcao()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadfer")

        If strOperacao.Length > 0 Then
            For index = 0 To strOperacao.Length - 1
                If Not String.IsNullOrEmpty(strOperacao(index)) Then
                    Dim strOpcao() As String = strOperacao(index).Split(Convert.ToChar("|"))
                    strOperacao(index) = strOpcao(0) + "|"
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, strOpcao(0)) Then
                        strOperacao(index) += "-1"
                    Else
                        strOperacao(index) += "0"
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub feriadosSchedulerControl_DeleteRecurrentAppointmentFormShowing(sender As Object, e As DevExpress.XtraScheduler.DeleteRecurrentAppointmentFormEventArgs) Handles feriadosSchedulerControl.DeleteRecurrentAppointmentFormShowing
        Dim aptAppointmentDelete As Appointment = e.Appointment
        objFeriados.ApagaFeriados(aptAppointmentDelete, feriadosSchedulerStorage)
        blnApagaFeriado = True
        feriadosSchedulerStorage.Appointments.Remove(e.Appointment.RecurrencePattern())
        e.Handled = True
    End Sub

    Private Sub feriadosSchedulerStorage_AppointmentDeleting(sender As Object, e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles feriadosSchedulerStorage.AppointmentDeleting
        If Not blnApagaFeriado Then
            Dim aptAppointmentDelete As Appointment = CType(e.Object, Appointment)
            objFeriados.ApagaFeriados(aptAppointmentDelete, feriadosSchedulerStorage)
        End If
        blnApagaFeriado = False
    End Sub

    Private Sub feriadosSchedulerControl_EditAppointmentFormShowing(sender As Object, e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles feriadosSchedulerControl.EditAppointmentFormShowing
        Dim blnEdit As Boolean = False

        If strOperacao.Length > 0 Then
            For index = 0 To strOperacao.Length - 1
                If Not String.IsNullOrEmpty(strOperacao(index)) Then
                    Dim strOpcao() As String = strOperacao(index).Split(Convert.ToChar("|"))
                    If Convert.ToInt32(e.Appointment.LabelKey) > 0 Then
                        If strOpcao(0).IndexOf("alt") > 0 Then
                            blnEdit = False
                            If strOpcao(1) = "-1" Then blnEdit = True
                            Exit For
                        End If
                    Else
                        If strOpcao(0).IndexOf("inc") > 0 Then
                            blnEdit = False
                            If strOpcao(1) = "-1" Then blnEdit = True
                            Exit For
                        End If
                    End If
                End If
            Next
        End If

        If blnEdit Then
            Dim aptFeriados As Appointment = e.Appointment
            feriadosSchedulerStorage.Appointments.IsNewAppointment(aptFeriados)

            Dim form As feriadosdetalheXtraForm = New feriadosdetalheXtraForm(aptFeriados, feriadosSchedulerStorage)
            Try
                e.DialogResult = form.ShowDialog(Me)
                feriadosSchedulerControl.Refresh()
                e.Handled = True
            Finally
                form.Dispose()
            End Try
        Else
            feriadosSchedulerControl.Refresh()
            e.Handled = True
        End If
    End Sub

    Private Sub feriadosSchedulerControl_PopupMenuShowing(sender As Object, e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles feriadosSchedulerControl.PopupMenuShowing
        'Remove alguns menus que não serão utilizados
        'Altera o nome de alguns menus
        If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu Then
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringEvent)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoThisDay)

            If strOperacao.Length > 0 Then
                For index = 0 To strOperacao.Length - 1
                    If Not String.IsNullOrEmpty(strOperacao(index)) Then
                        Dim strOpcao() As String = strOperacao(index).Split(Convert.ToChar("|"))
                        If strOpcao(0).IndexOf("inc") > 0 Then
                            If strOpcao(1) = "-1" Then
                                Dim item As SchedulerMenuItem = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment)
                                If item IsNot Nothing Then
                                    item.Caption = "&Novo Feriado"
                                End If
                            Else
                                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAppointment)
                            End If
                        End If
                    End If
                Next
            End If
        ElseIf e.Menu.Id = SchedulerMenuItemId.AppointmentMenu Then
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.EditSeries)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu)
            If strOperacao.Length > 0 Then
                For index = 0 To strOperacao.Length - 1
                    If Not String.IsNullOrEmpty(strOperacao(index)) Then
                        Dim strOpcao() As String = strOperacao(index).Split(Convert.ToChar("|"))
                        If strOpcao(0).IndexOf("alt") > 0 Then
                            If strOpcao(1) = "-1" Then
                                Dim item As SchedulerMenuItem = e.Menu.GetMenuItemById(SchedulerMenuItemId.OpenAppointment)
                                If item IsNot Nothing Then
                                    item.Caption = "&Abrir Feriado"
                                End If
                            Else
                                e.Menu.RemoveMenuItem(SchedulerMenuItemId.OpenAppointment)
                            End If
                        ElseIf strOpcao(0).IndexOf("exc") > 0 Then
                            If strOpcao(1) = "-1" Then
                                Dim item As SchedulerMenuItem = e.Menu.GetMenuItemById(SchedulerMenuItemId.DeleteAppointment)
                                If item IsNot Nothing Then
                                    item.Caption = "&Apagar Feriado"
                                End If
                            Else
                                e.Menu.RemoveMenuItem(SchedulerMenuItemId.DeleteAppointment)
                            End If
                        End If
                    End If
                Next
            End If
        End If
    End Sub
End Class