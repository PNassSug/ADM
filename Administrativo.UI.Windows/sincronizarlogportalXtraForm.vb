Imports Administrativo.BLL
Imports Administrativo.Modelo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Mask

''' <summary>
''' Interface Com o usuário
''' </summary>
''' <remarks>
''' Funções:
''' Sincronizar
''' Relatório
''' </remarks>

Public Class sincronizarlogportalXtraForm
    Dim objSincronizarlogportal As New SincronizarlogportalBLL
    Dim objComum As New ComumBLL

    Dim empresainicial As String
    Dim empresafinal As String
    Dim obrigacaoinicial As String
    Dim obrigacaofinal As String




    ''' <summary>
    ''' Construtor
    ''' </summary>
    ''' <remarks>
    ''' Carrega os BindingSource(s):
    ''' empresasInfoBindingSource
    ''' obrigacoesInfoBindingSource
    ''' Com a finalidade de utilizar nos SearchLookUpEdit
    ''' </remarks>
    Public Sub New()
        InitializeComponent()
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
        objComum.Browse("select empresa, razaosocial " +
                          "from empresas " +
                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " order by empresa", empresasInfoBindingSource)
    End Sub

    ''' <summary>
    ''' Form_Load
    ''' </summary>
    ''' <remarks>
    ''' Definem os valores nos SearchLookUpEdit e nas competências.
    ''' Os SearchLookUpEdit serão preenchidos usando os dados do banco de dados.
    ''' </remarks>
    Private Sub sincronizarlogportalXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        objComum.DefineValoresDefault("empresas", "empresa", empresainicialSearchLookUpEdit, empresafinalSearchLookUpEdit,
                                      "exercicio = " + administrativoInfo.Exercicio.ToString)
        objComum.DefineValoresDefault("admobrigacoes", "obrigacao", obrigacaoinicialSearchLookUpEdit, obrigacaofinalSearchLookUpEdit)
        competenciainicialTextEdit.EditValue = administrativoInfo.Competencia.ToString
        competenciafinalTextEdit.EditValue = administrativoInfo.Competencia.ToString
        competenciainicialTextEdit.Text = administrativoInfo.Competencia.ToString
        competenciafinalTextEdit.Text = administrativoInfo.Competencia.ToString
    End Sub

    ''' <summary>
    ''' Obrigação Inicial
    ''' </summary>
    ''' <remarks>
    ''' Ao selecionar uma obrigação inicial no SearchLookUpEdit, ele faz uma busca da informação no InfoBindingSource para preencher a descrição no SimpleText.
    ''' </remarks>
    Private Sub obrigacaoinicialSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoinicialSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                descricaoinicialTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
            Else
                descricaoinicialTextEdit.Text = String.Empty
            End If
        Else
            descricaoinicialTextEdit.Text = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Obrigação final
    ''' </summary>
    ''' <remarks>
    ''' Ao selecionar uma obrigação final no SearchLookUpEdit, ele faz uma busca da informação no InfoBindingSource para preencher a descrição no SimpleText.
    ''' </remarks>
    Private Sub obrigacaofinalSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaofinalSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                descricaofinalTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
            Else
                descricaofinalTextEdit.Text = String.Empty
            End If
        Else
            descricaofinalTextEdit.Text = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Empresa Inicial
    ''' </summary>
    ''' <remarks>
    ''' Ao selecionar uma empresa inicial no SearchLookUpEdit, ele faz uma busca da informação no InfoBindingSource para preencher a descrição no SimpleText.
    ''' </remarks>
    Private Sub empresainicialSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresainicialSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                empresainicialTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
            Else
                empresainicialTextEdit.Text = String.Empty
            End If
        Else
            empresainicialTextEdit.Text = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Empresa Final
    ''' </summary>
    ''' <remarks>
    ''' Ao selecionar uma empresa final no SearchLookUpEdit, ele faz uma busca da informação no InfoBindingSource para preencher a descrição no SimpleText.
    ''' </remarks>
    Private Sub empresafinalSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresafinalSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                empresafinalTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
            Else
                empresafinalTextEdit.Text = String.Empty
            End If
        Else
            empresafinalTextEdit.Text = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Sincroniza Log 
    ''' </summary>
    ''' <remarks>
    ''' Verifica todas as obrigações que foram envidas via portal, e que não teve visualização, para verificar na WS se já foram visualizadas, e nesse caso é atualizado.
    ''' </remarks>
    Private Sub sincronizarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles sincronizarSimpleButton.Click
        Try
            Me.AcceptButton = Nothing
            Me.CancelButton = Nothing
            sincronizarSimpleButton.Enabled = False
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objSincronizarlogportal.BuscaControleAdministrativo(competenciainicialTextEdit.EditValue.ToString, competenciafinalTextEdit.EditValue.ToString, empresainicialSearchLookUpEdit.Text, empresafinalSearchLookUpEdit.Text, obrigacaoinicialSearchLookUpEdit.Text, obrigacaofinalSearchLookUpEdit.Text)
            SplashScreenManager.CloseForm()
            If XtraMessageBox.Show("Sincronização efetuada com sucesso. Deseja gerar um relatório das obrigações não sincronizadas?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    PreparaRelatorio()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            sincronizarSimpleButton.Enabled = True
        Catch ex As Exception
            sincronizarSimpleButton.Enabled = True
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.AcceptButton = sincronizarSimpleButton
        Me.CancelButton = sincronizarSimpleButton
    End Sub

    ''' <summary>
    ''' Voltar
    ''' </summary>
    ''' <remarks>
    ''' Fecha o form
    ''' </remarks>
    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Relatório
    ''' </summary>
    ''' <remarks>
    ''' Gera um relatorio de todas as obrigações que foram enviadas via portal, e não foram visualidas.
    ''' </remarks>
    Private Sub relatorioSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles relatorioSimpleButton.Click
        Try
            PreparaRelatorio()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Relatório
    ''' </summary>
    ''' <remarks>
    ''' Gera um relatorio de todas as obrigações que foram enviadas via portal, e não foram visualidas.
    ''' </remarks>
    Private Sub PreparaRelatorio()

        empresainicial = empresainicialSearchLookUpEdit.Text.Replace(".", "")
        empresafinal = empresafinalSearchLookUpEdit.Text.Replace(".", "")
        obrigacaoinicial = obrigacaoinicialSearchLookUpEdit.Text.Replace("-", "")
        obrigacaofinal = obrigacaofinalSearchLookUpEdit.Text.Replace("-", "")


        Try
            Dim report As New sincronizaportallogXtraReport()
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objSincronizarlogportal.Report(competenciainicialTextEdit.EditValue.ToString, competenciafinalTextEdit.EditValue.ToString, empresainicial, empresafinal, obrigacaoinicial, obrigacaofinal, report)

            Dim printTool As New ReportPrintTool(report)

            report.Parameters.Item("Sistema").Value = Application.ProductName
            report.Parameters.Item("Sistema").Visible = False

            printTool.AutoShowParametersPanel = False

            SplashScreenManager.CloseForm()
            printTool.ShowRibbonPreview()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class