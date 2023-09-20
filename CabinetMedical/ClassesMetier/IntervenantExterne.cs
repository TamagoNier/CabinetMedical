using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabinetMedical.Exceptions;

namespace CabinetMedical.ClassesMetier
{
    public class IntervenantExterne : Intervenant
    {
        private readonly string specialite;
        private string adresse;
        private string tel;

     
        
        /// <summary>
        /// retourne la spécialité de l'intervenant externe
        /// </summary>
        public string Specialite => this.specialite;

        /// <summary>
        /// retourne ou définit l'adresse de l'intervenant externe
        /// </summary>
        public string Adresse { get => adresse; set => adresse = value; }

        /// <summary>
        ///retourne ou définit le téléphone de l'intervenant externe
        /// </summary>
        public string Tel { get => tel; set => tel = value; }


        /// <summary>
        /// Constructeur de la classe IntervenantExterne
        /// </summary>
        /// <param name="nom">nom de l'intervenant externe</param>
        /// <param name="prenom">prénom de l'intervenant externeparam>
        /// <param name="specialite">spécialité de l'intervenant externe</param>
        /// <param name="adresse">adresse de l'intervenant externe</param>
        /// <param name="tel">téléphone de l'intervenant externe</param>

        public IntervenantExterne(string nom, string prenom,string specialite, string adresse, string tel):base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// Sérialization d'un objet de la classe IntervenantExterne
        /// </summary>
        /// <returns>retourne l'objet IntervenantExterne sérializé</returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " +this.Tel ;
        }
    }
}
