Imports System.Data.Common
Imports System.Data.SQLite
'Id As Long, Provedor As String, Host As String, Porta As String, Banco As String, Usuario As String, Senha As String, StringConexao As String
Public Class ConexaoDAL
    Inherits BaseDAL(Of Conexao)

    Protected Overrides Function GetDeleteQuery(obj As Conexao) As String
        Return String.Format("DELETE FROM Conexao WHERE Id={0}", obj.Id)
    End Function

    Protected Overrides Function GetInsertQuery(obj As Conexao) As String
        Return String.Format("INSERT INTO Conexao (Provedor, Host, Porta) VALUES ('{0}', '{1}', '{2}')",
                              obj.Provedor, obj.Host, obj.Porta)
    End Function

    Protected Overrides Function GetSelectAllQuery() As String
        Return "SELECT * FROM Conexao"
    End Function

    Protected Overrides Function GetSelectByIdQuery(id As Integer) As String
        Return String.Format("SELECT * FROM Conexao WHERE Id={0}", id)
    End Function

    Protected Overrides Function GetUpdateQuery(obj As Conexao) As String
        Return String.Format("UPDATE Clientes SET Provedor='{0}', Host='{1}', Porta='{2}' WHERE Id={3}",
                              obj.Provedor, obj.Host, obj.Porta, obj.Id)
    End Function

    Protected Overrides Function GetSearchQuery(criterio As String) As String
        Return "SELECT * FROM Conexao WHERE Provedor LIKE @criterio OR Host LIKE @criterio OR Porta LIKE @criterio"
    End Function

    Protected Overrides Function ConvertFromReader(reader As DbDataReader) As Conexao
        Dim con As New Conexao With {
            .Id = reader.GetInt32(reader.GetOrdinal("Id")),
            .Provedor = reader.GetString(reader.GetOrdinal("Provedor")),
            .Host = reader.GetString(reader.GetOrdinal("Host")),
            .Porta = reader.GetString(reader.GetOrdinal("Porta"))
        }
        Return con
    End Function

End Class

