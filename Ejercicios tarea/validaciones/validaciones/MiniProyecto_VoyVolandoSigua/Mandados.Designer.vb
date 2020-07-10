<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mandados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbTipoMandado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRecorrido = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMandado = New System.Windows.Forms.Button()
        Me.txtMotoristas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoMandado
        '
        Me.cmbTipoMandado.FormattingEnabled = True
        Me.cmbTipoMandado.Items.AddRange(New Object() {"Pago de servicios publicos", "Compras de Supermercado", "Compras de articulos", "Otros"})
        Me.cmbTipoMandado.Location = New System.Drawing.Point(347, 192)
        Me.cmbTipoMandado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoMandado.Name = "cmbTipoMandado"
        Me.cmbTipoMandado.Size = New System.Drawing.Size(179, 24)
        Me.cmbTipoMandado.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(195, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Recorrido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tipo de mandado"
        '
        'txtRecorrido
        '
        Me.txtRecorrido.Location = New System.Drawing.Point(347, 138)
        Me.txtRecorrido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRecorrido.Name = "txtRecorrido"
        Me.txtRecorrido.Size = New System.Drawing.Size(179, 22)
        Me.txtRecorrido.TabIndex = 19
        '
        'txtPrecio
        '
        Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPrecio.Location = New System.Drawing.Point(347, 261)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(179, 22)
        Me.txtPrecio.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Identidad"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(347, 75)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.ReadOnly = True
        Me.txtIdentidad.Size = New System.Drawing.Size(179, 22)
        Me.txtIdentidad.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ingresar mandado"
        '
        'btnMandado
        '
        Me.btnMandado.Location = New System.Drawing.Point(356, 345)
        Me.btnMandado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMandado.Name = "btnMandado"
        Me.btnMandado.Size = New System.Drawing.Size(153, 37)
        Me.btnMandado.TabIndex = 27
        Me.btnMandado.Text = "Efectuar Mandado"
        Me.btnMandado.UseVisualStyleBackColor = True
        '
        'txtMotoristas
        '
        Me.txtMotoristas.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMotoristas.Location = New System.Drawing.Point(571, 377)
        Me.txtMotoristas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMotoristas.Name = "txtMotoristas"
        Me.txtMotoristas.ReadOnly = True
        Me.txtMotoristas.Size = New System.Drawing.Size(179, 22)
        Me.txtMotoristas.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(583, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Motoristas disponibles"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Mandados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 434)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMotoristas)
        Me.Controls.Add(Me.btnMandado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoMandado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRecorrido)
        Me.Controls.Add(Me.txtPrecio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Mandados"
        Me.Text = "Mandados"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipoMandado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRecorrido As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMandado As Button
    Friend WithEvents txtMotoristas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
