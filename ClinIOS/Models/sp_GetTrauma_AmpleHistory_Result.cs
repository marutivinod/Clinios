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
    
    public partial class sp_GetTrauma_AmpleHistory_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> TraumaId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string Allergies { get; set; }
        public Nullable<bool> Cmrbds_HTNInd { get; set; }
        public Nullable<bool> Cmrbds_DMInd { get; set; }
        public Nullable<bool> Cmrbds_Asth_COPDInd { get; set; }
        public Nullable<bool> Cmrbds_DyslipInd { get; set; }
        public Nullable<bool> Cmrbds_SmokeInd { get; set; }
        public Nullable<bool> Cmrbds_AlcoholInd { get; set; }
        public Nullable<bool> Cmrbds_BledDisOrdInd { get; set; }
        public Nullable<bool> Cmrbds_LiverCirrInd { get; set; }
        public Nullable<bool> Cmrbds_CKDInd { get; set; }
        public Nullable<bool> Cmrbds_StrokeInd { get; set; }
        public Nullable<bool> Cmrbds_MalignanInd { get; set; }
        public Nullable<bool> Cmrbds_IBDInd { get; set; }
        public Nullable<bool> Cmrbds_PreSurgeryInd { get; set; }
        public Nullable<bool> Cmrbds_hoCVAInd { get; set; }
        public Nullable<bool> Cmrbds_EpilepsyInd { get; set; }
        public Nullable<bool> Cmrbds_hoCADInd { get; set; }
        public Nullable<bool> Cmrbds_CABGInd { get; set; }
        public Nullable<bool> Cmrbds_PCTAInd { get; set; }
        public Nullable<bool> Cmrbds_Others { get; set; }
        public Nullable<bool> Cmrbds_NoneInd { get; set; }
        public string SurgicalHist { get; set; }
        public string LastMeal { get; set; }
        public string LastTetanus { get; set; }
        public string PreviousEvents { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
