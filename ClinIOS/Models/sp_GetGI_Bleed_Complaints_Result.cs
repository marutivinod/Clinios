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
    
    public partial class sp_GetGI_Bleed_Complaints_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> GI_BleedId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> HaematemesisId { get; set; }
        public Nullable<int> MalenaId { get; set; }
        public Nullable<bool> PainAbdomenInd { get; set; }
        public Nullable<bool> DysphagiaInd { get; set; }
        public Nullable<bool> FeverInd { get; set; }
        public Nullable<bool> CoughInd { get; set; }
        public Nullable<bool> RetchingInd { get; set; }
        public Nullable<bool> FatigueInd { get; set; }
        public Nullable<bool> WtLossInt { get; set; }
        public Nullable<bool> DiarrhoeaInd { get; set; }
        public Nullable<bool> SyncopeInd { get; set; }
        public Nullable<bool> Others { get; set; }
        public string HistCompl { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
