Imports System.IO
Imports System.Data.SQLite
Public Class Form2
    Dim constr As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Private _form1 As Form1
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Me._form1.RefreshMyForm()
        Form1.Show()
        Form1.Update()

    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        'Dim textfile As New StreamWriter(Application.StartupPath & "\kamusindo.db")
        'Dim textfile As String = "kamusindo.db"
        'If System.IO.File.Exists(textfile) = True Then
        '    'Dim ObjWriter As New System.IO.StreamWriter(textfile, False)
        '    Dim ObjWriter As New System.IO.StreamWriter(textfile, True)
        '    ObjWriter.Write(vbNewLine & TextBox1.Text)
        '    ObjWriter.Close()
        'Else
        '    Dim ObjWriter As New System.IO.StreamWriter(textfile, False)
        '    ObjWriter.Write(vbNewLine & TextBox1.Text)
        '    ObjWriter.Close()
        'End If
        ''textfile.WriteLine(TextBox1.Text.Trim)
        ''textfile.Close()
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        MsgBox("Selesai ")
        Application.Restart()
    End Sub
End Class