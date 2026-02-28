Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_crypttypes = New System.Windows.Forms.TextBox()
        Me.rtb_decrypted = New System.Windows.Forms.RichTextBox()
        Me.rtb_encrypted = New System.Windows.Forms.RichTextBox()
        Me.btn_crypttypes = New System.Windows.Forms.Button()
        Me.btn_load_decrypted = New System.Windows.Forms.Button()
        Me.btn_save_decrypted = New System.Windows.Forms.Button()
        Me.btn_crypt = New System.Windows.Forms.Button()
        Me.btn_decrypt = New System.Windows.Forms.Button()
        Me.btn_save_encrypted = New System.Windows.Forms.Button()
        Me.btn_load_encrypted = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_crypttypes
        '
        Me.txt_crypttypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_crypttypes.Location = New System.Drawing.Point(12, 14)
        Me.txt_crypttypes.Name = "txt_crypttypes"
        Me.txt_crypttypes.ReadOnly = True
        Me.txt_crypttypes.Size = New System.Drawing.Size(862, 20)
        Me.txt_crypttypes.TabIndex = 0
        Me.txt_crypttypes.Text = "Base64,Base64"
        '
        'rtb_decrypted
        '
        Me.rtb_decrypted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rtb_decrypted.Location = New System.Drawing.Point(12, 41)
        Me.rtb_decrypted.Name = "rtb_decrypted"
        Me.rtb_decrypted.Size = New System.Drawing.Size(455, 408)
        Me.rtb_decrypted.TabIndex = 1
        Me.rtb_decrypted.Text = ""
        '
        'rtb_encrypted
        '
        Me.rtb_encrypted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_encrypted.Location = New System.Drawing.Point(474, 41)
        Me.rtb_encrypted.Name = "rtb_encrypted"
        Me.rtb_encrypted.Size = New System.Drawing.Size(432, 408)
        Me.rtb_encrypted.TabIndex = 2
        Me.rtb_encrypted.Text = ""
        '
        'btn_crypttypes
        '
        Me.btn_crypttypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_crypttypes.Location = New System.Drawing.Point(880, 12)
        Me.btn_crypttypes.Name = "btn_crypttypes"
        Me.btn_crypttypes.Size = New System.Drawing.Size(26, 23)
        Me.btn_crypttypes.TabIndex = 3
        Me.btn_crypttypes.Text = "..."
        Me.btn_crypttypes.UseVisualStyleBackColor = True
        '
        'btn_load_decrypted
        '
        Me.btn_load_decrypted.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_load_decrypted.Location = New System.Drawing.Point(12, 455)
        Me.btn_load_decrypted.Name = "btn_load_decrypted"
        Me.btn_load_decrypted.Size = New System.Drawing.Size(171, 23)
        Me.btn_load_decrypted.TabIndex = 4
        Me.btn_load_decrypted.Text = "unverschlüsselte Textdatei laden"
        Me.btn_load_decrypted.UseVisualStyleBackColor = True
        '
        'btn_save_decrypted
        '
        Me.btn_save_decrypted.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_save_decrypted.Location = New System.Drawing.Point(189, 455)
        Me.btn_save_decrypted.Name = "btn_save_decrypted"
        Me.btn_save_decrypted.Size = New System.Drawing.Size(192, 23)
        Me.btn_save_decrypted.TabIndex = 5
        Me.btn_save_decrypted.Text = "unverschlüsselte Textdatei speichern"
        Me.btn_save_decrypted.UseVisualStyleBackColor = True
        '
        'btn_crypt
        '
        Me.btn_crypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_crypt.Location = New System.Drawing.Point(387, 455)
        Me.btn_crypt.Name = "btn_crypt"
        Me.btn_crypt.Size = New System.Drawing.Size(81, 23)
        Me.btn_crypt.TabIndex = 6
        Me.btn_crypt.Text = "verschlüsseln"
        Me.btn_crypt.UseVisualStyleBackColor = True
        '
        'btn_decrypt
        '
        Me.btn_decrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_decrypt.Location = New System.Drawing.Point(474, 455)
        Me.btn_decrypt.Name = "btn_decrypt"
        Me.btn_decrypt.Size = New System.Drawing.Size(81, 23)
        Me.btn_decrypt.TabIndex = 9
        Me.btn_decrypt.Text = "entschlüsseln"
        Me.btn_decrypt.UseVisualStyleBackColor = True
        '
        'btn_save_encrypted
        '
        Me.btn_save_encrypted.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_save_encrypted.Location = New System.Drawing.Point(725, 455)
        Me.btn_save_encrypted.Name = "btn_save_encrypted"
        Me.btn_save_encrypted.Size = New System.Drawing.Size(180, 23)
        Me.btn_save_encrypted.TabIndex = 8
        Me.btn_save_encrypted.Text = "verschlüsselte Textdatei speichern"
        Me.btn_save_encrypted.UseVisualStyleBackColor = True
        '
        'btn_load_encrypted
        '
        Me.btn_load_encrypted.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_load_encrypted.Location = New System.Drawing.Point(561, 455)
        Me.btn_load_encrypted.Name = "btn_load_encrypted"
        Me.btn_load_encrypted.Size = New System.Drawing.Size(158, 23)
        Me.btn_load_encrypted.TabIndex = 7
        Me.btn_load_encrypted.Text = "verschlüsselte Textdatei laden"
        Me.btn_load_encrypted.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 484)
        Me.Controls.Add(Me.btn_decrypt)
        Me.Controls.Add(Me.btn_save_encrypted)
        Me.Controls.Add(Me.btn_load_encrypted)
        Me.Controls.Add(Me.btn_crypt)
        Me.Controls.Add(Me.btn_save_decrypted)
        Me.Controls.Add(Me.btn_load_decrypted)
        Me.Controls.Add(Me.btn_crypttypes)
        Me.Controls.Add(Me.rtb_encrypted)
        Me.Controls.Add(Me.rtb_decrypted)
        Me.Controls.Add(Me.txt_crypttypes)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Ver-/Entschlüssler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_crypttypes As TextBox
    Friend WithEvents rtb_decrypted As RichTextBox
    Friend WithEvents rtb_encrypted As RichTextBox
    Friend WithEvents btn_crypttypes As Button
    Friend WithEvents btn_load_decrypted As Button
    Friend WithEvents btn_save_decrypted As Button
    Friend WithEvents btn_crypt As Button
    Friend WithEvents btn_decrypt As Button
    Friend WithEvents btn_save_encrypted As Button
    Friend WithEvents btn_load_encrypted As Button
End Class
