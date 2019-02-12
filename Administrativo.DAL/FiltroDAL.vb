Imports System.Windows.Forms
Imports Administrativo.Modelo

Public Class FiltroDAL
    Implements IFiltro

    Public Sub CarregaFiltro() Implements IFiltro.CarregaFiltro
        Dim objRegistro As New RegistroDAL
        Dim aRegistro = Split(objRegistro.LocalizaChaveRegistro("Software", Application.ProductName, "filtroXtraForm"), "|")

        filtroInfo.Filtrado = False
        filtroInfo.Filtrarpor = String.Empty
        filtroInfo.TipoVencimento = String.Empty
        filtroInfo.Dias = 0
        filtroInfo.DataInicial = Nothing
        filtroInfo.DataFinal = Nothing
        If aRegistro.Length > 1 Then
            filtroInfo.Filtrarpor = aRegistro(0).ToString
            If filtroInfo.Filtrarpor = "VENCIMENTO" Then
                filtroInfo.Filtrado = True
                filtroInfo.TipoVencimento = aRegistro(1).ToString
                If filtroInfo.TipoVencimento = "DIAS" Then
                    filtroInfo.Dias = Convert.ToInt32(aRegistro(2).ToString)
                ElseIf filtroInfo.TipoVencimento = "PERIODO" Then
                    filtroInfo.DataInicial = aRegistro(2)
                    filtroInfo.DataFinal = aRegistro(3)
                End If
            End If
        End If
    End Sub

    Public Function RetornaWhereFiltro(pstrTabela As String) As String Implements IFiltro.RetornaWhereFiltro
        Try
            Dim strWhere As String = String.Empty
            If filtroInfo.Filtrado Then
                If filtroInfo.Filtrarpor = "VENCIMENTO" Then
                    If filtroInfo.TipoVencimento = "DIAS" Then
                        If filtroInfo.Dias = 0 Then
                            strWhere = "extract(day from " + pstrTabela + ".datavencimento - current_date) = 0 "
                        ElseIf filtroInfo.Dias > 0 Then
                            strWhere = "extract(day from " + pstrTabela + ".datavencimento - current_date) <= " + filtroInfo.Dias.ToString + " and " +
                                       "extract(day from " + pstrTabela + ".datavencimento - current_date) >= 0 "
                        ElseIf filtroInfo.Dias < 0 Then
                            strWhere = "extract(day from " + pstrTabela + ".datavencimento - current_date) >= " + filtroInfo.Dias.ToString + " and " +
                                       "extract(day from " + pstrTabela + ".datavencimento - current_date) <= 0 "
                        End If
                    ElseIf filtroInfo.TipoVencimento = "PERIODO" Then
                        strWhere = pstrTabela + ".datavencimento >= '" + filtroInfo.DataInicial.ToString.Replace("/", "").Substring(4, 4) + filtroInfo.DataInicial.ToString.Replace("/", "").Substring(2, 2) + filtroInfo.DataInicial.ToString.Replace("/", "").Substring(0, 2) + "' and " +
                                   pstrTabela + ".datavencimento <= '" + filtroInfo.DataFinal.ToString.Replace("/", "").Substring(4, 4) + filtroInfo.DataFinal.ToString.Replace("/", "").Substring(2, 2) + filtroInfo.DataFinal.ToString.Replace("/", "").Substring(0, 2) + "' "
                    End If
                Else
                    If administrativoInfo.Competencia.Substring(0, 2) = "12" Then
                        strWhere = pstrTabela + ".competencia = '" + administrativoInfo.Competencia + "' "
                    Else
                        strWhere = pstrTabela + ".competencia in ('" + administrativoInfo.Competencia + "','13" + administrativoInfo.Exercicio.ToString + "') "
                    End If
                End If
            Else
                If administrativoInfo.Competencia.Substring(0, 2) = "12" Then
                    strWhere = pstrTabela + ".competencia in ('" + administrativoInfo.Competencia + "','13" + administrativoInfo.Exercicio.ToString + "') "
                Else
                    strWhere = pstrTabela + ".competencia = '" + administrativoInfo.Competencia + "' "
                End If
            End If
            Return strWhere
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub GravaFiltro(pstrFiltrarpor As String, pstrTipoVencimento As String, pintDias As Integer, pdtaDataInicial As Nullable(Of DateTime), pdtaDataFinal As Nullable(Of DateTime)) Implements IFiltro.GravaFiltro
        Dim objRegistro As New RegistroDAL
        Dim strValue As String = pstrFiltrarpor + "|"
        If pstrFiltrarpor = "VENCIMENTO" Then
            strValue += pstrTipoVencimento + "|"
            If pstrTipoVencimento = "DIAS" Then
                strValue += pintDias.ToString + "|"
            ElseIf pstrTipoVencimento = "PERIODO" Then
                strValue += pdtaDataInicial.Value + "|" + pdtaDataFinal.Value + "|"
            End If
        End If
        objRegistro.GravaChaveRegistro("Software", Application.ProductName, "filtroXtraForm", strValue)
        CarregaFiltro()
    End Sub

    Public Sub IconeOpcaoFiltro(pOpcaoBarButtonItem As DevExpress.XtraBars.BarButtonItem) Implements IFiltro.IconeOpcaoFiltro
        Try
            If filtroInfo.Filtrado Then
                pOpcaoBarButtonItem.ImageIndex = 1
            Else
                pOpcaoBarButtonItem.ImageIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class