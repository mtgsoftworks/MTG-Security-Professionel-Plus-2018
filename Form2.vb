Public Class Form2

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label17.Text = My.Computer.Screen.WorkingArea.ToString
        Label25.Text = My.Computer.Mouse.WheelExists
        Label20.Text = My.Computer.Screen.GetHashCode
        Label21.Text = My.Computer.Info.OSFullName
        Label19.Text = My.Computer.Info.OSPlatform
        Label18.Text = My.Computer.Info.OSVersion
        Label14.Text = My.Computer.Name
        Label15.Text = My.User.Name
        Label16.Text = My.Computer.Network.IsAvailable
        Label22.Text = My.Computer.Keyboard.CapsLock
        Label23.Text = My.Computer.Keyboard.NumLock
        Label24.Text = My.Computer.Keyboard.ScrollLock
    End Sub
End Class