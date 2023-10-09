Imports System.Net

Public Class Form10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then

            Label1.Text = "Var"

        Else

            Label1.Text = "Yok"

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("ipconfig /release")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shell("ipconfig /renew")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Adres As String = TextBox1.Text
        Dim Tespit As IPHostEntry = Dns.GetHostByName(Adres)
        Dim IPAdresi As IPAddress() = Tespit.AddressList
        TextBox2.Text = IPAdresi(0).ToString
    End Sub
    
    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class