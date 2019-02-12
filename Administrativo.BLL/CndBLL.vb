Imports Administrativo.Modelo
Imports Administrativo.DAL
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Class CndBLL
   Implements ICnd

   Dim objCnd As New CndDAL
   Public Sub Grid(ByRef pstrQuery As String, pdgGrid As GridControl, pgvGrid As GridView, picStatusImageColection As ImageCollection) Implements ICnd.Grid
      Try
         objCnd.Grid(pstrQuery, pdgGrid, pgvGrid, picStatusImageColection)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
End Class
