Imports System.Data.SQLite
Public Class server
    Dim lokasi As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim namafile As String = "indo.db"
    Dim fullPath As String = System.IO.Path.Combine(lokasi, namafile)
    Public connectionString As String = String.Format("Data Source = {0}", fullPath)

    Public Sub createDatabase()
        If Not duplicateDatabase(fullPath) Then
            Dim createTable As String = "CREATE TABLE 'kosakata' (
                                         'Kata Perintah' CHAR,
                                         'Respon' CHAR,
                                         'Direktori' CHAR,
                                          ); "
            Using SqlConn As New SQLiteConnection(connectionString)
                Dim cmd As New SQLiteCommand(createTable, SqlConn)
                SqlConn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function
End Class
