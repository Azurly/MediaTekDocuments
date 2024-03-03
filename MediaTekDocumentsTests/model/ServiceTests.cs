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
    public class ServiceTests
    {
        private const string id = "0001";
        private const string libelle = "lelibelle";
        private readonly static Service leService = new Service(id, libelle);
        [TestMethod()]
        public void ServiceTest()
        {
            Assert.AreEqual(id, leService.id);
            Assert.AreEqual(libelle, leService.libelle);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(libelle, leService.ToString());
        }
    }
}