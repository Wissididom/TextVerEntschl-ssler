Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrypttypes
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusgewähltesObjektInDerLinkenListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Base64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rot13ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlowfishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachObenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachUntenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmEinsNachObenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmEinsNachUntenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_move_down = New System.Windows.Forms.Button()
        Me.btn_move_last = New System.Windows.Forms.Button()
        Me.btn_move_up = New System.Windows.Forms.Button()
        Me.btn_move_first = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(252, 363)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Base64", "Rot13", "Blowfish", "Morse", "Tastatur", "Cäsar"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(149, 329)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(210, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(149, 329)
        Me.ListBox2.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HinzufügenToolStripMenuItem, Me.EntfernenToolStripMenuItem, Me.NachObenToolStripMenuItem, Me.NachUntenToolStripMenuItem, Me.UmEinsNachObenToolStripMenuItem, Me.UmEinsNachUntenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 136)
        '
        'HinzufügenToolStripMenuItem
        '
        Me.HinzufügenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusgewähltesObjektInDerLinkenListeToolStripMenuItem, Me.Base64ToolStripMenuItem, Me.Rot13ToolStripMenuItem, Me.BlowfishToolStripMenuItem})
        Me.HinzufügenToolStripMenuItem.Name = "HinzufügenToolStripMenuItem"
        Me.HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.HinzufügenToolStripMenuItem.Text = "hinzufügen"
        '
        'AusgewähltesObjektInDerLinkenListeToolStripMenuItem
        '
        Me.AusgewähltesObjektInDerLinkenListeToolStripMenuItem.Name = "AusgewähltesObjektInDerLinkenListeToolStripMenuItem"
        Me.AusgewähltesObjektInDerLinkenListeToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AusgewähltesObjektInDerLinkenListeToolStripMenuItem.Text = "ausgewähltes Objekt in der linken Liste"
        '
        'Base64ToolStripMenuItem
        '
        Me.Base64ToolStripMenuItem.Name = "Base64ToolStripMenuItem"
        Me.Base64ToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.Base64ToolStripMenuItem.Text = "Base64"
        '
        'Rot13ToolStripMenuItem
        '
        Me.Rot13ToolStripMenuItem.Name = "Rot13ToolStripMenuItem"
        Me.Rot13ToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.Rot13ToolStripMenuItem.Text = "Rot13"
        '
        'BlowfishToolStripMenuItem
        '
        Me.BlowfishToolStripMenuItem.Name = "BlowfishToolStripMenuItem"
        Me.BlowfishToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.BlowfishToolStripMenuItem.Text = "Blowfish"
        '
        'EntfernenToolStripMenuItem
        '
        Me.EntfernenToolStripMenuItem.Name = "EntfernenToolStripMenuItem"
        Me.EntfernenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EntfernenToolStripMenuItem.Text = "entfernen"
        '
        'NachObenToolStripMenuItem
        '
        Me.NachObenToolStripMenuItem.Name = "NachObenToolStripMenuItem"
        Me.NachObenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NachObenToolStripMenuItem.Text = "nach oben"
        '
        'NachUntenToolStripMenuItem
        '
        Me.NachUntenToolStripMenuItem.Name = "NachUntenToolStripMenuItem"
        Me.NachUntenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NachUntenToolStripMenuItem.Text = "nach unten"
        '
        'UmEinsNachObenToolStripMenuItem
        '
        Me.UmEinsNachObenToolStripMenuItem.Name = "UmEinsNachObenToolStripMenuItem"
        Me.UmEinsNachObenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UmEinsNachObenToolStripMenuItem.Text = "um eins nach oben"
        '
        'UmEinsNachUntenToolStripMenuItem
        '
        Me.UmEinsNachUntenToolStripMenuItem.Name = "UmEinsNachUntenToolStripMenuItem"
        Me.UmEinsNachUntenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UmEinsNachUntenToolStripMenuItem.Text = "um eins nach unten"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(167, 136)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(37, 23)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "->"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(167, 165)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(37, 23)
        Me.btn_remove.TabIndex = 4
        Me.btn_remove.Text = "<-"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_move_down
        '
        Me.btn_move_down.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.btn_move_down.Location = New System.Drawing.Point(365, 96)
        Me.btn_move_down.Name = "btn_move_down"
        Me.btn_move_down.Size = New System.Drawing.Size(38, 23)
        Me.btn_move_down.TabIndex = 5
        Me.btn_move_down.Text = "â"
        Me.btn_move_down.UseVisualStyleBackColor = True
        '
        'btn_move_last
        '
        Me.btn_move_last.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.btn_move_last.Location = New System.Drawing.Point(365, 154)
        Me.btn_move_last.Name = "btn_move_last"
        Me.btn_move_last.Size = New System.Drawing.Size(38, 37)
        Me.btn_move_last.TabIndex = 6
        Me.btn_move_last.Text = "â" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "â"
        Me.btn_move_last.UseVisualStyleBackColor = True
        '
        'btn_move_up
        '
        Me.btn_move_up.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.btn_move_up.Location = New System.Drawing.Point(365, 125)
        Me.btn_move_up.Name = "btn_move_up"
        Me.btn_move_up.Size = New System.Drawing.Size(38, 23)
        Me.btn_move_up.TabIndex = 7
        Me.btn_move_up.Text = "á"
        Me.btn_move_up.UseVisualStyleBackColor = True
        '
        'btn_move_first
        '
        Me.btn_move_first.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.btn_move_first.Location = New System.Drawing.Point(365, 197)
        Me.btn_move_first.Name = "btn_move_first"
        Me.btn_move_first.Size = New System.Drawing.Size(38, 36)
        Me.btn_move_first.TabIndex = 8
        Me.btn_move_first.Text = "á" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "á"
        Me.btn_move_first.UseVisualStyleBackColor = True
        '
        'frm_crypttypes
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(410, 404)
        Me.Controls.Add(Me.btn_move_first)
        Me.Controls.Add(Me.btn_move_up)
        Me.Controls.Add(Me.btn_move_last)
        Me.Controls.Add(Me.btn_move_down)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_crypttypes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ver-/Entschlüsslungsmethoden auswählen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_move_down As Button
    Friend WithEvents btn_move_last As Button
    Friend WithEvents btn_move_up As Button
    Friend WithEvents btn_move_first As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HinzufügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusgewähltesObjektInDerLinkenListeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Base64ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Rot13ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlowfishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntfernenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NachObenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NachUntenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UmEinsNachObenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UmEinsNachUntenToolStripMenuItem As ToolStripMenuItem
End Class
