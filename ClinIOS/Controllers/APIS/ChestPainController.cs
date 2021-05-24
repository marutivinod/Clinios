using ClinIOS.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class ChestPainController : ApiController
    {
        public DataAccess da = new DataAccess();
        [AllowAnonymous]
        public Dictionary<string, object> Get(string secName, int Id)
        {
            return new MetaData().GetData(secName, Id);
        }

        [AllowAnonymous]
        public void Put(Dictionary<string, object> data,string key)
        {
            //data["PatientId"] = 1; 
            //foreach (var key in data.Keys)
            //{
            //    new MetaData().SaveData(key, data /*JObject.FromObject(data[key]).ToObject<Dictionary<string, object>>()*/);//JObject jObj =
            //}

            new MetaData().SaveData(key, data);

        }
    }




}
