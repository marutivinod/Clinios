using ClinIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClinIOS.Controllers.APIS
{
    public class UsersController : ApiController
    {

        public DataAccess da = new DataAccess();
       
        public List<Dictionary<string, object>> Get()
        {
            var c = da.GetRecords<User>().Where(z => z.IsActive == true).ToList();
            c.ForEach(x =>
            {
                x.Password = da.Decryptdata(x.Password); //"U2hhaDIyNyFAIw=="
            });
            return da.GetDictionaryFromClass(c);
        }

        [HttpGet]
        public Dictionary<string, object> Edit(int id)
        {
            var c = da.GetRecords<User>().Where(z => z.IsActive == true && z.Id == id).SingleOrDefault();
            return da.GetDictionaryFromClass(c);
             
        }


        public void Post(Dictionary<string, object> data)
        {
            var AppUser = new User()
            {
                FirstName = data["FirstName"].ToString(),
                MiddleName = data["MiddleName"].ToString(),
                LastName = data["LastName"].ToString(),
                RoleId = Convert.ToInt32(data["RoleId"]),
                DesignationId = Convert.ToInt32(data["DesignationId"]),
                DOB = Convert.ToDateTime(data["DOB"].ToString()),
                GenderId = Convert.ToInt32(data["GenderId"]),
                PhoneNo = data["PhoneNo"].ToString(),
                AlternatePhoneNo = data["AlternatePhoneNo"].ToString(),
                Email = data["Email"].ToString(),
                UserName = data["UserName"].ToString(),
                Password = da.Encryptdata(data["Password"].ToString()),
                StreetAddress = data["StreetAddress"].ToString(),
                CityId = Convert.ToInt32(data["CityId"]),
                StateId = Convert.ToInt32(data["StateId"]),                
                IsActive = true,
                //CreatedBy = UID,
                CreatedDate = DateTime.Now,
            };            
            da.InsertRecord(AppUser);
        }
        public void Put(Dictionary<string, object> data)
        {
            var AppUser = new User()
            {
                Id = int.Parse(data["Id"].ToString()),
                FirstName = data["FirstName"].ToString(),
                MiddleName = data["MiddleName"].ToString(),
                LastName = data["LastName"].ToString(),
                RoleId = Convert.ToInt32(data["RoleId"]),
                DesignationId = Convert.ToInt32(data["DesignationId"]),
                DOB = Convert.ToDateTime(data["DOB"].ToString()),
                GenderId = Convert.ToInt32(data["GenderId"]),
                PhoneNo = data["PhoneNo"].ToString(),
                AlternatePhoneNo = data["AlternatePhoneNo"].ToString(),
                Email = data["Email"].ToString(),
                UserName = data["UserName"].ToString(),
                Password = da.Encryptdata(data["Password"].ToString()),
                StreetAddress = data["StreetAddress"].ToString(),
                CityId = Convert.ToInt32(data["CityId"]),
                StateId = Convert.ToInt32(data["StateId"]),
                IsActive = true,
                //CreatedBy = UID,
                //CreatedDate = DateTime.Now,
                ModifiedBy=1,
                ModifiedDate = DateTime.Now
            };
           
            da.UpdateRecord(AppUser);
        }

        //[HttpDelete]
        //public void Delete(int userId)
        //{
        //    using (ClinIOSDBEntities ctx = new ClinIOSDBEntities())
        //    {
        //        ctx.sp_DeleteUser(userId, UID);
        //    }
        //}
    }
}
