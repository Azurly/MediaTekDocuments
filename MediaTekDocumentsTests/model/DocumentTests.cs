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
    public class DocumentTests
    {
        private const string Id = "0001";
        private const string Titre = "titretest";
        private const string Image = "imagetest";
        private const string IdGenre = "idgenre";
        private const string Genre = "genre";
        private const string IdPublic = "idpublic";
        private const string Public = "public";
        private const string IdRayon = "idrayon";
        private const string Rayon = "rayon";
        private readonly static Document documentTest = new Document(Id, Titre, Image, IdGenre, Genre, IdPublic, Public, IdRayon, Rayon);

        [TestMethod()]
        public void DocumentTest()
        {
            Assert.AreEqual(Id, documentTest.Id);
            Assert.AreEqual(Titre, documentTest.Titre);
            Assert.AreEqual(Image, documentTest.Image);
            Assert.AreEqual(IdGenre, documentTest.IdGenre);
            Assert.AreEqual(Genre, documentTest.Genre);
            Assert.AreEqual(IdPublic, documentTest.IdPublic);
            Assert.AreEqual(Public, documentTest.Public);
            Assert.AreEqual(IdRayon, documentTest.IdRayon);
            Assert.AreEqual(Rayon, documentTest.Rayon);
        }
    }
}