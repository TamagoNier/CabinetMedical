using System;
using System.Collections.Generic;
using System.Text;

namespace CabinetMedical.Exceptions
{
    internal class TempException
    {
        public String Application { get; set; }
        public String ClasseException { get; set; }
        public DateTime DateException { get; set; }
        public String MessageException { get; set; }
        public String UserException { get; set; }
        public String UserMachine { get; set; }
    }
}
