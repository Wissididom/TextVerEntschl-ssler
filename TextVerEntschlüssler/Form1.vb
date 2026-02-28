Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class Form1

    Private Sub btn_crypttypes_Click(sender As Object, e As EventArgs) Handles btn_crypttypes.Click
        Data.SetData(txt_crypttypes.Text)
        Dim frm = New FrmCrypttypes()
        frm.ShowDialog()
        txt_crypttypes.Text = Data.GetData()
        Data.ClearData()
    End Sub

    Private Sub btn_load_decrypted_Click(sender As Object, e As EventArgs) Handles btn_load_decrypted.Click
        Dim OFD As New OpenFileDialog
        With OFD
            .Title = "unverschlüsselte Textdatei laden"
            .Multiselect = False
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .FileName = "nichts gewählt"
            .Filter = "Textdateien|*.txt|Alle Dateien|*.*"
            If .ShowDialog() = DialogResult.OK Then
                rtb_decrypted.Text = File.ReadAllText(.FileName, Encoding.UTF8)
            End If
        End With
    End Sub

    Private Sub btn_save_decrypted_Click(sender As Object, e As EventArgs) Handles btn_save_decrypted.Click
        Dim SFD As New SaveFileDialog
        With SFD
            .Title = "unverschlüsselte Textdatei speichern"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .FileName = "nichts gewählt"
            .Filter = "Textdateien|*.txt|Alle Dateien|*.*"
            If .ShowDialog() = DialogResult.OK Then
                File.WriteAllText(.FileName, rtb_decrypted.Text, Encoding.UTF8)
            End If
        End With
    End Sub

    Private Sub btn_crypt_Click(sender As Object, e As EventArgs) Handles btn_crypt.Click
        rtb_encrypted.Text = API.Encrypt(txt_crypttypes.Text, rtb_decrypted.Text)
    End Sub

    Private Sub btn_decrypt_Click(sender As Object, e As EventArgs) Handles btn_decrypt.Click
        rtb_decrypted.Text = API.Decrypt(txt_crypttypes.Text, rtb_encrypted.Text)
    End Sub

    Private Sub btn_load_encrypted_Click(sender As Object, e As EventArgs) Handles btn_load_encrypted.Click
        Dim OFD As New OpenFileDialog
        With OFD
            .Title = "verschlüsselte Textdatei laden"
            .Multiselect = False
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .FileName = "nichts gewählt"
            .Filter = "Textdateien|*.txt|Alle Dateien|*.*"
            If .ShowDialog() = DialogResult.OK Then
                rtb_encrypted.Text = File.ReadAllText(.FileName, Encoding.UTF8)
            End If
        End With
    End Sub

    Private Sub btn_save_encrypted_Click(sender As Object, e As EventArgs) Handles btn_save_encrypted.Click
        Dim SFD As New SaveFileDialog
        With SFD
            .Title = "verschlüsselte Textdatei speichern"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .FileName = "nichts gewählt"
            .Filter = "Textdateien|*.txt|Alle Dateien|*.*"
            If .ShowDialog() = DialogResult.OK Then
                File.WriteAllText(.FileName, rtb_encrypted.Text, Encoding.UTF8)
            End If
        End With
    End Sub
End Class
