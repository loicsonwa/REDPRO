using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Pertes
    {
        public string Code_mvt { get; set; }
        public DateTime Date { get; set; }
        public string Code_Pertes { get; set; }
        public string Description { get; set; }
        public int Quantité { get; set; }
        public string Unité { get; set; }
        public string Code_Emballage { get; set; }
        public string Code_Boissons { get; set; }
        public string Code_Capsules { get; set; }

    }
}
