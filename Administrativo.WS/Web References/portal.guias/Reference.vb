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
Namespace portal.guias

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="GuiasSoap", [Namespace]:="http://www.grupocandinho.com.br/WebServices/Guias.asmx")> _
    Partial Public Class Guias
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private LogGuiaOperationCompleted As System.Threading.SendOrPostCallback

        Private CadastraGuiaOperationCompleted As System.Threading.SendOrPostCallback

        Private AlteraGuiaOperationCompleted As System.Threading.SendOrPostCallback

        Private useDefaultCredentialsSetExplicitly As Boolean

        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Administrativo.WS.My.MySettings.Default.Administrativo_WS_portal_guias_Guias
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
        Public Event LogGuiaCompleted As LogGuiaCompletedEventHandler

        '''<remarks/>
        Public Event CadastraGuiaCompleted As CadastraGuiaCompletedEventHandler

        '''<remarks/>
        Public Event AlteraGuiaCompleted As AlteraGuiaCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Guias.asmx/LogGuia", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Guias.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Guias.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function LogGuia(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal emailUsuarioEmpresa As String) As String
            Dim results() As Object = Me.Invoke("LogGuia", New Object() {escritorioCNPJ, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, emailUsuarioEmpresa})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub LogGuiaAsync(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal emailUsuarioEmpresa As String)
            Me.LogGuiaAsync(escritorioCNPJ, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, emailUsuarioEmpresa, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub LogGuiaAsync(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal emailUsuarioEmpresa As String, ByVal userState As Object)
            If (Me.LogGuiaOperationCompleted Is Nothing) Then
                Me.LogGuiaOperationCompleted = AddressOf Me.OnLogGuiaOperationCompleted
            End If
            Me.InvokeAsync("LogGuia", New Object() {escritorioCNPJ, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, emailUsuarioEmpresa}, Me.LogGuiaOperationCompleted, userState)
        End Sub

        Private Sub OnLogGuiaOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogGuiaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogGuiaCompleted(Me, New LogGuiaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Guias.asmx/CadastraGuia", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Guias.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Guias.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function CadastraGuia(ByVal escritorioCNPJ As String, ByVal loginUsuarioEscritorio As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal vencimento As Date, ByVal mensagem As String, ByVal dados As String) As String
            Dim results() As Object = Me.Invoke("CadastraGuia", New Object() {escritorioCNPJ, loginUsuarioEscritorio, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, vencimento, mensagem, dados})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub CadastraGuiaAsync(ByVal escritorioCNPJ As String, ByVal loginUsuarioEscritorio As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal vencimento As Date, ByVal mensagem As String, ByVal dados As String)
            Me.CadastraGuiaAsync(escritorioCNPJ, loginUsuarioEscritorio, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, vencimento, mensagem, dados, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub CadastraGuiaAsync(ByVal escritorioCNPJ As String, ByVal loginUsuarioEscritorio As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal vencimento As Date, ByVal mensagem As String, ByVal dados As String, ByVal userState As Object)
            If (Me.CadastraGuiaOperationCompleted Is Nothing) Then
                Me.CadastraGuiaOperationCompleted = AddressOf Me.OnCadastraGuiaOperationCompleted
            End If
            Me.InvokeAsync("CadastraGuia", New Object() {escritorioCNPJ, loginUsuarioEscritorio, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, vencimento, mensagem, dados}, Me.CadastraGuiaOperationCompleted, userState)
        End Sub

        Private Sub OnCadastraGuiaOperationCompleted(ByVal arg As Object)
            If (Not (Me.CadastraGuiaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CadastraGuiaCompleted(Me, New CadastraGuiaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.grupocandinho.com.br/WebServices/Guias.asmx/AlteraGuia", RequestNamespace:="http://www.grupocandinho.com.br/WebServices/Guias.asmx", ResponseNamespace:="http://www.grupocandinho.com.br/WebServices/Guias.asmx", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AlteraGuia(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal vencimento As Date, ByVal mensagem As String, ByVal dados As String) As String
            Dim results() As Object = Me.Invoke("AlteraGuia", New Object() {escritorioCNPJ, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, vencimento, mensagem, dados})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub AlteraGuiaAsync(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal vencimento As Date, ByVal mensagem As String, ByVal dados As String)
            Me.AlteraGuiaAsync(escritorioCNPJ, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, vencimento, mensagem, dados, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AlteraGuiaAsync(ByVal escritorioCNPJ As String, ByVal empresa As String, ByVal obrigacao As String, ByVal competencia As String, ByVal parcela As String, ByVal sequenciaExtra As String, ByVal obrigacaoExtra As String, ByVal tipoPessoaInforme As String, ByVal informe As String, ByVal vencimento As Date, ByVal mensagem As String, ByVal dados As String, ByVal userState As Object)
            If (Me.AlteraGuiaOperationCompleted Is Nothing) Then
                Me.AlteraGuiaOperationCompleted = AddressOf Me.OnAlteraGuiaOperationCompleted
            End If
            Me.InvokeAsync("AlteraGuia", New Object() {escritorioCNPJ, empresa, obrigacao, competencia, parcela, sequenciaExtra, obrigacaoExtra, tipoPessoaInforme, informe, vencimento, mensagem, dados}, Me.AlteraGuiaOperationCompleted, userState)
        End Sub

        Private Sub OnAlteraGuiaOperationCompleted(ByVal arg As Object)
            If (Not (Me.AlteraGuiaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AlteraGuiaCompleted(Me, New AlteraGuiaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    Public Delegate Sub LogGuiaCompletedEventHandler(ByVal sender As Object, ByVal e As LogGuiaCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class LogGuiaCompletedEventArgs
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
    Public Delegate Sub CadastraGuiaCompletedEventHandler(ByVal sender As Object, ByVal e As CadastraGuiaCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class CadastraGuiaCompletedEventArgs
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
    Public Delegate Sub AlteraGuiaCompletedEventHandler(ByVal sender As Object, ByVal e As AlteraGuiaCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AlteraGuiaCompletedEventArgs
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
