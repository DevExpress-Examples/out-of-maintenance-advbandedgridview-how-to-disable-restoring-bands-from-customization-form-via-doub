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
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid.Customization
Imports DevExpress.XtraTab
Imports DevExpress.Utils

Namespace MyXtraGrid
    Public Class MyAdvBandedGridView
        Inherits AdvBandedGridView

        Public Sub New(ByVal ownerGrid As DevExpress.XtraGrid.GridControl)
            MyBase.New(ownerGrid)

        End Sub
        Public Sub New()

        End Sub
        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyAdvBandedGridView"
            End Get
        End Property
        Protected Overrides Function CreateCustomizationForm() As DevExpress.XtraGrid.Views.Grid.Customization.CustomizationForm
            Return New CustomCustomizationForm(Me)
        End Function
    End Class
    Public Class CustomCustomizationForm
        Inherits BandedCustomizationForm

        Public Sub New(ByVal view As BandedGridView)
            MyBase.New(view)

        End Sub

        Private Sub Bands_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Protected Overrides Sub CreateListBox()
            MyBase.CreateListBox()
            BandsPage.Controls.Clear()
            Dim _bands As New CustomBandCustomizationListBox(Me)
            _bands.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            _bands.Populate()
            BandsPage.Controls.Add(_bands)
        End Sub
    End Class
    Public Class CustomBandCustomizationListBox
        Inherits BandCustomizationListBox

        Public Sub New(ByVal form As CustomizationForm)
            MyBase.New(form)

        End Sub
        Protected Overrides Sub OnMouseDoubleClick(ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Left AndAlso e.Clicks >= 2 Then
                Return
            End If
            MyBase.OnMouseDoubleClick(e)
        End Sub
    End Class
End Namespace
