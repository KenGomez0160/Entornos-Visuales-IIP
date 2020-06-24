Imports System.Runtime.InteropServices
Public Class FormMenu
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelCabezera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabezera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TimerOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.TimerOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub TimerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TimerMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.TimerMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If PanelMenu.Width = 220 Then
            TimerOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            TimerMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub PanelForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelForm.Paint
        ocultarSubMenu()

    End Sub
    Private Sub ocultarSubMenu()
        PanelSubMenuClase.Visible = False
        PanelSubMenuTarea.Visible = False
    End Sub
    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            ocultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub BtnClase_Click(sender As Object, e As EventArgs) Handles BtnClase.Click
        MostrarSubMenu(PanelSubMenuClase)

    End Sub

    Private Sub BtnTareas_Click(sender As Object, e As EventArgs) Handles BtnTareas.Click
        MostrarSubMenu(PanelSubMenuTarea)
    End Sub


End Class
