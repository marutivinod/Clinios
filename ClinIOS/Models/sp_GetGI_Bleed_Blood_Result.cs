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
    
    public partial class sp_GetGI_Bleed_Blood_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> GI_BleedId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> Sno { get; set; }
        public string BloodProcCrystllColl { get; set; }
        public Nullable<double> Volume { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string OrderBy { get; set; }
        public string AdminBy { get; set; }
        public Nullable<int> BloodTransfusActId { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
