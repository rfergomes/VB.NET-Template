<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        PanelMenu = New Panel()
        PanelInfo = New Panel()
        BtnMenu7 = New FontAwesome.Sharp.IconButton()
        BtnMenu6 = New FontAwesome.Sharp.IconButton()
        BtnMenu5 = New FontAwesome.Sharp.IconButton()
        BtnMenu4 = New FontAwesome.Sharp.IconButton()
        BtnMenu3 = New FontAwesome.Sharp.IconButton()
        BtnMenu2 = New FontAwesome.Sharp.IconButton()
        BtnMenu1 = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        ImgLogo = New PictureBox()
        PanelTitleBar = New Panel()
        PanelSubTitleBar = New Panel()
        LabelCuttentForm = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PictureBox1 = New PictureBox()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(ImgLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelSubTitleBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PanelMenu.Controls.Add(PanelInfo)
        PanelMenu.Controls.Add(BtnMenu7)
        PanelMenu.Controls.Add(BtnMenu6)
        PanelMenu.Controls.Add(BtnMenu5)
        PanelMenu.Controls.Add(BtnMenu4)
        PanelMenu.Controls.Add(BtnMenu3)
        PanelMenu.Controls.Add(BtnMenu2)
        PanelMenu.Controls.Add(BtnMenu1)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.ForeColor = Color.Coral
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 661)
        PanelMenu.TabIndex = 0
        ' 
        ' PanelInfo
        ' 
        PanelInfo.Dock = DockStyle.Bottom
        PanelInfo.Location = New Point(0, 561)
        PanelInfo.Name = "PanelInfo"
        PanelInfo.Size = New Size(220, 100)
        PanelInfo.TabIndex = 2
        ' 
        ' BtnMenu7
        ' 
        BtnMenu7.Cursor = Cursors.Hand
        BtnMenu7.Dock = DockStyle.Top
        BtnMenu7.FlatAppearance.BorderSize = 0
        BtnMenu7.FlatStyle = FlatStyle.Flat
        BtnMenu7.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu7.ForeColor = Color.Gainsboro
        BtnMenu7.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        BtnMenu7.IconColor = Color.Gainsboro
        BtnMenu7.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu7.IconSize = 32
        BtnMenu7.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu7.Location = New Point(0, 400)
        BtnMenu7.Name = "BtnMenu7"
        BtnMenu7.Padding = New Padding(10, 0, 20, 0)
        BtnMenu7.Size = New Size(220, 50)
        BtnMenu7.TabIndex = 10
        BtnMenu7.Text = "Dashboard"
        BtnMenu7.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu7.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu7.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu6
        ' 
        BtnMenu6.Cursor = Cursors.Hand
        BtnMenu6.Dock = DockStyle.Top
        BtnMenu6.FlatAppearance.BorderSize = 0
        BtnMenu6.FlatStyle = FlatStyle.Flat
        BtnMenu6.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu6.ForeColor = Color.Gainsboro
        BtnMenu6.IconChar = FontAwesome.Sharp.IconChar.Tools
        BtnMenu6.IconColor = Color.Gainsboro
        BtnMenu6.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu6.IconSize = 32
        BtnMenu6.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu6.Location = New Point(0, 350)
        BtnMenu6.Name = "BtnMenu6"
        BtnMenu6.Padding = New Padding(10, 0, 20, 0)
        BtnMenu6.Size = New Size(220, 50)
        BtnMenu6.TabIndex = 9
        BtnMenu6.Text = "Sistema"
        BtnMenu6.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu6.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu6.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu5
        ' 
        BtnMenu5.Cursor = Cursors.Hand
        BtnMenu5.Dock = DockStyle.Top
        BtnMenu5.FlatAppearance.BorderSize = 0
        BtnMenu5.FlatStyle = FlatStyle.Flat
        BtnMenu5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu5.ForeColor = Color.Gainsboro
        BtnMenu5.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking
        BtnMenu5.IconColor = Color.Gainsboro
        BtnMenu5.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu5.IconSize = 32
        BtnMenu5.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu5.Location = New Point(0, 300)
        BtnMenu5.Name = "BtnMenu5"
        BtnMenu5.Padding = New Padding(10, 0, 20, 0)
        BtnMenu5.Size = New Size(220, 50)
        BtnMenu5.TabIndex = 8
        BtnMenu5.Text = "Pedidos"
        BtnMenu5.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu5.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu5.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu4
        ' 
        BtnMenu4.Cursor = Cursors.Hand
        BtnMenu4.Dock = DockStyle.Top
        BtnMenu4.FlatAppearance.BorderSize = 0
        BtnMenu4.FlatStyle = FlatStyle.Flat
        BtnMenu4.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu4.ForeColor = Color.Gainsboro
        BtnMenu4.IconChar = FontAwesome.Sharp.IconChar.Headset
        BtnMenu4.IconColor = Color.Gainsboro
        BtnMenu4.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu4.IconSize = 32
        BtnMenu4.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu4.Location = New Point(0, 250)
        BtnMenu4.Name = "BtnMenu4"
        BtnMenu4.Padding = New Padding(10, 0, 20, 0)
        BtnMenu4.Size = New Size(220, 50)
        BtnMenu4.TabIndex = 7
        BtnMenu4.Text = "Chamados"
        BtnMenu4.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu4.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu4.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu3
        ' 
        BtnMenu3.Cursor = Cursors.Hand
        BtnMenu3.Dock = DockStyle.Top
        BtnMenu3.FlatAppearance.BorderSize = 0
        BtnMenu3.FlatStyle = FlatStyle.Flat
        BtnMenu3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu3.ForeColor = Color.Gainsboro
        BtnMenu3.IconChar = FontAwesome.Sharp.IconChar.TruckField
        BtnMenu3.IconColor = Color.Gainsboro
        BtnMenu3.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu3.IconSize = 32
        BtnMenu3.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu3.Location = New Point(0, 200)
        BtnMenu3.Name = "BtnMenu3"
        BtnMenu3.Padding = New Padding(10, 0, 20, 0)
        BtnMenu3.Size = New Size(220, 50)
        BtnMenu3.TabIndex = 6
        BtnMenu3.Text = "Fornecedores"
        BtnMenu3.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu3.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu3.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu2
        ' 
        BtnMenu2.Cursor = Cursors.Hand
        BtnMenu2.Dock = DockStyle.Top
        BtnMenu2.FlatAppearance.BorderSize = 0
        BtnMenu2.FlatStyle = FlatStyle.Flat
        BtnMenu2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu2.ForeColor = Color.Gainsboro
        BtnMenu2.IconChar = FontAwesome.Sharp.IconChar.Users
        BtnMenu2.IconColor = Color.Gainsboro
        BtnMenu2.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu2.IconSize = 32
        BtnMenu2.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu2.Location = New Point(0, 150)
        BtnMenu2.Name = "BtnMenu2"
        BtnMenu2.Padding = New Padding(10, 0, 20, 0)
        BtnMenu2.Size = New Size(220, 50)
        BtnMenu2.TabIndex = 5
        BtnMenu2.Text = "Clientes"
        BtnMenu2.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu2.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu2.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu1
        ' 
        BtnMenu1.Cursor = Cursors.Hand
        BtnMenu1.Dock = DockStyle.Top
        BtnMenu1.FlatAppearance.BorderSize = 0
        BtnMenu1.FlatStyle = FlatStyle.Flat
        BtnMenu1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMenu1.ForeColor = Color.Gainsboro
        BtnMenu1.IconChar = FontAwesome.Sharp.IconChar.Dashboard
        BtnMenu1.IconColor = Color.Gainsboro
        BtnMenu1.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMenu1.IconSize = 32
        BtnMenu1.ImageAlign = ContentAlignment.MiddleLeft
        BtnMenu1.Location = New Point(0, 100)
        BtnMenu1.Name = "BtnMenu1"
        BtnMenu1.Padding = New Padding(10, 0, 20, 0)
        BtnMenu1.Size = New Size(220, 50)
        BtnMenu1.TabIndex = 4
        BtnMenu1.Text = "Dashboard"
        BtnMenu1.TextAlign = ContentAlignment.MiddleLeft
        BtnMenu1.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMenu1.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(ImgLogo)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(220, 100)
        PanelLogo.TabIndex = 1
        ' 
        ' ImgLogo
        ' 
        ImgLogo.Image = CType(resources.GetObject("ImgLogo.Image"), Image)
        ImgLogo.Location = New Point(23, 12)
        ImgLogo.Name = "ImgLogo"
        ImgLogo.Size = New Size(172, 74)
        ImgLogo.SizeMode = PictureBoxSizeMode.Zoom
        ImgLogo.TabIndex = 4
        ImgLogo.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(220, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(1009, 65)
        PanelTitleBar.TabIndex = 3
        ' 
        ' PanelSubTitleBar
        ' 
        PanelSubTitleBar.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PanelSubTitleBar.Controls.Add(LabelCuttentForm)
        PanelSubTitleBar.Controls.Add(IconCurrentForm)
        PanelSubTitleBar.Dock = DockStyle.Top
        PanelSubTitleBar.Location = New Point(220, 65)
        PanelSubTitleBar.Name = "PanelSubTitleBar"
        PanelSubTitleBar.Size = New Size(1009, 35)
        PanelSubTitleBar.TabIndex = 4
        ' 
        ' LabelCuttentForm
        ' 
        LabelCuttentForm.AutoSize = True
        LabelCuttentForm.ForeColor = Color.MediumPurple
        LabelCuttentForm.Location = New Point(41, 6)
        LabelCuttentForm.Name = "LabelCuttentForm"
        LabelCuttentForm.Size = New Size(64, 15)
        LabelCuttentForm.TabIndex = 1
        LabelCuttentForm.Text = "Dashboard"' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        IconCurrentForm.ForeColor = Color.MediumPurple
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        IconCurrentForm.IconColor = Color.MediumPurple
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.Location = New Point(3, 0)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(32, 32)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = SystemColors.Window
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(220, 100)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(1009, 561)
        PanelDesktop.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1009, 561)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FormPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1229, 661)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelSubTitleBar)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        Name = "FormPrincipal"
        Text = "FormPrincipal"
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(ImgLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelSubTitleBar.ResumeLayout(False)
        PanelSubTitleBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImgLogo As PictureBox
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents BtnMenu7 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMenu6 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMenu5 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMenu4 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMenu3 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMenu2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMenu1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelSubTitleBar As Panel
    Friend WithEvents LabelCuttentForm As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
