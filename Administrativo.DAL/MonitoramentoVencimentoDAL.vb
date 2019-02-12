Imports Administrativo.Modelo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing

Public Class MonitoramentoVencimentoDAL
    Implements IMonitoramentoVencimento

    Private edit As RepositoryItemTextEdit
    Private image As RepositoryItemImageComboBox

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridObrigacao As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pgvGridEmpresaDetalhe As GridView, ByVal pgvGridInforme As GridView, ByVal pgvGridFuncionario As GridView, picVencimentoImageColection As DevExpress.Utils.ImageCollection, picEmpresaImageColection As DevExpress.Utils.ImageCollection) Implements IMonitoramentoVencimento.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdMonitoramento As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsMonitoramento As New DataSet()
            Dim dtMonitoramento As New DataTable("monitoramento")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtMonitoramento.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtMonitoramento)
            
            pgvGrid.OptionsDetail.AllowZoomDetail = True
            pgvGrid.OptionsDetail.AutoZoomDetail = True

            pgvGridObrigacao.OptionsDetail.AllowZoomDetail = True
            pgvGridObrigacao.OptionsDetail.AutoZoomDetail = True

            pgvGridEmpresa.OptionsDetail.AllowZoomDetail = True
            pgvGridEmpresa.OptionsDetail.AutoZoomDetail = True

            pgvGridEmpresaDetalhe.OptionsDetail.AllowZoomDetail = True
            pgvGridEmpresaDetalhe.OptionsDetail.AutoZoomDetail = True

            pgvGridInforme.OptionsDetail.AllowZoomDetail = True
            pgvGridInforme.OptionsDetail.AutoZoomDetail = True

            pgvGridFuncionario.OptionsDetail.AllowZoomDetail = True
            pgvGridFuncionario.OptionsDetail.AutoZoomDetail = True

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVencimentoImageColection

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drMonitoramento As DataRow = dsMonitoramento.Tables("monitoramento").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drMonitoramento(index) = row.Values(index)
                    End If
                Next
                If row.Values(0) = 1 Then
                    image.Items.Add(New ImageComboBoxItem("Obrigações que vencem hoje: " + String.Format("{0:N0}", row.Values(1)), 1, 0))
                ElseIf row.Values(0) = 2 Then
                    image.Items.Add(New ImageComboBoxItem("Obrigações a vencer: " + String.Format("{0:N0}", row.Values(1)), 2, 1))
                ElseIf row.Values(0) = 3 Then
                    image.Items.Add(New ImageComboBoxItem("Obrigações vencidas: " + String.Format("{0:N0}", row.Values(1)), 3, 2))
                ElseIf row.Values(0) = 4 Then
                    image.Items.Add(New ImageComboBoxItem("Obrigações entregues no prazo: " + String.Format("{0:N0}", row.Values(1)), 4, 3))
                ElseIf row.Values(0) = 5 Then
                    image.Items.Add(New ImageComboBoxItem("Obrigações entregues fora do prazo: " + String.Format("{0:N0}", row.Values(1)), 5, 4))
                End If
                dsMonitoramento.Tables("monitoramento").Rows.Add(drMonitoramento)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtObrigacao As New DataTable("obrigacao")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtObrigacao)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drObrigacao As DataRow = dsMonitoramento.Tables("obrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drObrigacao(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("obrigacao").Rows.Add(drObrigacao)
            Next


            sdMonitoramento = objDataBase.QueryFull(pstrQuery(2).ToString)
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

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(3).ToString)
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

            Dim keyColumnmonitoramento As DataColumn = dsMonitoramento.Tables("monitoramento").Columns("status")
            Dim foreignKeyColumnObrigacaoStatus As DataColumn = dsMonitoramento.Tables("obrigacao").Columns("status")

            Dim keyColumnstatus As DataColumn = dsMonitoramento.Tables("obrigacao").Columns("status")
            Dim keyColumnobrigacao As DataColumn = dsMonitoramento.Tables("obrigacao").Columns("obrigacao")
            Dim foreignKeyColumnEmpresaStatus As DataColumn = dsMonitoramento.Tables("empresa").Columns("status")
            Dim foreignKeyColumnEmpresaObrigacao As DataColumn = dsMonitoramento.Tables("empresa").Columns("obrigacao")

            Dim foreignKeyColumnEmpresaDetalheStatus As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("status")
            Dim foreignKeyColumnEmpresaDetalheObrigacao As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("obrigacao")
            
            Dim KeyColumnEmpresaStatus As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("status")
            Dim KeyColumnEmpresaObrigacao As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("obrigacao")
            Dim KeyColumnEmpresaEmpresa As DataColumn = dsMonitoramento.Tables("empresadetalhe").Columns("empresa")

            Dim foreignKeyColumnEmpresaInformeStatus As DataColumn = dsMonitoramento.Tables("informe").Columns("status")
            Dim foreignKeyColumnEmpresaInformeObrigacao As DataColumn = dsMonitoramento.Tables("informe").Columns("obrigacao")
            Dim foreignKeyColumnEmpresaInformeEmpresa As DataColumn = dsMonitoramento.Tables("informe").Columns("empresa")

            Dim foreignKeyColumnEmpresaFuncionarioStatus As DataColumn = dsMonitoramento.Tables("funcionario").Columns("status")
            Dim foreignKeyColumnEmpresaFuncionarioObrigacao As DataColumn = dsMonitoramento.Tables("funcionario").Columns("obrigacao")
            Dim foreignKeyColumnEmpresaFuncionarioEmpresa As DataColumn = dsMonitoramento.Tables("funcionario").Columns("empresa")

            Dim relationObrigacao As DataRelation
            Dim relationEmpresa As DataRelation
            Dim relationEmpresaDetalhe As DataRelation
            Dim relationInforme As DataRelation
            Dim relationFuncionario As DataRelation

            relationObrigacao = New DataRelation("MonitoramentoObrigacao", keyColumnmonitoramento, foreignKeyColumnObrigacaoStatus)
            dsMonitoramento.Relations.Add(relationObrigacao)
            
            relationEmpresa = New DataRelation("ObrigacaoEmpresa", {keyColumnstatus, keyColumnobrigacao}, {foreignKeyColumnEmpresaStatus, foreignKeyColumnEmpresaObrigacao})
            dsMonitoramento.Relations.Add(relationEmpresa)

            relationEmpresaDetalhe = New DataRelation("ObrigacaoEmpresaDetalhe", {keyColumnstatus, keyColumnobrigacao}, {foreignKeyColumnEmpresaDetalheStatus, foreignKeyColumnEmpresaDetalheObrigacao})
            dsMonitoramento.Relations.Add(relationEmpresaDetalhe)
            
            relationInforme = New DataRelation("ObrigacaoEmpresaInforme", {KeyColumnEmpresaStatus, KeyColumnEmpresaObrigacao, KeyColumnEmpresaEmpresa}, {foreignKeyColumnEmpresaInformeStatus, foreignKeyColumnEmpresaInformeObrigacao, foreignKeyColumnEmpresaInformeEmpresa})
            dsMonitoramento.Relations.Add(relationInforme)

            relationFuncionario = New DataRelation("ObrigacaoEmpresaFuncionario", {KeyColumnEmpresaStatus, KeyColumnEmpresaObrigacao, KeyColumnEmpresaEmpresa}, {foreignKeyColumnEmpresaFuncionarioStatus, foreignKeyColumnEmpresaFuncionarioObrigacao, foreignKeyColumnEmpresaFuncionarioEmpresa})
            dsMonitoramento.Relations.Add(relationFuncionario)

            pdgGrid.DataSource = dsMonitoramento.Tables("monitoramento")
            pdgGrid.ForceInitialize()
            pgvGrid.ViewCaption = "Data de Vencimento"
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

            pgvGrid.Columns(1).Visible = False

            pgvGrid.Columns(0).ColumnEdit = image
            pgvGrid.Columns(0).Caption = "Status"
            pgvGrid.Columns(0).AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Near

            '***************************************************************************
            ' Monitoramento / Obrigação
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(0).RelationName = "MonitoramentoObrigacao"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridObrigacao
            pgvGridObrigacao.ViewCaption = "Obrigações"
            pgvGridObrigacao.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvGridObrigacao.PopulateColumns(dsMonitoramento.Tables("obrigacao"))
            pgvGridObrigacao.OptionsView.ShowGroupPanel = False
            pgvGridObrigacao.OptionsBehavior.Editable = False
            pgvGridObrigacao.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridObrigacao.OptionsCustomization.AllowColumnResizing = False
            pgvGridObrigacao.OptionsCustomization.AllowColumnMoving = False
            pgvGridObrigacao.OptionsCustomization.AllowGroup = False
            pgvGridObrigacao.OptionsView.ColumnAutoWidth = False
            pgvGridObrigacao.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridObrigacao.ColumnPanelRowHeight = 60
            pgvGridObrigacao.OptionsView.ColumnAutoWidth = False
            pgvGridObrigacao.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridObrigacao.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridObrigacao.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridObrigacao.Columns(0).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridObrigacao.Columns(1).ColumnEdit = edit
            pgvGridObrigacao.Columns(1).Caption = "Obrigação"
            pgvGridObrigacao.Columns(1).Width = 80

            pgvGridObrigacao.Columns(2).Caption = "Descrição"
            pgvGridObrigacao.Columns(2).Width = 600

            pgvGridObrigacao.Columns(3).Caption = "Total de Empresas"
            pgvGridObrigacao.Columns(3).Width = 90

            '***************************************************************************
            ' Obrigação / Empresa
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(0).Nodes(0).RelationName = "ObrigacaoEmpresa"
            pdgGrid.LevelTree.Nodes(0).Nodes(0).LevelTemplate = pgvGridEmpresa
            pgvGridEmpresa.ViewCaption = "Empresas"
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
            pgvGridEmpresa.Columns(1).Visible = False
            pgvGridEmpresa.Columns(13).Visible = False
            pgvGridEmpresa.Columns(14).Visible = False
            pgvGridEmpresa.Columns(15).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGridEmpresa.Columns(2).ColumnEdit = edit
            pgvGridEmpresa.Columns(2).Caption = "Empresa"
            pgvGridEmpresa.Columns(2).Width = 65

            pgvGridEmpresa.Columns(3).Caption = "Razão Social"
            pgvGridEmpresa.Columns(3).Width = 250

            pgvGridEmpresa.Columns(4).Caption = "CNPJ"
            pgvGridEmpresa.Columns(4).Width = 130

            pgvGridEmpresa.Columns(5).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridEmpresa.Columns(5).Width = 80

            pgvGridEmpresa.Columns(6).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridEmpresa.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(7).ColumnEdit = edit
            pgvGridEmpresa.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridEmpresa.Columns(7).Width = 115

            pgvGridEmpresa.Columns(8).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridEmpresa.Columns(8).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(9).ColumnEdit = edit
            pgvGridEmpresa.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridEmpresa.Columns(9).Width = 115

            pgvGridEmpresa.Columns(10).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridEmpresa.Columns(10).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridEmpresa.Columns(11).ColumnEdit = edit
            pgvGridEmpresa.Columns(11).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridEmpresa.Columns(11).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEmpresaImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridEmpresa.Columns(12).ColumnEdit = image
            pgvGridEmpresa.Columns(12).Caption = "Status"
            pgvGridEmpresa.Columns(12).Width = 115

            '***************************************************************************
            ' Obrigação / Empresa - Detalhe
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(0).Nodes(1).RelationName = "ObrigacaoEmpresaDetalhe"
            pdgGrid.LevelTree.Nodes(0).Nodes(1).LevelTemplate = pgvGridEmpresaDetalhe
            pgvGridEmpresaDetalhe.ViewCaption = "Empresas"
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
            pgvGridEmpresaDetalhe.Columns(1).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGridEmpresaDetalhe.Columns(2).ColumnEdit = edit
            pgvGridEmpresaDetalhe.Columns(2).Caption = "Empresa"
            pgvGridEmpresaDetalhe.Columns(2).Width = 65

            pgvGridEmpresaDetalhe.Columns(3).Caption = "Razão Social"
            pgvGridEmpresaDetalhe.Columns(3).Width = 250

            pgvGridEmpresaDetalhe.Columns(4).Caption = "CNPJ"
            pgvGridEmpresaDetalhe.Columns(4).Width = 110

            pgvGridEmpresaDetalhe.Columns(5).Caption = "Total" + Environment.NewLine + "Obrigações"
            pgvGridEmpresaDetalhe.Columns(5).Width = 80
            
            '***************************************************************************
            ' Obrigação / Empresa - Detalhe / Infome
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(0).Nodes(1).Nodes(0).RelationName = "ObrigacaoEmpresaInforme"
            pdgGrid.LevelTree.Nodes(0).Nodes(1).Nodes(0).LevelTemplate = pgvGridInforme
            pgvGridInforme.ViewCaption = "Infome"
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
            pgvGridInforme.Columns(1).Visible = False
            pgvGridInforme.Columns(2).Visible = False
            pgvGridInforme.Columns(13).Visible = False
            pgvGridInforme.Columns(14).Visible = False
            pgvGridInforme.Columns(15).Visible = False

            pgvGridInforme.Columns(3).Caption = "CNPJ/CPF"
            pgvGridInforme.Columns(3).Width = 130

            pgvGridInforme.Columns(4).Caption = "Nome"
            pgvGridInforme.Columns(4).Width = 400

            pgvGridInforme.Columns(5).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridInforme.Columns(5).Width = 80

            pgvGridInforme.Columns(6).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridInforme.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridInforme.Columns(7).ColumnEdit = edit
            pgvGridInforme.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridInforme.Columns(7).Width = 115

            pgvGridInforme.Columns(8).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridInforme.Columns(8).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridInforme.Columns(9).ColumnEdit = edit
            pgvGridInforme.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridInforme.Columns(9).Width = 115

            pgvGridInforme.Columns(10).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridInforme.Columns(10).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridInforme.Columns(11).ColumnEdit = edit
            pgvGridInforme.Columns(11).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridInforme.Columns(11).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEmpresaImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridInforme.Columns(12).ColumnEdit = image
            pgvGridInforme.Columns(12).Caption = "Status"
            pgvGridInforme.Columns(12).Width = 115

            '***************************************************************************
            ' Obrigação / Empresa - Detalhe / Funcionario
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(0).Nodes(1).Nodes(1).RelationName = "ObrigacaoEmpresaFuncionario"
            pdgGrid.LevelTree.Nodes(0).Nodes(1).Nodes(1).LevelTemplate = pgvGridFuncionario
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
            pgvGridFuncionario.Columns(1).Visible = False
            pgvGridFuncionario.Columns(2).Visible = False
            pgvGridFuncionario.Columns(13).Visible = False
            pgvGridFuncionario.Columns(14).Visible = False
            pgvGridFuncionario.Columns(15).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGridFuncionario.Columns(3).ColumnEdit = edit
            pgvGridFuncionario.Columns(3).Caption = "Funcionário"
            pgvGridFuncionario.Columns(3).Width = 65

            pgvGridFuncionario.Columns(4).Caption = "Nome"
            pgvGridFuncionario.Columns(4).Width = 250

            pgvGridFuncionario.Columns(5).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvGridFuncionario.Columns(5).Width = 80

            pgvGridFuncionario.Columns(6).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvGridFuncionario.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridFuncionario.Columns(7).ColumnEdit = edit
            pgvGridFuncionario.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvGridFuncionario.Columns(7).Width = 115

            pgvGridFuncionario.Columns(8).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvGridFuncionario.Columns(8).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridFuncionario.Columns(9).ColumnEdit = edit
            pgvGridFuncionario.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvGridFuncionario.Columns(9).Width = 115

            pgvGridFuncionario.Columns(10).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvGridFuncionario.Columns(10).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvGridFuncionario.Columns(11).ColumnEdit = edit
            pgvGridFuncionario.Columns(11).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvGridFuncionario.Columns(11).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEmpresaImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridFuncionario.Columns(12).ColumnEdit = image
            pgvGridFuncionario.Columns(12).Caption = "Status"
            pgvGridFuncionario.Columns(12).Width = 115

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grafico(ByRef pstrQuery As String, pcGrafico As DevExpress.XtraCharts.ChartControl) Implements IMonitoramentoVencimento.Grafico
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

            For index = 0 To Convert.ToInt32(pcGrafico.Series.Count) - 1
                pcGrafico.Series(index).Points(0).Values = New Double() {0}
            Next

            Dim intTotal As Decimal = 0
            Dim dr As DataRow
            For Each dr In dsMonitoramento.Tables(0).Rows
                pcGrafico.Series(dr(0) - 1).Points(0).Values = New Double() {dr(1)}
                intTotal += dr(1)
            Next dr
            pcGrafico.Titles.Clear()
            Dim ctTituloGrafico As New ChartTitle()
            If Not filtroInfo.Filtrado Or filtroInfo.Filtrarpor = "GERADOR" Then
                ctTituloGrafico.Text = "Gráfico com a situação de Vencimento das Empresas com as obrigações geradas no Fato Gerador: [" + administrativoInfo.Competencia.Substring(0, 2) + "/" + administrativoInfo.Competencia.Substring(2, 4) + "]"
            Else
                If filtroInfo.TipoVencimento = "DIAS" Then
                    If filtroInfo.Dias > 1 Or filtroInfo.Dias < -1 Then
                        ctTituloGrafico.Text = "Gráfico com a situação de Vencimento das Empresas com as obrigações geradas no período de: [" + filtroInfo.Dias.ToString + " dias]"
                    ElseIf filtroInfo.Dias = 0 Then
                        ctTituloGrafico.Text = "Gráfico com a situação de Vencimento das Empresas com as obrigações geradas que vencem: [Hoje]"
                    ElseIf filtroInfo.Dias = 1 Then
                        ctTituloGrafico.Text = "Gráfico com a situação de Vencimento das Empresas com as obrigações geradas que vencem: [Amanhã]"
                    ElseIf filtroInfo.Dias = -1 Then
                        ctTituloGrafico.Text = "Gráfico com a situação de Vencimento das Empresas com as obrigações geradas que venceram: [Ontem]"
                    End If
                ElseIf filtroInfo.TipoVencimento = "PERIODO" Then
                    ctTituloGrafico.Text = "Gráfico com a situação de Vencimento das Empresas com as obrigações geradas no período: [" + filtroInfo.DataInicial.Value.ToShortDateString + " a " + filtroInfo.DataFinal.Value.ToShortDateString + "]"
                End If
            End If
            ctTituloGrafico.Font = New Font("Tahoma", 12)
            pcGrafico.Titles.Add(ctTituloGrafico)
            Dim ctSubTituloGrafico As New ChartTitle()
            ctSubTituloGrafico.Text = "Total de Obrigações: [" + intTotal.ToString("0,00") + "]"
            ctSubTituloGrafico.Font = New Font("Tahoma", 10)
            pcGrafico.Titles.Add(ctSubTituloGrafico)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class