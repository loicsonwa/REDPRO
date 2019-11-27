using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDPRO.I
{
    public partial class Connexion : UserControl
    {
        public Connexion()
        {
            //if (Program.IsInDesignMode())
            //{
            //    return;
            //}
            InitializeComponent();
        }

        private void versIncription_Click(object sender, EventArgs e)
        {
            Demarrage.MainInstance.AfficheInscription();
        }
    }
}
