using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabinetMedical.ClassesMetier;
using CabinetMedical.Exceptions;

namespace TestCabinetMedical2
{
    [TestClass]
    public class DossierTest
    {
        [TestMethod]
        public void TesteGetNbPrestationsI()
        {
            Intervenant intervenant = new Intervenant("Dupont", "Pierre");
            intervenant.AjoutePrestation(new Prestation("Presta 10", new DateTime(2019,6,12),intervenant));
            intervenant.AjoutePrestation(new Prestation("Presta 11", new DateTime(2019,6,15),intervenant));
            Assert.AreEqual(2, intervenant.GetNbPrestations());
        }

        [TestMethod]
        public void TesteGetNbPrestationsIE()
        {
            IntervenantExterne intervenantExt = new IntervenantExterne("Dupont", "Pierre", "Magie", "Rue Del Los Amigos", "060606060606");
            intervenantExt.AjoutePrestation(new Prestation("Presta 10", new DateTime(2019, 6, 12), intervenantExt));
            intervenantExt.AjoutePrestation(new Prestation("Presta 11", new DateTime(2019, 6, 15), intervenantExt));
            Assert.AreEqual(2, intervenantExt.GetNbPrestations());
        }

        [TestMethod]
        public void TestDateCreationDossierOK()
        {
            Dossier dossier = new Dossier("Dupont", "Jean", new DateTime(1990, 11, 12), new DateTime(2019,3,31));
            Assert.IsInstanceOfType(dossier, typeof(Dossier));
        }

        [TestMethod]
        [ExpectedException(typeof(CabinetMedicalException))]
        public void TestDateCreationDossierKO()
        {
            DateTime dateCreationDossier = DateTime.Now.AddDays(10);
            Dossier dossier = new Dossier("Dupont", "Jean", new DateTime(1990, 11, 12), dateCreationDossier);
        }
    }
}
