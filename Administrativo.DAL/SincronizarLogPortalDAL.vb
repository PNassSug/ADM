Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports Administrativo.Modelo
''' <summary>
''' Camada de acesso a dados da classe DataBaseDAL.vb
''' </summary>
''' <remarks>
''' Nesta camada de negócio o sistema vai realizar as seguintes buscas:
''' Browse
''' DefineValoresDefault
''' BuscaControleAdministrativo
''' RetornaDescricao
''' Report
''' </remarks>
Public Class SincronizarlogportalDAL
    Implements ISincronizarlogportal

    ''' <summary>
    ''' BuscaControleAdministrativo
    ''' </summary>
    ''' <param name="pstrCompetenciaInicial">Competência inicial</param>
    ''' <param name="pstrCompetenciaFinal">Competência final</param>
    ''' <param name="pstrEmpresaInicial">Empresa inicial</param>
    ''' <param name="pstrEmpresaFinal">Empresa final</param>
    ''' <param name="pstrObrigacaoInicial">Obrigação inicial</param>
    ''' <param name="pstrObrigacaoFinal">Obrigação final</param>
    ''' <remarks>
    ''' monta a query para a busca no banco, dos logs que devem ser verificados se foram atualizados.
    ''' </remarks>
    Public Sub BuscaControleAdministrativo(pstrCompetenciaInicial As String, pstrCompetenciaFinal As String, pstrEmpresaInicial As String, pstrEmpresaFinal As String, pstrObrigacaoInicial As String, pstrObrigacaoFinal As String) Implements ISincronizarlogportal.BuscaControleAdministrativo
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim strWhere As String = String.Empty

            If Not String.IsNullOrEmpty(pstrCompetenciaInicial) Then
                strWhere += "and to_timestamp(adm.competencia, 'MMYYYY') between to_timestamp('" + pstrCompetenciaInicial + "', 'MMYYYY') and to_timestamp('" + pstrCompetenciaFinal + "', 'MMYYYY') "
            End If
            If Not String.IsNullOrEmpty(pstrEmpresaInicial) Then
                strWhere += "and adm.empresa between '" + pstrEmpresaInicial + "' and '" + pstrEmpresaFinal + "' "
            End If
            If Not String.IsNullOrEmpty(pstrObrigacaoInicial) Then
                strWhere += "and adm.obrigacao between '" + pstrObrigacaoInicial + "' and '" + pstrObrigacaoFinal + "' "
            End If
            Dim strJoinUsuarios As String = String.Empty
            If usuarioInfo.obrigacoes Then
                strJoinUsuarios = "join admobrigacoesusuarios aou on aou.obrigacao = adm.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            strQuery = "select cast('A' as varchar) as wsportal, adm.empresa, adm.obrigacao, adm.competencia, adm.exercicio, adm.parcela, adm.sequenciaextra, adm.obrigacaoextra, adm.tipopessoainforme, adm.informe, ada.empresavisualizou, ada.nomeusuarioempresa, ada.datahoraempresavisualizou, adm.funcionario " +
                          "from admcontroleadministrativo adm " +
                          "join admcontroleadministrativoportalarquivos ada on adm.empresa = ada.empresa " +
                                                                          "and adm.competencia = ada.competencia " +
                                                                          "and adm.obrigacao = ada.obrigacao " +
                                                                          "and adm.exercicio = ada.exercicio " +
                                                                          "and adm.parcela = ada.parcela " +
                                                                          "and adm.sequenciaextra = ada.sequenciaextra " +
                                                                          "and adm.obrigacaoextra = ada.obrigacaoextra " +
                                                                          "and adm.tipopessoainforme = ada.tipopessoainforme " +
                                                                          "and adm.informe = ada.informe " +
                                                                          "and coalesce(adm.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                          "and adm.exercicio = ada.exercicio " +
                                                                          "and ada.empresavisualizou = 0 " + strJoinUsuarios + " " +
                         "where adm.tipoenvio = 'S' " +
                           "and adm.vistoencarregado = -1 " +
                                strWhere +
                         "union all " +
                        "select cast('G' as varchar) as wsportal, adm.empresa, adm.obrigacao, adm.competencia, adm.exercicio, adm.parcela, adm.sequenciaextra, adm.obrigacaoextra, adm.tipopessoainforme, adm.informe, adg.empresavisualizou, adg.nomeusuarioempresa, adg.datahoraempresavisualizou, adm.funcionario " +
                          "from admcontroleadministrativo adm " +
                          "join admcontroleadministrativoportalguias adg on adm.empresa = adg.empresa " +
                                                                       "and adm.competencia = adg.competencia " +
                                                                       "and adm.obrigacao = adg.obrigacao " +
                                                                       "and adm.exercicio = adg.exercicio " +
                                                                       "and adm.parcela = adg.parcela " +
                                                                       "and adm.sequenciaextra = adg.sequenciaextra " +
                                                                       "and adm.obrigacaoextra = adg.obrigacaoextra " +
                                                                       "and adm.tipopessoainforme = adg.tipopessoainforme " +
                                                                       "and adm.informe = adg.informe " +
                                                                       "and coalesce(adm.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                       "and adm.exercicio = adg.exercicio " +
                                                                       "and adg.empresavisualizou = 0 " +
                                                                       "and coalesce(adg.usuarioenvio, '') <> '' " + strJoinUsuarios + " " +
                         "where adm.tipoenvio = 'S' " +
                           "and adm.vistoencarregado = -1 " +
                                strWhere +
                         "order by 2, 3, 4 "
            AtualizaControleAdministrativo(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' AtualizaControleAdministrativo
    ''' </summary>
    ''' <param name="pstrQuery">Comando SQL</param>
    ''' <remarks>
    ''' Busca os logs na WebService, a fim de atualizar o banco de dados
    ''' </remarks>
    Private Sub AtualizaControleAdministrativo(pstrQuery As String)
        Dim strNomeUsuario As String = String.Empty
        Dim dateDatavisualizacao As DateTime
        Dim objManutencaoObrigacoes As New ManutencaoObrigacoesDAL
        Dim infoPortalLog As manutencaoobrigacoesInfo
        Dim objDataBase As New DataBaseDAL
        Try
            Dim sdData As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                infoPortalLog = objManutencaoObrigacoes.BuscaDados(row.Values(1).ToString, row.Values(3).ToString, Convert.ToInt64(row.Values(4)), row.Values(2).ToString, Convert.ToInt64(row.Values(6)), Convert.ToInt64(row.Values(7)), Convert.ToString(row.Values(13)), Convert.ToInt64(row.Values(5)), Convert.ToInt64(row.Values(8)), Convert.ToInt64(row.Values(9)))
                If row.Values(0).ToString = "A" Then
                    objManutencaoObrigacoes.LogArquivos(infoPortalLog)
                Else
                    objManutencaoObrigacoes.LogGuias(infoPortalLog)
                End If
                strNomeUsuario = String.Empty
                dateDatavisualizacao = Nothing
                If infoPortalLog.portallog.Count > 0 Then
                    For iLista = 0 To infoPortalLog.portallog.Count - 1
                        If iLista > 0 Then
                            If Convert.ToDateTime(dateDatavisualizacao) >= infoPortalLog.portallog(iLista).datahora Then
                                If Not infoPortalLog.portallog(iLista).nome Is Nothing Then
                                    strNomeUsuario = infoPortalLog.portallog(iLista).nome
                                End If

                                dateDatavisualizacao = Convert.ToDateTime(infoPortalLog.portallog(iLista).datahora)
                            End If
                        Else
                            If Not infoPortalLog.portallog(iLista).nome Is Nothing Then
                                strNomeUsuario = infoPortalLog.portallog(iLista).nome
                            End If
                            dateDatavisualizacao = Convert.ToDateTime(infoPortalLog.portallog(iLista).datahora)
                        End If
                    Next
                    If infoPortalLog.portalarquivos.Count > 0 Then
                        If infoPortalLog.portallog.Count > 0 Then
                            infoPortalLog.portalarquivos(0).empresavisualizou = -1
                        Else
                            infoPortalLog.portalarquivos(0).empresavisualizou = 0
                        End If
                        infoPortalLog.portalarquivos(0).nomeusuarioempresa = strNomeUsuario
                        If Not String.IsNullOrEmpty(dateDatavisualizacao.ToString) Then
                            infoPortalLog.portalarquivos(0).datahoraempresavisualizou = Convert.ToDateTime(dateDatavisualizacao)
                        Else
                            infoPortalLog.portalarquivos(0).datahoraempresavisualizou = Nothing
                        End If
                        objManutencaoObrigacoes.IUDPortalArquivos("alteracao", infoPortalLog)
                    End If
                    If infoPortalLog.portalguias.Count > 0 Then
                        If infoPortalLog.portallog.Count > 0 Then
                            infoPortalLog.portalguias(0).empresavisualizou = -1
                        Else
                            infoPortalLog.portalguias(0).empresavisualizou = 0
                        End If
                        infoPortalLog.portalguias(0).nomeusuarioempresa = strNomeUsuario
                        If Not String.IsNullOrEmpty(dateDatavisualizacao.ToString) Then
                            infoPortalLog.portalguias(0).datahoraempresavisualizou = Convert.ToDateTime(dateDatavisualizacao)
                        Else
                            infoPortalLog.portalguias(0).datahoraempresavisualizou = Nothing
                        End If
                        objManutencaoObrigacoes.IUDPortalGuias("alteracao", infoPortalLog)
                    End If
                End If
            Next row
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Report
    ''' </summary>
    ''' <param name="pstrCompetenciaInicial">Competência inicial</param>
    ''' <param name="pstrCompetenciaFinal">Competência final</param>
    ''' <param name="pstrEmpresaInicial">Empresa inicial</param>
    ''' <param name="pstrEmpresaFinal">Empresa final</param>
    ''' <param name="pstrObrigacaoInicial">Obrigação inicial</param>
    ''' <param name="pstrObrigacaoFinal">Obrigação final</param>
    ''' <param name="pReport">Report do Relatório</param>
    ''' <remarks>
    ''' Gera um relatório do que não foi sincronizado.
    ''' </remarks>
    Public Sub Report(pstrCompetenciaInicial As String, pstrCompetenciaFinal As String, pstrEmpresaInicial As String, pstrEmpresaFinal As String, pstrObrigacaoInicial As String, pstrObrigacaoFinal As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements ISincronizarlogportal.Report
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim strWhere As String = String.Empty

            If Not String.IsNullOrEmpty(pstrCompetenciaInicial) Then
                strWhere += "and to_timestamp(adm.competencia, 'MMYYYY') between to_timestamp('" + pstrCompetenciaInicial + "', 'MMYYYY') and to_timestamp('" + pstrCompetenciaFinal + "', 'MMYYYY') "
            End If
            If Not String.IsNullOrEmpty(pstrEmpresaInicial) Then
                strWhere += "and adm.empresa between '" + pstrEmpresaInicial + "' and '" + pstrEmpresaFinal + "' "
            End If
            If Not String.IsNullOrEmpty(pstrObrigacaoInicial) Then
                strWhere += "and adm.obrigacao between '" + pstrObrigacaoInicial + "' and '" + pstrObrigacaoFinal + "' "
            End If

            Dim strJoinUsuarios As String = String.Empty
            If usuarioInfo.obrigacoes Then
                strJoinUsuarios = "join admobrigacoesusuarios aou on aou.obrigacao = adm.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            '*********************************************************
            'Query Geral sem informações de Informes e Funcionários
            '*********************************************************
            strQuery = "select adm.empresa, adm.competencia, adm.obrigacao, ada.usuarioenvio, ada.datahoraenvioinicio, ada.datahoraenviofim, ado.descricao, emp.razaosocial, cast('' as varchar) as tipo, cast('' as varchar) as funcionariocnpjcpf, cast('' as varchar) as nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalarquivos ada on adm.empresa = ada.empresa and adm.competencia = ada.competencia " +
                                                                         "and adm.obrigacao = ada.obrigacao and adm.exercicio = ada.exercicio and adm.parcela = ada.parcela " +
                                                                         "and adm.sequenciaextra = ada.sequenciaextra and adm.obrigacaoextra = ada.obrigacaoextra and adm.tipopessoainforme = ada.tipopessoainforme " +
                                                                         "and adm.informe = ada.informe and coalesce(adm.funcionario,'') = coalesce(ada.funcionario,'') and adm.exercicio = ada.exercicio " +
                                                                         "and ada.empresavisualizou = 0 and coalesce(ada.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.tipopessoainforme,0) = 0 and coalesce(adm.funcionario,'') = '' " + strWhere
            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, adg.usuarioenvio, adg.datahoraenvioinicio, adg.datahoraenviofim, ado.descricao, emp.razaosocial, cast('' as varchar) as tipo, cast('' as varchar) as funcionariocnpjcpf, cast('' as varchar) as nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalguias adg on adm.empresa = adg.empresa and adm.competencia = adg.competencia " +
                                                                      "and adm.obrigacao = adg.obrigacao and adm.exercicio = adg.exercicio and adm.parcela = adg.parcela " +
                                                                      "and adm.sequenciaextra = adg.sequenciaextra and adm.obrigacaoextra = adg.obrigacaoextra and adm.tipopessoainforme = adg.tipopessoainforme " +
                                                                      "and adm.informe = adg.informe and coalesce(adm.funcionario,'') = coalesce(adg.funcionario,'') and adm.exercicio = adg.exercicio " +
                                                                      "and adg.empresavisualizou = 0 and coalesce(adg.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.tipopessoainforme,0) = 0 and coalesce(adm.funcionario,'') = '' " + strWhere

            '*********************************************************
            'Query Geral só de Informes
            '*********************************************************
            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, ada.usuarioenvio, ada.datahoraenvioinicio, ada.datahoraenviofim, ado.descricao, emp.razaosocial, cast('J' as varchar) as tipo, jur.cnpj as funcionariocnpjcpf, jur.nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalarquivos ada on adm.empresa = ada.empresa and adm.competencia = ada.competencia " +
                                                                         "and adm.obrigacao = ada.obrigacao and adm.exercicio = ada.exercicio and adm.parcela = ada.parcela " +
                                                                         "and adm.sequenciaextra = ada.sequenciaextra and adm.obrigacaoextra = ada.obrigacaoextra and adm.tipopessoainforme = ada.tipopessoainforme " +
                                                                         "and adm.informe = ada.informe and coalesce(adm.funcionario,'') = coalesce(ada.funcionario,'') and adm.exercicio = ada.exercicio " +
                                                                         "and ada.empresavisualizou = 0 and coalesce(ada.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                         "join informesjuridica jur on jur.empresa = adm.empresa and jur.informejuridica = adm.informe and jur.darf = adm.darfinforme and jur.tipoinforme = adm.tipoinforme and jur.cnpj = adm.cnpjcpfinforme and jur.exercicio = adm.exercicio  " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.tipopessoainforme,0) = 1 " + strWhere

            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, ada.usuarioenvio, ada.datahoraenvioinicio, ada.datahoraenviofim, ado.descricao, emp.razaosocial, cast('F' as varchar) as tipo, fis.cpf as funcionariocnpjcpf, fis.nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalarquivos ada on adm.empresa = ada.empresa and adm.competencia = ada.competencia " +
                                                                         "and adm.obrigacao = ada.obrigacao and adm.exercicio = ada.exercicio and adm.parcela = ada.parcela " +
                                                                         "and adm.sequenciaextra = ada.sequenciaextra and adm.obrigacaoextra = ada.obrigacaoextra and adm.tipopessoainforme = ada.tipopessoainforme " +
                                                                         "and adm.informe = ada.informe and coalesce(adm.funcionario,'') = coalesce(ada.funcionario,'') and adm.exercicio = ada.exercicio " +
                                                                         "and ada.empresavisualizou = 0 and coalesce(ada.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                         "join informesfisica fis on fis.empresa = adm.empresa and fis.informefisica = adm.informe and fis.darf = adm.darfinforme and fis.tipoinforme = adm.tipoinforme and fis.cpf = adm.cnpjcpfinforme and fis.exercicio = adm.exercicio  " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.tipopessoainforme,0) = 2 " + strWhere

            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, adg.usuarioenvio, adg.datahoraenvioinicio, adg.datahoraenviofim, ado.descricao, emp.razaosocial, cast('J' as varchar) as tipo, jur.cnpj as funcionariocnpjcpf, jur.nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalguias adg on adm.empresa = adg.empresa and adm.competencia = adg.competencia " +
                                                                      "and adm.obrigacao = adg.obrigacao and adm.exercicio = adg.exercicio and adm.parcela = adg.parcela " +
                                                                      "and adm.sequenciaextra = adg.sequenciaextra and adm.obrigacaoextra = adg.obrigacaoextra and adm.tipopessoainforme = adg.tipopessoainforme " +
                                                                      "and adm.informe = adg.informe and coalesce(adm.funcionario,'') = coalesce(adg.funcionario,'') and adm.exercicio = adg.exercicio " +
                                                                      "and adg.empresavisualizou = 0 and coalesce(adg.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                         "join informesjuridica jur on jur.empresa = adm.empresa and jur.informejuridica = adm.informe and jur.darf = adm.darfinforme and jur.tipoinforme = adm.tipoinforme and jur.cnpj = adm.cnpjcpfinforme and jur.exercicio = adm.exercicio  " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.tipopessoainforme,0) = 1 " + strWhere

            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, adg.usuarioenvio, adg.datahoraenvioinicio, adg.datahoraenviofim, ado.descricao, emp.razaosocial, cast('F' as varchar) as tipo, fis.cpf as funcionariocnpjcpf, fis.nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalguias adg on adm.empresa = adg.empresa and adm.competencia = adg.competencia " +
                                                                      "and adm.obrigacao = adg.obrigacao and adm.exercicio = adg.exercicio and adm.parcela = adg.parcela " +
                                                                      "and adm.sequenciaextra = adg.sequenciaextra and adm.obrigacaoextra = adg.obrigacaoextra and adm.tipopessoainforme = adg.tipopessoainforme " +
                                                                      "and adm.informe = adg.informe and coalesce(adm.funcionario,'') = coalesce(adg.funcionario,'') and adm.exercicio = adg.exercicio " +
                                                                      "and adg.empresavisualizou = 0 and coalesce(adg.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                         "join informesfisica fis on fis.empresa = adm.empresa and fis.informefisica = adm.informe and fis.darf = adm.darfinforme and fis.tipoinforme = adm.tipoinforme and fis.cpf = adm.cnpjcpfinforme and fis.exercicio = adm.exercicio  " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.tipopessoainforme,0) = 2 " + strWhere

            '*********************************************************
            'Query Geral só de Funcionários
            '*********************************************************
            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, ada.usuarioenvio, ada.datahoraenvioinicio, ada.datahoraenviofim, ado.descricao, emp.razaosocial, cast('C' as varchar) as tipo, f.funcionario as funcionariocnpjcpf, f.nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalarquivos ada on adm.empresa = ada.empresa and adm.competencia = ada.competencia " +
                                                                         "and adm.obrigacao = ada.obrigacao and adm.exercicio = ada.exercicio and adm.parcela = ada.parcela " +
                                                                         "and adm.sequenciaextra = ada.sequenciaextra and adm.obrigacaoextra = ada.obrigacaoextra and adm.tipopessoainforme = ada.tipopessoainforme " +
                                                                         "and adm.informe = ada.informe and coalesce(adm.funcionario,'') = coalesce(ada.funcionario,'') and adm.exercicio = ada.exercicio " +
                                                                         "and ada.empresavisualizou = 0 and coalesce(ada.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                         "join funcionarios f on f.empresa = adm.empresa and f.funcionario = adm.funcionario " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.funcionario,'') <> '' " + strWhere

            strQuery = strQuery +
                    "union all " +
                       "select adm.empresa, adm.competencia, adm.obrigacao, adg.usuarioenvio, adg.datahoraenvioinicio, adg.datahoraenviofim, ado.descricao, emp.razaosocial, cast('C' as varchar) as tipo, f.funcionario as funcionariocnpjcpf, f.nome " +
                         "from admcontroleadministrativo adm " +
                         "join admcontroleadministrativoportalguias adg on adm.empresa = adg.empresa and adm.competencia = adg.competencia " +
                                                                      "and adm.obrigacao = adg.obrigacao and adm.exercicio = adg.exercicio and adm.parcela = adg.parcela " +
                                                                      "and adm.sequenciaextra = adg.sequenciaextra and adm.obrigacaoextra = adg.obrigacaoextra and adm.tipopessoainforme = adg.tipopessoainforme " +
                                                                      "and adm.informe = adg.informe and coalesce(adm.funcionario,'') = coalesce(adg.funcionario,'') and adm.exercicio = adg.exercicio " +
                                                                      "and adg.empresavisualizou = 0 and coalesce(adg.usuarioenvio, '') <> '' " +
                         "join admobrigacoes ado on adm.obrigacao = ado.obrigacao " + strJoinUsuarios + " " +
                         "join empresas emp on emp.empresa = adm.empresa and emp.exercicio = adm.exercicio " +
                         "join funcionarios f on f.empresa = adm.empresa and f.funcionario = adm.funcionario " +
                        "where adm.tipoenvio = 'S' and adm.vistoencarregado = -1 " +
                          "and coalesce(adm.funcionario,'') <> '' " + strWhere +
                     "order by 2, 3, 4 "

            pReport.DataSource = objDataBase.QueryDataView(strQuery)

            Dim dvtable As XPDataView = CType(pReport.DataSource, XPDataView)
            If dvtable.Count = 0 Then Throw New Exception("Não existem informações a serem impressas")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
