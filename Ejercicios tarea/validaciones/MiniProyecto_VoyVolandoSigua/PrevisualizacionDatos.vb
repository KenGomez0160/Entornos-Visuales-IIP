Imports System.ComponentModel

Public Class PrevisualizacionDatos
    Private Sub PrevisualizacionDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdentidad.Text = Usuarios.usuario(Usuarios.posicion, 0)
        txtNombreCompleto.Text = Usuarios.usuario(Usuarios.posicion, 1)
        txtEdad.Text = Usuarios.usuario(Usuarios.posicion, 2)
        If Usuarios.usuario(Usuarios.posicion, 3) = "Femenino" Then
            chkFemenino.Checked = True
        Else
            chkMasculino.Checked = True
        End If
        txtHistorial.Text = Usuarios.usuario(Usuarios.posicion, 8)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
        BuscarUsuario.Hide()
        Mandados.Show()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Identidad del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreCompleto_MouseHover(sender As Object, e As EventArgs) Handles txtNombreCompleto.MouseHover
        ToolTip.SetToolTip(txtNombreCompleto, "nombre del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Edad de cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkMasculino_MouseHover(sender As Object, e As EventArgs) Handles chkMasculino.MouseHover
        ToolTip.SetToolTip(chkMasculino, "Masculino")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkFemenino_MouseHover(sender As Object, e As EventArgs) Handles chkFemenino.MouseHover
        ToolTip.SetToolTip(chkFemenino, "Femenino")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCancelar_MouseHover(sender As Object, e As EventArgs) Handles btnCancelar.MouseHover
        ToolTip.SetToolTip(btnCancelar, "Cancela la revision de informacion")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAceptar_MouseHover(sender As Object, e As EventArgs) Handles btnAceptar.MouseHover
        ToolTip.SetToolTip(btnAceptar, "Informacion correcta")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtHistorial_MouseHover(sender As Object, e As EventArgs) Handles txtHistorial.MouseHover
        ToolTip.SetToolTip(txtHistorial, "Historial de mandados del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        BaseDeDatosClientes.Show()
    End Sub



End Class