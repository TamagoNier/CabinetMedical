using System.Collections.ObjectModel;

namespace ClassesMetier
{
    public class Intervenant
    {
        private readonly string nom;
        private readonly string prenom;
        private Collection<Prestation> prestations;

        /// <summary>
        /// renvoit le nom de l'intervenant
        /// </summary>
        public string Nom => this.nom;

        /// <summary>
        /// renvoit le prénom de l'intervenant
        /// </summary>
        public string Prenom => this.prenom;

        /// <summary>
        /// Constructeur de l'intervanant
        /// </summary>
        /// <param name="nom">nom de l'intervenant</param>
        /// <param name="prenom">prénom de l'intervenant</param>
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            prestations = new Collection<Prestation>();
        }
        /// <summary>
        /// sérialization d'un objet de la classe Intervenant
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Intervenant : " + this.Nom + " - " + this.Prenom;
        }

        /// <summary>
        /// Ajoute une prestation à la liste des prestations effectuées par l'intervenant
        /// </summary>
        /// <param name="prestation">objet de la classe Prestation à rajouter à la listes des interventions de l'intervenant</param>
        public void AjoutePrestation(Prestation prestation)
        {
            this.prestations.Add(prestation);
        }
        /// <summary>
        /// Retourne le nombre de prestations effectuées par l'intervenant
        /// </summary>
        /// <returns>nombre d'interventions de l'intervenant</returns>
        public int GetNbPrestations()
        {
            return this.prestations.Count;
        }
    }
}
