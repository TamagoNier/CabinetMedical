﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CabinetMedical;

namespace TestCabinetMedical
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;
            int somme = new SertAFaireUnTestUnitaire.SommePourRien(a, b);
            Assert.AreEqual(8, somme);
        }
    }
}
