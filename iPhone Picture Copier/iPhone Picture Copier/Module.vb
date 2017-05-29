Module Module1
    Sub Main()
        ' Get recursive List of all files starting in this directory.
        Dim list As List(Of String) = Dur.GetFilesRecursive(Form1.TextBox1.Text)

        ' Loop through and display each path.
        For Each path In list
            Form1.CheckedListBox1.Items.Add(path)
        Next


    End Sub
End Module
