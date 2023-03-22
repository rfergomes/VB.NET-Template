
Imports System.Configuration

Public Class ConexaoBLL
    Private ReadOnly ConexaoDAL As New ConexaoDAL

    Public Function Inserir(Conexao As Conexao) As Boolean
        Return ConexaoDAL.Insert(Conexao, Provedor.SQLite)
    End Function

    Public Function Atualizar(Conexao As Conexao) As Boolean
        Return ConexaoDAL.Update(Conexao, Provedor.SQLite)
    End Function

    Public Function Excluir(Conexao As Conexao) As Boolean
        Return ConexaoDAL.Delete(Conexao, Provedor.SQLite)
    End Function

    Public Function ObterPorId(id As Integer) As Conexao
        Return ConexaoDAL.GetById(id, Provedor.SQLite)
    End Function

    Public Function ObterTodos(Database As Provedor) As List(Of Conexao)
        Return ConexaoDAL.GetAll(Database)
    End Function

    Public Shared Function ObterStringConexao(Provedor As String) As String
        Dim ConfigValue As String = ConfigurationManager.ConnectionStrings(Provedor).ConnectionString
        Try
            Return ConfigValue
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub SalvarStringConexao(Provedor As String, Texto As String)
        Try
            'Salvar uma nova configuração ou atualizar uma existente no App.config'
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim setting As KeyValueConfigurationElement = config.AppSettings.Settings(Provedor)
            If setting Is Nothing Then
                'Criar uma nova chave de configuração'
                config.AppSettings.Settings.Add(Provedor, Texto)
            Else
                'Atualizar o valor de uma chave de configuração existente'
                setting.Value = Texto
            End If
            'Salvar as alterações no App.config'
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("connectionStrings")
            MessageBox.Show("Configuração salva com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Sub ExcluirStringConexao(Provedor As String)
        Try
            'Remover uma chave de configuração do App.config'
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config.AppSettings.Settings.Remove(Provedor)
            'Salvar as alterações no App.config'
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("connectionStrings")
            MessageBox.Show("Configuração removida com sucesso!")
        Catch ex As Exception
            Dim unused = MsgBox(ex.Message)
        End Try
    End Sub

    Public Function TestaConexao(database As Provedor) As String
        Try
            Dim resultado As String = ConexaoDAL.GetConexaoBanco(database)
            Return resultado
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
