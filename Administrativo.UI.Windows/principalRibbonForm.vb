
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers

Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Imports Administrativo.Modelo
Imports Administrativo.BLL

Public Class principalRibbonForm
   Dim blnErroFormLoad As Boolean = False

   Private Sub principalRibbonForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      Dim blnSelecionarDataBase As Boolean = False
      Dim objAdministrativo As New AdministrativoBLL

      ' Busca o ultimo skin configurado na máquina do usuário
      Dim objRegistro As New RegistroBLL
      Dim strValor As String = objRegistro.LocalizaChaveRegistro("Software", Application.ProductName, "skin")

      BonusSkins.Register()
      SkinManager.EnableFormSkins()
      SkinManager.EnableMdiFormSkins()
      LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
      UserLookAndFeel.Default.SetSkinStyle(strValor)
      SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem, True)

      objAdministrativo.VerificaVersao()
      If Environment.GetCommandLineArgs.Length > 1 Then
         Dim aParametros() As String = Environment.GetCommandLineArgs
         If Not String.IsNullOrEmpty(aParametros(1).ToString) Then
            Dim aLista() As String = aParametros(1).Split(Convert.ToChar("/"))
            For iLista = 0 To aLista.Length - 1
               If aLista(iLista).ToLower = "opt" Then
                  blnSelecionarDataBase = True
               ElseIf aLista(iLista).ToLower = "noportal" Then
                  administrativoInfo.DesconsideraPortal = True
               End If
            Next
         End If
      End If
      Try
         Dim objDataBase As New DataBaseBLL
         objDataBase.BuscaConfiguracaoBancoDados(Application.ProductName)
         If blnSelecionarDataBase Or (databaseInfo.Tipo = String.Empty And databaseInfo.BancoDados = String.Empty) Then
            Dim form As selecionardatabaseXtraForm = New selecionardatabaseXtraForm()
            form.ShowDialog(Me)
         End If
         If Not databaseInfo.Conexao Then
            Me.WindowState = FormWindowState.Maximized
            LogarUsuario(databaseInfo.Conexao)
            Exit Sub
         Else
            If objDataBase.ConectarDataBase() Then
               LogarUsuario(databaseInfo.Conexao)
               SelecionarExercicio()
               If administrativoInfo.Exercicio = 0 Then
                  Exit Sub
               Else
                  If administrativoInfo.Competencia = String.Empty Then
                     Exit Sub
                  End If
               End If

               dataBarStaticItem.Caption = "[" + Now.ToLongDateString() + "]"
            End If
         End If

         Dim objFiltro As New FiltroBLL
         objFiltro.CarregaFiltro()

         Dim objPortalServidor As New PortalServidorBLL
         objPortalServidor.BuscaConfiguracaoPortalServidor()

         Me.WindowState = FormWindowState.Maximized
         If administrativoInfo.DesconsideraPortal Then
            XtraMessageBox.Show("Acesso ao sistema parametrizado para não enviar as informações para o PORTAL", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
         If usuarioInfo.nivel = "AD" Then
            If menuRibbonControl.Items("monitoramentovencimentoBarButtonItem").Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
               menuRibbonControl.SelectedPage = menuRibbonControl.Pages(2)
               Dim form As monitoramentovencimentoXtraForm = New monitoramentovencimentoXtraForm()
               form.Show(Me)
            End If
         End If
         AlertaObrigacoes()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
         blnErroFormLoad = True
         Me.Close()
      End Try
   End Sub

   Private Sub principalRibbonForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
      If databaseInfo.Conexao Then
         If Not blnErroFormLoad Then
            If XtraMessageBox.Show("Tem certeza que deseja sair do sistema?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.No Then
               e.Cancel = True
               If Not usuarioInfo.Logado Then
                  LogarUsuario(databaseInfo.Conexao)
               End If
               If administrativoInfo.Exercicio = 0 Then
                  SelecionarExercicio()
               End If
               If administrativoInfo.Competencia = String.Empty Then
                  SelecionarCompetencia()
               End If
            End If
         End If
      End If
   End Sub

   Private Sub trocarusuarioBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles trocarusuarioBarButtonItem.ItemClick
      Try
         LogarUsuario(databaseInfo.Conexao)
         AlertaObrigacoes()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub trocarexercicioBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles trocarexercicioBarButtonItem.ItemClick
      Try
         SelecionarExercicio()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub trocarcompetenciaBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles trocarcompetenciaBarButtonItem.ItemClick
      Try
         SelecionarCompetencia()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub skinRibbonGalleryBarItem_GalleryItemClick(sender As System.Object, e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles skinRibbonGalleryBarItem.GalleryItemClick
      Dim objRegistro As New RegistroBLL

      objRegistro.GravaChaveRegistro("Software", Application.ProductName, "skin", e.Item.Tag.ToString)
   End Sub

   Private Sub usuariosBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles usuariosBarButtonItem.ItemClick
      Dim form As usuariosXtraForm = New usuariosXtraForm()
      form.Show(Me)
   End Sub

   Private Sub gruposacessoBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles gruposacessoBarButtonItem.ItemClick
      Dim form As gruposacessoXtraForm = New gruposacessoXtraForm()
      form.Show(Me)
   End Sub

   Private Sub obrigacoesBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles obrigacoesBarButtonItem.ItemClick
      Dim form As obrigacoesXtraForm = New obrigacoesXtraForm()
      form.Show(Me)
   End Sub

   Private Sub obrigacoesrelatorioBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles obrigacoesrelatorioBarButtonItem.ItemClick
      Dim form As obrigacoesrelatorioXtraForm = New obrigacoesrelatorioXtraForm()
      form.Show(Me)
   End Sub

   Private Sub obrigacoesusuarioBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles obrigacoesusuarioBarButtonItem.ItemClick
      Dim form As obrigacoesusuarioXtraForm = New obrigacoesusuarioXtraForm()
      form.Show(Me)
   End Sub

   Private Sub empresaobrigacoesBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles empresaobrigacoesBarButtonItem.ItemClick
      Dim form As empresaobrigacoesXtraForm = New empresaobrigacoesXtraForm()
      form.Show(Me)
   End Sub

   Private Sub empresaobrigacoesrelatorioBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles empresaobrigacoesrelatorioBarButtonItem.ItemClick
      Dim form As empresaobrigacoesrelarioXtraForm = New empresaobrigacoesrelarioXtraForm()
      form.Show(Me)
   End Sub

   Private Sub empresaobrigacoesgeracaoBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles empresaobrigacoesgeracaoBarButtonItem.ItemClick
      Dim form As empresaobrigacoesgeracaoXtraForm = New empresaobrigacoesgeracaoXtraForm()
      form.Show(Me)
   End Sub

   Private Sub regrasBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles regrasBarButtonItem.ItemClick
      Dim form As regrasXtraForm = New regrasXtraForm()
      form.Show(Me)
   End Sub

   Private Sub regrasrelatorioBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles regrasrelatorioBarButtonItem.ItemClick
      Dim form As regrasrelatorioXtraForm = New regrasrelatorioXtraForm()
      form.Show(Me)
   End Sub

   Private Sub regrasgerarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles regrasgerarBarButtonItem.ItemClick
      Dim form As regrasgeracaoXtraForm = New regrasgeracaoXtraForm()
      form.Show(Me)
   End Sub

   Private Sub monitoramentoBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles monitoramentoBarButtonItem.ItemClick
      Dim form As monitoramentoXtraForm = New monitoramentoXtraForm()
      form.Show(Me)
   End Sub

   Private Sub monitoramentovencimentoBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles monitoramentovencimentoBarButtonItem.ItemClick
      Dim form As monitoramentovencimentoXtraForm = New monitoramentovencimentoXtraForm()
      form.Show(Me)
   End Sub

   Private Sub monitoramentologBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles monitoramentologBarButtonItem.ItemClick
      Dim form As monitoramentologXtraForm = New monitoramentologXtraForm()
      form.Show(Me)
   End Sub

   Private Sub tarefasextrasBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tarefasextrasBarButtonItem.ItemClick
      Dim form As tarefasextrasXtraForm = New tarefasextrasXtraForm()
      form.Show(Me)
   End Sub

   Private Sub parcelamentoBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles parcelamentoBarButtonItem.ItemClick
      Dim form As parcelamentoXtraForm = New parcelamentoXtraForm()
      form.Show(Me)
   End Sub

   Private Sub manutencaoBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles manutencaoBarButtonItem.ItemClick
      Dim form As manutencaoobrigacoesXtraForm = New manutencaoobrigacoesXtraForm()
      form.Show(Me)
   End Sub

   Private Sub cndBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cndBarButtonItem.ItemClick
      Dim form As cndXtraForm = New cndXtraForm()
      form.Show(Me)
   End Sub

   Private Sub servidorBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles servidorBarButtonItem.ItemClick
      If Not administrativoInfo.DesconsideraPortal Then
         Dim form As portalservidorXtraForm = New portalservidorXtraForm()
         form.Show(Me)
      Else
         XtraMessageBox.Show("A utilização do Portal foi desabilitada na carga do sistema. Favor entrar em contato com o Técnico da empresa.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub usuariosempresasBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles usuariosempresasBarButtonItem.ItemClick
      If Not administrativoInfo.DesconsideraPortal Then
         Dim form As portalusuariosXtraForm = New portalusuariosXtraForm()
         form.Show(Me)
      Else
         XtraMessageBox.Show("A utilização do Portal foi desabilitada na carga do sistema. Favor entrar em contato com o Técnico da empresa.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub feriadosBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles feriadosBarButtonItem.ItemClick
      Dim form As feriadosXtraForm = New feriadosXtraForm()
      form.Show(Me)
   End Sub

   Private Sub maladiretaBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles maladiretaBarButtonItem.ItemClick
      Dim form As maladiretaXtraform = New maladiretaXtraform()
      form.Show(Me)
   End Sub

   Private Sub logportalBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles logportalBarButtonItem.ItemClick
      If Not administrativoInfo.DesconsideraPortal Then
         Dim form As sincronizarlogportalXtraForm = New sincronizarlogportalXtraForm()
         form.Show(Me)
      Else
         XtraMessageBox.Show("A utilização do Portal foi desabilitada na carga do sistema. Favor entrar em contato com o Técnico da empresa.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub LogarUsuario(pNaoConectou As Boolean)
      If Not pNaoConectou Then
         For index = 0 To menuRibbonControl.Pages.Count - 1
            menuRibbonControl.Pages(index).Visible = False
         Next
         XtraMessageBox.Show("O sistema deverá ser encerrado devido a falta de conexão com o Banco de Dados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Else
         Dim form As selecionarusuarioXtraForm = New selecionarusuarioXtraForm()
         form.ShowDialog(Me)
         If Not usuarioInfo.logado Then
            Me.Close()
         End If
         usuarioBarStaticItem.Caption = "[" + usuarioInfo.usuario + "]"
         Dim objUsuario As New UsuarioBLL
         Dim infoGrupoAcesso As New usuariogruposacessoInfo

         infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario()

         grupoBarStaticItem.Caption = "[" + infoGrupoAcesso.grupo + "]"
         usuarioInfo.grupo = infoGrupoAcesso.grupo

         If menuRibbonControl.Pages.Count > 0 Then
            For index = 0 To menuRibbonControl.Pages.Count - 1
               If menuRibbonControl.Pages(index).Tag IsNot Nothing Then
                  menuRibbonControl.Pages(index).Visible = objUsuario.UsuarioTemAcesso(infoGrupoAcesso, menuRibbonControl.Pages(index).Tag.ToString)
                  If menuRibbonControl.Pages(index).Visible Then
                     If menuRibbonControl.Pages(index).Groups.Count > 0 Then
                        For intGroup = 0 To menuRibbonControl.Pages(index).Groups.Count - 1
                           If menuRibbonControl.Pages(index).Groups(intGroup).Tag IsNot Nothing Then
                              menuRibbonControl.Pages(index).Groups(intGroup).Visible = objUsuario.UsuarioTemAcesso(infoGrupoAcesso, menuRibbonControl.Pages(index).Groups(intGroup).Tag.ToString)
                           End If
                        Next
                     End If
                  End If
               End If
            Next
         End If
         If menuRibbonControl.Items.Count > 0 Then
            For index = 0 To menuRibbonControl.Items.Count - 1
               If menuRibbonControl.Items(index).Tag IsNot Nothing Then
                  If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, menuRibbonControl.Items(index).Tag.ToString) Then
                     menuRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                  Else
                     menuRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                  End If
               End If
            Next
         End If
      End If
   End Sub

   Private Sub SelecionarExercicio()
      If usuarioInfo.nivel = "AD" Then
         administrativoInfo.Exercicio = Now.Year
      Else
         Dim form As selecionarexercicioXtraForm = New selecionarexercicioXtraForm()
         form.ShowDialog(Me)
      End If
      If administrativoInfo.Exercicio = 0 Then
         Me.Close()
      Else
         exercicioBarStaticItem.Caption = "[" + administrativoInfo.Exercicio.ToString() + "]"
         If administrativoInfo.Competencia = String.Empty Then
            competenciaBarStaticItem.Caption = String.Empty
            SelecionarCompetencia()
         End If
      End If
   End Sub

   Private Sub SelecionarCompetencia()
      If usuarioInfo.nivel = "AD" Then
         If Now.Month.ToString.Length = 1 Then
            administrativoInfo.Competencia = "0" + Now.Month.ToString
         Else
            administrativoInfo.Competencia = Now.Month.ToString
         End If
         administrativoInfo.Competencia += Now.Year.ToString
      Else
         Dim form As selecionarcompetenciaXtraForm = New selecionarcompetenciaXtraForm()
         form.ShowDialog(Me)
      End If
      If administrativoInfo.Competencia = String.Empty Then
         Me.Close()
      End If
      competenciaBarStaticItem.Caption = "[" + administrativoInfo.Competencia.Substring(0, 2) + "/" + administrativoInfo.Competencia.Substring(2, 4) + "]"
   End Sub

   Private Sub AlertaObrigacoes()
      Try
         If usuarioInfo.alertarvencimento Then
            Dim infoAlertaObrigacao As New manutencaoobrigacoesalerta
            Dim objManutencaoObrigacao As New ManutencaoObrigacoesBLL
            infoAlertaObrigacao = objManutencaoObrigacao.BuscaAlertas

            For index = 0 To infoAlertaObrigacao.alertas.Count - 1
               alertarvencimentoobrigacaoAlertControl.Show(Me.FindForm(), infoAlertaObrigacao.alertas(index).titulo, infoAlertaObrigacao.alertas(index).descricao, String.Empty, alertaImageCollection.Images(0), infoAlertaObrigacao.alertas(index).tag, True)
            Next
         End If
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Private Sub alertarvencimentoobrigacaoAlertControl_ButtonClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs) Handles alertarvencimentoobrigacaoAlertControl.ButtonClick
      Dim form As manutencaoobrigacoesXtraForm = New manutencaoobrigacoesXtraForm(e.Info.Tag.ToString)
      form.Show(Me)
   End Sub

   Private Sub alertarvencimentoobrigacaoAlertControl_BeforeFormShow(sender As Object, e As DevExpress.XtraBars.Alerter.AlertFormEventArgs) Handles alertarvencimentoobrigacaoAlertControl.BeforeFormShow
      e.AlertForm.Size = New Size(380, 120)
   End Sub

   Private Sub manualBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles manualBarButtonItem.ItemClick
      Dim form As manualsistemaXtraForm = New manualsistemaXtraForm(Application.StartupPath + "\ManualSistema.pdf")
      form.Show(Me)
   End Sub

   Private Sub historicoalteracoesBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles historicoalteracoesBarButtonItem.ItemClick
      Dim form As historicoalteracoesXtraForm = New historicoalteracoesXtraForm(Application.StartupPath + "\HistoricoAlteracoes.pdf")
      form.Show(Me)
   End Sub
End Class