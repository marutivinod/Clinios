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
    using System.Collections.Generic;
    
    public partial class Triage_Vitals
    {
        public int Id { get; set; }
        public Nullable<int> TriageId { get; set; }
        public Nullable<int> ConsciousLevelId { get; set; }
        public Nullable<int> RespRate { get; set; }
        public Nullable<double> PainScore { get; set; }
        public Nullable<double> GRBS { get; set; }
        public Nullable<int> SystBP { get; set; }
        public Nullable<int> DiastBP { get; set; }
        public Nullable<bool> COPD { get; set; }
        public Nullable<double> Temp { get; set; }
        public Nullable<bool> O2Req { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> RiskLevel { get; set; }
        public Nullable<int> HeartRate { get; set; }
        public Nullable<int> O2Perctge { get; set; }
        public Nullable<int> CardOrPerArrestTypeId { get; set; }
        public Nullable<int> PainTypeId { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Triage Triage { get; set; }
    }
}
