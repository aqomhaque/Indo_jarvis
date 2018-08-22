Module deklarasi

    Public sqlite_cmd As SQLite.SQLiteCommand
    Public sqlite_datareader As SQLite.SQLiteDataReader
    Public Conn, sqlite_conn As SQLite.SQLiteConnection
    Public Adapter As SQLite.SQLiteDataAdapter
    Public tabel As New DataTable
    Public Constring, sql, sql1, pesan, tanggal As String
    Public jumlah_data As Double
    Public simpan_baru As Boolean
    'Public frx As New FastReport.TfrxReport
    'Public frdq As New FastReport.TfrxADOQuery
    'Public frdk As New FastReport.TfrxADODatabase
    'Public memoteks As FastReport.IfrxMemoView

    Public Sub buka()
        Constring = String.Format("Data Source={0}\digilib.clite;", Application.StartupPath)
        sqlite_conn = New SQLite.SQLiteConnection(Constring)
        If sqlite_conn.State = ConnectionState.Closed Then sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()
    End Sub

    Public Sub koneksi()
        Try
            Constring = String.Format("Data Source={0}\digilib.clite;", Application.StartupPath)
            Conn = New SQLite.SQLiteConnection(Constring)
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch
            MsgBox("Koneksi ke Database Gagal, cek Database anda", MsgBoxStyle.Critical, "Database Error")
            Exit Sub
        End Try
    End Sub

    Public Sub tutup_koneksi()
        Conn.Close()
        Conn.Dispose()
    End Sub
End Module
