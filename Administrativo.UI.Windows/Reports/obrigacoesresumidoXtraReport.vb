﻿Imports Administrativo.Modelo

Public Class obrigacoesresumidoXtraReport
    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        obrigacoesBindingSource.DataSource = GetType(obrigacoesrelatorioInfo)
    End Sub
End Class