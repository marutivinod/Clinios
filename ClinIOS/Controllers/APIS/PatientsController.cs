using ClinIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class PatientsController : ApiController
    {
        public List<Dictionary<string, object>> Get(string secName)
        {
            return new MetaData().GetData(secName);
        }
    }
}
