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
    
    public partial class sp_GetSeizures_PA_Disability_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> SeizuresId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> A_PupilLR_Size { get; set; }
        public Nullable<int> A_PupilR_ReactId { get; set; }
        public Nullable<int> A_PupilL_Size { get; set; }
        public Nullable<int> A_PupilL_ReactId { get; set; }
        public string A_Laterasigns { get; set; }
        public Nullable<bool> A_LOCInd { get; set; }
        public Nullable<int> A_LOCDur { get; set; }
        public Nullable<bool> A_SezInd { get; set; }
        public Nullable<int> A_SezDur { get; set; }
        public Nullable<bool> M_InfoDept { get; set; }
        public Nullable<int> PainScore { get; set; }
        public Nullable<int> A_GCS_E { get; set; }
        public Nullable<int> A_GCS_V { get; set; }
        public Nullable<int> A_GCS_M { get; set; }
        public Nullable<int> A_GCS_Tot { get; set; }
        public Nullable<int> A_RTS { get; set; }
        public string Dis_Re_Assesment { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
