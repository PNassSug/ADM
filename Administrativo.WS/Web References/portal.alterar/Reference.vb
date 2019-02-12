﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.34209
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

'
'Este código-fonte foi gerado automaticamente por Microsoft.VSDesigner, Versão 4.0.30319.34209.
'
Namespace portal.alterar

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="AlteracoesSoap", [Namespace]:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx")> _
    Partial Public Class Alteracoes
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private AlteraEmpresaOperationCompleted As System.Threading.SendOrPostCallback

        Private AlteraObrigacaoOperationCompleted As System.Threading.SendOrPostCallback

        Private AlteraUsuarioEmpresaOperationCompleted As System.Threading.SendOrPostCallback

        Private AlteraUsuarioEscritorioOperationCompleted As System.Threading.SendOrPostCallback

        Private AlteraEscritorioOperationCompleted As System.Threading.SendOrPostCallback

        Private useDefaultCredentialsSetExplicitly As Boolean

        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Administrativo.WS.My.MySettings.Default.Administrativo_WS_portal_alterar_Alteracoes
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub

        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true) _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false)) _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property

        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property

        '''<remarks/>
        Public Event AlteraEmpresaCompleted As AlteraEmpresaCompletedEventHandler

        '''<remarks/>
        Public Event AlteraObrigacaoCompleted As AlteraObrigacaoCompletedEventHandler

        '''<remarks/>
        Public Event AlteraUsuarioEmpresaCompleted As AlteraUsuarioEmpresaCompletedEventHandler

        '''<remarks/>
        Public Event AlteraUsuarioEscritorioCompleted As AlteraUsuarioEscritorioCompletedEventHandler

        '''<remarks/>
        Public Event AlteraEscritorioCompleted As AlteraEscritorioCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx/AlteraEmpresa", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AlteraEmpresa(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal razaoSocial As String, ByVal cpfCnpj As String) As String
            Dim results() As Object = Me.Invoke("AlteraEmpresa", New Object() {escritorioCNPJ, empresa, razaoSocial, cpfCnpj})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub AlteraEmpresaAsync(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal razaoSocial As String, ByVal cpfCnpj As String)
            Me.AlteraEmpresaAsync(escritorioCNPJ, empresa, razaoSocial, cpfCnpj, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AlteraEmpresaAsync(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal razaoSocial As String, ByVal cpfCnpj As String, ByVal userState As Object)
            If (Me.AlteraEmpresaOperationCompleted Is Nothing) Then
                Me.AlteraEmpresaOperationCompleted = AddressOf Me.OnAlteraEmpresaOperationCompleted
            End If
            Me.InvokeAsync("AlteraEmpresa", New Object() {escritorioCNPJ, empresa, razaoSocial, cpfCnpj}, Me.AlteraEmpresaOperationCompleted, userState)
        End Sub

        Private Sub OnAlteraEmpresaOperationCompleted(ByVal arg As Object)
            If (Not (Me.AlteraEmpresaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AlteraEmpresaCompleted(Me, New AlteraEmpresaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx/AlteraObrigacao", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AlteraObrigacao(ByVal escritorioCNPJ As String, ByVal obrigacao As String, ByVal nome As String) As String
            Dim results() As Object = Me.Invoke("AlteraObrigacao", New Object() {escritorioCNPJ, obrigacao, nome})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub AlteraObrigacaoAsync(ByVal escritorioCNPJ As String, ByVal obrigacao As String, ByVal nome As String)
            Me.AlteraObrigacaoAsync(escritorioCNPJ, obrigacao, nome, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AlteraObrigacaoAsync(ByVal escritorioCNPJ As String, ByVal obrigacao As String, ByVal nome As String, ByVal userState As Object)
            If (Me.AlteraObrigacaoOperationCompleted Is Nothing) Then
                Me.AlteraObrigacaoOperationCompleted = AddressOf Me.OnAlteraObrigacaoOperationCompleted
            End If
            Me.InvokeAsync("AlteraObrigacao", New Object() {escritorioCNPJ, obrigacao, nome}, Me.AlteraObrigacaoOperationCompleted, userState)
        End Sub

        Private Sub OnAlteraObrigacaoOperationCompleted(ByVal arg As Object)
            If (Not (Me.AlteraObrigacaoCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AlteraObrigacaoCompleted(Me, New AlteraObrigacaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx/AlteraUsuarioEmpresa", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AlteraUsuarioEmpresa(ByVal escritorioCNPJ As String, ByVal email As String, ByVal empresa As String, ByVal nome As String, ByVal ddd As String, ByVal telefone As String) As String
            Dim results() As Object = Me.Invoke("AlteraUsuarioEmpresa", New Object() {escritorioCNPJ, email, empresa, nome, ddd, telefone})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub AlteraUsuarioEmpresaAsync(ByVal escritorioCNPJ As String, ByVal email As String, ByVal empresa As String, ByVal nome As String, ByVal ddd As String, ByVal telefone As String)
            Me.AlteraUsuarioEmpresaAsync(escritorioCNPJ, email, empresa, nome, ddd, telefone, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AlteraUsuarioEmpresaAsync(ByVal escritorioCNPJ As String, ByVal email As String, ByVal empresa As String, ByVal nome As String, ByVal ddd As String, ByVal telefone As String, ByVal userState As Object)
            If (Me.AlteraUsuarioEmpresaOperationCompleted Is Nothing) Then
                Me.AlteraUsuarioEmpresaOperationCompleted = AddressOf Me.OnAlteraUsuarioEmpresaOperationCompleted
            End If
            Me.InvokeAsync("AlteraUsuarioEmpresa", New Object() {escritorioCNPJ, email, empresa, nome, ddd, telefone}, Me.AlteraUsuarioEmpresaOperationCompleted, userState)
        End Sub

        Private Sub OnAlteraUsuarioEmpresaOperationCompleted(ByVal arg As Object)
            If (Not (Me.AlteraUsuarioEmpresaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AlteraUsuarioEmpresaCompleted(Me, New AlteraUsuarioEmpresaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx/AlteraUsuarioEscritor" & _
            "io", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AlteraUsuarioEscritorio(ByVal escritorioCNPJ As String, ByVal login As String, ByVal nome As String, ByVal email As String, ByVal senha As String) As String
            Dim results() As Object = Me.Invoke("AlteraUsuarioEscritorio", New Object() {escritorioCNPJ, login, nome, email, senha})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub AlteraUsuarioEscritorioAsync(ByVal escritorioCNPJ As String, ByVal login As String, ByVal nome As String, ByVal email As String, ByVal senha As String)
            Me.AlteraUsuarioEscritorioAsync(escritorioCNPJ, login, nome, email, senha, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AlteraUsuarioEscritorioAsync(ByVal escritorioCNPJ As String, ByVal login As String, ByVal nome As String, ByVal email As String, ByVal senha As String, ByVal userState As Object)
            If (Me.AlteraUsuarioEscritorioOperationCompleted Is Nothing) Then
                Me.AlteraUsuarioEscritorioOperationCompleted = AddressOf Me.OnAlteraUsuarioEscritorioOperationCompleted
            End If
            Me.InvokeAsync("AlteraUsuarioEscritorio", New Object() {escritorioCNPJ, login, nome, email, senha}, Me.AlteraUsuarioEscritorioOperationCompleted, userState)
        End Sub

        Private Sub OnAlteraUsuarioEscritorioOperationCompleted(ByVal arg As Object)
            If (Not (Me.AlteraUsuarioEscritorioCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AlteraUsuarioEscritorioCompleted(Me, New AlteraUsuarioEscritorioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx/AlteraEscritorio", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Alteracoes.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AlteraEscritorio(ByVal escritorioCNPJ As String, ByVal razao As String, ByVal ddd As String, ByVal telefone As String) As String
            Dim results() As Object = Me.Invoke("AlteraEscritorio", New Object() {escritorioCNPJ, razao, ddd, telefone})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub AlteraEscritorioAsync(ByVal escritorioCNPJ As String, ByVal razao As String, ByVal ddd As String, ByVal telefone As String)
            Me.AlteraEscritorioAsync(escritorioCNPJ, razao, ddd, telefone, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AlteraEscritorioAsync(ByVal escritorioCNPJ As String, ByVal razao As String, ByVal ddd As String, ByVal telefone As String, ByVal userState As Object)
            If (Me.AlteraEscritorioOperationCompleted Is Nothing) Then
                Me.AlteraEscritorioOperationCompleted = AddressOf Me.OnAlteraEscritorioOperationCompleted
            End If
            Me.InvokeAsync("AlteraEscritorio", New Object() {escritorioCNPJ, razao, ddd, telefone}, Me.AlteraEscritorioOperationCompleted, userState)
        End Sub

        Private Sub OnAlteraEscritorioOperationCompleted(ByVal arg As Object)
            If (Not (Me.AlteraEscritorioCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AlteraEscritorioCompleted(Me, New AlteraEscritorioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub

        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing) _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024) _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")> _
    Public Delegate Sub AlteraEmpresaCompletedEventHandler(ByVal sender As Object, ByVal e As AlteraEmpresaCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AlteraEmpresaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")> _
    Public Delegate Sub AlteraObrigacaoCompletedEventHandler(ByVal sender As Object, ByVal e As AlteraObrigacaoCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AlteraObrigacaoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")> _
    Public Delegate Sub AlteraUsuarioEmpresaCompletedEventHandler(ByVal sender As Object, ByVal e As AlteraUsuarioEmpresaCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AlteraUsuarioEmpresaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")> _
    Public Delegate Sub AlteraUsuarioEscritorioCompletedEventHandler(ByVal sender As Object, ByVal e As AlteraUsuarioEscritorioCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AlteraUsuarioEscritorioCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")> _
    Public Delegate Sub AlteraEscritorioCompletedEventHandler(ByVal sender As Object, ByVal e As AlteraEscritorioCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AlteraEscritorioCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class
End Namespace