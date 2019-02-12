Imports System.IO
Public Class manualsistemaXtraForm
    Dim strArquivo As String = String.Empty
    Public Sub New(ByVal pstrArquivo As String)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        strArquivo = pstrArquivo
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
    End Sub

    Private Sub manualsistemaXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim stStreamPDF As IO.Stream
        stStreamPDF = New IO.FileStream(strArquivo, FileMode.Open)
        manualPdfViewer.Visible = True
        manualPdfViewer.LoadDocument(stStreamPDF)
        manualPdfViewer.Refresh()
        stStreamPDF.Close()
    End Sub
End Class