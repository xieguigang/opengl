Imports OpenGL

Public Class Form1

    Friend WithEvents RenderControl As New GlControl

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Controls.Add(RenderControl)

        RenderControl.Dock = DockStyle.Fill
    End Sub

    Private Sub RenderControl_ContextCreated(sender As Object, e As GlControlEventArgs) Handles RenderControl.ContextCreated
        ' Here you can allocate resources Or initialize state
        Gl.MatrixMode(MatrixMode.Projection)
        Gl.LoadIdentity()
        Gl.Ortho(0.0, 1.0F, 0.0, 1.0, 0.0, 1.0)

        Gl.MatrixMode(MatrixMode.Modelview)
        Gl.LoadIdentity()
    End Sub

    Private Sub RenderControl_Render(sender As Object, e As GlControlEventArgs) Handles RenderControl.Render
        Dim senderControl As Control = CType(sender, Control)

        ' Note: conflicting commands are scoped in Gl.VB class
        Gl.VB.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height)
        Gl.VB.Clear(ClearBufferMask.ColorBufferBit)

        ' Note: conflicting enumerants are scoped in Gl.VBEnum class
        Dim currentViewport As Integer() = New Integer(3) {0, 0, 0, 0}
        Gl.Get(Gl.VBEnum.VIEWPORT, currentViewport)

        Dim canvas As New GLGraphics



    End Sub
End Class
