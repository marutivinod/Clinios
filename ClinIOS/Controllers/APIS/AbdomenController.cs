using ClinIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class AbdomenController : ApiController
    {
        public DataAccess da = new DataAccess();
        [AllowAnonymous]
        public Dictionary<string, object> Get(string secName, int Id)
        {
            return new MetaData().GetData(secName, Id);
        }

        [AllowAnonymous]
        public void Put(Dictionary<string, object> data, string key)
        {
            new MetaData().SaveData(key, data);
        }
    }
}
