//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinIOS.Models
{
    using System;
    
    public partial class sp_GetStrk_Disposition_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> StrokeId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<System.DateTime> DispTime { get; set; }
        public Nullable<int> DispId { get; set; }
        public Nullable<int> ER { get; set; }
        public string ERSign { get; set; }
        public Nullable<int> ReceiveDoc { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
