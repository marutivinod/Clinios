using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ClinIOS.Models
{
    public static class Extensions
    {

        public static void ExecuteTableValueProcedure<T>(this DbContext context, IEnumerable<T> data, string procedureName, string paramName, string param2, int Param2Value, string typeName)
        {
            try
            {
                context.Database.ExecuteSqlCommand($"{procedureName} {paramName},{param2}",
                        new SqlParameter(paramName, data.ToDataTable()) { SqlDbType = SqlDbType.Structured, TypeName = typeName },
                        new SqlParameter(param2, Param2Value) { SqlDbType = SqlDbType.Int });
            }
            catch (Exception) { throw; }
        }
        public static int ExecuteTableValueProcedureWithId<T>(this DbContext context, IEnumerable<T> data, string procedureName, string paramName, string param2, bool Param2Value, string typeName)
        {
            try
            {
                var bookIdParameter = new SqlParameter() { ParameterName = "@newId", Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int };
                var authors = context.Database.ExecuteSqlCommand($"{procedureName} {paramName},{param2},{bookIdParameter.ParameterName} OUT",
                    new SqlParameter(paramName, data.ToDataTable()) { SqlDbType = SqlDbType.Structured, TypeName = typeName },
                    new SqlParameter(param2, Param2Value) { SqlDbType = SqlDbType.Bit }, bookIdParameter);
                return (int)bookIdParameter.Value;
            }
            catch (Exception e) { throw e; }
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            var props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++) { table.Columns.Add(props[i].Name, Nullable.GetUnderlyingType(props[i].PropertyType) ?? props[i].PropertyType); }
            object[] values = new object[props.Count];
            foreach (T item in data) { for (int i = 0; i < values.Length; i++) { values[i] = props[i].GetValue(item); } table.Rows.Add(values); }
            return table;
        }
    }

}