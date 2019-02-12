Imports Administrativo.DAL
''' <summary>
''' Camada de negócio da classe DataBaseBLL.vb
''' </summary>
''' <remarks>
''' Nesta camada de negócio o sistema vai realizar as seguintes buscas:
''' ValidaObrigacao
''' Browse
''' DefineValoresDefault
''' Grid
''' RetornaDescricao
''' ProximaMaladireta
''' IUDMaladireta
''' CarregaCombopalavraReservada
''' CarregaPalavraReservada
''' CarregaMensagem
''' </remarks>
Public Class MaladiretaBLL
    Implements IMaladireta

    Dim objMaladireta As New MaladiretaDAL
    ''' <summary>
    ''' Valida a obrigação, verificando se ele esta vinculada a outra obrigação
    ''' </summary>
    ''' <param name="pstrQuery"></param>
    ''' <remarks>Camada de negócio - ValidaObrigacao</remarks>
    Public Sub ValidaObrigacao(ByVal pstrQuery As String) Implements DAL.IMaladireta.ValidaObrigacao
        Try
            objMaladireta.ValidaObrigacao(pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrQuery"></param>
    ''' <param name="pstrTituloGrid"></param>
    ''' <param name="pdgGrid"></param>
    ''' <param name="pgvGrid"></param>
    ''' <remarks>Camada de negócio - Grid </remarks>
    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements DAL.IMaladireta.Grid
        Try
            objMaladireta.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, prcRibbonControl)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrQuery"></param>
    ''' <param name="pdgGrid"></param>
    ''' <param name="pgvGrid"></param>
    ''' <param name="infoObrigacoes"></param>
    ''' <remarks>Camada de negócio - Grid</remarks>
    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoObrigacoes As System.Collections.Generic.List(Of Modelo.maladiretaobrigacoesinfo)) Implements DAL.IMaladireta.Grid
        Try
            objMaladireta.Grid(pstrQuery, pdgGrid, pgvGrid, infoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Camada de negócio - ProximaMaladireta</remarks>
    Public Function ProximaMaladireta() As Integer Implements DAL.IMaladireta.ProximaMaladireta
        Try
            Return objMaladireta.ProximaMaladireta()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrOperacao"></param>
    ''' <param name="infoMaladireta"></param>
    ''' <param name="originalinfoObrigacoes"></param>
    ''' <remarks>Camada de negócio - IUDMaladireta</remarks>
    Public Sub IUDMaladireta(ByRef pstrOperacao As String, ByRef infoMaladireta As Modelo.maladiretainfo, ByRef originalinfoObrigacoes As System.Collections.Generic.List(Of Modelo.maladiretaobrigacoesinfo)) Implements DAL.IMaladireta.IUDMaladireta
        If String.IsNullOrEmpty(infoMaladireta.mensagem) Then Throw New Exception("A mensagem da Mala Direta deve ser preenchida")
        objMaladireta.IUDMaladireta(pstrOperacao, infoMaladireta, originalinfoObrigacoes)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pComboBox"></param>
    ''' <remarks>Camada de negócio - CarregaCombopalavraReservada</remarks>
    Public Sub CarregaCombopalavraReservada(pComboBox As DevExpress.XtraEditors.ComboBoxEdit) Implements DAL.IMaladireta.CarregaCombopalavraReservada
        Try
            objMaladireta.CarregaCombopalavraReservada(pComboBox)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pListBox"></param>
    ''' <param name="pstrCategoria"></param>
    ''' <remarks>Camada de negócio - CarregaListaPalavraReservada</remarks>
    Public Sub CarregaListaPalavraReservada(pListBox As DevExpress.XtraEditors.ListBoxControl, pstrCategoria As String) Implements DAL.IMaladireta.CarregaListaPalavraReservada
        Try
            objMaladireta.CarregaListaPalavraReservada(pListBox, pstrCategoria)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrCategoria"></param>
    ''' <param name="pstrNome"></param>
    ''' <returns></returns>
    ''' <remarks>Camada de negócio - CarregaPalavraReservada</remarks>
    Public Function CarregaPalavraReservada(pstrCategoria As String, pstrNome As String) As String Implements DAL.IMaladireta.CarregaPalavraReservada
        Try
            Return objMaladireta.CarregaPalavraReservada(pstrCategoria, pstrNome)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrObrigacao"></param>
    ''' <param name="pstrCompetencia"></param>
    ''' <param name="pstrEmpresa"></param>
    ''' <param name="pintObrigacaoextra"></param>
    ''' <param name="pintSequenciaextra"></param>
    ''' <param name="pintParcela"></param>
    ''' <returns></returns>
    ''' <remarks>Camada de negócio - CarregaMensagem</remarks>
    Public Function CarregaMensagem(pstrObrigacao As String, pstrCompetencia As String, pstrEmpresa As String, pintObrigacaoextra As Int32, pintSequenciaextra As Int32, pintParcela As Int32, pintInforme As Int32) As String Implements DAL.IMaladireta.CarregaMensagem
        Try
            Return objMaladireta.CarregaMensagem(pstrObrigacao, pstrCompetencia, pstrEmpresa, pintObrigacaoextra, pintSequenciaextra, pintParcela, pintInforme)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class

