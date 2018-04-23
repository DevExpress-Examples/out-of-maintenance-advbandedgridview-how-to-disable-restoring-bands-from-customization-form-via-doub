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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyXtraGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Column1", typeof(String));
            for (int i = 0; i < 10; i++)
                dataTable1.Rows.Add( "Item Wg " + i );
            myGridControl1.DataSource = dataTable1;
        }
    }
}
