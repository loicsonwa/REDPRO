using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
   public class Commandes
    {
        public Commandes( string code_Commande, DateTime date_commande, DateTime delai, string montant_com, string realisé, Clients client) :this(code_Commande, date_commande, delai, montant_com, realisé)
        {
            Client = client;
        }

        public Commandes(string code_Commande, DateTime date_commande, DateTime delai, string montant_com, string realisé)
        {
            Code_Commande = code_Commande;
            Date_commande = date_commande;
            Delai = delai;
            Montant_com = montant_com;
            Realisé = realisé;
        }

        public string Code_Commande { get; set; }
        public DateTime Date_commande { get; set; }
        public DateTime Delai { get; set; }
        public string Montant_com { get; set; }
        public string Realisé { get; set; }
        public Clients Client { get; set; }
        




    }
}
