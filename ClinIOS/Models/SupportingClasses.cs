using System;

namespace ClinIOS.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

       

    public class UserList
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
    public class GenericList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
        public string Remarks { get; set; }
    }

   

    public class UserRoles
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Description { get; set; }
        public int UserRoleid { get; set; }
    }

   
    //Labels
    public class Labels
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }


   
}