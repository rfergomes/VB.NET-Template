'Imports System.Data.Common
'Imports Org.BouncyCastle.Crypto

'Public MustInherit Class BaseDALL(Of T)
'    Private _providerFactory As DbProviderFactory
'    Private _connectionString As String
'    Private Conexao As IDbConnection

'    Public Sub New(ByVal providerName As String, ByVal connectionString As String)
'        _providerFactory = DbProviderFactories.GetFactory(providerName)
'        _connectionString = connectionString
'    End Sub

'    Public Function Inserir(obj As T) As Boolean
'        Try
'            Using conexao As DbConnection = _providerFactory.CreateConnection()
'                conexao.ConnectionString = _connectionString
'                Using cmd As DbCommand = _providerFactory.CreateCommand()
'                    cmd.Connection = conexao
'                    cmd.CommandText = GetInsertQuery(obj)
'                    conexao.Open()
'                    cmd.ExecuteNonQuery()
'                End Using
'            End Using
'            Return True
'        Catch ex As Exception
'            Return False
'        End Try

'    End Function

'    Public Function Insert(obj As T) As Boolean
'        Try
'            Using command As New SQLiteCommand(Conexao)
'                command.CommandText = GetInsertQuery(obj)
'                command.ExecuteNonQuery()
'            End Using
'            Return True
'        Catch ex As Exception
'            Return False
'        End Try
'    End Function

'    Public Function Update(obj As T) As Boolean
'        Try
'            Using command As New SQLiteCommand(Conexao)
'                command.CommandText = GetUpdateQuery(obj)
'                command.ExecuteNonQuery()
'            End Using
'            Return True
'        Catch ex As Exception
'            Return False
'        End Try
'    End Function

'    Public Function Delete(obj As T) As Boolean
'        Try
'            Using command As New SQLiteCommand(Conexao)
'                command.CommandText = GetDeleteQuery(obj)
'                command.ExecuteNonQuery()
'            End Using
'            Return True
'        Catch ex As Exception
'            Return False
'        End Try
'    End Function

'    Public Function GetById(id As Integer) As T
'        Try
'            Using command As New SQLiteCommand(Conexao)
'                command.CommandText = GetSelectByIdQuery(id)
'                Using reader As SQLiteDataReader = command.ExecuteReader()
'                    If reader.Read() Then
'                        Return ConvertFromReader(reader)
'                    Else
'                        Return Nothing
'                    End If
'                End Using
'            End Using
'        Catch ex As Exception
'            Return Nothing
'        End Try
'    End Function

'    Public Function GetAll() As List(Of T)
'        Try
'            Dim result As New List(Of T)
'            Using command As New SQLiteCommand(Conexao)
'                command.CommandText = GetSelectAllQuery()
'                Using reader As SQLiteDataReader = command.ExecuteReader()
'                    While reader.Read()
'                        result.Add(ConvertFromReader(reader))
'                    End While
'                End Using
'            End Using
'            Return result
'        Catch ex As Exception
'            Return Nothing
'        End Try
'    End Function

'    Public Function GetSearch(criterio As String) As List(Of T)
'        Try
'            Dim result As New List(Of T)
'            Using command As New SQLiteCommand(Conexao)
'                command.CommandText = GetSearchQuery(criterio)
'                command.Parameters.AddWithValue("@criterio", "%" & criterio & "%")
'                Using reader As SQLiteDataReader = command.ExecuteReader()
'                    While reader.Read()
'                        result.Add(ConvertFromReader(reader))
'                    End While
'                End Using
'            End Using
'            Return result
'        Catch ex As Exception
'            Return Nothing
'        End Try
'    End Function

'    Protected MustOverride Function GetInsertQuery(obj As T) As String
'    Protected MustOverride Function GetUpdateQuery(obj As T) As String
'    Protected MustOverride Function GetDeleteQuery(obj As T) As String
'    Protected MustOverride Function GetSelectByIdQuery(id As Integer) As String
'    Protected MustOverride Function GetSelectAllQuery() As String
'    Protected MustOverride Function GetSearchQuery(criterio As String) As String
'    Protected MustOverride Function ConvertFromReader(reader As DbDataReader) As T

'End Class

