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
    
    public partial class sp_GetSeizures_Charecters_Result
    {
        public Nullable<long> Id { get; set; }
        public Nullable<int> SeizuresId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<bool> UnuslpostrInd { get; set; }
        public Nullable<bool> GenShklimbsInd { get; set; }
        public Nullable<bool> StrLook_RollEyeInd { get; set; }
        public Nullable<bool> UrinaIncontInd { get; set; }
        public Nullable<bool> TongueBiteInd { get; set; }
        public Nullable<bool> HeadTurnShiftInd { get; set; }
        public Nullable<bool> LipsMkingInd { get; set; }
        public Nullable<bool> NotWtnssInd { get; set; }
        public Nullable<bool> ConsciLossInd { get; set; }
        public Nullable<bool> NoRegConsciInd { get; set; }
        public Nullable<bool> AltSensoriumInd { get; set; }
        public Nullable<int> NumNDurationId { get; set; }
        public Nullable<System.DateTime> DurationTime { get; set; }
        public Nullable<bool> EpiepSttusInd { get; set; }
        public Nullable<bool> PostSympNoneInd { get; set; }
        public Nullable<bool> PostSympConfInd { get; set; }
        public Nullable<bool> PostSympLmbWkInd { get; set; }
        public Nullable<bool> PostSympHdchInd { get; set; }
        public Nullable<bool> PostSympMuscSoreInd { get; set; }
        public Nullable<bool> PreHistDMInd { get; set; }
        public Nullable<bool> PreHist_HTNInd { get; set; }
        public Nullable<bool> PreHistCADInd { get; set; }
        public Nullable<bool> PreHistCKDInd { get; set; }
        public Nullable<bool> PreHistEPILEPSYInd { get; set; }
        public Nullable<bool> PreHistMALGNInd { get; set; }
        public Nullable<bool> PreHistHEADInjInd { get; set; }
        public Nullable<bool> PreHistOTHERSInd { get; set; }
        public string PreHistOTHERS { get; set; }
        public string OtherComplaints { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
