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
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace MyXtraGrid
    Public Class MyAdvBandedGridViewInfo
        Inherits AdvBandedGridViewInfo

        Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
            MyBase.New(gridView)

        End Sub
    End Class
End Namespace
