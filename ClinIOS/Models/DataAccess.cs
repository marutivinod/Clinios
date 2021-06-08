using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.Reflection;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace ClinIOS.Models
{

    public class DataAccess
    {
        public DbContext GetContext() { return new ClinIOSDBEntities(); }

        public T GetRecord<T>( string spName, int Id) where T : class { using (var ctx = GetContext()) 
            { return ctx.Database.SqlQuery<T>($"exec {spName} {Id}").SingleOrDefault(); } }
        public bool UpdateRecord<T>(T obj) where T : class
        {
            using (var ctx = GetContext())
            {
                ctx.Set<T>().Attach(obj);
                ctx.Entry<T>(obj).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            };
        }
      
       
        public T InsertRecord<T>(T ts) where T : class { try { using (var ctx = GetContext()){var c = ctx.Set<T>().Add(ts); ctx.SaveChanges(); return c;}; } catch (Exception e) { return null; }
        }
        public List<T> GetRecords<T>() where T : class { using (var ctx = GetContext()) { return ctx.Set<T>().ToList(); }; }
        public List<Dictionary<string, object>> GetDictionaryFromClass<T>(List<T> obj) where T : class
        {
            var result = new List<Dictionary<string, object>>();
            obj.ForEach(c2 => { result.Add(c2.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).ToDictionary(prop => prop.Name, prop => prop.GetValue(c2, null))); });
            return result;
        }
        public void TransactRecord<T>(T data, string spName, string spType, int insertInd) where T : class { using (var ctx = GetContext()) { ctx.ExecuteTableValueProcedure(new T[] { data }, spName, "@Rec", "@operation", insertInd, spType); ctx.SaveChanges(); } }
        public void TransactRecord<T>(T data, string spName, string spType) where T : class { using (var ctx = GetContext()) { ctx.ExecuteTableValueProcedure(new T[] { data }, spName, "@Rec",  spType); ctx.SaveChanges(); } }

        public int TransactRecordWithId<T>(T data, string spName, string spType, bool insertInd) where T : class { using (var ctx = GetContext()) { var id = ctx.ExecuteTableValueProcedureWithId(new T[] { data }, spName, "@Rec", "@Operation", insertInd,  spType); ctx.SaveChanges(); return id; } }

        public Dictionary<string, object> GetDictionaryFromClass<T>(T obj) where T : class
        {
            return obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).ToDictionary(prop => prop.Name, prop => prop.GetValue(obj, null));
        }
        public T GetClassFromDictionary<T>(Dictionary<string, object> data) where T : class
        {
            var serializer = new JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };
            return serializer.Deserialize<T>(serializer.Serialize(data));
        }
        public fn_CheckLogin_Result CheckLogin(Login l) { using (var ctx = new ClinIOSDBEntities()) { return ctx.fn_CheckLogin(l.UserName, Encryptdata(l.Password)).FirstOrDefault(); } }

        public string Decryptdata(string StringValue)
        {
            var Decode = new UTF8Encoding().GetDecoder();
            var todecode_byte = Convert.FromBase64String(StringValue);
            char[] decoded_char = new char[Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            return new string(decoded_char);
        }
        public string Encryptdata(string StringValue) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(StringValue)); }


    }

   
}