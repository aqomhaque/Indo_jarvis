<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cari_karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cari_karyawan))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmdcetak = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtjumlahdata = New System.Windows.Forms.TextBox
        Me.cbokategori = New System.Windows.Forms.ComboBox
        Me.txtkriteria = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rb3 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.grid = New System.Windows.Forms.DataGridView
        Me.txtPerintah = New System.Windows.Forms.TextBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.txtresponse = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcetak
        '
        Me.cmdcetak.Image = CType(resources.GetObject("cmdcetak.Image"), System.Drawing.Image)
        Me.cmdcetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdcetak.Location = New System.Drawing.Point(385, 119)
        Me.cmdcetak.Name = "cmdcetak"
        Me.cmdcetak.Size = New System.Drawing.Size(89, 54)
        Me.cmdcetak.TabIndex = 70
        Me.cmdcetak.Text = "Cetak"
        Me.cmdcetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdcetak.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtjumlahdata)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(297, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(82, 54)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Jumlah Data"
        '
        'txtjumlahdata
        '
        Me.txtjumlahdata.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahdata.Location = New System.Drawing.Point(6, 34)
        Me.txtjumlahdata.Name = "txtjumlahdata"
        Me.txtjumlahdata.Size = New System.Drawing.Size(70, 26)
        Me.txtjumlahdata.TabIndex = 0
        Me.txtjumlahdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbokategori
        '
        Me.cbokategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbokategori.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbokategori.FormattingEnabled = True
        Me.cbokategori.Items.AddRange(New Object() {"NIK", "Nama_Karyawan", "Tempat_Lahir", "Tgl_Lahir", "Telp", "Agama", "Jenis_Kelamin", "Alamat", "Pendidikan_Terakhir"})
        Me.cbokategori.Location = New System.Drawing.Point(6, 32)
        Me.cbokategori.Name = "cbokategori"
        Me.cbokategori.Size = New System.Drawing.Size(143, 23)
        Me.cbokategori.TabIndex = 35
        '
        'txtkriteria
        '
        Me.txtkriteria.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkriteria.Location = New System.Drawing.Point(136, 179)
        Me.txtkriteria.Name = "txtkriteria"
        Me.txtkriteria.Size = New System.Drawing.Size(338, 23)
        Me.txtkriteria.TabIndex = 69
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbokategori)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 54)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(6, 70)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(113, 17)
        Me.rb3.TabIndex = 2
        Me.rb3.Text = "Mengandung Kata"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 85)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipe Pencarian"
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Checked = True
        Me.rb2.Location = New System.Drawing.Point(6, 52)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(102, 17)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "Sebagai Awalan"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 34)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(78, 17)
        Me.rb1.TabIndex = 0
        Me.rb1.Text = "Kata Tepat"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(111, 230)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(363, 225)
        Me.grid.TabIndex = 71
        '
        'txtPerintah
        '
        Me.txtPerintah.Location = New System.Drawing.Point(570, 248)
        Me.txtPerintah.Name = "txtPerintah"
        Me.txtPerintah.Size = New System.Drawing.Size(196, 20)
        Me.txtPerintah.TabIndex = 72
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(570, 325)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(196, 20)
        Me.txtPath.TabIndex = 73
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(142, 55)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(230, 36)
        Me.RichTextBox1.TabIndex = 74
        Me.RichTextBox1.Text = ""
        '
        'txtresponse
        '
        Me.txtresponse.Location = New System.Drawing.Point(570, 286)
        Me.txtresponse.Name = "txtresponse"
        Me.txtresponse.Size = New System.Drawing.Size(196, 20)
        Me.txtresponse.TabIndex = 75
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(570, 119)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 76
        '
        'cari_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 467)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtresponse)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtPerintah)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdcetak)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtkriteria)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cari_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Karyawan"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdcetak As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtjumlahdata As System.Windows.Forms.TextBox
    Friend WithEvents cbokategori As System.Windows.Forms.ComboBox
    Friend WithEvents txtkriteria As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtPerintah As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtresponse As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
