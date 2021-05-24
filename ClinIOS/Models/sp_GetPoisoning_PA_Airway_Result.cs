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
    
    public partial class sp_GetPoisoning_PA_Airway_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> PoisoningId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<bool> A_PatentInd { get; set; }
        public Nullable<bool> A_ObstrInd { get; set; }
        public Nullable<int> A_ObstrForgnBodyId { get; set; }
        public Nullable<int> A_ObstrFluidsId { get; set; }
        public Nullable<bool> A_FrnBodyInd { get; set; }
        public Nullable<bool> A_FluidInd { get; set; }
        public Nullable<bool> A_ProtectedInd { get; set; }
        public Nullable<int> A_ProtectedId { get; set; }
        public Nullable<bool> A_C_CollarInd { get; set; }
        public Nullable<int> M_AdjId { get; set; }
        public Nullable<int> M_ProcId { get; set; }
        public Nullable<bool> M_SuctionInd { get; set; }
        public Nullable<bool> M_Info_AnastInd { get; set; }
        public Nullable<bool> M_Info_NeuroInd { get; set; }
        public Nullable<bool> M_Info_HdNcktInd { get; set; }
        public string Air_Re_Assesment { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
