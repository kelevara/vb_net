Public Class ChildCard



    Private Sub SaveData_Click(sender As Object, e As EventArgs) Handles SaveData.Click
        Dim dBaseCommand As New System.Data.OleDb.OleDbCommand
        Dim dBaseConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=new_BD.mdb")

        dBaseCommand = New OleDb.OleDbCommand("INSERT INTO [Общие данные] ([Фамилия], [Имя], [Год рождения]) VALUES ('" & LastNameChild.Text & "', '" & FirstNameChild.Text & "', '" & YearOfBornChild.Text & "')", dBaseConnection)
        dBaseConnection.Open()
        dBaseCommand.ExecuteNonQuery()
        dBaseConnection.Close()

        Me.Close()
        Main.Show()
    End Sub
End Class