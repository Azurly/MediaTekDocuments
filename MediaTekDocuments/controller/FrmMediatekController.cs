using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;
using Newtonsoft.Json;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Suivi> GetAllSuivis()
        {
            return access.GetAllSuivis();
        }

        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// récupère les exemplaires d'une commande Livre
        /// </summary>
        /// <param name="idLivre">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<CommandeDocument> GetCommandesLivres(string idLivre)
        {
            return access.GetCommandesLivres(idLivre);
        }

        public List<CommandeDocument> GetCommandesDvd(string idDvd)
        {
            return access.GetCommandesDvd(idDvd);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        public bool CreerCommandeDvd(CommandeDocument commandeDocument)
        {
            return access.CreerCommandeDocument(commandeDocument);
        }
        public bool UpdateCommandeDvd(CommandeDocument commandeDocument)
        {
            return access.UpdateCommandeDocument(commandeDocument);
        }
        public bool DeleteCommandeDvd(CommandeDocument commandeDocument)
        {
            return access.DeleteCommandeDocument(commandeDocument);
        }
        public bool CreerDvd(Dvd dvd)
        {
            return access.CreerDvd(dvd);
        }
        public bool UpdateDvd(Dvd dvd)
        {
            return access.UpdateDvd(dvd);
        }
        public bool DeleteDvd(Dvd dvd)
        {
            return access.DeleteDvd(dvd) ;
        }
        public bool CreerLivre(Livre livre)
        {
            return access.CreerLivre(livre);
        }
        public bool UpdateLivre(Livre livre)
        {
            return access.UpdateLivre(livre);
        }
        public bool DeleteLivre(Livre livre)
        {
            return access.DeleteLivre(livre);
        }


        #region Login et Utilisateur
        public bool verifDroitAccueil(Utilisateur utilisateur)
        {
            Console.WriteLine(utilisateur.nom);
            List<string> services = new List<string> {"0001","0002", "0003" };
            if (services.Contains(utilisateur.idService))
            {
                return true;
            }
            return false;
        }
        public bool verifCommande(Utilisateur utilisateur)
        {
            List<string> services = new List<string> { "0002" };
            if (services.Contains(utilisateur.idService))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
