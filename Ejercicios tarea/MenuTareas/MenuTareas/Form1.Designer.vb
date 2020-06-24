<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.BtnTareas = New System.Windows.Forms.Button()
        Me.PanelSubMenuClase = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnArregloDeVectores = New System.Windows.Forms.Button()
        Me.BtnClase = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabezera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubMenuTarea.SuspendLayout()
        Me.PanelSubMenuClase.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabezera
        '
        Me.PanelCabezera.BackColor = System.Drawing.Color.Red
        Me.PanelCabezera.Controls.Add(Me.BtnRestaurar)
        Me.PanelCabezera.Controls.Add(Me.BtnMinimizar)
        Me.PanelCabezera.Controls.Add(Me.BtnMaximizar)
        Me.PanelCabezera.Controls.Add(Me.Button1)
        Me.PanelCabezera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabezera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabezera.Name = "PanelCabezera"
        Me.PanelCabezera.Size = New System.Drawing.Size(900, 40)
        Me.PanelCabezera.TabIndex = 1
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = Global.MenuTareas.My.Resources.Resources.Icono_Restaurar
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
        Me.BtnMinimizar.Image = Global.MenuTareas.My.Resources.Resources.Icono_Minimizar
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
        Me.BtnMaximizar.Image = Global.MenuTareas.My.Resources.Resources.Icono_Maximizar
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
        Me.Button1.Image = Global.MenuTareas.My.Resources.Resources.Icono_cerrar_FN
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
        Me.PanelMenu.Controls.Add(Me.BtnTareas)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuClase)
        Me.PanelMenu.Controls.Add(Me.BtnClase)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.Color.DimGray
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 460)
        Me.PanelMenu.TabIndex = 1
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
        'BtnTareas
        '
        Me.BtnTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTareas.FlatAppearance.BorderSize = 0
        Me.BtnTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTareas.Location = New System.Drawing.Point(0, 229)
        Me.BtnTareas.Name = "BtnTareas"
        Me.BtnTareas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnTareas.Size = New System.Drawing.Size(220, 50)
        Me.BtnTareas.TabIndex = 1
        Me.BtnTareas.Text = "Tareas"
        Me.BtnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTareas.UseVisualStyleBackColor = True
        '
        'PanelSubMenuClase
        '
        Me.PanelSubMenuClase.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuClase.Controls.Add(Me.Button4)
        Me.PanelSubMenuClase.Controls.Add(Me.Button3)
        Me.PanelSubMenuClase.Controls.Add(Me.BtnArregloDeVectores)
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
        'BtnArregloDeVectores
        '
        Me.BtnArregloDeVectores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnArregloDeVectores.FlatAppearance.BorderSize = 0
        Me.BtnArregloDeVectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnArregloDeVectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnArregloDeVectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArregloDeVectores.Location = New System.Drawing.Point(0, 0)
        Me.BtnArregloDeVectores.Name = "BtnArregloDeVectores"
        Me.BtnArregloDeVectores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnArregloDeVectores.Size = New System.Drawing.Size(220, 30)
        Me.BtnArregloDeVectores.TabIndex = 0
        Me.BtnArregloDeVectores.Text = "Arreglo de Vectores"
        Me.BtnArregloDeVectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnArregloDeVectores.UseVisualStyleBackColor = True
        '
        'BtnClase
        '
        Me.BtnClase.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnClase.FlatAppearance.BorderSize = 0
        Me.BtnClase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClase.Location = New System.Drawing.Point(0, 78)
        Me.BtnClase.Name = "BtnClase"
        Me.BtnClase.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnClase.Size = New System.Drawing.Size(220, 50)
        Me.BtnClase.TabIndex = 0
        Me.BtnClase.Text = "Clase"
        Me.BtnClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClase.UseVisualStyleBackColor = True
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
        Me.PictureBox1.Image = Global.MenuTareas.My.Resources.Resources.LOGO
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
        Me.BtnMenu.Image = Global.MenuTareas.My.Resources.Resources.Mobile_Menu_Icon
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
        Me.PanelForm.TabIndex = 3
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrarMenu
        '
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabezera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelCabezera.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubMenuTarea.ResumeLayout(False)
        Me.PanelSubMenuClase.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabezera As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMenu As PictureBox
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelSubMenuClase As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnArregloDeVectores As Button
    Friend WithEvents BtnClase As Button
    Friend WithEvents PanelSubMenuTarea As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BtnTareas As Button
End Class
