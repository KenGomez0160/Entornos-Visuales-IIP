Public Class FrmBolsaSolidaria
    Private e As Object

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim identidad, nombre As String
        Dim cantidad As Integer
        Dim estado, tipoBolsa, direccion As String
        identidad = TxtIdentidad.Text
        VerificaCedula(identidad)
        verificarRegistro()
        agregarRegistro()
        productosbolsa()
    End Sub
    Private Sub agregarRegistro()
        Dim values() As Object = {TxtIdentidad.Text, TxtNombre.Text, TxtTipoBolsa.Text, CbxDepartamento.Text, TxtMunicipio.Text}

        ' Añadimos una nueva fila al control DataGridView
        '
        Dim index As Integer = DgvRegistro.Rows.Add()

        ' Referenciamos la nueva fila
        '
        Dim currentRow As DataGridViewRow = DgvRegistro.Rows(index)

        ' Añadimos los valores a las celdas de la fila
        '
        currentRow.SetValues(values)
    End Sub

    Private Sub FrmBolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboEstado.Items.Add("Pobreza")
        ComboEstado.Items.Add("Pobreza Extrema")
        ComboEstado.Items.Add("Estable")

        CbxDepartamento.Items.Add("Comayagua")
        CbxDepartamento.Items.Add("Francisco Morazan")
        CbxDepartamento.Items.Add("Atlantidad")
        CbxDepartamento.Items.Add("Choluteca")
        CbxDepartamento.Items.Add("Colon")
        CbxDepartamento.Items.Add("Copan")
        CbxDepartamento.Items.Add("Cortes")
        CbxDepartamento.Items.Add("El paraiso")
        CbxDepartamento.Items.Add("Gracias a Dios")
        CbxDepartamento.Items.Add("Intibuca")
        CbxDepartamento.Items.Add("Islas de la Bahia")
        CbxDepartamento.Items.Add("La Paz")
        CbxDepartamento.Items.Add("Lempira")
        CbxDepartamento.Items.Add("Ocotepeque")
        CbxDepartamento.Items.Add("Olancho")
        CbxDepartamento.Items.Add("Santa Barbara")
        CbxDepartamento.Items.Add("Valle")
        CbxDepartamento.Items.Add("Yoro")
    End Sub

    Private Sub TxtIntegrantes_TextChanged(sender As Object, e As EventArgs) Handles TxtIntegrantes.TextChanged
        Dim cantidad As Integer
        Dim bolsa As String

        cantidad = Val(TxtIntegrantes.Text)
        bolsa = TxtTipoBolsa.Text

        If cantidad <= 3 Then
            bolsa = "Bolsa Basica"


        Else
            bolsa = "Bolsa Regular"
        End If
        TxtTipoBolsa.Text = bolsa
        TxtIntegrantes.Text = cantidad
    End Sub
    Private Sub productosbolsa()

        Dim producto As String
        Dim bolsa As String
        bolsa = TxtTipoBolsa.Text
        If bolsa = "Bolsa Basica" Then
            producto = "3 libras de frijoles"
            ListaBolsa.Items.Add(producto)
            producto = "3 libras de arroz"
            ListaBolsa.Items.Add(producto)
            producto = "2 kilos de manteca"
            ListaBolsa.Items.Add(producto)
            producto = "3 bolsas de sal"
            ListaBolsa.Items.Add(producto)
            producto = "1 caja de margarina"
            ListaBolsa.Items.Add(producto)
            producto = "3 bolsas de espaguetes"
            ListaBolsa.Items.Add(producto)
            producto = "1 bolsa de leche en polvo"
            ListaBolsa.Items.Add(producto)
            producto = "1 bolsa de avena"
            ListaBolsa.Items.Add(producto)
            producto = "2 libras de arina "
            ListaBolsa.Items.Add(producto)
            producto = "4 bolsas de cloro"
            ListaBolsa.Items.Add(producto)
            producto = "4 bolsas de detergente"
            ListaBolsa.Items.Add(producto)
            producto = "3 bolsitas de arina de trigo "
            ListaBolsa.Items.Add(producto)
            producto = "4 rollos de papel igienico "
            ListaBolsa.Items.Add(producto)
            producto = "2 jabones"
            ListaBolsa.Items.Add(producto)
            producto = "4 rollos de papel igienico "
            ListaBolsa.Items.Add(producto)
            producto = "4 libras de azucar"
            ListaBolsa.Items.Add(producto)
            producto = " "
            ListaBolsa.Items.Add(producto)

        ElseIf bolsa = "Bolsa Regular" Then
            producto = "6 libras de frijoles"
            ListaBolsa.Items.Add(producto)
            producto = "6 libras de arroz"
            ListaBolsa.Items.Add(producto)
            producto = "4 kilos de manteca"
            ListaBolsa.Items.Add(producto)
            producto = "6 bolsas de sal"
            ListaBolsa.Items.Add(producto)
            producto = "2 cajas de margarina"
            ListaBolsa.Items.Add(producto)
            producto = "6 bolsas de espaguetes"
            ListaBolsa.Items.Add(producto)
            producto = "2 bolsas de leche en polvo"
            ListaBolsa.Items.Add(producto)
            producto = "2 bolsas de avena"
            ListaBolsa.Items.Add(producto)
            producto = "4 libras de arina "
            ListaBolsa.Items.Add(producto)
            producto = "8 bolsas de cloro"
            ListaBolsa.Items.Add(producto)
            producto = "8 bolsas de detergente"
            ListaBolsa.Items.Add(producto)
            producto = "3 bolsitas de arina de trigo "
            ListaBolsa.Items.Add(producto)
            producto = "8 rollos de papel igienico "
            ListaBolsa.Items.Add(producto)
            producto = "4 jabones"
            ListaBolsa.Items.Add(producto)
            producto = "8 libras de azucar"
            ListaBolsa.Items.Add(producto)
            producto = " "
            ListaBolsa.Items.Add(producto)
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtIdentidad.Clear()
        TxtNombre.Clear()
        TxtIntegrantes.Clear()
        TxtMunicipio.Clear()
        TxtTipoBolsa.Clear()



    End Sub

    Public Function VerificaCedula(Cedula As String) As Boolean
        VerificaCedula = True
        If Len(Trim(Cedula)) <> 13 Then
            VerificaCedula = False
        End If

        If VerificaCedula = False Then
            MsgBox("Cedula incorrecta ", vbInformation)


        End If
        Return Cedula

    End Function

    Private Sub verificarRegistro()
        Dim existeElDato As Boolean = False
        For Each itm As DataGridViewRow In DgvRegistro.Rows
            If itm.Cells(0).Value = TxtIdentidad.Text Then
                existeElDato = True
            End If
        Next
        If Me.DgvRegistro.Rows.Count > 0 AndAlso existeElDato = True Then
            MsgBox("Éste registro ya existe", MsgBoxStyle.OkOnly, "INFORMACIÓN")
            DgvRegistro.Enabled = False
        End If


    End Sub



End Class