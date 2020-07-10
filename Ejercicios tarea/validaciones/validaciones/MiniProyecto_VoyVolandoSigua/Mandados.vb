Public Class Mandados

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Identidad del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtRecorrido_MouseHover(sender As Object, e As EventArgs) Handles txtRecorrido.MouseHover
        ToolTip.SetToolTip(txtRecorrido, "Distancia de la entrega(Km)")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbTipoMandado_MouseHover(sender As Object, e As EventArgs) Handles cmbTipoMandado.MouseHover
        ToolTip.SetToolTip(cmbTipoMandado, "Tipo de mandado a realizar")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip.SetToolTip(txtPrecio, "Costo del mandado")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnMandado_MouseHover(sender As Object, e As EventArgs) Handles btnMandado.MouseHover
        ToolTip.SetToolTip(btnMandado, "carga los datos del mandado")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMotoristas_MouseHover(sender As Object, e As EventArgs) Handles txtMotoristas.MouseHover
        ToolTip.SetToolTip(txtMotoristas, "cantidad de motoristas disponibles")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Mandados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdentidad.Text = Usuarios.IdentidadTemp
    End Sub

    Private Sub btnMandado_Click(sender As Object, e As EventArgs) Handles btnMandado.Click

        Try
            If Me.ValidateChildren And txtRecorrido.Text <> String.Empty And cmbTipoMandado.Text <> String.Empty And IsNumeric(txtRecorrido.Text) Then
                Usuarios.usuario(Usuarios.posicion, 5) = txtRecorrido.Text
                Usuarios.usuario(Usuarios.posicion, 6) = cmbTipoMandado.SelectedItem
                Usuarios.usuario(posicion, 8) = Val(Usuarios.usuario(posicion, 8)) + 1
                Me.Close()
                BuscarUsuario.Show()
            Else
                MessageBox.Show("Asegurese de ingresar todos los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtRecorrido_TextChanged(sender As Object, e As EventArgs) Handles txtRecorrido.TextChanged
        If txtRecorrido.Text <> "" Then
            Usuarios.usuario(Usuarios.posicion, 7) = Val(txtRecorrido.Text) * 10
            txtPrecio.Text = Usuarios.usuario(Usuarios.posicion, 7)
        Else
            txtPrecio.Text = ""
        End If
    End Sub
End Class