using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Boissons
    {
        public Boissons()
        {
        }

        public Boissons(string code_Boissons, string libelle, string famille, string sous_Famille, int format, int alerte_Stock, int prix_Unitaire, double prix_VenteTTc)
        {
            Code_Boissons = code_Boissons;
            Libelle = libelle;
            Famille = famille;
            Sous_Famille = sous_Famille;
            Format = format;
            Alerte_Stock = alerte_Stock;
            Prix_Unitaire = prix_Unitaire;
            Prix_VenteTTc = prix_VenteTTc;
        }

        public string Code_Boissons { get; set; }
        public string Libelle { get; set; }
        public string Famille { get; set; }
        public string Sous_Famille { get; set; }
        public int Format { get; set; }
        public int Alerte_Stock { get; set; }
        public int Prix_Unitaire { get; set; }
        public double Prix_VenteTTc { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Boissons boissons &&
                   Code_Boissons == boissons.Code_Boissons;
        }

        public override int GetHashCode()
        {
            return -1042539517 + EqualityComparer<string>.Default.GetHashCode(Code_Boissons);
        }
    }
}
