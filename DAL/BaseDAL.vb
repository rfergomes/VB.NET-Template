Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports System.Data.OracleClient
Imports Npgsql
Imports System.Data.Entity

Public Enum Provedor
    Access
    Excel
    SQLite
    MySQL
    Oracle
    Postgre
    SQLServer
End Enum
Public MustInherit Class BaseDAL(Of T)
    Protected ReadOnly Property ConnectionString(database As Provedor) As String
        Get
            Select Case database
                Case Provedor.Access
                    Return ConfigurationManager.ConnectionStrings("Access").ConnectionString
                Case Provedor.Excel
                    Return ConfigurationManager.ConnectionStrings("Excel").ConnectionString
                Case Provedor.SQLite
                    Return ConfigurationManager.ConnectionStrings("SQLite").ConnectionString
                Case Provedor.MySQL
                    Return ConfigurationManager.ConnectionStrings("MySQL").ConnectionString
                Case Provedor.Oracle
                    Return ConfigurationManager.ConnectionStrings("Oracle").ConnectionString
                Case Provedor.Postgre
                    Return ConfigurationManager.ConnectionStrings("PostgreSQL").ConnectionString
                Case Provedor.SQLServer
                    Return ConfigurationManager.ConnectionStrings("SQLServer").ConnectionString
                Case Else
                    Throw New ArgumentOutOfRangeException(NameOf(database), "Invalid database type")
            End Select
        End Get
    End Property

    Protected Function GetConnection(database As Provedor) As DbConnection
        Select Case database
            Case Provedor.Access
                Return New OleDbConnection(ConnectionString(Provedor.Access))
            Case Provedor.Excel
                Return New OleDbConnection(ConnectionString(Provedor.Excel))
            Case Provedor.SQLite
                Return New SQLiteConnection(ConnectionString(Provedor.SQLite))
            Case Provedor.MySQL
                Return New MySqlConnection(ConnectionString(Provedor.MySQL))
            Case Provedor.Oracle
                Return New OracleConnection(ConnectionString(Provedor.Oracle))
            Case Provedor.Postgre
                Return New NpgsqlConnection(ConnectionString(Provedor.Postgre))
            Case Provedor.SQLServer
                Return New SqlConnection(ConnectionString(Provedor.SQLServer))
            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(database), "Invalid database type")
        End Select
    End Function

    Public Function ExecuteScalar(query As String, database As Provedor, Optional parameters As DbParameter() = Nothing) As Object
        Using connection As DbConnection = GetConnection(database)
            Using command As DbCommand = connection.CreateCommand()
                command.CommandText = query
                command.CommandType = CommandType.Text
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters)
                End If
                connection.Open()
                Return command.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function ExecuteNonQuery(query As String, database As Provedor, Optional parameters As DbParameter() = Nothing) As Integer
        Using connection As DbConnection = GetConnection(database)
            Using command As DbCommand = connection.CreateCommand()
                command.CommandText = query
                command.CommandType = CommandType.Text
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters)
                End If
                connection.Open()
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteReader(query As String, database As Provedor, Optional parameters As DbParameter() = Nothing) As DbDataReader
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        command.CommandText = query
        command.CommandType = CommandType.Text
        If parameters IsNot Nothing Then
            command.Parameters.AddRange(parameters)
        End If
        connection.Open()
        Return command.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Function Insert(obj As T, database As Provedor) As Boolean
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try
            command.CommandText = GetInsertQuery(obj)
            connection.Open()
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Update(obj As T, database As Provedor) As Boolean
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try
            command.CommandText = GetUpdateQuery(obj)
            connection.Open()
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Delete(obj As T, database As Provedor) As Boolean
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try
            command.CommandText = GetDeleteQuery(obj)
            connection.Open()
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GetById(id As Integer, database As Provedor) As T
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try

            command.CommandText = GetSelectByIdQuery(id)
            connection.Open()
            Using reader As DbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Return ConvertFromReader(reader)
                Else
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GetAll(database As Provedor) As List(Of T)
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try
            Dim result As New List(Of T)
            command.CommandText = GetSelectAllQuery()
            connection.Open()
            Using reader As DbDataReader = command.ExecuteReader()
                While reader.Read()
                    result.Add(ConvertFromReader(reader))
                End While
            End Using
            Return result
        Catch ex As Exception
            Return New List(Of T)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GetSearch(criterio As String, database As Provedor) As List(Of T)
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try
            Dim result As New List(Of T)
            command.CommandText = GetSearchQuery(criterio)
            command.Parameters.Add("%" & criterio & "%")
            connection.Open()
            Using reader As DbDataReader = command.ExecuteReader()
                While reader.Read()
                    result.Add(ConvertFromReader(reader))
                End While
            End Using
            Return result
        Catch ex As Exception
            Return Nothing
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GetConexaoBanco(database As Provedor) As String
        Dim connection As DbConnection = GetConnection(database)
        Dim command As DbCommand = connection.CreateCommand()
        Try
            connection.Open()
            Return "Conexão bem sucedida!!!"
        Catch ex As Exception
            Return ex.Message
        Finally
            connection.Close()
        End Try
    End Function

    Protected MustOverride Function GetInsertQuery(obj As T) As String
    Protected MustOverride Function GetUpdateQuery(obj As T) As String
    Protected MustOverride Function GetDeleteQuery(obj As T) As String
    Protected MustOverride Function GetSelectByIdQuery(id As Integer) As String
    Protected MustOverride Function GetSelectAllQuery() As String
    Protected MustOverride Function GetSearchQuery(criterio As String) As String
    Protected MustOverride Function ConvertFromReader(reader As DbDataReader) As T
End Class

