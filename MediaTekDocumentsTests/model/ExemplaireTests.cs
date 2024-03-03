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
    public class ExemplaireTests
    {
        private const string id = "0001";
        private const int numero = 000653;
        private const string photo = "laPhoto.png";
        private static readonly DateTime laDate = new DateTime(12 / 12 / 2022);
        private const string idEtat = "0002";
        private readonly static Exemplaire lexemplaire = new Exemplaire(numero, laDate, photo, idEtat, id);
        [TestMethod()]
        public void ExemplaireTest()
        {
            Assert.AreEqual(numero, lexemplaire.Numero);
            Assert.AreEqual(photo, lexemplaire.Photo);
            Assert.AreEqual(idEtat, lexemplaire.IdEtat);
            Assert.AreEqual(id, lexemplaire.Id);
            Assert.AreEqual(new DateTime(12/12/2022), lexemplaire.DateAchat);

        }
    }
}