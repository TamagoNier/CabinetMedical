using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CabinetMedical.Exceptions
{
    class CabinetMedicalException : Exception
    {
        public CabinetMedicalException(string message)
            : base("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now + "\n" + message)
        {


            JObject jsonException = new JObject
            (
                new JProperty("Erreur de :", System.Environment.UserName),
                new JProperty("Date de l'erreur : ", DateTime.Now),
                new JProperty("Message : ", message)
            );

            File.WriteAllText(@"E:\GOGOR\bloc 2\CSharp Deuxieme Annee\CabinetMedical\CabinetMedical\logs.json", JsonConvert.SerializeObject(jsonException));

        }
    }
