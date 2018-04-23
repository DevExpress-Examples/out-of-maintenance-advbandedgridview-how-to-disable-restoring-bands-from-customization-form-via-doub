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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MyXtraGrid
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim dataTable1 As New DataTable()
            dataTable1.Columns.Add("Column1", GetType(String))
            For i As Integer = 0 To 9
                dataTable1.Rows.Add("Item Wg " & i)
            Next i
            myGridControl1.DataSource = dataTable1
        End Sub
    End Class
End Namespace
