using ClinIOS.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class ChestPainController : ApiController
    {
        [AllowAnonymous]
        public Dictionary<string, object> Get(string secName, int Id)
        {
            return new MetaData().GetData(secName, Id);
        }
        [AllowAnonymous]
        public void Put(Dictionary<string, object> data,string key)
        {
            new MetaData().SaveData(key, data);
        }
        public void Put(List<PutClass> data)
        {
            foreach (var item in data) new MetaData().SaveData(item.Sec, item.Obj);
        }
    }
}
