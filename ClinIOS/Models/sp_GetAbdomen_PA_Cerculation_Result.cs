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
    
    public partial class sp_GetAbdomen_PA_Cerculation_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> AbdomenId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<bool> A_ExtrenBleedInd { get; set; }
        public Nullable<int> A_PalorId { get; set; }
        public Nullable<int> A_ColdExtrId { get; set; }
        public Nullable<int> A_PulseId { get; set; }
        public Nullable<int> A_CVSId { get; set; }
        public Nullable<int> A_PRId { get; set; }
        public Nullable<int> A_SBPId { get; set; }
        public Nullable<int> A_RRId { get; set; }
        public Nullable<int> A_SENSId { get; set; }
        public Nullable<int> A_ClssId { get; set; }
        public Nullable<bool> A_BldLossInd { get; set; }
        public Nullable<int> EFASTScanId { get; set; }
        public Nullable<int> M_IVSite { get; set; }
        public Nullable<int> M_IVSize { get; set; }
        public Nullable<bool> M_IVAccessInd { get; set; }
        public Nullable<bool> M_IVFluidsInd { get; set; }
        public Nullable<bool> M_DefibriInd { get; set; }
        public Nullable<bool> M_BldSmplInd { get; set; }
        public string M_PreHospFluidsInd { get; set; }
        public Nullable<bool> M_FluidsCrystInd { get; set; }
        public Nullable<bool> M_FluidsCollInd { get; set; }
        public Nullable<bool> M_FluidsBldInd { get; set; }
        public Nullable<bool> M_Info_OrtoInd { get; set; }
        public Nullable<bool> M_Info_AbdomenInd { get; set; }
        public Nullable<bool> M_Info_UrologyInd { get; set; }
        public Nullable<bool> M_Info_BldBnkInd { get; set; }
        public Nullable<bool> M_Info_RadiolgyInd { get; set; }
        public string Cerc_Re_Assesment { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
