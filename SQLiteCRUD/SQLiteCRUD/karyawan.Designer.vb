<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class karyawan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttempatlahir = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dttgllahir = New System.Windows.Forms.DateTimePicker
        Me.txttelp = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboagama = New System.Windows.Forms.ComboBox
        Me.cbojeniskelamin = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbopendidikan = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.grid = New System.Windows.Forms.DataGridView
        Me.txtkriteria = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdtambah = New System.Windows.Forms.Button
        Me.cmdsimpan = New System.Windows.Forms.Button
        Me.cmdedit = New System.Windows.Forms.Button
        Me.cmdhapus = New System.Windows.Forms.Button
        Me.cmdrefresh = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'txtnik
        '
        Me.txtnik.Enabled = False
        Me.txtnik.Location = New System.Drawing.Point(94, 6)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(126, 20)
        Me.txtnik.TabIndex = 1
        '
        'txtnama
        '
        Me.txtnama.Enabled = False
        Me.txtnama.Location = New System.Drawing.Point(94, 28)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(126, 20)
        Me.txtnama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Enabled = False
        Me.txttempatlahir.Location = New System.Drawing.Point(94, 50)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(126, 20)
        Me.txttempatlahir.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tanggal Lahir"
        '
        'dttgllahir
        '
        Me.dttgllahir.CustomFormat = "yyyy-MM-dd"
        Me.dttgllahir.Enabled = False
        Me.dttgllahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttgllahir.Location = New System.Drawing.Point(94, 71)
        Me.dttgllahir.Name = "dttgllahir"
        Me.dttgllahir.Size = New System.Drawing.Size(126, 20)
        Me.dttgllahir.TabIndex = 7
        '
        'txttelp
        '
        Me.txttelp.Enabled = False
        Me.txttelp.Location = New System.Drawing.Point(94, 93)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(126, 20)
        Me.txttelp.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No Telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Agama"
        '
        'cboagama
        '
        Me.cboagama.Enabled = False
        Me.cboagama.FormattingEnabled = True
        Me.cboagama.Items.AddRange(New Object() {"Islam", "Katholik", "Protestan", "Hindu", "Budha", "Konghucu"})
        Me.cboagama.Location = New System.Drawing.Point(94, 115)
        Me.cboagama.Name = "cboagama"
        Me.cboagama.Size = New System.Drawing.Size(126, 21)
        Me.cboagama.TabIndex = 11
        '
        'cbojeniskelamin
        '
        Me.cbojeniskelamin.Enabled = False
        Me.cbojeniskelamin.FormattingEnabled = True
        Me.cbojeniskelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbojeniskelamin.Location = New System.Drawing.Point(94, 138)
        Me.cbojeniskelamin.Name = "cbojeniskelamin"
        Me.cbojeniskelamin.Size = New System.Drawing.Size(126, 21)
        Me.cbojeniskelamin.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Jenis Kelamin"
        '
        'txtalamat
        '
        Me.txtalamat.Enabled = False
        Me.txtalamat.Location = New System.Drawing.Point(94, 161)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(126, 96)
        Me.txtalamat.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Alamat"
        '
        'cbopendidikan
        '
        Me.cbopendidikan.Enabled = False
        Me.cbopendidikan.FormattingEnabled = True
        Me.cbopendidikan.Items.AddRange(New Object() {"SLTA/Sederajat", "D1", "D2", "D3", "S1", "S2", "S3"})
        Me.cbopendidikan.Location = New System.Drawing.Point(94, 259)
        Me.cbopendidikan.Name = "cbopendidikan"
        Me.cbopendidikan.Size = New System.Drawing.Size(126, 21)
        Me.cbopendidikan.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Pendidikan"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(226, 29)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(363, 225)
        Me.grid.TabIndex = 18
        '
        'txtkriteria
        '
        Me.txtkriteria.Location = New System.Drawing.Point(330, 6)
        Me.txtkriteria.Name = "txtkriteria"
        Me.txtkriteria.Size = New System.Drawing.Size(259, 20)
        Me.txtkriteria.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Filter Data Nama"
        '
        'cmdtambah
        '
        Me.cmdtambah.Location = New System.Drawing.Point(226, 256)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(71, 24)
        Me.cmdtambah.TabIndex = 21
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Enabled = False
        Me.cmdsimpan.Location = New System.Drawing.Point(299, 256)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(71, 24)
        Me.cmdsimpan.TabIndex = 22
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdedit
        '
        Me.cmdedit.Enabled = False
        Me.cmdedit.Location = New System.Drawing.Point(372, 256)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(71, 24)
        Me.cmdedit.TabIndex = 23
        Me.cmdedit.Text = "Edit"
        Me.cmdedit.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Enabled = False
        Me.cmdhapus.Location = New System.Drawing.Point(445, 256)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(71, 24)
        Me.cmdhapus.TabIndex = 24
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdrefresh
        '
        Me.cmdrefresh.Location = New System.Drawing.Point(518, 256)
        Me.cmdrefresh.Name = "cmdrefresh"
        Me.cmdrefresh.Size = New System.Drawing.Size(71, 24)
        Me.cmdrefresh.TabIndex = 25
        Me.cmdrefresh.Text = "Refresh"
        Me.cmdrefresh.UseVisualStyleBackColor = True
        '
        'karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 284)
        Me.Controls.Add(Me.cmdrefresh)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdedit)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.txtkriteria)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cbopendidikan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbojeniskelamin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboagama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dttgllahir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dttgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboagama As System.Windows.Forms.ComboBox
    Friend WithEvents cbojeniskelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbopendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtkriteria As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdtambah As System.Windows.Forms.Button
    Friend WithEvents cmdsimpan As System.Windows.Forms.Button
    Friend WithEvents cmdedit As System.Windows.Forms.Button
    Friend WithEvents cmdhapus As System.Windows.Forms.Button
    Friend WithEvents cmdrefresh As System.Windows.Forms.Button

End Class
