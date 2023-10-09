Imports System.IO
Public Class Form5
    Dim path As String
    Dim save As StreamWriter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        path = "C:\Windows\System32\Drivers\etc\hosts"
        save = New StreamWriter(path, True)
        Dim siteblock As String = (Environment.NewLine & "127.0.0.1" & TextBox1.Text)
        save.Write(siteblock)
        save.Close()
        MsgBox("Site Engellenmiştir!!", vbInformation, "Engellendi")
    End Sub
End Class