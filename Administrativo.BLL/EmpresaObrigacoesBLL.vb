Imports Administrativo.DAL
''' <summary>
''' Camada de negócio da classe EmpresaObrigacoesBLL.vb
''' </summary>
''' <remarks>
''' Nesta camada de negócio o sistema vai realizar as seguintes buscas:
''' Grid
''' IUDEmpresaObrigacoes
''' SincronizaEmpresaObrigacoes
''' Browse
''' RetornaDescricao
''' DefineValoresDefault
''' Report
''' GeracaoControleObrigacoes
''' SugereObrigacoes
''' </remarks>
Public Class EmpresaObrigacoesBLL
    Implements IEmpresaObrigacoes

    Dim objEmpresaObrigacoes As New EmpresaObrigacoesDAL

    ''' <summary>
    ''' Esta Sub faz manipulação dos dados para mostrar apresentar as Informações no Grid, que forma informadas no parâmetro "infoEmpresaObrigacoes"
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <param name="pdgGrid">Controle do Grid</param>
    ''' <param name="pgvGrid">Contrele de View da Grid</param>
    ''' <param name="infoEmpresaObrigacoes">Informação das empresas</param>
    ''' <remarks>Camada de negócio - Grid</remarks>
    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoEmpresaObrigacoes As System.Collections.Generic.List(Of Modelo.empresaobrigacoes)) Implements DAL.IEmpresaObrigacoes.Grid
        Try
            objEmpresaObrigacoes.Grid(pstrQuery, pdgGrid, pgvGrid, infoEmpresaObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Esta Sub faz manipulação dos dados para mostrar apresentar as Informações no Grid
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <param name="pdgGrid">Controle do Grid</param>
    ''' <param name="pgvGrid">Contrele de View da Grid</param>
    ''' <remarks>Camada de negócio - Grid</remarks>
    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements DAL.IEmpresaObrigacoes.Grid
        Try
            objEmpresaObrigacoes.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, prcRibbonControl)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Manipula os dados no banco de dados. Com a função especificada no pstrOperacao, ele irá manipular no banco conforme o que se encontra no Objeto infoEmpresaObrigacoes
    ''' </summary>
    ''' <param name="pstrOperacao">É o tipo de operação: "exclusao". E se for diferente ele vai fazer "update" ou "insert"</param>
    ''' <param name="infoEmpresaObrigacoes">Objeto de "empresaobrigacoesInfo"</param>
    ''' <param name="originalinfoEmpresaObrigacoes">Componente de List. Lista de obrigações.</param>
    ''' <remarks>Camada de negócio - IUDEmpresaObrigacoes</remarks>
    Public Sub IUDEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoEmpresaObrigacoes As Modelo.empresaobrigacoesInfo, ByRef originalinfoEmpresaObrigacoes As System.Collections.Generic.List(Of Modelo.empresaobrigacoes)) Implements DAL.IEmpresaObrigacoes.IUDEmpresaObrigacoes
        Try
            If String.IsNullOrEmpty(infoEmpresaObrigacoes.empresa) Then Throw New Exception("A empresa deve ser preenchida")
            If infoEmpresaObrigacoes.obrigacoes.Count = 0 Then Throw New Exception("Deve incluir pelo menos uma obrigação")
            objEmpresaObrigacoes.IUDEmpresaObrigacoes(pstrOperacao, infoEmpresaObrigacoes, originalinfoEmpresaObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Manipula os dados no banco de dados. Com a função especificada no pstrOperacao, ele irá manipular no banco conforme o que se encontra no Objeto infoEmpresaObrigacoes
    ''' </summary>
    ''' <param name="pstrOperacao">É o tipo de operação: "exclusao". E se for diferente ele vai fazer "update" e "insert"</param>
    ''' <param name="infoEmpresaObrigacoes">Objeto de "empresaobrigacoesInfo"</param>
    ''' <remarks>Camada de negócio - SincronizaEmpresaObrigacoes</remarks>
    Public Sub SincronizaEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoEmpresaObrigacoes As Modelo.empresaobrigacoesInfo) Implements DAL.IEmpresaObrigacoes.SincronizaEmpresaObrigacoes
        Try
            objEmpresaObrigacoes.SincronizaEmpresaObrigacoes(pstrOperacao, infoEmpresaObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Monta um relatório de Empresa Obrigação
    ''' </summary>
    ''' <param name="pstrCampoInicialEmpresa">Parametro de Inicial Empresa</param>
    ''' <param name="pstrCampoFinalEmpresa">Parametro de Final Empresa</param>
    ''' <param name="pstrCampoInicialObrigacao">Parametro de Inicial Obrigacao</param>
    ''' <param name="pstrCampoFinalObrigacao">Parametro de Final Obrigacao</param>
    ''' <param name="pstrTipoLucro">Parametro Tipo do Lucro</param>
    ''' <param name="pstrTipoEmpresa">Parametro Tipo de Empresa</param>
    ''' <param name="pReport">Recebe o resultado da Query para montar um relatório</param> 
    ''' <remarks>Camada de negócio - Report</remarks>
    Public Sub Report(ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByRef pstrCampoInicialObrigacao As String, ByRef pstrCampoFinalObrigacao As String, ByRef pstrTipoLucro As String, ByRef pstrTipoEmpresa As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements DAL.IEmpresaObrigacoes.Report
        If String.IsNullOrEmpty(pstrCampoInicialEmpresa) Then Throw New Exception("O código da empresa inicial deve ser informada")
        If String.IsNullOrEmpty(pstrCampoFinalEmpresa) Then Throw New Exception("O código da empresa final deve ser informada")
        If String.IsNullOrEmpty(pstrCampoInicialObrigacao) Then Throw New Exception("O código da obrigação inicial deve ser informada")
        If String.IsNullOrEmpty(pstrCampoFinalObrigacao) Then Throw New Exception("O código da obrigação final deve ser informada")
        If pstrCampoFinalEmpresa < pstrCampoInicialEmpresa Then Throw New Exception("O código da empresa final deve ser maior que o código da empresa inicial")
        If pstrCampoFinalObrigacao < pstrCampoInicialObrigacao Then Throw New Exception("O código da obrigação final deve ser maior que o código da obrigação inicial")
        objEmpresaObrigacoes.Report(pstrCampoInicialEmpresa, pstrCampoFinalEmpresa, pstrCampoInicialObrigacao, pstrCampoFinalObrigacao, pstrTipoLucro, pstrTipoEmpresa, pReport)
    End Sub

    ''' <summary>
    ''' Cadastra as novas obrigações
    ''' </summary>
    ''' <param name="pstrEmpresa">Empresa</param>
    ''' <param name="pstrCompetencia">Competencia</param>
    ''' <param name="pintExercicio">Exercicio</param>
    ''' <param name="pstrObrigacao">Obrigação</param>
    ''' <param name="pblnExcluiControleObrigacao">Opção para excluir todas as obrigações.</param>
    ''' <remarks>Camada de negócio - GeracaoControleObrigacoes</remarks>
    Public Sub GeracaoControleObrigacoes(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, ByRef pblnExcluiControleObrigacao As Boolean) Implements DAL.IEmpresaObrigacoes.GeracaoControleObrigacoes
        Try
            If String.IsNullOrEmpty(pstrEmpresa) Then Throw New Exception("A Empresa deve ser informada")
            If String.IsNullOrEmpty(pstrCompetencia) Then Throw New Exception("A Competência deve ser informada")
            objEmpresaObrigacoes.GeracaoControleObrigacoes(pstrEmpresa, pstrCompetencia, pintExercicio, pstrObrigacao, pblnExcluiControleObrigacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Seleciona as possiveis Obrigações.
    ''' </summary>
    ''' <param name="pstrEmpresa">Empresa</param>
    ''' <param name="pstrEmpresaAux">Competencia</param>
    ''' <param name="pstrRazaoSocialAux"></param>
    ''' <returns></returns>
    ''' <remarks>Camada de negócio - SugereObrigacoes</remarks>
    Public Function SugereObrigacoes(ByRef pstrEmpresa As String, ByRef pstrEmpresaAux As String, ByRef pstrRazaoSocialAux As String) As String Implements DAL.IEmpresaObrigacoes.SugereObrigacoes
        Try
            Return objEmpresaObrigacoes.SugereObrigacoes(pstrEmpresa, pstrEmpresaAux, pstrRazaoSocialAux)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
