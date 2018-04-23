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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid.Customization;
using DevExpress.XtraTab;
using DevExpress.Utils;

namespace MyXtraGrid {
    public class MyAdvBandedGridView : AdvBandedGridView {
        public MyAdvBandedGridView(DevExpress.XtraGrid.GridControl ownerGrid)
            : base(ownerGrid) {

        }
        public MyAdvBandedGridView() {

        }
        protected override string ViewName {
            get {
                return "MyAdvBandedGridView";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.Customization.CustomizationForm CreateCustomizationForm() {
            return new CustomCustomizationForm(this);//
        }
    }
    public class CustomCustomizationForm : BandedCustomizationForm {
        public CustomCustomizationForm(BandedGridView view)
            : base(view) {

        }

        void Bands_DoubleClick(object sender, EventArgs e) {

        }

        protected override void CreateListBox() {
            base.CreateListBox();
            BandsPage.Controls.Clear();
            CustomBandCustomizationListBox _bands = new CustomBandCustomizationListBox(this);
            _bands.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            _bands.Populate();
            BandsPage.Controls.Add(_bands);
        }
    }
    public class CustomBandCustomizationListBox : BandCustomizationListBox {
        public CustomBandCustomizationListBox(CustomizationForm form)
            : base(form) {

        }
        protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) {
            if(e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks >= 2) {
                return;
            }
            base.OnMouseDoubleClick(e);
        }
    }
}
