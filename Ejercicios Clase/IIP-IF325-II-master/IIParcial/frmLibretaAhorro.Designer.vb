﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibretaAhorro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Saldo = New System.Windows.Forms.Label()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.lstDepositos = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAperturar)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(295, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de información"
        '
        'btnAperturar
        '
        Me.btnAperturar.Location = New System.Drawing.Point(193, 95)
        Me.btnAperturar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(67, 46)
        Me.btnAperturar.TabIndex = 4
        Me.btnAperturar.Text = "Aperturar Cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(95, 55)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(76, 20)
        Me.txtMonto.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(95, 25)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(108, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 181)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(293, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(132, 17)
        Me.btnRetirar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(69, 37)
        Me.btnRetirar.TabIndex = 1
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(17, 17)
        Me.btnDepositar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(69, 37)
        Me.btnDepositar.TabIndex = 0
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.Saldo)
        Me.GroupBox3.Controls.Add(Me.lstRetiros)
        Me.GroupBox3.Controls.Add(Me.lstDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 257)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(298, 123)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Retiros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Depositos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(233, 93)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 20)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(236, 67)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(63, 20)
        Me.txtSaldo.TabIndex = 5
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Location = New System.Drawing.Point(234, 51)
        Me.Saldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(61, 13)
        Me.Saldo.TabIndex = 2
        Me.Saldo.Text = "Saldo Total"
        '
        'lstRetiros
        '
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.Location = New System.Drawing.Point(128, 32)
        Me.lstRetiros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(91, 69)
        Me.lstRetiros.TabIndex = 1
        '
        'lstDepositos
        '
        Me.lstDepositos.FormattingEnabled = True
        Me.lstDepositos.Location = New System.Drawing.Point(10, 32)
        Me.lstDepositos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstDepositos.Name = "lstDepositos"
        Me.lstDepositos.Size = New System.Drawing.Size(91, 69)
        Me.lstDepositos.TabIndex = 0
        '
        'frmLibretaAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 410)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmLibretaAhorro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLibretaAhorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Saldo As Label
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents lstDepositos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
