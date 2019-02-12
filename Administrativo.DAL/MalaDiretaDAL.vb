Imports Administrativo.Modelo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid
Imports System.Windows.Forms

Public Class MaladiretaDAL
    Implements IMaladireta

    Private edit As RepositoryItemTextEdit
    Private maladiretaRibbonControl As RibbonControl

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrQuery"></param>
    ''' <remarks></remarks>
    Public Sub ValidaObrigacao(ByVal pstrQuery As String) Implements IMaladireta.ValidaObrigacao
        Try
            Dim objResultado As Object
            Dim objDataBase As New DataBaseDAL
            objResultado = objDataBase.QuerySimples(pstrQuery)
            If Not objResultado Is Nothing Then
                Throw New Exception("Esta obrigação já está vinculada a outra Mala Direta!")
            End If
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
    ''' <param name="prcRibbonControl"></param>
    ''' <remarks></remarks>
    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements IMaladireta.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdMaladireta As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsMaladireta As New DataSet()
            Dim dtMaladireta As New DataTable("maladireta")
            For Each row As SelectStatementResultRow In sdMaladireta.ResultSet(0).Rows
                dtMaladireta.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMaladireta.Tables.Add(dtMaladireta)

            For Each row As SelectStatementResultRow In sdMaladireta.ResultSet(1).Rows
                Dim drMaladireta As DataRow = dsMaladireta.Tables("maladireta").NewRow()
                For index = 0 To row.Values.Length - 1
                    drMaladireta(index) = row.Values(index)
                Next
                dsMaladireta.Tables("maladireta").Rows.Add(drMaladireta)
            Next

            sdMaladireta = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtObrigacao As New DataTable("obrigacao")
            For Each row As SelectStatementResultRow In sdMaladireta.ResultSet(0).Rows
                dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsMaladireta.Tables.Add(dtObrigacao)

            For Each row As SelectStatementResultRow In sdMaladireta.ResultSet(1).Rows
                Dim drObrigacao As DataRow = dsMaladireta.Tables("obrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    drObrigacao(index) = row.Values(index)
                Next
                dsMaladireta.Tables("obrigacao").Rows.Add(drObrigacao)
            Next

            Dim keyColumn As DataColumn = dsMaladireta.Tables("maladireta").Columns("maladireta")
            Dim foreignKeyColumnObr As DataColumn = dsMaladireta.Tables("obrigacao").Columns("maladireta")

            dsMaladireta.Relations.Add("MaladiretaObrigacao", keyColumn, foreignKeyColumnObr)

            'Bind the grid control to the data source
            pdgGrid.DataSource = dsMaladireta.Tables("Maladireta")
            pdgGrid.ForceInitialize()
            AddHandler pdgGrid.KeyUp, AddressOf pdgGrid_KeyUp

            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

            pgvGrid.Columns(0).Caption = "Mala direta"
            pgvGrid.Columns(0).Width = 25

            pgvGrid.Columns(1).Caption = "Descrição"
            pgvGrid.Columns(1).Width = 150

            pgvGrid.Columns(2).Caption = "Mensagem"
            pgvGrid.Columns(2).Width = 170
            AddHandler pgvGrid.RowCellClick, AddressOf pgvGrid_RowCellClick

            Dim obrigacaogridview As New GridView(pdgGrid)
            pdgGrid.LevelTree.Nodes.Add("MaladiretaObrigacao", obrigacaogridview)
            obrigacaogridview.ViewCaption = pstrTituloGrid(1).ToString
            obrigacaogridview.PopulateColumns(dsMaladireta.Tables("obrigacao"))
            obrigacaogridview.OptionsView.ShowGroupPanel = False
            obrigacaogridview.OptionsBehavior.Editable = False
            obrigacaogridview.OptionsCustomization.AllowQuickHideColumns = False
            obrigacaogridview.OptionsCustomization.AllowColumnResizing = False
            obrigacaogridview.OptionsCustomization.AllowColumnMoving = False
            obrigacaogridview.OptionsCustomization.AllowGroup = False

            obrigacaogridview.Columns(0).Visible = False

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            obrigacaogridview.Columns(1).ColumnEdit = edit
            obrigacaogridview.Columns(1).Caption = "Obrigação"
            obrigacaogridview.Columns(1).Width = 60

            obrigacaogridview.Columns(2).Caption = "Descrição"
            obrigacaogridview.Columns(2).Width = 500
            obrigacaogridview.Name = "obrigacaoGridView"
            AddHandler obrigacaogridview.RowCellClick, AddressOf obrigacaogridview_RowCellClick

            maladiretaRibbonControl = prcRibbonControl
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub pdgGrid_KeyUp(sender As Object, e As KeyEventArgs)
        Dim gcSender As GridControl = DirectCast(sender, GridControl)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If gcSender.FocusedView.Name = "maladiretaGridView" Then
                maladiretaRibbonControl.Manager.Items(4).Enabled = True
            Else
                maladiretaRibbonControl.Manager.Items(4).Enabled = False
            End If
        End If
    End Sub

    Private Sub pgvGrid_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub obrigacaogridview_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub HabilitaDesabilitaExcluirBarButton(pobjSender As Object, prccEvent As RowCellClickEventArgs)
        Dim gvSender As GridView = DirectCast(pobjSender, GridView)
        If gvSender.Name = "maladiretaGridView" Then
            If prccEvent.Clicks = 1 Then
                maladiretaRibbonControl.Manager.Items(4).Enabled = True
            Else
                maladiretaRibbonControl.Manager.Items(4).Enabled = False
            End If
        Else
            maladiretaRibbonControl.Manager.Items(4).Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrQuery"></param>
    ''' <param name="pdgGrid"></param>
    ''' <param name="pgvGrid"></param>
    ''' <param name="infoObrigacoes"></param>
    ''' <remarks></remarks>
    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoObrigacoes As System.Collections.Generic.List(Of Modelo.maladiretaobrigacoesinfo)) Implements IMaladireta.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresa As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdEmpresa.ResultSet(1).Rows
                infoObrigacoes.Add(New maladiretaobrigacoesinfo(row.Values(0).ToString, row.Values(1).ToString))
            Next

            pdgGrid.DataSource = infoObrigacoes

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Obrigação"
            pgvGrid.Columns(0).Width = 30

            pgvGrid.Columns(1).Caption = "Descrição"
            pgvGrid.Columns(1).Width = 250

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ProximaMaladireta() As Integer Implements IMaladireta.ProximaMaladireta
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            Return objDataBase.QuerySimples("select coalesce(max(maladireta),0) + 1 from admMaladireta")
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
    ''' <remarks></remarks>
    Public Sub IUDMaladireta(ByRef pstrOperacao As String, ByRef infoMaladireta As Modelo.maladiretainfo, ByRef originalinfoObrigacoes As System.Collections.Generic.List(Of Modelo.maladiretaobrigacoesinfo)) Implements IMaladireta.IUDMaladireta
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "inclusao" Then
                strQuery = "insert into admmaladireta( maladireta, descricao, mensagem, incuser, incdata, altuser, altdata) " +
                                         "values (" + infoMaladireta.maladireta.ToString() + ", " +
                                                "'" + infoMaladireta.descricao + "', " +
                                                "'" + infoMaladireta.mensagem + "', " +
                                                "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                "'" + usuarioInfo.usuario + "', current_timestamp);"
            ElseIf pstrOperacao = "alteracao" Then
                strQuery = "update admmaladireta " +
                              "set descricao = '" + infoMaladireta.descricao + "', " +
                                  "mensagem = '" + infoMaladireta.mensagem + "', " +
                                  "altuser = '" + usuarioInfo.usuario + "', " +
                                  "altdata = current_timestamp " +
                            "where maladireta = " + infoMaladireta.maladireta.ToString + ";"
            ElseIf pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admmaladiretaobrigacoes " +
                            "where maladireta = " + infoMaladireta.maladireta.ToString + ";"

                strQuery += Chr(13) + Chr(10)
                strQuery += "delete " +
                              "from admmaladireta " +
                            "where maladireta = " + infoMaladireta.maladireta.ToString + ";"

            End If
            If pstrOperacao <> "exclusao" Then
                If infoMaladireta.obrigacoes.Count = 0 And originalinfoObrigacoes.Count > 0 Then
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from admmaladiretaobrigacoes " +
                                 "where maladireta = " + infoMaladireta.maladireta.ToString + ";"
                End If
                For indexoriginal = 0 To originalinfoObrigacoes.Count - 1
                    Dim blnEncontrouMaladiretaObrigacao As Boolean = False
                    For index = 0 To infoMaladireta.obrigacoes.Count - 1
                        If originalinfoObrigacoes(indexoriginal).obrigacao = infoMaladireta.obrigacoes(index).obrigacao Then
                            blnEncontrouMaladiretaObrigacao = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouMaladiretaObrigacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from admmaladiretaobrigacoes " +
                                     "where maladireta = " + infoMaladireta.maladireta.ToString + " " +
                                       "and obrigacao = '" + originalinfoObrigacoes(indexoriginal).obrigacao + "';"
                    End If
                Next
                For index = 0 To infoMaladireta.obrigacoes.Count - 1
                    Dim blnEncontrouMaladiretaObrigacao As Boolean = False
                    For indexoriginal = 0 To originalinfoObrigacoes.Count - 1
                        If infoMaladireta.obrigacoes(index).obrigacao = originalinfoObrigacoes(indexoriginal).obrigacao Then
                            blnEncontrouMaladiretaObrigacao = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouMaladiretaObrigacao Then
                        Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                           "from admmaladiretaobrigacoes " +
                                                                          "where obrigacao = '" + infoMaladireta.obrigacoes(index).obrigacao + "'")

                        If intCount = 0 Then
                            strQuery += Chr(13) + Chr(10)
                            strQuery += "insert into admmaladiretaobrigacoes(maladireta, obrigacao, incuser, incdata, altuser, altdata) " +
                                                                    "values (" + infoMaladireta.maladireta.ToString() + ", " +
                                                                           "'" + infoMaladireta.obrigacoes(index).obrigacao + "', " +
                                                                           "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                           "'" + usuarioInfo.usuario + "', current_timestamp);"
                        Else
                            Throw New Exception("A obrigação [" + infoMaladireta.obrigacoes(index).obrigacao + "] já está vinculada a outra Mala Direta!")
                        End If
                    End If
                Next
            End If
            objDataBase.NonQuery(strQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pComboBox"></param>
    ''' <remarks></remarks>
    Public Sub CarregaCombopalavraReservada(pComboBox As DevExpress.XtraEditors.ComboBoxEdit) Implements IMaladireta.CarregaComboPalavraReservada
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = "select distinct combopalavrareservada " +
                                       "from admmaladiretaconfig"
            Dim sdData As SelectedData = objDataBase.QueryFull(strQuery)
            pComboBox.Properties.Items.Clear()
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                pComboBox.Properties.Items.Add(row.Values(0))
            Next row
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pListBox"></param>
    ''' <param name="pstrCategoria"></param>
    ''' <remarks></remarks>
    Public Sub CarregaListaPalavraReservada(pListBox As DevExpress.XtraEditors.ListBoxControl, pstrCategoria As String) Implements IMaladireta.CarregaListaPalavraReservada
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = "select listapalavrareservada " +
                                       "from admmaladiretaconfig " +
                                      "where combopalavrareservada = '" + pstrCategoria + "'"
            Dim sdData As SelectedData = objDataBase.QueryFull(strQuery)
            pListBox.Items.Clear()
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                pListBox.Items.Add(row.Values(0))
            Next row
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
    ''' <remarks></remarks>
    Public Function CarregaPalavraReservada(pstrCategoria As String, pstrNome As String) As String Implements IMaladireta.CarregaPalavraReservada
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = "select palavrareservada " +
                                       "from admmaladiretaconfig " +
                                      "where combopalavrareservada = '" + pstrCategoria + "' " +
                                        "and listapalavrareservada = '" + pstrNome + "'"
            Dim strResultado As String = objDataBase.QuerySimples(strQuery).ToString
            Return strResultado
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
    ''' <remarks></remarks>
    Public Function CarregaMensagem(pstrObrigacao As String, pstrCompetencia As String, pstrEmpresa As String, pintObrigacaoextra As Int32, pintSequenciaextra As Int32, pintParcela As Int32, pintInforme As Int32) As String Implements IMaladireta.CarregaMensagem
        Try
            Dim objDataBase As New DataBaseDAL
            Dim objResultado As Object, objChaves As Object
            Dim intStart As Integer = 0, intCount As Integer = 0
            Dim sdEstruturaTabela As SelectedData, sdAtributos As SelectedData, objMensagem As SelectedData, sdResult As SelectedData, sdEstruturaTabelaSecundaria As SelectedData
            Dim strChaves As String = String.Empty, strChave As String = String.Empty, strLigacao As String = String.Empty, strAtributo As String = String.Empty, strQuery As String = String.Empty, strLigacaoSecundaria As String = String.Empty

            strQuery = "select mensagem " +
                         "from admmaladiretaobrigacoes amo " +
                         "join admmaladireta am on amo.maladireta = am.maladireta " +
                        "where amo.obrigacao = '" + pstrObrigacao + "'"

            Dim strMensagem As String = String.Empty
            objMensagem = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In objMensagem.ResultSet(1).Rows
                strMensagem = row.Values(0)
            Next row

            If String.IsNullOrEmpty(strMensagem) Then
                strQuery = "select mensagem " +
                             "from admmaladireta am " +
                        "left join admmaladiretaobrigacoes amo on amo.maladireta = am.maladireta " +
                            "where coalesce(amo.obrigacao,'') = ''"
                objMensagem = objDataBase.QueryFull(strQuery)
                For Each row As SelectStatementResultRow In objMensagem.ResultSet(1).Rows
                    strMensagem = row.Values(0)
                Next row
            End If

            Do While strMensagem.IndexOf("<", intStart) > -1
                If strMensagem.IndexOf(">", intStart) = -1 Then Exit Do
                strChave = strMensagem.Substring(strMensagem.IndexOf("<", intStart) + 1, strMensagem.IndexOf(">", intStart) - (strMensagem.IndexOf("<", intStart) + 1))
                While strChave.IndexOf("<", 0) > -1
                    intStart = strMensagem.IndexOf("<", intStart) + strChave.IndexOf("<", 0) + 1
                    strChave = strMensagem.Substring(strMensagem.IndexOf("<", intStart) + 1, strMensagem.IndexOf(">", intStart) - (strMensagem.IndexOf("<", intStart) + 1))
                End While
                strChaves += "'" + strChave + "', "
                intStart = strMensagem.IndexOf(">", intStart) + 1
            Loop
            If strChaves.Length = 0 Then
                Return strMensagem
            End If

            strChaves = strChaves.Substring(0, strChaves.Length - 2)
            strQuery = "select palavrareservada, atributo, aliastabela, mascara " +
                         "from admmaladiretaconfig " +
                        "where palavrareservada in (" + strChaves + ") " +
                     "order by  palavrareservada, atributo, aliastabela "
            sdAtributos = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdAtributos.ResultSet(1).Rows
                If String.IsNullOrEmpty(row.Values(3)) Then
                    strAtributo += "'" + row.Values(0) + "|'|| " + row.Values(2) + "." + row.Values(1) + " ,"
                ElseIf row.Values(3) = "ddmmyyyy" Then
                    strAtributo += "'" + row.Values(0) + "|'|| replace(gd_formatsql(gd_ddmmyyyy(" + row.Values(2) + "." + row.Values(1) + "),'00/00/0000'),'00/00/0000',''),"
                ElseIf row.Values(3) = "moeda" Then
                    strAtributo += "'" + row.Values(0) + "|'|| replace(replace(to_char(" + row.Values(2) + "." + row.Values(1) + ",'999999D99'),'.',','),' ,00',''),"
                ElseIf row.Values(3) = "telefone" Then
                    strAtributo += "'" + row.Values(0) + "|'|| case when char_length(" + row.Values(2) + "." + row.Values(1) + ") = 8 then gd_formatsql(" + row.Values(2) + "." + row.Values(1) + ", '0000-0000') when char_length(" + row.Values(2) + "." + row.Values(1) + ") = 9 then gd_formatsql(" + row.Values(2) + "." + row.Values(1) + ", '00000-0000') else '' end,"
                Else
                    strAtributo += "'" + row.Values(0) + "|'|| gd_formatsql(" + row.Values(2) + "." + row.Values(1) + " ,'" + row.Values(3) + "'),"
                End If
                intCount += 1
            Next row

            If strAtributo.Length = 0 Then Return strMensagem

            strAtributo = strAtributo.Substring(0, strAtributo.Length - 1)
            strQuery = "select distinct ligacao " +
                         "from admmaladiretaconfig " +
                        "where palavrareservada in (" + strChaves + ") " +
                     "order by ligacao "
            sdEstruturaTabela = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdEstruturaTabela.ResultSet(1).Rows
                strLigacao += " " + row.Values(0)
            Next row

            strQuery = "select distinct ligacaosecundaria " +
                         "from admmaladiretaconfig " +
                        "where palavrareservada in (" + strChaves + ") " +
                     "order by ligacaosecundaria "
            sdEstruturaTabelaSecundaria = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdEstruturaTabelaSecundaria.ResultSet(1).Rows
                strLigacaoSecundaria += " " + row.Values(0)
            Next row

            strQuery = "select " + strAtributo + " " +
                         "from admcontroleadministrativo adm " +
                               strLigacao + " " +
                               strLigacaoSecundaria + " " +
                        "where adm.competencia = '" + pstrCompetencia + "' " +
                          "and adm.empresa = '" + pstrEmpresa + "' " +
                          "and adm.obrigacao = '" + pstrObrigacao + "' " +
                          "and adm.obrigacaoextra = " + pintObrigacaoextra.ToString + " " +
                          "and adm.sequenciaextra = " + pintSequenciaextra.ToString + " " +
                          "and adm.parcela = " + pintParcela.ToString + " " +
                          "and adm.informe = " + pintInforme.ToString

            sdResult = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdResult.ResultSet(1).Rows
                While intCount <> 0
                    If Not String.IsNullOrEmpty(row.Values(intCount - 1)) Then
                        objResultado = Split(row.Values(intCount - 1), "|")
                        strMensagem = strMensagem.Replace("<" + objResultado(0) + ">", Trim(objResultado(1)))
                    End If
                    intCount -= 1
                End While
            Next row
            intCount = 0
            objChaves = Split(strChaves.Replace("'", "").Replace(" ", ""), ",")
            While UBound(objChaves) > intCount
                strMensagem = strMensagem.Replace("  ", " ").Replace("<" + objChaves(intCount) + ">", String.Empty)
                intCount += 1
            End While
            Return strMensagem
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
