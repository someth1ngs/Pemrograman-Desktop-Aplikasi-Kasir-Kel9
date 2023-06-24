<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.makanan = New System.Windows.Forms.Button()
        Me.minuman = New System.Windows.Forms.Button()
        Me.pesan = New System.Windows.Forms.Button()
        Me.history = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.meja = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.idpesan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Pesanan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Kembali = New System.Windows.Forms.TextBox()
        Me.Bayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'makanan
        '
        Me.makanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.makanan.Location = New System.Drawing.Point(667, 23)
        Me.makanan.Name = "makanan"
        Me.makanan.Size = New System.Drawing.Size(121, 44)
        Me.makanan.TabIndex = 1
        Me.makanan.Text = "Makanan"
        Me.makanan.UseVisualStyleBackColor = True
        '
        'minuman
        '
        Me.minuman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.minuman.Location = New System.Drawing.Point(667, 73)
        Me.minuman.Name = "minuman"
        Me.minuman.Size = New System.Drawing.Size(121, 47)
        Me.minuman.TabIndex = 2
        Me.minuman.Text = "Minuman"
        Me.minuman.UseVisualStyleBackColor = True
        '
        'pesan
        '
        Me.pesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pesan.Location = New System.Drawing.Point(351, 391)
        Me.pesan.Name = "pesan"
        Me.pesan.Size = New System.Drawing.Size(121, 47)
        Me.pesan.TabIndex = 3
        Me.pesan.Text = "Pesan"
        Me.pesan.UseVisualStyleBackColor = True
        '
        'history
        '
        Me.history.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.history.Location = New System.Drawing.Point(12, 391)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(121, 47)
        Me.history.TabIndex = 4
        Me.history.Text = "History"
        Me.history.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(14, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Meja"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.nama.Location = New System.Drawing.Point(100, 23)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(331, 26)
        Me.nama.TabIndex = 7
        '
        'meja
        '
        Me.meja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meja.FormattingEnabled = True
        Me.meja.Location = New System.Drawing.Point(100, 99)
        Me.meja.Name = "meja"
        Me.meja.Size = New System.Drawing.Size(174, 28)
        Me.meja.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(667, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 47)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBox1.Location = New System.Drawing.Point(505, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(156, 29)
        Me.TextBox1.TabIndex = 10
        '
        'idpesan
        '
        Me.idpesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.idpesan.Location = New System.Drawing.Point(100, 62)
        Me.idpesan.Name = "idpesan"
        Me.idpesan.Size = New System.Drawing.Size(331, 26)
        Me.idpesan.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(14, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ID Pesan"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(669, 126)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(119, 20)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Stock Status ->"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Pesanan, Me.ColumnHeader1, Me.ColumnHeader4})
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 151)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 234)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Pesanan
        '
        Me.Pesanan.Text = "Pesanan"
        Me.Pesanan.Width = 489
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tipe Pesanan"
        Me.ColumnHeader1.Width = 127
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Harga"
        Me.ColumnHeader4.Width = 152
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(340, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 26)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Kembali
        '
        Me.Kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Kembali.Location = New System.Drawing.Point(505, 93)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.ReadOnly = True
        Me.Kembali.Size = New System.Drawing.Size(156, 29)
        Me.Kembali.TabIndex = 23
        '
        'Bayar
        '
        Me.Bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Bayar.Location = New System.Drawing.Point(505, 58)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(156, 29)
        Me.Bayar.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(455, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(449, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(434, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Kembali"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Project_Akhir.My.Resources.Resources.warkop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Bayar)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idpesan)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.meja)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.history)
        Me.Controls.Add(Me.pesan)
        Me.Controls.Add(Me.minuman)
        Me.Controls.Add(Me.makanan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents makanan As Button
    Friend WithEvents minuman As Button
    Friend WithEvents pesan As Button
    Friend WithEvents history As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents meja As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents idpesan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Pesanan As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents Kembali As TextBox
    Friend WithEvents Bayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
