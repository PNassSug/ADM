Imports Administrativo.DAL

Public Class ObrigacoesBLL
    Implements IObrigacoes

    Dim objObrigacoes As New ObrigacoesDAL

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView,
                    pgvGridItem As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridCpr As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridIss As DevExpress.XtraGrid.Views.Grid.GridView,
                    pgvGridEiss As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridIe As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridCnpj As DevExpress.XtraGrid.Views.Grid.GridView) Implements DAL.IObrigacoes.Grid
        Try
            objObrigacoes.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, pgvGridItem, pgvGridCpr, pgvGridIss, pgvGridEiss, pgvGridIe, pgvGridCnpj)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDObrigacoes(ByRef pstrOperacao As String, ByRef infoObrigacoes As Modelo.obrigacoesInfo, ByRef originalinfoVariacao As System.Collections.Generic.List(Of Modelo.obrigacoesvariacao)) Implements DAL.IObrigacoes.IUDObrigacoes
        Try
            If String.IsNullOrEmpty(infoObrigacoes.descricao) Then Throw New Exception("A descrição da obrigação deve ser preenchida")
            If String.IsNullOrEmpty(infoObrigacoes.sistema) Then Throw New Exception("O sistema deve ser preenchido")
            objObrigacoes.IUDObrigacoes(pstrOperacao, infoObrigacoes, originalinfoVariacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarObrigacoes(ByRef pstrOperacao As String, ByRef infoObrigacoes As Modelo.obrigacoesInfo) Implements DAL.IObrigacoes.SincronizarObrigacoes
        Try
            objObrigacoes.SincronizarObrigacoes(pstrOperacao, infoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ProximaObrigacao() As String Implements DAL.IObrigacoes.ProximaObrigacao
        Try
            Return objObrigacoes.ProximaObrigacao
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Report(ByRef pstrCampoInicial As String, ByRef pstrCampoFinal As String, ByRef pstrPeriodicidade As String, ByRef pstrTributo As String, ByVal pstrSistema As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements DAL.IObrigacoes.Report
        If String.IsNullOrEmpty(pstrCampoInicial) Then Throw New Exception("O código da obrigação inicial deve ser informada")
        If String.IsNullOrEmpty(pstrCampoFinal) Then Throw New Exception("O código da obrigação final deve ser informada")
        If pstrCampoFinal < pstrCampoInicial Then Throw New Exception("O código da obrigação final deve ser maior que o código da obrigação inicial")
        objObrigacoes.Report(pstrCampoInicial, pstrCampoFinal, pstrPeriodicidade, pstrTributo, pstrSistema, pReport)
    End Sub

    Public Sub Report(ByRef pstrCampoInicial As String, ByRef pstrCampoFinal As String, ByRef pstrPeriodicidade As String, ByRef pstrTributo As String, ByVal pstrSistema As String, pReport As DevExpress.XtraReports.UI.XtraReport, ByVal pblnResumido As Boolean) Implements DAL.IObrigacoes.Report
        If String.IsNullOrEmpty(pstrCampoInicial) Then Throw New Exception("O código da obrigação inicial deve ser informada")
        If String.IsNullOrEmpty(pstrCampoFinal) Then Throw New Exception("O código da obrigação final deve ser informada")
        If pstrCampoFinal < pstrCampoInicial Then Throw New Exception("O código da obrigação final deve ser maior que o código da obrigação inicial")
        objObrigacoes.Report(pstrCampoInicial, pstrCampoFinal, pstrPeriodicidade, pstrTributo, pstrSistema, pReport, pblnResumido)
    End Sub

    Public Sub IUDObrigacoesUsuarios(ByRef pstrOperacao As String, ByRef infoObrigacoesUsuarios As Modelo.obrigacoesusuariosInfo, ByRef originalinfoObrigacoes As System.Collections.Generic.List(Of Modelo.obrigacoesusuarios)) Implements DAL.IObrigacoes.IUDObrigacoesUsuarios
        Try
            If String.IsNullOrEmpty(infoObrigacoesUsuarios.usuario) Then Throw New Exception("O usuário deve ser preenchido")
            If infoObrigacoesUsuarios.obrigacoes.Count = 0 Then Throw New Exception("Deve incluir pelo menos uma obrigação")
            Dim objDataBase As New DataBaseBLL
            If pstrOperacao = "inclusao" Then
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                   "from admobrigacoesusuarios aou " +
                                                                   "where aou.usuario = '" + infoObrigacoesUsuarios.usuario + "'")
                If (intCount > 0) Then Throw New Exception("Já existe obrigações configuradas para esse usuário")
            End If
            objObrigacoes.IUDObrigacoesUsuarios(pstrOperacao, infoObrigacoesUsuarios, originalinfoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoObrigacoes As System.Collections.Generic.List(Of Modelo.obrigacoesusuarios)) Implements DAL.IObrigacoes.Grid
        Try
            objObrigacoes.Grid(pstrQuery, pdgGrid, pgvGrid, infoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements DAL.IObrigacoes.Grid
        Try
            objObrigacoes.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, prcRibbonControl)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoVariacao As System.Collections.Generic.List(Of Modelo.obrigacoesvariacao), ByRef pstrVariacao As String) Implements DAL.IObrigacoes.Grid
        Try
            objObrigacoes.Grid(pstrQuery, pdgGrid, pgvGrid, infoVariacao, pstrVariacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function RetornaLayoutObrigacao(ByRef pstrObrigacao As String) As Integer Implements DAL.IObrigacoes.RetornaLayoutObrigacao
        Try
            Return objObrigacoes.RetornaLayoutObrigacao(pstrObrigacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
