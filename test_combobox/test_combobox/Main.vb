Public Class Main
    Dim dBaseCommand As New System.Data.OleDb.OleDbCommand
    Dim dBaseConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=new_BD.mdb")
    Dim DT As New Data.DataTable
    Dim DA As OleDb.OleDbDataAdapter


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT.Clear()
        dBaseCommand = New OleDb.OleDbCommand("SELECT DISTINCT [Год рождения] FROM [Общие данные] ORDER BY [Год рождения]", dBaseConnection)
        dBaseConnection.Open()
        dBaseCommand.ExecuteNonQuery()
        DA = New OleDb.OleDbDataAdapter(dBaseCommand)
        DA.Fill(DT)
        Me.DateOfBorn.Items.Clear()

        For Each r As DataRow In DT.Rows
            Me.DateOfBorn.Items.Add(r(0).ToString)
        Next
        dBaseConnection.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DateOfBorn.SelectedIndexChanged
        
        DT.Clear()
        dBaseCommand = New OleDb.OleDbCommand("SELECT ([Фамилия] + ' ' + [Имя]) AS FI FROM [Общие данные] WHERE [Год рождения] = '" & DateOfBorn.SelectedItem.ToString & "' ORDER BY [Фамилия]", dBaseConnection)
        dBaseConnection.Open()
        dBaseCommand.ExecuteNonQuery()
        DA = New OleDb.OleDbDataAdapter(dBaseCommand)
        DA.Fill(DT)
        ChildsList.MultiColumn = True
        Me.ChildsList.Items.Clear()

        For Each r As DataRow In DT.Rows
            Me.ChildsList.Items.Add(r(1).ToString())
        Next

        dBaseConnection.Close()
    End Sub

    Private Sub NewChild_Click(sender As Object, e As EventArgs) Handles NewChild.Click
        ChildCard.Show()
    End Sub
End Class
