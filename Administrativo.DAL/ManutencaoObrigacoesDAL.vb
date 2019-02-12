Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class ManutencaoObrigacoesDAL
    Implements IManutencaoObrigacoes

    Private edit As RepositoryItemTextEdit
    Private image As RepositoryItemImageComboBox

    Private Enum enuValidaPortal
        Empresas
        UsuariosEmpresas
        UsuariosEscritorios
        Obrigacoes
    End Enum


    Public Sub Grid(ByRef penuGrid As enuGridManutecaoObrigacao, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView) Implements IManutencaoObrigacoes.Grid
        Try
            If penuGrid = enuGridManutecaoObrigacao.Funcionario Then
                pdgGrid.DataSource = infoManutencaoObrigacoes.cagedmensal

                ' Definição de Máscaras no Grid
                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = True
                edit.Mask.EditMask = "00.0000"
                pgvGrid.Columns(0).ColumnEdit = edit
                pgvGrid.Columns(0).Caption = "Funcionário"
                pgvGrid.Columns(0).Width = 75

                pgvGrid.Columns(1).Caption = "Nome"
                pgvGrid.Columns(1).Width = 450

                pgvGrid.Columns(2).Visible = False
                pgvGrid.Columns(3).Visible = False
            ElseIf penuGrid = enuGridManutecaoObrigacao.PortalLog Then
                pdgGrid.DataSource = infoManutencaoObrigacoes.portallog

                pgvGrid.Columns(0).Caption = "Nome"
                pgvGrid.Columns(0).Width = 150

                pgvGrid.Columns(1).Caption = "Email"
                pgvGrid.Columns(1).Width = 300

                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.DateTime
                edit.Mask.UseMaskAsDisplayFormat = True
                pgvGrid.Columns(2).ColumnEdit = edit
                pgvGrid.Columns(2).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
                pgvGrid.Columns(2).Width = 115
                pgvGrid.Columns(3).Visible = False
                pgvGrid.Columns(4).Visible = False
                pgvGrid.Columns(5).Visible = False
            End If
            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridIcmsst As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheIcmsst As DevExpress.XtraGrid.Views.Grid.GridView, picStatusImageColection As DevExpress.Utils.ImageCollection, picTipoEnvioImageColection As DevExpress.Utils.ImageCollection, picVisualizacaoImageColection As DevExpress.Utils.ImageCollection) Implements IManutencaoObrigacoes.Grid
        Try
            Dim objDataBase As New DataBaseDAL

            Dim sdMonitoramento As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)
            Dim dsMonitoramento As New DataSet()
            Dim dtMonitoramento As New DataTable("manutencao")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtMonitoramento.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtMonitoramento)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drMonitoramento As DataRow = dsMonitoramento.Tables("manutencao").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drMonitoramento(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("manutencao").Rows.Add(drMonitoramento)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtEmpresa As New DataTable("empresa")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtEmpresa.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtEmpresa)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drEmpresa As DataRow = dsMonitoramento.Tables("empresa").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drEmpresa(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("empresa").Rows.Add(drEmpresa)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(2).ToString)
            Dim dtFuncionario As New DataTable("funcionario")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtFuncionario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtFuncionario)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drFuncionario As DataRow = dsMonitoramento.Tables("funcionario").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drFuncionario(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("funcionario").Rows.Add(drFuncionario)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(3).ToString)
            Dim dtDetalheFuncionario As New DataTable("detalhefuncionario")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtDetalheFuncionario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtDetalheFuncionario)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drDetalheFuncionario As DataRow = dsMonitoramento.Tables("detalhefuncionario").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drDetalheFuncionario(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("detalhefuncionario").Rows.Add(drDetalheFuncionario)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(4).ToString)
            Dim dtInforme As New DataTable("informe")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtInforme.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtInforme)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drInforme As DataRow = dsMonitoramento.Tables("informe").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drInforme(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("informe").Rows.Add(drInforme)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(5).ToString)
            Dim dtDetalheInforme As New DataTable("detalheinforme")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtDetalheInforme.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtDetalheInforme)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drDetalheInforme As DataRow = dsMonitoramento.Tables("detalheinforme").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drDetalheInforme(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("detalheinforme").Rows.Add(drDetalheInforme)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(6).ToString)
            Dim dtIcmsst As New DataTable("entradasivaguias")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtIcmsst.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtIcmsst)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drIcmsst As DataRow = dsMonitoramento.Tables("entradasivaguias").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drIcmsst(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("entradasivaguias").Rows.Add(drIcmsst)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(7).ToString)
            Dim dtDetalheIcmsst As New DataTable("detalheicmsst")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtDetalheIcmsst.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtDetalheIcmsst)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drDetalheIcmsst As DataRow = dsMonitoramento.Tables("detalheicmsst").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drDetalheIcmsst(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("detalheicmsst").Rows.Add(drDetalheIcmsst)
            Next

            Dim keyColumnEmpresa As DataColumn = dsMonitoramento.Tables("manutencao").Columns("empresa")
            Dim keyColumnCompetencia As DataColumn = dsMonitoramento.Tables("manutencao").Columns("competencia")

            Dim foreignKeyColumnEmpresaEmp As DataColumn = dsMonitoramento.Tables("empresa").Columns("empresa")
            Dim foreignKeyColumnEmpresaCom As DataColumn = dsMonitoramento.Tables("empresa").Columns("competencia")

            Dim foreignKeyColumnFuncionarioEmp As DataColumn = dsMonitoramento.Tables("funcionario").Columns("empresa")
            Dim foreignKeyColumnFuncionarioCom As DataColumn = dsMonitoramento.Tables("funcionario").Columns("competencia")

            Dim foreignKeyColumnInformeEmp As DataColumn = dsMonitoramento.Tables("informe").Columns("empresa")
            Dim foreignKeyColumnInformeCom As DataColumn = dsMonitoramento.Tables("informe").Columns("competencia")

            Dim foreignKeyColumnIcmsstEmp As DataColumn = dsMonitoramento.Tables("entradasivaguias").Columns("empresa")
            Dim foreignKeyColumnIcmsstCom As DataColumn = dsMonitoramento.Tables("entradasivaguias").Columns("competencia")

            dsMonitoramento.Relations.Add("ManutencaoObrigacao", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnEmpresaEmp, foreignKeyColumnEmpresaCom})
            dsMonitoramento.Relations.Add("ManutencaoFuncionario", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnFuncionarioEmp, foreignKeyColumnFuncionarioCom})
            dsMonitoramento.Relations.Add("ManutencaoInforme", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnInformeEmp, foreignKeyColumnInformeCom})
            dsMonitoramento.Relations.Add("ManutencaoIcmsst", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnIcmsstEmp, foreignKeyColumnIcmsstCom})

            Dim KeyColumnFuncionarioEmp As DataColumn = dsMonitoramento.Tables("funcionario").Columns("empresa")
            Dim keyColumnfuncionarioFun As DataColumn = dsMonitoramento.Tables("funcionario").Columns("funcionario")
            Dim KeyColumnFuncionarioCom As DataColumn = dsMonitoramento.Tables("funcionario").Columns("competencia")

            Dim foreignKeyColumnDetFunEmp As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("empresa")
            Dim foreignKeyColumnDetFunFun As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("funcionario")
            Dim foreignKeyColumnDetFunCom As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("competencia")

            dsMonitoramento.Relations.Add("DetalheFuncionario", {KeyColumnFuncionarioEmp, keyColumnfuncionarioFun, KeyColumnFuncionarioCom}, {foreignKeyColumnDetFunEmp, foreignKeyColumnDetFunFun, foreignKeyColumnDetFunCom})

            Dim keyColumnInformeEmp As DataColumn = dsMonitoramento.Tables("informe").Columns("empresa")
            Dim keyColumnInformeCom As DataColumn = dsMonitoramento.Tables("informe").Columns("competencia")
            Dim keyColumnInformeInf As DataColumn = dsMonitoramento.Tables("informe").Columns("cnpjcpfinforme")
            Dim keyColumnInformeNom As DataColumn = dsMonitoramento.Tables("informe").Columns("nome")

            Dim foreignKeyColumnDetInfEmp As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("empresa")
            Dim foreignKeyColumnDetInfCom As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("competencia")
            Dim foreignKeyColumnDetInfInf As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("cnpjcpfinforme")
            Dim foreignKeyColumnDetInfNom As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("nome")

            dsMonitoramento.Relations.Add("DetalheInforme", {keyColumnInformeEmp, keyColumnInformeCom, keyColumnInformeInf, keyColumnInformeNom}, {foreignKeyColumnDetInfEmp, foreignKeyColumnDetInfCom, foreignKeyColumnDetInfInf, foreignKeyColumnDetInfNom})

            Dim keyColumnIcmsstEmp As DataColumn = dsMonitoramento.Tables("entradasivaguias").Columns("empresa")
            Dim keyColumnIcmsstCom As DataColumn = dsMonitoramento.Tables("entradasivaguias").Columns("competencia")
            Dim keyColumnIcmsstInf As DataColumn = dsMonitoramento.Tables("entradasivaguias").Columns("parcela")
            Dim keyColumnIcmsstNom As DataColumn = dsMonitoramento.Tables("entradasivaguias").Columns("razaosocial")

            Dim foreignKeyColumnDetIcmEmp As DataColumn = dsMonitoramento.Tables("detalheicmsst").Columns("empresa")
            Dim foreignKeyColumnDetIcmCom As DataColumn = dsMonitoramento.Tables("detalheicmsst").Columns("competencia")
            Dim foreignKeyColumnDetIcmInf As DataColumn = dsMonitoramento.Tables("detalheicmsst").Columns("parcela")
            Dim foreignKeyColumnDetIcmNom As DataColumn = dsMonitoramento.Tables("detalheicmsst").Columns("razaosocial")

            dsMonitoramento.Relations.Add("DetalheIcmsst", {keyColumnIcmsstEmp, keyColumnIcmsstCom, keyColumnIcmsstInf, keyColumnIcmsstNom}, {foreignKeyColumnDetIcmEmp, foreignKeyColumnDetIcmCom, foreignKeyColumnDetIcmInf, foreignKeyColumnDetIcmNom})

            pdgGrid.DataSource = dsMonitoramento.Tables("manutencao")
            pdgGrid.ForceInitialize()
            pgvGrid.ViewCaption = "Manutenção das Obrigações"
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvGrid.OptionsCustomization.AllowQuickHideColumns = False
            pgvGrid.OptionsCustomization.AllowColumnResizing = False
            pgvGrid.OptionsCustomization.AllowColumnMoving = False
            pgvGrid.OptionsCustomization.AllowGroup = False
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            ' Definição de Máscaras no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Empresa"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Razão Social"
            pgvGrid.Columns(1).Width = 320

            pgvGrid.Columns(2).Caption = "CNPJ"
            pgvGrid.Columns(2).Width = 130

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGrid.Columns(3).ColumnEdit = edit
            pgvGrid.Columns(3).Caption = "Fato Gerador"
            pgvGrid.Columns(3).Width = 85

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGrid.Columns(4).ColumnEdit = image
            pgvGrid.Columns(4).Caption = "Status"
            pgvGrid.Columns(4).Width = 120

            pdgGrid.LevelTree.Nodes(0).RelationName = "ManutencaoObrigacao"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridEmpresa
            pgvGridEmpresa.ViewCaption = "Detalhes"
            pgvGridEmpresa.PopulateColumns(dsMonitoramento.Tables("empresa"))
            pgvGridEmpresa.OptionsView.ShowGroupPanel = False
            pgvGridEmpresa.OptionsBehavior.Editable = False
            pgvGridEmpresa.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridEmpresa.OptionsCustomization.AllowColumnResizing = False
            pgvGridEmpresa.OptionsCustomization.AllowColumnMoving = False
            pgvGridEmpresa.OptionsCustomization.AllowGroup = False
            pgvGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvGridEmpresa.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridEmpresa.ColumnPanelRowHeight = 60
            pgvGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvGridEmpresa.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridEmpresa.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridEmpresa.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridEmpresa.Columns(0).Visible = False
            pgvGridEmpresa.Columns(15).Visible = False
            pgvGridEmpresa.Columns(16).Visible = False
            pgvGridEmpresa.Columns(17).Visible = False
            pgvGridEmpresa.Columns(18).Visible = False
            pgvGridEmpresa.Columns(19).Visible = False
            pgvGridEmpresa.Columns(20).Visible = False
            pgvGridEmpresa.Columns(21).Visible = False
            pgvGridEmpresa.Columns(22).Visible = False
            pgvGridEmpresa.Columns(23).Visible = False
            pgvGridEmpresa.Columns(24).Visible = False

            ' Definição de Máscaras no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridEmpresa.Columns(1).ColumnEdit = edit
            pgvGridEmpresa.Columns(1).Caption = "Obrigação"
            pgvGridEmpresa.Columns(1).Width = 70

            pgvGridEmpresa.Columns(2).Caption = "Descrição"
            pgvGridEmpresa.Columns(2).Width = 230

            pgvGridEmpresa.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridEmpresa.Columns(3).Width = 75

            pgvGridEmpresa.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridEmpresa.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(5).ColumnEdit = edit
            pgvGridEmpresa.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridEmpresa.Columns(5).Width = 115

            pgvGridEmpresa.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridEmpresa.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(7).ColumnEdit = edit
            pgvGridEmpresa.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridEmpresa.Columns(7).Width = 115

            pgvGridEmpresa.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridEmpresa.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(9).ColumnEdit = edit
            pgvGridEmpresa.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridEmpresa.Columns(9).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridEmpresa.Columns(10).ColumnEdit = image
            pgvGridEmpresa.Columns(10).Caption = "Status"
            pgvGridEmpresa.Columns(10).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picTipoEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("E-mail", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Malote", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Site", 3, 3))
            pgvGridEmpresa.Columns(11).ColumnEdit = image
            pgvGridEmpresa.Columns(11).Caption = "Tipo Envio"
            pgvGridEmpresa.Columns(11).Width = 120


            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizacaoImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Sem Envio", 3, 3))
            pgvGridEmpresa.Columns(12).ColumnEdit = image
            pgvGridEmpresa.Columns(12).Caption = "Status Visualização"
            pgvGridEmpresa.Columns(12).Width = 120

            pgvGridEmpresa.Columns(13).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvGridEmpresa.Columns(13).Width = 115

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(14).ColumnEdit = edit
            pgvGridEmpresa.Columns(14).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvGridEmpresa.Columns(14).Width = 115

            pdgGrid.LevelTree.Nodes(1).RelationName = "ManutencaoFuncionario"
            pdgGrid.LevelTree.Nodes(1).LevelTemplate = pgvGridFuncionario
            pgvGridFuncionario.ViewCaption = "Funcionários"
            pgvGridFuncionario.PopulateColumns(dsMonitoramento.Tables("funcionario"))
            pgvGridFuncionario.OptionsView.ShowGroupPanel = False
            pgvGridFuncionario.OptionsBehavior.Editable = False
            pgvGridFuncionario.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridFuncionario.OptionsCustomization.AllowColumnResizing = False
            pgvGridFuncionario.OptionsCustomization.AllowColumnMoving = False
            pgvGridFuncionario.OptionsCustomization.AllowGroup = False
            pgvGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvGridFuncionario.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridFuncionario.ColumnPanelRowHeight = 60
            pgvGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvGridFuncionario.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridFuncionario.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridFuncionario.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridFuncionario.Columns(0).Visible = False
            pgvGridFuncionario.Columns(3).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGridFuncionario.Columns(1).ColumnEdit = edit
            pgvGridFuncionario.Columns(1).Caption = "Funcionário"
            pgvGridFuncionario.Columns(1).Width = 75

            pgvGridFuncionario.Columns(2).Caption = "Nome"
            pgvGridFuncionario.Columns(2).Width = 400

            pdgGrid.LevelTree.Nodes(1).Nodes(0).RelationName = "DetalheFuncionario"
            pdgGrid.LevelTree.Nodes(1).Nodes(0).LevelTemplate = pgvGridDetalheFuncionario
            pgvGridDetalheFuncionario.ViewCaption = "Detalhes"
            pgvGridDetalheFuncionario.PopulateColumns(dsMonitoramento.Tables("detalhefuncionario"))
            pgvGridDetalheFuncionario.OptionsView.ShowGroupPanel = False
            pgvGridDetalheFuncionario.OptionsBehavior.Editable = False
            pgvGridDetalheFuncionario.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridDetalheFuncionario.OptionsCustomization.AllowColumnResizing = False
            pgvGridDetalheFuncionario.OptionsCustomization.AllowColumnMoving = False
            pgvGridDetalheFuncionario.OptionsCustomization.AllowGroup = False
            pgvGridDetalheFuncionario.OptionsView.ColumnAutoWidth = False
            pgvGridDetalheFuncionario.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridDetalheFuncionario.ColumnPanelRowHeight = 60
            pgvGridDetalheFuncionario.OptionsView.ColumnAutoWidth = False
            pgvGridDetalheFuncionario.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridDetalheFuncionario.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridDetalheFuncionario.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridDetalheFuncionario.Columns(0).Visible = False
            pgvGridDetalheFuncionario.Columns(15).Visible = False
            pgvGridDetalheFuncionario.Columns(16).Visible = False
            pgvGridDetalheFuncionario.Columns(17).Visible = False
            pgvGridDetalheFuncionario.Columns(18).Visible = False
            pgvGridDetalheFuncionario.Columns(19).Visible = False
            pgvGridDetalheFuncionario.Columns(20).Visible = False
            pgvGridDetalheFuncionario.Columns(21).Visible = False
            pgvGridDetalheFuncionario.Columns(22).Visible = False
            pgvGridDetalheFuncionario.Columns(23).Visible = False
            pgvGridDetalheFuncionario.Columns(24).Visible = False
            pgvGridDetalheFuncionario.Columns(25).Visible = False

            ' Definição de Máscaras no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridDetalheFuncionario.Columns(1).ColumnEdit = edit
            pgvGridDetalheFuncionario.Columns(1).Caption = "Obrigação"
            pgvGridDetalheFuncionario.Columns(1).Width = 70

            pgvGridDetalheFuncionario.Columns(2).Caption = "Descrição"
            pgvGridDetalheFuncionario.Columns(2).Width = 230

            pgvGridDetalheFuncionario.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridDetalheFuncionario.Columns(3).Width = 75

            pgvGridDetalheFuncionario.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridDetalheFuncionario.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheFuncionario.Columns(5).ColumnEdit = edit
            pgvGridDetalheFuncionario.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridDetalheFuncionario.Columns(5).Width = 115

            pgvGridDetalheFuncionario.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridDetalheFuncionario.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheFuncionario.Columns(7).ColumnEdit = edit
            pgvGridDetalheFuncionario.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridDetalheFuncionario.Columns(7).Width = 115

            pgvGridDetalheFuncionario.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridDetalheFuncionario.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheFuncionario.Columns(9).ColumnEdit = edit
            pgvGridDetalheFuncionario.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridDetalheFuncionario.Columns(9).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridDetalheFuncionario.Columns(10).ColumnEdit = image
            pgvGridDetalheFuncionario.Columns(10).Caption = "Status"
            pgvGridDetalheFuncionario.Columns(10).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picTipoEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("E-mail", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Malote", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Site", 3, 3))
            pgvGridDetalheFuncionario.Columns(11).ColumnEdit = image
            pgvGridDetalheFuncionario.Columns(11).Caption = "Tipo Envio"
            pgvGridDetalheFuncionario.Columns(11).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizacaoImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Sem Envio", 3, 3))
            pgvGridDetalheFuncionario.Columns(12).ColumnEdit = image
            pgvGridDetalheFuncionario.Columns(12).Caption = "Status Visualização"
            pgvGridDetalheFuncionario.Columns(12).Width = 120

            pgvGridDetalheFuncionario.Columns(13).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvGridDetalheFuncionario.Columns(13).Width = 115

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheFuncionario.Columns(14).ColumnEdit = edit
            pgvGridDetalheFuncionario.Columns(14).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvGridDetalheFuncionario.Columns(14).Width = 115

            pdgGrid.LevelTree.Nodes(2).RelationName = "ManutencaoInforme"
            pdgGrid.LevelTree.Nodes(2).LevelTemplate = pgvGridInforme
            pgvGridInforme.ViewCaption = "Informes"
            pgvGridInforme.PopulateColumns(dsMonitoramento.Tables("informe"))
            pgvGridInforme.OptionsView.ShowGroupPanel = False
            pgvGridInforme.OptionsBehavior.Editable = False
            pgvGridInforme.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridInforme.OptionsCustomization.AllowColumnResizing = False
            pgvGridInforme.OptionsCustomization.AllowColumnMoving = False
            pgvGridInforme.OptionsCustomization.AllowGroup = False
            pgvGridInforme.OptionsView.ColumnAutoWidth = False
            pgvGridInforme.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridInforme.ColumnPanelRowHeight = 60
            pgvGridInforme.OptionsView.ColumnAutoWidth = False
            pgvGridInforme.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridInforme.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridInforme.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridInforme.Columns(0).Visible = False

            pgvGridInforme.Columns(1).Caption = "CNPJ/CPF"
            pgvGridInforme.Columns(1).Width = 130

            pgvGridInforme.Columns(2).Caption = "Nome"
            pgvGridInforme.Columns(2).Width = 400

            pgvGridInforme.Columns(3).Visible = False

            pdgGrid.LevelTree.Nodes(2).Nodes(0).RelationName = "DetalheInforme"
            pdgGrid.LevelTree.Nodes(2).Nodes(0).LevelTemplate = pgvGridDetalheInforme
            pgvGridDetalheInforme.ViewCaption = "Detalhes"
            pgvGridDetalheInforme.PopulateColumns(dsMonitoramento.Tables("detalheinforme"))
            pgvGridDetalheInforme.OptionsView.ShowGroupPanel = False
            pgvGridDetalheInforme.OptionsBehavior.Editable = False
            pgvGridDetalheInforme.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridDetalheInforme.OptionsCustomization.AllowColumnResizing = False
            pgvGridDetalheInforme.OptionsCustomization.AllowColumnMoving = False
            pgvGridDetalheInforme.OptionsCustomization.AllowGroup = False
            pgvGridDetalheInforme.OptionsView.ColumnAutoWidth = False
            pgvGridDetalheInforme.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridDetalheInforme.ColumnPanelRowHeight = 60
            pgvGridDetalheInforme.OptionsView.ColumnAutoWidth = False
            pgvGridDetalheInforme.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridDetalheInforme.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridDetalheInforme.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridDetalheInforme.Columns(0).Visible = False
            pgvGridDetalheInforme.Columns(15).Visible = False
            pgvGridDetalheInforme.Columns(16).Visible = False
            pgvGridDetalheInforme.Columns(17).Visible = False
            pgvGridDetalheInforme.Columns(18).Visible = False
            pgvGridDetalheInforme.Columns(19).Visible = False
            pgvGridDetalheInforme.Columns(20).Visible = False
            pgvGridDetalheInforme.Columns(21).Visible = False
            pgvGridDetalheInforme.Columns(22).Visible = False
            pgvGridDetalheInforme.Columns(23).Visible = False
            pgvGridDetalheInforme.Columns(24).Visible = False
            pgvGridDetalheInforme.Columns(25).Visible = False
            pgvGridDetalheInforme.Columns(26).Visible = False
            pgvGridDetalheInforme.Columns(27).Visible = False
            pgvGridDetalheInforme.Columns(28).Visible = False
            pgvGridDetalheInforme.Columns(29).Visible = False

            ' Definição de Máscaras no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridDetalheInforme.Columns(1).ColumnEdit = edit
            pgvGridDetalheInforme.Columns(1).Caption = "Obrigação"
            pgvGridDetalheInforme.Columns(1).Width = 70

            pgvGridDetalheInforme.Columns(2).Caption = "Descrição"
            pgvGridDetalheInforme.Columns(2).Width = 230

            pgvGridDetalheInforme.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridDetalheInforme.Columns(3).Width = 75

            pgvGridDetalheInforme.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridDetalheInforme.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheInforme.Columns(5).ColumnEdit = edit
            pgvGridDetalheInforme.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridDetalheInforme.Columns(5).Width = 115

            pgvGridDetalheInforme.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridDetalheInforme.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheInforme.Columns(7).ColumnEdit = edit
            pgvGridDetalheInforme.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridDetalheInforme.Columns(7).Width = 115

            pgvGridDetalheInforme.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridDetalheInforme.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheInforme.Columns(9).ColumnEdit = edit
            pgvGridDetalheInforme.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridDetalheInforme.Columns(9).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridDetalheInforme.Columns(10).ColumnEdit = image
            pgvGridDetalheInforme.Columns(10).Caption = "Status"
            pgvGridDetalheInforme.Columns(10).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picTipoEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("E-mail", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Malote", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Site", 3, 3))
            pgvGridDetalheInforme.Columns(11).ColumnEdit = image
            pgvGridDetalheInforme.Columns(11).Caption = "Tipo Envio"
            pgvGridDetalheInforme.Columns(11).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizacaoImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Sem Envio", 3, 3))
            pgvGridDetalheInforme.Columns(12).ColumnEdit = image
            pgvGridDetalheInforme.Columns(12).Caption = "Status Visualização"
            pgvGridDetalheInforme.Columns(12).Width = 120

            pgvGridDetalheInforme.Columns(13).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvGridDetalheInforme.Columns(13).Width = 115

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheInforme.Columns(14).ColumnEdit = edit
            pgvGridDetalheInforme.Columns(14).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvGridDetalheInforme.Columns(14).Width = 115

            pdgGrid.LevelTree.Nodes(3).RelationName = "ManutencaoIcmsst"
            pdgGrid.LevelTree.Nodes(3).LevelTemplate = pgvGridIcmsst
            pgvGridIcmsst.ViewCaption = "ICMS ST"
            pgvGridIcmsst.PopulateColumns(dsMonitoramento.Tables("entradasivaguias"))
            pgvGridIcmsst.OptionsView.ShowGroupPanel = False
            pgvGridIcmsst.OptionsBehavior.Editable = False
            pgvGridIcmsst.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridIcmsst.OptionsCustomization.AllowColumnResizing = False
            pgvGridIcmsst.OptionsCustomization.AllowColumnMoving = False
            pgvGridIcmsst.OptionsCustomization.AllowGroup = False
            pgvGridIcmsst.OptionsView.ColumnAutoWidth = False
            pgvGridIcmsst.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridIcmsst.ColumnPanelRowHeight = 60
            pgvGridIcmsst.OptionsView.ColumnAutoWidth = False
            pgvGridIcmsst.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridIcmsst.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridIcmsst.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridIcmsst.Columns(0).Visible = False

            pgvGridIcmsst.Columns(1).Caption = "Nota"
            pgvGridIcmsst.Columns(1).Width = 130

            pgvGridIcmsst.Columns(2).Caption = "Emitente"
            pgvGridIcmsst.Columns(2).Width = 400

            pgvGridIcmsst.Columns(3).Visible = False

            pdgGrid.LevelTree.Nodes(3).Nodes(0).RelationName = "DetalheIcmsst"
            pdgGrid.LevelTree.Nodes(3).Nodes(0).LevelTemplate = pgvGridDetalheIcmsst
            pgvGridDetalheIcmsst.ViewCaption = "Detalhes"
            pgvGridDetalheIcmsst.PopulateColumns(dsMonitoramento.Tables("detalheicmsst"))
            pgvGridDetalheIcmsst.OptionsView.ShowGroupPanel = False
            pgvGridDetalheIcmsst.OptionsBehavior.Editable = False
            pgvGridDetalheIcmsst.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridDetalheIcmsst.OptionsCustomization.AllowColumnResizing = False
            pgvGridDetalheIcmsst.OptionsCustomization.AllowColumnMoving = False
            pgvGridDetalheIcmsst.OptionsCustomization.AllowGroup = False
            pgvGridDetalheIcmsst.OptionsView.ColumnAutoWidth = False
            pgvGridDetalheIcmsst.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridDetalheIcmsst.ColumnPanelRowHeight = 60
            pgvGridDetalheIcmsst.OptionsView.ColumnAutoWidth = False
            pgvGridDetalheIcmsst.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridDetalheIcmsst.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridDetalheIcmsst.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridDetalheIcmsst.Columns(0).Visible = False
            pgvGridDetalheIcmsst.Columns(15).Visible = False
            pgvGridDetalheIcmsst.Columns(16).Visible = False
            pgvGridDetalheIcmsst.Columns(17).Visible = False
            pgvGridDetalheIcmsst.Columns(18).Visible = False
            pgvGridDetalheIcmsst.Columns(19).Visible = False
            pgvGridDetalheIcmsst.Columns(20).Visible = False
            pgvGridDetalheIcmsst.Columns(21).Visible = False
            pgvGridDetalheIcmsst.Columns(22).Visible = False
            pgvGridDetalheIcmsst.Columns(23).Visible = False
            pgvGridDetalheIcmsst.Columns(24).Visible = False
            pgvGridDetalheIcmsst.Columns(25).Visible = False
            pgvGridDetalheIcmsst.Columns(26).Visible = False
            pgvGridDetalheIcmsst.Columns(27).Visible = False
            pgvGridDetalheIcmsst.Columns(28).Visible = False

            ' Definição de Máscaras no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridDetalheIcmsst.Columns(1).ColumnEdit = edit
            pgvGridDetalheIcmsst.Columns(1).Caption = "Obrigação"
            pgvGridDetalheIcmsst.Columns(1).Width = 70

            pgvGridDetalheIcmsst.Columns(2).Caption = "Descrição"
            pgvGridDetalheIcmsst.Columns(2).Width = 230

            pgvGridDetalheIcmsst.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridDetalheIcmsst.Columns(3).Width = 75

            pgvGridDetalheIcmsst.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridDetalheIcmsst.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheIcmsst.Columns(5).ColumnEdit = edit
            pgvGridDetalheIcmsst.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridDetalheIcmsst.Columns(5).Width = 115

            pgvGridDetalheIcmsst.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridDetalheIcmsst.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheIcmsst.Columns(7).ColumnEdit = edit
            pgvGridDetalheIcmsst.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridDetalheIcmsst.Columns(7).Width = 115

            pgvGridDetalheIcmsst.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridDetalheIcmsst.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheIcmsst.Columns(9).ColumnEdit = edit
            pgvGridDetalheIcmsst.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridDetalheIcmsst.Columns(9).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridDetalheIcmsst.Columns(10).ColumnEdit = image
            pgvGridDetalheIcmsst.Columns(10).Caption = "Status"
            pgvGridDetalheIcmsst.Columns(10).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picTipoEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("E-mail", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Malote", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Site", 3, 3))
            pgvGridDetalheIcmsst.Columns(11).ColumnEdit = image
            pgvGridDetalheIcmsst.Columns(11).Caption = "Tipo Envio"
            pgvGridDetalheIcmsst.Columns(11).Width = 120

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizacaoImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 2, 2))
            image.Items.Add(New ImageComboBoxItem("Sem Envio", 3, 3))
            pgvGridDetalheIcmsst.Columns(12).ColumnEdit = image
            pgvGridDetalheIcmsst.Columns(12).Caption = "Status Visualização"
            pgvGridDetalheIcmsst.Columns(12).Width = 120

            pgvGridDetalheIcmsst.Columns(13).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvGridDetalheIcmsst.Columns(13).Width = 115

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridDetalheIcmsst.Columns(14).ColumnEdit = edit
            pgvGridDetalheIcmsst.Columns(14).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvGridDetalheIcmsst.Columns(14).Width = 115

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDManutencaoObrigacoes(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements IManutencaoObrigacoes.IUDManutencaoObrigacoes
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim strFuncionarios As String = String.Empty

            If pstrOperacao = "alteracao" Then
                strQuery = "update admcontroleadministrativo " +
                              "set usuariogeracao = '" + infoManutencaoObrigacoes.usuariogeracao + "', "
                If infoManutencaoObrigacoes.datahorageracao.HasValue Then
                    strQuery += "datahorageracao = '" + infoManutencaoObrigacoes.datahorageracao.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                Else
                    strQuery += "datahorageracao = null, "
                End If
                strQuery += "tipoenvio = '" + infoManutencaoObrigacoes.tipoenvio.ToString + "', " +
                            "vistoentrega = " + infoManutencaoObrigacoes.vistoentrega.ToString + ", " +
                            "usuarioentrega = '" + infoManutencaoObrigacoes.usuarioentrega + "', " +
                            "observacao = '" + infoManutencaoObrigacoes.observacao + "', "
                If infoManutencaoObrigacoes.datahoraentrega.HasValue Then
                    strQuery += "datahoraentrega = '" + infoManutencaoObrigacoes.datahoraentrega.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                Else
                    strQuery += "datahoraentrega = null, "
                End If
                strQuery += "vistoencarregado = " + infoManutencaoObrigacoes.vistoencarregado.ToString + ", " +
                            "usuarioencarregado = '" + infoManutencaoObrigacoes.usuarioencarregado + "', "
                If infoManutencaoObrigacoes.datahoraencarregado.HasValue Then
                    strQuery += "datahoraencarregado = '" + infoManutencaoObrigacoes.datahoraencarregado.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                Else
                    strQuery += "datahoraencarregado = null, "
                End If
                strQuery += "valor = " + infoManutencaoObrigacoes.valor.ToString.Replace(",", ".") + ", " +
                            "valorpago = " + infoManutencaoObrigacoes.valorpago.ToString.Replace(",", ".") + ", "
                If infoManutencaoObrigacoes.datapagamento.HasValue Then
                    strQuery += "datapagamento = '" + infoManutencaoObrigacoes.datapagamento.Value.ToString("yyyy-MM-dd") + "', "
                Else
                    strQuery += "datapagamento = null, "
                End If
                If infoManutencaoObrigacoes.datavencimento.HasValue Then
                    strQuery += "datavencimento = '" + infoManutencaoObrigacoes.datavencimento.Value.ToString("yyyy-MM-dd") + "' "
                Else
                    strQuery += "datavencimento = null "
                End If
                If infoManutencaoObrigacoes.obrigacao = "000003" Then
                    If infoManutencaoObrigacoes.cagedmensal.Count > 0 Then
                        For index = 0 To infoManutencaoObrigacoes.cagedmensal.Count - 1
                            If Not String.IsNullOrEmpty(strFuncionarios) Then
                                strFuncionarios += ", "
                            End If
                            strFuncionarios += "'" + infoManutencaoObrigacoes.cagedmensal(index).funcionario.ToString + "'"
                        Next
                        strFuncionarios = "(" + strFuncionarios + ")"
                    End If
                    strQuery += "where exercicio = " + infoManutencaoObrigacoes.competencia.ToString.Substring(2, 4) + " " +
                                  "and competencia = '" + infoManutencaoObrigacoes.competencia + "' " +
                                  "and empresa = '" + infoManutencaoObrigacoes.empresa + "' " +
                                  "and obrigacao = '" + infoManutencaoObrigacoes.obrigacao + "' " +
                                  "and coalesce(funcionario,'') in " + strFuncionarios + " " +
                                  "and coalesce(parcela,0) = " + infoManutencaoObrigacoes.parcela.ToString + " " +
                                  "and coalesce(tipopessoainforme,0) = " + infoManutencaoObrigacoes.tipopessoainforme.ToString + " " +
                                  "and coalesce(informe,0) = " + infoManutencaoObrigacoes.informe.ToString
                Else
                    strQuery += "where exercicio = " + infoManutencaoObrigacoes.competencia.ToString.Substring(2, 4) + " " +
                                  "and competencia = '" + infoManutencaoObrigacoes.competencia + "' " +
                                  "and empresa = '" + infoManutencaoObrigacoes.empresa + "' " +
                                  "and obrigacao = '" + infoManutencaoObrigacoes.obrigacao + "' " +
                                  "and sequenciaextra = " + infoManutencaoObrigacoes.sequenciaextra.ToString() + " " +
                                  "and coalesce(funcionario,'') = '" + infoManutencaoObrigacoes.funcionario + "' " +
                                  "and coalesce(parcela,0) = " + infoManutencaoObrigacoes.parcela.ToString + " " +
                                  "and coalesce(tipopessoainforme,0) = " + infoManutencaoObrigacoes.tipopessoainforme.ToString + " " +
                                  "and coalesce(informe,0) = " + infoManutencaoObrigacoes.informe.ToString
                End If
            End If
            objDataBase.NonQuery(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDPortalGuias(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements IManutencaoObrigacoes.IUDPortalGuias
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "alteracao" Then
                strQuery = "update admcontroleadministrativoportalguias " +
                              "set mensagem = '" + infoManutencaoObrigacoes.portalguias(0).mensagem.Replace("'", "''") + "', " +
                                  "usuarioenvio = '" + infoManutencaoObrigacoes.portalguias(0).usuarioenvio + "', "
                If infoManutencaoObrigacoes.portalguias(0).datahoraenvioinicio.HasValue Then
                    strQuery += "datahoraenvioinicio = '" + infoManutencaoObrigacoes.portalguias(0).datahoraenvioinicio.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                Else
                    strQuery += "datahoraenvioinicio = null, "
                End If
                If infoManutencaoObrigacoes.portalguias(0).datahoraenviofim.HasValue Then
                    strQuery += "datahoraenviofim = '" + infoManutencaoObrigacoes.portalguias(0).datahoraenviofim.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                Else
                    strQuery += "datahoraenviofim = null, "
                End If
                strQuery += "empresavisualizou = " + infoManutencaoObrigacoes.portalguias(0).empresavisualizou.ToString + ", " +
                            "nomeusuarioempresa = '" + infoManutencaoObrigacoes.portalguias(0).nomeusuarioempresa.ToString + "', "
                If infoManutencaoObrigacoes.portalguias(0).datahoraempresavisualizou.HasValue Then
                    strQuery += "datahoraempresavisualizou = '" + infoManutencaoObrigacoes.portalguias(0).datahoraempresavisualizou.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' "
                Else
                    strQuery += "datahoraempresavisualizou = null "
                End If

                strQuery += "where exercicio = " + infoManutencaoObrigacoes.competencia.ToString.Substring(2, 4) + " " +
                              "and competencia = '" + infoManutencaoObrigacoes.competencia + "' " +
                              "and empresa = '" + infoManutencaoObrigacoes.empresa + "' " +
                              "and obrigacao = '" + infoManutencaoObrigacoes.obrigacao + "' " +
                              "and sequenciaextra = " + infoManutencaoObrigacoes.sequenciaextra.ToString() + " " +
                              "and coalesce(funcionario,'') = '" + infoManutencaoObrigacoes.funcionario + "' " +
                              "and coalesce(parcela,0) = " + infoManutencaoObrigacoes.parcela.ToString + " " +
                              "and coalesce(tipopessoainforme,0) = " + infoManutencaoObrigacoes.tipopessoainforme.ToString + " " +
                              "and coalesce(informe,0) = " + infoManutencaoObrigacoes.informe.ToString
            End If
            objDataBase.NonQuery(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaDados(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, ByRef pintSequenciaExtra As Integer, ByRef pintObrigacaoExtra As Integer, ByRef pstrFuncionario As String, ByRef pintParcela As Integer, ByRef pintTipoPessoaInforme As Integer, ByRef pintInforme As Integer) As Modelo.manutencaoobrigacoesInfo Implements IManutencaoObrigacoes.BuscaDados
        Try
            Dim infoManutencaoObrigacao As New manutencaoobrigacoesInfo
            Dim infoObrigacaoPortalGuia As List(Of manutencaoobrigacoesportalguiasInfo)
            Dim infoObrigacaoPortalArquivo As List(Of manutencaoobrigacoesportalarquivosInfo)
            Dim infoObrigacaoFuncionarios As List(Of manutencaoobrigacoesfuncionariosInfo)
            Dim infoObrigacaoPortalLog As List(Of manutencaoobrigacoesportallogInfo)
            Dim objObrigacao As New ObrigacoesDAL

            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            If pstrObrigacao = "000003" Then
                strQuery = "select aca.usuariogeracao, aca.datahorageracao, " +
                                  "aca.usuarioentrega, aca.datahoraentrega, aca.vistoentrega, " +
                                  "aca.usuarioencarregado, aca.datahoraencarregado, aca.vistoencarregado, " +
                                  "'' as funcionario, aca.datavencimento, cast(0 as numeric(18,2)) as valor, cast(0 as numeric(18,2)) as valorpago, aca.datapagamento, aca.tipoenvio, aca.parcela, aca.darfinforme, aca.cnpjcpfinforme " +
                             "from admcontroleadministrativo aca "
                strQuery += "where aca.exercicio = " + pintExercicio.ToString + " " +
                              "and aca.competencia = '" + pstrCompetencia + "' " +
                              "and aca.empresa = '" + pstrEmpresa + "' " +
                              "and aca.obrigacao = '" + pstrObrigacao + "' " +
                              "and aca.sequenciaextra = " + pintSequenciaExtra.ToString() + " " +
                              "and aca.obrigacaoextra = " + pintObrigacaoExtra.ToString() + " " +
                              "and coalesce(aca.parcela,0) = " + pintParcela.ToString + " " +
                              "and coalesce(aca.tipopessoainforme,0) = " + pintTipoPessoaInforme.ToString + " " +
                              "and coalesce(aca.informe,0) = " + pintInforme.ToString
            Else
                strQuery = "select aca.usuariogeracao, aca.datahorageracao, " +
                                  "aca.usuarioentrega, aca.datahoraentrega, aca.vistoentrega, " +
                                  "aca.usuarioencarregado, aca.datahoraencarregado, aca.vistoencarregado, " +
                                  "aca.funcionario, aca.datavencimento, aca.valor, aca.valorpago, aca.datapagamento, aca.tipoenvio, aca.parcela, aca.darfinforme, aca.cnpjcpfinforme " +
                             "from admcontroleadministrativo aca "
                strQuery += "where aca.exercicio = " + pintExercicio.ToString + " " +
                              "and aca.competencia = '" + pstrCompetencia + "' " +
                              "and aca.empresa = '" + pstrEmpresa + "' " +
                              "and aca.obrigacao = '" + pstrObrigacao + "' " +
                              "and aca.sequenciaextra = " + pintSequenciaExtra.ToString() + " " +
                              "and aca.obrigacaoextra = " + pintObrigacaoExtra.ToString() + " " +
                              "and coalesce(aca.funcionario,'') = '" + pstrFuncionario + "' " +
                              "and coalesce(aca.parcela,0) = " + pintParcela.ToString + " " +
                              "and coalesce(aca.tipopessoainforme,0) = " + pintTipoPessoaInforme.ToString + " " +
                              "and coalesce(aca.informe,0) = " + pintInforme.ToString
            End If
            Dim sdData As SelectedData = objDataBase.QueryFull(strQuery)

            infoManutencaoObrigacao.obrigacao = pstrObrigacao
            infoManutencaoObrigacao.competencia = pstrCompetencia
            infoManutencaoObrigacao.empresa = pstrEmpresa
            infoManutencaoObrigacao.sequenciaextra = pintSequenciaExtra
            infoManutencaoObrigacao.obrigacaoextra = pintObrigacaoExtra
            infoManutencaoObrigacao.tipopessoainforme = pintTipoPessoaInforme
            infoManutencaoObrigacao.informe = pintInforme
            infoManutencaoObrigacao.funcionario = pstrFuncionario
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                infoManutencaoObrigacao.usuariogeracao = Convert.ToString(row.Values(0))
                infoManutencaoObrigacao.datahorageracao = row.Values(1)
                infoManutencaoObrigacao.usuarioentrega = Convert.ToString(row.Values(2))
                infoManutencaoObrigacao.datahoraentrega = row.Values(3)
                infoManutencaoObrigacao.vistoentrega = row.Values(4)
                infoManutencaoObrigacao.usuarioencarregado = Convert.ToString(row.Values(5))
                infoManutencaoObrigacao.datahoraencarregado = row.Values(6)
                infoManutencaoObrigacao.vistoencarregado = row.Values(7)
                infoManutencaoObrigacao.funcionario = Convert.ToString(row.Values(8))
                infoManutencaoObrigacao.datavencimento = row.Values(9)
                infoManutencaoObrigacao.valor = row.Values(10)
                infoManutencaoObrigacao.valorpago = row.Values(11)
                infoManutencaoObrigacao.datapagamento = row.Values(12)
                infoManutencaoObrigacao.tipoenvio = Convert.ToString(row.Values(13))
                infoManutencaoObrigacao.parcela = row.Values(14)
                infoManutencaoObrigacao.darfinforme = Convert.ToString(row.Values(15))
                infoManutencaoObrigacao.cnpjcpfinforme = Convert.ToString(row.Values(16))
            Next row

            If pstrObrigacao = "000003" Then
                strQuery = "select aca.funcionario, cast(max(f.nome) as varchar) as nome " +
                                "from admcontroleadministrativo aca " +
                                "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario "
                strQuery += "where aca.exercicio = " + pintExercicio.ToString + " " +
                              "and aca.competencia = '" + pstrCompetencia + "' " +
                              "and aca.empresa = '" + pstrEmpresa + "' " +
                              "and aca.obrigacao = '" + pstrObrigacao + "' " +
                              "and aca.datavencimento = '" + String.Format("{0:yyyy-MM-dd}", infoManutencaoObrigacao.datavencimento) + "' " +
                              "and coalesce(aca.usuariogeracao,'') = '" + infoManutencaoObrigacao.usuariogeracao.ToString + "' "
                If infoManutencaoObrigacao.datahorageracao.HasValue Then
                    strQuery += "and aca.datahorageracao = '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", infoManutencaoObrigacao.datahorageracao) + "' "
                Else
                    strQuery += "and aca.datahorageracao is null "
                End If
                strQuery += "group by aca.empresa, aca.funcionario, aca.competencia " +
                            "order by aca.empresa, aca.funcionario"
            ElseIf objObrigacao.RetornaLayoutObrigacao(pstrObrigacao) > 0 Then
                strQuery = "select acapg.razaosocial, acapg.endereco, acapg.bairro, acapg.cep, acapg.municipio, acapg.uf, acapg.ddd, acapg.telefone, acapg.cnae, acapg.inscricaoestadual, acapg.cnpjcpf, " +
                                  "acapg.datavencimento, acapg.datapagamento, acapg.periodoapuracao, acapg.codigoreceita, acapg.descricaoguia, " +
                                  "acapg.valor, acapg.valoroutros, acapg.valorjuros, acapg.valormulta, acapg.valortotal, acapg.valorminimo, " +
                                  "acapg.texto1, acapg.texto2, acapg.texto3, acapg.texto4, acapg.cotas, acapg.relacaomesacumulado, " +
                                  "acapg.nomebeneficiario, acapg.cnpjcpfbeneficiario, acapg.notafiscal, acapg.nroreferencia, acapg.mensagem, " +
                                  "acapg.usuarioenvio, acapg.datahoraenvioinicio, acapg.datahoraenviofim, acapg.empresavisualizou, " +
                                  "acapg.nomeusuarioempresa, acapg.datahoraempresavisualizou  " +
                             "from admcontroleadministrativoportalguias acapg "
                strQuery += "where acapg.exercicio = " + pintExercicio.ToString + " " +
                              "and acapg.competencia = '" + pstrCompetencia + "' " +
                              "and acapg.empresa = '" + pstrEmpresa + "' " +
                              "and acapg.obrigacao = '" + pstrObrigacao + "' " +
                              "and acapg.sequenciaextra = " + pintSequenciaExtra.ToString() + " " +
                              "and acapg.obrigacaoextra = " + pintObrigacaoExtra.ToString() + " " +
                              "and coalesce(acapg.funcionario,'') = '" + pstrFuncionario + "' " +
                              "and coalesce(acapg.parcela,0) = " + pintParcela.ToString + " " +
                              "and coalesce(acapg.tipopessoainforme,0) = " + pintTipoPessoaInforme.ToString + " " +
                              "and coalesce(acapg.informe,0) = " + pintInforme.ToString
            End If
            Dim sdDataPortal As SelectedData = objDataBase.QueryFull(strQuery)

            infoObrigacaoPortalGuia = New List(Of manutencaoobrigacoesportalguiasInfo)
            infoObrigacaoPortalArquivo = New List(Of manutencaoobrigacoesportalarquivosInfo)
            infoObrigacaoFuncionarios = New List(Of manutencaoobrigacoesfuncionariosInfo)
            infoObrigacaoPortalLog = New List(Of manutencaoobrigacoesportallogInfo)

            For Each row As SelectStatementResultRow In sdDataPortal.ResultSet(1).Rows
                If pstrObrigacao = "000003" Then
                    Dim funcionarioinfo As New manutencaoobrigacoesfuncionariosInfo(Convert.ToString(row.Values(0)), Convert.ToString(row.Values(1)))
                    infoObrigacaoFuncionarios.Add(funcionarioinfo)
                ElseIf objObrigacao.RetornaLayoutObrigacao(pstrObrigacao) > 0 Then
                    Dim portalguiainfo As New manutencaoobrigacoesportalguiasInfo(Convert.ToString(row.Values(0)), Convert.ToString(row.Values(1)), Convert.ToString(row.Values(2)), Convert.ToString(row.Values(3)), Convert.ToString(row.Values(4)),
                                                                                  Convert.ToString(row.Values(5)), Convert.ToString(row.Values(6)), Convert.ToString(row.Values(7)),
                                                                                  Convert.ToString(row.Values(8)), Convert.ToString(row.Values(9)), Convert.ToString(row.Values(10)),
                                                                                  row.Values(11), row.Values(12), row.Values(13), Convert.ToString(row.Values(14)), Convert.ToString(row.Values(15)),
                                                                                  Convert.ToDecimal(row.Values(16)), Convert.ToDecimal(row.Values(17)), Convert.ToDecimal(row.Values(18)), Convert.ToDecimal(row.Values(19)), Convert.ToDecimal(row.Values(20)), Convert.ToDecimal(row.Values(21)),
                                                                                  Convert.ToString(row.Values(22)), Convert.ToString(row.Values(23)), Convert.ToString(row.Values(24)), Convert.ToString(row.Values(25)), Convert.ToString(row.Values(26)),
                                                                                  Convert.ToString(row.Values(27)), Convert.ToString(row.Values(28)), Convert.ToString(row.Values(29)), Convert.ToString(row.Values(30)), Convert.ToString(row.Values(31)), Convert.ToString(row.Values(32)),
                                                                                  Convert.ToString(row.Values(33)), row.Values(34), row.Values(35), row.Values(36), Convert.ToString(row.Values(37)), row.Values(38))

                    infoObrigacaoPortalGuia.Add(portalguiainfo)
                End If
            Next row

            If objObrigacao.RetornaLayoutObrigacao(pstrObrigacao) = 0 Then
                strQuery = "select acapg.arquivo, acapg.mensagem, " +
                                  "acapg.usuarioenvio, acapg.datahoraenvioinicio, acapg.datahoraenviofim, acapg.empresavisualizou, " +
                                  "acapg.nomeusuarioempresa, acapg.datahoraempresavisualizou  " +
                             "from admcontroleadministrativoportalarquivos acapg "
                strQuery += "where acapg.exercicio = " + pintExercicio.ToString + " " +
                              "and acapg.competencia = '" + pstrCompetencia + "' " +
                              "and acapg.empresa = '" + pstrEmpresa + "' " +
                              "and acapg.obrigacao = '" + pstrObrigacao + "' " +
                              "and acapg.sequenciaextra = " + pintSequenciaExtra.ToString() + " " +
                              "and acapg.obrigacaoextra = " + pintObrigacaoExtra.ToString() + " " +
                              "and coalesce(acapg.funcionario,'') = '" + pstrFuncionario + "' " +
                              "and coalesce(acapg.parcela,0) = " + pintParcela.ToString + " " +
                              "and coalesce(acapg.tipopessoainforme,0) = " + pintTipoPessoaInforme.ToString + " " +
                              "and coalesce(acapg.informe,0) = " + pintInforme.ToString

                sdDataPortal = objDataBase.QueryFull(strQuery)

                If sdDataPortal.ResultSet(1).Rows.Length = 0 Then
                    If objObrigacao.RetornaLayoutObrigacao(pstrObrigacao) = 0 Then
                        Dim portalarquivoinfo As New manutencaoobrigacoesportalarquivosInfo(String.Empty, String.Empty, String.Empty, Nothing, Nothing, 0, String.Empty, Nothing)
                        infoObrigacaoPortalArquivo.Add(portalarquivoinfo)
                    End If
                Else
                    For Each row As SelectStatementResultRow In sdDataPortal.ResultSet(1).Rows
                        Dim portalarquivoinfo As New manutencaoobrigacoesportalarquivosInfo(Convert.ToString(row.Values(0)), Convert.ToString(row.Values(1)),
                                                                                            Convert.ToString(row.Values(2)), row.Values(3), row.Values(4), row.Values(5), Convert.ToString(row.Values(6)), row.Values(7))
                        infoObrigacaoPortalArquivo.Add(portalarquivoinfo)
                    Next row
                End If
            End If
            infoManutencaoObrigacao.portalguias = infoObrigacaoPortalGuia
            infoManutencaoObrigacao.portalarquivos = infoObrigacaoPortalArquivo
            infoManutencaoObrigacao.cagedmensal = infoObrigacaoFuncionarios
            infoManutencaoObrigacao.portallog = infoObrigacaoPortalLog
            Return infoManutencaoObrigacao
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UploadGuias(ByRef pstrDados As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) As Boolean Implements IManutencaoObrigacoes.UploadGuias
        Try
            Dim objGuias As New GuiasWS
            Dim blnRetorno As Boolean = False
            If ValidarDadosPortal(infoManutencaoObrigacoes, enuValidaPortal.UsuariosEmpresas) Then
                blnRetorno = objGuias.Guias(pstrDados, infoManutencaoObrigacoes)
            End If
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub IUDPortalArquivos(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements IManutencaoObrigacoes.IUDPortalArquivos
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "alteracao" Then
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                   "from admcontroleadministrativoportalarquivos apc " +
                                                                   "where exercicio = " + infoManutencaoObrigacoes.competencia.ToString.Substring(2, 4) + " " +
                                                                     "and competencia = '" + infoManutencaoObrigacoes.competencia + "' " +
                                                                     "and empresa = '" + infoManutencaoObrigacoes.empresa + "' " +
                                                                     "and obrigacao = '" + infoManutencaoObrigacoes.obrigacao + "' " +
                                                                     "and sequenciaextra = " + infoManutencaoObrigacoes.sequenciaextra.ToString() + " " +
                                                                     "and coalesce(funcionario,'') = '" + infoManutencaoObrigacoes.funcionario + "' " +
                                                                     "and coalesce(parcela,0) = " + infoManutencaoObrigacoes.parcela.ToString + " " +
                                                                     "and coalesce(tipopessoainforme,0) = " + infoManutencaoObrigacoes.tipopessoainforme.ToString + " " +
                                                                     "and coalesce(informe,0) = " + infoManutencaoObrigacoes.informe.ToString)
                If (intCount > 0) Then
                    strQuery = "update admcontroleadministrativoportalarquivos " +
                                  "set arquivo = '" + infoManutencaoObrigacoes.portalarquivos(0).arquivo.Replace("\", "\\").Replace("'", "''") + "', " +
                                      "mensagem = '" + infoManutencaoObrigacoes.portalarquivos(0).mensagem.Replace("'", "''") + "', " +
                                      "usuarioenvio = '" + infoManutencaoObrigacoes.portalarquivos(0).usuarioenvio + "', "
                    If infoManutencaoObrigacoes.portalarquivos(0).datahoraenvioinicio.HasValue Then
                        strQuery += "datahoraenvioinicio = '" + infoManutencaoObrigacoes.portalarquivos(0).datahoraenvioinicio.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                    Else
                        strQuery += "datahoraenvioinicio = null, "
                    End If
                    If infoManutencaoObrigacoes.portalarquivos(0).datahoraenviofim.HasValue Then
                        strQuery += "datahoraenviofim = '" + infoManutencaoObrigacoes.portalarquivos(0).datahoraenviofim.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                    Else
                        strQuery += "datahoraenviofim = null, "
                    End If
                    strQuery += "empresavisualizou = " + infoManutencaoObrigacoes.portalarquivos(0).empresavisualizou.ToString + ", " +
                                "nomeusuarioempresa = '" + infoManutencaoObrigacoes.portalarquivos(0).nomeusuarioempresa.ToString + "', "
                    If infoManutencaoObrigacoes.portalarquivos(0).datahoraempresavisualizou.HasValue Then
                        strQuery += "datahoraempresavisualizou = '" + infoManutencaoObrigacoes.portalarquivos(0).datahoraempresavisualizou.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' "
                    Else
                        strQuery += "datahoraempresavisualizou = null "
                    End If

                    strQuery += "where exercicio = " + infoManutencaoObrigacoes.competencia.ToString.Substring(2, 4) + " " +
                                  "and competencia = '" + infoManutencaoObrigacoes.competencia + "' " +
                                  "and empresa = '" + infoManutencaoObrigacoes.empresa + "' " +
                                  "and obrigacao = '" + infoManutencaoObrigacoes.obrigacao + "' " +
                                  "and sequenciaextra = " + infoManutencaoObrigacoes.sequenciaextra.ToString + " " +
                                  "and coalesce(funcionario,'') = '" + infoManutencaoObrigacoes.funcionario + "' " +
                                  "and coalesce(parcela,0) = " + infoManutencaoObrigacoes.parcela.ToString + " " +
                                  "and coalesce(tipopessoainforme,0) = " + infoManutencaoObrigacoes.tipopessoainforme.ToString + " " +
                                  "and coalesce(informe,0) = " + infoManutencaoObrigacoes.informe.ToString
                Else
                    strQuery = "insert into admcontroleadministrativoportalarquivos(empresa, competencia, obrigacao, exercicio, parcela, sequenciaextra, " +
                                                                                   "obrigacaoextra, tipopessoainforme, informe, funcionario, arquivo, " +
                                                                                   "mensagem, usuarioenvio, datahoraenvioinicio, datahoraenviofim, " +
                                                                                   "empresavisualizou, nomeusuarioempresa, datahoraempresavisualizou) " +
                                    "values ('" + infoManutencaoObrigacoes.empresa + "','" + infoManutencaoObrigacoes.competencia + "'," +
                                            "'" + infoManutencaoObrigacoes.obrigacao + "'," + infoManutencaoObrigacoes.competencia.ToString.Substring(2, 4) + "," +
                                                  infoManutencaoObrigacoes.parcela.ToString + "," + infoManutencaoObrigacoes.sequenciaextra.ToString + "," +
                                                  infoManutencaoObrigacoes.obrigacaoextra.ToString + "," + infoManutencaoObrigacoes.tipopessoainforme.ToString + "," +
                                                  infoManutencaoObrigacoes.informe.ToString + ",'" + infoManutencaoObrigacoes.funcionario + "'," +
                                            "'" + infoManutencaoObrigacoes.portalarquivos(0).arquivo.Replace("\", "\\").Replace("'", "''") + "'," +
                                            "'" + infoManutencaoObrigacoes.portalarquivos(0).mensagem.Replace("'", "''") + "'," +
                                            "'" + infoManutencaoObrigacoes.portalarquivos(0).usuarioenvio + "',"
                    If infoManutencaoObrigacoes.portalarquivos(0).datahoraenvioinicio.HasValue Then
                        strQuery += "'" + infoManutencaoObrigacoes.portalarquivos(0).datahoraenvioinicio.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                    Else
                        strQuery += "null, "
                    End If
                    If infoManutencaoObrigacoes.portalarquivos(0).datahoraenviofim.HasValue Then
                        strQuery += "'" + infoManutencaoObrigacoes.portalarquivos(0).datahoraenviofim.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                    Else
                        strQuery += "null, "
                    End If
                    strQuery += infoManutencaoObrigacoes.portalarquivos(0).empresavisualizou.ToString + ", " +
                                "'" + infoManutencaoObrigacoes.portalarquivos(0).nomeusuarioempresa.ToString + "', "
                    If infoManutencaoObrigacoes.portalarquivos(0).datahoraempresavisualizou.HasValue Then
                        strQuery += "'" + infoManutencaoObrigacoes.portalarquivos(0).datahoraempresavisualizou.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' "
                    Else
                        strQuery += "null "
                    End If
                    strQuery += ")"
                End If
            End If
            objDataBase.NonQuery(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function UploadArquivos(ByRef pbArquivos() As Byte, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) As Boolean Implements IManutencaoObrigacoes.UploadArquivos
        Try
            Dim objArquivos As New ArquivosWS
            Dim blnRetorno As Boolean = False
            If ValidarDadosPortal(infoManutencaoObrigacoes, enuValidaPortal.UsuariosEmpresas) Then
               blnRetorno = objArquivos.Arquivos(pbArquivos, infoManutencaoObrigacoes)
            End If
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DownloadArquivos(ByRef pstrCaminhoDownload As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) As String Implements IManutencaoObrigacoes.DownloadArquivos
        Try
            Dim objArquivos As New ArquivosWS
            Return objArquivos.DownloadArquivos(pstrCaminhoDownload, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub LogArquivos(ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements IManutencaoObrigacoes.LogArquivos
        Try
            Dim objArquivos As New ArquivosWS

            Dim strRetorno As String = objArquivos.LogArquivos(String.Empty, infoManutencaoObrigacoes)
            RetornaLog(strRetorno, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub LogGuias(ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements IManutencaoObrigacoes.LogGuias
        Try
            Dim objGuias As New GuiasWS

            Dim strRetorno As String = objGuias.LogGuias(String.Empty, infoManutencaoObrigacoes)
            RetornaLog(strRetorno, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub RetornaLog(ByVal pstrRetorno As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo)
        If Not String.IsNullOrEmpty(pstrRetorno) Then
            Dim strMsgErro As String = String.Empty
            Dim infoObrigacaoPortalLog As List(Of manutencaoobrigacoesportallogInfo)
            infoObrigacaoPortalLog = New List(Of manutencaoobrigacoesportallogInfo)
            Dim aLista() As String = pstrRetorno.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split(",")
                If aCampos.Length <= 1 Then
                    strMsgErro = "Empresa: " + infoManutencaoObrigacoes.empresa.Substring(0, 2) + "." + infoManutencaoObrigacoes.empresa.Substring(2, 4) + " "
                    strMsgErro += "Competência: " + infoManutencaoObrigacoes.competencia.Substring(0, 2) + "/" + infoManutencaoObrigacoes.competencia.Substring(2, 4) + " "
                    strMsgErro += "Obrigação: " + infoManutencaoObrigacoes.obrigacao.Substring(0, 1) + "-" + infoManutencaoObrigacoes.obrigacao.Substring(1, 5) + " "
                    If infoManutencaoObrigacoes.datavencimento.HasValue Then
                        strMsgErro += "Data Vencimento: " + infoManutencaoObrigacoes.datavencimento.ToString.Substring(0, 10) + " "
                    End If
                    If Not String.IsNullOrEmpty(infoManutencaoObrigacoes.funcionario) Then
                        strMsgErro += "Funcionário: " + infoManutencaoObrigacoes.funcionario + " "
                    End If
                    If infoManutencaoObrigacoes.tipopessoainforme > 0 Then
                        strMsgErro += "CNPJ/CPF: "
                        If infoManutencaoObrigacoes.cnpjcpfinforme.Length = 11 Then
                            strMsgErro += infoManutencaoObrigacoes.cnpjcpfinforme.Substring(0, 3) + "." +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(3, 3) + "." +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(6, 3) + "-" +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(9, 2) + " "
                        ElseIf infoManutencaoObrigacoes.cnpjcpfinforme.Length = 14 Then
                            strMsgErro += infoManutencaoObrigacoes.cnpjcpfinforme.Substring(0, 2) + "." +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(2, 3) + "." +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(5, 3) + "-" +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(8, 4) + "/" +
                                          infoManutencaoObrigacoes.cnpjcpfinforme.Substring(12, 2) + " "
                        End If
                    End If
                    strMsgErro = strMsgErro.Substring(0, strMsgErro.Length - 1)
                End If
                If aCampos.Length <= 1 Then Throw New Exception(pstrRetorno + Environment.NewLine +
                                                                "WebService: LOG de envio das Obrigações para as Empresas " + Environment.NewLine +
                                                                "[" + strMsgErro + "]. Favor verificar.")
                Dim objDataBase As New DataBaseDAL
                Dim strNome As String = objDataBase.QuerySimples("select uep.nome " +
                                                                   "from admusuariosempresassistemasportal uep " +
                                                                   "join admusuariosempresassistemasitensportal uei on uei.empresa = uep.empresa and uei.email = uep.email " +
                                                                   "join admobrigacoes ao on ao.sistema = uei.sistema and ao.obrigacao = '" + infoManutencaoObrigacoes.obrigacao.ToString + "' " +
                                                                  "where uep.empresa = '" + infoManutencaoObrigacoes.empresa.ToString + "' " +
                                                                    "and uep.email = '" + aCampos(0).ToString + "'")

                Dim portalloginfo As New manutencaoobrigacoesportallogInfo(strNome, aCampos(0).ToString, Convert.ToDateTime(aCampos(1).ToString))
                infoObrigacaoPortalLog.Add(portalloginfo)
            Next
            infoManutencaoObrigacoes.portallog = infoObrigacaoPortalLog
        End If
    End Sub

    Public Function BuscaAlertas() As manutencaoobrigacoesalerta Implements IManutencaoObrigacoes.BuscaAlertas
        Try
            Dim infoAlertaObrigacao As New manutencaoobrigacoesalerta
            Dim infoalertaInfo As List(Of alertaInfo)

            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            Dim strJoinUsuarios As String = String.Empty
            If usuarioInfo.obrigacoes Then
                strJoinUsuarios = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If

            strQuery = "select aca.obrigacao, max(ao.descricao) as descricao, max(ao.sistema) as sistema, count(*) as qtd, extract(day from aca.datavencimento - current_date) as dias " +
                         "from admcontroleadministrativo aca " +
                         "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " + strJoinUsuarios + " " +
                        "where extract(Day from aca.datavencimento - current_date) between 0 And " + usuarioInfo.diasalerta.ToString + " and aca.datahoraencarregado is null " +
                     "group by aca.obrigacao, extract(Day from aca.datavencimento - current_date) " +
                     "order by 5"

            Dim sdData As SelectedData = objDataBase.QueryFull(strQuery)
            infoalertaInfo = New List(Of alertaInfo)

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                Dim strTitulo As String = String.Empty
                Dim strDescricao As String = String.Empty
                If Convert.ToInt32(row.Values(4)) = 0 Then
                    strTitulo = "<size=10><b>Vence hoje</b>"
                Else
                    strTitulo = "<size=10><b>Vence em " + Convert.ToString(row.Values(4)) + " dia"
                    If row.Values(4) > 1 Then
                        strTitulo += "s"
                    End If
                    strTitulo += "</b>"
                End If
                strDescricao = "<size=10><b>Obrigação: </b>[<size=8>" + Convert.ToString(row.Values(0)).Substring(0, 1) + "-" + Convert.ToString(row.Values(0)).Substring(1, 5) + " - "
                strDescricao += Convert.ToString(row.Values(1)) + "<size=10>].</br>"
                strDescricao += "<size=10><b>" + Convert.ToString(row.Values(3)) + "</b> empresa(s) vinculada(s) para essa obrigação.</br>"
                strDescricao += "<size=8>Clique no botão abaixo para maiores detalhes."
                Dim alertainfo As New alertaInfo(strTitulo, strDescricao, "aca.datahoraencarregado is null and " +
                                                                          "aca.obrigacao = '" + Convert.ToString(row.Values(0)) + "' and " +
                                                                          "extract(day from aca.datavencimento - current_date) = " + Convert.ToString(row.Values(4)))
                infoalertaInfo.Add(alertainfo)
            Next row
            infoAlertaObrigacao.alertas = infoalertaInfo

            Return infoAlertaObrigacao
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function ValidarDadosPortal(ByRef infoArquivos As manutencaoobrigacoesInfo, ByRef penuValidaPortal As enuValidaPortal) As Boolean
        Dim wsConsulta As New SelectWS
        Dim wsInclusao As New InsertWS
        Dim objDataBase As New DataBaseDAL
        Dim strQuery As String = String.Empty
        Dim sdData As SelectedData = Nothing
        Dim blnUsuarioEmpresaExiste As Boolean = False
        Dim blnEmpresaUsuarioObrigacaoExiste As Boolean = False
        Try
            If penuValidaPortal = enuValidaPortal.UsuariosEmpresas Then
                strQuery = "select au.empresa, au.nome, au.email, coalesce(au.ddd,'') as ddd, coalesce(au.telefone,'') as telefone " +
                             "from admusuariosempresassistemasportal au " +
                             "join admusuariosempresassistemasitensportal aui on aui.empresa = au.empresa And aui.email = au.email " +
                             "join admobrigacoes ao on ao.sistema = aui.sistema and ao.obrigacao = '" + infoArquivos.obrigacao.ToString + "' " +
                            "where au.empresa = '" + infoArquivos.empresa.ToString + "' " +
                         "order by 1, 3"
                sdData = objDataBase.QueryFull(strQuery)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    SplashScreenManager.Default.SetWaitFormDescription("Validando a obrigação para os [Usuários da Empresa] no portal")
                    If Not blnUsuarioEmpresaExiste Then
                        blnUsuarioEmpresaExiste = wsConsulta.UsuarioEmpresaExiste(row.Values(0).ToString, row.Values(2).ToString)
                    End If
                    blnEmpresaUsuarioObrigacaoExiste = wsConsulta.EmpresaUsuarioObrigacaoExiste(row.Values(0).ToString, infoArquivos.obrigacao, row.Values(2).ToString)
                    If Not blnUsuarioEmpresaExiste Or Not blnEmpresaUsuarioObrigacaoExiste Then
                        If ValidarDadosPortal(infoArquivos, enuValidaPortal.Empresas) Then
                            If ValidarDadosPortal(infoArquivos, enuValidaPortal.UsuariosEscritorios) Then
                                If ValidarDadosPortal(infoArquivos, enuValidaPortal.Obrigacoes) Then
                                    If Not blnUsuarioEmpresaExiste Then
                                        wsInclusao.IncluiUsuarioEmpresa(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString, row.Values(4).ToString)
                                    End If
                                    If Not blnEmpresaUsuarioObrigacaoExiste Then
                                        wsInclusao.IncluirEmpresaUsuarioObrigacoes(row.Values(0).ToString, infoArquivos.obrigacao, row.Values(2).ToString)
                                    End If
                                End If
                            End If
                        End If
                    End If
                    SplashScreenManager.Default.SetWaitFormDescription("Enviando...")
                Next row
            End If

            If penuValidaPortal = enuValidaPortal.Empresas Then
                SplashScreenManager.Default.SetWaitFormDescription("Validando a [Empresa] no portal")
                If Not wsConsulta.EmpresaExiste(infoArquivos.empresa) Then
                    strQuery = "select aoe.empresa, emp.razaosocial, coalesce(emp.cnpj,'') as cnpjcpf " +
                                 "from (select aoe.empresa, max(aoe.exercicio) as exercicio " +
                                         "from admobrigacoesempresas aoe " +
                                        "where aoe.empresa = '" + infoArquivos.empresa.ToString + "' " +
                                     "group by aoe.empresa) aoe " +
                                 "join empresas emp on emp.empresa = aoe.empresa And emp.exercicio = aoe.exercicio"
                    sdData = objDataBase.QueryFull(strQuery)
                    For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                        wsInclusao.IncluirEmpresas(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString)
                    Next row
                End If
            End If

            If penuValidaPortal = enuValidaPortal.UsuariosEscritorios Then
                SplashScreenManager.Default.SetWaitFormDescription("Validando o [Usuário do Escritório] no portal")
                Dim strLogin As String = String.Empty
                If infoArquivos.portalguias.Count > 0 Then
                    strLogin = infoArquivos.portalguias(0).usuarioenvio
                ElseIf infoArquivos.portalarquivos.Count > 0 Then
                    strLogin = infoArquivos.portalarquivos(0).usuarioenvio
                End If
                If String.IsNullOrEmpty(strLogin) Then
                    strLogin = usuarioInfo.usuario
                End If
                If Not wsConsulta.UsuarioEscritorioExiste(strLogin) Then
                    strQuery = "select u.nome, u.login, u.senha, coalesce(u.email,'') as email " +
                                 "from usuarios u " +
                                 "join usernivel un on un.login = u.login and un.sistema = 'Administrativo' " +
                                "where u.login = '" + strLogin + "'"
                    sdData = objDataBase.QueryFull(strQuery)
                    For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                        wsInclusao.IncluirUsuariosEscritorio(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString)
                    Next row
                End If
            End If

            If penuValidaPortal = enuValidaPortal.Obrigacoes Then
                SplashScreenManager.Default.SetWaitFormDescription("Validando a [Obrigação] no portal")
                If Not wsConsulta.ObrigacaoExiste(infoArquivos.obrigacao) Then
                    strQuery = "select ao.obrigacao, ao.descricao " +
                                 "from admobrigacoes ao " +
                                "where ao.obrigacao = '" + infoArquivos.obrigacao.ToString + "'"
                    sdData = objDataBase.QueryFull(strQuery)
                    For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                        Dim objObrigacao As New ObrigacoesDAL
                        wsInclusao.IncluirObrigacoes(row.Values(0).ToString, row.Values(1).ToString, objObrigacao.RetornaLayoutObrigacao(row.Values(0).ToString))
                    Next row
                End If
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class