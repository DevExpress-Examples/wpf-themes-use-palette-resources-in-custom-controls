Imports DevExpress.Xpf.Core

Namespace DXSample

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub comboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            ApplicationThemeHelper.ApplicationThemeName = TryCast(e.NewValue, String)
        End Sub
    End Class
End Namespace
