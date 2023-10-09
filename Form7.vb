Imports Microsoft.Win32
Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reg As String = "SYSTEM\CurrentControlSet\services\Tcpip\Parameter s\Interfaces\"
        For Each x In Registry.LocalMachine.OpenSubKey(reg, True).GetSubKeyNames()
            For Each y In Registry.LocalMachine.OpenSubKey(reg & x & "\", True).GetValueNames
                If y = "NameServer" Then _
                Registry.LocalMachine.OpenSubKey(reg & x & "\", True).SetValue(y, "textBox1.Text,textBox2.text")
            Next
        Next
    End Sub
End Class