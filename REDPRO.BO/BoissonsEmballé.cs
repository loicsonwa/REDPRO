using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class BoissonsEmballé
    {
        public BoissonsEmballé(string code_Boisson, string code_Emballage, int quantité)
        {
            Code_Boisson = code_Boisson;
            Code_Emballage = code_Emballage;
            Quantité = quantité;
        }

        public string Code_Boisson { get; set; }
        public string Code_Emballage { get; set; }
        public int Quantité { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BoissonsEmballé emballé &&
                   Code_Boisson == emballé.Code_Boisson &&
                   Code_Emballage == emballé.Code_Emballage;
        }

        public override int GetHashCode()
        {
            var hashCode = 1563402403;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code_Boisson);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code_Emballage);
            return hashCode;
        }
    }
}
