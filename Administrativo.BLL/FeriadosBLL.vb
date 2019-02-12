Imports Administrativo.DAL
''' <summary>
''' Camada de negócio da classe FeriadosBLL.vb
''' </summary>
''' <remarks></remarks>
Public Class FeriadosBLL
    Implements IFeriados

    Dim objFeriados As New FeriadosDAL
    ''' <summary>
    ''' Cria marcação no calendário no controle SchedulerControl
    ''' </summary>
    ''' <param name="pstrQuery">Query para carregar no calendário</param>
    ''' <param name="psccFeriados">Controle do calendário</param>
    ''' <remarks>Camada de negócio - CriaFeriados</remarks>
    Public Sub CriaFeriados(ByRef pstrQuery As String, psccFeriados As DevExpress.XtraScheduler.SchedulerControl) Implements DAL.IFeriados.CriaFeriados
        Try
            objFeriados.CriaFeriados(pstrQuery, psccFeriados)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Esta Sub faz manipulação dos dados para mostrar apresentar as Informações no Grid
    ''' </summary>
    ''' <param name="pstrQuery">Query para consulta</param>
    ''' <param name="pdgGrid">Controle do Grid</param>
    ''' <param name="pgvGrid">Contrele de View da Grid</param>
    ''' <param name="infoFiltro">Filtro para o preenchimento do grid</param>
    ''' <param name="pstrVariacao">"Municipal","Estadual"</param>
    ''' <remarks>Camada de negócio - Grid</remarks>
    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoFiltro As System.Collections.Generic.List(Of Modelo.feriadosfiltro), ByRef pstrVariacao As String) Implements DAL.IFeriados.Grid
        Try
            objFeriados.Grid(pstrQuery, pdgGrid, pgvGrid, infoFiltro, pstrVariacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Manipula os dados no banco de dados. Com a função especificada no pstrOperacao, ele irá manipular no banco conforme o que se encontra no Objeto infoEmpresaObrigacoes
    ''' </summary>
    ''' <param name="pstrOperacao">É o tipo de operação: "exclusao". E se for diferente ele vai fazer "update" ou "insert"</param>
    ''' <param name="infoFeriados">Objeto de "infoFeriados"</param>
    ''' <param name="originalinfoFiltro">Componente de List. Lista de obrigações.</param>
    ''' <remarks>Camada de negócio - IUDFeriados</remarks>
    Public Sub IUDFeriados(ByRef pstrOperacao As String, ByRef infoFeriados As Modelo.feriadosInfo, ByRef originalinfoFiltro As System.Collections.Generic.List(Of Modelo.feriadosfiltro)) Implements DAL.IFeriados.IUDFeriados
        Try
            If String.IsNullOrEmpty(infoFeriados.descricao) Then Throw New Exception("É obrigatório o preenchimento da Descrição")
            If String.IsNullOrEmpty(infoFeriados.tipoferiado) Then Throw New Exception("É obrigatório o preenchimento do Tipo de Feriado")
            If String.IsNullOrEmpty(infoFeriados.data) Or infoFeriados.data.Length < 5 Then Throw New Exception("É obrigatório o preenchimento da data")
            If infoFeriados.tipoferiado = "M" Or infoFeriados.tipoferiado = "E" Then
                Dim strMensagem As String = String.Empty
                If infoFeriados.tipoferiado = "M" Then
                    strMensagem = "Munícipios"
                ElseIf infoFeriados.tipoferiado = "E" Then
                    strMensagem = "Estados"
                End If
                If infoFeriados.filtro.Count = 0 Then Throw New Exception("Deverá existir pelo menos um registro na Relação de " + strMensagem)
            End If

            If pstrOperacao = "inclusao" Then
                Dim objDataBase As New DataBaseBLL
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                   "from admferiados af " +
                                                                   "where af.dataferiado = '" + infoFeriados.data + "' " +
                                                                     "and af.tipoferiado = '" + infoFeriados.tipoferiado + "' " +
                                                                     "and af.tipodata = '" + infoFeriados.tipodata + "'")
                If (intCount > 0) Then Throw New Exception("Feriado já existente")
            End If

            objFeriados.IUDFeriados(pstrOperacao, infoFeriados, originalinfoFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Apaga o feriado do banco, e remove do calendário
    ''' </summary>
    ''' <param name="paptFeriados">contole do XtraScheduler Appointment</param>
    ''' <param name="psccFeriados">contole do XtraScheduler SchedulerStorage</param>
    ''' <remarks>Camada de negócio - ApagaFeriados</remarks>
    Public Sub ApagaFeriados(paptFeriados As DevExpress.XtraScheduler.Appointment, psccFeriados As DevExpress.XtraScheduler.SchedulerStorage) Implements DAL.IFeriados.ApagaFeriados
        Try
            objFeriados.ApagaFeriados(paptFeriados, psccFeriados)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' atualiza a informação no XtraScheduler Appointment, com tipo de feriado e a descrição
    ''' </summary>
    ''' <param name="pstrDescricao">Descricao</param>
    ''' <param name="pstrLocalizacao">Localizacao</param>
    ''' <param name="pstrTipoFeriado">Tipo Feriado</param>
    ''' <param name="paptFeriados">tipo do controle XtraScheduler</param>
    ''' <remarks>Camada de negócio - Feriados</remarks>
    Public Sub Feriados(ByRef pstrDescricao As String, ByRef pstrLocalizacao As String, ByRef pstrTipoFeriado As String, paptFeriados As DevExpress.XtraScheduler.Appointment) Implements DAL.IFeriados.Feriados
        Try
            objFeriados.Feriados(pstrDescricao, pstrLocalizacao, pstrTipoFeriado, paptFeriados)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' atualiza a informação no XtraScheduler SchedulerStorage, com tipo de feriado e a descrição
    ''' </summary>
    ''' <param name="pdtaDataFeriado">Data Feriado</param>
    ''' <param name="pstrDescricao">Descricao</param>
    ''' <param name="pstrLocalizacao">Localizacao</param>
    ''' <param name="pstrTipoData">Tipo Data</param>
    ''' <param name="pstrTipoFeriado">Tipo Feriado</param>
    ''' <param name="psccFeriados">XtraScheduler SchedulerStorage</param>
    ''' <remarks>Camada de negócio - Feriados</remarks>
    Public Sub Feriados(ByRef pdtaDataFeriado As Date, ByRef pstrDescricao As String, ByRef pstrLocalizacao As String, ByRef pstrTipoData As String, ByRef pstrTipoFeriado As String, psccFeriados As DevExpress.XtraScheduler.SchedulerStorage) Implements DAL.IFeriados.Feriados
        Try
            objFeriados.Feriados(pdtaDataFeriado, pstrDescricao, pstrLocalizacao, pstrTipoData, pstrTipoFeriado, psccFeriados)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
