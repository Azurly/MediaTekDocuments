using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model.Tests
{
    [TestClass()]
    public class UtilisateurTests
    {
        private const string id = "0001";
        private const string nom = "lenom";
        private const string prenom = "leprenom";
        private const string mail = "lemail";
        private const string idService = "testidservice";
        private const string libelleService = "testlibelleservice";
        private readonly static Utilisateur lutilisateur = new Utilisateur(id, nom, prenom, mail, idService, libelleService);
        [TestMethod()]
        public void UtilisateurTest()
        {
            Assert.AreEqual(id, lutilisateur.id);
            Assert.AreEqual(nom, lutilisateur.nom);
            Assert.AreEqual(prenom, lutilisateur.prenom);
            Assert.AreEqual(mail, lutilisateur.mail);
            Assert.AreEqual(idService, lutilisateur.idService);
            Assert.AreEqual(libelleService, lutilisateur.libelleService);

        }
    }
}