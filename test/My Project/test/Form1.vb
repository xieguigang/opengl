#Region "Microsoft.VisualBasic::fb6d4c96b509978a40dc4e64f5de2757, mzkit\src\mzkit\opengl\test\My Project\test\Form1.vb"

    ' Author:
    ' 
    '       xieguigang (gg.xie@bionovogene.com, BioNovoGene Co., LTD.)
    ' 
    ' Copyright (c) 2018 gg.xie@bionovogene.com, BioNovoGene Co., LTD.
    ' 
    ' 
    ' MIT License
    ' 
    ' 
    ' Permission is hereby granted, free of charge, to any person obtaining a copy
    ' of this software and associated documentation files (the "Software"), to deal
    ' in the Software without restriction, including without limitation the rights
    ' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    ' copies of the Software, and to permit persons to whom the Software is
    ' furnished to do so, subject to the following conditions:
    ' 
    ' The above copyright notice and this permission notice shall be included in all
    ' copies or substantial portions of the Software.
    ' 
    ' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    ' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    ' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    ' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    ' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    ' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    ' SOFTWARE.



    ' /********************************************************************************/

    ' Summaries:


    ' Code Statistics:

    '   Total Lines: 112
    '    Code Lines: 86
    ' Comment Lines: 14
    '   Blank Lines: 12
    '     File Size: 5.33 KB


    '     Class Form1
    ' 
    '         Constructor: (+1 Overloads) Sub New
    '         Sub: aboutToolStripMenuItem_Click, exitToolStripMenuItem_Click, glControl_Load, glControl_Paint, glControl_Resize
    '              Render
    ' 
    ' 
    ' /********************************************************************************/

#End Region

Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL

Namespace OpenTK.WinForms.TestForm
    Public Partial Class Form1
        Inherits Form

        ''' Cannot convert FieldDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
        ''' 
        ''' Input:
        Private _timer As System.Windows.Forms.Timer
        ''' 
        ''' 
        Private _angle As Single = 0.0F

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show(Me, "This demonstrates a simple use of the new OpenTK 4.x GLControl.", "GLControl Test Form", MessageBoxButtons.OK)
        End Sub

        Private Sub glControl_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Make sure that when the GLControl is resized or needs to be painted,
            ' we update our projection matrix or re-render its contents, respectively.
            AddHandler glControl.Resize, AddressOf glControl_Resize
            AddHandler glControl.Paint, AddressOf glControl_Paint

            ' Redraw the screen every 1/20 of a second.
            Me._timer = New Timer()
            AddHandler Me._timer.Tick, Sub(sender2, e2)
                                           _angle += 0.5F
                                           Render()
                                       End Sub

            Me._timer.Interval = 50   ' 1000 ms per sec / 50 ms per frame = 20 FPS
            Me._timer.Start()

            ' Ensure that the viewport and projection matrix are set correctly initially.
            Me.glControl_Resize(glControl, EventArgs.Empty)
        End Sub

        Private Sub glControl_Resize(ByVal sender As Object, ByVal e As EventArgs)
            glControl.MakeCurrent()
            If glControl.ClientSize.Height = 0 Then glControl.ClientSize = New Drawing.Size(glControl.ClientSize.Width, 1)
            GL.Viewport(0, 0, glControl.ClientSize.Width, glControl.ClientSize.Height)
            Dim aspect_ratio = Math.Max(glControl.ClientSize.Width, 1) / CSng(Math.Max(glControl.ClientSize.Height, 1))
            Dim perpective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64)
            GL.MatrixMode(MatrixMode.Projection)
            GL.LoadMatrix(perpective)
        End Sub

        Private Sub glControl_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Render()
        End Sub

        Private Sub Render()
            glControl.MakeCurrent()
            GL.ClearColor(Color4.MidnightBlue)
            GL.Enable(EnableCap.DepthTest)
            Dim lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0)
            GL.MatrixMode(MatrixMode.Modelview)
            GL.LoadMatrix(lookat)
            GL.Rotate(_angle, 0.0F, 1.0F, 0.0F)
            GL.Clear(ClearBufferMask.ColorBufferBit Or ClearBufferMask.DepthBufferBit)
            GL.Begin(BeginMode.Quads)
            GL.Color4(Color4.Silver)
            GL.Vertex3(-1.0F, -1.0F, -1.0F)
            GL.Vertex3(-1.0F, 1.0F, -1.0F)
            GL.Vertex3(1.0F, 1.0F, -1.0F)
            GL.Vertex3(1.0F, -1.0F, -1.0F)
            GL.Color4(Color4.Honeydew)
            GL.Vertex3(-1.0F, -1.0F, -1.0F)
            GL.Vertex3(1.0F, -1.0F, -1.0F)
            GL.Vertex3(1.0F, -1.0F, 1.0F)
            GL.Vertex3(-1.0F, -1.0F, 1.0F)
            GL.Color4(Color4.Moccasin)
            GL.Vertex3(-1.0F, -1.0F, -1.0F)
            GL.Vertex3(-1.0F, -1.0F, 1.0F)
            GL.Vertex3(-1.0F, 1.0F, 1.0F)
            GL.Vertex3(-1.0F, 1.0F, -1.0F)
            GL.Color4(Color4.IndianRed)
            GL.Vertex3(-1.0F, -1.0F, 1.0F)
            GL.Vertex3(1.0F, -1.0F, 1.0F)
            GL.Vertex3(1.0F, 1.0F, 1.0F)
            GL.Vertex3(-1.0F, 1.0F, 1.0F)
            GL.Color4(Color4.PaleVioletRed)
            GL.Vertex3(-1.0F, 1.0F, -1.0F)
            GL.Vertex3(-1.0F, 1.0F, 1.0F)
            GL.Vertex3(1.0F, 1.0F, 1.0F)
            GL.Vertex3(1.0F, 1.0F, -1.0F)
            GL.Color4(Color4.ForestGreen)
            GL.Vertex3(1.0F, -1.0F, -1.0F)
            GL.Vertex3(1.0F, 1.0F, -1.0F)
            GL.Vertex3(1.0F, 1.0F, 1.0F)
            GL.Vertex3(1.0F, -1.0F, 1.0F)
            Call GL.End()
            glControl.SwapBuffers()
        End Sub
    End Class
End Namespace
