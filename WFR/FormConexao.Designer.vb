<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConexao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormConexao))
        Panel2 = New Panel()
        GroupBox3 = New GroupBox()
        RbOracle = New RadioButton()
        RbSQLServer = New RadioButton()
        RbSQLite = New RadioButton()
        RbPostgre = New RadioButton()
        RbMySQL = New RadioButton()
        RbExcel = New RadioButton()
        RbAccess = New RadioButton()
        Panel3 = New Panel()
        GroupBox1 = New GroupBox()
        BtnCancelar = New Button()
        BtnAlterar = New Button()
        Label7 = New Label()
        TextSenha = New TextBox()
        Label5 = New Label()
        TextUsuario = New TextBox()
        Label6 = New Label()
        TextBanco = New TextBox()
        Label4 = New Label()
        TextPorta = New TextBox()
        Label3 = New Label()
        TextHost = New TextBox()
        Label2 = New Label()
        Panel4 = New Panel()
        GroupBox2 = New GroupBox()
        LbResultado = New Label()
        Label8 = New Label()
        BtTestarConexao = New Button()
        TextConnectionString = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        Panel2.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel4.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(GroupBox3)
        Panel2.Location = New Point(9, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(883, 97)
        Panel2.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RbOracle)
        GroupBox3.Controls.Add(RbSQLServer)
        GroupBox3.Controls.Add(RbSQLite)
        GroupBox3.Controls.Add(RbPostgre)
        GroupBox3.Controls.Add(RbMySQL)
        GroupBox3.Controls.Add(RbExcel)
        GroupBox3.Controls.Add(RbAccess)
        GroupBox3.FlatStyle = FlatStyle.System
        GroupBox3.Location = New Point(3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(877, 91)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        ' 
        ' RbOracle
        ' 
        RbOracle.Appearance = Appearance.Button
        RbOracle.AutoSize = True
        RbOracle.Cursor = Cursors.Hand
        RbOracle.Image = CType(resources.GetObject("RbOracle.Image"), Image)
        RbOracle.Location = New Point(395, 15)
        RbOracle.Name = "RbOracle"
        RbOracle.Size = New Size(86, 66)
        RbOracle.TabIndex = 19
        RbOracle.TabStop = True
        RbOracle.UseVisualStyleBackColor = True
        ' 
        ' RbSQLServer
        ' 
        RbSQLServer.Appearance = Appearance.Button
        RbSQLServer.AutoSize = True
        RbSQLServer.Cursor = Cursors.Hand
        RbSQLServer.Image = CType(resources.GetObject("RbSQLServer.Image"), Image)
        RbSQLServer.Location = New Point(782, 15)
        RbSQLServer.Name = "RbSQLServer"
        RbSQLServer.Size = New Size(86, 66)
        RbSQLServer.TabIndex = 18
        RbSQLServer.TabStop = True
        RbSQLServer.UseVisualStyleBackColor = True
        ' 
        ' RbSQLite
        ' 
        RbSQLite.Appearance = Appearance.Button
        RbSQLite.AutoSize = True
        RbSQLite.Cursor = Cursors.Hand
        RbSQLite.Image = CType(resources.GetObject("RbSQLite.Image"), Image)
        RbSQLite.Location = New Point(653, 15)
        RbSQLite.Name = "RbSQLite"
        RbSQLite.Size = New Size(86, 66)
        RbSQLite.TabIndex = 17
        RbSQLite.TabStop = True
        RbSQLite.UseVisualStyleBackColor = True
        ' 
        ' RbPostgre
        ' 
        RbPostgre.Appearance = Appearance.Button
        RbPostgre.AutoSize = True
        RbPostgre.Cursor = Cursors.Hand
        RbPostgre.Image = CType(resources.GetObject("RbPostgre.Image"), Image)
        RbPostgre.Location = New Point(524, 15)
        RbPostgre.Name = "RbPostgre"
        RbPostgre.Size = New Size(86, 66)
        RbPostgre.TabIndex = 16
        RbPostgre.TabStop = True
        RbPostgre.UseVisualStyleBackColor = True
        ' 
        ' RbMySQL
        ' 
        RbMySQL.Appearance = Appearance.Button
        RbMySQL.AutoSize = True
        RbMySQL.Cursor = Cursors.Hand
        RbMySQL.Image = CType(resources.GetObject("RbMySQL.Image"), Image)
        RbMySQL.Location = New Point(266, 15)
        RbMySQL.Name = "RbMySQL"
        RbMySQL.Size = New Size(86, 66)
        RbMySQL.TabIndex = 15
        RbMySQL.TabStop = True
        RbMySQL.UseVisualStyleBackColor = True
        ' 
        ' RbExcel
        ' 
        RbExcel.Appearance = Appearance.Button
        RbExcel.AutoSize = True
        RbExcel.Cursor = Cursors.Hand
        RbExcel.Image = CType(resources.GetObject("RbExcel.Image"), Image)
        RbExcel.Location = New Point(137, 15)
        RbExcel.Name = "RbExcel"
        RbExcel.Size = New Size(86, 66)
        RbExcel.TabIndex = 14
        RbExcel.TabStop = True
        RbExcel.UseVisualStyleBackColor = True
        ' 
        ' RbAccess
        ' 
        RbAccess.Appearance = Appearance.Button
        RbAccess.AutoSize = True
        RbAccess.Cursor = Cursors.Hand
        RbAccess.Image = CType(resources.GetObject("RbAccess.Image"), Image)
        RbAccess.Location = New Point(8, 15)
        RbAccess.Name = "RbAccess"
        RbAccess.Size = New Size(86, 66)
        RbAccess.TabIndex = 13
        RbAccess.TabStop = True
        RbAccess.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(GroupBox1)
        Panel3.Location = New Point(9, 104)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(438, 278)
        Panel3.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnCancelar)
        GroupBox1.Controls.Add(BtnAlterar)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextSenha)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextUsuario)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBanco)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextPorta)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextHost)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(432, 272)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Enabled = False
        BtnCancelar.Location = New Point(146, 233)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(94, 23)
        BtnCancelar.TabIndex = 26
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' BtnAlterar
        ' 
        BtnAlterar.Location = New Point(46, 233)
        BtnAlterar.Name = "BtnAlterar"
        BtnAlterar.Size = New Size(94, 23)
        BtnAlterar.TabIndex = 27
        BtnAlterar.Text = "Alterar"
        BtnAlterar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(41, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(154, 25)
        Label7.TabIndex = 24
        Label7.Text = "Dados de Acesso"' 
        ' TextSenha
        ' 
        TextSenha.Location = New Point(156, 177)
        TextSenha.Name = "TextSenha"
        TextSenha.Size = New Size(182, 23)
        TextSenha.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(156, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 22
        Label5.Text = "Senha"' 
        ' TextUsuario
        ' 
        TextUsuario.Location = New Point(46, 176)
        TextUsuario.Name = "TextUsuario"
        TextUsuario.Size = New Size(86, 23)
        TextUsuario.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(46, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 20
        Label6.Text = "Usuário"' 
        ' TextBanco
        ' 
        TextBanco.Location = New Point(156, 127)
        TextBanco.Name = "TextBanco"
        TextBanco.Size = New Size(182, 23)
        TextBanco.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(156, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 15)
        Label4.TabIndex = 18
        Label4.Text = "Nome do Banco"' 
        ' TextPorta
        ' 
        TextPorta.Location = New Point(46, 127)
        TextPorta.Name = "TextPorta"
        TextPorta.Size = New Size(86, 23)
        TextPorta.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 16
        Label3.Text = "Porta"' 
        ' TextHost
        ' 
        TextHost.Location = New Point(46, 78)
        TextHost.Name = "TextHost"
        TextHost.Size = New Size(292, 23)
        TextHost.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 13
        Label2.Text = "Caminho/Host"' 
        ' Panel4
        ' 
        Panel4.Controls.Add(GroupBox2)
        Panel4.Location = New Point(454, 104)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(438, 278)
        Panel4.TabIndex = 4
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(LbResultado)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(BtTestarConexao)
        GroupBox2.Controls.Add(TextConnectionString)
        GroupBox2.Location = New Point(3, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(432, 272)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' LbResultado
        ' 
        LbResultado.BackColor = SystemColors.ActiveCaptionText
        LbResultado.ForeColor = Color.Lime
        LbResultado.Location = New Point(6, 177)
        LbResultado.Name = "LbResultado"
        LbResultado.RightToLeft = RightToLeft.No
        LbResultado.Size = New Size(420, 92)
        LbResultado.TabIndex = 19
        LbResultado.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(6, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(130, 21)
        Label8.TabIndex = 18
        Label8.Text = "ConnectionString"' 
        ' BtTestarConexao
        ' 
        BtTestarConexao.Location = New Point(132, 127)
        BtTestarConexao.Name = "BtTestarConexao"
        BtTestarConexao.Size = New Size(153, 41)
        BtTestarConexao.TabIndex = 16
        BtTestarConexao.Text = "Testar Conexão"
        BtTestarConexao.UseVisualStyleBackColor = True
        ' 
        ' TextConnectionString
        ' 
        TextConnectionString.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextConnectionString.BackColor = SystemColors.Info
        TextConnectionString.BorderStyle = BorderStyle.None
        TextConnectionString.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextConnectionString.ForeColor = Color.Coral
        TextConnectionString.Location = New Point(6, 43)
        TextConnectionString.Multiline = True
        TextConnectionString.Name = "TextConnectionString"
        TextConnectionString.PlaceholderText = "Cadeia de Conexão"
        TextConnectionString.ReadOnly = True
        TextConnectionString.Size = New Size(420, 72)
        TextConnectionString.TabIndex = 17
        TextConnectionString.TextAlign = HorizontalAlignment.Center
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"' 
        ' FormConexao
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(994, 531)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Name = "FormConexao"
        Text = "Configurações do Sistema"
        Panel2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        Panel3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel4.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAlterar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextSenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBanco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextPorta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextHost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LbResultado As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtTestarConexao As Button
    Friend WithEvents TextConnectionString As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbOracle As RadioButton
    Friend WithEvents RbSQLServer As RadioButton
    Friend WithEvents RbSQLite As RadioButton
    Friend WithEvents RbPostgre As RadioButton
    Friend WithEvents RbMySQL As RadioButton
    Friend WithEvents RbExcel As RadioButton
    Friend WithEvents RbAccess As RadioButton
End Class
