Imports Administrativo.DAL
''' <summary>
''' Camada de negócio da classe SincronizarlogportalBLL.vb
''' </summary>
''' <remarks>
''' Nesta camada de negócio o sistema vai realizar as seguintes Funções:
''' Browse
''' DefineValoresDefault
''' BuscaControleAdministrativo
''' RetornaDescricao
''' Report
''' </remarks>
Public Class SincronizarlogportalBLL
    Implements ISincronizarlogportal

    Dim objSincronizarlogportal As New SincronizarlogportalDAL

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
    ''' Busca os logs na WebService, a fim de atualizar o banco de dados
    ''' </remarks>
    Public Sub BuscaControleAdministrativo(pstrCompetenciaInicial As String, pstrCompetenciaFinal As String, pstrEmpresaInicial As String, pstrEmpresaFinal As String, pstrObrigacaoInicial As String, pstrObrigacaoFinal As String) Implements DAL.ISincronizarlogportal.BuscaControleAdministrativo
        Try
            If String.IsNullOrEmpty(pstrCompetenciaInicial) Xor String.IsNullOrEmpty(pstrCompetenciaFinal) Then
                Throw New Exception("Preencha as Competências ou deixe-as vazias!")
            End If
            If String.IsNullOrEmpty(pstrEmpresaInicial) Xor String.IsNullOrEmpty(pstrEmpresaFinal) Then
                Throw New Exception("Preencha as Empresas ou deixe-as vazias!")
            End If
            If String.IsNullOrEmpty(pstrObrigacaoInicial) Xor String.IsNullOrEmpty(pstrObrigacaoFinal) Then
                Throw New Exception("Preencha as Obrigações ou deixe-as vazias!")
            End If
            objSincronizarlogportal.BuscaControleAdministrativo(pstrCompetenciaInicial, pstrCompetenciaFinal, pstrEmpresaInicial, pstrEmpresaFinal, pstrObrigacaoInicial, pstrObrigacaoFinal)
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
    Public Sub Report(pstrCompetenciaInicial As String, pstrCompetenciaFinal As String, pstrEmpresaInicial As String, pstrEmpresaFinal As String, pstrObrigacaoInicial As String, pstrObrigacaoFinal As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements DAL.ISincronizarlogportal.Report
        Try
            If String.IsNullOrEmpty(pstrCompetenciaInicial) Xor String.IsNullOrEmpty(pstrCompetenciaFinal) Then
                Throw New Exception("Preencha as Competências ou deixe-as vazias!")
            End If
            If String.IsNullOrEmpty(pstrEmpresaInicial) Xor String.IsNullOrEmpty(pstrEmpresaFinal) Then
                Throw New Exception("Preencha as Empresas ou deixe-as vazias!")
            End If
            If String.IsNullOrEmpty(pstrObrigacaoInicial) Xor String.IsNullOrEmpty(pstrObrigacaoFinal) Then
                Throw New Exception("Preencha as Obrigações ou deixe-as vazias!")
            End If
            objSincronizarlogportal.Report(pstrCompetenciaInicial, pstrCompetenciaFinal, pstrEmpresaInicial, pstrEmpresaFinal, pstrObrigacaoInicial, pstrObrigacaoFinal, pReport)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
