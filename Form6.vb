Public Class Form6
    Private Const KEYEVENTF_EXTENDEDKEY As Long = &H1
    Private Const KEYEVENTF_KEYUP As Long = &H2
    Private Const VK_LWIN As Byte = &H5B
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, _
    ByVal bScan As Byte, ByVal dwFlags As Long)

    Dim sifre As String
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.ToString = "F12" Then
            Me.KeyPreview = False
            Dim inp As String
            inp = InputBox("Lütfen Şifreyi Giriniz ve Enter Tuşuna Basınız", "Şifre Giriniz")

            If inp = sifre Then
                Me.WindowState = FormWindowState.Normal
                Me.Opacity = 100
                Label1.Visible = True
                Me.ShowInTaskbar = True
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                sifre = ""
            Else
                MsgBox("Hatalı Şifre Girdiniz..", MsgBoxStyle.Critical, "Hatalı Şifre")
            End If
        End If

        If e.KeyCode.ToString = "F11" Then
            If sifre = "" Then
                sifre = InputBox("Lütfen Koymak İstediğiniz Şifreyi Giriniz")
                Me.WindowState = FormWindowState.Maximized
                Me.Opacity = 0.1
                Label1.Visible = False
                Me.ShowInTaskbar = False
                Me.TopMost = True
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            End If

        End If

        If e.Alt And e.KeyCode.ToString = "F4" Then
            e.Handled = True
        End If

        If e.Alt And Keys.Tab Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.Alt And e.KeyCode = Keys.Tab Then
            keybd_event(Keys.Zoom, 0, KEYEVENTF_EXTENDEDKEY)
        End If

        If e.KeyCode = Keys.Control And e.KeyCode = Keys.Alt And e.KeyCode = Keys.Delete Then
            keybd_event(Keys.Zoom, 0, KEYEVENTF_EXTENDEDKEY)
        End If

        If e.KeyCode = Keys.LWin Or e.KeyCode = Keys.RWin Then
            keybd_event(Keys.Zoom, 0, KEYEVENTF_EXTENDEDKEY)
        End If

    End Sub
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub AçBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AçBtn.Click
        System.Diagnostics.Process.Start(DsyYoluTxt.Text)
    End Sub

    Private Sub GözatBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GözatBtn.Click
        'OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Title = " Ekran Kilitliyken açmak istediğiniz bir Dosyayı Seçiniz"
        OpenFileDialog1.Filter = "EXE Dosyalar|*.exe|Tüm Dosyalar|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.FileName = "C:\Program Files (x86)\Windows Media Player\wmplayer.exe"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AçBtn.Enabled = True
            DsyYoluTxt.Text = OpenFileDialog1.FileName
        Else
            'MessageBox.Show("Dosya seçmediniz")
            AçBtn.Enabled = False
        End If
    End Sub
End Class