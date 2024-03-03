using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Commande
    {
        public string id { get; set; }
        public DateTime dateCommande { get; set; }
        public float montant { get; }

        public Commande(string id, DateTime dateCommande, float montant)
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.montant = montant;
        }
    }
}