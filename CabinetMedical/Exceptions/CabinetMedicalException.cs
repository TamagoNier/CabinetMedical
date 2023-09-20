using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CabinetMedical.Exceptions
{
    class CabinetMedicalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabinetMedicalException"/> class.
        /// Classe spécialisé de Exception.
        /// </summary>
        /// <param name="message"></param>
        public CabinetMedicalException(string message)
            : base("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now + "\n" + message)
        {


            JObject jsonException = new JObject
            (
                new JProperty("Erreur de :", System.Environment.UserName),
                new JProperty("\nDate de l'erreur : ", DateTime.Now),
                new JProperty("\nMessage : ", message + "\n")
            );

            File.WriteAllText(@"E:\GOGOR\bloc 2\CSharp Deuxieme Annee\CabinetMedical\CabinetMedical\logs.json", JsonConvert.SerializeObject(jsonException));

        }
    }
}