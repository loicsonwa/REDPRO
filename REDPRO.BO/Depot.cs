using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Depot
    {
        public Depot()
        {
        }

        public Depot(string id_Depot, string nom, int telephone1, int telephone2, string email, string localisation, string logo)
        {
            Id_Depot = id_Depot;
            Nom = nom;
            Telephone1 = telephone1;
            Telephone2 = telephone2;
            Email = email;
            Localisation = localisation;
            Logo = logo;
        }

        public string Id_Depot { get; set; }
        public string Nom { get; set; }
        public int Telephone1 { get; set; }
        public int Telephone2 { get; set; }
        public string Email { get; set; }
        public string Localisation { get; set; }
        public string Logo { get; set; }
       
    }
}
