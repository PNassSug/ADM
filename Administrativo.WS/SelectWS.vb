Imports Administrativo.Modelo

Public Class SelectWS
    Dim ws As New portal.consultar.Consultas

    Public Function EscritorioExiste(ByRef pstrCnpjCpf As String) As Boolean
        Dim blnEncontrou As Boolean = False
        Dim strDados As String = ws.ConsultaEscritorios(pstrCnpjCpf)
        If Not String.IsNullOrEmpty(strDados) Then
            Dim aLista() As String = strDados.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split("-")
                If aCampos.Length > 1 Then
                    If aCampos(0).Replace(" ", String.Empty) = pstrCnpjCpf Then
                        blnEncontrou = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnEncontrou
    End Function

    Public Function EscritorioRetornaDados() As String
        Dim strDados As String = ws.ConsultaEscritorios(portalservidorInfo.cnpjcpf)
        Return strDados
    End Function

    Public Function EmpresaExiste(ByRef pstrEmpresa As String) As Boolean
        Dim blnEncontrou As Boolean = False
        Dim strDados As String = ws.ConsultaEmpresas(portalservidorInfo.cnpjcpf, pstrEmpresa)
        If Not String.IsNullOrEmpty(strDados) Then
            Dim aLista() As String = strDados.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split(",")
                If aCampos.Length > 1 Then
                    If aCampos(0).Replace(" ", String.Empty) = portalservidorInfo.cnpjcpf And
                        aCampos(1).Replace(" ", String.Empty) = pstrEmpresa Then
                        blnEncontrou = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnEncontrou
    End Function

    Public Function EmpresaRetornaDados(ByRef pstrEmpresa As String) As String
        Dim strDados As String = ws.ConsultaEmpresas(portalservidorInfo.cnpjcpf, pstrEmpresa)
        Return strDados
    End Function

    Public Function ObrigacaoExiste(ByRef pstrObrigacao As String) As Boolean
        Dim blnEncontrou As Boolean = False
        Dim strDados As String = ws.ConsultaObrigacoes(portalservidorInfo.cnpjcpf, pstrObrigacao)
        If Not String.IsNullOrEmpty(strDados) Then
            Dim aLista() As String = strDados.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split(",")
                If aCampos.Length > 1 Then
                    If aCampos(0).Replace(" ", String.Empty) = portalservidorInfo.cnpjcpf And
                        aCampos(1).Replace(" ", String.Empty) = pstrObrigacao Then
                        blnEncontrou = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnEncontrou
    End Function

    Public Function ObrigacaoRetornaDados(ByRef pstrObrigacao As String) As String
        Dim strDados As String = ws.ConsultaObrigacoes(portalservidorInfo.cnpjcpf, pstrObrigacao)
        Return strDados
    End Function

    Public Function UsuarioEmpresaExiste(ByRef pstrEmpresa As String, ByRef pstrEmail As String) As Boolean
        Dim blnEncontrou As Boolean = False
        Dim strDados As String = ws.ConsultaUsuarioEmpresa(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail)
        If Not String.IsNullOrEmpty(strDados) Then
            Dim aLista() As String = strDados.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split(",")
                If aCampos.Length > 1 Then
                    If aCampos(0).Replace(" ", String.Empty) = portalservidorInfo.cnpjcpf And
                       aCampos(1).Replace(" ", String.Empty) = pstrEmpresa And
                       aCampos(2).Replace(" ", String.Empty) = pstrEmail Then
                        blnEncontrou = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnEncontrou
    End Function

    Public Function UsuarioEmpresaRetornaDados(ByRef pstrEmpresa As String, ByRef pstrEmail As String) As String
        Dim strDados As String = ws.ConsultaUsuarioEmpresa(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail)
        Return strDados
    End Function

    Public Function UsuarioEscritorioExiste(ByRef pstrLogin As String) As Boolean
        Dim blnEncontrou As Boolean = False
        Dim strDados As String = ws.ConsultaUsuarioEscritorio(portalservidorInfo.cnpjcpf, pstrLogin)
        If Not String.IsNullOrEmpty(strDados) Then
            Dim aLista() As String = strDados.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split(",")
                If aCampos.Length > 1 Then
                    If aCampos(0).Replace(" ", String.Empty) = portalservidorInfo.cnpjcpf And
                       aCampos(2).Replace(" ", String.Empty) = pstrLogin Then
                        blnEncontrou = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnEncontrou
    End Function

    Public Function UsuarioEscritorioRetornaDados(ByRef pstrLogin As String) As String
        Dim strDados As String = ws.ConsultaUsuarioEscritorio(portalservidorInfo.cnpjcpf, pstrLogin)
        Return strDados
    End Function

    Public Function EmpresaUsuarioObrigacaoExiste(ByRef pstrEmpresa As String, ByRef pstrObrigacao As String, ByRef pstrEmail As String) As Boolean
        Dim blnEncontrou As Boolean = False
        Dim strDados As String = ws.ConsultaEmpresaUsuarioObrigacao(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail, pstrObrigacao)
        If Not String.IsNullOrEmpty(strDados) Then
            Dim aLista() As String = strDados.Split("|")
            For iLista = 0 To aLista.Length - 1
                Dim aCampos() As String = aLista(iLista).Split(",")
                If aCampos.Length > 1 Then
                    If aCampos(0).Replace(" ", String.Empty) = portalservidorInfo.cnpjcpf And
                       aCampos(1).Replace(" ", String.Empty) = pstrEmpresa And
                       aCampos(2).Replace(" ", String.Empty) = pstrEmail And
                       aCampos(3).Replace(" ", String.Empty) = pstrObrigacao Then
                        blnEncontrou = True
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnEncontrou
    End Function

    Public Function EmpresaUsuarioObrigacaoRetornaDados(ByRef pstrEmpresa As String, ByRef pstrEmail As String, ByRef pstrObrigacao As String) As String
        Dim strDados As String = ws.ConsultaEmpresaUsuarioObrigacao(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail, pstrObrigacao)
        Return strDados
    End Function
End Class
