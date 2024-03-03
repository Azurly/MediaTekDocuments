using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using MediaTekDocuments.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.controller
{
    internal class FrmLoginController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        private Utilisateur utilisateur = null;

        private FrmMediatek mediatek;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmLoginController()
        {
            access = Access.GetInstance();
        }

        public void lanceMain()
        {
            mediatek = new FrmMediatek(utilisateur);
            mediatek.Show();
        }
        public bool GetLogin(string mail, string password)
        {
            utilisateur = access.GetLogin(mail, password);
            if(utilisateur != null) 
            {
                lanceMain();
                return true;
            }
            return false;
        }
            
    }
}
