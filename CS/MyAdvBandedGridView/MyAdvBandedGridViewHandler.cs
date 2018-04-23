// Developer Express Code Central Example:
// How to create a AdvBandedGridView descendant class and register it for design-time use
// 
// This is an example of a custom AdvBandedGridView and a custom control that
// inherits the DevExpress.XtraGrid.GridControl. Make sure to build the project
// prior to opening Form1 in the designer.
// 
// To obtain general information about
// creating and registering a custom view descendant class at design time, refer to
// the following Knowledge Base article: http://www.devexpress.com/scid=A859.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T122322

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Windows.Forms;

namespace MyXtraGrid
{
    public class MyAdvBandedGridViewHandler : AdvBandedGridHandler
    {
        public MyAdvBandedGridViewHandler(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridView)
            : base(gridView)
        {
            
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Delete && View.State == BandedGridState.Normal)
                View.DeleteRow(View.FocusedRowHandle);
            if (e.KeyData == Keys.Enter && View.State == BandedGridState.Normal)
                View.AddNewRow();
        }
    }
}
