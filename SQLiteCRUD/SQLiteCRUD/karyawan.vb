Imports System.Data.SQLite
Imports System.Data.OleDb
Public Class karyawan
    Sub data_tabel()
        Call koneksi()
        Call filter_tabel()
    End Sub

    Sub simpan()
        Try
            Adapter = New SQLiteDataAdapter(sql, Conn)
            Adapter.Fill(tabel)
        Catch ex As OleDbException
            MessageBox.Show("Gagal : Kesalahan pada " & ex.Message)
        End Try
    End Sub

    Sub filter_tabel()
        Try
            Dim DS As New DataSet '----------[DEKLARASI TABEL VIRTUAL]--------------
            sql = String.Format("SELECT * FROM karyawan WHERE Nama_Karyawan like '{0}%' ORDER BY Nama_Karyawan ASC", txtkriteria.Text)
            Adapter = New SQLiteDataAdapter(sql, Conn)
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
                .AutoResizeColumns()
            End With
        Catch
            MsgBox("Koneksi ke Database Gagal, cek Database anda atau Driver SQLite Anda", MsgBoxStyle.Critical, "Database Error")
            End
        End Try
    End Sub

    Sub tombol_netral()
        cmdtambah.Enabled = False
        cmdsimpan.Enabled = False
        cmdedit.Enabled = False
        cmdhapus.Enabled = False
    End Sub

    Sub kosong()
        txtnik.Text = ""
        txtnama.Text = ""
        txttempatlahir.Text = ""
        dttgllahir.Value = Now
        txttelp.Text = ""
        cboagama.Text = "Islam"
        cbojeniskelamin.Text = "Laki-Laki"
        txtalamat.Text = ""
        cbopendidikan.Text = "SLTA/Sederajat"
        txtkriteria.Text = ""
    End Sub

    Sub aktif()
        txtnik.Enabled = True
        txtnama.Enabled = True
        txttempatlahir.Enabled = True
        dttgllahir.Enabled = True
        txttelp.Enabled = True
        cboagama.Enabled = True
        cbojeniskelamin.Enabled = True
        txtalamat.Enabled = True
        cbopendidikan.Enabled = True
        txtkriteria.Enabled = False
    End Sub

    Sub tak_aktif()
        txtnik.Enabled = False
        txtnama.Enabled = False
        txttempatlahir.Enabled = False
        dttgllahir.Enabled = False
        txttelp.Enabled = False
        cboagama.Enabled = False
        cbojeniskelamin.Enabled = False
        txtalamat.Enabled = False
        cbopendidikan.Enabled = False
        txtkriteria.Enabled = True
    End Sub

    Private Sub karyawan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call data_tabel()
        cboagama.Text = "Islam"
        cbojeniskelamin.Text = "Laki-Laki"
        cbopendidikan.Text = "SLTA/Sederajat"
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        If jumlah_data = 0 Then
        Else
            Try
                With grid
                    txtnik.Text = .SelectedCells(0).Value
                    txtnama.Text = .SelectedCells(1).Value
                    txttempatlahir.Text = .SelectedCells(2).Value
                    dttgllahir.Value = .SelectedCells(3).Value
                    txttelp.Text = .SelectedCells(4).Value
                    cboagama.Text = .SelectedCells(5).Value
                    cbojeniskelamin.Text = .SelectedCells(6).Value
                    txtalamat.Text = .SelectedCells(7).Value
                    cbopendidikan.Text = .SelectedCells(8).Value
                End With
            Catch
                cmdrefresh.PerformClick()
                MsgBox("Double Klik pada baris bukan pada cell, jika ingin menampilkan data", MsgBoxStyle.Information, "Cell Tabel")
                Exit Sub
            End Try
            Call tombol_netral()
            cmdedit.Enabled = True
            cmdhapus.Enabled = True
        End If
    End Sub

    Private Sub cmdtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtambah.Click
        grid.Enabled = False
        Call tombol_netral()
        cmdsimpan.Enabled = True
        Call kosong()
        Call aktif()
        txtnik.Focus()
        simpan_baru = True
    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        If txtnik.Text = "" Or txtnama.Text = "" Or txttempatlahir.Text = "" Or txttelp.Text = "" Or txttempatlahir.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Ada data yang belum anda isi !", MsgBoxStyle.Information, "Isian Kosong")
            Exit Sub
        End If
        '--------------------------------[CEK DUPLIKASI DATA]--------------------------------------------------------
        If simpan_baru = True Then
            sql = String.Format("SELECT * FROM karyawan WHERE NIK ='{0}'", txtnik.Text)
            Call koneksi()
            Call simpan()
            If tabel.Rows.Count <> 0 Then
                MsgBox("Kode yang anda masukkan sudah ada !", MsgBoxStyle.Information, "Data Sudah Ada")
                Call kosong()
                Call tak_aktif()
                Call tombol_netral()
                cmdtambah.Enabled = True
                grid.Enabled = True
                Call tutup_koneksi()
                Exit Sub
            Else
            End If
        End If
        '--------------------------------[SIMPAN DATA]--------------------------------------------------------
        If simpan_baru = True Then
            sql = "INSERT INTO karyawan (NIK, Nama_Karyawan, Tempat_Lahir, TGL_Lahir, Telp, Agama, Jenis_Kelamin, Alamat, Pendidikan_Terakhir) VALUES ('" & _
                  txtnik.Text & "','" & _
                  txtnama.Text & "','" & _
                  txttempatlahir.Text & "','" & _
                  Format(dttgllahir.Value.Date, "yyyy-MM-dd") & "','" & _
                  txttelp.Text & "','" & _
                  cboagama.Text & "','" & _
                  cbojeniskelamin.Text & "','" & _
                  txtalamat.Text & "','" & _
                  cbopendidikan.Text & "')"
        Else
            sql = "UPDATE karyawan SET " & _
                  "Nama_Karyawan='" & txtnama.Text & "'," & _
                  "Tempat_Lahir='" & txttempatlahir.Text & "'," & _
                  "Tgl_Lahir='" & Format(dttgllahir.Value.Date, "yyyy-MM-dd") & "'," & _
                  "Telp='" & txttelp.Text & "'," & _
                  "Agama='" & cboagama.Text & "'," & _
                  "Jenis_Kelamin='" & cbojeniskelamin.Text & "'," & _
                  "Alamat='" & txtalamat.Text & "'," & _
                  "Pendidikan_Terakhir='" & cbopendidikan.Text & "'" & _
                  " WHERE NIK='" & txtnik.Text & "'"
        End If
        Call koneksi()
        Call simpan()
        Adapter.Update(tabel)
        Call tutup_koneksi()
        If simpan_baru = True Then
            MsgBox("Data berhasil ditambahkan ke dalam database", MsgBoxStyle.Information, "Simpan Data Sukses")
        Else
            MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Update Data Sukses")
        End If
        cmdrefresh.PerformClick()
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        Call tombol_netral()
        grid.Enabled = False
        cmdsimpan.Enabled = True
        simpan_baru = False
        Call aktif()
        txtnama.Focus()
        txtnik.Enabled = False
    End Sub

    Private Sub cmdhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhapus.Click
        pesan = MsgBox("Anda Yakin akan menghapus data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
        If pesan = vbYes Then
            sql = String.Format("DELETE FROM karyawan WHERE NIK ='{0}'", txtnik.Text)
            Call koneksi()
            Call simpan()
            Adapter.Update(tabel)
            Call tutup_koneksi()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Hapus Data Sukses")
        Else
        End If
        cmdrefresh.PerformClick()
    End Sub

    Private Sub cmdrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefresh.Click
        Call kosong()
        Call tak_aktif()
        Call data_tabel()
        simpan_baru = True
        grid.Enabled = True
        Call tombol_netral()
        cmdtambah.Enabled = True
        txtkriteria.Focus()
    End Sub

    Private Sub karyawan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cmdrefresh.PerformClick()
    End Sub

    Private Sub txtkriteria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkriteria.TextChanged
        Call data_tabel()
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
End Class
