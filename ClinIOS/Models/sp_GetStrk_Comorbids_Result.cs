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
    
    public partial class sp_GetStrk_Comorbids_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> StrokeId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<bool> HTNInd { get; set; }
        public Nullable<bool> DMInd { get; set; }
        public Nullable<bool> Asth_COPDInd { get; set; }
        public Nullable<bool> DyslipInd { get; set; }
        public Nullable<bool> SmokeInd { get; set; }
        public Nullable<bool> EthanolInd { get; set; }
        public Nullable<bool> hoCVAInd { get; set; }
        public Nullable<bool> EpilepsyInd { get; set; }
        public Nullable<bool> hoCADInd { get; set; }
        public Nullable<bool> CABGInd { get; set; }
        public Nullable<bool> PCTAInd { get; set; }
        public string Others { get; set; }
        public Nullable<bool> NoneInd { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
