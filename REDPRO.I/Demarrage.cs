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
    public partial class Demarrage : Form
    {
        // Rendre mon formulaire accessible en globale
        public static Demarrage MainInstance = null;
        public Demarrage()
        {
            MainInstance = this;
            InitializeComponent();
        }

        internal void AfficheConnexion()
        {
            connexion1.Visible = false;
            connexion1.BringToFront();
            Transition1.ShowSync(connexion1);
            
        }

        internal void AfficheInscription()
        {
            inscription1.Visible = false;
            inscription1.BringToFront();
            Transition1.ShowSync(inscription1);
        }
    }
}
