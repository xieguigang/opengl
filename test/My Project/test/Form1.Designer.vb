Imports OpenTK
Imports OpenTK.WinForms

Namespace OpenTK.WinForms.TestForm
    Partial Class Form1
        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            menuStrip1 = New Windows.Forms.MenuStrip()
            fileToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            newToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            openToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripSeparator = New Windows.Forms.ToolStripSeparator()
            saveToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            saveAsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripSeparator1 = New Windows.Forms.ToolStripSeparator()
            printToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            printPreviewToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripSeparator2 = New Windows.Forms.ToolStripSeparator()
            exitToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            editToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            undoToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            redoToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripSeparator3 = New Windows.Forms.ToolStripSeparator()
            cutToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            copyToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            pasteToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripSeparator4 = New Windows.Forms.ToolStripSeparator()
            selectAllToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            customizeToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            optionsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            helpToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            contentsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            indexToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            searchToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            toolStripSeparator5 = New Windows.Forms.ToolStripSeparator()
            aboutToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            glControl = New GLControl()
            menuStrip1.SuspendLayout()
            SuspendLayout()
            ' 
            ' menuStrip1
            ' 
            menuStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem})
            menuStrip1.Location = New Drawing.Point(0, 0)
            menuStrip1.Name = "menuStrip1"
            menuStrip1.Size = New Drawing.Size(403, 24)
            menuStrip1.TabIndex = 1
            menuStrip1.Text = "menuStrip1"
            ' 
            ' fileToolStripMenuItem
            ' 
            fileToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem})
            fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            fileToolStripMenuItem.Size = New Drawing.Size(37, 20)
            fileToolStripMenuItem.Text = "&File"
            ' 
            ' newToolStripMenuItem
            ' 
            newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), Drawing.Image)
            newToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            newToolStripMenuItem.Name = "newToolStripMenuItem"
            newToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.N
            newToolStripMenuItem.Size = New Drawing.Size(146, 22)
            newToolStripMenuItem.Text = "&New"
            ' 
            ' openToolStripMenuItem
            ' 
            openToolStripMenuItem.Image = CType(resources.GetObject("openToolStripMenuItem.Image"), Drawing.Image)
            openToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            openToolStripMenuItem.Name = "openToolStripMenuItem"
            openToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.O
            openToolStripMenuItem.Size = New Drawing.Size(146, 22)
            openToolStripMenuItem.Text = "&Open"
            ' 
            ' toolStripSeparator
            ' 
            toolStripSeparator.Name = "toolStripSeparator"
            toolStripSeparator.Size = New Drawing.Size(143, 6)
            ' 
            ' saveToolStripMenuItem
            ' 
            saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"), Drawing.Image)
            saveToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            saveToolStripMenuItem.Name = "saveToolStripMenuItem"
            saveToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.S
            saveToolStripMenuItem.Size = New Drawing.Size(146, 22)
            saveToolStripMenuItem.Text = "&Save"
            ' 
            ' saveAsToolStripMenuItem
            ' 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
            saveAsToolStripMenuItem.Size = New Drawing.Size(146, 22)
            saveAsToolStripMenuItem.Text = "Save &As"
            ' 
            ' toolStripSeparator1
            ' 
            toolStripSeparator1.Name = "toolStripSeparator1"
            toolStripSeparator1.Size = New Drawing.Size(143, 6)
            ' 
            ' printToolStripMenuItem
            ' 
            printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), Drawing.Image)
            printToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            printToolStripMenuItem.Name = "printToolStripMenuItem"
            printToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.P
            printToolStripMenuItem.Size = New Drawing.Size(146, 22)
            printToolStripMenuItem.Text = "&Print"
            ' 
            ' printPreviewToolStripMenuItem
            ' 
            printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), Drawing.Image)
            printPreviewToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
            printPreviewToolStripMenuItem.Size = New Drawing.Size(146, 22)
            printPreviewToolStripMenuItem.Text = "Print Pre&view"
            ' 
            ' toolStripSeparator2
            ' 
            toolStripSeparator2.Name = "toolStripSeparator2"
            toolStripSeparator2.Size = New Drawing.Size(143, 6)
            ' 
            ' exitToolStripMenuItem
            ' 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            exitToolStripMenuItem.Size = New Drawing.Size(146, 22)
            exitToolStripMenuItem.Text = "E&xit"
            AddHandler exitToolStripMenuItem.Click, New EventHandler(AddressOf exitToolStripMenuItem_Click)
            ' 
            ' editToolStripMenuItem
            ' 
            editToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem})
            editToolStripMenuItem.Name = "editToolStripMenuItem"
            editToolStripMenuItem.Size = New Drawing.Size(39, 20)
            editToolStripMenuItem.Text = "&Edit"
            ' 
            ' undoToolStripMenuItem
            ' 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem"
            undoToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.Z
            undoToolStripMenuItem.Size = New Drawing.Size(144, 22)
            undoToolStripMenuItem.Text = "&Undo"
            ' 
            ' redoToolStripMenuItem
            ' 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem"
            redoToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.Y
            redoToolStripMenuItem.Size = New Drawing.Size(144, 22)
            redoToolStripMenuItem.Text = "&Redo"
            ' 
            ' toolStripSeparator3
            ' 
            toolStripSeparator3.Name = "toolStripSeparator3"
            toolStripSeparator3.Size = New Drawing.Size(141, 6)
            ' 
            ' cutToolStripMenuItem
            ' 
            cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"), Drawing.Image)
            cutToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            cutToolStripMenuItem.Name = "cutToolStripMenuItem"
            cutToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.X
            cutToolStripMenuItem.Size = New Drawing.Size(144, 22)
            cutToolStripMenuItem.Text = "Cu&t"
            ' 
            ' copyToolStripMenuItem
            ' 
            copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"), Drawing.Image)
            copyToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            copyToolStripMenuItem.Name = "copyToolStripMenuItem"
            copyToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.C
            copyToolStripMenuItem.Size = New Drawing.Size(144, 22)
            copyToolStripMenuItem.Text = "&Copy"
            ' 
            ' pasteToolStripMenuItem
            ' 
            pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), Drawing.Image)
            pasteToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
            pasteToolStripMenuItem.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.V
            pasteToolStripMenuItem.Size = New Drawing.Size(144, 22)
            pasteToolStripMenuItem.Text = "&Paste"
            ' 
            ' toolStripSeparator4
            ' 
            toolStripSeparator4.Name = "toolStripSeparator4"
            toolStripSeparator4.Size = New Drawing.Size(141, 6)
            ' 
            ' selectAllToolStripMenuItem
            ' 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
            selectAllToolStripMenuItem.Size = New Drawing.Size(144, 22)
            selectAllToolStripMenuItem.Text = "Select &All"
            ' 
            ' toolsToolStripMenuItem
            ' 
            toolsToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {customizeToolStripMenuItem, optionsToolStripMenuItem})
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
            toolsToolStripMenuItem.Size = New Drawing.Size(46, 20)
            toolsToolStripMenuItem.Text = "&Tools"
            ' 
            ' customizeToolStripMenuItem
            ' 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
            customizeToolStripMenuItem.Size = New Drawing.Size(130, 22)
            customizeToolStripMenuItem.Text = "&Customize"
            ' 
            ' optionsToolStripMenuItem
            ' 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
            optionsToolStripMenuItem.Size = New Drawing.Size(130, 22)
            optionsToolStripMenuItem.Text = "&Options"
            ' 
            ' helpToolStripMenuItem
            ' 
            helpToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem})
            helpToolStripMenuItem.Name = "helpToolStripMenuItem"
            helpToolStripMenuItem.Size = New Drawing.Size(44, 20)
            helpToolStripMenuItem.Text = "&Help"
            ' 
            ' contentsToolStripMenuItem
            ' 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem"
            contentsToolStripMenuItem.Size = New Drawing.Size(122, 22)
            contentsToolStripMenuItem.Text = "&Contents"
            ' 
            ' indexToolStripMenuItem
            ' 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem"
            indexToolStripMenuItem.Size = New Drawing.Size(122, 22)
            indexToolStripMenuItem.Text = "&Index"
            ' 
            ' searchToolStripMenuItem
            ' 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem"
            searchToolStripMenuItem.Size = New Drawing.Size(122, 22)
            searchToolStripMenuItem.Text = "&Search"
            ' 
            ' toolStripSeparator5
            ' 
            toolStripSeparator5.Name = "toolStripSeparator5"
            toolStripSeparator5.Size = New Drawing.Size(119, 6)
            ' 
            ' aboutToolStripMenuItem
            ' 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
            aboutToolStripMenuItem.Size = New Drawing.Size(122, 22)
            aboutToolStripMenuItem.Text = "&About..."
            AddHandler aboutToolStripMenuItem.Click, New EventHandler(AddressOf aboutToolStripMenuItem_Click)
            ' 
            ' glControl
            ' 
            glControl.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            glControl.API = Windowing.Common.ContextAPI.OpenGL
            glControl.APIVersion = New Version(3, 3, 0, 0)
            glControl.Flags = Windowing.Common.ContextFlags.Default
            glControl.IsEventDriven = True
            glControl.Location = New Drawing.Point(12, 27)
            glControl.Name = "glControl"
            glControl.Profile = Windowing.Common.ContextProfile.Compatability
            glControl.Size = New Drawing.Size(379, 211)
            glControl.TabIndex = 2
            glControl.Text = "glControl1"
            AddHandler glControl.Load, New EventHandler(AddressOf glControl_Load)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 15.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(403, 250)
            Controls.Add(glControl)
            Controls.Add(menuStrip1)
            Name = "Form1"
            Text = "GLControl Test Form"
            menuStrip1.ResumeLayout(False)
            menuStrip1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private menuStrip1 As Windows.Forms.MenuStrip
        Private fileToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private newToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private openToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator As Windows.Forms.ToolStripSeparator
        Private saveToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private saveAsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator1 As Windows.Forms.ToolStripSeparator
        Private printToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private printPreviewToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator2 As Windows.Forms.ToolStripSeparator
        Private exitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private editToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private undoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private redoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator3 As Windows.Forms.ToolStripSeparator
        Private cutToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private copyToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private pasteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator4 As Windows.Forms.ToolStripSeparator
        Private selectAllToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private customizeToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private optionsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private helpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private contentsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private indexToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private searchToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator5 As Windows.Forms.ToolStripSeparator
        Private aboutToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private glControl As GLControl
    End Class
End Namespace
