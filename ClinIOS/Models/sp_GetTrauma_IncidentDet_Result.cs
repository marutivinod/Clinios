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
    
    public partial class sp_GetTrauma_IncidentDet_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> TraumaId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string Mechanism { get; set; }
        public Nullable<System.DateTime> DateOfInci { get; set; }
        public Nullable<System.DateTime> TimeOfInci { get; set; }
        public string Place { get; set; }
        public string Drug { get; set; }
        public string Dose { get; set; }
        public string Route { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
