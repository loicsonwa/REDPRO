using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Emballages
    {
        public string Code_Emballage { get; set; }
        public int capacité { get; set; }
        public string Description { get; set; }
        public int valeur { get; set; }
        public string Type { get; set; }
    }
}
