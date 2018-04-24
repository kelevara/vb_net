Public Class Form1
    Dim dBaseCommand As New System.Data.OleDb.OleDbCommand
    Dim dBaseConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=new_BD.mdb")
    Dim DT As New Data.DataTable
    Dim DA As OleDb.OleDbDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dBaseCommand = New OleDb.OleDbCommand("SELECT DISTINCT [Год рождения] FROM [Общие данные] ORDER BY [Год рождения]", dBaseConnection)
        dBaseConnection.Open()
        dBaseCommand.ExecuteNonQuery()
        DA = New OleDb.OleDbDataAdapter(dBaseCommand)
        DA.Fill(DT)
        Me.ComboBox1.Items.Clear()

        For Each r As DataRow In DT.Rows
            Me.ComboBox1.Items.Add(r(0).ToString)
        Next
    End Sub
End Class
