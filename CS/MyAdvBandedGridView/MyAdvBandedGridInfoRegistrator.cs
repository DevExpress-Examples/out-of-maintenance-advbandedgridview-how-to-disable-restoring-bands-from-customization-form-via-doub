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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyXtraGrid
{
    public class MyAdvBandedGridInfoRegistrator : AdvBandedGridInfoRegistrator
    {
        public override string ViewName { get { return "MyAdvBandedGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyAdvBandedGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyAdvBandedGridViewInfo(view as MyAdvBandedGridView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new MyAdvBandedGridViewHandler(view as MyAdvBandedGridView); }
    }
}
