Imports System.IO
Public Class Form1
    Private Sub HardDrives()
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()


        Dim d As DriveInfo

        For Each d In allDrives
            If d.IsReady = True Then

                ComboBox1.Items.Add(d.Name)
                ComboBox1.Items.Remove("C:\")
            End If

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckedListBox1.Items.Clear()

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
        Timer3.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Select()
        HardDrives()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked = True Then
            TextBox1.Enabled = False
            Button1.Enabled = False
            ComboBox1.Enabled = True
            Button2.Enabled = True
            Timer2.Start()
        End If
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = False
            TextBox1.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = False

        End If
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        HardDrives()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ComboBox1.SelectedIndex.ToString.Length < 1 Then
            Module2.Main()
            Timer2.Stop()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Timer1.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If TextBox1.TextLength > 1 Then

            Module1.Main()
            Timer3.Stop()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    End Sub
End Class
