<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabezera = New System.Windows.Forms.Panel()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelSubMenuTarea = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BtnBaseDatos = New System.Windows.Forms.Button()
        Me.PanelSubMenuClase = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnIniciarRegistro = New System.Windows.Forms.Button()
        Me.BtnRegistrarse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PanelCabezera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubMenuTarea.SuspendLayout()
        Me.PanelSubMenuClase.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrarMenu
        '
        '
        'PanelCabezera
        '
        Me.PanelCabezera.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelCabezera.Controls.Add(Me.BtnRestaurar)
        Me.PanelCabezera.Controls.Add(Me.BtnMinimizar)
        Me.PanelCabezera.Controls.Add(Me.BtnMaximizar)
        Me.PanelCabezera.Controls.Add(Me.Button1)
        Me.PanelCabezera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabezera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabezera.Name = "PanelCabezera"
        Me.PanelCabezera.Size = New System.Drawing.Size(900, 40)
        Me.PanelCabezera.TabIndex = 3
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.Icono_Restaurar
        Me.BtnRestaurar.Location = New System.Drawing.Point(823, 0)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.BtnRestaurar.TabIndex = 2
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.Icono_Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(787, 0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.Icono_Maximizar
        Me.BtnMaximizar.Location = New System.Drawing.Point(823, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMaximizar.TabIndex = 1
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.Icono_cerrar_FN
        Me.Button1.Location = New System.Drawing.Point(860, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.Black
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuTarea)
        Me.PanelMenu.Controls.Add(Me.BtnBaseDatos)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuClase)
        Me.PanelMenu.Controls.Add(Me.BtnRegistrarse)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.Color.DimGray
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 460)
        Me.PanelMenu.TabIndex = 4
        '
        'PanelSubMenuTarea
        '
        Me.PanelSubMenuTarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuTarea.Controls.Add(Me.Button6)
        Me.PanelSubMenuTarea.Controls.Add(Me.Button7)
        Me.PanelSubMenuTarea.Controls.Add(Me.Button8)
        Me.PanelSubMenuTarea.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuTarea.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSubMenuTarea.Location = New System.Drawing.Point(0, 279)
        Me.PanelSubMenuTarea.Name = "PanelSubMenuTarea"
        Me.PanelSubMenuTarea.Size = New System.Drawing.Size(220, 101)
        Me.PanelSubMenuTarea.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(0, 60)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(220, 30)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Button6"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(0, 30)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(220, 30)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Button7"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(220, 30)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Button8"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'BtnBaseDatos
        '
        Me.BtnBaseDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBaseDatos.FlatAppearance.BorderSize = 0
        Me.BtnBaseDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnBaseDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaseDatos.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaseDatos.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.clientes
        Me.BtnBaseDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBaseDatos.Location = New System.Drawing.Point(0, 229)
        Me.BtnBaseDatos.Name = "BtnBaseDatos"
        Me.BtnBaseDatos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnBaseDatos.Size = New System.Drawing.Size(220, 50)
        Me.BtnBaseDatos.TabIndex = 1
        Me.BtnBaseDatos.Text = "Base de datos"
        Me.BtnBaseDatos.UseVisualStyleBackColor = True
        '
        'PanelSubMenuClase
        '
        Me.PanelSubMenuClase.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuClase.Controls.Add(Me.Button4)
        Me.PanelSubMenuClase.Controls.Add(Me.Button3)
        Me.PanelSubMenuClase.Controls.Add(Me.BtnIniciarRegistro)
        Me.PanelSubMenuClase.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuClase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSubMenuClase.Location = New System.Drawing.Point(0, 128)
        Me.PanelSubMenuClase.Name = "PanelSubMenuClase"
        Me.PanelSubMenuClase.Size = New System.Drawing.Size(220, 101)
        Me.PanelSubMenuClase.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(220, 30)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Button4"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(220, 30)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Button3"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnIniciarRegistro
        '
        Me.BtnIniciarRegistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnIniciarRegistro.FlatAppearance.BorderSize = 0
        Me.BtnIniciarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnIniciarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnIniciarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciarRegistro.Location = New System.Drawing.Point(0, 0)
        Me.BtnIniciarRegistro.Name = "BtnIniciarRegistro"
        Me.BtnIniciarRegistro.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnIniciarRegistro.Size = New System.Drawing.Size(220, 30)
        Me.BtnIniciarRegistro.TabIndex = 0
        Me.BtnIniciarRegistro.Text = "Iniciar Registro"
        Me.BtnIniciarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIniciarRegistro.UseVisualStyleBackColor = True
        '
        'BtnRegistrarse
        '
        Me.BtnRegistrarse.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistrarse.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarse.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.empleados
        Me.BtnRegistrarse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrarse.Location = New System.Drawing.Point(0, 78)
        Me.BtnRegistrarse.Name = "BtnRegistrarse"
        Me.BtnRegistrarse.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnRegistrarse.Size = New System.Drawing.Size(220, 50)
        Me.BtnRegistrarse.TabIndex = 0
        Me.BtnRegistrarse.Text = "Registrarse"
        Me.BtnRegistrarse.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 78)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu.Image = Global.MiniProyecto_VoyVolandoSigua.My.Resources.Resources.Mobile_Menu_Icon
        Me.BtnMenu.Location = New System.Drawing.Point(171, 43)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(49, 32)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.TabStop = False
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.Gray
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(220, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(680, 460)
        Me.PanelForm.TabIndex = 6
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabezera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.PanelCabezera.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubMenuTarea.ResumeLayout(False)
        Me.PanelSubMenuClase.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrarMenu As Timer
    Friend WithEvents PanelCabezera As Panel
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelSubMenuTarea As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BtnBaseDatos As Button
    Friend WithEvents PanelSubMenuClase As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnIniciarRegistro As Button
    Friend WithEvents BtnRegistrarse As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnMenu As PictureBox
    Friend WithEvents PanelForm As Panel
End Class
