using Soins2021.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class Prestation
    {
        private readonly string libelle;
        private readonly DateTime dateHeureSoin;
        private Intervenant intervenant;
        

        public string  HeureSoin()
        {
            return this.DateHeureSoin.Hour + "h"+ this.DateHeureSoin.Minute  +" - " +this.DateHeureSoin.ToShortTimeString();
        }
           

        /// <summary>
        /// property du libelle de la prestation (lecture seule)
        /// </summary>
        public string Libelle => this.libelle;

        /// <summary>
        /// property de la date des soins (lecture seule)
        /// </summary>
        public DateTime DateHeureSoin => this.dateHeureSoin;

        /// <summary>
        /// property de l'objet intervenant ayant réalisé la prestation
        /// (lecture seule)
        /// </summary>
        public Intervenant Intervenant => this.intervenant; 


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="dateHeure"></param>
        /// <param name="intervenant"></param>
        public Prestation(string libelle, DateTime dateHeurePrestation, Intervenant intervenant){
            if (dateHeurePrestation <= DateTime.Now)
            {
                this.libelle = libelle;
                this.dateHeureSoin = dateHeurePrestation;
                this.intervenant = intervenant;
            }
            else
            {
                throw new Soins2021Exception("La date de la prestation ne peut être postérieure à la date courante");
            }

        }
        /// <summary>
        /// fonction qui compare 2 dates au format DateHeure
        /// Attention ici, on ne compare que les dates.
        /// 2 dates seront égales si leur JJ/MM/AAAA  sont égaux, quelle que soit l'heure
        /// </summary>
        /// <param name="unePrestation"></param>
        /// <returns>
        ///     0 les dates sont égales
        ///     1 si la date de la prestation courante est postérieure à la date de la prestation unePrestation
        ///     -1 si la date de la prestation courante est antérieure à la date de la prestation unePrestation
        /// 
        /// </returns>
        public int compareTo(Prestation unePrestation)
        {
            //if(this.DateHeureSoin.Date > unePrestation.DateHeureSoin.Date) {
            //    return 1;
            //}
            //else
            //{
            //    if (this.DateHeureSoin.Date == unePrestation.DateHeureSoin.Date)
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        return -1;
            //    }
            //}
            // bien mieux car on utilise le framework
            return this.DateHeureSoin.Date.CompareTo(unePrestation.DateHeureSoin.Date);
        }

        

        public override string ToString()
        {
            return "\t" + this.libelle + " - " +this.dateHeureSoin.ToString() + " - " + this.intervenant;



        }
    }
}
