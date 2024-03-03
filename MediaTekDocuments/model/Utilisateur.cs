using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Utilisateur
    {
        public string id { get; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string idService { get; set; }
        public string libelleService { get; set; }
        /// <param name = "id" ></ param >
        /// <param name = "nom" ></ param >
        /// <param name = "prenom" ></ param >
        /// <param name = "mail" ></ param >
        /// <param name = "idService" ></ param >
        public Utilisateur(string id, string nom, string prenom, string mail, string idService, string libelleService)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.idService = idService;
            this.libelleService = libelleService;
        }
    }
}
