Public Class BuscarUsuario
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim verdadero As Integer
        Dim identidad As String
        verdadero = 0

        identidad = txtIdentidad.Text

        If identidad.Length = 13 And IsNumeric(txtIdentidad.Text) Then
            For i = 0 To 10 Step 1
                If identidad = Usuarios.usuario(i, 0) Then
                    verdadero = 1
                    Usuarios.posicion = i
                End If
            Next

            If verdadero = 1 Then
                PrevisualizacionDatos.Show()
            Else
                Usuarios.IdentidadTemp = identidad
                MessageBox.Show("No se encontro registro del cliente en el sistema,se registrara el cliente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Hide()
                RegistrarUsuarios.Show()
            End If
        Else
            MessageBox.Show("Ingrese un numero de identidad valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Identidad del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip.SetToolTip(btnBuscar, "Busca al cliente en la base de datos")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class