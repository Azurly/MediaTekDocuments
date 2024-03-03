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
    public class RevueTests
    {
        private const string id = "0001";
        private const string titre = "leTitre";
        private const string image = "l'image.png";
        private const string periodicite = "laperiodicite";
        private const int delaimiseadispo = 0000;
        private const string idGenre = "l'idGenre";
        private const string genre = "le genre";
        private const string idPublic = "idPublic";
        private const string lePublic = "le Public";
        private const string idRayon = "l'idRayon";
        private const string rayon = "le rayon";
        private readonly static Revue leLivre = new Revue(id, titre, image,
            idGenre, genre, idPublic, lePublic, idRayon, rayon, periodicite, delaimiseadispo);

        [TestMethod()]
        public void RevueTest()
        {
            Assert.AreEqual(id, leLivre.Id);
            Assert.AreEqual(titre, leLivre.Titre);
            Assert.AreEqual(image, leLivre.Image);
            Assert.AreEqual(periodicite, leLivre.Periodicite);
            Assert.AreEqual(delaimiseadispo, leLivre.DelaiMiseADispo);
            Assert.AreEqual(idGenre, leLivre.IdGenre);
            Assert.AreEqual(genre, leLivre.Genre);
            Assert.AreEqual(idPublic, leLivre.IdPublic);
            Assert.AreEqual(lePublic, leLivre.Public);
            Assert.AreEqual(idRayon, leLivre.IdRayon);
            Assert.AreEqual(rayon, leLivre.Rayon);
        }
    }
}