Imports System.Windows.Forms

Public Class FrmCrypttypes

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim result As String = ""
        For Each item As String In ListBox2.Items
            If result = "" Then
                result = item.ToString()
            Else
                result &= "," & item.ToString()
            End If
        Next
        Data.SetData(result)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox2.Items.Add(ListBox1.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If ListBox2.SelectedIndex > -1 Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
    End Sub

    Private Sub btn_move_first_Click(sender As Object, e As EventArgs) Handles btn_move_first.Click
        Dim index As Integer = ListBox2.SelectedIndex
        If index > 0 Then
            Dim oTemp As Object = ListBox2.SelectedItem
            ListBox2.Items.RemoveAt(index)
            ListBox2.Items.Insert(0, oTemp)
            ListBox2.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_move_up_Click(sender As Object, e As EventArgs) Handles btn_move_up.Click
        Dim index As Integer = ListBox2.SelectedIndex
        If index > 0 Then
            Dim oTemp As Object = ListBox2.SelectedItem
            ListBox2.Items.RemoveAt(index)
            ListBox2.Items.Insert(index - 1, oTemp)
            ListBox2.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub btn_move_down_Click(sender As Object, e As EventArgs) Handles btn_move_down.Click
        Dim index As Integer = ListBox2.SelectedIndex
        If index < ListBox2.Items.Count - 1 Then
            Dim oTemp As Object = ListBox2.SelectedItem
            ListBox2.Items.RemoveAt(index)
            ListBox2.Items.Insert(index + 1, oTemp)
            ListBox2.SelectedIndex = index + 1
        End If
    End Sub

    Private Sub btn_move_last_Click(sender As Object, e As EventArgs) Handles btn_move_last.Click
        Dim index As Integer = ListBox2.SelectedIndex
        If index < ListBox2.Items.Count - 1 Then
            Dim oTemp As Object = ListBox2.SelectedItem
            ListBox2.Items.RemoveAt(index)
            ListBox2.Items.Add(oTemp)
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
    End Sub

    Private Sub frm_crypttypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox2.Items.AddRange(Data.GetData().Split(","c))
    End Sub

    Private Sub ListBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyCode = Keys.Delete AndAlso ListBox2.SelectedIndex > -1 Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
    End Sub

    Private Sub AusgewähltesObjektInDerLinkenListeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusgewähltesObjektInDerLinkenListeToolStripMenuItem.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox2.Items.Add(ListBox1.SelectedItem.ToString())
        End If
    End Sub

    Private Sub Base64ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Base64ToolStripMenuItem.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox2.Items.Add("Base64")
        End If
    End Sub

    Private Sub Rot13ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Rot13ToolStripMenuItem.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox2.Items.Add("Rot13")
        End If
    End Sub

    Private Sub BlowfishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlowfishToolStripMenuItem.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox2.Items.Add("Blowfish")
        End If
    End Sub

    Private Sub EntfernenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntfernenToolStripMenuItem.Click
        If ListBox2.SelectedIndex > -1 Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
    End Sub

    Private Sub NachObenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachObenToolStripMenuItem.Click
        btn_move_first_Click(sender, e)
    End Sub

    Private Sub NachUntenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachUntenToolStripMenuItem.Click
        btn_move_last_Click(sender, e)
    End Sub

    Private Sub UmEinsNachObenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UmEinsNachObenToolStripMenuItem.Click
        btn_move_up_Click(sender, e)
    End Sub

    Private Sub UmEinsNachUntenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UmEinsNachUntenToolStripMenuItem.Click
        btn_move_down_Click(sender, e)
    End Sub
End Class
