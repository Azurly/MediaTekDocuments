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
    public class RayonTests
    {
        private const string id = "0001";
        private const string libelle = "testLibelle";
        private static readonly Rayon testRayon = new Rayon(id, libelle);
        [TestMethod()]
        public void RayonTest()
        {
            Assert.AreEqual(id, testRayon.Id);
            Assert.AreEqual(libelle, testRayon.Libelle);
        }
    }
}