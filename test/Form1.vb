Imports Microsoft.VisualBasic.Imaging.Drawing3D
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
        ' Gl.LoadIdentity()

        ' Gl.MatrixMode(MatrixMode.Modelview)
        '  Gl.LoadIdentity()
        ' Gl.Viewport(0, 600, 0, 600)

        Gl.Enable(EnableCap.DepthTest)
        Gl.DepthFunc(DepthFunction.Less)
        Gl.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)
        Gl.Enable(EnableCap.Blend)
        Gl.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha)
    End Sub

    Private Sub RenderControl_Render(sender As Object, e As GlControlEventArgs) Handles RenderControl.Render
        Gl.Begin(PrimitiveType.Points)
        Gl.Vertex2(0, 0)
        Gl.Vertex2(0.2, 0.4)
        Gl.End()
        Gl.Begin(PrimitiveType.LineStrip)
        Gl.Vertex2(0.5, 0)
        Gl.Vertex2(-0.5, 1.9)
        Gl.End()

    End Sub
End Class
