using ClinIOS.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class TirageVitalsController : ApiController
    {
        DataAccess da = new DataAccess();
        //public sp_GetTriageDetails_Result GET(string id){ return new sp_GetTriageDetails_Result();}
        public sp_GetTriageDetails_Result GET(string id)
        {
            if (id != null)
            { return da.GetRecord<sp_GetTriageDetails_Result>("sp_GetTriageDetails", int.Parse(id)); }
            else { return new sp_GetTriageDetails_Result(); }
        }

        public void PUT(Dictionary<string, object> data, string key)
        {
            new MetaData().SaveData(key, data);
            //var d=  da.GetClassFromDictionary<sp_GetTriageDetails_Result>(data);
            //da.TransactRecord(d, "spInsertUpdateTriage_Vitals", "Triage_Vital", d.TriageId == 0?0:1);
        }
    }
}
