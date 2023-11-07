using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kor;

namespace KorUnitTest
{
    [TestClass]
    public class KorTeszteles
    {
        [TestMethod]
        public void TeruletTeszt()
        {
            // Arrange - Környezet beállítása
            //Példányosítom az osztályt
            KorClass kr = new KorClass(3);
            kr.setTerulet();

            //Act - Futtatás
            double varteredmeny = 28.27;
            double kapotteredmeny =Math.Round( kr.getTerulet(),2);
            //Assert - Kiértékelés
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void KeruletTeszt()
        {
            KorClass kr = new KorClass(3);
            kr.setKerulet();
            double varteredmeny = 18.85;
            double kapotteredmeny = Math.Round(kr.getKerulet(), 2);
            Assert.AreEqual(varteredmeny,kapotteredmeny);
        }
        [TestMethod]
        public void SugarTeszt()
        {
            KorClass kr = new KorClass(3);
            kr.getSugar();
            double varteredmeny = 3;
            double kapotteredmeny = kr.getSugar();
            Assert.AreEqual(varteredmeny, kapotteredmeny);

        }
    }
}
