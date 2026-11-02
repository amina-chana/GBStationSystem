Imports System.Data.SqlClient

Module DBConnection

    Public Function GetConnection() As SqlConnection

        Dim connectionString As String =
        "Data Source=(localdb)\MSSQLLocalDB;" &
        "Initial Catalog=GBStationDB;" &
        "Integrated Security=True;"

        Return New SqlConnection(connectionString)

    End Function


End Module


