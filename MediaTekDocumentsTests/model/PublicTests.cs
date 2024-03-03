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
    public class PublicTests
    {
        private const string id = "0001";
        private const string libelle = "testLibelle";
        private static readonly Public testPublic = new Public(id, libelle);
        [TestMethod()]
        public void PublicTest()
        {
            Assert.AreEqual(id, testPublic.Id);
            Assert.AreEqual(libelle, testPublic.Libelle);
        }
    }
}