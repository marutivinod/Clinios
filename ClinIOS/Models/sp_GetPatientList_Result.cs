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
    
    public partial class sp_GetPatientList_Result
    {
        public Nullable<long> Id { get; set; }
        public int TriageId { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string Patient { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> TrgDate { get; set; }
        public Nullable<System.TimeSpan> TrgTime { get; set; }
        public string RiskPriority { get; set; }
        public string Symptom { get; set; }
        public Nullable<int> Status { get; set; }
        public string TraigeDoneBy { get; set; }
    }
}