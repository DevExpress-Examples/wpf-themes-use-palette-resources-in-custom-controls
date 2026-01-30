Imports System.Windows
Imports System.Windows.Controls

Namespace DXSample

    Public Class CustomControl1
        Inherits Control

        Shared Sub New()
            Call DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl1), New FrameworkPropertyMetadata(GetType(CustomControl1)))
        End Sub

        Public Property Text As String
            Get
                Return CStr(GetValue(TextProperty))
            End Get

            Set(ByVal value As String)
                SetValue(TextProperty, value)
            End Set
        End Property

        Public Shared ReadOnly TextProperty As DependencyProperty = DependencyProperty.Register("Text", GetType(String), GetType(CustomControl1), New PropertyMetadata(CType(Nothing, PropertyChangedCallback)))
    End Class
End Namespace
