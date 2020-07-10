Public Class RegistrarUsuarios

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Usuarios.cantidadClientes += 1
        Usuarios.posicion = Usuarios.cantidadClientes

        Try
            If Me.ValidateChildren And txtIdentidad.Text <> String.Empty And txtNombreCompleto.Text <> String.Empty And txtEdad.Text <> String.Empty And (chkFemenino.Checked = True Or chkMasculino.Checked = True) And txtDireccion.Text <> String.Empty And IsNumeric(txtEdad.Text) Then
                Usuarios.usuario(Usuarios.cantidadClientes, 0) = txtIdentidad.Text
                Usuarios.usuario(Usuarios.cantidadClientes, 1) = txtNombreCompleto.Text
                Usuarios.usuario(Usuarios.cantidadClientes, 2) = txtEdad.Text
                If chkFemenino.Checked = True Then
                    Usuarios.usuario(Usuarios.cantidadClientes, 3) = "Femenino"
                ElseIf chkMasculino.Checked = True Then
                    Usuarios.usuario(Usuarios.cantidadClientes, 3) = "Masculino"
                End If
                Usuarios.usuario(Usuarios.cantidadClientes, 4) = txtDireccion.Text
                MessageBox.Show("cliente Guardado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Usuarios.usuario(Usuarios.cantidadClientes, 8) = 0
                Me.Close()
                Mandados.Show()
            Else
                MessageBox.Show("Verifique que todos los campos esten completos y escritos correctamente", "Casillas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chkMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasculino.CheckedChanged
        If chkMasculino.Checked = True Then
            chkFemenino.Enabled = False
        Else
            chkFemenino.Enabled = True
        End If
    End Sub

    Private Sub chkFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles chkFemenino.CheckedChanged
        If chkFemenino.Checked = True Then
            chkMasculino.Enabled = False
        Else
            chkMasculino.Enabled = True
        End If
    End Sub

    Private Sub RegistrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdentidad.Text = Usuarios.IdentidadTemp
    End Sub

    Private Sub txtNombreCompleto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreCompleto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
            If (Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0) Then
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Ingrese una edad valida")
            End If
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub chkFemenino_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles chkFemenino.Validating
        If chkFemenino.Checked = True Or chkMasculino.Checked = True Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario seleccionar una de ambas")
        End If
    End Sub

    Private Sub chkMasculino_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles chkMasculino.Validating
        If chkFemenino.Checked = True Or chkMasculino.Checked = True Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario seleccionar una de ambas")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreCompleto_MouseHover(sender As Object, e As EventArgs) Handles txtNombreCompleto.MouseHover
        ToolTip.SetToolTip(txtNombreCompleto, "Nombre completo del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Edad del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Identidad del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkMasculino_MouseHover(sender As Object, e As EventArgs) Handles chkMasculino.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Masculino")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkFemenino_MouseHover(sender As Object, e As EventArgs) Handles chkFemenino.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Femenino")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Dirección del domicilio del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
