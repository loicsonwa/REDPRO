using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Fournisseurs
    {
        public string Code_Fournisseur { get; set; }
        public string Nom { get; set; }
        public int Telephone1 { get; set; }
        public int Telephone2 { get; set; }
        public string Solde { get; set; }
        public string Addresse { get; set; }
    }
}
