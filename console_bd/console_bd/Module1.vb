Imports System.Data.OleDb

Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.White

        Dim connectToBD = New OleDbConnection()
        connectToBD.ConnectionString = "Data Source=""new_BD.mdb"";User ID=Admin;Provider=""Microsoft.Jet.OLEDB.4.0"";"
        connectToBD.Open()

        Dim commandToBD = New OleDbCommand()
        commandToBD.Connection = connectToBD
        commandToBD.CommandText = "SELECT * FROM [Общие данные]"

        Dim readData = commandToBD.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
        Console.WriteLine("Таблица БД:" + vbCrLf)
        While readData.Read() = True
            Console.WriteLine("{0, -3} {1, -15} {2, -15}", readData.GetValue(0), readData.GetValue(1), readData.GetValue(2))
        End While

        readData.Close()
        connectToBD.Close()
        Console.ReadKey()
    End Sub

End Module
