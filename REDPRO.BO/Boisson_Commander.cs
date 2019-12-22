using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Boisson_Commander
    {
        public Boisson_Commander()
        {
        }

        public Boisson_Commander(string code_Boissons, string libelle, string code_commandes, string qtité, string unité)
        {
            Code_Boissons = code_Boissons;
            Libelle = libelle;
            Code_commandes = code_commandes;
            Qtité = qtité;
            this.unité = unité;
        }

        public string Code_Boissons { get; set; }
        public string Libelle { get; set; }
        public string Code_commandes { get; set; }
        public string Qtité { get; set; }
        public string unité { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Boisson_Commander commander &&
                   Code_Boissons == commander.Code_Boissons &&
                   Code_commandes == commander.Code_commandes;
        }

        public override int GetHashCode()
        {
            var hashCode = -456820583;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code_Boissons);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code_commandes);
            return hashCode;
        }
    }
}
