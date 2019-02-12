Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid
Imports System.Windows.Forms

Public Class RegrasDAL
    Implements IRegras

    Private edit As RepositoryItemTextEdit
    Private regrasRibbonControl As RibbonControl

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements IRegras.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdRegra As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsRegras As New DataSet()
            Dim dtRegra As New DataTable("regra")
            For Each row As SelectStatementResultRow In sdRegra.ResultSet(0).Rows
                dtRegra.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsRegras.Tables.Add(dtRegra)

            For Each row As SelectStatementResultRow In sdRegra.ResultSet(1).Rows
                Dim drRegras As DataRow = dsRegras.Tables("regra").NewRow()
                For index = 0 To row.Values.Length - 1
                    drRegras(index) = row.Values(index)
                Next
                dsRegras.Tables("regra").Rows.Add(drRegras)
            Next

            sdRegra = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtObrigacao As New DataTable("obrigacao")
            For Each row As SelectStatementResultRow In sdRegra.ResultSet(0).Rows
                dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsRegras.Tables.Add(dtObrigacao)

            For Each row As SelectStatementResultRow In sdRegra.ResultSet(1).Rows
                Dim drObrigacao As DataRow = dsRegras.Tables("obrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    drObrigacao(index) = row.Values(index)
                Next
                dsRegras.Tables("obrigacao").Rows.Add(drObrigacao)
            Next

            sdRegra = objDataBase.QueryFull(pstrQuery(2).ToString)
            Dim dtEmpresa As New DataTable("empresa")
            For Each row As SelectStatementResultRow In sdRegra.ResultSet(0).Rows
                dtEmpresa.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsRegras.Tables.Add(dtEmpresa)

            For Each row As SelectStatementResultRow In sdRegra.ResultSet(1).Rows
                Dim drEmpresa As DataRow = dsRegras.Tables("empresa").NewRow()
                For index = 0 To row.Values.Length - 1
                    drEmpresa(index) = row.Values(index)
                Next
                dsRegras.Tables("empresa").Rows.Add(drEmpresa)
            Next

            Dim keyColumn As DataColumn = dsRegras.Tables("regra").Columns("regra")
            Dim foreignKeyColumnObr As DataColumn = dsRegras.Tables("obrigacao").Columns("regra")
            Dim foreignKeyColumnEmp As DataColumn = dsRegras.Tables("empresa").Columns("regra")

            dsRegras.Relations.Add("RegraObrigacao", keyColumn, foreignKeyColumnObr)
            dsRegras.Relations.Add("RegraEmpresa", keyColumn, foreignKeyColumnEmp)

            'Bind the grid control to the data source
            pdgGrid.DataSource = dsRegras.Tables("regra")
            pdgGrid.ForceInitialize()
            AddHandler pdgGrid.KeyUp, AddressOf pdgGrid_KeyUp

            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

            pgvGrid.Columns(0).Caption = "Regra"
            pgvGrid.Columns(0).Width = 25

            pgvGrid.Columns(1).Caption = "Descrição"
            pgvGrid.Columns(1).Width = 300
            AddHandler pgvGrid.RowCellClick, AddressOf pgvGrid_RowCellClick

            Dim obrigacaogridview As New GridView(pdgGrid)
            pdgGrid.LevelTree.Nodes.Add("RegraObrigacao", obrigacaogridview)
            obrigacaogridview.ViewCaption = pstrTituloGrid(1).ToString
            obrigacaogridview.PopulateColumns(dsRegras.Tables("obrigacao"))
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
            obrigacaogridview.Columns(1).Width = 40

            obrigacaogridview.Columns(2).Caption = "Descrição"
            obrigacaogridview.Columns(2).Width = 500
            obrigacaogridview.Name = "obrigacaoGridView"
            AddHandler obrigacaogridview.RowCellClick, AddressOf obrigacaogridview_RowCellClick

            Dim empresagridview As New GridView(pdgGrid)
            pdgGrid.LevelTree.Nodes.Add("RegraEmpresa", empresagridview)
            empresagridview.ViewCaption = pstrTituloGrid(2).ToString
            empresagridview.PopulateColumns(dsRegras.Tables("empresa"))
            empresagridview.OptionsView.ShowGroupPanel = False
            empresagridview.OptionsBehavior.Editable = False
            empresagridview.OptionsCustomization.AllowQuickHideColumns = False
            empresagridview.OptionsCustomization.AllowColumnResizing = False
            empresagridview.OptionsCustomization.AllowColumnMoving = False
            empresagridview.OptionsCustomization.AllowGroup = False

            empresagridview.Columns(0).Visible = False

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            empresagridview.Columns(1).ColumnEdit = edit
            empresagridview.Columns(1).Caption = "Empresa"
            empresagridview.Columns(1).Width = 40

            empresagridview.Columns(2).Caption = "Razão Social"
            empresagridview.Columns(2).Width = 500
            empresagridview.Name = "empresaGridView"
            AddHandler empresagridview.RowCellClick, AddressOf empresagridview_RowCellClick

            regrasRibbonControl = prcRibbonControl
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub pdgGrid_KeyUp(sender As Object, e As KeyEventArgs)
        Dim gcSender As GridControl = DirectCast(sender, GridControl)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If gcSender.FocusedView.Name = "regrasGridView" Then
                regrasRibbonControl.Manager.Items(4).Enabled = True
            Else
                regrasRibbonControl.Manager.Items(4).Enabled = False
            End If
        End If
    End Sub

    Private Sub pgvGrid_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub obrigacaogridview_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub empresagridview_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub HabilitaDesabilitaExcluirBarButton(pobjSender As Object, prccEvent As RowCellClickEventArgs)
        Dim gvSender As GridView = DirectCast(pobjSender, GridView)
        If gvSender.Name = "regrasGridView" Then
            If prccEvent.Clicks = 1 Then
                regrasRibbonControl.Manager.Items(4).Enabled = True
            Else
                regrasRibbonControl.Manager.Items(4).Enabled = False
            End If
        Else
            regrasRibbonControl.Manager.Items(4).Enabled = False
        End If
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoEmpresas As System.Collections.Generic.List(Of Modelo.regrasempresasinfo)) Implements IRegras.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresa As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdEmpresa.ResultSet(1).Rows
                infoEmpresas.Add(New regrasempresasinfo(row.Values(0).ToString, row.Values(1).ToString))
            Next

            pdgGrid.DataSource = infoEmpresas

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Empresa"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Razão Social"
            pgvGrid.Columns(1).Width = 300

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoObrigacoes As System.Collections.Generic.List(Of Modelo.regrasobrigacoesinfo)) Implements IRegras.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresa As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdEmpresa.ResultSet(1).Rows
                infoObrigacoes.Add(New regrasobrigacoesinfo(row.Values(0).ToString, row.Values(1).ToString))
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

    Public Sub Report(ByRef pstrCampoInicialRegra As String, ByRef pstrCampoFinalRegra As String, ByRef pstrCampoInicialObrigacao As String, ByRef pstrCampoFinalObrigacao As String, ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements IRegras.Report
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = "select 1 as ordem, ar.regra, max(ar.descricao) as descricao, cast('' as varchar) as tipo, cast('' as varchar) as codigo_emp_obr, cast('' as varchar) as descricao_emp_obr " +
                                       "from admregras ar "
            If Not String.IsNullOrEmpty(pstrCampoInicialObrigacao) And Not String.IsNullOrEmpty(pstrCampoFinalObrigacao) Then
                strQuery += "join admregrasobrigacoes aro on aro.regra = ar.regra " +
                                                        "and aro.obrigacao >= '" + pstrCampoInicialObrigacao + "' " +
                                                        "and aro.obrigacao <= '" + pstrCampoFinalObrigacao + "' " +
                                                        "and aro.exercicio = ar.exercicio "
            End If
            If Not String.IsNullOrEmpty(pstrCampoInicialEmpresa) And Not String.IsNullOrEmpty(pstrCampoFinalEmpresa) Then
                strQuery += "join admregrasempresas are on are.regra = ar.regra " +
                                                      "and are.empresa >= '" + pstrCampoInicialEmpresa + "' " +
                                                      "and are.empresa <= '" + pstrCampoFinalEmpresa + "' " +
                                                      "and are.exercicio = ar.exercicio "
            End If
            strQuery += "where ar.exercicio = " + administrativoInfo.Exercicio.ToString + " "
            If Not String.IsNullOrEmpty(pstrCampoInicialRegra) And Not String.IsNullOrEmpty(pstrCampoFinalRegra) Then
                strQuery += "and ar.regra >= " + pstrCampoInicialRegra + " " +
                            "and ar.regra <= " + pstrCampoFinalRegra + " "
            End If
            strQuery += "group by ar.regra "

            strQuery += "union all "
            strQuery += "select 2 as ordem, aro.regra, cast('' as varchar) as descricao, cast('OBRIGACAO' as varchar) as tipo, aro.obrigacao as codigo_emp_obr, max(ao.descricao) as descricao_emp_obr " +
                          "from admregrasobrigacoes aro " +
                          "join admregras ar on ar.regra = aro.regra " +
                                           "and ar.exercicio = aro.exercicio "
            If Not String.IsNullOrEmpty(pstrCampoInicialEmpresa) And Not String.IsNullOrEmpty(pstrCampoFinalEmpresa) Then
                strQuery += "join admregrasempresas are on are.regra = aro.regra " +
                                                      "and are.empresa >= '" + pstrCampoInicialEmpresa + "' " +
                                                      "and are.empresa <= '" + pstrCampoFinalEmpresa + "' " +
                                                      "and are.exercicio = aro.exercicio "
            End If
            strQuery += "join admobrigacoes ao on ao.obrigacao = aro.obrigacao "
            strQuery += "where aro.exercicio = " + administrativoInfo.Exercicio.ToString + " "
            If Not String.IsNullOrEmpty(pstrCampoInicialRegra) And Not String.IsNullOrEmpty(pstrCampoFinalRegra) Then
                strQuery += "and aro.regra >= " + pstrCampoInicialRegra + " " +
                            "and aro.regra <= " + pstrCampoFinalRegra + " "
            End If
            If Not String.IsNullOrEmpty(pstrCampoInicialObrigacao) And Not String.IsNullOrEmpty(pstrCampoFinalObrigacao) Then
                strQuery += "and aro.obrigacao >= '" + pstrCampoInicialObrigacao + "' " +
                            "and aro.obrigacao <= '" + pstrCampoFinalObrigacao + "' "
            End If
            strQuery += "group by aro.regra, aro.obrigacao "

            strQuery += "union all "
            strQuery += "select 3 as ordem, are.regra, cast('' as varchar) as descricao, cast('EMPRESA' as varchar) as tipo, are.empresa as codigo_emp_obr, max(e.razaosocial) as descricao_emp_obr " +
                          "from admregrasempresas are " +
                          "join admregras ar on ar.regra = are.regra " +
                                           "and ar.exercicio = are.exercicio "
            If Not String.IsNullOrEmpty(pstrCampoInicialObrigacao) And Not String.IsNullOrEmpty(pstrCampoFinalObrigacao) Then
                strQuery += "join admregrasobrigacoes aro on aro.regra = are.regra " +
                                                        "and aro.obrigacao >= '" + pstrCampoInicialObrigacao + "' " +
                                                        "and aro.obrigacao <= '" + pstrCampoFinalObrigacao + "' " +
                                                        "and aro.exercicio = are.exercicio "
            End If

            strQuery += "join empresas e on e.empresa = are.empresa and e.exercicio = are.exercicio "
            strQuery += "where are.exercicio = " + administrativoInfo.Exercicio.ToString + " "
            If Not String.IsNullOrEmpty(pstrCampoInicialRegra) And Not String.IsNullOrEmpty(pstrCampoFinalRegra) Then
                strQuery += "and are.regra >= " + pstrCampoInicialRegra + " " +
                            "and are.regra <= " + pstrCampoFinalRegra + " "
            End If
            If Not String.IsNullOrEmpty(pstrCampoInicialEmpresa) And Not String.IsNullOrEmpty(pstrCampoFinalEmpresa) Then
                strQuery += "and are.empresa >= '" + pstrCampoInicialEmpresa + "' " +
                            "and are.empresa <= '" + pstrCampoFinalEmpresa + "' "
            End If
            strQuery += "group by are.regra, are.empresa "

            strQuery += "order by 2, 1, 4"

            pReport.DataSource = objDataBase.QueryDataView(strQuery)

            Dim dvtable As XPDataView = CType(pReport.DataSource, XPDataView)
            If dvtable.Count = 0 Then Throw New Exception("Não existem informações a serem impressas")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ProximaRegra() As Integer Implements IRegras.ProximaRegra
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            Return objDataBase.QuerySimples("select coalesce(max(regra),0) + 1 from admregras where exercicio = " + administrativoInfo.Exercicio.ToString)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub IUDRegras(ByRef pstrOperacao As String, ByRef infoRegras As Modelo.regrasinfo, ByRef originalinfoEmpresas As System.Collections.Generic.List(Of Modelo.regrasempresasinfo), ByRef originalinfoObrigacoes As System.Collections.Generic.List(Of Modelo.regrasobrigacoesinfo)) Implements IRegras.IUDRegras
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "inclusao" Then
                strQuery = "insert into admregras(exercicio, regra, descricao, incuser, incdata, altuser, altdata) " +
                                         "values (" + administrativoInfo.Exercicio.ToString() + ", " +
                                                      infoRegras.regra.ToString() + ", " +
                                                "'" + infoRegras.descricao + "', " +
                                                "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                "'" + usuarioInfo.usuario + "', current_timestamp);"
            ElseIf pstrOperacao = "alteracao" Then
                strQuery = "update admregras " +
                              "set descricao = '" + infoRegras.descricao + "', " +
                                  "altuser = '" + usuarioInfo.usuario + "', " +
                                  "altdata = current_timestamp " +
                            "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                              "and regra = " + infoRegras.regra.ToString + ";"
            ElseIf pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                              "from admregrasempresas " +
                             "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                               "and regra = " + infoRegras.regra.ToString + ";"

                strQuery += Chr(13) + Chr(10)
                strQuery += "delete " +
                              "from admregrasobrigacoes " +
                             "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                               "and regra = " + infoRegras.regra.ToString + ";"

                strQuery += Chr(13) + Chr(10)
                strQuery += "delete " +
                              "from admregras " +
                            "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                              "and regra = " + infoRegras.regra.ToString + ";"

            End If
            If pstrOperacao <> "exclusao" Then
                If infoRegras.empresas.Count = 0 And originalinfoEmpresas.Count > 0 Then
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from admregrasempresas " +
                                 "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                   "and regra = " + infoRegras.regra.ToString + ";"
                End If
                If infoRegras.obrigacoes.Count = 0 And originalinfoObrigacoes.Count > 0 Then
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from admregrasobrigacoes " +
                                 "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                   "and regra = " + infoRegras.regra.ToString + ";"
                End If
                For indexoriginal = 0 To originalinfoEmpresas.Count - 1
                    Dim blnEncontrouRegraEmpresa As Boolean = False
                    For index = 0 To infoRegras.empresas.Count - 1
                        If originalinfoEmpresas(indexoriginal).empresa = infoRegras.empresas(index).empresa Then
                            blnEncontrouRegraEmpresa = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouRegraEmpresa Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from admregrasempresas " +
                                     "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                       "and regra = " + infoRegras.regra.ToString + " " +
                                       "and empresa = '" + originalinfoEmpresas(indexoriginal).empresa + "';"
                    End If
                Next
                For index = 0 To infoRegras.empresas.Count - 1
                    Dim blnEncontrouRegraEmpresa As Boolean = False
                    For indexoriginal = 0 To originalinfoEmpresas.Count - 1
                        If infoRegras.empresas(index).empresa = originalinfoEmpresas(indexoriginal).empresa Then
                            blnEncontrouRegraEmpresa = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouRegraEmpresa Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "insert into admregrasempresas(exercicio, regra, empresa, incuser, incdata, altuser, altdata) " +
                                                          "values (" + administrativoInfo.Exercicio.ToString() + ", " +
                                                                       infoRegras.regra.ToString() + ", " +
                                                                 "'" + infoRegras.empresas(index).empresa + "', " +
                                                                 "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                 "'" + usuarioInfo.usuario + "', current_timestamp);"
                    End If
                Next
                For indexoriginal = 0 To originalinfoObrigacoes.Count - 1
                    Dim blnEncontrouRegraObrigacao As Boolean = False
                    For index = 0 To infoRegras.obrigacoes.Count - 1
                        If originalinfoObrigacoes(indexoriginal).obrigacao = infoRegras.obrigacoes(index).obrigacao Then
                            blnEncontrouRegraObrigacao = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouRegraObrigacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from admregrasobrigacoes " +
                                     "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                       "and regra = " + infoRegras.regra.ToString + " " +
                                       "and obrigacao = '" + originalinfoObrigacoes(indexoriginal).obrigacao + "';"
                    End If
                Next
                For index = 0 To infoRegras.obrigacoes.Count - 1
                    Dim blnEncontrouRegraObrigacao As Boolean = False
                    For indexoriginal = 0 To originalinfoObrigacoes.Count - 1
                        If infoRegras.obrigacoes(index).obrigacao = originalinfoObrigacoes(indexoriginal).obrigacao Then
                            blnEncontrouRegraObrigacao = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouRegraObrigacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "insert into admregrasobrigacoes(exercicio, regra, obrigacao, incuser, incdata, altuser, altdata) " +
                                                          "values (" + administrativoInfo.Exercicio.ToString() + ", " +
                                                                       infoRegras.regra.ToString() + ", " +
                                                                 "'" + infoRegras.obrigacoes(index).obrigacao + "', " +
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

    Public Sub GerarRegras(ByRef pstrCampoInicialRegra As String, ByRef pstrCampoFinalRegra As String, ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByRef pstrCampoObrigacao As String, pblnExcluiEmpresaObrigacao As Boolean) Implements IRegras.GerarRegras
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pblnExcluiEmpresaObrigacao Then
                strQuery = "delete " +
                             "from admobrigacoesempresas " +
                            "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                              "and empresa in (select are.empresa " +
                                                "from admregras ar " +
                                                "join admregrasempresas are on are.regra = ar.regra " +
                                                                          "and are.exercicio = ar.exercicio " +
                                                                          "and are.empresa >= '" + pstrCampoInicialEmpresa.ToString() + "' " +
                                                                          "and are.empresa <= '" + pstrCampoFinalEmpresa.ToString() + "' " +
                                                "join admregrasobrigacoes aro on aro.regra = ar.regra and aro.exercicio = ar.exercicio "
                If Not String.IsNullOrEmpty(pstrCampoObrigacao) Then
                    strQuery += "and aro.obrigacao = '" + pstrCampoObrigacao + "' "
                End If
                strQuery += "where ar.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                              "and ar.regra >= " + pstrCampoInicialRegra.ToString() + " " +
                              "and ar.regra <= " + pstrCampoFinalRegra.ToString() + " " +
                         "group by are.empresa) "
                If Not String.IsNullOrEmpty(pstrCampoObrigacao) Then
                    strQuery += "and obrigacao = '" + pstrCampoObrigacao + "' "
                End If
                strQuery += ";"
                strQuery += Chr(13) + Chr(10)
            Else
                strQuery = "select count(*) " +
                             "from admobrigacoesempresas " +
                            "where exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                              "and empresa in (select are.empresa " +
                                                "from admregras ar " +
                                                "join admregrasempresas are on are.regra = ar.regra " +
                                                                          "and are.exercicio = ar.exercicio " +
                                                                          "and are.empresa >= '" + pstrCampoInicialEmpresa.ToString() + "' " +
                                                                          "and are.empresa <= '" + pstrCampoFinalEmpresa.ToString() + "' " +
                                                "join admregrasobrigacoes aro on aro.regra = ar.regra and aro.exercicio = ar.exercicio "
                If Not String.IsNullOrEmpty(pstrCampoObrigacao) Then
                    strQuery += "and aro.obrigacao = '" + pstrCampoObrigacao + "' "
                End If
                strQuery += "where ar.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                                 "and ar.regra >= " + pstrCampoInicialRegra.ToString() + " " +
                                                 "and ar.regra <= " + pstrCampoFinalRegra.ToString() + " " +
                                            "group by are.empresa) "
                If Not String.IsNullOrEmpty(pstrCampoObrigacao) Then
                    strQuery += "and obrigacao = '" + pstrCampoObrigacao + "' "
                End If
                strQuery += ";"

                Dim intCount As Int32 = objDataBase.QuerySimples(strQuery)
                If intCount > 0 Then Throw New Exception("Não será possivel gerar Regras para essas empresas, pois já existem obrigações vinculadas.")
                strQuery = String.Empty
            End If
            strQuery += "insert into admobrigacoesempresas(exercicio, obrigacao, empresa, incuser, incdata, altuser, altdata) " +
                        "select ar.exercicio, aro.obrigacao, are.empresa, '" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                         "'" + usuarioInfo.usuario + "', current_timestamp " +
                          "from admregras ar " +
                          "join admregrasempresas are on are.regra = ar.regra " +
                                                    "and are.exercicio = ar.exercicio " +
                                                    "and are.empresa >= '" + pstrCampoInicialEmpresa.ToString() + "' " +
                                                    "and are.empresa <= '" + pstrCampoFinalEmpresa.ToString() + "' " +
                          "join empresas e on e.empresa = are.empresa and e.exercicio = are.exercicio and coalesce(e.matriz,e.empresa) = are.empresa " +
                          "join admregrasobrigacoes aro on aro.regra = ar.regra and aro.exercicio = ar.exercicio "
            If Not String.IsNullOrEmpty(pstrCampoObrigacao) Then
                strQuery += "and aro.obrigacao = '" + pstrCampoObrigacao + "' "
            End If
            strQuery += "join admobrigacoes ao on ao.obrigacao = aro.obrigacao and coalesce(ao.tributo,'') = 'F' " +
                       "where ar.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                         "and ar.regra >= " + pstrCampoInicialRegra.ToString() + " " +
                         "and ar.regra <= " + pstrCampoFinalRegra.ToString() + " " +
                   "union all " +
                      "select ar.exercicio, aro.obrigacao, are.empresa, '" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                       "'" + usuarioInfo.usuario + "', current_timestamp " +
                        "from admregras ar " +
                        "join admregrasempresas are on are.regra = ar.regra " +
                                                  "and are.exercicio = ar.exercicio " +
                                                  "and are.empresa >= '" + pstrCampoInicialEmpresa.ToString() + "' " +
                                                  "and are.empresa <= '" + pstrCampoFinalEmpresa.ToString() + "' " +
                        "join admregrasobrigacoes aro on aro.regra = ar.regra and aro.exercicio = ar.exercicio "
            If Not String.IsNullOrEmpty(pstrCampoObrigacao) Then
                strQuery += "and aro.obrigacao = '" + pstrCampoObrigacao + "' "
            End If
            strQuery += "join admobrigacoes ao on ao.obrigacao = aro.obrigacao and coalesce(ao.tributo,'') <> 'F' " +
                       "where ar.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                         "and ar.regra >= " + pstrCampoInicialRegra.ToString() + " " +
                         "and ar.regra <= " + pstrCampoFinalRegra.ToString() + ";"

            objDataBase.NonQuery(strQuery)
            SincronizarGerarRegras(pstrCampoInicialEmpresa, pstrCampoFinalEmpresa)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarGerarRegras(ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String) Implements IRegras.SincronizarGerarRegras
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdData As SelectedData

            Dim wsConsulta As New SelectWS
            Dim wsInclusao As New InsertWS
            Dim wsAlteracao As New UpdateWS

            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                sdData = objDataBase.QueryFull("select aoe.empresa, emp.razaosocial, coalesce(emp.cnpj,'') as cnpjcpf " +
                                                 "from (select aoe.empresa, max(aoe.exercicio) as exercicio " +
                                                         "from admobrigacoesempresas aoe " +
                                                        "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                                          "and aoe.empresa >= '" + pstrCampoInicialEmpresa.ToString() + "' " +
                                                          "and aoe.empresa <= '" + pstrCampoFinalEmpresa.ToString() + "' group by aoe.empresa) aoe " +
                                                 "join empresas emp on emp.empresa = aoe.empresa and emp.exercicio = aoe.exercicio " +
                                             "order by 1")
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    Dim infoEmpresaObrigacoes As New empresaobrigacoesInfo
                    infoEmpresaObrigacoes.empresa = row.Values(0).ToString
                    infoEmpresaObrigacoes.razaosocial = row.Values(1).ToString
                    infoEmpresaObrigacoes.cnpjcpf = row.Values(2).ToString

                    Dim objEmpresaObrigacaoes As New EmpresaObrigacoesDAL
                    objEmpresaObrigacaoes.SincronizaEmpresaObrigacoes("alteracao", infoEmpresaObrigacoes)
                Next row
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
