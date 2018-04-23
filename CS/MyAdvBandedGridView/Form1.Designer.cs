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

namespace MyXtraGrid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myGridControl1 = new MyXtraGrid.MyGridControl();
            this.myAdvBandedGridView1 = new MyXtraGrid.MyAdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAdvBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(1, 13);
            this.myGridControl1.MainView = this.myAdvBandedGridView1;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(385, 328);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myAdvBandedGridView1});
            // 
            // myAdvBandedGridView1
            // 
            this.myAdvBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.myAdvBandedGridView1.GridControl = this.myGridControl1;
            this.myAdvBandedGridView1.Name = "myAdvBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 353);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAdvBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGridControl myGridControl1;
        private MyAdvBandedGridView myAdvBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;

    }
}

