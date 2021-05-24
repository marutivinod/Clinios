using ClinIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class DDValuesController : ApiController
    {
        DataAccess da = new DataAccess();
        //public int UID { get { return da.GetUserIdByName(System.Web.HttpContext.Current.User.Identity.Name); } }
        [AllowAnonymous]
        [HttpGet]
        public Dictionary<string, List<Dictionary<string, object>>> GET(string idList)
        {
            using (ClinIOSDBEntities ctx = new ClinIOSDBEntities())
            {
                var result = new Dictionary<string, List<Dictionary<string, object>>>();
                var WholeList = ctx.spGetMasterListkeys(idList).ToList();
                var MasterList = WholeList.Select(x => x.KeyName).Distinct().ToArray();
                foreach (var lst in MasterList)
                {
                    result.Add(lst, da.GetDictionaryFromClass(WholeList.Where(x => x.KeyName.Equals(lst)).Select(y => new GenericList { Id = y.ListkeyId, Name = y.ListKeyName }).ToList()));
                }

                return result;
            }
        }

        [HttpGet]
        public List<Dictionary<string, object>> getCities()
        {
            using (ClinIOSDBEntities ctx = new ClinIOSDBEntities())
            {
                var c = da.GetDictionaryFromClass(ctx.sp_getCitynames().ToList());
                return c;
            }
        }

        [HttpGet]
        public List<Dictionary<string, object>> getStatesCountry(int cityId, int flag)
        {
            using (ClinIOSDBEntities ctx = new ClinIOSDBEntities())
            {
                var c = da.GetDictionaryFromClass(ctx.sp_getStateCountryListbyCityId(cityId, flag).ToList());
                return c;
            }
        }


    }
}
