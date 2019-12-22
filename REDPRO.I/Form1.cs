using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDPRO.I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TileBar1_SelectedItemChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroup2.Items.IndexOf(e.Item);
        }
    }
}
