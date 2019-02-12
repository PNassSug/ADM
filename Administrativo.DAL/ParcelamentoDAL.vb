Imports Administrativo.Modelo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils

Public Class ParcelamentoDAL
    Implements IParcelamento

    Private edit As RepositoryItemTextEdit
    Private image As RepositoryItemImageComboBox

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridObrigacao As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridParcelamento As DevExpress.XtraGrid.Views.Grid.GridView, picStatusImageColection As DevExpress.Utils.ImageCollection) Implements IParcelamento.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdParcelamento As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsParcelamento As New DataSet()
            Dim dtParcelamento As New DataTable("empresa")
            For Each row As SelectStatementResultRow In sdParcelamento.ResultSet(0).Rows
                dtParcelamento.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsParcelamento.Tables.Add(dtParcelamento)

            For Each row As SelectStatementResultRow In sdParcelamento.ResultSet(1).Rows
                Dim drEmpresa As DataRow = dsParcelamento.Tables("empresa").NewRow()
                For index = 0 To row.Values.Length - 1
                    drEmpresa(index) = row.Values(index)
                Next
                dsParcelamento.Tables("empresa").Rows.Add(drEmpresa)
            Next

            sdParcelamento = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtObrigacao As New DataTable("obrigacao")
            For Each row As SelectStatementResultRow In sdParcelamento.ResultSet(0).Rows
                dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsParcelamento.Tables.Add(dtObrigacao)

            For Each row As SelectStatementResultRow In sdParcelamento.ResultSet(1).Rows
                Dim drObrigacao As DataRow = dsParcelamento.Tables("obrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    drObrigacao(index) = row.Values(index)
                Next
                dsParcelamento.Tables("obrigacao").Rows.Add(drObrigacao)
            Next

            sdParcelamento = objDataBase.QueryFull(pstrQuery(2).ToString)
            Dim dtDetalhe As New DataTable("detalhe")
            For Each row As SelectStatementResultRow In sdParcelamento.ResultSet(0).Rows
                dtDetalhe.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsParcelamento.Tables.Add(dtDetalhe)

            For Each row As SelectStatementResultRow In sdParcelamento.ResultSet(1).Rows
                Dim drDetalhe As DataRow = dsParcelamento.Tables("detalhe").NewRow()
                For index = 0 To row.Values.Length - 1
                    drDetalhe(index) = row.Values(index)
                Next
                dsParcelamento.Tables("detalhe").Rows.Add(drDetalhe)
            Next

            Dim keyColumnEmpresa As DataColumn = dsParcelamento.Tables("empresa").Columns("empresa")
            Dim foreignKeyColumnEmpresaEmp As DataColumn = dsParcelamento.Tables("obrigacao").Columns("empresa")
            dsParcelamento.Relations.Add("EmpresaObrigacao", {keyColumnEmpresa}, {foreignKeyColumnEmpresaEmp})


            Dim keyColumnObrigacaoEmp As DataColumn = dsParcelamento.Tables("obrigacao").Columns("empresa")
            Dim keyColumnObrigacaoObr As DataColumn = dsParcelamento.Tables("obrigacao").Columns("obrigacao")
            Dim keyColumnObrigacaoSeq As DataColumn = dsParcelamento.Tables("obrigacao").Columns("sequenciaextra")

            Dim foreignKeyColumnObrigacaoEmp As DataColumn = dsParcelamento.Tables("detalhe").Columns("empresa")
            Dim foreignKeyColumnObrigacaoObr As DataColumn = dsParcelamento.Tables("detalhe").Columns("obrigacao")
            Dim foreignKeyColumnObrigacaoSeq As DataColumn = dsParcelamento.Tables("detalhe").Columns("sequenciaextra")
            dsParcelamento.Relations.Add("ObrigacaoDetalhe", {keyColumnObrigacaoEmp, keyColumnObrigacaoObr, keyColumnObrigacaoSeq}, {foreignKeyColumnObrigacaoEmp, foreignKeyColumnObrigacaoObr, foreignKeyColumnObrigacaoSeq})

            'Bind the grid control to the data source
            pdgGrid.DataSource = dsParcelamento.Tables("empresa")
            pdgGrid.ForceInitialize()
            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvGrid.OptionsCustomization.AllowQuickHideColumns = False
            pgvGrid.OptionsCustomization.AllowColumnResizing = False
            pgvGrid.OptionsCustomization.AllowColumnMoving = False
            pgvGrid.OptionsCustomization.AllowGroup = False
            pgvGrid.OptionsView.ColumnAutoWidth = False
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Empresa"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Razão Social"
            pgvGrid.Columns(1).Width = 580

            pdgGrid.LevelTree.Nodes(0).RelationName = "EmpresaObrigacao"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridObrigacao
            pgvGridObrigacao.ViewCaption = pstrTituloGrid(1).ToString
            pgvGridObrigacao.PopulateColumns(dsParcelamento.Tables("obrigacao"))
            pgvGridObrigacao.OptionsView.ShowGroupPanel = False
            pgvGridObrigacao.OptionsBehavior.Editable = False
            pgvGridObrigacao.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridObrigacao.OptionsCustomization.AllowColumnResizing = False
            pgvGridObrigacao.OptionsCustomization.AllowColumnMoving = False
            pgvGridObrigacao.OptionsCustomization.AllowGroup = False
            pgvGridObrigacao.OptionsView.ColumnAutoWidth = False
            pgvGridObrigacao.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            pgvGridObrigacao.OptionsView.ColumnAutoWidth = False
            pgvGridObrigacao.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridObrigacao.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridObrigacao.Columns(0).Visible = False
            pgvGridObrigacao.Columns(3).Visible = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGridObrigacao.Columns(1).ColumnEdit = edit
            pgvGridObrigacao.Columns(1).Caption = "Obrigação"
            pgvGridObrigacao.Columns(1).Width = 85

            pgvGridObrigacao.Columns(2).Caption = "Descrição"
            pgvGridObrigacao.Columns(2).Width = 250

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridObrigacao.Columns(4).ColumnEdit = edit
            pgvGridObrigacao.Columns(4).Caption = "Período Inicial"
            pgvGridObrigacao.Columns(4).Width = 90

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridObrigacao.Columns(5).ColumnEdit = edit
            pgvGridObrigacao.Columns(5).Caption = "Período Final"
            pgvGridObrigacao.Columns(5).Width = 90

            pgvGridObrigacao.Columns(6).Caption = "Quantidade Parcelas"
            pgvGridObrigacao.Columns(6).Width = 120

            pdgGrid.LevelTree.Nodes(0).Nodes(0).RelationName = "ObrigacaoDetalhe"
            pdgGrid.LevelTree.Nodes(0).Nodes(0).LevelTemplate = pgvGridParcelamento
            pgvGridParcelamento.ViewCaption = pstrTituloGrid(2).ToString
            pgvGridParcelamento.PopulateColumns(dsParcelamento.Tables("detalhe"))
            pgvGridParcelamento.OptionsView.ShowGroupPanel = False
            pgvGridParcelamento.OptionsBehavior.Editable = False
            pgvGridParcelamento.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridParcelamento.OptionsCustomization.AllowColumnResizing = False
            pgvGridParcelamento.OptionsCustomization.AllowColumnMoving = False
            pgvGridParcelamento.OptionsCustomization.AllowGroup = False
            pgvGridParcelamento.OptionsView.ColumnAutoWidth = False
            pgvGridParcelamento.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            pgvGridParcelamento.OptionsView.ColumnAutoWidth = False
            pgvGridParcelamento.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGridParcelamento.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGridParcelamento.Columns(0).Visible = False
            pgvGridParcelamento.Columns(1).Visible = False
            pgvGridParcelamento.Columns(2).Visible = False


            pgvGridParcelamento.Columns(3).Caption = "Parcela"
            pgvGridParcelamento.Columns(3).Width = 75

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGridParcelamento.Columns(4).ColumnEdit = edit
            pgvGridParcelamento.Columns(4).Caption = "Fato Gerador"
            pgvGridParcelamento.Columns(4).Width = 85

            pgvGridParcelamento.Columns(5).Caption = "Data Vencimento"
            pgvGridParcelamento.Columns(5).Width = 100

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridParcelamento.Columns(6).ColumnEdit = image
            pgvGridParcelamento.Columns(6).Caption = "Status"
            pgvGridParcelamento.Columns(6).Width = 120
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoParcelamentoDetalhes As System.Collections.Generic.List(Of Modelo.parcelamentodetalhes), picStatusImageColection As DevExpress.Utils.ImageCollection) Implements IParcelamento.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresa As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdEmpresa.ResultSet(1).Rows
                infoParcelamentoDetalhes.Add(New parcelamentodetalhes(row.Values(3), row.Values(4).ToString, row.Values(5), row.Values(6)))
            Next

            pdgGrid.DataSource = infoParcelamentoDetalhes
            pgvGrid.OptionsView.ShowGroupPanel = False
            pgvGrid.OptionsBehavior.Editable = False
            pgvGrid.OptionsCustomization.AllowQuickHideColumns = False
            pgvGrid.OptionsCustomization.AllowColumnResizing = False
            pgvGrid.OptionsCustomization.AllowColumnMoving = False
            pgvGrid.OptionsCustomization.AllowGroup = False
            pgvGrid.OptionsView.ColumnAutoWidth = False
            pgvGrid.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            pgvGrid.OptionsView.ColumnAutoWidth = False
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvGrid.Columns(0).Caption = "Parcela"
            pgvGrid.Columns(0).Width = 75

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGrid.Columns(1).ColumnEdit = edit
            pgvGrid.Columns(1).Caption = "Fato Gerador"
            pgvGrid.Columns(1).Width = 85

            pgvGrid.Columns(2).Caption = "Data Vencimento"
            pgvGrid.Columns(2).Width = 90

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGrid.Columns(3).ColumnEdit = image
            pgvGrid.Columns(3).Caption = "Status"
            pgvGrid.Columns(3).Width = 120

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDParcelamento(ByRef pstrOperacao As String, ByRef infoParcelamento As Modelo.parcelamentoInfo, ByRef originalinfoinfoParcelamentoDetalhes As System.Collections.Generic.List(Of Modelo.parcelamentodetalhes)) Implements IParcelamento.IUDParcelamento
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            If pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admcontroleadministrativo " +
                            "where empresa = '" + infoParcelamento.empresa + "' " +
                              "and obrigacao = '" + infoParcelamento.obrigacao + "' " +
                              "and sequenciaextra = " + infoParcelamento.sequenciaextra.ToString + " " +
                              "and coalesce(obrigacaoextra,0) = -1;"
            End If
            If pstrOperacao <> "exclusao" Then
                For indexoriginal = 0 To originalinfoinfoParcelamentoDetalhes.Count - 1
                    Dim blnEncontrouParcela As Boolean = False
                    For index = 0 To infoParcelamento.detalhes.Count - 1
                        If originalinfoinfoParcelamentoDetalhes(indexoriginal).parcela = infoParcelamento.detalhes(index).parcela And
                            originalinfoinfoParcelamentoDetalhes(indexoriginal).competencia = infoParcelamento.detalhes(index).competencia Then
                            blnEncontrouParcela = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouParcela Then
                        If Not String.IsNullOrEmpty(strQuery) Then
                            strQuery += Chr(13) + Chr(10)
                        End If
                        strQuery += "delete " +
                                      "from admcontroleadministrativo " +
                                     "where empresa = '" + infoParcelamento.empresa + "' " +
                                       "and obrigacao = '" + infoParcelamento.obrigacao + "' " +
                                       "and competencia = '" + originalinfoinfoParcelamentoDetalhes(indexoriginal).competencia + "' " +
                                       "and parcela = " + originalinfoinfoParcelamentoDetalhes(indexoriginal).parcela.ToString + " " +
                                       "and sequenciaextra = " + infoParcelamento.sequenciaextra.ToString + " " +
                                       "and coalesce(obrigacaoextra,0) = -1;"
                    End If
                Next
                If pstrOperacao = "inclusao" Then
                    infoParcelamento.sequenciaextra = objDataBase.QuerySimples("select max(coalesce(aca.sequenciaextra,0)) " +
                                                                                 "from admcontroleadministrativo aca " +
                                                                                "where aca.empresa = '" + infoParcelamento.empresa + "' " +
                                                                                  "and aca.obrigacao = '" + infoParcelamento.obrigacao + "' " +
                                                                                  "and coalesce(aca.obrigacaoextra,0) = -1") + 1
                End If

                For index = 0 To infoParcelamento.detalhes.Count - 1
                    Dim blnEncontrouParcela As Boolean = False
                    For indexoriginal = 0 To originalinfoinfoParcelamentoDetalhes.Count - 1
                        If originalinfoinfoParcelamentoDetalhes(indexoriginal).parcela = infoParcelamento.detalhes(index).parcela And
                           originalinfoinfoParcelamentoDetalhes(indexoriginal).competencia = infoParcelamento.detalhes(index).competencia Then
                            blnEncontrouParcela = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouParcela Then
                        If Not String.IsNullOrEmpty(strQuery) Then
                            strQuery += Chr(13) + Chr(10)
                        End If
                        strQuery += "insert into admcontroleadministrativo(empresa, competencia, obrigacao, exercicio, parcela, sequenciaextra, obrigacaoextra, datavencimento) " +
                                                                                 "values ('" + infoParcelamento.empresa + "', " +
                                                                                         "'" + infoParcelamento.detalhes(index).competencia + "', " +
                                                                                         "'" + infoParcelamento.obrigacao + "', " +
                                                                                               infoParcelamento.detalhes(index).competencia.Substring(2, 4) + ", " +
                                                                                               infoParcelamento.detalhes(index).parcela.ToString + ", " +
                                                                                               infoParcelamento.sequenciaextra.ToString + ", -1, " +
                                                                                         "'" + infoParcelamento.detalhes(index).datavencimento.Value.ToString("yyyy-MM-dd") + "');"
                    End If
                Next
            End If
            If Not String.IsNullOrEmpty(strQuery) Then
                objDataBase.NonQuery(strQuery)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaVencimento(ByRef pstrEstado As String, ByRef pstrMunicipio As String, ByRef pstrCompetencia As String, ByRef pstrPeriodicidade As String, ByRef pintDiaVencimento As Integer, ByRef pstrTipoDia As String, ByRef pintSabDomUtil As Integer, ByRef pintAntecipaUtil As Integer, ByRef pintSubsequente As Integer, ByRef pstrTipoSubsequente As String) As Date Implements IParcelamento.BuscaVencimento
        Try
            Dim objDataBase As New DataBaseDAL

            Dim dtaDataVencimento As Nullable(Of DateTime)
            dtaDataVencimento = objDataBase.QuerySimples("select gd_datavencimento('" + pstrEstado + "', '" + pstrMunicipio + "', '" + pstrCompetencia + "'," +
                                                                                  "'" + pstrPeriodicidade + "', " + pintDiaVencimento.ToString + ",'" + pstrTipoDia + "', " +
                                                                                        pintSabDomUtil.ToString + ", " + pintAntecipaUtil.ToString + ", " +
                                                                                        pintSubsequente.ToString + ", '" + pstrTipoSubsequente + "')")
            Return dtaDataVencimento
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
End Class
