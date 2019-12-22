using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Utilisateurs
    {
        public string ID_Utilisateurs { get; set; }
        public string Nom { get; set; }
        public string Mot_De_Passe { get; set; }
        public string Type { get; set; }
        public DateTime Date_creation { get; set; }
        public DateTime Date_DerniereConnexion { get; set; }
    }
}
