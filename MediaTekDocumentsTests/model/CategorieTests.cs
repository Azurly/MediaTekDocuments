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
    public class CategorieTests
    {
        private const string id = "0001";
        private const string libelle = "test";
        private readonly static Categorie test = new Categorie(id, libelle);
        [TestMethod()]
        public void CategorieTest()
        {
            Assert.AreEqual(id, test.Id, "fonctionne");
            Assert.AreEqual(libelle, test.Libelle, "fonctionne");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(libelle, test.ToString(), "fonctionne");
        }
    }
}