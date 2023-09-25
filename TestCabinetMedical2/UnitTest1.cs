using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabinetMedical.ClassesMetier;

namespace TestCabinetMedical2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;
            int somme = SertAFaireUnTestUnitaire.SommePourRien(a,b);
            Assert.AreEqual(8, somme);
        }
    }
}
