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
    public class LivreTests
    {
        private const string id = "0001";
        private const string titre = "leTitre";
        private const string image = "l'image.png";
        private const string isbn = "545464164";
        private const string auteur = "lauteur";
        private const string collection = "lacollection";
        private const string idGenre = "l'idGenre";
        private const string genre = "le genre";
        private const string idPublic = "idPublic";
        private const string lePublic = "le Public";
        private const string idRayon = "l'idRayon";
        private const string rayon = "le rayon";
        private readonly static Livre leLivre = new Livre(id, titre, image, isbn, auteur, collection,
            idGenre, genre, idPublic, lePublic, idRayon, rayon);
        [TestMethod()]
        public void LivreTest()
        {
            Assert.AreEqual(id, leLivre.Id);
            Assert.AreEqual(titre, leLivre.Titre);
            Assert.AreEqual(image, leLivre.Image);
            Assert.AreEqual(isbn, leLivre.Isbn);
            Assert.AreEqual(auteur, leLivre.Auteur);
            Assert.AreEqual(collection, leLivre.Collection);
            Assert.AreEqual(idGenre, leLivre.IdGenre);
            Assert.AreEqual(genre, leLivre.Genre);
            Assert.AreEqual(idPublic, leLivre.IdPublic);
            Assert.AreEqual(lePublic, leLivre.Public);
            Assert.AreEqual(idRayon, leLivre.IdRayon);
            Assert.AreEqual(rayon, leLivre.Rayon);
        }
    }
}