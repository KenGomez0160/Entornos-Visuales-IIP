Public Class BaseDeDatosClientes
    Private Sub BaseDeDatosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 10 Step 1
            dgvBase.Rows.Add(Usuarios.usuario(i, 0), Usuarios.usuario(i, 1), Usuarios.usuario(i, 2), Usuarios.usuario(i, 3), Usuarios.usuario(i, 4), Usuarios.usuario(i, 8))
        Next
    End Sub
End Class