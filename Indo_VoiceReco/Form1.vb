Imports System.Speech.Recognition
Imports System.Management
'Imports System.SQLite
Imports System.IO

Public Class Form1
    Dim pengenalansuara As New SpeechRecognitionEngine
    Dim kosakata As New Choices

    'Sub data_tabel()
    '    Call konek()
    '    Call filter_tabel()
    '    DataGridView1.AutoResizeColumns()
    '    Conn.Close()
    '    Conn.Dispose()
    'End Sub

    'Sub filter_tabel()
    '    Try
    '        Dim DS As New DataSet '----------[DEKLARASI TABEL VIRTUAL]--------------
    '        Adapter = New SQLite.SQLiteDataAdapter(sql, Conn)
    '        Adapter.Fill(DS, "kamus")
    '        DataGridView1.DataSource = DS.Tables("kamus")
    '        'jumlah_data = grid.Rows.Count
    '        DS = Nothing
    '        'With DataGridView1
    '        '    .Columns(1).HeaderText = "Nama Karyawan"
    '        '    .Columns(2).HeaderText = "Tempat Lahir"
    '        '    .Columns(3).HeaderText = "Tanggal Lahir"
    '        '    .Columns(6).HeaderText = "Jenis Kelamin"
    '        '    .Columns(8).HeaderText = "Pendidikan"
    '        'End With
    '    Catch
    '        MsgBox("Koneksi ke Database Gagal, cek Database anda atau Driver SQLite Anda", MsgBoxStyle.Critical, "Database Error")
    '        End
    '    End Try
    'End Sub

    Private Sub Psuara_Event(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        My.Computer.Keyboard.SendKeys(e.Result.Text & " ")
    End Sub
    Private Sub Psuara()
        kosakata.Add(System.IO.File.ReadAllLines("kamusindo.db"))
        Dim gr As New Grammar(New GrammarBuilder(kosakata))
        Try
            pengenalansuara.RequestRecognizerUpdate()
            pengenalansuara.LoadGrammar(gr)
            AddHandler pengenalansuara.SpeechRecognized, AddressOf Psuara_Event
            pengenalansuara.SetInputToDefaultAudioDevice()
            pengenalansuara.RecognizeAsync(RecognizeMode.Multiple)
            pengenalansuara.Recognize()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Psuara()

        Dim loadkamus() As String = IO.File.ReadAllLines(Application.StartupPath & "\kamusindo.db")
        Using reader As New StreamReader("kamusindo.db")
            tampilKamus.Text = reader.ReadToEnd
            reader.Close()
            'loadkamus = reader.ReadLine()
            'tampilKamus.Text = tampilKamus.Text & reader.Read
        End Using

        'Do Until loadkamus.EndofStream
        'tampilKamus.Text =tampilKamus.Text &loadkamus.R 
        'Loop
        Console.WriteLine(loadkamus)
        'Using loadkamus As New System.IO.StreamReader(Application.StartupPath & "\kamusindo.db")
        'MessageBox.Show(loadkamus.ReadLine())
        'End Using
        'loadkamus = File.OpenText("C:\Users\Aqom Haq\OneDrive\Project Skripsi Vb.Net\Indo_VoiceReco\Indo_VoiceReco\bin\Debug\indo.db")
        'di loop
        'Do Until loadkamus.EndOfStream
        'RichTextBox2.Text = RichTextBox2.Text & loadkamus.Read
        'Loop

        'tutup Stream Reader
        'loadkamus.Close()

    End Sub
    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'sql = "SELECT * FROM kamus"
        'Call data_tabel()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
        RichTextBox1.Focus()
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles RichTextBox1.TextChanged, RichTextBox2.TextChanged
        TextBox1.Text = RichTextBox1.Text
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "browser" Then
            TextBox1.Text = "membuka browser"
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak(TextBox1.Text)
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
            RichTextBox1.Text = ""
            TextBox1.Text = ""
            RichTextBox1.Focus()
        End If
    End Sub
    'Public Sub RefreshMyForm()
    '    If Me.InvokeRequired() Then
    '        Me.Invoke(Sub() RefreshMyForm())
    '    Else
    '        Me.Refresh()
    '    End If
    'End Sub

    Private Sub BtnTambahKata_Click(sender As Object, e As EventArgs) Handles BtnTambahKata.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gantiGambar As New OpenFileDialog
        If gantiGambar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackgroundImage = Image.FromFile(gantiGambar.FileName)
        End If
    End Sub
End Class
