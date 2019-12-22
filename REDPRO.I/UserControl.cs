using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace REDPRO.I
{
    public partial class UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void tileControl1_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = Group2.Items.IndexOf(e.Item);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Votre produit a éte enregistré avec succès !", "Confirmation"
                , MessageBoxButtons.OK);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flyoutPanel1.ShowBeakForm();
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    Message msg = new Message();
        //    alertControl1.Show(this, msg.Caption, msg.Text, "", msg.Image, msg);
        //}
        //private void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        //{
        //    //Make the Alert Window opaque
        //    e.AlertForm.OpacityLevel = 1;
        //}

        //private void alertControl1_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        //{ 
        //    //Process Alert Window click
        //    Message msg = e.Info.Tag as Message;
        //    XtraMessageBox.Show(msg.Text, msg.Caption);
        //}

    }

    //public class Message 
    //{ 
    //    public Message()
    //    { 
    //        this.Caption = "LILA-Supermercado";
    //        this.Text = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo";
    //        this.Image = global::REDPRO.I.Properties.Resources.photo_2019_12_13_10_53_20;
    //    }
    //    public string Caption { get; set; }
    //    public string Text { get; set; }
    //    public Image Image { get; set; }
    //}
}
