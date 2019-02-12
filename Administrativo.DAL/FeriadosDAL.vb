Imports Administrativo.Modelo
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Mask

Public Class FeriadosDAL
    Implements IFeriados

    Private edit As RepositoryItemTextEdit

    Public Sub CriaFeriados(ByRef pstrQuery As String, psccFeriados As DevExpress.XtraScheduler.SchedulerControl) Implements IFeriados.CriaFeriados
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdFeriados As SelectedData = objDataBase.QueryFull(pstrQuery)
            Dim scFeriados As SchedulerStorage = psccFeriados.Storage
            For Each row As SelectStatementResultRow In sdFeriados.ResultSet(1).Rows
                Feriados(row.Values(4), row.Values(5), row.Values(3), row.Values(2).ToString, row.Values(1).ToString, scFeriados)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoFiltro As System.Collections.Generic.List(Of Modelo.feriadosfiltro), ByRef pstrVariacao As String) Implements IFeriados.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdFeriadosDetalhe As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdFeriadosDetalhe.ResultSet(1).Rows
                infoFiltro.Add(New feriadosfiltro(row.Values(0).ToString, row.Values(1).ToString))
            Next

            pdgGrid.DataSource = infoFiltro

            pgvGrid.OptionsView.ShowGroupPanel = False
            pgvGrid.OptionsView.ColumnAutoWidth = False
            pgvGrid.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            pgvGrid.ColumnPanelRowHeight = 60
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            If pstrVariacao = "municipal" Then
                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = True
                edit.Mask.EditMask = "00-00000"
                pgvGrid.Columns(0).Visible = True
                pgvGrid.Columns(0).ColumnEdit = edit
                pgvGrid.Columns(0).Caption = "Município"
                pgvGrid.Columns(0).Width = 90
            ElseIf pstrVariacao = "estadual" Then
                pgvGrid.Columns(0).Visible = True
                pgvGrid.Columns(0).Caption = "Estado"
                pgvGrid.Columns(0).Width = 90
            End If

            pgvGrid.Columns(1).Visible = True
            pgvGrid.Columns(1).Caption = "Nome"
            pgvGrid.Columns(1).Width = 300

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDFeriados(ByRef pstrOperacao As String, ByRef infoFeriados As Modelo.feriadosInfo, ByRef originalinfoFiltro As System.Collections.Generic.List(Of Modelo.feriadosfiltro)) Implements IFeriados.IUDFeriados
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "inclusao" Then
                If infoFeriados.filtro Is Nothing Then
                    strQuery = "insert into admferiados(dataferiado, descricao, tipoferiado, tipodata, incuser, incdata, altuser, altdata) " +
                                               "values ('" + infoFeriados.data + "', " +
                                                       "'" + infoFeriados.descricao + "', " +
                                                       "'" + infoFeriados.tipoferiado + "', " +
                                                       "'" + infoFeriados.tipodata + "', " +
                                                       "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                       "'" + usuarioInfo.usuario + "', current_timestamp);"
                Else
                    For index = 0 To infoFeriados.filtro.Count - 1
                        If Not String.IsNullOrEmpty(strQuery) Then
                            strQuery += Chr(13) + Chr(10)
                        End If
                        strQuery += "insert into admferiados(dataferiado, filtro, descricao, tipoferiado, tipodata, incuser, incdata, altuser, altdata) " +
                                                    "values ('" + infoFeriados.data + "', " +
                                                            "'" + infoFeriados.filtro(index).filtro + "', " +
                                                            "'" + infoFeriados.descricao + "', " +
                                                            "'" + infoFeriados.tipoferiado + "', " +
                                                            "'" + infoFeriados.tipodata + "', " +
                                                            "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                            "'" + usuarioInfo.usuario + "', current_timestamp);"
                    Next
                End If
            ElseIf pstrOperacao = "alteracao" Then
                If pstrOperacao <> "exclusao" Then
                    'Verificação dos itens alterados com o original que foi carregado, caso um item original não foi encontrado nos alterados
                    'indica que houve exclusão
                    For indexoriginal = 0 To originalinfoFiltro.Count - 1
                        Dim blnEncontrouFeriadoFiltro As Boolean = False
                        For index = 0 To infoFeriados.filtro.Count - 1
                            If originalinfoFiltro(indexoriginal).filtro = infoFeriados.filtro(index).filtro Then
                                blnEncontrouFeriadoFiltro = True
                                Exit For
                            End If
                        Next
                        If Not blnEncontrouFeriadoFiltro Then
                            strQuery += Chr(13) + Chr(10)
                            strQuery += "delete " +
                                          "from admferiados " +
                                         "where dataferiado = '" + infoFeriados.data + "' " +
                                           "and filtro = '" + originalinfoFiltro(indexoriginal).filtro + "';"
                        End If
                    Next
                    If infoFeriados.filtro IsNot Nothing Then
                        For index = 0 To infoFeriados.filtro.Count - 1
                            Dim blnEncontrouFeriadoFiltro As Boolean = False
                            For indexoriginal = 0 To originalinfoFiltro.Count - 1
                                If infoFeriados.filtro(index).filtro = originalinfoFiltro(indexoriginal).filtro Then
                                    blnEncontrouFeriadoFiltro = True
                                    Exit For
                                End If
                            Next
                            'Verificação dos itens alterados com o original que foi carregado, caso um item original não foi encontrado nos alterados
                            'indica que houve inclusão, caso contrário alteração de dados
                            If Not blnEncontrouFeriadoFiltro Then
                                strQuery += Chr(13) + Chr(10)
                                strQuery += "insert into admferiados(dataferiado, filtro, descricao, tipoferiado, tipodata, incuser, incdata, altuser, altdata) " +
                                                                "values ('" + infoFeriados.data + "', " +
                                                                        "'" + infoFeriados.filtro(index).filtro + "', " +
                                                                        "'" + infoFeriados.descricao + "', " +
                                                                        "'" + infoFeriados.tipoferiado + "', " +
                                                                        "'" + infoFeriados.tipodata + "', " +
                                                                        "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                        "'" + usuarioInfo.usuario + "', current_timestamp);"
                            Else
                                strQuery += Chr(13) + Chr(10)
                                strQuery += "update admferiados " +
                                              "set descricao = '" + infoFeriados.descricao.ToString + "', " +
                                                  "altuser = '" + usuarioInfo.usuario + "', " +
                                                  "altdata = current_timestamp " +
                                            "where dataferiado = '" + infoFeriados.data + "' " +
                                              "and filtro = '" + infoFeriados.filtro(index).filtro.ToString + "' " +
                                              "and tipoferiado = '" + infoFeriados.tipoferiado + "' " +
                                              "and tipodata = '" + infoFeriados.tipodata + "';"
                            End If
                        Next
                    Else
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "update admferiados " +
                                      "set descricao = '" + infoFeriados.descricao.ToString + "', " +
                                          "altuser = '" + usuarioInfo.usuario + "', " +
                                          "altdata = current_timestamp " +
                                    "where dataferiado = '" + infoFeriados.data + "' " +
                                      "and tipoferiado = '" + infoFeriados.tipoferiado + "' " +
                                      "and tipodata = '" + infoFeriados.tipodata + "';"
                    End If
                End If
            ElseIf pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admferiados " +
                            "where coalesce(dataferiado,'') = '" + infoFeriados.data + "' " +
                              "and tipoferiado = '" + infoFeriados.tipoferiado + "' " +
                              "and tipodata = '" + infoFeriados.tipodata + "' "
                If infoFeriados.tipodata = "V" Then
                    strQuery += "and descricao = '" + infoFeriados.descricao + "'"
                End If
                strQuery += ";"
            End If
            objDataBase.NonQuery(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Feriados(ByRef pstrDescricao As String, ByRef pstrLocalizacao As String, ByRef pstrTipoFeriado As String, paptFeriados As DevExpress.XtraScheduler.Appointment) Implements IFeriados.Feriados
        Try
            If pstrTipoFeriado = "F" Then
                paptFeriados.Location = "País: " + pstrLocalizacao
            ElseIf pstrTipoFeriado = "E" Then
                paptFeriados.Location = "Estado: " + pstrLocalizacao
            ElseIf pstrTipoFeriado = "M" Then
                paptFeriados.Location = "Município: " + pstrLocalizacao
            End If

            paptFeriados.Subject = pstrDescricao
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Feriados(ByRef pdtaDataFeriado As Date, ByRef pstrDescricao As String, ByRef pstrLocalizacao As String, ByRef pstrTipoData As String, ByRef pstrTipoFeriado As String, psccFeriados As DevExpress.XtraScheduler.SchedulerStorage) Implements IFeriados.Feriados
        Try
            Dim aptFeriados As Appointment

            If pstrTipoData = "F" Then
                aptFeriados = psccFeriados.CreateAppointment(AppointmentType.Pattern)
            Else
                aptFeriados = psccFeriados.CreateAppointment(AppointmentType.Normal)
            End If
            aptFeriados.AllDay = True
            If pstrTipoFeriado = "F" Then
                aptFeriados.Location = "País: " + pstrLocalizacao
                aptFeriados.LabelKey = 1
            ElseIf pstrTipoFeriado = "E" Then
                aptFeriados.Location = "Estado: " + pstrLocalizacao
                aptFeriados.LabelKey = 2
            ElseIf pstrTipoFeriado = "M" Then
                aptFeriados.Location = "Município: " + pstrLocalizacao
                aptFeriados.LabelKey = 3
            End If

            aptFeriados.Start = pdtaDataFeriado
            aptFeriados.End = pdtaDataFeriado
            aptFeriados.Subject = pstrDescricao

            If pstrTipoData = "F" Then
                aptFeriados.RecurrenceInfo.AllDay = True
                aptFeriados.RecurrenceInfo.Type = RecurrenceType.Yearly
                aptFeriados.RecurrenceInfo.Start = aptFeriados.Start
                aptFeriados.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None
                aptFeriados.RecurrenceInfo.DayNumber = aptFeriados.Start.Day
                aptFeriados.RecurrenceInfo.Month = aptFeriados.Start.Month
                aptFeriados.RecurrenceInfo.Range = RecurrenceRange.NoEndDate
                aptFeriados.RecurrenceInfo.End = aptFeriados.Start
            End If
            psccFeriados.Appointments.Add(aptFeriados)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub ApagaFeriados(paptFeriados As DevExpress.XtraScheduler.Appointment, psccFeriados As DevExpress.XtraScheduler.SchedulerStorage) Implements IFeriados.ApagaFeriados
        Try
            Dim strTipoFeriado As String = String.Empty
            If Convert.ToInt32(paptFeriados.LabelKey) = 1 Then
                strTipoFeriado = "F"
            ElseIf Convert.ToInt32(paptFeriados.LabelKey) = 2 Then
                strTipoFeriado = "E"
            ElseIf Convert.ToInt32(paptFeriados.LabelKey) = 3 Then
                strTipoFeriado = "M"
            End If

            Dim strTipoData As String = String.Empty
            If Not paptFeriados.IsRecurring Then
                strTipoData = "V"
            Else
                strTipoData = "F"
            End If

            Dim strSqlExercicio As String = String.Empty
            Dim intExercicioInicial As Int32 = administrativoInfo.Exercicio - 1
            Dim intExercicioFinal As Int32 = administrativoInfo.Exercicio + 1

            If strTipoData = "V" Then
                For intIndex = intExercicioInicial To intExercicioFinal
                    If Not String.IsNullOrEmpty(strSqlExercicio) Then
                        strSqlExercicio += " union all "
                    End If
                    strSqlExercicio += "select " + intIndex.ToString + " as exercicio "
                Next
            End If

            Dim infoferiados As feriadosInfo
            Dim infofiltro As List(Of feriadosfiltro)

            Dim strQuery As String = String.Empty
            If strTipoData = "F" Then
                strQuery = "select cast(" + intExercicioInicial.ToString + " as integer) as exercicio, af.tipoferiado, af.tipodata, cast('BRASIL' as varchar) as localizacao, " +
                                  "cast(cast(cast(" + intExercicioInicial.ToString + " as varchar(4)) <concat> '-' <concat> substring(dataferiado,4,2) <concat> '-' <concat> substring(dataferiado,1,2) as date)as date) as dataferiado, " +
                                  "coalesce(af.descricao,'') as descricao, coalesce(af.filtro,'') as filtro " +
                             "from admferiados af " +
                            "where af.tipodata = '" + strTipoData + "' " +
                              "and af.tipoferiado = '" + strTipoFeriado + "' " +
                              "and af.dataferiado = '" + Convert.ToString("00" + paptFeriados.Start.Day.ToString).Substring(paptFeriados.Start.Day.ToString.Length, 2) + "/" + Convert.ToString("00" + paptFeriados.Start.Month.ToString).Substring(paptFeriados.Start.Month.ToString.Length, 2) + "'"
            ElseIf strTipoData = "V" Then
                strQuery = "select ex.exercicio, af.tipoferiado, af.tipodata, cast('BRASIL' as varchar) as localizacao, " +
                                  "gd_feriadomovel(af.filtro,ex.exercicio) as dataferiado, " +
                                  "coalesce(af.descricao,'') as descricao, coalesce(af.filtro,'') as filtro " +
                             "from (" + strSqlExercicio + ") ex " +
                             "join admferiados af on coalesce(af.dataferiado,'') = coalesce(af.dataferiado,'') " +
                            "where af.tipodata = '" + strTipoData + "' " +
                              "and af.tipoferiado = '" + strTipoFeriado + "' " +
                              "and af.descricao = '" + paptFeriados.Subject + "'"
            End If


            Dim objDataBase As New DataBaseDAL
            Dim sdFeriadosDetalhe As SelectedData = objDataBase.QueryFull(strQuery)

            infoferiados = New feriadosInfo
            infofiltro = New List(Of feriadosfiltro)

            For Each row As SelectStatementResultRow In sdFeriadosDetalhe.ResultSet(1).Rows
                If strTipoData = "F" Then
                    infofiltro.Add(New feriadosfiltro(row.Values(6).ToString, String.Empty))
                ElseIf strTipoData = "V" Then
                    For index = 0 To psccFeriados.Appointments.Count - 1
                        Dim aptFeriado As Appointment = psccFeriados.Appointments.Items(index)

                        If aptFeriado.Start = row.Values(4) And
                            Not paptFeriados.IsRecurring And
                            aptFeriado.Subject = row.Values(5) And
                            ((Convert.ToInt32(paptFeriados.LabelKey) = 1 And row.Values(1) = "F") Or
                            (Convert.ToInt32(paptFeriados.LabelKey) = 2 And row.Values(1) = "E") Or
                            (Convert.ToInt32(paptFeriados.LabelKey) = 3 And row.Values(1) = "M")) Then
                            psccFeriados.Appointments.Remove(aptFeriado)
                            Exit For
                        End If
                    Next
                End If
            Next
            If strTipoData = "F" Then
                infoferiados.data = Convert.ToString("00" + paptFeriados.Start.Day.ToString).Substring(paptFeriados.Start.Day.ToString.Length, 2) + "/" + Convert.ToString("00" + paptFeriados.Start.Month.ToString).Substring(paptFeriados.Start.Month.ToString.Length, 2)
            ElseIf strTipoData = "V" Then
                infoferiados.data = String.Empty
            End If
            infoferiados.descricao = paptFeriados.Subject
            infoferiados.tipoferiado = strTipoFeriado
            infoferiados.tipodata = strTipoData

            infoferiados.filtro = infofiltro

            IUDFeriados("exclusao", infoferiados, infofiltro)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
