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
    
    public partial class sp_GetGI_Bleed_PA_Breathing_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> GI_BleedId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> A_ChstRaiseId { get; set; }
        public Nullable<int> A_PalpationId { get; set; }
        public Nullable<int> A_Palpation_RLId { get; set; }
        public Nullable<int> A_PercussionId { get; set; }
        public Nullable<int> A_Percussion_RLId { get; set; }
        public Nullable<int> A_AirEntryId { get; set; }
        public Nullable<int> A_AirEntry_RLId { get; set; }
        public Nullable<int> A_RespSoundId { get; set; }
        public Nullable<bool> A_RhonchiInd { get; set; }
        public Nullable<bool> A_WheezeInd { get; set; }
        public Nullable<double> M_Oxygen { get; set; }
        public Nullable<int> M_ProngMaskId { get; set; }
        public Nullable<int> M_Ndl_ICDId { get; set; }
        public Nullable<bool> M_Info_CTVSInd { get; set; }
        public Nullable<bool> M_Info_ChestInd { get; set; }
        public string Brath_Re_Assesment { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
