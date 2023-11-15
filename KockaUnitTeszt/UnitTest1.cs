using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kocka;

namespace KockaUnitTeszt
{
    [TestClass]
    public class NegyszogTeszteles
    {
        [TestMethod]
        public void TeruletTeszt()
        {
            NegyszogClass negyszog1 = new NegyszogClass();
            negyszog1.SetTerulet();
            double varteredmeny = 9;
            double kapotteredmeny = negyszog1.GetTerulet();
            Assert.AreEqual(varteredmeny, kapotteredmeny);

        }
        [TestMethod]
        public void KeruletTeszt()
        {
            NegyszogClass negyszog1 = new NegyszogClass();
            negyszog1.SetKerulet();
            double varteredmeny = 12;
            double kapotteredmeny = negyszog1.GetKerulet();
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
