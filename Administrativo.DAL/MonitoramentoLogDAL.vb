Imports DevExpress.Xpo.DB
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class MonitoramentoLogDAL
    Implements IMonitoramentoLog

    Private edit As RepositoryItemTextEdit
    Private memo As RepositoryItemMemoExEdit
    Private image As RepositoryItemImageComboBox

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvPortalGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogPortalGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvPortalGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogPortalGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvPortalGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogPortalGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, picStatusImageColection As DevExpress.Utils.ImageCollection, picEnvioImageColection As DevExpress.Utils.ImageCollection, picVisualizouImageColection As DevExpress.Utils.ImageCollection) Implements IMonitoramentoLog.Grid

        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdMonitoramento As SelectedData
            Dim dsMonitoramento As New DataSet()

            pgvGrid.OptionsDetail.AllowZoomDetail = True
            pgvGrid.OptionsDetail.AutoZoomDetail = True

            pgvGridEmpresa.OptionsDetail.AllowZoomDetail = True
            pgvGridEmpresa.OptionsDetail.AutoZoomDetail = True

            pgvGridFuncionario.OptionsDetail.AllowZoomDetail = True
            pgvGridFuncionario.OptionsDetail.AutoZoomDetail = True

            pgvGridInforme.OptionsDetail.AllowZoomDetail = True
            pgvGridInforme.OptionsDetail.AutoZoomDetail = True

            pgvPortalGridEmpresa.OptionsDetail.AllowZoomDetail = True
            pgvPortalGridEmpresa.OptionsDetail.AutoZoomDetail = True

            pgvPortalGridFuncionario.OptionsDetail.AllowZoomDetail = True
            pgvPortalGridFuncionario.OptionsDetail.AutoZoomDetail = True

            pgvPortalGridInforme.OptionsDetail.AllowZoomDetail = True
            pgvPortalGridInforme.OptionsDetail.AutoZoomDetail = True

            pgvGridDetalheFuncionario.OptionsDetail.AllowZoomDetail = True
            pgvGridDetalheFuncionario.OptionsDetail.AutoZoomDetail = True

            pgvGridDetalheInforme.OptionsDetail.AllowZoomDetail = True
            pgvGridDetalheInforme.OptionsDetail.AutoZoomDetail = True


            sdMonitoramento = objDataBase.QueryFull(pstrQuery(0).ToString)
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
            Dim dtLogEmpresa As New DataTable("logempresa")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtLogEmpresa.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtLogEmpresa)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drLogEmpresa As DataRow = dsMonitoramento.Tables("logempresa").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drLogEmpresa(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("logempresa").Rows.Add(drLogEmpresa)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(3).ToString)
            Dim dtPortalEmpresa As New DataTable("portalempresa")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtPortalEmpresa.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtPortalEmpresa)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drPortalEmpresa As DataRow = dsMonitoramento.Tables("portalempresa").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drPortalEmpresa(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("portalempresa").Rows.Add(drPortalEmpresa)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(4).ToString)
            Dim dtLogPortalEmpresa As New DataTable("logportalempresa")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtLogPortalEmpresa.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtLogPortalEmpresa)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drLogPortalEmpresa As DataRow = dsMonitoramento.Tables("logportalempresa").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drLogPortalEmpresa(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("logportalempresa").Rows.Add(drLogPortalEmpresa)
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

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(6).ToString)
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

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(7).ToString)
            Dim dtLogFuncionario As New DataTable("logfuncionario")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtLogFuncionario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtLogFuncionario)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drLogFuncionario As DataRow = dsMonitoramento.Tables("logfuncionario").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drLogFuncionario(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("logfuncionario").Rows.Add(drLogFuncionario)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(8).ToString)
            Dim dtPortalFuncionario As New DataTable("portalfuncionario")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtPortalFuncionario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtPortalFuncionario)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drPortalFuncionario As DataRow = dsMonitoramento.Tables("portalfuncionario").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drPortalFuncionario(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("portalfuncionario").Rows.Add(drPortalFuncionario)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(9).ToString)
            Dim dtLogPortalFuncionario As New DataTable("logportalfuncionario")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtLogPortalFuncionario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtLogPortalFuncionario)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drLogPortalFuncionario As DataRow = dsMonitoramento.Tables("logportalfuncionario").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drLogPortalFuncionario(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("logportalfuncionario").Rows.Add(drLogPortalFuncionario)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(10).ToString)
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

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(11).ToString)
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

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(12).ToString)
            Dim dtLogInforme As New DataTable("loginforme")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtLogInforme.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtLogInforme)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drLogInforme As DataRow = dsMonitoramento.Tables("loginforme").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drLogInforme(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("loginforme").Rows.Add(drLogInforme)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(13).ToString)
            Dim dtPortalInforme As New DataTable("portalinforme")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtPortalInforme.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtPortalInforme)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drPortalInforme As DataRow = dsMonitoramento.Tables("portalinforme").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drPortalInforme(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("portalinforme").Rows.Add(drPortalInforme)
            Next

            sdMonitoramento = objDataBase.QueryFull(pstrQuery(14).ToString)
            Dim dtLogPortalInforme As New DataTable("logportalinforme")
            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(0).Rows
                dtLogPortalInforme.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMonitoramento.Tables.Add(dtLogPortalInforme)

            For Each row As SelectStatementResultRow In sdMonitoramento.ResultSet(1).Rows
                Dim drLogPortalInforme As DataRow = dsMonitoramento.Tables("logportalinforme").NewRow()
                For index = 0 To row.Values.Length - 1
                    If Not row.Values(index) Is Nothing Then
                        drLogPortalInforme(index) = row.Values(index)
                    End If
                Next
                dsMonitoramento.Tables("logportalinforme").Rows.Add(drLogPortalInforme)
            Next

            'Campo chave das Informações das Empresas
            Dim keyColumnEmpresa As DataColumn = dsMonitoramento.Tables("monitoramento").Columns("empresa")
            Dim keyColumnCompetencia As DataColumn = dsMonitoramento.Tables("monitoramento").Columns("competencia")

            'Campo chave das Informações das Empresas/Obrigações
            Dim foreignKeyColumnEmpresaEmp As DataColumn = dsMonitoramento.Tables("empresa").Columns("empresa")
            Dim foreignKeyColumnEmpresaCom As DataColumn = dsMonitoramento.Tables("empresa").Columns("competencia")

            'Campo chave das Informações das Empresas/Funcionários
            Dim foreignKeyColumnFuncionarioEmp As DataColumn = dsMonitoramento.Tables("funcionario").Columns("empresa")
            Dim foreignKeyColumnFuncionarioCom As DataColumn = dsMonitoramento.Tables("funcionario").Columns("competencia")

            'Campo chave das Informações das Empresas/Informes
            Dim foreignKeyColumnInformeEmp As DataColumn = dsMonitoramento.Tables("informe").Columns("empresa")
            Dim foreignKeyColumnInformeCom As DataColumn = dsMonitoramento.Tables("informe").Columns("competencia")

            'Vinculo das chaves das Informações Empresas com Empresas/Obrigações
            dsMonitoramento.Relations.Add("monitoramentoObrigacao", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnEmpresaEmp, foreignKeyColumnEmpresaCom})
            'Vinculo das chaves das Informações Empresas com Empresas/Funcionários
            dsMonitoramento.Relations.Add("monitoramentoFuncionario", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnFuncionarioEmp, foreignKeyColumnFuncionarioCom})
            'Vinculo das chaves das Informações Empresas com Empresas/Informe
            dsMonitoramento.Relations.Add("monitoramentoInforme", {keyColumnEmpresa, keyColumnCompetencia}, {foreignKeyColumnInformeEmp, foreignKeyColumnInformeCom})

            'Campo chave das Informações das Empresas/Funcionários/Competencias
            Dim KeyColumnFuncionarioEmp As DataColumn = dsMonitoramento.Tables("funcionario").Columns("empresa")
            Dim keyColumnfuncionarioFun As DataColumn = dsMonitoramento.Tables("funcionario").Columns("funcionario")
            Dim KeyColumnFuncionarioCom As DataColumn = dsMonitoramento.Tables("funcionario").Columns("competencia")

            Dim foreignKeyColumnDetFunEmp As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("empresa")
            Dim foreignKeyColumnDetFunFun As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("funcionario")
            Dim foreignKeyColumnDetFunCom As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("competencia")

            'Vinculo das chaves das Informações Empresas/Funcionários com Empresas/Funcionários/Competencias
            dsMonitoramento.Relations.Add("DetalheFuncionario", {KeyColumnFuncionarioEmp, keyColumnfuncionarioFun, KeyColumnFuncionarioCom},
                                                                {foreignKeyColumnDetFunEmp, foreignKeyColumnDetFunFun, foreignKeyColumnDetFunCom})

            'Campo chave das Informações das Empresas/Informe/Competencias
            Dim keyColumnInformeEmp As DataColumn = dsMonitoramento.Tables("informe").Columns("empresa")
            Dim keyColumnInformeCom As DataColumn = dsMonitoramento.Tables("informe").Columns("competencia")
            Dim keyColumnInformeInf As DataColumn = dsMonitoramento.Tables("informe").Columns("cnpjcpfinforme")
            Dim keyColumnInformeNom As DataColumn = dsMonitoramento.Tables("informe").Columns("nome")

            Dim foreignKeyColumnDetInfEmp As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("empresa")
            Dim foreignKeyColumnDetInfCom As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("competencia")
            Dim foreignKeyColumnDetInfInf As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("cnpjcpfinforme")
            Dim foreignKeyColumnDetInfNom As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("nome")

            'Vinculo das chaves das Informações Empresas/Informe com Empresas/Informe/Competencias
            dsMonitoramento.Relations.Add("DetalheInforme", {keyColumnInformeEmp, keyColumnInformeCom, keyColumnInformeInf, keyColumnInformeNom},
                                                            {foreignKeyColumnDetInfEmp, foreignKeyColumnDetInfCom, foreignKeyColumnDetInfInf, foreignKeyColumnDetInfNom})

            'Campo chave das Informações das Empresas/Obrigações/Log
            Dim KeyColumnEmpresaEmp As DataColumn = dsMonitoramento.Tables("empresa").Columns("empresa")
            Dim KeyColumnEmpresaCom As DataColumn = dsMonitoramento.Tables("empresa").Columns("competencia")
            Dim keyColumnEmpresaObr As DataColumn = dsMonitoramento.Tables("empresa").Columns("obrigacao")
            Dim keyColumnEmpresaPar As DataColumn = dsMonitoramento.Tables("empresa").Columns("parcela")
            Dim keyColumnEmpresaSex As DataColumn = dsMonitoramento.Tables("empresa").Columns("sequenciaextra")
            Dim keyColumnEmpresaOex As DataColumn = dsMonitoramento.Tables("empresa").Columns("obrigacaoextra")

            Dim foreignKeyColumnLogEmpEmp As DataColumn = dsMonitoramento.Tables("logempresa").Columns("empresa")
            Dim foreignKeyColumnLogEmpCom As DataColumn = dsMonitoramento.Tables("logempresa").Columns("competencia")
            Dim foreignKeyColumnLogEmpObr As DataColumn = dsMonitoramento.Tables("logempresa").Columns("obrigacao")
            Dim foreignKeyColumnLogEmpPar As DataColumn = dsMonitoramento.Tables("logempresa").Columns("parcela")
            Dim foreignKeyColumnLogEmpSex As DataColumn = dsMonitoramento.Tables("logempresa").Columns("sequenciaextra")
            Dim foreignKeyColumnLogEmpOex As DataColumn = dsMonitoramento.Tables("logempresa").Columns("obrigacaoextra")

            'Vinculo das chaves das Informações Empresas/Obrigações com Empresas/Obrigações/Log
            dsMonitoramento.Relations.Add("LogEmpresa", {KeyColumnEmpresaEmp, KeyColumnEmpresaCom, keyColumnEmpresaObr,
                                                         keyColumnEmpresaPar, keyColumnEmpresaSex, keyColumnEmpresaOex},
                                                        {foreignKeyColumnLogEmpEmp, foreignKeyColumnLogEmpCom, foreignKeyColumnLogEmpObr,
                                                         foreignKeyColumnLogEmpPar, foreignKeyColumnLogEmpSex, foreignKeyColumnLogEmpOex})

            'Campo chave das Informações das Empresas/Obrigações/Portal
            Dim foreignKeyColumnPorEmpEmp As DataColumn = dsMonitoramento.Tables("portalempresa").Columns("empresa")
            Dim foreignKeyColumnPorEmpCom As DataColumn = dsMonitoramento.Tables("portalempresa").Columns("competencia")
            Dim foreignKeyColumnPorEmpObr As DataColumn = dsMonitoramento.Tables("portalempresa").Columns("obrigacao")
            Dim foreignKeyColumnPorEmpPar As DataColumn = dsMonitoramento.Tables("portalempresa").Columns("parcela")
            Dim foreignKeyColumnPorEmpSex As DataColumn = dsMonitoramento.Tables("portalempresa").Columns("sequenciaextra")
            Dim foreignKeyColumnPorEmpOex As DataColumn = dsMonitoramento.Tables("portalempresa").Columns("obrigacaoextra")

            'Vinculo das chaves das Informações Empresas/Obrigações com Empresas/Obrigações/Portal
            dsMonitoramento.Relations.Add("PortalEmpresa", {KeyColumnEmpresaEmp, KeyColumnEmpresaCom, keyColumnEmpresaObr,
                                                            keyColumnEmpresaPar, keyColumnEmpresaSex, keyColumnEmpresaOex},
                                                           {foreignKeyColumnPorEmpEmp, foreignKeyColumnPorEmpCom, foreignKeyColumnPorEmpObr,
                                                            foreignKeyColumnPorEmpPar, foreignKeyColumnPorEmpSex, foreignKeyColumnPorEmpOex})

            'Campo chave das Informações das Empresas/Obrigações/Portal/Log
            Dim foreignKeyColumnLogPorEmpEmp As DataColumn = dsMonitoramento.Tables("logportalempresa").Columns("empresa")
            Dim foreignKeyColumnLogPorEmpCom As DataColumn = dsMonitoramento.Tables("logportalempresa").Columns("competencia")
            Dim foreignKeyColumnLogPorEmpObr As DataColumn = dsMonitoramento.Tables("logportalempresa").Columns("obrigacao")
            Dim foreignKeyColumnLogPorEmpPar As DataColumn = dsMonitoramento.Tables("logportalempresa").Columns("parcela")
            Dim foreignKeyColumnLogPorEmpSex As DataColumn = dsMonitoramento.Tables("logportalempresa").Columns("sequenciaextra")
            Dim foreignKeyColumnLogPorEmpOex As DataColumn = dsMonitoramento.Tables("logportalempresa").Columns("obrigacaoextra")

            'Vinculo das chaves das Informações Empresas/Obrigações/Portal com Empresas/Obrigações/Portal/Log
            dsMonitoramento.Relations.Add("LogPortalEmpresa", {foreignKeyColumnPorEmpEmp, foreignKeyColumnPorEmpCom, foreignKeyColumnPorEmpObr,
                                                               foreignKeyColumnPorEmpPar, foreignKeyColumnPorEmpSex, foreignKeyColumnPorEmpOex},
                                                              {foreignKeyColumnLogPorEmpEmp, foreignKeyColumnLogPorEmpCom, foreignKeyColumnLogPorEmpObr,
                                                               foreignKeyColumnLogPorEmpPar, foreignKeyColumnLogPorEmpSex, foreignKeyColumnLogPorEmpOex})

            'Campo chave das Informações das Empresas/Obrigações/Funcionários/Log
            Dim KeyColumnDetFuncionarioEmp As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("empresa")
            Dim KeyColumnDetFuncionarioCom As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("competencia")
            Dim KeyColumnDetFuncionarioObr As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("obrigacao")
            Dim KeyColumnDetFuncionarioFun As DataColumn = dsMonitoramento.Tables("detalhefuncionario").Columns("funcionario")

            Dim foreignKeyColumnLogFunEmp As DataColumn = dsMonitoramento.Tables("logfuncionario").Columns("empresa")
            Dim foreignKeyColumnLogFunCom As DataColumn = dsMonitoramento.Tables("logfuncionario").Columns("competencia")
            Dim foreignKeyColumnLogFunObr As DataColumn = dsMonitoramento.Tables("logfuncionario").Columns("obrigacao")
            Dim foreignKeyColumnLogFunFun As DataColumn = dsMonitoramento.Tables("logfuncionario").Columns("funcionario")

            'Vinculo das chaves das Informações Empresas/Obrigações com Empresas/Obrigações/Log
            dsMonitoramento.Relations.Add("LogFuncionario", {KeyColumnDetFuncionarioEmp, KeyColumnDetFuncionarioCom, KeyColumnDetFuncionarioObr,
                                                             KeyColumnDetFuncionarioFun},
                                                            {foreignKeyColumnLogFunEmp, foreignKeyColumnLogFunCom, foreignKeyColumnLogFunObr,
                                                             foreignKeyColumnLogFunFun})

            'Campo chave das Informações das Empresas/Obrigações/Funcionários/Portal
            Dim foreignKeyColumnPorFunEmp As DataColumn = dsMonitoramento.Tables("portalfuncionario").Columns("empresa")
            Dim foreignKeyColumnPorFunCom As DataColumn = dsMonitoramento.Tables("portalfuncionario").Columns("competencia")
            Dim foreignKeyColumnPorFunObr As DataColumn = dsMonitoramento.Tables("portalfuncionario").Columns("obrigacao")
            Dim foreignKeyColumnPorFunFun As DataColumn = dsMonitoramento.Tables("portalfuncionario").Columns("funcionario")

            'Vinculo das chaves das Informações Empresas/Obrigações com Empresas/Obrigações/Funcionários/Portal
            dsMonitoramento.Relations.Add("PortalFuncionario", {KeyColumnDetFuncionarioEmp, KeyColumnDetFuncionarioCom, KeyColumnDetFuncionarioObr,
                                                                KeyColumnDetFuncionarioFun},
                                                               {foreignKeyColumnPorFunEmp, foreignKeyColumnPorFunCom, foreignKeyColumnPorFunObr,
                                                                foreignKeyColumnPorFunFun})

            'Campo chave das Informações das Empresas/Obrigações/Funcionários/Portal/Log
            Dim foreignKeyColumnLogPorFunEmp As DataColumn = dsMonitoramento.Tables("logportalfuncionario").Columns("empresa")
            Dim foreignKeyColumnLogPorFunCom As DataColumn = dsMonitoramento.Tables("logportalfuncionario").Columns("competencia")
            Dim foreignKeyColumnLogPorFunObr As DataColumn = dsMonitoramento.Tables("logportalfuncionario").Columns("obrigacao")
            Dim foreignKeyColumnLogPorFunFun As DataColumn = dsMonitoramento.Tables("logportalfuncionario").Columns("funcionario")

            'Vinculo das chaves das Informações Empresas/Obrigações/Portal com Empresas/Obrigações/Funcionários/Portal/Log
            dsMonitoramento.Relations.Add("LogPortalFuncionario", {foreignKeyColumnPorFunEmp, foreignKeyColumnPorFunCom, foreignKeyColumnPorFunObr, foreignKeyColumnPorFunFun},
                                                                  {foreignKeyColumnLogPorFunEmp, foreignKeyColumnLogPorFunCom, foreignKeyColumnLogPorFunObr, foreignKeyColumnLogPorFunFun})

            'Campo chave das Informações das Empresas/Obrigações/Informe/Log
            Dim KeyColumnDetInformeEmp As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("empresa")
            Dim KeyColumnDetInformeCom As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("competencia")
            Dim KeyColumnDetInformeObr As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("obrigacao")
            Dim KeyColumnDetInformePar As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("parcela")
            Dim KeyColumnDetInformeSex As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("sequenciaextra")
            Dim KeyColumnDetInformeOex As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("obrigacaoextra")
            Dim KeyColumnDetInformeTpi As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("tipopessoainforme")
            Dim KeyColumnDetInformeInf As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("informe")
            Dim KeyColumnDetInformeCci As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("cnpjcpfinforme")
            Dim KeyColumnDetInformeNom As DataColumn = dsMonitoramento.Tables("detalheinforme").Columns("nome")

            Dim foreignKeyColumnLogInfEmp As DataColumn = dsMonitoramento.Tables("loginforme").Columns("empresa")
            Dim foreignKeyColumnLogInfCom As DataColumn = dsMonitoramento.Tables("loginforme").Columns("competencia")
            Dim foreignKeyColumnLogInfObr As DataColumn = dsMonitoramento.Tables("loginforme").Columns("obrigacao")
            Dim foreignKeyColumnLogInfPar As DataColumn = dsMonitoramento.Tables("loginforme").Columns("parcela")
            Dim foreignKeyColumnLogInfSex As DataColumn = dsMonitoramento.Tables("loginforme").Columns("sequenciaextra")
            Dim foreignKeyColumnLogInfOex As DataColumn = dsMonitoramento.Tables("loginforme").Columns("obrigacaoextra")
            Dim foreignKeyColumnLogInfTpi As DataColumn = dsMonitoramento.Tables("loginforme").Columns("tipopessoainforme")
            Dim foreignKeyColumnLogInfInf As DataColumn = dsMonitoramento.Tables("loginforme").Columns("informe")
            Dim foreignKeyColumnLogInfCci As DataColumn = dsMonitoramento.Tables("loginforme").Columns("cnpjcpfinforme")
            Dim foreignKeyColumnLogInfNom As DataColumn = dsMonitoramento.Tables("loginforme").Columns("nome")

            'Vinculo das chaves das Informações Empresas/Obrigações com Empresas/Obrigações/Log
            dsMonitoramento.Relations.Add("LogInforme", {KeyColumnDetInformeEmp, KeyColumnDetInformeCom, KeyColumnDetInformeObr,
                                                         KeyColumnDetInformePar, KeyColumnDetInformeSex, KeyColumnDetInformeOex,
                                                         KeyColumnDetInformeTpi, KeyColumnDetInformeInf, KeyColumnDetInformeCci,
                                                         KeyColumnDetInformeNom},
                                                        {foreignKeyColumnLogInfEmp, foreignKeyColumnLogInfCom, foreignKeyColumnLogInfObr,
                                                         foreignKeyColumnLogInfPar, foreignKeyColumnLogInfSex, foreignKeyColumnLogInfOex,
                                                         foreignKeyColumnLogInfTpi, foreignKeyColumnLogInfInf, foreignKeyColumnLogInfCci,
                                                         foreignKeyColumnLogInfNom})

            'Campo chave das Informações das Empresas/Obrigações/Informe/Portal
            Dim foreignKeyColumnPorInfEmp As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("empresa")
            Dim foreignKeyColumnPorInfCom As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("competencia")
            Dim foreignKeyColumnPorInfObr As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("obrigacao")
            Dim foreignKeyColumnPorInfPar As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("parcela")
            Dim foreignKeyColumnPorInfSex As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("sequenciaextra")
            Dim foreignKeyColumnPorInfOex As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("obrigacaoextra")
            Dim foreignKeyColumnPorInfTpi As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("tipopessoainforme")
            Dim foreignKeyColumnPorInfInf As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("informe")
            Dim foreignKeyColumnPorInfCci As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("cnpjcpfinforme")
            Dim foreignKeyColumnPorInfNom As DataColumn = dsMonitoramento.Tables("portalinforme").Columns("nome")

            'Vinculo das chaves das Informações Empresas/Obrigações com Empresas/Obrigações/Informe/Portal
            dsMonitoramento.Relations.Add("PortalInforme", {KeyColumnDetInformeEmp, KeyColumnDetInformeCom, KeyColumnDetInformeObr,
                                                            KeyColumnDetInformePar, KeyColumnDetInformeSex, KeyColumnDetInformeOex,
                                                            KeyColumnDetInformeTpi, KeyColumnDetInformeInf, KeyColumnDetInformeCci,
                                                            KeyColumnDetInformeNom},
                                                           {foreignKeyColumnPorInfEmp, foreignKeyColumnPorInfCom, foreignKeyColumnPorInfObr,
                                                            foreignKeyColumnPorInfPar, foreignKeyColumnPorInfSex, foreignKeyColumnPorInfOex,
                                                            foreignKeyColumnPorInfTpi, foreignKeyColumnPorInfInf, foreignKeyColumnPorInfCci,
                                                            foreignKeyColumnPorInfNom})

            'Campo chave das Informações das Empresas/Obrigações/Informe/Portal/Log
            Dim foreignKeyColumnLogPorInfEmp As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("empresa")
            Dim foreignKeyColumnLogPorInfCom As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("competencia")
            Dim foreignKeyColumnLogPorInfObr As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("obrigacao")
            Dim foreignKeyColumnLogPorInfPar As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("parcela")
            Dim foreignKeyColumnLogPorInfSex As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("sequenciaextra")
            Dim foreignKeyColumnLogPorInfOex As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("obrigacaoextra")
            Dim foreignKeyColumnLogPorInfTpi As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("tipopessoainforme")
            Dim foreignKeyColumnLogPorInfInf As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("informe")
            Dim foreignKeyColumnLogPorInfCci As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("cnpjcpfinforme")
            Dim foreignKeyColumnLogPorInfNom As DataColumn = dsMonitoramento.Tables("logportalinforme").Columns("nome")

            'Vinculo das chaves das Informações Empresas/Obrigações/Portaç com Empresas/Obrigações/Informe/Portal/Log
            dsMonitoramento.Relations.Add("LogPortalInforme", {foreignKeyColumnPorInfEmp, foreignKeyColumnPorInfCom, foreignKeyColumnPorInfObr,
                                                              foreignKeyColumnPorInfPar, foreignKeyColumnPorInfSex, foreignKeyColumnPorInfOex,
                                                              foreignKeyColumnPorInfTpi, foreignKeyColumnPorInfInf, foreignKeyColumnPorInfCci,
                                                              foreignKeyColumnPorInfNom},
                                                           {foreignKeyColumnLogPorInfEmp, foreignKeyColumnLogPorInfCom, foreignKeyColumnLogPorInfObr,
                                                            foreignKeyColumnLogPorInfPar, foreignKeyColumnLogPorInfSex, foreignKeyColumnLogPorInfOex,
                                                            foreignKeyColumnLogPorInfTpi, foreignKeyColumnLogPorInfInf, foreignKeyColumnLogPorInfCci,
                                                            foreignKeyColumnLogPorInfNom})

            '******************************************************************************************************************************************************
            ' DADOS DAS EMPRESAS (Nivel 1)
            '******************************************************************************************************************************************************
            pdgGrid.DataSource = dsMonitoramento.Tables("monitoramento")
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
            pgvGrid.Columns(3).Width = 85

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGrid.Columns(4).ColumnEdit = image
            pgvGrid.Columns(4).Caption = "Status"
            pgvGrid.Columns(4).Width = 120

            '******************************************************************************************************************************************************
            ' OBRIGAÇÕES DAS EMPRESAS (Nivel 1.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(0).RelationName = "monitoramentoObrigacao"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridEmpresa
            pgvGridEmpresa.ViewCaption = "Detalhes"
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
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvGridEmpresa.Columns(10).ColumnEdit = image
            pgvGridEmpresa.Columns(10).Caption = "Status"
            pgvGridEmpresa.Columns(10).Width = 120

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.1.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(0).Nodes(0).RelationName = "LogEmpresa"
            pdgGrid.LevelTree.Nodes(0).Nodes(0).LevelTemplate = pgvLogGridEmpresa
            pgvLogGridEmpresa.ViewCaption = "LOG"
            pgvLogGridEmpresa.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvLogGridEmpresa.PopulateColumns(dsMonitoramento.Tables("logempresa"))
            pgvLogGridEmpresa.OptionsView.ShowGroupPanel = False
            pgvLogGridEmpresa.OptionsBehavior.Editable = False
            pgvLogGridEmpresa.OptionsCustomization.AllowQuickHideColumns = False
            pgvLogGridEmpresa.OptionsCustomization.AllowColumnResizing = False
            pgvLogGridEmpresa.OptionsCustomization.AllowColumnMoving = False
            pgvLogGridEmpresa.OptionsCustomization.AllowGroup = False
            pgvLogGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvLogGridEmpresa.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvLogGridEmpresa.ColumnPanelRowHeight = 60
            pgvLogGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvLogGridEmpresa.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvLogGridEmpresa.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvLogGridEmpresa.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvLogGridEmpresa.Columns(0).Visible = False
            pgvLogGridEmpresa.Columns(1).Visible = False
            pgvLogGridEmpresa.Columns(13).Visible = False
            pgvLogGridEmpresa.Columns(14).Visible = False
            pgvLogGridEmpresa.Columns(15).Visible = False
            pgvLogGridEmpresa.Columns(16).Visible = False

            pgvLogGridEmpresa.Columns(2).Caption = "Sequência"
            pgvLogGridEmpresa.Columns(2).Width = 75

            pgvLogGridEmpresa.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvLogGridEmpresa.Columns(3).Width = 75

            pgvLogGridEmpresa.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvLogGridEmpresa.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridEmpresa.Columns(5).ColumnEdit = edit
            pgvLogGridEmpresa.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvLogGridEmpresa.Columns(5).Width = 115

            pgvLogGridEmpresa.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvLogGridEmpresa.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridEmpresa.Columns(7).ColumnEdit = edit
            pgvLogGridEmpresa.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvLogGridEmpresa.Columns(7).Width = 115

            pgvLogGridEmpresa.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvLogGridEmpresa.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridEmpresa.Columns(9).ColumnEdit = edit
            pgvLogGridEmpresa.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvLogGridEmpresa.Columns(9).Width = 115

            pgvLogGridEmpresa.Columns(10).Caption = "Usuário" + Environment.NewLine + "LOG"
            pgvLogGridEmpresa.Columns(10).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridEmpresa.Columns(11).ColumnEdit = edit
            pgvLogGridEmpresa.Columns(11).Caption = "Data/Hora" + Environment.NewLine + "LOG"
            pgvLogGridEmpresa.Columns(11).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvLogGridEmpresa.Columns(12).ColumnEdit = image
            pgvLogGridEmpresa.Columns(12).Caption = "Status"
            pgvLogGridEmpresa.Columns(12).Width = 120

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.1.2)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(0).Nodes(1).RelationName = "PortalEmpresa"
            pdgGrid.LevelTree.Nodes(0).Nodes(1).LevelTemplate = pgvPortalGridEmpresa
            pgvPortalGridEmpresa.ViewCaption = "PORTAL"
            pgvPortalGridEmpresa.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvPortalGridEmpresa.PopulateColumns(dsMonitoramento.Tables("portalempresa"))
            pgvPortalGridEmpresa.OptionsView.ShowGroupPanel = False
            pgvPortalGridEmpresa.OptionsCustomization.AllowQuickHideColumns = False
            pgvPortalGridEmpresa.OptionsCustomization.AllowColumnResizing = False
            pgvPortalGridEmpresa.OptionsCustomization.AllowColumnMoving = False
            pgvPortalGridEmpresa.OptionsCustomization.AllowGroup = False
            pgvPortalGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvPortalGridEmpresa.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvPortalGridEmpresa.ColumnPanelRowHeight = 60
            pgvPortalGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvPortalGridEmpresa.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvPortalGridEmpresa.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvPortalGridEmpresa.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap
            pgvPortalGridEmpresa.OptionsView.RowAutoHeight = True
            pgvPortalGridEmpresa.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways

            pgvPortalGridEmpresa.Columns(0).Visible = False
            pgvPortalGridEmpresa.Columns(1).Visible = False
            pgvPortalGridEmpresa.Columns(10).Visible = False
            pgvPortalGridEmpresa.Columns(11).Visible = False
            pgvPortalGridEmpresa.Columns(12).Visible = False
            pgvPortalGridEmpresa.Columns(13).Visible = False

            ' Definição de Mascarás no Grid
            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Enviado", -1, 1))
            pgvPortalGridEmpresa.Columns(2).ColumnEdit = image
            pgvPortalGridEmpresa.Columns(2).Caption = "Status Envio"
            pgvPortalGridEmpresa.Columns(2).Width = 100
            pgvPortalGridEmpresa.Columns(2).OptionsColumn.AllowEdit = False

            memo = New RepositoryItemMemoExEdit()
            memo.ReadOnly = True
            memo.AutoHeight = True
            memo.PopupSizeable = False
            memo.PopupBorderStyle = PopupBorderStyles.Style3D
            pgvPortalGridEmpresa.Columns(3).ColumnEdit = memo
            pgvPortalGridEmpresa.Columns(3).Caption = "Mensagem"
            pgvPortalGridEmpresa.Columns(3).Width = 210
            pgvPortalGridEmpresa.Columns(3).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap

            pgvPortalGridEmpresa.Columns(4).Caption = "Usuário" + Environment.NewLine + "Envio"
            pgvPortalGridEmpresa.Columns(4).Width = 70
            pgvPortalGridEmpresa.Columns(4).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridEmpresa.Columns(5).ColumnEdit = edit
            pgvPortalGridEmpresa.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Envio Inicio"
            pgvPortalGridEmpresa.Columns(5).Width = 115
            pgvPortalGridEmpresa.Columns(5).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridEmpresa.Columns(6).ColumnEdit = edit
            pgvPortalGridEmpresa.Columns(6).Caption = "Data/Hora" + Environment.NewLine + "Envio Fim"
            pgvPortalGridEmpresa.Columns(6).Width = 115
            pgvPortalGridEmpresa.Columns(6).OptionsColumn.AllowEdit = False

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizouImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", -1, 1))
            pgvPortalGridEmpresa.Columns(7).ColumnEdit = image
            pgvPortalGridEmpresa.Columns(7).Caption = "Status Visualização"
            pgvPortalGridEmpresa.Columns(7).Width = 100
            pgvPortalGridEmpresa.Columns(7).OptionsColumn.AllowEdit = False

            pgvPortalGridEmpresa.Columns(8).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvPortalGridEmpresa.Columns(8).Width = 200
            pgvPortalGridEmpresa.Columns(8).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridEmpresa.Columns(9).ColumnEdit = edit
            pgvPortalGridEmpresa.Columns(9).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvPortalGridEmpresa.Columns(9).Width = 115
            pgvPortalGridEmpresa.Columns(9).OptionsColumn.AllowEdit = False

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.1.2.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(0).Nodes(1).Nodes(0).RelationName = "LogPortalEmpresa"
            pdgGrid.LevelTree.Nodes(0).Nodes(1).Nodes(0).LevelTemplate = pgvLogPortalGridEmpresa

            pgvLogPortalGridEmpresa.ViewCaption = "LOG"
            pgvLogPortalGridEmpresa.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvLogPortalGridEmpresa.PopulateColumns(dsMonitoramento.Tables("logportalempresa"))
            pgvLogPortalGridEmpresa.OptionsView.ShowGroupPanel = False
            pgvLogPortalGridEmpresa.OptionsCustomization.AllowQuickHideColumns = False
            pgvLogPortalGridEmpresa.OptionsCustomization.AllowColumnResizing = False
            pgvLogPortalGridEmpresa.OptionsCustomization.AllowColumnMoving = False
            pgvLogPortalGridEmpresa.OptionsCustomization.AllowGroup = False
            pgvLogPortalGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvLogPortalGridEmpresa.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvLogPortalGridEmpresa.ColumnPanelRowHeight = 60
            pgvLogPortalGridEmpresa.OptionsView.ColumnAutoWidth = False
            pgvLogPortalGridEmpresa.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvLogPortalGridEmpresa.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvLogPortalGridEmpresa.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap
            pgvLogPortalGridEmpresa.OptionsView.RowAutoHeight = False
            pgvLogPortalGridEmpresa.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways

            pgvLogPortalGridEmpresa.Columns(0).Visible = False
            pgvLogPortalGridEmpresa.Columns(1).Visible = False
            pgvLogPortalGridEmpresa.Columns(13).Visible = False
            pgvLogPortalGridEmpresa.Columns(14).Visible = False
            pgvLogPortalGridEmpresa.Columns(15).Visible = False
            pgvLogPortalGridEmpresa.Columns(16).Visible = False

            pgvLogPortalGridEmpresa.Columns(2).Caption = "Sequência"
            pgvLogPortalGridEmpresa.Columns(2).Width = 75

            ' Definição de Mascarás no Grid
            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Enviado", -1, 1))
            pgvLogPortalGridEmpresa.Columns(3).ColumnEdit = image
            pgvLogPortalGridEmpresa.Columns(3).Caption = "Status Envio"
            pgvLogPortalGridEmpresa.Columns(3).Width = 100
            pgvLogPortalGridEmpresa.Columns(3).OptionsColumn.AllowEdit = False

            memo = New RepositoryItemMemoExEdit()
            memo.ReadOnly = True
            memo.AutoHeight = True
            memo.PopupSizeable = False
            memo.PopupBorderStyle = PopupBorderStyles.Style3D
            pgvLogPortalGridEmpresa.Columns(4).ColumnEdit = memo
            pgvLogPortalGridEmpresa.Columns(4).Caption = "Mensagem"
            pgvLogPortalGridEmpresa.Columns(4).Width = 210
            pgvLogPortalGridEmpresa.Columns(4).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap

            pgvLogPortalGridEmpresa.Columns(5).Caption = "Usuário" + Environment.NewLine + "Envio"
            pgvLogPortalGridEmpresa.Columns(5).Width = 70
            pgvLogPortalGridEmpresa.Columns(5).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridEmpresa.Columns(6).ColumnEdit = edit
            pgvLogPortalGridEmpresa.Columns(6).Caption = "Data/Hora" + Environment.NewLine + "Envio Inicio"
            pgvLogPortalGridEmpresa.Columns(6).Width = 115
            pgvLogPortalGridEmpresa.Columns(6).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridEmpresa.Columns(7).ColumnEdit = edit
            pgvLogPortalGridEmpresa.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Envio Fim"
            pgvLogPortalGridEmpresa.Columns(7).Width = 115
            pgvLogPortalGridEmpresa.Columns(7).OptionsColumn.AllowEdit = False

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizouImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", -1, 1))
            pgvLogPortalGridEmpresa.Columns(8).ColumnEdit = image
            pgvLogPortalGridEmpresa.Columns(8).Caption = "Status Visualização"
            pgvLogPortalGridEmpresa.Columns(8).Width = 100
            pgvLogPortalGridEmpresa.Columns(8).OptionsColumn.AllowEdit = False

            pgvLogPortalGridEmpresa.Columns(9).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvLogPortalGridEmpresa.Columns(9).Width = 200
            pgvLogPortalGridEmpresa.Columns(9).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridEmpresa.Columns(10).ColumnEdit = edit
            pgvLogPortalGridEmpresa.Columns(10).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvLogPortalGridEmpresa.Columns(10).Width = 115
            pgvLogPortalGridEmpresa.Columns(10).OptionsColumn.AllowEdit = False

            pgvLogPortalGridEmpresa.Columns(11).Caption = "Usuário" + Environment.NewLine + "LOG"
            pgvLogPortalGridEmpresa.Columns(11).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridEmpresa.Columns(12).ColumnEdit = edit
            pgvLogPortalGridEmpresa.Columns(12).Caption = "Data/Hora" + Environment.NewLine + "LOG"
            pgvLogPortalGridEmpresa.Columns(12).Width = 115

            '******************************************************************************************************************************************************
            ' DADOS DAS EMPRESAS POR FUNCIONÁRIOS (Nivel 1.2)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(1).RelationName = "monitoramentoFuncionario"
            pdgGrid.LevelTree.Nodes(1).LevelTemplate = pgvGridFuncionario
            pgvGridFuncionario.ViewCaption = "Funcionários"
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

            '******************************************************************************************************************************************************
            ' DADOS DAS OBRIGAÇÕES DAS EMPRESAS POR FUNCIONÁRIOS (Nivel 1.2.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(1).Nodes(0).RelationName = "DetalheFuncionario"
            pdgGrid.LevelTree.Nodes(1).Nodes(0).LevelTemplate = pgvGridDetalheFuncionario
            pgvGridDetalheFuncionario.ViewCaption = "Detalhes"
            pgvGridDetalheFuncionario.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
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
            pgvGridDetalheFuncionario.Columns(11).Visible = False
            pgvGridDetalheFuncionario.Columns(12).Visible = False

            ' Definição de Mascarás no Grid
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

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.2.1.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(1).Nodes(0).Nodes(0).RelationName = "LogFuncionario"
            pdgGrid.LevelTree.Nodes(1).Nodes(0).Nodes(0).LevelTemplate = pgvLogGridFuncionario
            pgvLogGridFuncionario.ViewCaption = "LOG"
            pgvLogGridFuncionario.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvLogGridFuncionario.PopulateColumns(dsMonitoramento.Tables("logfuncionario"))
            pgvLogGridFuncionario.OptionsView.ShowGroupPanel = False
            pgvLogGridFuncionario.OptionsBehavior.Editable = False
            pgvLogGridFuncionario.OptionsCustomization.AllowQuickHideColumns = False
            pgvLogGridFuncionario.OptionsCustomization.AllowColumnResizing = False
            pgvLogGridFuncionario.OptionsCustomization.AllowColumnMoving = False
            pgvLogGridFuncionario.OptionsCustomization.AllowGroup = False
            pgvLogGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvLogGridFuncionario.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvLogGridFuncionario.ColumnPanelRowHeight = 60
            pgvLogGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvLogGridFuncionario.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvLogGridFuncionario.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvLogGridFuncionario.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvLogGridFuncionario.Columns(0).Visible = False
            pgvLogGridFuncionario.Columns(1).Visible = False
            pgvLogGridFuncionario.Columns(13).Visible = False
            pgvLogGridFuncionario.Columns(14).Visible = False

            pgvLogGridFuncionario.Columns(2).Caption = "Sequência"
            pgvLogGridFuncionario.Columns(2).Width = 75

            pgvLogGridFuncionario.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvLogGridFuncionario.Columns(3).Width = 75

            pgvLogGridFuncionario.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvLogGridFuncionario.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridFuncionario.Columns(5).ColumnEdit = edit
            pgvLogGridFuncionario.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvLogGridFuncionario.Columns(5).Width = 115

            pgvLogGridFuncionario.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvLogGridFuncionario.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridFuncionario.Columns(7).ColumnEdit = edit
            pgvLogGridFuncionario.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvLogGridFuncionario.Columns(7).Width = 115

            pgvLogGridFuncionario.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvLogGridFuncionario.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridFuncionario.Columns(9).ColumnEdit = edit
            pgvLogGridFuncionario.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvLogGridFuncionario.Columns(9).Width = 115

            pgvLogGridFuncionario.Columns(10).Caption = "Usuário" + Environment.NewLine + "LOG"
            pgvLogGridFuncionario.Columns(10).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridFuncionario.Columns(11).ColumnEdit = edit
            pgvLogGridFuncionario.Columns(11).Caption = "Data/Hora" + Environment.NewLine + "LOG"
            pgvLogGridFuncionario.Columns(11).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvLogGridFuncionario.Columns(12).ColumnEdit = image
            pgvLogGridFuncionario.Columns(12).Caption = "Status"
            pgvLogGridFuncionario.Columns(12).Width = 120

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.2.1.2)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(1).Nodes(0).Nodes(1).RelationName = "PortalFuncionario"
            pdgGrid.LevelTree.Nodes(1).Nodes(0).Nodes(1).LevelTemplate = pgvPortalGridFuncionario
            pgvPortalGridFuncionario.ViewCaption = "PORTAL"
            pgvPortalGridFuncionario.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvPortalGridFuncionario.PopulateColumns(dsMonitoramento.Tables("portalfuncionario"))
            pgvPortalGridFuncionario.OptionsView.ShowGroupPanel = False
            pgvPortalGridFuncionario.OptionsCustomization.AllowQuickHideColumns = False
            pgvPortalGridFuncionario.OptionsCustomization.AllowColumnResizing = False
            pgvPortalGridFuncionario.OptionsCustomization.AllowColumnMoving = False
            pgvPortalGridFuncionario.OptionsCustomization.AllowGroup = False
            pgvPortalGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvPortalGridFuncionario.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvPortalGridFuncionario.ColumnPanelRowHeight = 60
            pgvPortalGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvPortalGridFuncionario.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvPortalGridFuncionario.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvPortalGridFuncionario.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap
            pgvPortalGridFuncionario.OptionsView.RowAutoHeight = True
            pgvPortalGridFuncionario.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways

            pgvPortalGridFuncionario.Columns(0).Visible = False
            pgvPortalGridFuncionario.Columns(1).Visible = False
            pgvPortalGridFuncionario.Columns(10).Visible = False
            pgvPortalGridFuncionario.Columns(11).Visible = False

            ' Definição de Mascarás no Grid
            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Enviado", -1, 1))
            pgvPortalGridFuncionario.Columns(2).ColumnEdit = image
            pgvPortalGridFuncionario.Columns(2).Caption = "Status Envio"
            pgvPortalGridFuncionario.Columns(2).Width = 100
            pgvPortalGridFuncionario.Columns(2).OptionsColumn.AllowEdit = False

            memo = New RepositoryItemMemoExEdit()
            memo.ReadOnly = True
            memo.AutoHeight = True
            memo.PopupSizeable = False
            memo.PopupBorderStyle = PopupBorderStyles.Style3D
            pgvPortalGridFuncionario.Columns(3).ColumnEdit = memo
            pgvPortalGridFuncionario.Columns(3).Caption = "Mensagem"
            pgvPortalGridFuncionario.Columns(3).Width = 210
            pgvPortalGridFuncionario.Columns(3).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap

            pgvPortalGridFuncionario.Columns(4).Caption = "Usuário" + Environment.NewLine + "Envio"
            pgvPortalGridFuncionario.Columns(4).Width = 70
            pgvPortalGridFuncionario.Columns(4).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridFuncionario.Columns(5).ColumnEdit = edit
            pgvPortalGridFuncionario.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Envio Inicio"
            pgvPortalGridFuncionario.Columns(5).Width = 115
            pgvPortalGridFuncionario.Columns(5).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridFuncionario.Columns(6).ColumnEdit = edit
            pgvPortalGridFuncionario.Columns(6).Caption = "Data/Hora" + Environment.NewLine + "Envio Fim"
            pgvPortalGridFuncionario.Columns(6).Width = 115
            pgvPortalGridFuncionario.Columns(6).OptionsColumn.AllowEdit = False

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizouImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", -1, 1))
            pgvPortalGridFuncionario.Columns(7).ColumnEdit = image
            pgvPortalGridFuncionario.Columns(7).Caption = "Status Visualização"
            pgvPortalGridFuncionario.Columns(7).Width = 100
            pgvPortalGridFuncionario.Columns(7).OptionsColumn.AllowEdit = False

            pgvPortalGridFuncionario.Columns(8).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvPortalGridFuncionario.Columns(8).Width = 200
            pgvPortalGridFuncionario.Columns(8).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridFuncionario.Columns(9).ColumnEdit = edit
            pgvPortalGridFuncionario.Columns(9).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvPortalGridFuncionario.Columns(9).Width = 115
            pgvPortalGridFuncionario.Columns(9).OptionsColumn.AllowEdit = False

            ''******************************************************************************************************************************************************
            '' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.2.1.2.1)
            ''******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(1).Nodes(0).Nodes(1).Nodes(0).RelationName = "LogPortalFuncionario"
            pdgGrid.LevelTree.Nodes(1).Nodes(0).Nodes(1).Nodes(0).LevelTemplate = pgvLogPortalGridFuncionario
            pgvLogPortalGridFuncionario.ViewCaption = "LOG"
            pgvLogPortalGridFuncionario.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvLogPortalGridFuncionario.PopulateColumns(dsMonitoramento.Tables("logportalfuncionario"))
            pgvLogPortalGridFuncionario.OptionsView.ShowGroupPanel = False
            pgvLogPortalGridFuncionario.OptionsCustomization.AllowQuickHideColumns = False
            pgvLogPortalGridFuncionario.OptionsCustomization.AllowColumnResizing = False
            pgvLogPortalGridFuncionario.OptionsCustomization.AllowColumnMoving = False
            pgvLogPortalGridFuncionario.OptionsCustomization.AllowGroup = False
            pgvLogPortalGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvLogPortalGridFuncionario.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvLogPortalGridFuncionario.ColumnPanelRowHeight = 60
            pgvLogPortalGridFuncionario.OptionsView.ColumnAutoWidth = False
            pgvLogPortalGridFuncionario.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvLogPortalGridFuncionario.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvLogPortalGridFuncionario.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap
            pgvLogPortalGridFuncionario.OptionsView.RowAutoHeight = False
            pgvLogPortalGridFuncionario.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways

            pgvLogPortalGridFuncionario.Columns(0).Visible = False
            pgvLogPortalGridFuncionario.Columns(1).Visible = False
            pgvLogPortalGridFuncionario.Columns(13).Visible = False
            pgvLogPortalGridFuncionario.Columns(14).Visible = False

            pgvLogPortalGridFuncionario.Columns(2).Caption = "Sequência"
            pgvLogPortalGridFuncionario.Columns(2).Width = 75

            ' Definição de Mascarás no Grid
            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Enviado", -1, 1))
            pgvLogPortalGridFuncionario.Columns(3).ColumnEdit = image
            pgvLogPortalGridFuncionario.Columns(3).Caption = "Status Envio"
            pgvLogPortalGridFuncionario.Columns(3).Width = 100
            pgvLogPortalGridFuncionario.Columns(3).OptionsColumn.AllowEdit = False

            memo = New RepositoryItemMemoExEdit()
            memo.ReadOnly = True
            memo.AutoHeight = True
            memo.PopupSizeable = False
            memo.PopupBorderStyle = PopupBorderStyles.Style3D
            pgvLogPortalGridFuncionario.Columns(4).ColumnEdit = memo
            pgvLogPortalGridFuncionario.Columns(4).Caption = "Mensagem"
            pgvLogPortalGridFuncionario.Columns(4).Width = 210
            pgvLogPortalGridFuncionario.Columns(4).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap

            pgvLogPortalGridFuncionario.Columns(5).Caption = "Usuário" + Environment.NewLine + "Envio"
            pgvLogPortalGridFuncionario.Columns(5).Width = 70
            pgvLogPortalGridFuncionario.Columns(5).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridFuncionario.Columns(6).ColumnEdit = edit
            pgvLogPortalGridFuncionario.Columns(6).Caption = "Data/Hora" + Environment.NewLine + "Envio Inicio"
            pgvLogPortalGridFuncionario.Columns(6).Width = 115
            pgvLogPortalGridFuncionario.Columns(6).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridFuncionario.Columns(7).ColumnEdit = edit
            pgvLogPortalGridFuncionario.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Envio Fim"
            pgvLogPortalGridFuncionario.Columns(7).Width = 115
            pgvLogPortalGridFuncionario.Columns(7).OptionsColumn.AllowEdit = False

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizouImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", -1, 1))
            pgvLogPortalGridFuncionario.Columns(8).ColumnEdit = image
            pgvLogPortalGridFuncionario.Columns(8).Caption = "Status Visualização"
            pgvLogPortalGridFuncionario.Columns(8).Width = 100
            pgvLogPortalGridFuncionario.Columns(8).OptionsColumn.AllowEdit = False

            pgvLogPortalGridFuncionario.Columns(9).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvLogPortalGridFuncionario.Columns(9).Width = 200
            pgvLogPortalGridFuncionario.Columns(9).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridFuncionario.Columns(10).ColumnEdit = edit
            pgvLogPortalGridFuncionario.Columns(10).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvLogPortalGridFuncionario.Columns(10).Width = 115
            pgvLogPortalGridFuncionario.Columns(10).OptionsColumn.AllowEdit = False

            pgvLogPortalGridFuncionario.Columns(11).Caption = "Usuário" + Environment.NewLine + "LOG"
            pgvLogPortalGridFuncionario.Columns(11).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridFuncionario.Columns(12).ColumnEdit = edit
            pgvLogPortalGridFuncionario.Columns(12).Caption = "Data/Hora" + Environment.NewLine + "LOG"
            pgvLogPortalGridFuncionario.Columns(12).Width = 115

            '******************************************************************************************************************************************************
            ' DADOS DAS EMPRESAS POR INFORME (Nivel 1.3)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(2).RelationName = "monitoramentoInforme"
            pdgGrid.LevelTree.Nodes(2).LevelTemplate = pgvGridInforme
            pgvGridInforme.ViewCaption = "Informes"
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

            pgvGridInforme.Columns(1).Caption = "CNPJ/CPF"
            pgvGridInforme.Columns(1).Width = 130

            pgvGridInforme.Columns(2).Caption = "Nome"
            pgvGridInforme.Columns(2).Width = 400

            pgvGridInforme.Columns(3).Visible = False

            '******************************************************************************************************************************************************
            ' DADOS DAS OBRIGAÇÕES DAS EMPRESAS POR INFORME (Nivel 1.3.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(2).Nodes(0).RelationName = "DetalheInforme"
            pdgGrid.LevelTree.Nodes(2).Nodes(0).LevelTemplate = pgvGridDetalheInforme
            pgvGridDetalheInforme.ViewCaption = "Detalhes"
            pgvGridDetalheInforme.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
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
            pgvGridDetalheInforme.Columns(11).Visible = False
            pgvGridDetalheInforme.Columns(12).Visible = False
            pgvGridDetalheInforme.Columns(13).Visible = False
            pgvGridDetalheInforme.Columns(14).Visible = False
            pgvGridDetalheInforme.Columns(15).Visible = False
            pgvGridDetalheInforme.Columns(16).Visible = False
            pgvGridDetalheInforme.Columns(17).Visible = False
            pgvGridDetalheInforme.Columns(18).Visible = False

            ' Definição de Mascarás no Grid
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

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.3.1.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(2).Nodes(0).Nodes(0).RelationName = "LogInforme"
            pdgGrid.LevelTree.Nodes(2).Nodes(0).Nodes(0).LevelTemplate = pgvLogGridInforme
            pgvLogGridInforme.ViewCaption = "LOG"
            pgvLogGridInforme.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvLogGridInforme.PopulateColumns(dsMonitoramento.Tables("loginforme"))
            pgvLogGridInforme.OptionsView.ShowGroupPanel = False
            pgvLogGridInforme.OptionsBehavior.Editable = False
            pgvLogGridInforme.OptionsCustomization.AllowQuickHideColumns = False
            pgvLogGridInforme.OptionsCustomization.AllowColumnResizing = False
            pgvLogGridInforme.OptionsCustomization.AllowColumnMoving = False
            pgvLogGridInforme.OptionsCustomization.AllowGroup = False
            pgvLogGridInforme.OptionsView.ColumnAutoWidth = False
            pgvLogGridInforme.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvLogGridInforme.ColumnPanelRowHeight = 60
            pgvLogGridInforme.OptionsView.ColumnAutoWidth = False
            pgvLogGridInforme.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvLogGridInforme.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvLogGridInforme.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            pgvLogGridInforme.Columns(0).Visible = False
            pgvLogGridInforme.Columns(1).Visible = False
            pgvLogGridInforme.Columns(13).Visible = False
            pgvLogGridInforme.Columns(14).Visible = False
            pgvLogGridInforme.Columns(15).Visible = False
            pgvLogGridInforme.Columns(16).Visible = False
            pgvLogGridInforme.Columns(17).Visible = False
            pgvLogGridInforme.Columns(18).Visible = False
            pgvLogGridInforme.Columns(19).Visible = False
            pgvLogGridInforme.Columns(20).Visible = False

            pgvLogGridInforme.Columns(2).Caption = "Sequência"
            pgvLogGridInforme.Columns(2).Width = 75

            pgvLogGridInforme.Columns(3).Caption = "Data" + Environment.NewLine + "Vencimento"
            pgvLogGridInforme.Columns(3).Width = 75

            pgvLogGridInforme.Columns(4).Caption = "Usuário" + Environment.NewLine + "Geração"
            pgvLogGridInforme.Columns(4).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridInforme.Columns(5).ColumnEdit = edit
            pgvLogGridInforme.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Geração"
            pgvLogGridInforme.Columns(5).Width = 115

            pgvLogGridInforme.Columns(6).Caption = "Usuário" + Environment.NewLine + "Entrega"
            pgvLogGridInforme.Columns(6).Width = 70

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridInforme.Columns(7).ColumnEdit = edit
            pgvLogGridInforme.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Entrega"
            pgvLogGridInforme.Columns(7).Width = 115

            pgvLogGridInforme.Columns(8).Caption = "Usuário" + Environment.NewLine + "Encarregado"
            pgvLogGridInforme.Columns(8).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridInforme.Columns(9).ColumnEdit = edit
            pgvLogGridInforme.Columns(9).Caption = "Data/Hora" + Environment.NewLine + "Encarregado"
            pgvLogGridInforme.Columns(9).Width = 115

            pgvLogGridInforme.Columns(10).Caption = "Usuário" + Environment.NewLine + "LOG"
            pgvLogGridInforme.Columns(10).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogGridInforme.Columns(11).ColumnEdit = edit
            pgvLogGridInforme.Columns(11).Caption = "Data/Hora" + Environment.NewLine + "LOG"
            pgvLogGridInforme.Columns(11).Width = 115

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picStatusImageColection
            image.Items.Add(New ImageComboBoxItem("Não Inicializado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Pendente", 1, 1))
            image.Items.Add(New ImageComboBoxItem("Finalizado", 2, 2))
            pgvLogGridInforme.Columns(12).ColumnEdit = image
            pgvLogGridInforme.Columns(12).Caption = "Status"
            pgvLogGridInforme.Columns(12).Width = 120

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.3.1.2)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(2).Nodes(0).Nodes(1).RelationName = "PortalInforme"
            pdgGrid.LevelTree.Nodes(2).Nodes(0).Nodes(1).LevelTemplate = pgvPortalGridInforme
            pgvPortalGridInforme.ViewCaption = "PORTAL"
            pgvPortalGridInforme.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvPortalGridInforme.PopulateColumns(dsMonitoramento.Tables("portalinforme"))
            pgvPortalGridInforme.OptionsView.ShowGroupPanel = False
            pgvPortalGridInforme.OptionsCustomization.AllowQuickHideColumns = False
            pgvPortalGridInforme.OptionsCustomization.AllowColumnResizing = False
            pgvPortalGridInforme.OptionsCustomization.AllowColumnMoving = False
            pgvPortalGridInforme.OptionsCustomization.AllowGroup = False
            pgvPortalGridInforme.OptionsView.ColumnAutoWidth = False
            pgvPortalGridInforme.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvPortalGridInforme.ColumnPanelRowHeight = 60
            pgvPortalGridInforme.OptionsView.ColumnAutoWidth = False
            pgvPortalGridInforme.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvPortalGridInforme.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvPortalGridInforme.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap
            pgvPortalGridInforme.OptionsView.RowAutoHeight = True
            pgvPortalGridInforme.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways

            pgvPortalGridInforme.Columns(0).Visible = False
            pgvPortalGridInforme.Columns(1).Visible = False
            pgvPortalGridInforme.Columns(10).Visible = False
            pgvPortalGridInforme.Columns(11).Visible = False
            pgvPortalGridInforme.Columns(12).Visible = False
            pgvPortalGridInforme.Columns(13).Visible = False
            pgvPortalGridInforme.Columns(14).Visible = False
            pgvPortalGridInforme.Columns(15).Visible = False
            pgvPortalGridInforme.Columns(16).Visible = False
            pgvPortalGridInforme.Columns(17).Visible = False

            ' Definição de Mascarás no Grid
            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Enviado", -1, 1))
            pgvPortalGridInforme.Columns(2).ColumnEdit = image
            pgvPortalGridInforme.Columns(2).Caption = "Status Envio"
            pgvPortalGridInforme.Columns(2).Width = 100
            pgvPortalGridInforme.Columns(2).OptionsColumn.AllowEdit = False

            memo = New RepositoryItemMemoExEdit()
            memo.ReadOnly = True
            memo.AutoHeight = True
            memo.PopupSizeable = False
            memo.PopupBorderStyle = PopupBorderStyles.Style3D
            pgvPortalGridInforme.Columns(3).ColumnEdit = memo
            pgvPortalGridInforme.Columns(3).Caption = "Mensagem"
            pgvPortalGridInforme.Columns(3).Width = 210
            pgvPortalGridInforme.Columns(3).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap

            pgvPortalGridInforme.Columns(4).Caption = "Usuário" + Environment.NewLine + "Envio"
            pgvPortalGridInforme.Columns(4).Width = 70
            pgvPortalGridInforme.Columns(4).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridInforme.Columns(5).ColumnEdit = edit
            pgvPortalGridInforme.Columns(5).Caption = "Data/Hora" + Environment.NewLine + "Envio Inicio"
            pgvPortalGridInforme.Columns(5).Width = 115
            pgvPortalGridInforme.Columns(5).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridInforme.Columns(6).ColumnEdit = edit
            pgvPortalGridInforme.Columns(6).Caption = "Data/Hora" + Environment.NewLine + "Envio Fim"
            pgvPortalGridInforme.Columns(6).Width = 115
            pgvPortalGridInforme.Columns(6).OptionsColumn.AllowEdit = False

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizouImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", -1, 1))
            pgvPortalGridInforme.Columns(7).ColumnEdit = image
            pgvPortalGridInforme.Columns(7).Caption = "Status Visualização"
            pgvPortalGridInforme.Columns(7).Width = 100
            pgvPortalGridInforme.Columns(7).OptionsColumn.AllowEdit = False

            pgvPortalGridInforme.Columns(8).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvPortalGridInforme.Columns(8).Width = 200
            pgvPortalGridInforme.Columns(8).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvPortalGridInforme.Columns(9).ColumnEdit = edit
            pgvPortalGridInforme.Columns(9).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvPortalGridInforme.Columns(9).Width = 115
            pgvPortalGridInforme.Columns(9).OptionsColumn.AllowEdit = False

            '******************************************************************************************************************************************************
            ' LOG DAS OBRIGAÇÕES DAS EMPRESAS (Nivel 1.3.1.2.1)
            '******************************************************************************************************************************************************

            pdgGrid.LevelTree.Nodes(2).Nodes(0).Nodes(1).Nodes(0).RelationName = "LogPortalInforme"
            pdgGrid.LevelTree.Nodes(2).Nodes(0).Nodes(1).Nodes(0).LevelTemplate = pgvLogPortalGridInforme
            pgvLogPortalGridInforme.ViewCaption = "LOG"
            pgvLogPortalGridInforme.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvLogPortalGridInforme.PopulateColumns(dsMonitoramento.Tables("logportalinforme"))
            pgvLogPortalGridInforme.OptionsView.ShowGroupPanel = False
            pgvLogPortalGridInforme.OptionsCustomization.AllowQuickHideColumns = False
            pgvLogPortalGridInforme.OptionsCustomization.AllowColumnResizing = False
            pgvLogPortalGridInforme.OptionsCustomization.AllowColumnMoving = False
            pgvLogPortalGridInforme.OptionsCustomization.AllowGroup = False
            pgvLogPortalGridInforme.OptionsView.ColumnAutoWidth = False
            pgvLogPortalGridInforme.ScrollStyle = ScrollStyleFlags.LiveHorzScroll

            pgvLogPortalGridInforme.ColumnPanelRowHeight = 60
            pgvLogPortalGridInforme.OptionsView.ColumnAutoWidth = False
            pgvLogPortalGridInforme.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvLogPortalGridInforme.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvLogPortalGridInforme.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap
            pgvLogPortalGridInforme.OptionsView.RowAutoHeight = False
            pgvLogPortalGridInforme.OptionsView.ShowButtonMode = Views.Base.ShowButtonModeEnum.ShowAlways

            pgvLogPortalGridInforme.Columns(0).Visible = False
            pgvLogPortalGridInforme.Columns(1).Visible = False
            pgvLogPortalGridInforme.Columns(13).Visible = False
            pgvLogPortalGridInforme.Columns(14).Visible = False
            pgvLogPortalGridInforme.Columns(15).Visible = False
            pgvLogPortalGridInforme.Columns(16).Visible = False
            pgvLogPortalGridInforme.Columns(17).Visible = False
            pgvLogPortalGridInforme.Columns(18).Visible = False
            pgvLogPortalGridInforme.Columns(19).Visible = False
            pgvLogPortalGridInforme.Columns(20).Visible = False

            pgvLogPortalGridInforme.Columns(2).Caption = "Sequência"
            pgvLogPortalGridInforme.Columns(2).Width = 75

            ' Definição de Mascarás no Grid
            image = New RepositoryItemImageComboBox()
            image.SmallImages = picEnvioImageColection
            image.Items.Add(New ImageComboBoxItem("Não Enviado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Enviado", -1, 1))
            pgvLogPortalGridInforme.Columns(3).ColumnEdit = image
            pgvLogPortalGridInforme.Columns(3).Caption = "Status Envio"
            pgvLogPortalGridInforme.Columns(3).Width = 100
            pgvLogPortalGridInforme.Columns(3).OptionsColumn.AllowEdit = False

            memo = New RepositoryItemMemoExEdit()
            memo.ReadOnly = True
            memo.AutoHeight = True
            memo.PopupSizeable = False
            memo.PopupBorderStyle = PopupBorderStyles.Style3D
            pgvLogPortalGridInforme.Columns(4).ColumnEdit = memo
            pgvLogPortalGridInforme.Columns(4).Caption = "Mensagem"
            pgvLogPortalGridInforme.Columns(4).Width = 210
            pgvLogPortalGridInforme.Columns(4).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap

            pgvLogPortalGridInforme.Columns(5).Caption = "Usuário" + Environment.NewLine + "Envio"
            pgvLogPortalGridInforme.Columns(5).Width = 70
            pgvLogPortalGridInforme.Columns(5).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridInforme.Columns(6).ColumnEdit = edit
            pgvLogPortalGridInforme.Columns(6).Caption = "Data/Hora" + Environment.NewLine + "Envio Inicio"
            pgvLogPortalGridInforme.Columns(6).Width = 115
            pgvLogPortalGridInforme.Columns(6).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridInforme.Columns(7).ColumnEdit = edit
            pgvLogPortalGridInforme.Columns(7).Caption = "Data/Hora" + Environment.NewLine + "Envio Fim"
            pgvLogPortalGridInforme.Columns(7).Width = 115
            pgvLogPortalGridInforme.Columns(7).OptionsColumn.AllowEdit = False

            image = New RepositoryItemImageComboBox()
            image.SmallImages = picVisualizouImageColection
            image.Items.Add(New ImageComboBoxItem("Não Visualizado", 0, 0))
            image.Items.Add(New ImageComboBoxItem("Visualizado", -1, 1))
            pgvLogPortalGridInforme.Columns(8).ColumnEdit = image
            pgvLogPortalGridInforme.Columns(8).Caption = "Status Visualização"
            pgvLogPortalGridInforme.Columns(8).Width = 100
            pgvLogPortalGridInforme.Columns(8).OptionsColumn.AllowEdit = False

            pgvLogPortalGridInforme.Columns(9).Caption = "Primeira Visualização:" + Environment.NewLine + "Usuário"
            pgvLogPortalGridInforme.Columns(9).Width = 200
            pgvLogPortalGridInforme.Columns(9).OptionsColumn.AllowEdit = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridInforme.Columns(10).ColumnEdit = edit
            pgvLogPortalGridInforme.Columns(10).Caption = "Primeira Visualização:" + Environment.NewLine + "Horário"
            pgvLogPortalGridInforme.Columns(10).Width = 115
            pgvLogPortalGridInforme.Columns(10).OptionsColumn.AllowEdit = False

            pgvLogPortalGridInforme.Columns(11).Caption = "Usuário" + Environment.NewLine + "LOG"
            pgvLogPortalGridInforme.Columns(11).Width = 85

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.DateTime
            edit.Mask.UseMaskAsDisplayFormat = True
            pgvLogPortalGridInforme.Columns(12).ColumnEdit = edit
            pgvLogPortalGridInforme.Columns(12).Caption = "Data/Hora" + Environment.NewLine + "LOG"
            pgvLogPortalGridInforme.Columns(12).Width = 115

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class