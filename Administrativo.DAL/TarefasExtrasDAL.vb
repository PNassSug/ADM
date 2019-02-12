Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraSplashScreen

Public Class TarefasExtrasDAL
    Implements ITarefasExtras

    Private edit As RepositoryItemTextEdit

    Public Sub Grid(ByRef pstrQuery As String, ByRef pstrFieldGroup As String, ByRef pstrCaptionGroup As String, ByRef pstrTituloGrid As String, ByRef pintQtdLinhaTitulo As Integer, pdgGrid As DevExpress.XtraGrid.GridControl, pbgvGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView) Implements ITarefasExtras.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            pdgGrid.DataSource = objDataBase.QueryDataView(pstrQuery)

            'Adiciona o Grupo da Banda
            pbgvGrid.Columns(pstrFieldGroup).GroupIndex = 0
            pbgvGrid.Columns(pstrFieldGroup).Caption = pstrCaptionGroup
            pbgvGrid.Columns(pstrFieldGroup).Visible = False

            If pbgvGrid.Bands.Count = 0 Then
                'Cria um Band - Titulo para o Grid
                pbgvGrid.Bands.AddBand(pstrTituloGrid)

                'Define a quantidade de linhas do tamanho de demonstração do titulo
                pbgvGrid.Bands(0).RowCount = pintQtdLinhaTitulo
            End If
            'Arrasta as colunas para dentro do titulo
            If pbgvGrid.Bands(0).Columns.Count = 0 Then
                Dim bgcColuna As New BandedGridColumn
                bgcColuna.Visible = True
                bgcColuna.FieldName = "datavencimento"
                bgcColuna.Caption = "Data Vencimento"
                pbgvGrid.Bands(0).Columns.Add(bgcColuna)

                bgcColuna = New BandedGridColumn
                bgcColuna.Visible = True
                bgcColuna.FieldName = "descricao"
                bgcColuna.Caption = "Descrição"
                pbgvGrid.Bands(0).Columns.Add(bgcColuna)

                bgcColuna = New BandedGridColumn
                bgcColuna.Visible = True
                bgcColuna.FieldName = "obrigacao"
                bgcColuna.Caption = "Obrigação"
                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = True
                edit.Mask.EditMask = "0-00000"
                bgcColuna.ColumnEdit = edit
                pbgvGrid.Bands(0).Columns.Add(bgcColuna)

                bgcColuna = New BandedGridColumn
                bgcColuna.Visible = True
                bgcColuna.FieldName = "competencia"
                bgcColuna.Caption = "Fato Gerador"
                edit = New RepositoryItemTextEdit()
                edit.Mask.MaskType = MaskType.Simple
                edit.Mask.UseMaskAsDisplayFormat = True
                edit.Mask.EditMask = "00/0000"
                bgcColuna.ColumnEdit = edit
                pbgvGrid.Bands(0).Columns.Add(bgcColuna)

                pbgvGrid.Bands(0).MinWidth = 800
                pbgvGrid.Bands(0).Columns(0).Width = 90
                pbgvGrid.Bands(0).Columns(1).Width = 80
                pbgvGrid.Bands(0).Columns(2).Width = 500
                pbgvGrid.Bands(0).Columns(3).Width = 200
            End If

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDTarefasExtras(ByRef pstrOperacao As String, ByRef infoTarefasExtras As Modelo.tarefasextrasInfo) Implements ITarefasExtras.IUDTarefasExtras
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "inclusao" Then
                strQuery = "insert into admcontroleadministrativo(empresa, competencia, obrigacao, exercicio, obrigacaoextra, datavencimento, sequenciaextra, funcionario, usuarioobrigacaoextra, datahoraobrigacaoextra, observacao) " +
                                                         "values ('" + infoTarefasExtras.empresa + "', " +
                                                                 "'" + infoTarefasExtras.competencia + "', " +
                                                                 "'" + infoTarefasExtras.obrigacao + "', " +
                                                                       infoTarefasExtras.competencia.ToString.Substring(2, 4) + ", -1, " +
                                                                 "'" + infoTarefasExtras.datavencimento.Value.ToString("yyyy-MM-dd") + "', " +
                                                                       infoTarefasExtras.sequenciaextra.ToString() + ", " +
                                                                 "'" + infoTarefasExtras.funcionario + "', " +
                                                                 "'" + infoTarefasExtras.usuarioobrigacaoextra + "', "
                If infoTarefasExtras.datahoraobrigacaoextra.HasValue Then
                    strQuery += "'" + infoTarefasExtras.datahoraobrigacaoextra.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', "
                Else
                    strQuery += "null, "
                End If
                strQuery += "'" + infoTarefasExtras.observacao + "')"
            ElseIf pstrOperacao = "alteracao" Then
                strQuery = "update admcontroleadministrativo " +
                              "set funcionario = '" + infoTarefasExtras.funcionario + "', " +
                                  "observacao = '" + infoTarefasExtras.observacao + "', " +
                                  "datavencimento = '" + infoTarefasExtras.datavencimento.Value.ToString("yyyy-MM-dd") + "' " +
                            "where exercicio = " + infoTarefasExtras.competencia.ToString.Substring(2, 4) + " " +
                              "and empresa = '" + infoTarefasExtras.empresa + "' " +
                              "and competencia = '" + infoTarefasExtras.competencia + "' " +
                              "and obrigacao = '" + infoTarefasExtras.obrigacao + "' " +
                              "and obrigacaoextra = -1 " +
                              "and sequenciaextra = " + infoTarefasExtras.sequenciaextra.ToString()
            ElseIf pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admcontroleadministrativo " +
                            "where exercicio = " + infoTarefasExtras.competencia.ToString.Substring(2, 4) + " " +
                              "and empresa = '" + infoTarefasExtras.empresa + "' " +
                              "and competencia = '" + infoTarefasExtras.competencia + "' " +
                              "and obrigacao = '" + infoTarefasExtras.obrigacao + "' " +
                              "and obrigacaoextra = -1 " +
                              "and sequenciaextra = " + infoTarefasExtras.sequenciaextra.ToString()
            End If
            objDataBase.NonQuery(strQuery)
            SincronizarEmpresaUsuarioObrigacaoTarefaExtra(infoTarefasExtras.empresa, infoTarefasExtras.obrigacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ProximaTarefa(ByRef pstrEmpresa As String, ByRef pstrObrigacao As String) As Integer Implements ITarefasExtras.ProximaTarefa
        Try
            Dim objDataBase As New DataBaseDAL

            Return objDataBase.QuerySimples("select coalesce(max(sequenciaextra),0) + 1 " +
                                              "from admcontroleadministrativo " +
                                             "where empresa = '" + pstrEmpresa + "' " +
                                               "and obrigacao = '" + pstrObrigacao + "' " +
                                               "and competencia = '" + administrativoInfo.Competencia.ToString + "' " +
                                               "and exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                               "and obrigacaoextra = -1")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Sub BuscaVencimento(ByRef pstrEstado As String, ByRef pstrMunicipio As String, pDataVencimentoDateEdit As DevExpress.XtraEditors.DateEdit, ByRef pstrCompetencia As String, ByRef pstrPeriodicidade As String, ByRef pintDiaVencimento As Integer, ByRef pstrTipoDia As String, ByRef pintSabDomUtil As Integer, ByRef pintAntecipaUtil As Integer, ByRef pintSubsequente As Integer, ByRef pstrTipoSubsequente As String) Implements ITarefasExtras.BuscaVencimento
        Try
            Dim objDataBase As New DataBaseDAL

            Dim dtaDataVencimento As Nullable(Of DateTime)
            dtaDataVencimento = objDataBase.QuerySimples("select gd_datavencimento('" + pstrEstado + "', '" + pstrMunicipio + "', '" + pstrCompetencia + "'," +
                                                                                  "'" + pstrPeriodicidade + "', " + pintDiaVencimento.ToString + ",'" + pstrTipoDia + "', " +
                                                                                        pintSabDomUtil.ToString + ", " + pintAntecipaUtil.ToString + ", " +
                                                                                        pintSubsequente.ToString + ", '" + pstrTipoSubsequente + "')")
            If dtaDataVencimento.HasValue Then
                pDataVencimentoDateEdit.EditValue = dtaDataVencimento
            Else
                pDataVencimentoDateEdit.EditValue = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaDados(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, pintSequenciaExtra As Integer) As Modelo.tarefasextrasInfo Implements ITarefasExtras.BuscaDados
        Try
            Dim infoTarefasExtras As New tarefasextrasInfo
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = "select aca.datavencimento, aca.funcionario, aca.observacao " +
                                       "from admcontroleadministrativo aca "
            strQuery += "where aca.exercicio = " + pintExercicio.ToString + " " +
                          "and aca.empresa = '" + pstrEmpresa + "' " +
                          "and aca.obrigacao = '" + pstrObrigacao + "' " +
                          "and aca.obrigacaoextra = -1 " +
                          "and aca.parcela = 0 " +
                          "and aca.sequenciaextra = " + pintSequenciaExtra.ToString()
            Dim sdData As SelectedData = objDataBase.QueryFull(strQuery)

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                infoTarefasExtras.datavencimento = row.Values(0)
                infoTarefasExtras.funcionario = Convert.ToString(row.Values(1))
                infoTarefasExtras.observacao = Convert.ToString(row.Values(2))
            Next row
            Return infoTarefasExtras
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Sub SincronizarEmpresaUsuarioObrigacaoTarefaExtra(ByRef pstrEmpresa As String, ByRef pstrObrigacao As String)
        Try
            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os dados com o portal")
                Dim objDataBase As New DataBaseDAL
                Dim strQuery As String = String.Empty
                Dim sdData As SelectedData
                Dim wsConsulta As New SelectWS
                Dim wsInclusao As New InsertWS
                Dim wsAlteracao As New UpdateWS
                Dim wsExclusao As New DeleteWS

                '------------------------------------------------------------------------------
                ' SINCRONIZANDO O CADASTRO DE USUÁRIOS DAS EMPRESAS
                '------------------------------------------------------------------------------
                ' NESSE PRIMEIRO PROCESSO SOMENTE INCLUI REGISTRO NA WEBSERVICE
                '------------------------------------------------------------------------------
                strQuery = "select au.empresa, au.nome, au.email, coalesce(au.ddd,'') as ddd, coalesce(au.telefone,'') as telefone " +
                         "from admusuariosempresassistemasportal au " +
                        "where au.empresa = '" + pstrEmpresa + "' " +
                     "order by 1, 3"

                sdData = objDataBase.QueryFull(strQuery)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    If wsConsulta.UsuarioEmpresaExiste(row.Values(0).ToString, row.Values(2).ToString) Then
                        wsAlteracao.AlterarUsuariosEmpresas(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString, row.Values(4).ToString)
                    Else
                        wsInclusao.IncluiUsuarioEmpresa(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString, row.Values(4).ToString)
                    End If
                    Dim strSubQuery As String = "select emp.obrigacao " +
                                             "from admusuariosempresassistemasitensportal usu " +
                                             "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                     "from (select empresa, obrigacao " +
                                                             "from admcontroleadministrativo " +
                                                            "where empresa = '" + row.Values(0).ToString + "' " +
                                                              "and obrigacao = '" + pstrObrigacao + "' " +
                                                              "and obrigacaoextra = -1 " +
                                                         "group by empresa, obrigacao) aoe " +
                                                     "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                 "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema " +
                                            "where usu.empresa = '" + row.Values(0).ToString + "' " +
                                              "and usu.email = '" + row.Values(2).ToString + "' " +
                                         "order by 1"
                    Dim sdSubData As SelectedData = objDataBase.QueryFull(strSubQuery)

                    For Each subrow As SelectStatementResultRow In sdSubData.ResultSet(1).Rows
                        If Not wsConsulta.EmpresaUsuarioObrigacaoExiste(row.Values(0).ToString, subrow.Values(0).ToString, row.Values(2).ToString) Then
                            wsInclusao.IncluirEmpresaUsuarioObrigacoes(row.Values(0).ToString, subrow.Values(0).ToString, row.Values(2).ToString)
                        End If
                    Next subrow
                Next row

                '------------------------------------------------------------------------------
                ' SINCRONIZANDO O CADASTRO DE OBRIGAÇÕES DOS USUÁRIOS DAS EMPRESAS
                '------------------------------------------------------------------------------
                ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
                '------------------------------------------------------------------------------
                Dim strDadosObrigacaoUsuarioEmpresa As String = wsConsulta.EmpresaUsuarioObrigacaoRetornaDados(pstrEmpresa, String.Empty, pstrObrigacao)
                Dim strQueryObrigacaoUsuarioEmpresaWS As String = String.Empty
                If Not String.IsNullOrEmpty(strDadosObrigacaoUsuarioEmpresa) Then
                    Dim aLista() As String = strDadosObrigacaoUsuarioEmpresa.Split("|")
                    For iLista = 0 To aLista.Length - 1
                        Dim aCampos() As String = aLista(iLista).Split(",")
                        If Not String.IsNullOrEmpty(strQueryObrigacaoUsuarioEmpresaWS) Then
                            strQueryObrigacaoUsuarioEmpresaWS += " union all "
                        End If
                        strQueryObrigacaoUsuarioEmpresaWS += "select cast('" + aCampos(1).ToString + "' as varchar) as empresa, cast('" + aCampos(2).ToString + "' as varchar) as email, cast('" + aCampos(3).ToString + "' as varchar) as obrigacao"
                    Next
                    strQueryObrigacaoUsuarioEmpresaWS = "select cast('WS' as varchar) as origem, cast(a.empresa as varchar) as empresa, cast(a.email as varchar) as email, cast(a.obrigacao as varchar) as obrigacao from (" + strQueryObrigacaoUsuarioEmpresaWS + ") a"
                    Dim strResultadoObrigacaoUsuarioEmpresa As String = "select empresa, email, obrigacao " +
                                           "from (" +
                                                  "select total.empresa, total.email, total.obrigacao, case when (coalesce(local.empresa,'') = '' and coalesce(ws.empresa,'') <> '') and (coalesce(local.email,'') = '' and coalesce(ws.email,'') <> '') and (coalesce(local.obrigacao,'') = '' and coalesce(ws.obrigacao,'') <> '') then -1 else 0 end as resultado " +
                                                    "from (" + strQueryObrigacaoUsuarioEmpresaWS.Replace("cast('WS' as varchar) as origem,", String.Empty) + " union " +
                                                           "select usu.empresa, usu.email, emp.obrigacao " +
                                                             "from admusuariosempresassistemasitensportal usu " +
                                                             "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                                     "from (select empresa, obrigacao " +
                                                                             "from admcontroleadministrativo " +
                                                                            "where empresa = '" + pstrEmpresa + "' " +
                                                                              "and obrigacao = '" + pstrObrigacao + "' " +
                                                                              "and obrigacaoextra = -1 " +
                                                                         "group by empresa, obrigacao) aoe " +
                                                                     "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                                 "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema) total " +
                                      "left join (select cast('LOCAL' as varchar) as origem, a.empresa, a.email, a.obrigacao " +
                                                   "from (select usu.empresa, usu.email, emp.obrigacao " +
                                                           "from admusuariosempresassistemasitensportal usu " +
                                                           "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                                   "from (select empresa, obrigacao " +
                                                                           "from admcontroleadministrativo " +
                                                                          "where empresa = '" + pstrEmpresa + "' " +
                                                                            "and obrigacao = '" + pstrObrigacao + "' " +
                                                                            "and obrigacaoextra = -1 " +
                                                                       "group by empresa, obrigacao) aoe " +
                                                                   "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                       "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema) a) local on local.empresa = total.empresa And local.email = total.email And local.obrigacao = total.obrigacao " +
                                      "left join (" + strQueryObrigacaoUsuarioEmpresaWS + ") ws on ws.empresa = total.empresa And ws.email = total.email And ws.obrigacao = total.obrigacao) r " +
                                           "where r.resultado = -1"

                    sdData = objDataBase.QueryFull(strResultadoObrigacaoUsuarioEmpresa)
                    For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                        If wsConsulta.EmpresaUsuarioObrigacaoExiste(row.Values(0).ToString, row.Values(2).ToString, row.Values(1).ToString) Then
                            wsExclusao.EmpresaUsuarioObrigacaoExclui(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString)
                        End If
                    Next row
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class


