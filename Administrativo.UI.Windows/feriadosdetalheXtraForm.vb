Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask


Public Class feriadosdetalheXtraForm
    Dim objFeriados As New FeriadosBLL
    Dim objComum As New ComumBLL

    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0
    Dim intLinhaSubRegistro As Int32 = -1
    Dim infoferiados As feriadosInfo
    Dim aptFeriados As Appointment
    Dim sccFeriados As SchedulerStorage
    Dim blnCarregaTela As Boolean = False

    Dim infofiltro As List(Of feriadosfiltro)
    Dim originalinfofiltro As List(Of feriadosfiltro)

    Public Sub New(paptFeriados As Appointment, psccFeriados As SchedulerStorage)
        blnCarregaTela = True
        InitializeComponent()
        blnCarregaTela = False
        aptFeriados = paptFeriados
        sccFeriados = psccFeriados
    End Sub

    Private Sub feriadosdetalheXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaTela()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub feriadoGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles feriadoGridView.DoubleClick
        Try
            If okSimpleButton.Tag.ToString <> "exclusao" Then
                confirmarvariacaoSimpleButton.Tag = "alteracao"
                Dim strField() As String = {"filtro", "nome"}
                CarregaDados(feriadoGridView, strField, filtroSearchLookUpEdit, filtrodescTextEdit, feriadoSplitContainerControl,
                             incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub filtroSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles filtroSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                If filtrodescTextEdit.Visible Then
                    filtrodescTextEdit.Text = objComum.RetornaDescricao(filtroBindingSource, index, "nome")
                Else
                    filtrodescTextEdit.Text = String.Empty
                End If
            Else
                filtrodescTextEdit.Text = String.Empty
            End If
        Else
            filtrodescTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub tipoferiadoComboBoxEdit_EditValueChanged(sender As Object, e As System.EventArgs) Handles tipoferiadoComboBoxEdit.EditValueChanged
        If Not tipoferiadoComboBoxEdit.EditValue Is Nothing Then
            RedimensionaTela(tipoferiadoComboBoxEdit.EditValue.ToString.ToLower, tipoferiadoComboBoxEdit.EditValue.ToString)
        End If
    End Sub

    Private Sub incluirvariacaoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles incluirvariacaoSimpleButton.Click
        Try
            confirmarvariacaoSimpleButton.Tag = "inclusao"
            HabilitaBotoes(confirmarvariacaoSimpleButton.Tag.ToString, filtroGridView,
                           incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
            feriadoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            filtroSearchLookUpEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarvariacaoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles alterarvariacaoSimpleButton.Click
        Try
            confirmarvariacaoSimpleButton.Tag = "alteracao"
            Dim strField() As String = {"filtro", "nome"}
            CarregaDados(feriadoGridView, strField, filtroSearchLookUpEdit, filtrodescTextEdit, feriadoSplitContainerControl,
                         incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirvariacaoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles excluirvariacaoSimpleButton.Click
        Try
            confirmarvariacaoSimpleButton.Tag = "exclusao"
            Dim strField() As String = {"filtro", "nome"}
            CarregaDados(feriadoGridView, strField, filtroSearchLookUpEdit, filtrodescTextEdit, feriadoSplitContainerControl,
                         incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub confirmarvariacaoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles confirmarvariacaoSimpleButton.Click
        Try
            VerificaDadosGravacao(filtroSearchLookUpEdit.EditValue.ToString, confirmarvariacaoSimpleButton)
            SetModelo(feriadoGridControl, confirmarvariacaoSimpleButton)
            HabilitaBotoes(confirmarvariacaoSimpleButton.Tag.ToString, filtroGridView,
                           incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
            feriadoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarvariacaoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarvariacaoSimpleButton.Click
        Try
            LimpaDados(confirmarvariacaoSimpleButton)
            HabilitaBotoes(confirmarvariacaoSimpleButton.Tag.ToString, filtroGridView,
                           incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
            feriadoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function DisplayComboBox(ByVal pstrCampo As String, ByVal pstrValor As String) As String
        Dim strDisplayComboBox As String = String.Empty
        If pstrCampo = "mes" Then
            If pstrValor = "1" Then
                strDisplayComboBox = "Janeiro"
            ElseIf pstrValor = "2" Then
                strDisplayComboBox = "Fevereiro"
            ElseIf pstrValor = "3" Then
                strDisplayComboBox = "Março"
            ElseIf pstrValor = "4" Then
                strDisplayComboBox = "Abril"
            ElseIf pstrValor = "5" Then
                strDisplayComboBox = "Maio"
            ElseIf pstrValor = "6" Then
                strDisplayComboBox = "Junho"
            ElseIf pstrValor = "7" Then
                strDisplayComboBox = "Julho"
            ElseIf pstrValor = "8" Then
                strDisplayComboBox = "Agosto"
            ElseIf pstrValor = "9" Then
                strDisplayComboBox = "Setembro"
            ElseIf pstrValor = "10" Then
                strDisplayComboBox = "Outubro"
            ElseIf pstrValor = "11" Then
                strDisplayComboBox = "Novembro"
            ElseIf pstrValor = "12" Then
                strDisplayComboBox = "Dezembro"
            End If
        ElseIf pstrCampo = "tipoferiado" Then
            If pstrValor = "1" Then
                strDisplayComboBox = "Federal"
            ElseIf pstrValor = "2" Then
                strDisplayComboBox = "Estadual"
            ElseIf pstrValor = "3" Then
                strDisplayComboBox = "Municipal"
            End If
        End If

        Return strDisplayComboBox
    End Function

    Private Sub CarregaTela()
        Try
            Dim strQuery As String = String.Empty
            descricaoTextEdit.Text = aptFeriados.Subject
            diaTextEdit.Text = aptFeriados.Start.Day.ToString
            mesComboBoxEdit.EditValue = DisplayComboBox("mes", aptFeriados.Start.Month.ToString)
            tipoferiadoComboBoxEdit.EditValue = DisplayComboBox("tipoferiado", aptFeriados.LabelKey.ToString)
            If Convert.ToInt32(aptFeriados.LabelKey) > 0 Then
                descricaoTextEdit.Enabled = aptFeriados.IsRecurring
                diaTextEdit.Enabled = aptFeriados.IsRecurring
                mesComboBoxEdit.Enabled = aptFeriados.IsRecurring
                tipoferiadoComboBoxEdit.Enabled = aptFeriados.IsRecurring
                okSimpleButton.Enabled = aptFeriados.IsRecurring
                If Not aptFeriados.IsRecurring Then
                    infofiltro = New List(Of feriadosfiltro)
                End If
            Else
                infofiltro = New List(Of feriadosfiltro)
            End If
            If tipoferiadoComboBoxEdit.Enabled Then
                tipoferiadoComboBoxEdit.Enabled = (Convert.ToInt32(aptFeriados.LabelKey) = 0)
            End If
            If diaTextEdit.Enabled Then
                diaTextEdit.Enabled = (Convert.ToInt32(aptFeriados.LabelKey) = 0)
            End If
            If mesComboBoxEdit.Enabled Then
                mesComboBoxEdit.Enabled = (Convert.ToInt32(aptFeriados.LabelKey) = 0)
            End If
            If tipoferiadoComboBoxEdit.EditValue.ToString.ToLower = "municipal" Or tipoferiadoComboBoxEdit.EditValue.ToString.ToLower = "estadual" Then
                If tipoferiadoComboBoxEdit.EditValue.ToString.ToLower = "municipal" Then
                    strQuery = "select af.filtro, m.nome " +
                                 "from admferiados af " +
                                 "join municipios m on m.municipio = af.filtro " +
                                "where af.dataferiado = '" + Convert.ToString("00" + aptFeriados.Start.Day.ToString).Substring(aptFeriados.Start.Day.ToString.Length, 2) + "/" + Convert.ToString("00" + aptFeriados.Start.Month.ToString).Substring(aptFeriados.Start.Month.ToString.Length, 2) + "' " +
                                  "and af.tipoferiado = 'M'"
                ElseIf tipoferiadoComboBoxEdit.EditValue.ToString.ToLower = "estadual" Then
                    strQuery = "select af.filtro, e.nome " +
                                 "from admferiados af " +
                                 "join estados e on e.estado = af.filtro " +
                                "where af.dataferiado = '" + Convert.ToString("00" + aptFeriados.Start.Day.ToString).Substring(aptFeriados.Start.Day.ToString.Length, 2) + "/" + Convert.ToString("00" + aptFeriados.Start.Month.ToString).Substring(aptFeriados.Start.Month.ToString.Length, 2) + "' " +
                                  "and af.tipoferiado = 'E'"
                End If
                infofiltro = New List(Of feriadosfiltro)
                objFeriados.Grid(strQuery, feriadoGridControl, feriadoGridView, infofiltro, tipoferiadoComboBoxEdit.EditValue.ToString.ToLower)
            End If
            infoferiados = New feriadosInfo

            infoferiados.filtro = infofiltro
            originalinfofiltro = New List(Of feriadosfiltro)
            If infofiltro IsNot Nothing Then
                For index = 0 To infofiltro.Count - 1
                    Dim filtroinfo As New feriadosfiltro(infofiltro(index).filtro.ToString, infofiltro(index).nome.ToString)
                    originalinfofiltro.Add(filtroinfo)
                Next
            End If

            okSimpleButton.Tag = "inclusao"
            If Convert.ToInt32(aptFeriados.LabelKey) > 0 Then
                okSimpleButton.Tag = "alteracao"
            Else
                RedimensionaTela(tipoferiadoComboBoxEdit.EditValue.ToString.ToLower, tipoferiadoComboBoxEdit.EditValue.ToString)
            End If

            HabilitaBotoes(String.Empty, feriadoGridView,
                           incluirvariacaoSimpleButton, alterarvariacaoSimpleButton, excluirvariacaoSimpleButton, confirmarvariacaoSimpleButton, voltarvariacaoSimpleButton)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub RedimensionaTela(ByVal pstrTipo As String, ByVal pstrValor As String)
        If Not blnCarregaTela Then
            If pstrTipo = "municipal" Or pstrTipo = "estadual" Then
                feriadoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                Me.Height = 435
                okSimpleButton.Location = New Point(okSimpleButton.Location.X, 350)
                voltarSimpleButton.Location = New Point(voltarSimpleButton.Location.X, 350)
            Else
                Me.Height = 185
                okSimpleButton.Location = New Point(okSimpleButton.Location.X, 101)
                voltarSimpleButton.Location = New Point(voltarSimpleButton.Location.X, 101)
            End If

            filtroGroupControl.Visible = (pstrTipo = "municipal" Or pstrTipo = "estadual")
            If pstrTipo = "municipal" Then
                If filtroSearchLookUpEdit.Properties.View.Columns.Count > 0 Then
                    filtroSearchLookUpEdit.Properties.View.Columns.Clear()
                End If
                Dim column As GridColumn = filtroSearchLookUpEdit.Properties.View.Columns.AddField("municipio")

                Dim edit As New RepositoryItemTextEdit
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = True
                edit.Mask.EditMask = "00-00000"

                column.ColumnEdit = edit
                column.Visible = True
                column.Caption = "Município"
                column.FieldName = "municipio"
                column = filtroSearchLookUpEdit.Properties.View.Columns.AddField("nome")
                column.Visible = True
                column.Caption = "Nome"
                column.FieldName = "nome"

                objComum.Browse("select municipio, nome from municipios order by municipio", filtroBindingSource)
                filtroSearchLookUpEdit.Properties.DisplayMember = "municipio"
                filtroSearchLookUpEdit.Properties.ValueMember = "municipio"
                filtroSearchLookUpEdit.EditValue = pstrValor
                filtroGroupControl.Text = "Relação de Munícipio"
                filtroLabelControl.Text = "Município"
            ElseIf pstrTipo = "estadual" Then
                If filtroSearchLookUpEdit.Properties.View.Columns.Count > 0 Then
                    filtroSearchLookUpEdit.Properties.View.Columns.Clear()
                End If
                Dim column As GridColumn = filtroSearchLookUpEdit.Properties.View.Columns.AddField("estado")
                column.Visible = True
                column.Caption = "Estado"
                column.FieldName = "estado"
                column = filtroSearchLookUpEdit.Properties.View.Columns.AddField("nome")
                column.Visible = True
                column.Caption = "Nome"
                column.FieldName = "nome"

                objComum.Browse("select estado, nome from estados order by estado", filtroBindingSource)
                filtroSearchLookUpEdit.Properties.DisplayMember = "estado"
                filtroSearchLookUpEdit.Properties.ValueMember = "estado"
                filtroSearchLookUpEdit.EditValue = pstrValor
                filtroGroupControl.Text = "Relação de Estados"
                filtroLabelControl.Text = "Estado"
            End If
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String, pgvItens As GridView,
                               incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                               confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        incluirbutton.Enabled = (pstrOperacao = String.Empty)
        alterarbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
        excluirbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
        confirmarbutton.Enabled = (pstrOperacao <> String.Empty)
        voltarbutton.Enabled = (pstrOperacao <> String.Empty)
        If Not IsNothing(confirmarbutton.Tag) Then
            If confirmarbutton.Tag.ToString = "exclusao" Then
                confirmarbutton.ImageIndex = 3
            Else
                confirmarbutton.ImageIndex = 2
            End If
            okSimpleButton.Enabled = (confirmarbutton.Tag.ToString = String.Empty)
            If confirmarbutton.Tag.ToString = String.Empty Then
                Me.AcceptButton = okSimpleButton
            Else
                Me.AcceptButton = Nothing
            End If
        End If
    End Sub

    Private Sub CarregaDados(pgvGrid As GridView, pstrField() As String,
                             pFieldSearchLookUpEdit As SearchLookUpEdit, pFieldTextEdit As TextEdit, pSplitContainerControl As SplitContainerControl,
                             incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                             confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                pFieldSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), pstrField(0)).ToString()
                pFieldTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), pstrField(1)).ToString()
                RetornaIndexRegistro(pFieldSearchLookUpEdit.EditValue.ToString)
                HabilitaBotoes(confirmarbutton.Tag.ToString, pgvGrid, incluirbutton, alterarbutton, excluirbutton, confirmarbutton, voltarbutton)
                pSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                pFieldSearchLookUpEdit.Focus()
            End If
        Next
    End Sub

    Private Sub SetModelo(pdgGrid As GridControl, confirmarbutton As SimpleButton)
        If confirmarbutton.Tag.ToString = "inclusao" Then
            Dim filtroinfo As New feriadosfiltro(filtroSearchLookUpEdit.EditValue.ToString, filtrodescTextEdit.Text)
            infofiltro.Add(filtroinfo)
        ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            infofiltro(intLinhaSubRegistro).filtro = filtroSearchLookUpEdit.EditValue.ToString
            infofiltro(intLinhaSubRegistro).nome = filtrodescTextEdit.Text
        ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
            infofiltro.Remove(infofiltro(intLinhaSubRegistro))
        End If
        pdgGrid.DataSource = Nothing
        pdgGrid.DataSource = infofiltro
        pdgGrid.ForceInitialize()
        infoferiados.filtro = infofiltro
        tipoferiadoComboBoxEdit.Enabled = (infoferiados.filtro.Count = 0)
        LimpaDados(confirmarbutton)
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            infoferiados.data = Convert.ToString("00" + diaTextEdit.Text).Substring(diaTextEdit.Text.Length, 2) + "/" + Convert.ToString("00" + Convert.ToString(mesComboBoxEdit.SelectedIndex + 1)).Substring(Convert.ToString(mesComboBoxEdit.SelectedIndex + 1).Length, 2)
            infoferiados.descricao = descricaoTextEdit.Text
            infoferiados.tipoferiado = String.Empty
            If Not String.IsNullOrEmpty(tipoferiadoComboBoxEdit.Text) Then
                infoferiados.tipoferiado = tipoferiadoComboBoxEdit.Text.ToUpper.Substring(0, 1)
            End If
            infoferiados.tipodata = "F"
            Dim strLocalizacao As String = String.Empty
            If infoferiados.tipoferiado = "F" Then
                strLocalizacao = "BRASIL"
            ElseIf infoferiados.tipoferiado = "E" Then
                If infoferiados.filtro.Count = 1 Then
                    strLocalizacao = infoferiados.filtro(0).nome
                Else
                    aptFeriados.Location = "em " + infoferiados.filtro.Count.ToString + " Estados"
                End If
            ElseIf infoferiados.tipoferiado = "M" Then
                If infoferiados.filtro.Count = 1 Then
                    strLocalizacao = infoferiados.filtro(0).nome
                Else
                    strLocalizacao = "em " + infoferiados.filtro.Count.ToString + " Municípios"
                End If
            End If

            Dim dtaData As Date = aptFeriados.Start.Date
            dtaData = dtaData.AddYears((administrativoInfo.Exercicio - 1) - dtaData.Year)
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objFeriados.IUDFeriados(pstrOperacao, infoferiados, originalinfofiltro)
            If pstrOperacao = "inclusao" Then
                objFeriados.Feriados(dtaData, infoferiados.descricao, strLocalizacao, infoferiados.tipodata, infoferiados.tipoferiado, sccFeriados)
            Else
                objFeriados.Feriados(infoferiados.descricao, strLocalizacao, infoferiados.tipoferiado, aptFeriados)
            End If
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub LimpaDados(confirmarbutton As SimpleButton)
        filtroSearchLookUpEdit.EditValue = String.Empty
        filtrodescTextEdit.Text = String.Empty
        intLinhaSubRegistro = -1
        confirmarbutton.Tag = String.Empty
    End Sub

    Private Sub RetornaIndexRegistro(pstrValor As String)
        For index = 0 To infofiltro.Count - 1
            If infofiltro(index).filtro = pstrValor Then
                intLinhaSubRegistro = index
            End If
        Next
    End Sub

    Private Sub VerificaDadosGravacao(pstrCampoChave As String, confirmarbutton As SimpleButton)
        For index = 0 To infofiltro.Count - 1
            If confirmarbutton.Tag.ToString = "inclusao" Then
                If infofiltro(index).filtro = pstrCampoChave Then
                    Throw New Exception("Já existe um " + filtroLabelControl.Text.ToString + " cadastrado")
                    Exit For
                End If
            ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                If index <> intLinhaSubRegistro Then
                    If infofiltro(index).filtro = pstrCampoChave Then
                        Throw New Exception("Já existe um " + filtroLabelControl.Text.ToString + " cadastrado")
                        Exit For
                    End If
                End If
            End If
        Next
        If String.IsNullOrEmpty(pstrCampoChave) Then Throw New Exception("O " + filtroLabelControl.Text.ToString + " é obrigatório")
    End Sub
End Class