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
    public partial class Princip : Form
    {
        public static Princip MainPrincipal;
        public Princip()
        {
            MainPrincipal = this;
            InitializeComponent();
        }

        public void Alert(string msg, AlertNotification.alertTypeEnum type)
        {
            AlertNotification f = new AlertNotification();
            f.setAlert(msg, type);
        }
    }
}
