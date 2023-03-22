
Imports System.Configuration
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports MySql.Data.MySqlClient
Imports Npgsql

Public Class FormConexao
    Private connStringBuilder As New DbConnectionStringBuilder
    Private Banco As String

    Private Sub FormConexao_Load(sender As Object, e As EventArgs)
        LimparCampos()
        DesabilitaCampos()
    End Sub

    Private Sub RbAccess_CheckedChanged(sender As Object, e As EventArgs) Handles RbAccess.CheckedChanged
        Banco = "Access"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Private Sub RbExcel_CheckedChanged(sender As Object, e As EventArgs) Handles RbExcel.CheckedChanged
        Banco = "Excel"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Private Sub RbMySQL_CheckedChanged(sender As Object, e As EventArgs) Handles RbMySQL.CheckedChanged
        Banco = "MySQL"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Private Sub RbOracle_CheckedChanged(sender As Object, e As EventArgs) Handles RbOracle.CheckedChanged
        Banco = "Oracle"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Private Sub RbPostgre_CheckedChanged(sender As Object, e As EventArgs) Handles RbPostgre.CheckedChanged
        Banco = "PostgreSQL"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Private Sub RbSQLite_CheckedChanged(sender As Object, e As EventArgs) Handles RbSQLite.CheckedChanged
        Banco = "SQLite"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Private Sub RbSQLServer_CheckedChanged(sender As Object, e As EventArgs) Handles RbSQLServer.CheckedChanged
        Banco = "SQLServer"
        ProvedorSelecionado()
        DesabilitaCampos()
    End Sub

    Public Sub ProvedorSelecionado()
        LimparCampos()
        TextConnectionString.Text = ConexaoBLL.ObterStringConexao(Banco)
        ObterConnectionString(Banco)
    End Sub

    Private Sub BtTestarConexao_Click(sender As Object, e As EventArgs) Handles BtTestarConexao.Click
        Dim ConexaoB As New ConexaoBLL
        LbResultado.ForeColor = Color.LightSkyBlue
        LbResultado.Text = "Aguarde... Testando conexão com " & Banco
        Application.DoEvents()

        If RbAccess.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.Access)
        ElseIf RbExcel.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.Excel)
        ElseIf RbOracle.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.Oracle)
        ElseIf RbMySQL.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.MySQL)
        ElseIf RbPostgre.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.Postgre)
        ElseIf RbSQLite.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.SQLite)
        ElseIf RbSQLServer.Checked Then
            LbResultado.Text = ConexaoB.TestaConexao(Provedor.SQLServer)
        End If
        If LbResultado.Text.Contains("sucedida") Then
            LbResultado.ForeColor = Color.Lime
        Else
            LbResultado.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ObterConnectionString(Provedor As String)
        Try
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim connectionString As ConnectionStringSettings = config.ConnectionStrings.ConnectionStrings(Banco)
            connStringBuilder.ConnectionString = connectionString.ConnectionString
            Select Case Provedor
                Case "Access", "Excel", "SQLite"
                    TextHost.Text = connStringBuilder("Data Source").ToString()
                Case "MySQL"
                    TextHost.Text = connStringBuilder("Server").ToString()
                    TextBanco.Text = connStringBuilder("Database").ToString()
                    'TextPorta.Text = connStringBuilder("Port").ToString()
                    TextUsuario.Text = connStringBuilder("Uid").ToString()
                    TextSenha.Text = connStringBuilder("Pwd").ToString()
                Case "Oracle"
                    TextHost.Text = connStringBuilder("Data Source").ToString()
                    TextUsuario.Text = connStringBuilder("User ID").ToString()
                    TextSenha.Text = connStringBuilder("Password").ToString()
                Case "PostgreSQL"
                    TextHost.Text = connStringBuilder("Host").ToString()
                    'TextPorta.Text = connStringBuilder("Port").ToString()
                    TextBanco.Text = connStringBuilder("Database").ToString()
                    TextUsuario.Text = connStringBuilder("UserName").ToString()
                    TextSenha.Text = connStringBuilder("Password").ToString()
                Case "SQLServer"
                    TextHost.Text = connStringBuilder("Data Source").ToString()
                    TextBanco.Text = connStringBuilder("Initial Catalog").ToString()
                    TextUsuario.Text = connStringBuilder("UserID").ToString()
                    TextSenha.Text = connStringBuilder("Password").ToString()
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        Try
            If BtnAlterar.Text = "Alterar" Then
                HabilitaCampos()
                Select Case Banco
                    Case "Access", "Excel", "SQLite"
                        TextPorta.Enabled = False
                        TextBanco.Enabled = False
                        TextUsuario.Enabled = False
                        TextSenha.Enabled = False
                    Case "MySQL", "PostgreSQL", "SQLServer"
                        TextPorta.Enabled = False
                    Case "Oracle"
                        TextPorta.Enabled = False
                        TextBanco.Enabled = False
                End Select
            Else
                Dim configuration As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                Dim connectionStringsSection As ConnectionStringsSection = ConfigurationManager.GetSection("connectionStrings")
                Dim connectionString As ConnectionStringSettings = configuration.ConnectionStrings.ConnectionStrings(Banco)
                Dim connBuilder As New DbConnectionStringBuilder With {
                    .ConnectionString = connectionString.ConnectionString
                }
                Select Case Banco
                    Case "Access", "Excel", "SQLite"
                        If Banco = "SQLite" Then
                            connBuilder = New SQLiteConnectionStringBuilder(connectionString.ConnectionString)
                        Else
                            connBuilder = New OleDbConnectionStringBuilder(connectionString.ConnectionString)
                        End If
                        connBuilder("Data Source") = TextHost.Text
                    Case "Oracle"
                        connStringBuilder = New OracleConnectionStringBuilder(connectionString.ConnectionString)
                        connBuilder("Data Source") = TextHost.Text
                        connBuilder("User ID") = TextUsuario.Text
                        connBuilder("Password") = TextSenha.Text
                    Case "MySQL"
                        connBuilder = New MySqlConnectionStringBuilder(connectionString.ConnectionString)
                        connBuilder("Server") = TextHost.Text
                        'connBuilder("Port") = TextPorta.Text
                        connBuilder("Database") = TextBanco.Text
                        connBuilder("Uid") = TextUsuario.Text
                        connBuilder("Pwd") = TextSenha.Text
                    Case "PostgreSQL"
                        connBuilder = New NpgsqlConnectionStringBuilder(connectionString.ConnectionString)
                        connBuilder("Server") = TextHost.Text
                        'connBuilder("Port") = TextPorta.Text
                        connBuilder("Database") = TextBanco.Text
                        connBuilder("Username") = TextUsuario.Text
                        connBuilder("Password") = TextSenha.Text
                    Case "SQLServer"
                        connBuilder = New SqlConnectionStringBuilder(connectionString.ConnectionString)
                        connBuilder("Server") = TextHost.Text
                        connBuilder("Initial Catalog") = TextBanco.Text
                        connBuilder("User ID") = TextUsuario.Text
                        connBuilder("Password") = TextSenha.Text
                End Select
                ' atualiza a connectionstring no arquivo app.config
                connectionString.ConnectionString = connBuilder.ConnectionString
                configuration.Save()
                ConfigurationManager.RefreshSection("connectionStrings")
                DesabilitaCampos()
                ' informa ao usuário que as alterações foram salvas com sucesso
                MessageBox.Show("Alterações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            TextConnectionString.Text = ConexaoBLL.ObterStringConexao(Banco)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DesabilitaCampos()
    End Sub

    Private Sub LimparCampos()
        TextHost.Text = ""
        TextPorta.Text = ""
        TextBanco.Text = ""
        TextUsuario.Text = ""
        TextSenha.Text = ""
        LbResultado.Text = ""
        TextConnectionString.Text = ""
    End Sub

    Private Sub HabilitaCampos()
        BtnAlterar.Text = "Salvar"
        TextHost.Enabled = True
        TextPorta.Enabled = True
        TextBanco.Enabled = True
        TextUsuario.Enabled = True
        TextSenha.Enabled = True
        BtnCancelar.Enabled = True
    End Sub

    Private Sub DesabilitaCampos()
        BtnAlterar.Text = "Alterar"
        TextHost.Enabled = False
        TextPorta.Enabled = False
        TextBanco.Enabled = False
        TextUsuario.Enabled = False
        TextSenha.Enabled = False
        BtnCancelar.Enabled = False
    End Sub

End Class
