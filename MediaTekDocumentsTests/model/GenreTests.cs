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
    public class GenreTests
    {

        private const string Id = "0005";
        private const string genreName = "Horreur";
        private static readonly Genre genreHorreur = new Genre(Id, genreName);
        [TestMethod()]
        public void GenreTest()
        {
            Assert.AreEqual(Id, genreHorreur.Id, "devrait marché");
            Assert.AreEqual(genreName, genreHorreur.Libelle, "devrait marché");
            Assert.AreEqual(genreHorreur.ToString(), "Horreur", "devrait marché");

        }

    }
}