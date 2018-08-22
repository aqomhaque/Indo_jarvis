Imports System.Data.SQLite
Module koneksi
    Public Conn As SQLiteConnection
    Public Adapter As SQLiteDataAdapter
    Public tabel As New DataTable
    Public Constring, sql, pesan, tanggal As String

    Public Sub konek()
        Try
            Constring = String.Format("Data Source={0}\indo.db;", Application.StartupPath)
            'Conn = New SQLite.SQLiteConnection(Constring)
            Conn = New SQLiteConnection("Data Source={0}\indo.db;Version-3", Application.StartupPath)
            Conn.Open()
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch
            MsgBox("Koneksi ke Database Gagal, cek Database anda", MsgBoxStyle.Critical, "Database Error")
            MsgBox(Application.StartupPath)

            Exit Sub
        End Try
    End Sub
    Public Sub tutup_koneksi()
        Conn.Close()
        Conn.Dispose()
    End Sub
End Module
