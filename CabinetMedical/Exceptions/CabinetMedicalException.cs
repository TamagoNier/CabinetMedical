using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Configuration;

namespace CabinetMedical.Exceptions
{
    public class CabinetMedicalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabinetMedicalException"/> class.
        /// Classe spécialisé de Exception.
        /// </summary>
        /// <param name="message"></param>
        public CabinetMedicalException(string message)
            : base(message)
        {


            TempException tempException = new TempException()
            {
                Application = this.GetType().Assembly.GetName().Name.ToString(),
                ClasseException = this.GetType().ToString(),
                DateException = DateTime.Now,
                MessageException = this.Message,
                UserException = Environment.UserName,
                UserMachine = Environment.MachineName,

            };

            var lesAppSettings = new AppSettingsReader();
            string pathToLogFile = lesAppSettings.GetValue("pathToLogFile", typeof(string)).ToString();
            if (!File.Exists(pathToLogFile))
            {
                var fichierCree = File.Create(pathToLogFile);
                fichierCree.Close();
            }
            String contenuJson = File.ReadAllText(pathToLogFile);
            List<TempException> tempExceptions = JsonConvert.DeserializeObject<List<TempException>>(contenuJson);
            if (tempExceptions == null)
            {
                tempExceptions = new List<TempException>();
            }
            tempExceptions.Add(tempException);
            var jsonEncoded = JsonConvert.SerializeObject(tempExceptions, Formatting.Indented);
            File.WriteAllText(pathToLogFile, jsonEncoded);

        }
    }
}