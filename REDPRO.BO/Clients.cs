using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
   public class Clients
    {
        public Clients(string code_client, string nom, int telephone, string solde, string seuil_endettement, string etat, string situation_solde, string autres_infos, string type_client)
        {
            Code_client = code_client;
            Nom = nom;
            Telephone = telephone;
            Solde = solde;
            Seuil_endettement = seuil_endettement;
            Etat = etat;
            Situation_solde = situation_solde;
            Autres_infos = autres_infos;
            Type_client = type_client;
        }

        public Clients(string code_client, string nom, int telephone, string solde, string seuil_endettement, string etat, string situation_solde, string autres_infos, string type_client,Categories_clients categorie)
            :this(code_client, nom,telephone,solde,seuil_endettement,etat,situation_solde,autres_infos,type_client)
        {
            Categorie = categorie;
        }

        public Clients(Ristournes ristourne)
        {
            Ristourne = ristourne;
        }

        public Clients()
        {
        }

        public override string ToString()
        {
            return Nom;
        }
        public override int GetHashCode()
        {
            return Code_client.GetHashCode();
        }
        public string Code_client { get; set; }
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public string Solde { get; set; }
        public Categories_clients Categorie { get; set; }
        public string Seuil_endettement { get; set; }
        public string Etat { get; set; }
        public string Situation_solde { get; set; }
        public string Autres_infos { get; set; }
        public string Type_client { get; set; }
        public Ristournes Ristourne { get; set; }

    }
}
