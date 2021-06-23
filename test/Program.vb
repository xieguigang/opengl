Imports System
Imports System.Windows.Forms

Namespace OpenTK.WinForms.TestForm
    Friend Module Program
        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Public Sub Main()
            Application.SetHighDpiMode(HighDpiMode.SystemAware)
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
