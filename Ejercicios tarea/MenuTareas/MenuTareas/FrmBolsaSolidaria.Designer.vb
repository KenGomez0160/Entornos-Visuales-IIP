<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBolsaSolidaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtTipoBolsa = New System.Windows.Forms.TextBox()
        Me.TxtIntegrantes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvRegistro = New System.Windows.Forms.DataGridView()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bolsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaBolsa = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Orange
        Me.GroupBox1.Controls.Add(Me.TxtMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.TxtTipoBolsa)
        Me.GroupBox1.Controls.Add(Me.TxtIntegrantes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.CbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboEstado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Location = New System.Drawing.Point(505, 111)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(100, 20)
        Me.TxtMunicipio.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Municipio"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLimpiar.Location = New System.Drawing.Point(3, 177)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(719, 43)
        Me.BtnLimpiar.TabIndex = 14
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtTipoBolsa
        '
        Me.TxtTipoBolsa.Location = New System.Drawing.Point(505, 26)
        Me.TxtTipoBolsa.Name = "TxtTipoBolsa"
        Me.TxtTipoBolsa.Size = New System.Drawing.Size(121, 20)
        Me.TxtTipoBolsa.TabIndex = 13
        '
        'TxtIntegrantes
        '
        Me.TxtIntegrantes.Location = New System.Drawing.Point(99, 113)
        Me.TxtIntegrantes.Name = "TxtIntegrantes"
        Me.TxtIntegrantes.Size = New System.Drawing.Size(100, 20)
        Me.TxtIntegrantes.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Integrantes"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnAgregar.Location = New System.Drawing.Point(3, 220)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(719, 43)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'CbxDepartamento
        '
        Me.CbxDepartamento.FormattingEnabled = True
        Me.CbxDepartamento.Location = New System.Drawing.Point(505, 68)
        Me.CbxDepartamento.Name = "CbxDepartamento"
        Me.CbxDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.CbxDepartamento.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Departaento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de bolsa"
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(99, 144)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboEstado.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Estado"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(99, 70)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Location = New System.Drawing.Point(99, 26)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdentidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'DgvRegistro
        '
        Me.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identidad, Me.Nombre, Me.Bolsa, Me.Direccion, Me.Municipio})
        Me.DgvRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRegistro.Location = New System.Drawing.Point(0, 266)
        Me.DgvRegistro.Name = "DgvRegistro"
        Me.DgvRegistro.Size = New System.Drawing.Size(725, 184)
        Me.DgvRegistro.TabIndex = 1
        '
        'Identidad
        '
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Bolsa
        '
        Me.Bolsa.HeaderText = "Tipo de Bolsa"
        Me.Bolsa.Name = "Bolsa"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Departamento"
        Me.Direccion.Name = "Direccion"
        '
        'Municipio
        '
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        '
        'ListaBolsa
        '
        Me.ListaBolsa.FormattingEnabled = True
        Me.ListaBolsa.Location = New System.Drawing.Point(552, 265)
        Me.ListaBolsa.Name = "ListaBolsa"
        Me.ListaBolsa.Size = New System.Drawing.Size(174, 173)
        Me.ListaBolsa.TabIndex = 14
        '
        'FrmBolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.Controls.Add(Me.ListaBolsa)
        Me.Controls.Add(Me.DgvRegistro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBolsaSolidaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxDepartamento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIntegrantes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents DgvRegistro As DataGridView
    Friend WithEvents TxtTipoBolsa As TextBox
    Friend WithEvents ListaBolsa As ListBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Bolsa As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
End Class
