' Developer Express Code Central Example:
' How to create a AdvBandedGridView descendant class and register it for design-time use
' 
' This is an example of a custom AdvBandedGridView and a custom control that
' inherits the DevExpress.XtraGrid.GridControl. Make sure to build the project
' prior to opening Form1 in the designer.
' 
' To obtain general information about
' creating and registering a custom view descendant class at design time, refer to
' the following Knowledge Base article: http://www.devexpress.com/scid=A859.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T122322

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace MyXtraGrid
    Public Class MyAdvBandedGridInfoRegistrator
        Inherits AdvBandedGridInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyAdvBandedGridView"
            End Get
        End Property
        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyAdvBandedGridView(TryCast(grid, GridControl))
        End Function
        Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
            Return New MyAdvBandedGridViewInfo(TryCast(view, MyAdvBandedGridView))
        End Function
        Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
            Return New MyAdvBandedGridViewHandler(TryCast(view, MyAdvBandedGridView))
        End Function
    End Class
End Namespace
