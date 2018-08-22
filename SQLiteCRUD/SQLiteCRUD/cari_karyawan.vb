Imports System.Speech.Recognition

Public Class cari_karyawan

    Dim pengenalansuara As New SpeechRecognitionEngine
    Dim kosakata As New Choices

    Private Sub Psuara_event(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        My.Computer.Keyboard.SendKeys(e.Result.Text & "")
    End Sub

    Private Sub Psuara()

        kosakata.Add(System.IO.File.ReadAllLines("ks.db"))
        Dim gr As New Grammar(New GrammarBuilder(kosakata))
        Try
            pengenalansuara.RequestRecognizerUpdate()
            pengenalansuara.LoadGrammar(gr)
            AddHandler pengenalansuara.SpeechRecognized, AddressOf Psuara_event
            pengenalansuara.SetInputToDefaultAudioDevice()
            pengenalansuara.RecognizeAsync(RecognizeMode.Multiple)
            pengenalansuara.Recognize()
        Catch ex As Exception
            Return
        End Try
    End Sub


    Sub data_tabel()
        Call koneksi()
        Call filter_tabel()
        grid.AutoResizeColumns()
        Conn.Close()
        Conn.Dispose()
    End Sub

    Sub filter_tabel()
        Try
            Dim DS As New DataSet '----------[DEKLARASI TABEL VIRTUAL]--------------
            Adapter = New SQLite.SQLiteDataAdapter(sql, Conn)
            Adapter.Fill(DS, "karyawan")
            grid.DataSource = DS.Tables("karyawan")
            jumlah_data = grid.Rows.Count
            DS = Nothing
            With grid
                .Columns(1).HeaderText = "Nama Karyawan"
                .Columns(2).HeaderText = "Tempat Lahir"
                .Columns(3).HeaderText = "Tanggal Lahir"
                .Columns(6).HeaderText = "Jenis Kelamin"
                .Columns(8).HeaderText = "Pendidikan"
            End With
        Catch
            MsgBox("Koneksi ke Database Gagal, cek Database anda atau Driver SQLite Anda", MsgBoxStyle.Critical, "Database Error")
            End
        End Try
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cbokategori.Text = "NIK"
        sql = "SELECT * FROM karyawan WHERE Nama_Karyawan like '" & txtkriteria.Text & "%' ORDER BY Nama_Karyawan ASC"
        Call data_tabel()
    End Sub

    Private Sub cbokategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbokategori.SelectedIndexChanged
        'txtkriteria.Text = ""
    End Sub

    Private Sub txtkriteria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkriteria.TextChanged
        If rb1.Checked = True Then sql = "SELECT * FROM karyawan WHERE " & cbokategori.Text & " = '" & txtkriteria.Text & "' ORDER BY " & cbokategori.Text & " ASC"
        If rb2.Checked = True Then sql = "SELECT * FROM karyawan WHERE " & cbokategori.Text & " like '" & txtkriteria.Text & "%' ORDER BY " & cbokategori.Text & " ASC"
        If rb3.Checked = True Then sql = "SELECT * FROM karyawan WHERE " & cbokategori.Text & " like '%" & txtkriteria.Text & "%' ORDER BY " & cbokategori.Text & " ASC"
        Call data_tabel()

        Dim selectedRow As DataGridViewRow
        If jumlah_data = 0 Then
        Else
            Try
                selectedRow = grid.Rows(0)
                txtPerintah.Text = grid.SelectedCells(0).Value
                txtPath.Text = grid.SelectedCells(2).Value
                txtresponse.Text = grid.SelectedCells(1).Value
            Catch
                MsgBox("Double Klik pada baris bukan pada cell, jika ingin menampilkan data", MsgBoxStyle.Information, "Cell Tabel")
                Exit Sub
            End Try
        End If
    End Sub

    'Private Sub cmdcetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcetak.Click
    '    Try
    'frx.LoadReportFromFile(Application.StartupPath & "\cari_karyawan.fr3")
    '    Catch
    '        MsgBox("File Report tidak ditemukan, silahkan hubungi vendor Aplikasi", MsgBoxStyle.Critical, "Report tidak ditemukan")
    '        Exit Sub
    '    End Try
    ''------------------------------------------------------------------------------
    ''frdq = frx.FindObject("Query")
    ''If frdq Is Nothing Then Exit Sub
    ''frdq.Query = sql
    ''------------------------------------------------------------------------------
    ''memoteks = frx.FindObject("memokriteria")
    ''If rb1.Checked = True Then memoteks.Memo = "Keterangan : Hasil Cetak Pencarian Data menggunakan Kriteria " & cbokategori.Text & " = " & txtkriteria.Text
    ''If rb2.Checked = True Then memoteks.Memo = "Keterangan : Hasil Cetak Pencarian Data menggunakan Kriteria " & cbokategori.Text & " dengan awalan " & txtkriteria.Text
    ''If rb3.Checked = True Then memoteks.Memo = "Keterangan : Hasil Cetak Pencarian Data menggunakan Kriteria " & cbokategori.Text & " mengandung kata " & txtkriteria.Text
    ''frx.ShowReport()
    'End Sub

    Private Sub cari_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Psuara()
        'cari_karyawan.SetTopLevel()
    End Sub



    Private Sub grid_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.Move
        If jumlah_data = 0 Then
        Else
            Try
                With grid
                    txtPerintah.Text = .SelectedCells(0).Value
                    txtPath.Text = .SelectedCells(1).Value

                End With
            Catch
                'cmdrefresh.PerformClick()
                MsgBox("Double Klik pada baris bukan pada cell, jika ingin menampilkan data", MsgBoxStyle.Information, "Cell Tabel")
                Exit Sub
            End Try

        End If
    End Sub


    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub cmdcetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcetak.Click



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtresponse.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        txtkriteria.Text = RichTextBox1.Text
    End Sub

    Private Sub txtPerintah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPerintah.TextChanged
        If txtPerintah.Text <> "" And txtresponse.Text <> "" And txtPath.Text <> "" Then
            'Else
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak(txtresponse.Text)
            
        End If
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        If txtPath.Text <> "" Then
            Dim a As String

            a = txtPath.Text
            'MsgBox(a)
            Process.Start(a)
            txtkriteria.Text = ""
            RichTextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub
End Class