using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDPRO.BO
{
    [Serializable]
    public class Categories_clients
    {
        public Categories_clients()
        {
        }

        public Categories_clients(string libelle, string description, int id)
        {
            Libelle = libelle;
            Description = description;
            Id = id;
        }

        public string Libelle { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Categories_clients clients &&
                   Id == clients.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
