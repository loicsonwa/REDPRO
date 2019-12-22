using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Livreurs
    {
        public string Id_Livreur { get; set; }
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public string Etat { get; set; }

    }
}
