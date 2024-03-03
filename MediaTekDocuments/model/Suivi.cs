using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Suivi
    {
        public string id { get; set; }
        public string etatCommande {  get; set; }

        public Suivi(string id, string etatCommande)
        {
            this.id = id;
            this.etatCommande = etatCommande;
        }
    }
}