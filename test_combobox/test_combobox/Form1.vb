Public Class Form1
    Dim dBaseCommand As New System.Data.OleDb.OleDbCommand
    Dim dBaseConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=new_BD.mdb")
    Dim DT As New Data.DataTable
    Dim DA As OleDb.OleDbDataAdapter
    Dim yearOfBornBaby As String

    Private Function Quote(strVariable As String) As String
        Quote = " ' " & strVariable & " ' "
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT.Clear()
        dBaseCommand = New OleDb.OleDbCommand("SELECT DISTINCT [Год рождения] FROM [Общие данные] ORDER BY [Год рождения]", dBaseConnection)
        dBaseConnection.Open()
        dBaseCommand.ExecuteNonQuery()
        DA = New OleDb.OleDbDataAdapter(dBaseCommand)
        DA.Fill(DT)
        Me.ComboBox1.Items.Clear()

        For Each r As DataRow In DT.Rows
            Me.ComboBox1.Items.Add(r(0).ToString)
        Next
        dBaseConnection.Close()
        DT.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim FIO As New ArrayList()
        DT.Clear()
        dBaseCommand = New OleDb.OleDbCommand("SELECT [Фамилия] AND [Имя] FROM [Общие данные] WHERE [Год рождения] = " & Quote(ComboBox1.SelectedItem), dBaseConnection)
        dBaseConnection.Open()
        dBaseCommand.ExecuteNonQuery()
        DA = New OleDb.OleDbDataAdapter(dBaseCommand)
        DA.Fill(DT)
        ListBox1.MultiColumn = True
        Me.ListBox1.Items.Clear()

        For Each r As DataRow In DT.Rows
            FIO.Add(r(0).ToString)
        Next

        ListBox1.Items.Add(FIO)
        dBaseConnection.Close()
    End Sub
End Class
