Public Enum enuGridManutecaoObrigacao
    Funcionario
    PortalLog
End Enum

Public Class manutencaoobrigacoesInfo
    Public Property empresa() As String
    Public Property obrigacao() As String
    Public Property competencia() As String
    Public Property datavencimento() As Nullable(Of Date)
    Public Property sequenciaextra() As Int32
    Public Property obrigacaoextra() As Int32
    Public Property funcionario() As String
    Public Property datahorageracao() As Nullable(Of DateTime)
    Public Property usuariogeracao() As String
    Public Property tipoenvio() As String
    Public Property vistoentrega() As Int32
    Public Property datahoraentrega() As Nullable(Of DateTime)
    Public Property usuarioentrega() As String
    Public Property vistoencarregado() As Int32
    Public Property datahoraencarregado() As Nullable(Of DateTime)
    Public Property usuarioencarregado() As String
    Public Property valor() As Decimal
    Public Property valorpago() As Decimal
    Public Property datapagamento() As Nullable(Of Date)
    Public Property parcela() As Int32
    Public Property informe() As Int32
    Public Property tipopessoainforme() As Int32
    Public Property cnpjcpfinforme() As String
    Public Property darfinforme() As String
    Public Property observacao() As String
    Public Property portalguias As List(Of manutencaoobrigacoesportalguiasInfo)
    Public Property portalarquivos As List(Of manutencaoobrigacoesportalarquivosInfo)
    Public Property portallog As List(Of manutencaoobrigacoesportallogInfo)
    Public Property cagedmensal As List(Of manutencaoobrigacoesfuncionariosInfo)
End Class

Public Class manutencaoobrigacoesfuncionariosInfo
    Public Property _funcionario As String
    Public Property _nome As String

    Public Sub New(ByVal funcionario As String, ByVal nome As String)
        Me.funcionario = funcionario
        Me.nome = nome
    End Sub

    Public Property funcionario() As String
        Get
            Return _funcionario
        End Get
        Set(ByVal value As String)
            _funcionario = value
        End Set
    End Property

    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property
End Class

Public Class manutencaoobrigacoesportalguiasInfo
    Public Property _layout As Int32
    Public Property _razaosocial As String
    Public Property _endereco As String
    Public Property _bairro As String
    Public Property _cep As String
    Public Property _municipio As String
    Public Property _uf As String
    Public Property _ddd As String
    Public Property _telefone As String
    Public Property _cnae As String
    Public Property _inscricaoestadual As String
    Public Property _cnpjcpf As String
    Public Property _datavencimento As Nullable(Of Date)
    Public Property _datapagamento As Nullable(Of Date)
    Public Property _periodoapuracao As Nullable(Of Date)
    Public Property _codigoreceita As String
    Public Property _descricaoguia As String
    Public Property _valor As Decimal
    Public Property _valoroutros As Decimal
    Public Property _valorjuros As Decimal
    Public Property _valormulta As Decimal
    Public Property _valortotal As Decimal
    Public Property _valorminimo As Decimal
    Public Property _texto1 As String
    Public Property _texto2 As String
    Public Property _texto3 As String
    Public Property _texto4 As String
    Public Property _cotas As String
    Public Property _relacaomesacumulado As String
    Public Property _nomebeneficiario As String
    Public Property _cnpjcpfbeneficiario As String
    Public Property _notafiscal As String
    Public Property _nroreferencia As String
    Public Property _mensagem As String
    Public Property _usuarioenvio As String
    Public Property _datahoraenvioinicio As Nullable(Of DateTime)
    Public Property _datahoraenviofim As Nullable(Of DateTime)
    Public Property _empresavisualizou As Int32
    Public Property _nomeusuarioempresa As String
    Public Property _datahoraempresavisualizou As Nullable(Of DateTime)

    Public Sub New(ByVal razaosocial As String, ByVal endereco As String, ByVal bairro As String, ByVal cep As String, ByVal municipio As String, ByVal uf As String, ByVal ddd As String, ByVal telefone As String, ByVal cnae As String,
                   ByVal inscricaoestadual As String, ByVal cnpjcpf As String, ByVal datavencimento As Nullable(Of Date), ByVal datapagamento As Nullable(Of Date), ByVal periodoapuracao As Nullable(Of Date), ByVal codigoreceita As String,
                   ByVal descricaoguia As String, ByVal valor As Decimal, ByVal valoroutros As Decimal, ByVal valorjuros As Decimal, ByVal valormulta As Decimal, ByVal valortotal As Decimal, ByVal valorminimo As Decimal,
                   ByVal texto1 As String, ByVal texto2 As String, ByVal texto3 As String, ByVal texto4 As String, ByVal cotas As String, ByVal relacaomesacumulado As String,
                   ByVal nomebeneficiario As String, ByVal cnpjcpfbeneficiario As String, ByVal notafiscal As String, ByVal nroreferencia As String, ByVal mensagem As String,
                   ByVal usuarioenvio As String, ByVal datahoraenvioinicio As Nullable(Of DateTime), ByVal datahoraenviofim As Nullable(Of DateTime),
                   ByVal empresavisualizou As Int32, ByVal nomeusuarioempresa As String, ByVal datahoraempresavisualizou As Nullable(Of DateTime))
        Me.layout = 0
        Me.razaosocial = razaosocial
        Me.endereco = endereco
        Me.bairro = bairro
        Me.cep = cep
        Me.municipio = municipio
        Me.uf = uf
        Me.ddd = ddd
        Me.telefone = telefone
        Me.cnae = cnae
        Me.inscricaoestadual = inscricaoestadual
        Me.cnpjcpf = cnpjcpf
        Me.datavencimento = datavencimento
        Me.datapagamento = datapagamento
        Me.periodoapuracao = periodoapuracao
        Me.codigoreceita = codigoreceita
        Me.descricaoguia = descricaoguia
        Me.valor = valor
        Me.valoroutros = valoroutros
        Me.valorjuros = valorjuros
        Me.valormulta = valormulta
        Me.valortotal = valortotal
        Me.valorminimo = valorminimo
        Me.texto1 = texto1
        Me.texto2 = texto2
        Me.texto3 = texto3
        Me.texto4 = texto4
        Me.cotas = cotas
        Me.relacaomesacumulado = relacaomesacumulado
        Me.nomebeneficiario = nomebeneficiario
        Me.cnpjcpfbeneficiario = cnpjcpfbeneficiario
        Me.notafiscal = notafiscal
        Me.nroreferencia = nroreferencia
        Me.mensagem = mensagem
        Me.usuarioenvio = usuarioenvio
        Me.datahoraenvioinicio = datahoraenvioinicio
        Me.datahoraenviofim = datahoraenviofim
        Me.empresavisualizou = empresavisualizou
        Me.nomeusuarioempresa = nomeusuarioempresa
        Me.datahoraempresavisualizou = datahoraempresavisualizou
    End Sub

    Public Property layout() As Int32
        Get
            Return _layout
        End Get
        Set(ByVal Valor As Int32)
            _layout = Valor
        End Set
    End Property

    Public Property razaosocial() As String
        Get
            Return _razaosocial
        End Get
        Set(ByVal Valor As String)
            _razaosocial = Valor
        End Set
    End Property

    Public Property endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal Valor As String)
            _endereco = Valor
        End Set
    End Property

    Public Property bairro() As String
        Get
            Return _bairro
        End Get
        Set(ByVal Valor As String)
            _bairro = Valor
        End Set
    End Property

    Public Property cep() As String
        Get
            Return _cep
        End Get
        Set(ByVal Valor As String)
            _cep = Valor
        End Set
    End Property

    Public Property municipio() As String
        Get
            Return _municipio
        End Get
        Set(ByVal value As String)
            _municipio = value
        End Set
    End Property

    Public Property uf() As String
        Get
            Return _uf
        End Get
        Set(ByVal value As String)
            _uf = value
        End Set
    End Property

    Public Property ddd() As String
        Get
            Return _ddd
        End Get
        Set(ByVal value As String)
            _ddd = value
        End Set
    End Property

    Public Property telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Public Property cnae() As String
        Get
            Return _cnae
        End Get
        Set(ByVal value As String)
            _cnae = value
        End Set
    End Property

    Public Property inscricaoestadual() As String
        Get
            Return _inscricaoestadual
        End Get
        Set(ByVal value As String)
            _inscricaoestadual = value
        End Set
    End Property

    Public Property cnpjcpf() As String
        Get
            Return _cnpjcpf
        End Get
        Set(ByVal value As String)
            _cnpjcpf = value
        End Set
    End Property

    Public Property datavencimento() As Nullable(Of Date)
        Get
            Return _datavencimento
        End Get
        Set(ByVal value As Nullable(Of Date))
            _datavencimento = value
        End Set
    End Property

    Public Property datapagamento() As Nullable(Of Date)
        Get
            Return _datapagamento
        End Get
        Set(ByVal value As Nullable(Of Date))
            _datapagamento = value
        End Set
    End Property

    Public Property periodoapuracao() As Nullable(Of Date)
        Get
            Return _periodoapuracao
        End Get
        Set(ByVal value As Nullable(Of Date))
            _periodoapuracao = value
        End Set
    End Property

    Public Property codigoreceita() As String
        Get
            Return _codigoreceita
        End Get
        Set(ByVal value As String)
            _codigoreceita = value
        End Set
    End Property

    Public Property descricaoguia() As String
        Get
            Return _descricaoguia
        End Get
        Set(ByVal value As String)
            _descricaoguia = value
        End Set
    End Property

    Public Property valor() As Decimal
        Get
            Return _valor
        End Get
        Set(ByVal value As Decimal)
            _valor = value
        End Set
    End Property

    Public Property valoroutros() As Decimal
        Get
            Return _valoroutros
        End Get
        Set(ByVal value As Decimal)
            _valoroutros = value
        End Set
    End Property

    Public Property valorjuros() As Decimal
        Get
            Return _valorjuros
        End Get
        Set(ByVal value As Decimal)
            _valorjuros = value
        End Set
    End Property

    Public Property valormulta() As Decimal
        Get
            Return _valormulta
        End Get
        Set(ByVal value As Decimal)
            _valormulta = value
        End Set
    End Property

    Public Property valortotal() As Decimal
        Get
            Return _valortotal
        End Get
        Set(ByVal value As Decimal)
            _valortotal = value
        End Set
    End Property

    Public Property valorminimo() As Decimal
        Get
            Return _valorminimo
        End Get
        Set(ByVal value As Decimal)
            _valorminimo = value
        End Set
    End Property

    Public Property texto1() As String
        Get
            Return _texto1
        End Get
        Set(ByVal value As String)
            _texto1 = value
        End Set
    End Property

    Public Property texto2() As String
        Get
            Return _texto2
        End Get
        Set(ByVal value As String)
            _texto2 = value
        End Set
    End Property

    Public Property texto3() As String
        Get
            Return _texto3
        End Get
        Set(ByVal value As String)
            _texto3 = value
        End Set
    End Property

    Public Property texto4() As String
        Get
            Return _texto4
        End Get
        Set(ByVal value As String)
            _texto4 = value
        End Set
    End Property

    Public Property cotas() As String
        Get
            Return _cotas
        End Get
        Set(ByVal value As String)
            _cotas = value
        End Set
    End Property

    Public Property relacaomesacumulado() As String
        Get
            Return _relacaomesacumulado
        End Get
        Set(ByVal value As String)
            _relacaomesacumulado = value
        End Set
    End Property

    Public Property nomebeneficiario() As String
        Get
            Return _nomebeneficiario
        End Get
        Set(ByVal value As String)
            _nomebeneficiario = value
        End Set
    End Property

    Public Property cnpjcpfbeneficiario() As String
        Get
            Return _cnpjcpfbeneficiario
        End Get
        Set(ByVal value As String)
            _cnpjcpfbeneficiario = value
        End Set
    End Property

    Public Property notafiscal() As String
        Get
            Return _notafiscal
        End Get
        Set(ByVal value As String)
            _notafiscal = value
        End Set
    End Property

    Public Property nroreferencia() As String
        Get
            Return _nroreferencia
        End Get
        Set(ByVal value As String)
            _nroreferencia = value
        End Set
    End Property

    Public Property mensagem() As String
        Get
            Return _mensagem
        End Get
        Set(ByVal value As String)
            _mensagem = value
        End Set
    End Property

    Public Property usuarioenvio() As String
        Get
            Return _usuarioenvio
        End Get
        Set(ByVal value As String)
            _usuarioenvio = value
        End Set
    End Property

    Public Property datahoraenvioinicio() As Nullable(Of DateTime)
        Get
            Return _datahoraenvioinicio
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahoraenvioinicio = value
        End Set
    End Property

    Public Property datahoraenviofim() As Nullable(Of DateTime)
        Get
            Return _datahoraenviofim
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahoraenviofim = value
        End Set
    End Property

    Public Property empresavisualizou() As Int32
        Get
            Return _empresavisualizou
        End Get
        Set(ByVal value As Int32)
            _empresavisualizou = value
        End Set
    End Property

    Public Property nomeusuarioempresa() As String
        Get
            Return _nomeusuarioempresa
        End Get
        Set(ByVal value As String)
            _nomeusuarioempresa = value
        End Set
    End Property

    Public Property datahoraempresavisualizou() As Nullable(Of DateTime)
        Get
            Return _datahoraempresavisualizou
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahoraempresavisualizou = value
        End Set
    End Property
End Class

Public Class manutencaoobrigacoesportalarquivosInfo
    Public Property _arquivo As String
    Public Property _mensagem As String
    Public Property _usuarioenvio As String
    Public Property _datahoraenvioinicio As Nullable(Of DateTime)
    Public Property _datahoraenviofim As Nullable(Of DateTime)
    Public Property _empresavisualizou As Int32
    Public Property _nomeusuarioempresa As String
    Public Property _datahoraempresavisualizou As Nullable(Of DateTime)

    Public Sub New(ByVal arquivo As String, ByVal mensagem As String,
                   ByVal usuarioenvio As String, ByVal datahoraenvioinicio As Nullable(Of DateTime), ByVal datahoraenviofim As Nullable(Of DateTime),
                   ByVal empresavisualizou As Int32, ByVal nomeusuarioempresa As String, ByVal datahoraempresavisualizou As Nullable(Of DateTime))
        Me.arquivo = arquivo
        Me.mensagem = mensagem
        Me.usuarioenvio = usuarioenvio
        Me.datahoraenvioinicio = datahoraenvioinicio
        Me.datahoraenviofim = datahoraenviofim
        Me.empresavisualizou = empresavisualizou
        Me.nomeusuarioempresa = nomeusuarioempresa
        Me.datahoraempresavisualizou = datahoraempresavisualizou
    End Sub

    Public Property arquivo() As String
        Get
            Return _arquivo
        End Get
        Set(ByVal value As String)
            _arquivo = value
        End Set
    End Property

    Public Property mensagem() As String
        Get
            Return _mensagem
        End Get
        Set(ByVal value As String)
            _mensagem = value
        End Set
    End Property

    Public Property usuarioenvio() As String
        Get
            Return _usuarioenvio
        End Get
        Set(ByVal value As String)
            _usuarioenvio = value
        End Set
    End Property

    Public Property datahoraenvioinicio() As Nullable(Of DateTime)
        Get
            Return _datahoraenvioinicio
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahoraenvioinicio = value
        End Set
    End Property

    Public Property datahoraenviofim() As Nullable(Of DateTime)
        Get
            Return _datahoraenviofim
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahoraenviofim = value
        End Set
    End Property

    Public Property empresavisualizou() As Int32
        Get
            Return _empresavisualizou
        End Get
        Set(ByVal value As Int32)
            _empresavisualizou = value
        End Set
    End Property

    Public Property nomeusuarioempresa() As String
        Get
            Return _nomeusuarioempresa
        End Get
        Set(ByVal value As String)
            _nomeusuarioempresa = value
        End Set
    End Property

    Public Property datahoraempresavisualizou() As Nullable(Of DateTime)
        Get
            Return _datahoraempresavisualizou
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahoraempresavisualizou = value
        End Set
    End Property
End Class

Public Class manutencaoobrigacoesportallogInfo
    Public Property _nome As String
    Public Property _email As String
    Public Property _datahora As Nullable(Of DateTime)

    Public Sub New(ByVal nome As String, ByVal email As String, ByVal datahora As Nullable(Of DateTime))
        Me.nome = nome
        Me.email = email
        Me.datahora = datahora
    End Sub

    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property datahora() As Nullable(Of DateTime)
        Get
            Return _datahora
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _datahora = value
        End Set
    End Property
End Class

Public Class manutencaoobrigacoesportallogrelatorioInfo
    Public Property empresa() As String
    Public Property competencia() As String
    Public Property obrigacao() As String
    Public Property usuarioenvio() As String
    Public Property datahoraenvioinicio() As Nullable(Of DateTime)
    Public Property datahoraenviofim() As Nullable(Of DateTime)
    Public Property descricao() As String
    Public Property razaosocial() As String
    Public Property tipo() As String
    Public Property funcionariocnpjcpf() As String
    Public Property nome() As String
End Class

Public Class manutencaoobrigacoesalerta
    Public Property alertas As List(Of alertaInfo)
End Class

Public Class alertaInfo
    Public Property _titulo As String
    Public Property _descricao As String
    Public Property _tag As String

    Public Sub New(ByVal titulo As String, ByVal descricao As String, ByVal tag As String)
        Me.titulo = titulo
        Me.descricao = descricao
        Me.tag = tag
    End Sub

    Public Property titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property

    Public Property descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property

    Public Property tag() As String
        Get
            Return _tag
        End Get
        Set(ByVal value As String)
            _tag = value
        End Set
    End Property
End Class
