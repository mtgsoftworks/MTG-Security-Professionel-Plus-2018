Public Class Form8
    Dim percent = 0
    Dim red
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        ComboBox1.SelectedIndex = 0
        ComboBox1.Items.AddRange(System.IO.Directory.GetLogicalDrives)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        percent = 0
        Button1.Enabled = False
        ListBox1.SelectedIndex = 0
        Timer1.Start()
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        percent = (ListBox2.Items.Count / ListBox1.Items.Count) * 100
        If (ListBox1.SelectedIndex < ListBox1.Items.Count - 1) Then
            ProgressBar1.Value = percent
            Label2.Text = "Taranıyor : " & ListBox1.SelectedItem
            ListBox2.Items.Add("Tarıyor: " & ListBox1.SelectedItem)
            Try
                If Dir(ListBox1.SelectedItem.ToString) <> "" Then
                    ListBox3.Items.Add("Virüs Bulundu: " & ListBox1.SelectedItem.ToString)
                ElseIf Dir(ListBox1.SelectedItem.ToString, FileAttribute.Hidden) <> "" Then
                    ListBox3.Items.Add("Virüs Bulundu: " & ListBox1.SelectedItem.ToString)
                Else
                End If
            Catch ex As Exception

            End Try
            ListBox1.SelectedIndex += 1
        Else
            If ListBox3.Items.Count - 1 >= 1 Then
                ListBox3.SelectedIndex = 0
                Button3.Enabled = True
            End If
            Timer1.Stop()
            ProgressBar1.Value = 100
            Label2.Text = "Tarama Bitti. " & ListBox3.Items.Count & "Virüs bulundu"
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox1.SelectedIndex >= 1 Then
            ListBox1.Items.Clear()
            TextBox1.Text = My.Resources.viruslistesi.ToString
            For Each line As String In TextBox1.Lines
                ListBox1.Items.Add(ComboBox1.SelectedItem.ToString & line.ToString)
            Next
            If ListBox1.Items.Count = 1 >= 0 Then
                Label1.Text = "Tarama Sonuç"
                Button1.Enabled = True
            Else
                Label1.Text = "Virüs Bulunamadı"
                Button1.Enabled = False
            End If
        Else
            Button1.Enabled = False
            ListBox1.Items.Clear()
            TextBox1.Text = ""
            Label1.Text = "MTG Security Professional Plus"
        End If
    End Sub
    
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 1 Then
            ListBox1.Items.Clear()
            TextBox1.Text = My.Resources.viruslistesi.ToString
            For Each line As String In TextBox1.Lines
                ListBox1.Items.Add(ComboBox1.SelectedItem.ToString & line.ToString)
            Next
            If ListBox1.Items.Count = 1 >= 0 Then
                Label1.Text = "Tarama Sonuç"
                Button1.Enabled = True
            Else
                Label1.Text = "Virüs Bulunamadı"
                Button1.Enabled = False
            End If
        Else
            Button1.Enabled = False
            ListBox1.Items.Clear()
            TextBox1.Text = ""
            Label1.Text = "MTG Antivirüs Professional Plus"
        End If
    End Sub
    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        If Label1.Text = "Virüs Taraması" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        If Label1.Text = "Virüs Taraması" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class