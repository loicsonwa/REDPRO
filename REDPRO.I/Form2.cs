using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace REDPRO.I
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void TileControl1_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = Group2.Items.IndexOf(e.Item);
        }

        private void TileItem1_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void TileControl1_Click(object sender, EventArgs e)
        {

        }
    }
}