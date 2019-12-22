using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Stock
    {
        public string Code_Emballage { get; set; }
        public string Id_stock { get; set; }
        public string Code_Boisson { get; set; }
        public int Quantité { get; set; }

     
    }
}
