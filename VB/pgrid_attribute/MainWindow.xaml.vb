Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Markup
Imports DevExpress.Mvvm.Native

Namespace pgrid_attribute

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ItemInitializer
        Inherits MarkupExtension
        Implements IInstanceInitializer

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Private Function CreateInstance(ByVal type As TypeInfo) As Object Implements IInstanceInitializer.CreateInstance
            Return Date.Today
        End Function

        Private ReadOnly Property Types As IEnumerable(Of TypeInfo) Implements IInstanceInitializer.Types
            Get
                Return New List(Of TypeInfo)() From {New TypeInfo(GetType(Date), "Today")}
            End Get
        End Property
    End Class
End Namespace
