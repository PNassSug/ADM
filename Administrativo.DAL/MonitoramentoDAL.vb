Imports Administrativo.Modelo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing

Public Class MonitoramentoDAL
    Implements IMonitoramento

    Private edit As RepositoryItemTextEdit
    Private image As RepositoryItemImageComboBox

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresaDetalhe As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, picImageColection As DevExpress.Utils.ImageCollection) Implements IMonitoramento.Grid
        Try
            Dim objDataBase As New DataBaseDAL

            Dim sdMonitoramento As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            pgvGrid.OptionsDetail.AllowZoomDetail = True
            pgvGrid.OptionsDetail.AutoZoomDetail = True

            pgvGridEmpresa.OptionsDetail.AllowZoomDetail = True
            pgvGridEmpresa.OptionsDetail.AutoZoomDetail = True

            pgvGridEmpresaDetalhe.OptionsDetail.AllowZoomDetail = True
            pgvGridEmpresaDetalhe.OptionsDetail.AutoZoomDetail = True

            pgvGridInforme.OptionsDetail.AllowZoomDetail = True
            pgvGridInforme.OptionsDetail.AutoZoomDetail = True

            pgvGridFuncionario.OptionsDetail.AllowZoomDetail = True
            pgvGridFuncionario.OptionsDetail.AutoZoomDetail = True

            Dim dsMonitoramento As New DataSet()
            Dim dtMonitoramento As New DataTable("monitoramento")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtMonitoramento.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtMonitoramento)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drMonitoramento As DataRow = dsMonitoramento.Tables("monitoramento").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drMonitoramento(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("monitoramento").Rows.Add(drMonitoramento)
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
            Dim dtEmpresaDetalhe As New DataTable("empresadetalhe")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtEmpresaDetalhe.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtEmpresaDetalhe)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drEmpresaDetalhe As DataRow = dsMonitoramento.Tables("empresadetalhe").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drEmpresaDetalhe(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("empresadetalhe").Rows.Add(drEmpresaDetalhe)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(3).ToString)
            Dim dtInforme As New DataTable("informe")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtInforme.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtInforme)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drInfome As DataRow = dsMonitoramento.Tables("informe").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drInfome(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("informe").Rows.Add(drInfome)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(4).ToString)
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

            Dim keyColumnEmpresa As DataColumn = dsMonitoramento.Tables("monitoramento").Columns("empresa")
            Dim keyColumnCompetencia As DataColumn = dsMonitoramento.Tables("monitoramento").Columns("competencia")

            Dim foreignKeyColumnEmp As DataColumn = dsMonitoramento.Tables("empresa").Columns("empresa")
            Dim foreignKeyColumnComp As DataColumn = dsMonitoramento.Tables("empresa").Columns("competencia")

            dsMonitoramento.Relations.Add("MonitoramentoEmpresa", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnEmp, foreignKeyColumnComp})

            Dim foreignKeyColumnEmpresaDetalheEmp As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("empresa")
            Dim foreignKeyColumnEmpresaDetalheComp As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("competencia")

            dsMonitoramento.Relations.Add("MonitoramentoEmpresaDetalhe", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnEmpresaDetalheEmp, foreignKeyColumnEmpresaDetalheComp})

            Dim keyColumnEmpresaDetalheEmpresa As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("empresa")
            Dim keyColumnEmpresaDetalheCompetencia As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("competencia")
            Dim keyColumnEmpresaDetalheObrigacao As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("obrigacao")

            Dim foreignkeyColumnInformeEmpresa As DataColumn = dsMonitoramento.Tables("informe").Columns("empresa")
            Dim foreignkeyColumnInformeCompetencia As DataColumn = dsMonitoramento.Tables("informe").Columns("competencia")
            Dim foreignkeyColumnInformeObrigacao As DataColumn = dsMonitoramento.Tables("informe").Columns("obrigacao")

            dsMonitoramento.Relations.Add("MonitoramentoInforme", {keyColumnEmpresaDetalheEmpresa, keyColumnEmpresaDetalheCompetencia, keyColumnEmpresaDetalheObrigacao}, {foreignkeyColumnInformeEmpresa, foreignkeyColumnInformeCompetencia, foreignkeyColumnInformeObrigacao})

            Dim foreignkeyColumnFuncionarioEmpresa As DataColumn = dsMonitoramento.Tables("funcionario").Columns("empresa")
            Dim foreignkeyColumnFuncionarioCompetencia As DataColumn = dsMonitoramento.Tables("funcionario").Columns("competencia")
            Dim foreignkeyColumnFuncionarioObrigacao As DataColumn = dsMonitoramento.Tables("funcionario").Columns("obrigacao")

            dsMonitoramento.Relations.Add("MonitoramentoFuncionario", {keyColumnEmpresaDetalheEmpresa, keyColumnEmpresaDetalheCompetencia, keyColumnEmpresaDetalheObrigacao}, {foreignkeyColumnFuncionarioEmpresa, foreignkeyColumnFuncionarioCompetencia, foreignkeyColumnFuncionarioObrigacao})

            '***********************************************************************************************
            ' Empresa 1
            '***********************************************************************************************
            pdgGrid.DataSource = dsMonitoramento.Tables("monitoramento")
            pdgGrid.ForceInitialize()
            pgvGrid.ViewCaption = "Monitoramento"
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvGrid.OptionsCustomization.AllowQuickHideColumns = False
            pgvGrid.OptionsCustomization.AllowColumnResizing = False
            pgvGrid.OptionsCustomization.AllowColumnMoving = False
            pgvGrid.OptionsCustomization.AllowGroup = False
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            ' Definição de Mascarás no Grid
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
            pgvGrid.Columns(3).Width = 90

            pgvGrid.Columns(4).Caption = "Total de Obrigações"
            pgvGrid.Columns(4).Width = 90

            pgvGrid.Columns(5).Caption = "Obrigações Geradas"
            pgvGrid.Columns(5).Width = 90

            pgvGrid.Columns(6).Caption = "Conferido para Entrega"
            pgvGrid.Columns(6).Width = 90

            pgvGrid.Columns(7).Caption = "Conferido pelo Encarregado"
            pgvGrid.Columns(7).Width = 110

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGrid.Columns(8).ColumnEdit = image
            pgvGrid.Columns(8).Caption = "Status"
            pgvGrid.Columns(8).Width = 120
            '***********************************************************************************************
            'Empresa 1.1
            '***********************************************************************************************
            pdgGrid.LevelTree.Nodes(0).RelationName = "MonitoramentoEmpresa"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridEmpresa
            pgvGridEmpresa.ViewCaption = "Obrigação"
            pgvGridEmpresa.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
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
            pgvGridEmpresa.Columns(11).Visible = False
            pgvGridEmpresa.Columns(12).Visible = False
            pgvGridEmpresa.Columns(13).Visible = False
            pgvGridEmpresa.Columns(14).Visible = False

            ' Definição de Mascarás no Grid
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
            image.SmallImages = picImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridEmpresa.Columns(10).ColumnEdit = image
            pgvGridEmpresa.Columns(10).Caption = "Status"
            pgvGridEmpresa.Columns(10).Width = 120
            '***********************************************************************************************
            'Empresa 1.2
            '***********************************************************************************************
            pdgGrid.LevelTree.Nodes(1).RelationName = "MonitoramentoEmpresaDetalhe"
            pdgGrid.LevelTree.Nodes(1).LevelTemplate = pgvGridEmpresaDetalhe
            pgvGridEmpresaDetalhe.ViewCaption = "Detalhes"
            pgvGridEmpresaDetalhe.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvGridEmpresaDetalhe.PopulateColumns(dsMonitoramento.Tables("empresadetalhe"))
            pgvGridEmpresaDetalhe.OptionsView.ShowGroupPanel = False
            pgvGridEmpresaDetalhe.OptionsBehavior.Editable = False
            pgvGridEmpresaDetalhe.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridEmpresaDetalhe.OptionsCustomization.AllowColumnResizing = False
            pgvGridEmpresaDetalhe.OptionsCustomization.AllowColumnMoving = False
            pgvGridEmpresaDetalhe.OptionsCustomization.AllowGroup = False
            pgvGridEmpresaDetalhe.OptionsView.ColumnAutoWidth = False
            pgvGridEmpresaDetalhe.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridEmpresaDetalhe.ColumnPanelRowHeight = 60
            pgvGridEmpresaDetalhe.OptionsView.ColumnAutoWidth = False
            pgvGridEmpresaDetalhe.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridEmpresaDetalhe.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridEmpresaDetalhe.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridEmpresaDetalhe.Columns(0).Visible = False
            pgvGridEmpresaDetalhe.Columns(3).Visible = False

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridEmpresaDetalhe.Columns(1).ColumnEdit = edit
            pgvGridEmpresaDetalhe.Columns(1).Caption = "Obrigação"
            pgvGridEmpresaDetalhe.Columns(1).Width = 70

            pgvGridEmpresaDetalhe.Columns(2).Caption = "Descrição"
            pgvGridEmpresaDetalhe.Columns(2).Width = 330

            pgvGridEmpresaDetalhe.Columns(4).Caption = "Total"
            pgvGridEmpresaDetalhe.Columns(4).Width = 90

            pgvGridEmpresaDetalhe.Columns(5).Caption = "Obrigações Geradas"
            pgvGridEmpresaDetalhe.Columns(5).Width = 90

            pgvGridEmpresaDetalhe.Columns(6).Caption = "Conferido para Entrega"
            pgvGridEmpresaDetalhe.Columns(6).Width = 90

            pgvGridEmpresaDetalhe.Columns(7).Caption = "Conferido pelo Encarregado"
            pgvGridEmpresaDetalhe.Columns(7).Width = 110

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridEmpresaDetalhe.Columns(8).ColumnEdit = image
            pgvGridEmpresaDetalhe.Columns(8).Caption = "Status"
            pgvGridEmpresaDetalhe.Columns(8).Width = 120
            '***********************************************************************************************
            'Empresa 1.2.1
            '***********************************************************************************************
            pdgGrid.LevelTree.Nodes(1).Nodes(0).RelationName = "MonitoramentoInforme"
            pdgGrid.LevelTree.Nodes(1).Nodes(0).LevelTemplate = pgvGridInforme
            pgvGridInforme.ViewCaption = "Informe"
            pgvGridInforme.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
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
            pgvGridInforme.Columns(11).Visible = False
            pgvGridInforme.Columns(12).Visible = False
            pgvGridInforme.Columns(13).Visible = False
            pgvGridInforme.Columns(14).Visible = False
            pgvGridInforme.Columns(15).Visible = False

            ' Definição de Mascarás no Grid

            pgvGridInforme.Columns(1).Caption = "CNPJ/CPF"
            pgvGridInforme.Columns(1).Width = 130

            pgvGridInforme.Columns(2).Caption = "Nome"
            pgvGridInforme.Columns(2).Width = 230

            pgvGridInforme.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridInforme.Columns(3).Width = 75

            pgvGridInforme.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridInforme.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridInforme.Columns(5).ColumnEdit = edit
            pgvGridInforme.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridInforme.Columns(5).Width = 115

            pgvGridInforme.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridInforme.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridInforme.Columns(7).ColumnEdit = edit
            pgvGridInforme.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridInforme.Columns(7).Width = 115

            pgvGridInforme.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridInforme.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridInforme.Columns(9).ColumnEdit = edit
            pgvGridInforme.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridInforme.Columns(9).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridInforme.Columns(10).ColumnEdit = image
            pgvGridInforme.Columns(10).Caption = "Status"
            pgvGridInforme.Columns(10).Width = 120

            '***********************************************************************************************
            'Empresa 1.2.2
            '***********************************************************************************************
            pdgGrid.LevelTree.Nodes(1).Nodes(1).RelationName = "MonitoramentoFuncionario"
            pdgGrid.LevelTree.Nodes(1).Nodes(1).LevelTemplate = pgvGridFuncionario
            pgvGridFuncionario.ViewCaption = "Funcionario"
            pgvGridFuncionario.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
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
            pgvGridFuncionario.Columns(11).Visible = False
            pgvGridFuncionario.Columns(12).Visible = False
            pgvGridFuncionario.Columns(13).Visible = False
            pgvGridFuncionario.Columns(14).Visible = False
            pgvGridFuncionario.Columns(15).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGridFuncionario.Columns(1).ColumnEdit = edit
            pgvGridFuncionario.Columns(1).Caption = "Funcionário"
            pgvGridFuncionario.Columns(1).Width = 70

            pgvGridFuncionario.Columns(2).Caption = "Nome"
            pgvGridFuncionario.Columns(2).Width = 230

            pgvGridFuncionario.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridFuncionario.Columns(3).Width = 75

            pgvGridFuncionario.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridFuncionario.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridFuncionario.Columns(5).ColumnEdit = edit
            pgvGridFuncionario.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridFuncionario.Columns(5).Width = 115

            pgvGridFuncionario.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridFuncionario.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridFuncionario.Columns(7).ColumnEdit = edit
            pgvGridFuncionario.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridFuncionario.Columns(7).Width = 115

            pgvGridFuncionario.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridFuncionario.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridFuncionario.Columns(9).ColumnEdit = edit
            pgvGridFuncionario.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridFuncionario.Columns(9).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridFuncionario.Columns(10).ColumnEdit = image
            pgvGridFuncionario.Columns(10).Caption = "Status"
            pgvGridFuncionario.Columns(10).Width = 120
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grafico(ByRef pstrQuery As String, pcGrafico As DevExpress.XtraCharts.ChartControl) Implements IMonitoramento.Grafico
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdMonitoramento As SelectedData = objDataBase.QueryFull(pstrQuery)

            Dim dsMonitoramento As New DataSet()
            Dim dtMonitoramento As New DataTable("monitoramento")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtMonitoramento.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtMonitoramento)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drMonitoramento As DataRow = dsMonitoramento.Tables("monitoramento").NewRow()
                For index = 0 To row.Values.Length - 1
                    drMonitoramento(index) = row.Values(index)
                Next
                dsMonitoramento.Tables("monitoramento").Rows.Add(drMonitoramento)
            Next

            Dim dr As DataRow
            For Each dr In dsMonitoramento.Tables(0).Rows

                pcGrafico.Series(0).Points(0).Values = New Double() {dr(0)}
                pcGrafico.Series(1).Points(0).Values = New Double() {dr(1)}
                pcGrafico.Series(2).Points(0).Values = New Double() {dr(2)}
                pcGrafico.Series(3).Points(0).Values = New Double() {dr(3)}
                Dim intTotal As Decimal = 0
                intTotal = dr(0) + dr(1) + dr(2) + dr(3)

                'Adicionar título do gráfico
                pcGrafico.Titles.Clear()
                Dim ctTituloGrafico As New ChartTitle()
                If Not filtroInfo.Filtrado Or filtroInfo.Filtrarpor = "GERADOR" Then
                    ctTituloGrafico.Text = "Gráfico Geral de Monitoramento das Obrigrações das Empresas no Fato Gerador: [" + administrativoInfo.Competencia.Substring(0, 2) + "/" + administrativoInfo.Competencia.Substring(2, 4) + "]"
                Else
                    If filtroInfo.TipoVencimento = "DIAS" Then
                        If filtroInfo.Dias > 1 Or filtroInfo.Dias < -1 Then
                            ctTituloGrafico.Text = "Gráfico Geral de Monitoramento das Obrigrações das Empresas do período de: [" + filtroInfo.Dias.ToString + " dias]"
                        ElseIf filtroInfo.Dias = 0 Then
                            ctTituloGrafico.Text = "Gráfico Geral de Monitoramento das Obrigrações das Empresas que vencem: [Hoje]"
                        ElseIf filtroInfo.Dias = 1 Then
                            ctTituloGrafico.Text = "Gráfico Geral de Monitoramento das Obrigrações das Empresas que vencem: [Amanhã]"
                        ElseIf filtroInfo.Dias = -1 Then
                            ctTituloGrafico.Text = "Gráfico Geral de Monitoramento das Obrigrações das Empresas que venceram: [Ontem]"
                        End If
                    ElseIf filtroInfo.TipoVencimento = "PERIODO" Then
                        ctTituloGrafico.Text = "Gráfico Geral de Monitoramento das Obrigrações das Empresas do período: [" + filtroInfo.DataInicial.Value.ToShortDateString + " a " + filtroInfo.DataFinal.Value.ToShortDateString + "]"
                    End If
                End If
                pcGrafico.Titles.Add(ctTituloGrafico)
                ctTituloGrafico.Font = New Font("Tahoma", 12)
                Dim ctSubTituloGrafico As New ChartTitle()
                ctSubTituloGrafico.Text = "Total de Obrigações: [" + intTotal.ToString("0,00") + "]"
                ctSubTituloGrafico.Font = New Font("Tahoma", 10)
                pcGrafico.Titles.Add(ctSubTituloGrafico)
            Next dr
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
