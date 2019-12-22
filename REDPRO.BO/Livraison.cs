using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Livraison
    {
        public string Code_Commande { get; set; }
        public DateTime Date_Livraison { get; set; }
        public string Code_commande { get; set; }
        public string Livré { get; set; }
        public string id_livreur { get; set; }
        public string Code_Livraison { get; set; }

    }
}
