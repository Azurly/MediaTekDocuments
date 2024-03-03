using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CommandeDocument : Commande
    {
        public int nbrExemplaire { get; }
        public string idLivreDvd { get; }
        public string idSuivi { get; }
        public string etatSuivi { get; }

        public CommandeDocument(int v, string id, DateTime dateCommande, float montant, 
            int nbrExemplaire, string idLivreDvd, string idSuivi, string etatSuivi) : base(id, dateCommande, montant)
        {
            this.nbrExemplaire = nbrExemplaire;
            this.idLivreDvd = idLivreDvd;
            this.idSuivi = idSuivi;
            this.etatSuivi = etatSuivi;
        }
    }
}