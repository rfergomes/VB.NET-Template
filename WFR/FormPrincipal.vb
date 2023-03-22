Imports System.Drawing.Text
Imports FontAwesome.Sharp

Public Class FormPrincipal
    Private BotaoAtivo As IconButton
    Private ReadOnly BordaEsquerdaBotao As Panel
    Private FormFilhoAtivo As Form

    'Construtor
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        BordaEsquerdaBotao = New Panel With {
            .Size = New Size(8, 50)
        }
        PanelMenu.Controls.Add(BordaEsquerdaBotao)
    End Sub


    Private Sub BtnMenu1_Click(sender As Object, e As EventArgs) Handles BtnMenu1.Click
        BotaoAtivado(sender, RGBCor.Cor1)
        'AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub BtnMenu2_Click(sender As Object, e As EventArgs) Handles BtnMenu2.Click
        BotaoAtivado(sender, RGBCor.Cor2)
        'AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub BtnMenu3_Click(sender As Object, e As EventArgs) Handles BtnMenu3.Click
        BotaoAtivado(sender, RGBCor.Cor3)
        'AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub BtnMenu4_Click(sender As Object, e As EventArgs) Handles BtnMenu4.Click
        BotaoAtivado(sender, RGBCor.Cor4)
        'AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub BtnMenu5_Click(sender As Object, e As EventArgs) Handles BtnMenu5.Click
        BotaoAtivado(sender, RGBCor.Cor5)
        'AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub BtnMenu6_Click(sender As Object, e As EventArgs) Handles BtnMenu6.Click
        BotaoAtivado(sender, RGBCor.Cor6)
        AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub BtnMenu7_Click(sender As Object, e As EventArgs) Handles BtnMenu7.Click
        BotaoAtivado(sender, RGBCor.Cor1)
        'AbrirFormFilho(New FormConexao)
    End Sub

    Private Sub ImgLogo_Click(sender As Object, e As EventArgs) Handles ImgLogo.Click
        FormFilhoAtivo?.Close()
        Reset()
    End Sub

    'Métodos
    Private Sub BotaoAtivado(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            BotaoDesativado()
            'Botão
            BotaoAtivo = CType(senderBtn, IconButton)
            BotaoAtivo.BackColor = Color.FromArgb(27, 37, 85)
            BotaoAtivo.ForeColor = customColor
            BotaoAtivo.IconColor = customColor
            BotaoAtivo.TextAlign = ContentAlignment.MiddleCenter
            BotaoAtivo.ImageAlign = ContentAlignment.MiddleRight
            BotaoAtivo.TextImageRelation = TextImageRelation.TextBeforeImage

            'Borda Esqerda
            BordaEsquerdaBotao.BackColor = customColor
            BordaEsquerdaBotao.Location = New Point(0, BotaoAtivo.Location.Y)
            BordaEsquerdaBotao.Visible = True
            BordaEsquerdaBotao.BringToFront()

            'Icone Formulário Ativo
            IconCurrentForm.IconChar = BotaoAtivo.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub
    Private Sub BotaoDesativado()
        If BotaoAtivo IsNot Nothing Then
            'Botão
            BotaoAtivo.BackColor = Color.FromArgb(31, 30, 68)
            BotaoAtivo.ForeColor = Color.Gainsboro
            BotaoAtivo.IconColor = Color.Gainsboro
            BotaoAtivo.TextAlign = ContentAlignment.MiddleLeft
            BotaoAtivo.ImageAlign = ContentAlignment.MiddleLeft
            BotaoAtivo.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub AbrirFormFilho(FormFilho As Form)
        Application.DoEvents()
        'Abrir apenas um Form
        FormFilhoAtivo?.Close()
        FormFilhoAtivo = FormFilho
        FormFilho.TopLevel = False
        FormFilho.FormBorderStyle = FormBorderStyle.None
        FormFilho.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(FormFilho)
        PanelDesktop.Tag = FormFilho
        FormFilho.BringToFront()
        FormFilho.Show()
        LabelCuttentForm.Text = FormFilho.Text
    End Sub

    Private Sub Reset()
        BotaoDesativado()
        BordaEsquerdaBotao.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        LabelCuttentForm.Text = "Home"
    End Sub

End Class