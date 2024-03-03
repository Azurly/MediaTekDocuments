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
    public class CommandeTests
    {
        private const string id = "0001";
        private const float montant = 0.05F;
        private readonly static DateTime laDate = DateTime.Now;
        private readonly static Commande laCommande = new Commande(id, laDate, montant);
        [TestMethod()]
        public void CommandeTest()
        {
            Assert.AreEqual(id, laCommande.id);
            Assert.AreEqual(montant, laCommande.montant);
            Assert.AreEqual(laDate, laCommande.dateCommande);

        }
    }
}