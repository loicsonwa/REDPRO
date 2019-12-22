using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Factures
    {
        public string Code_Facture { get; set; }
        public string Libelle { get; set; }
        public DateTime date { get; set; }
        public int Montant { get; set; }
        public string payé { get; set; }
        public string Client { get; set; }
        public string Code_commande { get; set; }
        public string Mode_Reglement { get; set; }
    }
}
