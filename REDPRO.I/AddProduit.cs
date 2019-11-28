using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace REDPRO.I
{
    public partial class AddProduit : UserControl
    {
        public AddProduit()
        {
            //if (Program.IsInDesignMode())
            //{
            //    return;
            //}
            InitializeComponent();
        }
        public void Alert(string msg, AlertNotification.alertTypeEnum type)
        {
            AlertNotification f = new AlertNotification();
            f.setAlert(msg, type);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            this.Alert("Success message", AlertNotification.alertTypeEnum.Success);
        }

        private void AnnulerProduit_Click(object sender, EventArgs e)
        {
            this.Alert("Error message", AlertNotification.alertTypeEnum.Error);
        }
    }
}
