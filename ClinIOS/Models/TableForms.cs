using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinIOS.Models
{
    public class TableForms
    {
        DataAccess da = new DataAccess();
        public string FOMRID { get; set; }
        public string GET { get; set; }
        public string TYPE { get; set; }
        public string TRANS { get; set; }
        public string DEL { get; set; }
        public object DATA { get; set; }
    }
}