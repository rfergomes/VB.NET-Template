Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.SQLite
Imports MySql.Data.MySqlClient
Imports System.Data.OracleClient
Imports Npgsql


Public Enum TipoBanco
    Access
    Excel
    SQLite
    MySQL
    Oracle
    Postgre
    SQLServer
End Enum

Public Class ConexaoBD
    Private _tipoBanco As TipoBanco
    Private _connectionString As String
    Private _conexao As IDbConnection

    Public Sub New(ByVal tipoBanco As TipoBanco)
        _tipoBanco = tipoBanco
        _connectionString = ConfigurationManager.ConnectionStrings(_tipoBanco).ConnectionString
    End Sub

    Public Function AbrirConexao() As IDbConnection
        Select Case _tipoBanco
            Case TipoBanco.Access, TipoBanco.Excel
                _conexao = New OleDbConnection(_connectionString)
            Case TipoBanco.SQLite
                _conexao = New SQLiteConnection(_connectionString)
            Case TipoBanco.MySQL
                _conexao = New MySqlConnection(_connectionString)
            Case TipoBanco.Oracle
                _conexao = New OracleConnection(_connectionString)
            Case TipoBanco.Postgre
                _conexao = New NpgsqlConnection(_connectionString)
            Case TipoBanco.SQLServer
                _conexao = New SqlConnection(_connectionString)
        End Select
        _conexao.Open()
        Return _conexao
    End Function

    Public Sub FecharConexao()
        If _conexao IsNot Nothing AndAlso _conexao.State <> ConnectionState.Closed Then
            _conexao.Close()
        End If
    End Sub
End Class


