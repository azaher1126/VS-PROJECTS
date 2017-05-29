Module Module2
    Sub Main()
        ' Get recursive List of all files starting in this directory.
        Dim list As List(Of String) = Dur.GetFilesRecursive(Form1.ComboBox1.SelectedItem.ToString)

        ' Loop through and display each path.
        For Each path In list
            Console.WriteLine(path)
        Next


    End Sub
End Module
