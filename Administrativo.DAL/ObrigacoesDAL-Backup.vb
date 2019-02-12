Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Public Class ObrigacoesDAL
   Implements IObrigacoes

   Private edit As RepositoryItemTextEdit
   Private obrigacoesusuariosRibbonControl As RibbonControl

   Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView,
                   pgvGridItem As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridCpr As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridIss As DevExpress.XtraGrid.Views.Grid.GridView,
                   pgvGridEiss As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridIe As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridCnpj As DevExpress.XtraGrid.Views.Grid.GridView) Implements IObrigacoes.Grid
      Try
         Dim objDataBase As New DataBaseDAL
         Dim sdObrigacoes As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

         Dim dsObrigacoes As New DataSet()
         Dim dtObrigacao As New DataTable("obrigacao")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtObrigacao)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drObrigacao As DataRow = dsObrigacoes.Tables("obrigacao").NewRow()
            For index = 0 To row.Values.Length - 1
               drObrigacao(index) = row.Values(index)
            Next
            dsObrigacoes.Tables("obrigacao").Rows.Add(drObrigacao)
         Next

         sdObrigacoes = objDataBase.QueryFull(pstrQuery(1).ToString)
         Dim dtItem As New DataTable("item")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtItem.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtItem)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drItem As DataRow = dsObrigacoes.Tables("item").NewRow()
            For index = 0 To row.Values.Length - 1
               drItem(index) = row.Values(index)
            Next
            dsObrigacoes.Tables("item").Rows.Add(drItem)
         Next

         sdObrigacoes = objDataBase.QueryFull(pstrQuery(2).ToString)
         Dim dtCpr As New DataTable("cpr")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtCpr.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtCpr)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drCpr As DataRow = dsObrigacoes.Tables("cpr").NewRow()
            For index = 0 To row.Values.Length - 1
               drCpr(index) = row.Values(index)
            Next
            dsObrigacoes.Tables("cpr").Rows.Add(drCpr)
         Next

         sdObrigacoes = objDataBase.QueryFull(pstrQuery(3).ToString)
         Dim dtIss As New DataTable("iss")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtIss.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtIss)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drIss As DataRow = dsObrigacoes.Tables("iss").NewRow()
            For index = 0 To row.Values.Length - 1
               drIss(index) = row.Values(index)
            Next
            dsObrigacoes.Tables("iss").Rows.Add(drIss)
         Next

         sdObrigacoes = objDataBase.QueryFull(pstrQuery(4).ToString)
         Dim dtEiss As New DataTable("eiss")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtEiss.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtEiss)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drEiss As DataRow = dsObrigacoes.Tables("eiss").NewRow()
            For index = 0 To row.Values.Length - 1
               drEiss(index) = row.Values(index)
            Next
            dsObrigacoes.Tables("eiss").Rows.Add(drEiss)
         Next

         sdObrigacoes = objDataBase.QueryFull(pstrQuery(5).ToString)
         Dim dtIe As New DataTable("ie")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtIe.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtIe)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drIe As DataRow = dsObrigacoes.Tables("ie").NewRow()
            For index = 0 To row.Values.Length - 1
               drIe(index) = row.Values(index)
            Next
            dsObrigacoes.Tables("ie").Rows.Add(drIe)
         Next

         sdObrigacoes = objDataBase.QueryFull(pstrQuery(6).ToString)
         Dim dtCnpj As New DataTable("cnpj")
         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(0).Rows
            dtCnpj.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
         Next
         dsObrigacoes.Tables.Add(dtCnpj)

         For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
            Dim drCnpj As DataRow = dsObrigacoes.Tables("cnpj").NewRow()
            For index = 0 To row.Values.Length - 1
               drCnpj(index) = row.Values(index)
            Next
            dsObrigacoes.Tables.Add(dtCnpj)

            For Each row As SelectStatementResultRow In sdObrigacoes.ResultSet(1).Rows
                Dim drCnpj As DataRow = dsObrigacoes.Tables("cnpj").NewRow()
                For index = 0 To row.Values.Length - 1
                    drCnpj(index) = row.Values(index)
                Next
                dsObrigacoes.Tables("cnpj").Rows.Add(drCnpj)
            Next

            Dim keyColumn As DataColumn = dsObrigacoes.Tables("obrigacao").Columns("obrigacao")

            Dim foreignKeyColumnItem As DataColumn = dsObrigacoes.Tables("item").Columns("obrigacao")
            Dim foreignKeyColumnCpr As DataColumn = dsObrigacoes.Tables("cpr").Columns("obrigacao")
            Dim foreignKeyColumnIss As DataColumn = dsObrigacoes.Tables("iss").Columns("obrigacao")
            Dim foreignKeyColumnEiss As DataColumn = dsObrigacoes.Tables("eiss").Columns("obrigacao")
            Dim foreignKeyColumnIe As DataColumn = dsObrigacoes.Tables("ie").Columns("obrigacao")
            Dim foreignKeyColumnCnpj As DataColumn = dsObrigacoes.Tables("cnpj").Columns("obrigacao")

            Dim relationItem As DataRelation
            Dim relationCpr As DataRelation
            Dim relationIss As DataRelation
            Dim relationEiss As DataRelation
            Dim relationIe As DataRelation
            Dim relationCnpj As DataRelation

            relationItem = New DataRelation("ObrigacaoItem", keyColumn, foreignKeyColumnItem)
            dsObrigacoes.Relations.Add(relationItem)

            relationCpr = New DataRelation("ObrigacaoCpr", keyColumn, foreignKeyColumnCpr)
            dsObrigacoes.Relations.Add(relationCpr)

            relationIss = New DataRelation("ObrigacaoIss", keyColumn, foreignKeyColumnIss)
            dsObrigacoes.Relations.Add(relationIss)

            relationEiss = New DataRelation("ObrigacaoEiss", keyColumn, foreignKeyColumnEiss)
            dsObrigacoes.Relations.Add(relationEiss)

            relationIe = New DataRelation("ObrigacaoIe", keyColumn, foreignKeyColumnIe)
            dsObrigacoes.Relations.Add(relationIe)

            relationCnpj = New DataRelation("ObrigacaoCnpj", keyColumn, foreignKeyColumnCnpj)
            dsObrigacoes.Relations.Add(relationCnpj)

            pdgGrid.DataSource = dsObrigacoes.Tables("obrigacao")
            pdgGrid.ForceInitialize()
            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Obrigação"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Descrição"
            pgvGrid.Columns(1).Width = 450

            pgvGrid.Columns(2).Caption = "Sistema"
            pgvGrid.Columns(2).Width = 200

            pgvGrid.Columns(3).Visible = False
            pgvGrid.Columns(4).Visible = False

            '***************************************************************************
            ' ITEM
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(0).RelationName = "ObrigacaoItem"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridItem
            pgvGridItem.ViewCaption = pstrTituloGrid(1).ToString
            pgvGridItem.PopulateColumns(dsObrigacoes.Tables("item"))
            pgvGridItem.OptionsView.ShowGroupPanel = False
            pgvGridItem.OptionsBehavior.Editable = False
            pgvGridItem.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridItem.OptionsCustomization.AllowColumnResizing = False
            pgvGridItem.OptionsCustomization.AllowColumnMoving = False
            pgvGridItem.OptionsCustomization.AllowGroup = False
            pgvGridItem.OptionsView.ColumnAutoWidth = False
            pgvGridItem.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridItem.ColumnPanelRowHeight = 60
            pgvGridItem.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridItem.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridItem.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridItem.Columns(0).Visible = False
            pgvGridItem.Columns(1).Visible = False
            pgvGridItem.Columns(2).Visible = False

            pgvGridItem.Columns(3).Caption = "Periodicidade"
            pgvGridItem.Columns(3).Width = 80

            pgvGridItem.Columns(4).Caption = "Tipo " + Environment.NewLine + "Vencimento"
            pgvGridItem.Columns(4).Width = 80

            pgvGridItem.Columns(5).Caption = "Dia"
            pgvGridItem.Columns(5).Width = 80

            pgvGridItem.Columns(6).Caption = "Tributo"
            pgvGridItem.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridItem.Columns(7).ColumnEdit = edit
            pgvGridItem.Columns(7).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGridItem.Columns(7).Width = 80

            pgvGridItem.Columns(8).Caption = "Subseqüente"
            pgvGridItem.Columns(8).Width = 80

            pgvGridItem.Columns(9).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGridItem.Columns(9).Width = 90

            pgvGridItem.Columns(10).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGridItem.Columns(10).Width = 100

            pgvGridItem.Columns(11).Caption = "Antecipa" + Environment.NewLine + "dia Util"
            pgvGridItem.Columns(11).Width = 70

            pgvGridItem.Columns(12).Visible = False

            '***************************************************************************
            ' CPR
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(1).RelationName = "ObrigacaoCpr"
            pdgGrid.LevelTree.Nodes(1).LevelTemplate = pgvGridCpr

            pgvGridCpr.ViewCaption = pstrTituloGrid(2).ToString
            pgvGridCpr.PopulateColumns(dsObrigacoes.Tables("cpr"))
            pgvGridCpr.OptionsView.ShowGroupPanel = False
            pgvGridCpr.OptionsBehavior.Editable = False
            pgvGridCpr.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridCpr.OptionsCustomization.AllowColumnResizing = False
            pgvGridCpr.OptionsCustomization.AllowColumnMoving = False
            pgvGridCpr.OptionsCustomization.AllowGroup = False
            pgvGridCpr.OptionsView.ColumnAutoWidth = False
            pgvGridCpr.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridCpr.ColumnPanelRowHeight = 60
            pgvGridCpr.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridCpr.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridCpr.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridCpr.Columns(0).Visible = False
            pgvGridCpr.Columns(1).Visible = False
            pgvGridCpr.Columns(2).Visible = False

            pgvGridCpr.Columns(3).Caption = "CPR"
            pgvGridCpr.Columns(3).Width = 70

            pgvGridCpr.Columns(4).Caption = "Periodicidade"
            pgvGridCpr.Columns(4).Width = 80

            pgvGridCpr.Columns(5).Caption = "Tipo " + Environment.NewLine + "Vencimento"
            pgvGridCpr.Columns(5).Width = 80

            pgvGridCpr.Columns(6).Caption = "Dia"
            pgvGridCpr.Columns(6).Width = 80

            pgvGridCpr.Columns(7).Caption = "Tributo"
            pgvGridCpr.Columns(7).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridCpr.Columns(8).ColumnEdit = edit
            pgvGridCpr.Columns(8).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGridCpr.Columns(8).Width = 80

            pgvGridCpr.Columns(9).Caption = "Subseqüente"
            pgvGridCpr.Columns(9).Width = 80

            pgvGridCpr.Columns(10).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGridCpr.Columns(10).Width = 90

            pgvGridCpr.Columns(11).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGridCpr.Columns(11).Width = 100

            pgvGridCpr.Columns(12).Caption = "Antecipa" + Environment.NewLine + "dia Util"
            pgvGridCpr.Columns(12).Width = 70

            pgvGridCpr.Columns(13).Visible = False

            '***************************************************************************
            ' ISS
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(2).RelationName = "ObrigacaoIss"
            pdgGrid.LevelTree.Nodes(2).LevelTemplate = pgvGridIss
            pgvGridIss.ViewCaption = pstrTituloGrid(3).ToString
            pgvGridIss.PopulateColumns(dsObrigacoes.Tables("iss"))
            pgvGridIss.OptionsView.ShowGroupPanel = False
            pgvGridIss.OptionsBehavior.Editable = False
            pgvGridIss.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridIss.OptionsCustomization.AllowColumnResizing = False
            pgvGridIss.OptionsCustomization.AllowColumnMoving = False
            pgvGridIss.OptionsCustomization.AllowGroup = False
            pgvGridIss.OptionsView.ColumnAutoWidth = False
            pgvGridIss.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridIss.ColumnPanelRowHeight = 60
            pgvGridIss.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridIss.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridIss.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridIss.Columns(0).Visible = False
            pgvGridIss.Columns(1).Visible = False
            pgvGridIss.Columns(2).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridIss.Columns(3).ColumnEdit = edit
            pgvGridIss.Columns(3).Caption = "Município"
            pgvGridIss.Columns(3).Width = 90

            pgvGridIss.Columns(4).Caption = "Nome"
            pgvGridIss.Columns(4).Width = 300

            pgvGridIss.Columns(5).Caption = "Periodicidade"
            pgvGridIss.Columns(5).Width = 80

         Dim keyColumn As DataColumn = dsObrigacoes.Tables("obrigacao").Columns("obrigacao")

         Dim foreignKeyColumnItem As DataColumn = dsObrigacoes.Tables("item").Columns("obrigacao")
         Dim foreignKeyColumnCpr As DataColumn = dsObrigacoes.Tables("cpr").Columns("obrigacao")
         Dim foreignKeyColumnIss As DataColumn = dsObrigacoes.Tables("iss").Columns("obrigacao")
         Dim foreignKeyColumnEiss As DataColumn = dsObrigacoes.Tables("eiss").Columns("obrigacao")
         Dim foreignKeyColumnIe As DataColumn = dsObrigacoes.Tables("ie").Columns("obrigacao")
         Dim foreignKeyColumnCnpj As DataColumn = dsObrigacoes.Tables("cnpj").Columns("obrigacao")

         Dim relationItem As DataRelation
         Dim relationCpr As DataRelation
         Dim relationIss As DataRelation
         Dim relationEiss As DataRelation
         Dim relationIe As DataRelation
         Dim relationCnpj As DataRelation

         relationItem = New DataRelation("ObrigacaoItem", keyColumn, foreignKeyColumnItem)
         dsObrigacoes.Relations.Add(relationItem)

         relationCpr = New DataRelation("ObrigacaoCpr", keyColumn, foreignKeyColumnCpr)
         dsObrigacoes.Relations.Add(relationCpr)

         relationIss = New DataRelation("ObrigacaoIss", keyColumn, foreignKeyColumnIss)
         dsObrigacoes.Relations.Add(relationIss)

         relationEiss = New DataRelation("ObrigacaoEiss", keyColumn, foreignKeyColumnEiss)
         dsObrigacoes.Relations.Add(relationEiss)

         relationIe = New DataRelation("ObrigacaoIe", keyColumn, foreignKeyColumnIe)
         dsObrigacoes.Relations.Add(relationIe)

         relationCnpj = New DataRelation("ObrigacaoCnpj", keyColumn, foreignKeyColumnCnpj)
         dsObrigacoes.Relations.Add(relationCnpj)

         pdgGrid.DataSource = dsObrigacoes.Tables("obrigacao")
         pdgGrid.ForceInitialize()
         pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
         pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

         ' Definição de Mascarás no Grid
         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "0-00000"
         pgvGrid.Columns(0).ColumnEdit = edit
         pgvGrid.Columns(0).Caption = "Obrigação"
         pgvGrid.Columns(0).Width = 80

         pgvGrid.Columns(1).Caption = "Descrição"
         pgvGrid.Columns(1).Width = 450

         pgvGrid.Columns(2).Caption = "Sistema"
         pgvGrid.Columns(2).Width = 200

         pgvGrid.Columns(3).Visible = False
         pgvGrid.Columns(4).Visible = False
         pgvGrid.Columns(5).Visible = False
         pgvGrid.Columns(6).Visible = False

         '***************************************************************************
         ' ITEM
         '***************************************************************************
         pdgGrid.LevelTree.Nodes(0).RelationName = "ObrigacaoItem"
         pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridItem
         pgvGridItem.ViewCaption = pstrTituloGrid(1).ToString
         pgvGridItem.PopulateColumns(dsObrigacoes.Tables("item"))
         pgvGridItem.OptionsView.ShowGroupPanel = False
         pgvGridItem.OptionsBehavior.Editable = False
         pgvGridItem.OptionsCustomization.AllowQuickHideColumns = False
         pgvGridItem.OptionsCustomization.AllowColumnResizing = False
         pgvGridItem.OptionsCustomization.AllowColumnMoving = False
         pgvGridItem.OptionsCustomization.AllowGroup = False
         pgvGridItem.OptionsView.ColumnAutoWidth = False
         pgvGridItem.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

         pgvGridItem.ColumnPanelRowHeight = 60
         pgvGridItem.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGridItem.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGridItem.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         pgvGridItem.Columns(0).Visible = False
         pgvGridItem.Columns(1).Visible = False
         pgvGridItem.Columns(2).Visible = False

         pgvGridItem.Columns(3).Caption = "Periodicidade"
         pgvGridItem.Columns(3).Width = 80

         pgvGridItem.Columns(4).Caption = "Tipo " + Environment.NewLine + "Vencimento"
         pgvGridItem.Columns(4).Width = 80

         pgvGridItem.Columns(5).Caption = "Dia"
         pgvGridItem.Columns(5).Width = 80

         pgvGridItem.Columns(6).Caption = "Tributo"
         pgvGridItem.Columns(6).Width = 70

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00/0000"
         pgvGridItem.Columns(7).ColumnEdit = edit
         pgvGridItem.Columns(7).Caption = "Competência" + Environment.NewLine + "Obsoleta"
         pgvGridItem.Columns(7).Width = 80

         pgvGridItem.Columns(8).Caption = "Subseqüente"
         pgvGridItem.Columns(8).Width = 80

         pgvGridItem.Columns(9).Caption = "Período" + Environment.NewLine + "Subseqüente"
         pgvGridItem.Columns(9).Width = 90

         pgvGridItem.Columns(10).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
         pgvGridItem.Columns(10).Width = 100

         pgvGridItem.Columns(11).Caption = "Antecipa" + Environment.NewLine + "dia Util"
         pgvGridItem.Columns(11).Width = 70

         pgvGridItem.Columns(12).Visible = False

         '***************************************************************************
         ' CPR
         '***************************************************************************
         pdgGrid.LevelTree.Nodes(1).RelationName = "ObrigacaoCpr"
         pdgGrid.LevelTree.Nodes(1).LevelTemplate = pgvGridCpr

         pgvGridCpr.ViewCaption = pstrTituloGrid(2).ToString
         pgvGridCpr.PopulateColumns(dsObrigacoes.Tables("cpr"))
         pgvGridCpr.OptionsView.ShowGroupPanel = False
         pgvGridCpr.OptionsBehavior.Editable = False
         pgvGridCpr.OptionsCustomization.AllowQuickHideColumns = False
         pgvGridCpr.OptionsCustomization.AllowColumnResizing = False
         pgvGridCpr.OptionsCustomization.AllowColumnMoving = False
         pgvGridCpr.OptionsCustomization.AllowGroup = False
         pgvGridCpr.OptionsView.ColumnAutoWidth = False
         pgvGridCpr.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

         pgvGridCpr.ColumnPanelRowHeight = 60
         pgvGridCpr.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGridCpr.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGridCpr.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         pgvGridCpr.Columns(0).Visible = False
         pgvGridCpr.Columns(1).Visible = False
         pgvGridCpr.Columns(2).Visible = False

         pgvGridCpr.Columns(3).Caption = "CPR"
         pgvGridCpr.Columns(3).Width = 70

         pgvGridCpr.Columns(4).Caption = "Periodicidade"
         pgvGridCpr.Columns(4).Width = 80

         pgvGridCpr.Columns(5).Caption = "Tipo " + Environment.NewLine + "Vencimento"
         pgvGridCpr.Columns(5).Width = 80

         pgvGridCpr.Columns(6).Caption = "Dia"
         pgvGridCpr.Columns(6).Width = 80

         pgvGridCpr.Columns(7).Caption = "Tributo"
         pgvGridCpr.Columns(7).Width = 70

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00/0000"
         pgvGridCpr.Columns(8).ColumnEdit = edit
         pgvGridCpr.Columns(8).Caption = "Competência" + Environment.NewLine + "Obsoleta"
         pgvGridCpr.Columns(8).Width = 80

         pgvGridCpr.Columns(9).Caption = "Subseqüente"
         pgvGridCpr.Columns(9).Width = 80

         pgvGridCpr.Columns(10).Caption = "Período" + Environment.NewLine + "Subseqüente"
         pgvGridCpr.Columns(10).Width = 90

         pgvGridCpr.Columns(11).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
         pgvGridCpr.Columns(11).Width = 100

         pgvGridCpr.Columns(12).Caption = "Antecipa" + Environment.NewLine + "dia Util"
         pgvGridCpr.Columns(12).Width = 70

         pgvGridCpr.Columns(13).Visible = False

         '***************************************************************************
         ' ISS
         '***************************************************************************
         pdgGrid.LevelTree.Nodes(2).RelationName = "ObrigacaoIss"
         pdgGrid.LevelTree.Nodes(2).LevelTemplate = pgvGridIss
         pgvGridIss.ViewCaption = pstrTituloGrid(3).ToString
         pgvGridIss.PopulateColumns(dsObrigacoes.Tables("iss"))
         pgvGridIss.OptionsView.ShowGroupPanel = False
         pgvGridIss.OptionsBehavior.Editable = False
         pgvGridIss.OptionsCustomization.AllowQuickHideColumns = False
         pgvGridIss.OptionsCustomization.AllowColumnResizing = False
         pgvGridIss.OptionsCustomization.AllowColumnMoving = False
         pgvGridIss.OptionsCustomization.AllowGroup = False
         pgvGridIss.OptionsView.ColumnAutoWidth = False
         pgvGridIss.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

         pgvGridIss.ColumnPanelRowHeight = 60
         pgvGridIss.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGridIss.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGridIss.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         pgvGridIss.Columns(0).Visible = False
         pgvGridIss.Columns(1).Visible = False
         pgvGridIss.Columns(2).Visible = False

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00-00000"
         pgvGridIss.Columns(3).ColumnEdit = edit
         pgvGridIss.Columns(3).Caption = "Município"
         pgvGridIss.Columns(3).Width = 90

         pgvGridIss.Columns(4).Caption = "Nome"
         pgvGridIss.Columns(4).Width = 300

         pgvGridIss.Columns(5).Caption = "Periodicidade"
         pgvGridIss.Columns(5).Width = 80

         pgvGridIss.Columns(6).Caption = "Tipo " + Environment.NewLine + "Vencimento"
         pgvGridIss.Columns(6).Width = 80

         pgvGridIss.Columns(7).Caption = "Dia"
         pgvGridIss.Columns(7).Width = 80

         pgvGridIss.Columns(8).Caption = "Tributo"
         pgvGridIss.Columns(8).Width = 70

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00/0000"
         pgvGridIss.Columns(9).ColumnEdit = edit
         pgvGridIss.Columns(9).Caption = "Competência" + Environment.NewLine + "Obsoleta"
         pgvGridIss.Columns(9).Width = 80

         pgvGridIss.Columns(10).Caption = "Subseqüente"
         pgvGridIss.Columns(10).Width = 80

         pgvGridIss.Columns(11).Caption = "Período" + Environment.NewLine + "Subseqüente"
         pgvGridIss.Columns(11).Width = 90

         pgvGridIss.Columns(12).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
         pgvGridIss.Columns(12).Width = 100

         pgvGridIss.Columns(13).Caption = "Antecipa" + Environment.NewLine + "dia Util"
         pgvGridIss.Columns(13).Width = 70

         pgvGridIss.Columns(14).Visible = False

         '***************************************************************************
         ' e-ISS
         '***************************************************************************
         pdgGrid.LevelTree.Nodes(3).RelationName = "ObrigacaoEiss"
         pdgGrid.LevelTree.Nodes(3).LevelTemplate = pgvGridEiss
         pgvGridEiss.ViewCaption = pstrTituloGrid(4).ToString
         pgvGridEiss.PopulateColumns(dsObrigacoes.Tables("eiss"))
         pgvGridEiss.OptionsView.ShowGroupPanel = False
         pgvGridEiss.OptionsBehavior.Editable = False
         pgvGridEiss.OptionsCustomization.AllowQuickHideColumns = False
         pgvGridEiss.OptionsCustomization.AllowColumnResizing = False
         pgvGridEiss.OptionsCustomization.AllowColumnMoving = False
         pgvGridEiss.OptionsCustomization.AllowGroup = False
         pgvGridEiss.OptionsView.ColumnAutoWidth = False
         pgvGridEiss.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

         pgvGridEiss.ColumnPanelRowHeight = 60
         pgvGridEiss.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGridEiss.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGridEiss.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         pgvGridEiss.Columns(0).Visible = False
         pgvGridEiss.Columns(1).Visible = False
         pgvGridEiss.Columns(2).Visible = False

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00-00000"
         pgvGridEiss.Columns(3).ColumnEdit = edit
         pgvGridEiss.Columns(3).Caption = "Município"
         pgvGridEiss.Columns(3).Width = 90

         pgvGridEiss.Columns(4).Caption = "Nome"
         pgvGridEiss.Columns(4).Width = 300

         pgvGridEiss.Columns(5).Caption = "Periodicidade"
         pgvGridEiss.Columns(5).Width = 80

         pgvGridEiss.Columns(6).Caption = "Tipo " + Environment.NewLine + "Vencimento"
         pgvGridEiss.Columns(6).Width = 80

         pgvGridEiss.Columns(7).Caption = "Dia"
         pgvGridEiss.Columns(7).Width = 80

         pgvGridEiss.Columns(8).Caption = "Tributo"
         pgvGridEiss.Columns(8).Width = 70

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00/0000"
         pgvGridEiss.Columns(9).ColumnEdit = edit
         pgvGridEiss.Columns(9).Caption = "Competência" + Environment.NewLine + "Obsoleta"
         pgvGridEiss.Columns(9).Width = 80

         pgvGridEiss.Columns(10).Caption = "Subseqüente"
         pgvGridEiss.Columns(10).Width = 80

         pgvGridEiss.Columns(11).Caption = "Período" + Environment.NewLine + "Subseqüente"
         pgvGridEiss.Columns(11).Width = 90

         pgvGridEiss.Columns(12).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
         pgvGridEiss.Columns(12).Width = 100

         pgvGridEiss.Columns(13).Caption = "Antecipa" + Environment.NewLine + "dia Util"
         pgvGridEiss.Columns(13).Width = 70

         pgvGridEiss.Columns(14).Visible = False

         '***************************************************************************
         ' IE
         '***************************************************************************
         pdgGrid.LevelTree.Nodes(4).RelationName = "ObrigacaoIe"
         pdgGrid.LevelTree.Nodes(4).LevelTemplate = pgvGridIe
         pgvGridIe.ViewCaption = pstrTituloGrid(5).ToString
         pgvGridIe.PopulateColumns(dsObrigacoes.Tables("ie"))
         pgvGridIe.OptionsView.ShowGroupPanel = False
         pgvGridIe.OptionsBehavior.Editable = False
         pgvGridIe.OptionsCustomization.AllowQuickHideColumns = False
         pgvGridIe.OptionsCustomization.AllowColumnResizing = False
         pgvGridIe.OptionsCustomization.AllowColumnMoving = False
         pgvGridIe.OptionsCustomization.AllowGroup = False
         pgvGridIe.OptionsView.ColumnAutoWidth = False
         pgvGridIe.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

         pgvGridIe.ColumnPanelRowHeight = 60
         pgvGridIe.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGridIe.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGridIe.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         pgvGridIe.Columns(0).Visible = False
         pgvGridIe.Columns(1).Visible = False
         pgvGridIe.Columns(2).Visible = False

         pgvGridIe.Columns(3).Caption = "IE:" + Environment.NewLine + "Último Dígito"
         pgvGridIe.Columns(3).Width = 75

         pgvGridIe.Columns(4).Caption = "Periodicidade"
         pgvGridIe.Columns(4).Width = 80

         pgvGridIe.Columns(5).Caption = "Tipo " + Environment.NewLine + "Vencimento"
         pgvGridIe.Columns(5).Width = 80

         pgvGridIe.Columns(6).Caption = "Dia"
         pgvGridIe.Columns(6).Width = 80

         pgvGridIe.Columns(7).Caption = "Tributo"
         pgvGridIe.Columns(7).Width = 70

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00/0000"
         pgvGridIe.Columns(8).ColumnEdit = edit
         pgvGridIe.Columns(8).Caption = "Competência" + Environment.NewLine + "Obsoleta"
         pgvGridIe.Columns(8).Width = 80

         pgvGridIe.Columns(9).Caption = "Subseqüente"
         pgvGridIe.Columns(9).Width = 80

         pgvGridIe.Columns(10).Caption = "Período" + Environment.NewLine + "Subseqüente"
         pgvGridIe.Columns(10).Width = 90

         pgvGridIe.Columns(11).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
         pgvGridIe.Columns(11).Width = 100

         pgvGridIe.Columns(12).Caption = "Antecipa dia" + Environment.NewLine + "Util"
         pgvGridIe.Columns(12).Width = 70

         pgvGridIe.Columns(13).Visible = False

         '***************************************************************************
         ' CNPJ
         '***************************************************************************
         pdgGrid.LevelTree.Nodes(5).RelationName = "ObrigacaoCnpj"
         pdgGrid.LevelTree.Nodes(5).LevelTemplate = pgvGridCnpj
         pgvGridCnpj.ViewCaption = pstrTituloGrid(6).ToString
         pgvGridCnpj.PopulateColumns(dsObrigacoes.Tables("cnpj"))
         pgvGridCnpj.OptionsView.ShowGroupPanel = False
         pgvGridCnpj.OptionsBehavior.Editable = False
         pgvGridCnpj.OptionsCustomization.AllowQuickHideColumns = False
         pgvGridCnpj.OptionsCustomization.AllowColumnResizing = False
         pgvGridCnpj.OptionsCustomization.AllowColumnMoving = False
         pgvGridCnpj.OptionsCustomization.AllowGroup = False
         pgvGridCnpj.OptionsView.ColumnAutoWidth = False
         pgvGridCnpj.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

         pgvGridCnpj.ColumnPanelRowHeight = 60
         pgvGridCnpj.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGridCnpj.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGridCnpj.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         pgvGridCnpj.Columns(0).Visible = False
         pgvGridCnpj.Columns(1).Visible = False
         pgvGridCnpj.Columns(2).Visible = False

         pgvGridCnpj.Columns(3).Caption = "CNPJ:" + Environment.NewLine + "Oitavo Dígito"
         pgvGridCnpj.Columns(3).Width = 80

         pgvGridCnpj.Columns(4).Caption = "Periodicidade"
         pgvGridCnpj.Columns(4).Width = 80

         pgvGridCnpj.Columns(5).Caption = "Tipo " + Environment.NewLine + "Vencimento"
         pgvGridCnpj.Columns(5).Width = 80

         pgvGridCnpj.Columns(6).Caption = "Dia"
         pgvGridCnpj.Columns(6).Width = 80

         pgvGridCnpj.Columns(7).Caption = "Tributo"
         pgvGridCnpj.Columns(7).Width = 70

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00/0000"
         pgvGridCnpj.Columns(8).ColumnEdit = edit
         pgvGridCnpj.Columns(8).Caption = "Competência" + Environment.NewLine + "Obsoleta"
         pgvGridCnpj.Columns(8).Width = 80

         pgvGridCnpj.Columns(9).Caption = "Subseqüente"
         pgvGridCnpj.Columns(9).Width = 80

         pgvGridCnpj.Columns(10).Caption = "Período" + Environment.NewLine + "Subseqüente"
         pgvGridCnpj.Columns(10).Width = 90

         pgvGridCnpj.Columns(11).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
         pgvGridCnpj.Columns(11).Width = 100

         pgvGridCnpj.Columns(12).Caption = "Antecipa dia" + Environment.NewLine + "Util"
         pgvGridCnpj.Columns(12).Width = 70

         pgvGridCnpj.Columns(13).Visible = False

      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

            pgvGridIss.Columns(8).Caption = "Tributo"
            pgvGridIss.Columns(8).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridIss.Columns(9).ColumnEdit = edit
            pgvGridIss.Columns(9).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGridIss.Columns(9).Width = 80

            pgvGridIss.Columns(10).Caption = "Subseqüente"
            pgvGridIss.Columns(10).Width = 80

            pgvGridIss.Columns(11).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGridIss.Columns(11).Width = 90

            pgvGridIss.Columns(12).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGridIss.Columns(12).Width = 100

            pgvGridIss.Columns(13).Caption = "Antecipa" + Environment.NewLine + "dia Util"
            pgvGridIss.Columns(13).Width = 70

            pgvGridIss.Columns(14).Visible = False

            '***************************************************************************
            ' e-ISS
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(3).RelationName = "ObrigacaoEiss"
            pdgGrid.LevelTree.Nodes(3).LevelTemplate = pgvGridEiss
            pgvGridEiss.ViewCaption = pstrTituloGrid(4).ToString
            pgvGridEiss.PopulateColumns(dsObrigacoes.Tables("eiss"))
            pgvGridEiss.OptionsView.ShowGroupPanel = False
            pgvGridEiss.OptionsBehavior.Editable = False
            pgvGridEiss.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridEiss.OptionsCustomization.AllowColumnResizing = False
            pgvGridEiss.OptionsCustomization.AllowColumnMoving = False
            pgvGridEiss.OptionsCustomization.AllowGroup = False
            pgvGridEiss.OptionsView.ColumnAutoWidth = False
            pgvGridEiss.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridEiss.ColumnPanelRowHeight = 60
            pgvGridEiss.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridEiss.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridEiss.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridEiss.Columns(0).Visible = False
            pgvGridEiss.Columns(1).Visible = False
            pgvGridEiss.Columns(2).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridEiss.Columns(3).ColumnEdit = edit
            pgvGridEiss.Columns(3).Caption = "Município"
            pgvGridEiss.Columns(3).Width = 90

            pgvGridEiss.Columns(4).Caption = "Nome"
            pgvGridEiss.Columns(4).Width = 300

            pgvGridEiss.Columns(5).Caption = "Periodicidade"
            pgvGridEiss.Columns(5).Width = 80

            pgvGridEiss.Columns(6).Caption = "Tipo " + Environment.NewLine + "Vencimento"
            pgvGridEiss.Columns(6).Width = 80

            pgvGridEiss.Columns(7).Caption = "Dia"
            pgvGridEiss.Columns(7).Width = 80

            pgvGridEiss.Columns(8).Caption = "Tributo"
            pgvGridEiss.Columns(8).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridEiss.Columns(9).ColumnEdit = edit
            pgvGridEiss.Columns(9).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGridEiss.Columns(9).Width = 80

            pgvGridEiss.Columns(10).Caption = "Subseqüente"
            pgvGridEiss.Columns(10).Width = 80

            pgvGridEiss.Columns(11).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGridEiss.Columns(11).Width = 90

            pgvGridEiss.Columns(12).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGridEiss.Columns(12).Width = 100

            pgvGridEiss.Columns(13).Caption = "Antecipa" + Environment.NewLine + "dia Util"
            pgvGridEiss.Columns(13).Width = 70

            pgvGridEiss.Columns(14).Visible = False

            '***************************************************************************
            ' IE
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(4).RelationName = "ObrigacaoIe"
            pdgGrid.LevelTree.Nodes(4).LevelTemplate = pgvGridIe
            pgvGridIe.ViewCaption = pstrTituloGrid(5).ToString
            pgvGridIe.PopulateColumns(dsObrigacoes.Tables("ie"))
            pgvGridIe.OptionsView.ShowGroupPanel = False
            pgvGridIe.OptionsBehavior.Editable = False
            pgvGridIe.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridIe.OptionsCustomization.AllowColumnResizing = False
            pgvGridIe.OptionsCustomization.AllowColumnMoving = False
            pgvGridIe.OptionsCustomization.AllowGroup = False
            pgvGridIe.OptionsView.ColumnAutoWidth = False
            pgvGridIe.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridIe.ColumnPanelRowHeight = 60
            pgvGridIe.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridIe.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridIe.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridIe.Columns(0).Visible = False
            pgvGridIe.Columns(1).Visible = False
            pgvGridIe.Columns(2).Visible = False

            pgvGridIe.Columns(3).Caption = "IE:" + Environment.NewLine + "Último Dígito"
            pgvGridIe.Columns(3).Width = 75

            pgvGridIe.Columns(4).Caption = "Periodicidade"
            pgvGridIe.Columns(4).Width = 80

            pgvGridIe.Columns(5).Caption = "Tipo " + Environment.NewLine + "Vencimento"
            pgvGridIe.Columns(5).Width = 80

            pgvGridIe.Columns(6).Caption = "Dia"
            pgvGridIe.Columns(6).Width = 80

            pgvGridIe.Columns(7).Caption = "Tributo"
            pgvGridIe.Columns(7).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridIe.Columns(8).ColumnEdit = edit
            pgvGridIe.Columns(8).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGridIe.Columns(8).Width = 80

            pgvGridIe.Columns(9).Caption = "Subseqüente"
            pgvGridIe.Columns(9).Width = 80

            pgvGridIe.Columns(10).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGridIe.Columns(10).Width = 90

            pgvGridIe.Columns(11).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGridIe.Columns(11).Width = 100

            pgvGridIe.Columns(12).Caption = "Antecipa dia" + Environment.NewLine + "Util"
            pgvGridIe.Columns(12).Width = 70

            pgvGridIe.Columns(13).Visible = False

            '***************************************************************************
            ' CNPJ
            '***************************************************************************
            pdgGrid.LevelTree.Nodes(5).RelationName = "ObrigacaoCnpj"
            pdgGrid.LevelTree.Nodes(5).LevelTemplate = pgvGridCnpj
            pgvGridCnpj.ViewCaption = pstrTituloGrid(6).ToString
            pgvGridCnpj.PopulateColumns(dsObrigacoes.Tables("cnpj"))
            pgvGridCnpj.OptionsView.ShowGroupPanel = False
            pgvGridCnpj.OptionsBehavior.Editable = False
            pgvGridCnpj.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridCnpj.OptionsCustomization.AllowColumnResizing = False
            pgvGridCnpj.OptionsCustomization.AllowColumnMoving = False
            pgvGridCnpj.OptionsCustomization.AllowGroup = False
            pgvGridCnpj.OptionsView.ColumnAutoWidth = False
            pgvGridCnpj.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvGridCnpj.ColumnPanelRowHeight = 60
            pgvGridCnpj.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridCnpj.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGridCnpj.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridCnpj.Columns(0).Visible = False
            pgvGridCnpj.Columns(1).Visible = False
            pgvGridCnpj.Columns(2).Visible = False

            pgvGridCnpj.Columns(3).Caption = "CNPJ:" + Environment.NewLine + "Oitavo Dígito"
            pgvGridCnpj.Columns(3).Width = 80

            pgvGridCnpj.Columns(4).Caption = "Periodicidade"
            pgvGridCnpj.Columns(4).Width = 80

            pgvGridCnpj.Columns(5).Caption = "Tipo " + Environment.NewLine + "Vencimento"
            pgvGridCnpj.Columns(5).Width = 80

            pgvGridCnpj.Columns(6).Caption = "Dia"
            pgvGridCnpj.Columns(6).Width = 80

            pgvGridCnpj.Columns(7).Caption = "Tributo"
            pgvGridCnpj.Columns(7).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridCnpj.Columns(8).ColumnEdit = edit
            pgvGridCnpj.Columns(8).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGridCnpj.Columns(8).Width = 80

            pgvGridCnpj.Columns(9).Caption = "Subseqüente"
            pgvGridCnpj.Columns(9).Width = 80

            pgvGridCnpj.Columns(10).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGridCnpj.Columns(10).Width = 90

            pgvGridCnpj.Columns(11).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGridCnpj.Columns(11).Width = 100

            pgvGridCnpj.Columns(12).Caption = "Antecipa dia" + Environment.NewLine + "Util"
            pgvGridCnpj.Columns(12).Width = 70

            pgvGridCnpj.Columns(13).Visible = False

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoVariacao As System.Collections.Generic.List(Of Modelo.obrigacoesvariacao), ByRef pstrVariacao As String) Implements IObrigacoes.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdObrigacao As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdObrigacao.ResultSet(1).Rows
                Dim strCompetenciaObsoleta As String = String.Empty
                If row.Values(6) IsNot Nothing Then
                    strCompetenciaObsoleta = row.Values(6).ToString
                End If
                infoVariacao.Add(New obrigacoesvariacao(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString, row.Values(4),
                                                        row.Values(5).ToString, strCompetenciaObsoleta, row.Values(7), row.Values(8).ToString, row.Values(9), row.Values(10)))
            Next

            pdgGrid.DataSource = infoVariacao

            pgvGrid.OptionsView.ShowGroupPanel = False
            pgvGrid.OptionsView.ColumnAutoWidth = False
            pgvGrid.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            pgvGrid.ColumnPanelRowHeight = 60
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            If pstrVariacao = "item" Or pstrVariacao = "cpr" Or pstrVariacao = "ie" Or pstrVariacao = "cnpj" Then
                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = False
                edit.Mask.EditMask = "0-00000"
                pgvGrid.Columns(0).Visible = True
                pgvGrid.Columns(0).ColumnEdit = edit

                pgvGrid.Columns(1).Visible = False
                If pstrVariacao = "cpr" Then
                    pgvGrid.Columns(0).Caption = "CPR"
                    pgvGrid.Columns(0).Width = 70
                ElseIf pstrVariacao = "ie" Then
                    pgvGrid.Columns(0).Caption = "IE:" + Environment.NewLine + "Último Dígito"
                    pgvGrid.Columns(0).Width = 75
                ElseIf pstrVariacao = "cnpj" Then
                    pgvGrid.Columns(0).Caption = "CNPJ:" + Environment.NewLine + "Oitavo Dígito"
                    pgvGrid.Columns(0).Width = 80
                Else
                    pgvGrid.Columns(0).Visible = False
                    pgvGrid.Columns(1).Visible = False
                End If
            Else
                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = True
                edit.Mask.EditMask = "0-00000"
                pgvGrid.Columns(0).Visible = True
                pgvGrid.Columns(0).ColumnEdit = edit
                pgvGrid.Columns(0).Caption = "Município"
                pgvGrid.Columns(0).Width = 90

                pgvGrid.Columns(1).Visible = True
                pgvGrid.Columns(1).Caption = "Nome"
                pgvGrid.Columns(1).Width = 300
            End If

            pgvGrid.Columns(2).Caption = "Periodicidade"
            pgvGrid.Columns(2).Width = 80

            pgvGrid.Columns(3).Caption = "Tipo " + Environment.NewLine + "Vencimento"
            pgvGrid.Columns(3).Width = 80

            pgvGrid.Columns(4).Caption = "Dia"
            pgvGrid.Columns(4).Width = 80

            pgvGrid.Columns(5).Caption = "Tributo"
            pgvGrid.Columns(5).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGrid.Columns(6).ColumnEdit = edit
            pgvGrid.Columns(6).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGrid.Columns(6).Width = 80

            pgvGrid.Columns(7).Caption = "Subseqüente"
            pgvGrid.Columns(7).Width = 80

            pgvGrid.Columns(8).Caption = "Período" + Environment.NewLine + "Subseqüente"
            pgvGrid.Columns(8).Width = 90

            pgvGrid.Columns(9).Caption = "Sábado/Domingo" + Environment.NewLine + "Util"
            pgvGrid.Columns(9).Width = 100

            pgvGrid.Columns(10).Caption = "Antecipa dia" + Environment.NewLine + "Util"
            pgvGrid.Columns(10).Width = 70

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDObrigacoes(ByRef pstrOperacao As String, ByRef infoObrigacoes As Modelo.obrigacoesInfo, ByRef originalinfoVariacao As System.Collections.Generic.List(Of Modelo.obrigacoesvariacao)) Implements IObrigacoes.IUDObrigacoes
      Try
         Dim objDataBase As New DataBaseDAL
         Dim strQuery As String = String.Empty
         Dim strTabela As String = String.Empty
         Dim strField As String = String.Empty

         If pstrOperacao = "inclusao" Then
            If infoObrigacoes.cpr Or infoObrigacoes.iss Or infoObrigacoes.eiss Or infoObrigacoes.ie Or infoObrigacoes.cnpj Then
               strQuery = "insert into admobrigacoes(obrigacao, descricao, parcelamento, sistema, envioautomatico, usuarioenvio, cpr, iss, eiss, ie, cnpj, incuser, incdata, altuser, altdata) " +
                                                "values ('" + infoObrigacoes.obrigacao + "', " +
                                                         "'" + infoObrigacoes.descricao + "', " +
                                                               infoObrigacoes.parcelamento.ToString + ", " +
                                                         "'" + infoObrigacoes.sistema + "', " +
                                                               infoObrigacoes.envioautomatico.ToString + ", " +
                                                         "'" + infoObrigacoes.usuarioenvio.ToString + "', " +
                                                               Convert.ToString(Convert.ToInt32(infoObrigacoes.cpr) * -1) + ", " +
                                                               Convert.ToString(Convert.ToInt32(infoObrigacoes.iss) * -1) + ", " +
                                                               Convert.ToString(Convert.ToInt32(infoObrigacoes.eiss) * -1) + ", " +
                                                               Convert.ToString(Convert.ToInt32(infoObrigacoes.ie) * -1) + ", " +
                                                               Convert.ToString(Convert.ToInt32(infoObrigacoes.cnpj) * -1) + ", " +
                                                         "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                         "'" + usuarioInfo.usuario + "', current_timestamp);"
            Else
               strQuery = "insert into admobrigacoes(obrigacao, descricao, parcelamento, sistema, envioautomatico, usuarioenvio, periodicidade, vencimento, tipodia, tributo, competenciaobsoleta, " +
                                                      "subsequente, tiposubsequente, sabdomutil, antecipautil, cpr, iss, eiss, ie, cnpj, incuser, incdata, altuser, altdata) " +
                                                "values ('" + infoObrigacoes.obrigacao + "', " +
                                                      "'" + infoObrigacoes.descricao + "', " +
                                                            infoObrigacoes.parcelamento.ToString + ", " +
                                                      "'" + infoObrigacoes.sistema + "', " +
                                                            infoObrigacoes.envioautomatico.ToString + ", " +
                                                      "'" + infoObrigacoes.usuarioenvio.ToString + "', " +
                                                      "'" + infoObrigacoes.variacao(0).periodicidade + "', " +
                                                            infoObrigacoes.variacao(0).vencimento.ToString + ", " +
                                                      "'" + infoObrigacoes.variacao(0).tipodia.ToString + "', " +
                                                      "'" + infoObrigacoes.variacao(0).tributo + "', " +
                                                      "'" + infoObrigacoes.variacao(0).competenciaobsoleta + "', " +
                                                            infoObrigacoes.variacao(0).subsequente.ToString + ", " +
                                                      "'" + infoObrigacoes.variacao(0).tiposubsequente + "', " +
                                                            infoObrigacoes.variacao(0).sabdomutil.ToString + ", " +
                                                            infoObrigacoes.variacao(0).antecipautil.ToString + ", " +
                                                            Convert.ToString(Convert.ToInt32(infoObrigacoes.cpr) * -1) + ", " +
                                                            Convert.ToString(Convert.ToInt32(infoObrigacoes.iss) * -1) + ", " +
                                                            Convert.ToString(Convert.ToInt32(infoObrigacoes.eiss) * -1) + ", " +
                                                            Convert.ToString(Convert.ToInt32(infoObrigacoes.ie) * -1) + ", " +
                                                            Convert.ToString(Convert.ToInt32(infoObrigacoes.cnpj) * -1) + ", " +
                                                      "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                      "'" + usuarioInfo.usuario + "', current_timestamp);"
            End If
            If infoObrigacoes.cpr Or infoObrigacoes.iss Or infoObrigacoes.eiss Or infoObrigacoes.ie Or infoObrigacoes.cnpj Then
               If infoObrigacoes.cpr Then
                  strTabela = "admobrigacoescpr"
                  strField = "cpr"
               ElseIf infoObrigacoes.iss Then
                  strTabela = "admobrigacoesiss"
                  strField = "municipio"
               ElseIf infoObrigacoes.eiss Then
                  strTabela = "admobrigacoeseiss"
                  strField = "municipio"
               ElseIf infoObrigacoes.ie Then
                  strTabela = "admobrigacoesie"
                  strField = "ie"
               ElseIf infoObrigacoes.cnpj Then
                  strTabela = "admobrigacoescnpj"
                  strField = "cnpj"
               End If
               For index = 0 To infoObrigacoes.variacao.Count - 1
                  strQuery += Chr(13) + Chr(10)
                  strQuery += "insert into " + strTabela + "(obrigacao, " + strField + ", periodicidade, vencimento, tipodia, tributo, competenciaobsoleta, " +
                                                               "subsequente, tiposubsequente, sabdomutil, antecipautil, incuser, incdata, altuser, altdata) " +
                                                   "values ('" + infoObrigacoes.obrigacao + "', " +
                                                            "'" + infoObrigacoes.variacao(index).variacao + "', " +
                                                            "'" + infoObrigacoes.variacao(index).periodicidade + "', " +
                                                                  infoObrigacoes.variacao(index).vencimento.ToString + ", " +
                                                            "'" + infoObrigacoes.variacao(index).tipodia.ToString + "', " +
                                                            "'" + infoObrigacoes.variacao(index).tributo + "', " +
                                                            "'" + infoObrigacoes.variacao(index).competenciaobsoleta + "', " +
                                                                  infoObrigacoes.variacao(index).subsequente.ToString + ", " +
                                                            "'" + infoObrigacoes.variacao(index).tiposubsequente + "', " +
                                                                  infoObrigacoes.variacao(index).sabdomutil.ToString + ", " +
                                                                  infoObrigacoes.variacao(index).antecipautil.ToString + ", " +
                                                            "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                            "'" + usuarioInfo.usuario + "', current_timestamp);"
               Next
            End If
         ElseIf pstrOperacao = "alteracao" Then
            strQuery = "update admobrigacoes " +
                          "set descricao = '" + infoObrigacoes.descricao + "', " +
                              "parcelamento = " + infoObrigacoes.parcelamento.ToString + ", " +
                              "sistema = '" + infoObrigacoes.sistema + "', " +
                              "envioautomatico = " + infoObrigacoes.envioautomatico.ToString + ", " +
                              "usuarioenvio = '" + infoObrigacoes.usuarioenvio.ToString + "', "
            If Not infoObrigacoes.cpr And Not infoObrigacoes.iss And Not infoObrigacoes.eiss And Not infoObrigacoes.ie And Not infoObrigacoes.cnpj Then
               strQuery += "periodicidade = '" + infoObrigacoes.variacao(0).periodicidade + "', " +
                           "vencimento = " + infoObrigacoes.variacao(0).vencimento.ToString + ", " +
                           "tipodia = '" + infoObrigacoes.variacao(0).tipodia.ToString + "', " +
                           "tributo = '" + infoObrigacoes.variacao(0).tributo + "', " +
                           "competenciaobsoleta = '" + infoObrigacoes.variacao(0).competenciaobsoleta + "', " +
                           "subsequente = " + infoObrigacoes.variacao(0).subsequente.ToString + ", " +
                           "tiposubsequente = '" + infoObrigacoes.variacao(0).tiposubsequente.ToString + "', " +
                           "sabdomutil = " + infoObrigacoes.variacao(0).sabdomutil.ToString + ", " +
                           "antecipautil = " + infoObrigacoes.variacao(0).antecipautil.ToString + ", "
            End If
            strQuery += "cpr = " + Convert.ToString(Convert.ToInt32(infoObrigacoes.cpr) * -1) + ", " +
                        "iss = " + Convert.ToString(Convert.ToInt32(infoObrigacoes.iss) * -1) + ", " +
                        "eiss = " + Convert.ToString(Convert.ToInt32(infoObrigacoes.eiss) * -1) + ", " +
                        "ie = " + Convert.ToString(Convert.ToInt32(infoObrigacoes.ie) * -1) + ", " +
                        "cnpj = " + Convert.ToString(Convert.ToInt32(infoObrigacoes.cnpj) * -1) + ", " +
                        "altuser = '" + usuarioInfo.usuario + "', " +
                        "altdata = current_timestamp " +
                  "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
            If infoObrigacoes.cpr Or infoObrigacoes.iss Or infoObrigacoes.eiss Or infoObrigacoes.ie Or infoObrigacoes.cnpj Then
               If infoObrigacoes.cpr Then
                  strTabela = "admobrigacoescpr"
                  strField = "cpr"
               ElseIf infoObrigacoes.iss Then
                  strTabela = "admobrigacoesiss"
                  strField = "municipio"
               ElseIf infoObrigacoes.eiss Then
                  strTabela = "admobrigacoeseiss"
                  strField = "municipio"
               ElseIf infoObrigacoes.ie Then
                  strTabela = "admobrigacoesie"
                  strField = "ie"
               ElseIf infoObrigacoes.cnpj Then
                  strTabela = "admobrigacoescnpj"
                  strField = "cnpj"
               End If

               If pstrOperacao <> "exclusao" Then
                  'Verificação dos itens alterados com o original que foi carregado, caso um item original não foi encontrado nos alterados
                  'indica que houve exclusão
                  For indexoriginal = 0 To originalinfoVariacao.Count - 1
                     Dim blnEncontrouObrigacaoVariacao As Boolean = False
                     For index = 0 To infoObrigacoes.variacao.Count - 1
                        If originalinfoVariacao(indexoriginal).variacao = infoObrigacoes.variacao(index).variacao Then
                           blnEncontrouObrigacaoVariacao = True
                           Exit For
                        End If
                     Next
                     If Not blnEncontrouObrigacaoVariacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from " + strTabela + " " +
                                     "where obrigacao = '" + infoObrigacoes.obrigacao + "' " +
                                       "and " + strField + " = '" + originalinfoVariacao(indexoriginal).variacao + "';"
                     End If
                  Next
                  For index = 0 To infoObrigacoes.variacao.Count - 1
                     Dim blnEncontrouObrigacaoVariacao As Boolean = False
                     For indexoriginal = 0 To originalinfoVariacao.Count - 1
                        If infoObrigacoes.variacao(index).variacao = originalinfoVariacao(indexoriginal).variacao Then
                           blnEncontrouObrigacaoVariacao = True
                           Exit For
                        End If
                     Next
                     'Verificação dos itens alterados com o original que foi carregado, caso um item original não foi encontrado nos alterados
                     'indica que houve inclusão, caso contrário alteração de dados
                     If Not blnEncontrouObrigacaoVariacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "insert into " + strTabela + "(obrigacao, " + strField + ", periodicidade, vencimento, tipodia, tributo, competenciaobsoleta, " +
                                                                        "subsequente, tiposubsequente, sabdomutil, antecipautil, incuser, incdata, altuser, altdata) " +
                                                            "values ('" + infoObrigacoes.obrigacao + "', " +
                                                                     "'" + infoObrigacoes.variacao(index).variacao + "', " +
                                                                     "'" + infoObrigacoes.variacao(index).periodicidade + "', " +
                                                                           infoObrigacoes.variacao(index).vencimento.ToString + ", " +
                                                                     "'" + infoObrigacoes.variacao(index).tipodia.ToString + "', " +
                                                                     "'" + infoObrigacoes.variacao(index).tributo + "', " +
                                                                     "'" + infoObrigacoes.variacao(index).competenciaobsoleta + "', " +
                                                                           infoObrigacoes.variacao(index).subsequente.ToString + ", " +
                                                                     "'" + infoObrigacoes.variacao(index).tiposubsequente + "', " +
                                                                           infoObrigacoes.variacao(index).sabdomutil.ToString + ", " +
                                                                           infoObrigacoes.variacao(index).antecipautil.ToString + ", " +
                                                                     "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                     "'" + usuarioInfo.usuario + "', current_timestamp);"
                     Else
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "update " + strTabela + " " +
                                             "set periodicidade = '" + infoObrigacoes.variacao(index).periodicidade + "', " +
                                                "vencimento = " + infoObrigacoes.variacao(index).vencimento.ToString + ", " +
                                                "tipodia = '" + infoObrigacoes.variacao(index).tipodia.ToString + "', " +
                                                "tributo = '" + infoObrigacoes.variacao(index).tributo + "', " +
                                                "competenciaobsoleta = '" + infoObrigacoes.variacao(index).competenciaobsoleta + "', " +
                                                "subsequente = " + infoObrigacoes.variacao(index).subsequente.ToString + ", " +
                                                "tiposubsequente = '" + infoObrigacoes.variacao(index).tiposubsequente.ToString + "', " +
                                                "sabdomutil = " + infoObrigacoes.variacao(index).sabdomutil.ToString + ", " +
                                                "antecipautil = " + infoObrigacoes.variacao(index).antecipautil.ToString + ", " +
                                                "altuser = '" + usuarioInfo.usuario + "', " +
                                                "altdata = current_timestamp " +
                                          "where obrigacao = '" + infoObrigacoes.obrigacao + "' " +
                                             "and " + strField + " = '" + infoObrigacoes.variacao(index).variacao + "';"
                     End If
                  Next
               End If
            End If
         ElseIf pstrOperacao = "exclusao" Then
            strQuery = "delete " +
                           "from admobrigacoescpr " +
                           "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
            strQuery += Chr(13) + Chr(10)
            strQuery += "delete " +
                           "from admobrigacoesiss " +
                           "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
            strQuery += Chr(13) + Chr(10)
            strQuery += "delete " +
                           "from admobrigacoeseiss " +
                           "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
            strQuery += Chr(13) + Chr(10)
            strQuery += "delete " +
                           "from admobrigacoesie " +
                           "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
            strQuery += Chr(13) + Chr(10)
            strQuery += "delete " +
                           "from admobrigacoescnpj " +
                           "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
            strQuery += Chr(13) + Chr(10)
            strQuery += "delete " +
                           "from admobrigacoes " +
                           "where obrigacao = '" + infoObrigacoes.obrigacao + "';"
         End If
         objDataBase.NonQuery(strQuery)
         SincronizarObrigacoes(pstrOperacao, infoObrigacoes)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

   Public Sub SincronizarObrigacoes(ByRef pstrOperacao As String, ByRef infoObrigacoes As Modelo.obrigacoesInfo) Implements IObrigacoes.SincronizarObrigacoes
        Try
            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os dados com o portal")
                If pstrOperacao <> "exclusao" Then
                    infoObrigacoes.layout = RetornaLayoutObrigacao(infoObrigacoes.obrigacao)
                    Dim wsConsulta As New SelectWS
                    If wsConsulta.ObrigacaoExiste(infoObrigacoes.obrigacao) Then
                        Dim wsAlteracao As New UpdateWS
                        wsAlteracao.AlterarObrigacoes(infoObrigacoes.obrigacao, infoObrigacoes.descricao)
                    Else
                        Dim wsInclusao As New InsertWS
                        wsInclusao.IncluirObrigacoes(infoObrigacoes.obrigacao, infoObrigacoes.descricao, infoObrigacoes.layout)
                    End If
                Else
                    Dim wsConsulta As New SelectWS
                    If wsConsulta.ObrigacaoExiste(infoObrigacoes.obrigacao) Then
                        Dim wsExclusao As New DeleteWS
                        wsExclusao.ObrigacaoExclui(infoObrigacoes.obrigacao)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ProximaObrigacao() As String Implements IObrigacoes.ProximaObrigacao
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            Return objDataBase.QuerySimples("select '1' <concat> gd_completestring(cast(cast(coalesce(max(right(obrigacao,5)),'0') as integer) + 1 as varchar),5,'0') from admobrigacoes where left(obrigacao,1) = '1'")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Report(ByRef pstrCampoInicial As String, ByRef pstrCampoFinal As String, ByRef pstrPeriodicidade As String, ByRef pstrTributo As String, ByVal pstrSistema As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements IObrigacoes.Report
        Try
            Dim objDataBase As New DataBaseDAL

            Dim strQuery As String = "select a.obrigacao, a.descricao, a.parcelamento, a.sistema, cast('I' as varchar) as tipo, cast('' as varchar) as varcod, cast('' as varchar) as vardet, a.periodicidade, a.tipodia, a.vencimento, a.tributo, a.competenciaobsoleta, a.subsequente, a.tiposubsequente, a.sabdomutil, a.antecipautil " +
                                       "from admobrigacoes a " +
                                      "where a.obrigacao >= '" + pstrCampoInicial + "' " +
                                        "and a.obrigacao <= '" + pstrCampoFinal + "' "

            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and a.periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and a.tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            strQuery += "and a.cpr = 0 and a.iss = 0 and a.eiss = 0 and a.ie = 0 and a.cnpj = 0 "

            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and a.sistema = '" + pstrSistema + "'"
            End If

            strQuery += " union all "
            strQuery += "select a.obrigacao, a.descricao, a.parcelamento, a.sistema, cast('C' as varchar) as tipo, cast(cpr.cpr as varchar) as varcod, cast('' as varchar) as vardet, cpr.periodicidade, cpr.tipodia, cpr.vencimento, cpr.tributo, cpr.competenciaobsoleta, cpr.subsequente, cpr.tiposubsequente, cpr.sabdomutil, cpr.antecipautil " +
                          "from admobrigacoes a " +
                          "join admobrigacoescpr cpr on cpr.obrigacao = a.obrigacao "
            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and cpr.periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and cpr.tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            strQuery += "where a.obrigacao >= '" + pstrCampoInicial + "' " +
                          "and a.obrigacao <= '" + pstrCampoFinal + "' " +
                          "and a.cpr = -1 "

            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and a.sistema = '" + pstrSistema + "'"
            End If

            strQuery += " union all "
            strQuery += "select a.obrigacao, a.descricao, a.parcelamento, a.sistema, cast('S' as varchar) as tipo, cast(iss.municipio as varchar) as varcod, cast(m.nome as varchar) as vardet, iss.periodicidade, iss.tipodia, iss.vencimento, iss.tributo, iss.competenciaobsoleta, iss.subsequente, iss.tiposubsequente, iss.sabdomutil, iss.antecipautil " +
                          "from admobrigacoes a " +
                          "join admobrigacoesiss iss on iss.obrigacao = a.obrigacao " +
                          "join municipios m on m.municipio = iss.municipio "
            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and iss.periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and iss.tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            strQuery += "where a.obrigacao >= '" + pstrCampoInicial + "' " +
                          "and a.obrigacao <= '" + pstrCampoFinal + "' " +
                          "and a.iss = -1 "

            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and a.sistema = '" + pstrSistema + "'"
            End If

            strQuery += " union all "
            strQuery += "select a.obrigacao, a.descricao, a.parcelamento, a.sistema, cast('E' as varchar) as tipo, cast(eiss.municipio as varchar) as varcod, cast(m.nome as varchar) as vardet, eiss.periodicidade, eiss.tipodia, eiss.vencimento, eiss.tributo, eiss.competenciaobsoleta, eiss.subsequente, eiss.tiposubsequente, eiss.sabdomutil, eiss.antecipautil " +
                          "from admobrigacoes a " +
                          "join admobrigacoeseiss eiss on eiss.obrigacao = a.obrigacao " +
                          "join municipios m on m.municipio = eiss.municipio "
            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and eiss.periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and eiss.tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            strQuery += "where a.obrigacao >= '" + pstrCampoInicial + "' " +
                          "and a.obrigacao <= '" + pstrCampoFinal + "' " +
                          "and a.eiss = -1 "

            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and a.sistema = '" + pstrSistema + "'"
            End If

            strQuery += " union all "
            strQuery += "select a.obrigacao, a.descricao, a.parcelamento, a.sistema, cast('T' as varchar) as tipo, cast(ie.ie as varchar) as varcod, cast('' as varchar) as vardet, ie.periodicidade, ie.tipodia, ie.vencimento, ie.tributo, ie.competenciaobsoleta, ie.subsequente, ie.tiposubsequente, ie.sabdomutil, ie.antecipautil " +
                          "from admobrigacoes a " +
                          "join admobrigacoesie ie on ie.obrigacao = a.obrigacao "
            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and ie.periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and ie.tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            strQuery += "where a.obrigacao >= '" + pstrCampoInicial + "' " +
                          "and a.obrigacao <= '" + pstrCampoFinal + "' " +
                          "and a.ie = -1 "

            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and a.sistema = '" + pstrSistema + "'"
            End If

            strQuery += " union all "
            strQuery += "select a.obrigacao, a.descricao, a.parcelamento, a.sistema, cast('N' as varchar) as tipo, cast(cnpj.cnpj as varchar) as varcod, cast('' as varchar) as vardet, cnpj.periodicidade, cnpj.tipodia, cnpj.vencimento, cnpj.tributo, cnpj.competenciaobsoleta, cnpj.subsequente, cnpj.tiposubsequente, cnpj.sabdomutil, cnpj.antecipautil " +
                          "from admobrigacoes a " +
                          "join admobrigacoescnpj cnpj on cnpj.obrigacao = a.obrigacao "
            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and cnpj.periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and cnpj.tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            strQuery += "where a.obrigacao >= '" + pstrCampoInicial + "' " +
                          "and a.obrigacao <= '" + pstrCampoFinal + "' " +
                          "and a.cnpj = -1 "

            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and a.sistema = '" + pstrSistema + "'"
            End If

            strQuery += "order by 1"

            pReport.DataSource = objDataBase.QueryDataView(strQuery)

            Dim dvtable As XPDataView = CType(pReport.DataSource, XPDataView)
            If dvtable.Count = 0 Then Throw New Exception("Não existem informações a serem impressas")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Report(ByRef pstrCampoInicial As String, ByRef pstrCampoFinal As String, ByRef pstrPeriodicidade As String, ByRef pstrTributo As String, ByVal pstrSistema As String, pReport As DevExpress.XtraReports.UI.XtraReport, ByVal pblnResumido As Boolean) Implements IObrigacoes.Report
        Try
            Dim objDataBase As New DataBaseDAL

            Dim strQuery As String = "select obrigacao, descricao, sistema " +
                                       "from admobrigacoes " +
                                      "where obrigacao >= '" + pstrCampoInicial + "' " +
                                        "and obrigacao <= '" + pstrCampoFinal + "'"

            If Not String.IsNullOrEmpty(pstrPeriodicidade) Then
                Dim intIndex As Int32 = 0
                If pstrPeriodicidade.ToUpper = "DIÁRIA" Then
                    intIndex = 1
                End If
                strQuery += "and periodicidade = '" + pstrPeriodicidade.ToUpper.Substring(intIndex, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrTributo) Then
                strQuery += "and tributo = '" + pstrTributo.Substring(0, 1) + "' "
            End If
            If Not String.IsNullOrEmpty(pstrSistema) Then
                strQuery += "and sistema = '" + pstrSistema + "'"
            End If
            strQuery += " order by 1"

            pReport.DataSource = objDataBase.QueryDataView(strQuery)

            Dim dvtable As XPDataView = CType(pReport.DataSource, XPDataView)
            If dvtable.Count = 0 Then Throw New Exception("Não existem informações a serem impressas")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDObrigacoesUsuarios(ByRef pstrOperacao As String, ByRef infoObrigacoesUsuarios As Modelo.obrigacoesusuariosInfo, ByRef originalinfoObrigacoes As System.Collections.Generic.List(Of Modelo.obrigacoesusuarios)) Implements IObrigacoes.IUDObrigacoesUsuarios
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admobrigacoesusuarios " +
                            "where usuario = '" + infoObrigacoesUsuarios.usuario + "';"
            End If
            If pstrOperacao <> "exclusao" Then
                If infoObrigacoesUsuarios.obrigacoes.Count = 0 And originalinfoObrigacoes.Count > 0 Then
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from admobrigacoesusuarios " +
                                 "where usuario = '" + infoObrigacoesUsuarios.usuario + "';"
                End If
                For indexoriginal = 0 To originalinfoObrigacoes.Count - 1
                    Dim blnEncontrouObrigacaoUsuario As Boolean = False
                    For index = 0 To infoObrigacoesUsuarios.obrigacoes.Count - 1
                        If originalinfoObrigacoes(indexoriginal).obrigacao = infoObrigacoesUsuarios.obrigacoes(index).obrigacao Then
                            blnEncontrouObrigacaoUsuario = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouObrigacaoUsuario Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from admobrigacoesusuarios " +
                                     "where usuario = '" + infoObrigacoesUsuarios.usuario + "' " +
                                       "and obrigacao = '" + originalinfoObrigacoes(indexoriginal).obrigacao + "';"
                    End If
                Next
                For index = 0 To infoObrigacoesUsuarios.obrigacoes.Count - 1
                    Dim blnEncontrouObrigacaoUsuario As Boolean = False
                    For indexoriginal = 0 To originalinfoObrigacoes.Count - 1
                        If infoObrigacoesUsuarios.obrigacoes(index).obrigacao = originalinfoObrigacoes(indexoriginal).obrigacao Then
                            blnEncontrouObrigacaoUsuario = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouObrigacaoUsuario Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "insert into admobrigacoesusuarios(usuario, obrigacao, incuser, incdata, altuser, altdata) " +
                                                          "values ('" + infoObrigacoesUsuarios.usuario + "', " +
                                                                 "'" + infoObrigacoesUsuarios.obrigacoes(index).obrigacao + "', " +
                                                                 "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                 "'" + usuarioInfo.usuario + "', current_timestamp);"
                    End If
                Next
            End If
            objDataBase.NonQuery(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoObrigacoes As System.Collections.Generic.List(Of Modelo.obrigacoesusuarios)) Implements IObrigacoes.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresa As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdEmpresa.ResultSet(1).Rows
                infoObrigacoes.Add(New obrigacoesusuarios(row.Values(0).ToString, row.Values(1).ToString))
            Next

            pdgGrid.DataSource = infoObrigacoes

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"

            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Obrigação"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Descrição"
            pgvGrid.Columns(1).Width = 300

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements IObrigacoes.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdObrigacaoUsuario As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsObrigacaoUsuario As New DataSet()
            Dim dtObrigacaoUsuario As New DataTable("obrigacaousuario")
            For Each row As SelectStatementResultRow In sdObrigacaoUsuario.ResultSet(0).Rows
                dtObrigacaoUsuario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsObrigacaoUsuario.Tables.Add(dtObrigacaoUsuario)

            For Each row As SelectStatementResultRow In sdObrigacaoUsuario.ResultSet(1).Rows
                Dim drObrigacoesUsuarios As DataRow = dsObrigacaoUsuario.Tables("obrigacaousuario").NewRow()
                For index = 0 To row.Values.Length - 1
                    drObrigacoesUsuarios(index) = row.Values(index)
                Next
                dsObrigacaoUsuario.Tables("obrigacaousuario").Rows.Add(drObrigacoesUsuarios)
            Next

            sdObrigacaoUsuario = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtObrigacao As New DataTable("obrigacao")
            For Each row As SelectStatementResultRow In sdObrigacaoUsuario.ResultSet(0).Rows
                dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsObrigacaoUsuario.Tables.Add(dtObrigacao)

            For Each row As SelectStatementResultRow In sdObrigacaoUsuario.ResultSet(1).Rows
                Dim drObrigacao As DataRow = dsObrigacaoUsuario.Tables("obrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    drObrigacao(index) = row.Values(index)
                Next
                dsObrigacaoUsuario.Tables("obrigacao").Rows.Add(drObrigacao)
            Next

            Dim keyColumn As DataColumn = dsObrigacaoUsuario.Tables("obrigacaousuario").Columns("usuario")
            Dim foreignKeyColumnObr As DataColumn = dsObrigacaoUsuario.Tables("obrigacao").Columns("usuario")

            dsObrigacaoUsuario.Relations.Add("ObrigacaoUsuario", keyColumn, foreignKeyColumnObr)

            'Bind the grid control to the data source
            pdgGrid.DataSource = dsObrigacaoUsuario.Tables("obrigacaousuario")
            pdgGrid.ForceInitialize()
            AddHandler pdgGrid.KeyUp, AddressOf pdgGrid_KeyUp

            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

            pgvGrid.Columns(0).Caption = "Usuário"
            pgvGrid.Columns(0).Width = 70

            pgvGrid.Columns(1).Caption = "Nome"
            pgvGrid.Columns(1).Width = 200
            AddHandler pgvGrid.RowCellClick, AddressOf pgvGrid_RowCellClick

            Dim obrigacaogridview As New GridView(pdgGrid)
            pdgGrid.LevelTree.Nodes.Add("ObrigacaoUsuario", obrigacaogridview)
            obrigacaogridview.ViewCaption = pstrTituloGrid(1).ToString
            obrigacaogridview.PopulateColumns(dsObrigacaoUsuario.Tables("obrigacao"))
            obrigacaogridview.OptionsView.ShowGroupPanel = False
            obrigacaogridview.OptionsBehavior.Editable = False
            obrigacaogridview.OptionsCustomization.AllowQuickHideColumns = False
            obrigacaogridview.OptionsCustomization.AllowColumnResizing = False
            obrigacaogridview.OptionsCustomization.AllowColumnMoving = False
            obrigacaogridview.OptionsCustomization.AllowGroup = False

            obrigacaogridview.Columns(0).Visible = False

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"

            obrigacaogridview.Columns(1).ColumnEdit = edit
            obrigacaogridview.Columns(1).Caption = "Obrigação"
            obrigacaogridview.Columns(1).Width = 70

            obrigacaogridview.Columns(2).Caption = "Descrição"
            obrigacaogridview.Columns(2).Width = 200
            obrigacaogridview.Name = "obrigacaoGridView"
            AddHandler obrigacaogridview.RowCellClick, AddressOf obrigacaogridview_RowCellClick

            obrigacoesusuariosRibbonControl = prcRibbonControl
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub pdgGrid_KeyUp(sender As Object, e As KeyEventArgs)
        Dim gcSender As GridControl = DirectCast(sender, GridControl)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If gcSender.FocusedView.Name = "obrigacoesusuariosGridView" Then
                obrigacoesusuariosRibbonControl.Manager.Items(4).Enabled = True
            Else
                obrigacoesusuariosRibbonControl.Manager.Items(4).Enabled = False
            End If
        End If
    End Sub

    Private Sub pgvGrid_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub obrigacaogridview_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub HabilitaDesabilitaExcluirBarButton(pobjSender As Object, prccEvent As RowCellClickEventArgs)
        Dim gvSender As GridView = DirectCast(pobjSender, GridView)
        If gvSender.Name = "obrigacoesusuariosGridView" Then
            If prccEvent.Clicks = 1 Then
                obrigacoesusuariosRibbonControl.Manager.Items(4).Enabled = True
            Else
                obrigacoesusuariosRibbonControl.Manager.Items(4).Enabled = False
            End If
        Else
            obrigacoesusuariosRibbonControl.Manager.Items(4).Enabled = False
        End If
    End Sub

    Public Function RetornaLayoutObrigacao(ByRef pstrObrigacao As String) As Integer Implements IObrigacoes.RetornaLayoutObrigacao
        Try
            Dim intLayout As Int32 = 0
            If pstrObrigacao = "000004" Or pstrObrigacao = "000005" Or pstrObrigacao = "000006" Or pstrObrigacao = "000007" Or
                pstrObrigacao = "000008" Or pstrObrigacao = "000009" Or pstrObrigacao = "000010" Or pstrObrigacao = "000011" Or
                pstrObrigacao = "000018" Or pstrObrigacao = "000019" Or pstrObrigacao = "000020" Or pstrObrigacao = "000021" Or
                pstrObrigacao = "000076" Or pstrObrigacao = "000077" Or pstrObrigacao = "000012" Or pstrObrigacao = "000013" Or
                pstrObrigacao = "000016" Or pstrObrigacao = "000022" Or pstrObrigacao = "000055" Or pstrObrigacao = "000056" Or
                pstrObrigacao = "000057" Or pstrObrigacao = "000014" Or pstrObrigacao = "000015" Or pstrObrigacao = "000017" Or
                pstrObrigacao = "000039" Or pstrObrigacao = "000073" Or pstrObrigacao = "000074" Or pstrObrigacao = "000081" Or
                pstrObrigacao = "000082" Or pstrObrigacao = "000083" Or pstrObrigacao = "000084" Or pstrObrigacao = "000091" Then
                intLayout = 1
            ElseIf pstrObrigacao = "000041" Or pstrObrigacao = "000042" Then
                intLayout = 2
            ElseIf pstrObrigacao = "000038" Or pstrObrigacao = "000043" Or pstrObrigacao = "000092" Then
                intLayout = 3
            End If
            Return intLayout
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class