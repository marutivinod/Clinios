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
    
    public partial class sp_GetStrk_Team_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> StrokeId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> ERPhyId { get; set; }
        public Nullable<int> AnestId { get; set; }
        public Nullable<int> RadiolgyId { get; set; }
        public Nullable<int> NeuroSrgnId { get; set; }
        public string Others { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
