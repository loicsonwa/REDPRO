using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class CapsulesGagnantes
    {
        public CapsulesGagnantes()
        {
        }

        public CapsulesGagnantes(string id_Caps, string description)
        {
            Id_Caps = id_Caps;
            Description = description;
        }

        public string Id_Caps { get; set; }
        public string Description { get; set; }
    }
}
