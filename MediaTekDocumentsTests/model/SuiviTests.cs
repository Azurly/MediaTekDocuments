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
    public class SuiviTests
    {
        private const string id = "001";
        private const string etat = "letatdelaCommande";
        private static readonly Suivi leSuivi = new Suivi(id, etat);
        [TestMethod()]
        public void SuiviTest()
        {
            Assert.AreEqual(id, leSuivi.id);
            Assert.AreEqual(etat, leSuivi.etatCommande);
        }
    }
}