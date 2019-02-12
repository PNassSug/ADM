Imports Administrativo.Modelo

Public Class GruposAcessoDAL
    Implements IGruposAcesso

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView) Implements IGruposAcesso.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            pdgGrid.DataSource = objDataBase.QueryDataView(pstrQuery)

            ' Definição de Mascarás no Grid
            pgvGrid.Columns(0).Caption = "Grupo"
            pgvGrid.Columns(0).Width = 130

            pdgGrid.ForceInitialize()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub IUDGruposAcesso(ByRef pstrOperacao As String, ByRef infoGruposAcesso As Modelo.gruposacessoInfo) Implements IGruposAcesso.IUDGruposAcesso
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim strDelete As String = String.Empty

            strQuery = "delete " +
                          "from gruposacesso " +
                         "where sistema = '" + infoGruposAcesso.sistema.ToString + "' " +
                           "and grupo = '" + infoGruposAcesso.grupo.ToString + "';"

            If pstrOperacao = "inclusao" Or pstrOperacao = "alteracao" Then
                For iItem = 0 To infoGruposAcesso.opcao.Count - 1
                    If infoGruposAcesso.opcao(iItem).opcao <> String.Empty Then
                        If Not String.IsNullOrEmpty(strQuery) Then
                            strQuery += Chr(13) + Chr(10)
                        End If
                        strQuery += "insert into gruposacesso(sistema, grupo, opcao, operacoes, descricao, incuser, incdata, altuser, altdata) " +
                                                     "values ('" + infoGruposAcesso.sistema.ToString + "', " +
                                                             "'" + infoGruposAcesso.grupo.ToString + "', " +
                                                             "'" + infoGruposAcesso.opcao(iItem).opcao.ToString + "', " +
                                                                     infoGruposAcesso.opcao(iItem).operacao.ToString + ", " +
                                                             "'" + infoGruposAcesso.opcao(iItem).descricao.ToString + "', " +
                                                             "'" + usuarioInfo.Usuario + "', current_timestamp, " +
                                                             "'" + usuarioInfo.Usuario + "', current_timestamp);"
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

    Public Sub VisualizaGrupoAcesso(ByRef pstrQuery As String, ByRef pstrCampoPai As String, ByRef pstrCampoFilho As String, ptlGrupoAcesso As DevExpress.XtraTreeList.TreeList) Implements IGruposAcesso.VisualizaGrupoAcesso
        Try
            Dim objDataBase As New DataBaseDAL
            ptlGrupoAcesso.DataSource = objDataBase.QueryDataView(pstrQuery)
            ptlGrupoAcesso.Columns("descricao").Caption = "Grupo de Acesso"
            ptlGrupoAcesso.Columns("opcao").Visible = False
            ptlGrupoAcesso.Columns("operacoes").Visible = False
            ptlGrupoAcesso.Columns("checado").Visible = False
            ptlGrupoAcesso.KeyFieldName = pstrCampoPai
            ptlGrupoAcesso.ParentFieldName = pstrCampoFilho
            ptlGrupoAcesso.ExpandAll()
            ptlGrupoAcesso.OptionsView.ShowCheckBoxes = True
            ptlGrupoAcesso.CheckAll()
            ptlGrupoAcesso.OptionsBehavior.AllowRecursiveNodeChecking = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
