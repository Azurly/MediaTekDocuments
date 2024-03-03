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
    public class DvdTests
    {
        private const string id = "0001";
        private const string titre = "leTitre";
        private const string image = "l'image.png";
        private const int duree = 2000;
        private const string realisateur= "leRealisatreur";
        private const string synopsis = "leSynopsis";
        private const string idGenre= "l'idGenre";
        private const string genre= "le genre";
        private const string idPublic= "idPublic";
        private const string lePublic= "le Public";
        private const string idRayon= "l'idRayon";
        private const string rayon= "le rayon";
        private readonly static Dvd leDvd = new Dvd(id, titre, image, duree, realisateur, synopsis,
            idGenre, genre, idPublic, lePublic, idRayon, rayon);

        [TestMethod()]
        public void DvdTest()
        {
            Assert.AreEqual(id, leDvd.Id);
            Assert.AreEqual(titre, leDvd.Titre);
            Assert.AreEqual(image, leDvd.Image);
            Assert.AreEqual(duree, leDvd.Duree);
            Assert.AreEqual(realisateur, leDvd.Realisateur);
            Assert.AreEqual(synopsis, leDvd.Synopsis);
            Assert.AreEqual(idGenre, leDvd.IdGenre);
            Assert.AreEqual(genre, leDvd.Genre);
            Assert.AreEqual(idPublic, leDvd.IdPublic);
            Assert.AreEqual(lePublic, leDvd.Public);
            Assert.AreEqual(idRayon, leDvd.IdRayon);
            Assert.AreEqual(rayon, leDvd.Rayon);

        }
    }
}