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
    
    public partial class sp_GetAbdomen_Investigations_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> AbdomenId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<bool> AbdomenProfileInd { get; set; }
        public Nullable<bool> CBCInd { get; set; }
        public Nullable<bool> BloodGTInd { get; set; }
        public Nullable<bool> RFTInd { get; set; }
        public Nullable<bool> RBSInd { get; set; }
        public Nullable<bool> ABGInd { get; set; }
        public Nullable<bool> LFTInd { get; set; }
        public Nullable<bool> CK_MBInd { get; set; }
        public Nullable<bool> TroopITInd { get; set; }
        public Nullable<bool> SmokeInd { get; set; }
        public Nullable<bool> CoagProfInd { get; set; }
        public Nullable<bool> CXRInd { get; set; }
        public Nullable<bool> ViralScrInd { get; set; }
        public string TwoDEcho { get; set; }
        public string Others { get; set; }
        public Nullable<bool> ToxicScreenInd { get; set; }
        public Nullable<bool> PhenytionInd { get; set; }
        public string ProvisionalDiag { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
