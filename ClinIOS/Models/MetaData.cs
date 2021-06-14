using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ClinIOS.Models
{
    public class MetaData
    {
        DataAccess da = new DataAccess();

        [AllowAnonymous]
        private List<TableForms> Froms()
        {
            return new List<TableForms>()
            {
                //Chest Pain
                 new TableForms("CP_Complaints", "sp_GetCP_Complaints","spUpdateCP_Complaints","CP_Complaints")
                ,new TableForms("CP_Moa", "sp_GetCP_Master","spUpdateCP_Master","CP_Master")
                ,new TableForms("Chestpain" ,"sp_GetChestpain","spUpdateCP_Master","ChestPain")
                ,new TableForms("CP_CoMor_RiskFactors" ,"sp_GetCP_CoMor_RiskFactors","spUpdateCP_CoMor_RiskFactors","CP_CoMor_RiskFactors")
                ,new TableForms("CP_Drug" ,"sp_GetCP_Drug","spUpdateCP_Drug","CP_Drug")
                ,new TableForms("CP_Ecg" ,"sp_GetCP_Ecg","spUpdateCP_Ecg","CP_Ecg")
                ,new TableForms("CP_Investgations" ,"sp_GetCP_Investgations","spUpdateCP_Investigations","CP_Investigations")
                ,new TableForms("CP_NonST" ,"sp_GetCP_NonST","spUpdateCP_NonST","CP_NonST")
                ,new TableForms("CP_PhysicalExamination" ,"sp_GetCP_PhysicalExamination","spUpdateCP_PhysicalExamination","CP_PhysicalExamination")
                ,new TableForms("CP_PrimeAssmnt_Airway" ,"sp_GetCP_PrimeAssmnt_Airway","spUpdateCP_PrimeAssmnt_Airway","CP_PrimeAssmnt_Airway")
                ,new TableForms("CP_PrimeAssmnt_Breathing" ,"sp_GetCP_PrimeAssmnt_Breathing","spUpdateCP_PrimeAssmnt_Breathing","CP_PrimeAssmnt_Breathing")
                ,new TableForms("CP_PrimeAssmnt_Cerculation" ,"sp_GetCP_PrimeAssmnt_Cerculation","spUpdateCP_PrimeAssmnt_Cerculation","CP_PrimeAssmnt_Cerculation")
                ,new TableForms("CP_PrimeAssmnt_Disablty" ,"sp_GetCP_Disability","spUpdateCP_PrimeAssmnt_Disability","CP_PrimeAssmnt_Disability")
                ,new TableForms("CP_PrimeAssmnt_Expo" ,"sp_GetCP_Exposure","spUpdateCP_PrimeAssmnt_Exposure","CP_PrimeAssmnt_Exposure")
                ,new TableForms("CP_ST" ,"sp_GetCP_ST","spUpdateCP_ST","CP_ST")
                ,new TableForms("CP_STPharmPCI" ,"sp_GetCP_STPharmPCI","spUpdateCP_STPharmPCI","CP_STPharmPCI")
                ,new TableForms("CP_Vitals" ,"sp_GetCP_Vitals","spUpdateCP_Vitals","CP_Vitals")
                ,new TableForms("CP_DISP" ,"sp_GetCP_Disposition","spUpdateCP_Disposition","CP_Disposition")

                //stroke
                ,new TableForms("STRK_preHospt" ,"sp_GetStrokeMaster","spInsertUpdateStrokeMaster","StrokeMaster")
                //,new TableForms("STRK_emegRoom" ,"","","")
                ,new TableForms("STRK_vitalsOnArri" ,"sp_GetStrk_Vitals","spInsertUpdateStrk_Vitals","Strk_Vitals")
                ,new TableForms("STRK_psAirWay" ,"sp_GetStrk_PA_Airway","spInsertUpdateStrk_PA_Airway","Strk_PA_Airway")
                ,new TableForms("STRK_psBreath" ,"sp_GetStrk_PA_Breathing","spInsertUpdateStrk_PA_Breathing","Strk_PA_Breathing")
                ,new TableForms("STRK_psCirc" ,"sp_GetStrk_PA_Cerculation","spInsertUpdateStrk_PA_Cerculation","Strk_PA_Cerculation")
                ,new TableForms("STRK_psDisab" ,"sp_GetStrk_PA_Disability","spInsertUpdateStrk_PA_Disability","Strk_PA_Disability")
                ,new TableForms("STRK_psExpo" ,"sp_GetStrk_PA_Exposure","spInsertUpdateStrk_PA_Exposure","Strk_PA_Exposure")
                ,new TableForms("STRK_strkEval" ,"sp_GetStrk_Evaluation","spInsertUpdateStrk_Evaluation","Strk_Evaluation")
                ,new TableForms("STRK_strkTeam" ,"sp_GetStrk_Team","spInsertUpdateStrk_Team","Strk_Team")
                ,new TableForms("STRK_crMorbds" ,"sp_GetStrk_Comorbids","spInsertUpdateStrk_Comorbids","Strk_Comorbids")
                ,new TableForms("STRK_invesgt" ,"sp_GetStrk_Investigations","spInsertUpdateStrk_Investigations","Strk_Investigations")
                ,new TableForms("STRK_invesgtTimes" ,"sp_GetStrk_Investigations_Times","spInsertUpdateStrk_Investigations_Times","Strk_Investigations_Times")
                ,new TableForms("STRK_planCare" ,"sp_GetStrk_PlanOfCare","spInsertUpdateStrk_PlanOfCare","Strk_PlanOfCare")
                ,new TableForms("STRK_strk_FibriList" ,"sp_GetStrk_FibrinolyticChkList","spInsertUpdateStrk_FibrinolyticChkList","Strk_FibrinolyticChkList")
                ,new TableForms("STRK_strk_Port" ,"sp_GetStrk_Protocol","spInsertUpdateStrk_Protocol","Strk_Protocol")
                ,new TableForms("STRK_Strk_Dispo" ,"sp_GetStrk_Disposition","spInsertUpdateStrk_Disposition","Strk_Disposition")
                ,new TableForms("STRK_vitalPop" ,"sp_GetStrk_Vitals","spInsertUpdateStrk_Vitals","Strk_Vitals")
                ,new TableForms("STRK_Drugs" ,"spInsertUpdateStrk_Drug","spInsertUpdateTrauma_Drug","Strk_Drug")
                ,new TableForms("STRK_DrugsER" ,"spInsertUpdateStrk_DrugRecon","spInsertUpdateTrauma_DrugRecon","Strk_DrugRecon")


                //Abdomen
                ,new TableForms("AB_moa" ,"sp_GetAbdomenMaster","spInsertUpdateAbdomenMaster","AbdomenMaster")
                ,new TableForms("AB_PAAir" ,"sp_GetAbdomen_PA_Airway","spInsertUpdateAbdomen_PA_Airway","Abdomen_PA_Airway")
                ,new TableForms("AB_PABreat" ,"sp_GetAbdomen_PA_Breathing","spInsertUpdateAbdomen_PA_Breathing","Abdomen_PA_Breathing")
                ,new TableForms("AB_PACir" ,"sp_GetAbdomen_PA_Cerculation","spInsertUpdateAbdomen_PA_Cerculation","Abdomen_PA_Cerculation")
                ,new TableForms("AB_VitalPop" ,"sp_GetAbdomen_Vitals","spInsertUpdateAbdomen_Vitals","Abdomen_Vitals")
                ,new TableForms("AB_PADisa" ,"sp_GetAbdomen_PA_Disability","spInsertUpdateAbdomen_PA_Disability","Abdomen_PA_Disability")
                ,new TableForms("AB_PAExpo" ,"sp_GetAbdomen_PA_Exposure","spInsertUpdateAbdomen_PA_Exposure","Abdomen_PA_Exposure")
                ,new TableForms("AB_PrCp" ,"sp_GetAbdomen_PresentCompl","spInsertUpdateAbdomen_PresentCompl","Abdomen_PresentCompl")
                ,new TableForms("AB_Cmrbds" ,"sp_GetAbdomen_Comorbids","spInsertUpdateAbdomen_Comorbids","Abdomen_Comorbids")
                ,new TableForms("AB_ABIncid" ,"sp_GetAbdomen_Incidents","spInsertUpdateAbdomen_Incidents","Abdomen_Incidents")
                ,new TableForms("AB_Exams" ,"sp_GetAbdomen_Examinations","spInsertUpdateAbdomen_Examinations","Abdomen_Examinations")
                ,new TableForms("AB_Invs" ,"sp_GetAbdomen_Investigations","spInsertUpdateAbdomen_Investigations","Abdomen_Investigations")
                ,new TableForms("AB_Refs" ,"sp_GetAbdomen_Referels","spInsertUpdateAbdomen_Referels","Abdomen_Referels")
                ,new TableForms("AB_DISP" ,"sp_GetAbdomen_Disposition","spInsertUpdateAbdomen_Disposition","Abdomen_Disposition")
                ,new TableForms("AB_Drugs" ,"sp_GetAbdomen_Drug","spInsertUpdateAbdomen_Drug","Abdomen_Drug")
                ,new TableForms("AB_DrugsChrts" ,"sp_GetAbdomen_DrugRecon","spInsertUpdateAbdomen_DrugRecon","Abdomen_DrugRecon")

                //GI
                ,new TableForms("GI_VitalsPop" ,"sp_GetGI_Bleed_Vitals","spInsertUpdateGI_Bleed_Vitals","GI_Bleed_Vitals")
                ,new TableForms("GI_PreHosp" ,"sp_GetGI_Bleed_PreHospital","spInsertUpdateGI_Bleed_PreHospital","GI_Bleed_PreHospital")
                ,new TableForms("GI_vitals2" ,"sp_GetGI_Bleed_Vitals","spInsertUpdateGI_Bleed_Vitals","GI_Bleed_Vitals")
                ,new TableForms("GI_PAAir" ,"sp_GetGI_Bleed_PA_Airway","spInsertUpdateGI_Bleed_PA_Airway","GI_Bleed_PA_Airway")
                ,new TableForms("GI_PABreat" ,"sp_GetGI_Bleed_PA_Breathing","spInsertUpdateGI_Bleed_PA_Breathing","GI_Bleed_PA_Breathing")
                ,new TableForms("GI_PACir" ,"sp_GetGI_Bleed_PA_Cerculation","spInsertUpdateGI_Bleed_PA_Cerculation","GI_Bleed_PA_Cerculation")
                ,new TableForms("GI_PADisa" ,"sp_GetGI_Bleed_PA_Disability","spInsertUpdateGI_Bleed_PA_Disability","GI_Bleed_PA_Disability")
                ,new TableForms("GI_PAExpo" ,"sp_GetGI_Bleed_PA_Exposure","spInsertUpdateGI_Bleed_PA_Exposure","GI_Bleed_PA_Exposure")
                ,new TableForms("GI_CFShock" ,"sp_GetGI_Bleed_PA_ClacificShock","spInsertUpdateGI_Bleed_PA_ClacificShock","GI_Bleed_PA_ClacificShock")
                ,new TableForms("GI_PreCompl" ,"sp_GetGI_Bleed_Complaints","spInsertUpdateGI_Bleed_Complaints","GI_Bleed_Complaints")
                ,new TableForms("GI_Exams" ,"sp_GetGI_Bleed_Examinations","spInsertUpdateGI_Bleed_Examinations","GI_Bleed_Examinations")
                //,new TableForms("GI_Intrven" ,"","","")
                ,new TableForms("GI_Cmrbds" ,"sp_GetGI_Bleed_AmpleHistory","spInsertUpdateGI_Bleed_AmpleHistory","GI_Bleed_AmpleHistory")
                ,new TableForms("GI_RiskStrf" ,"sp_GetGI_Bleed_RiskStratification","spInsertUpdateGI_Bleed_RiskStratification","GI_Bleed_RiskStratification")
                ,new TableForms("GI_Invesg" ,"sp_GetGI_Bleed_Investigations","spInsertUpdateGI_Bleed_Investigations","GI_Bleed_Investigations")
                ,new TableForms("GI_Refs" ,"sp_GetGI_Bleed_Referels","spInsertUpdateGI_Bleed_Referels","GI_Bleed_Referels")
                ,new TableForms("GI_EndPlan" ,"sp_GetGI_Bleed_Planning","spInsertUpdateGI_Bleed_Planning","GI_Bleed_Planning")
                ,new TableForms("GI_Dispo" ,"sp_GetGI_Bleed_Disposition","spInsertUpdateGI_Bleed_Disposition","GI_Bleed_Disposition")
                ,new TableForms("GI_Drugs" ,"sp_GetGI_Bleed_Drug","spInsertUpdateGI_Bleed_Drug","GI_Bleed_Drug")
                ,new TableForms("GI_DrugsChrts" ,"sp_GetGI_Bleed_DrugRecon","spInsertUpdateGI_Bleed_DrugRecon","GI_Bleed_DrugRecon")

                //poision
                ,new TableForms("PO_VitalsPop" ,"sp_GetPoisoning_Vitals","spInsertUpdatePoisoning_Vitals","Poisoning_Vitals")
                ,new TableForms("PO_Moa" ,"sp_GetPoisoningMaster","spInsertUpdatePoisoningMaster","PoisoningMaster")
                ,new TableForms("PO_vitals" ,"sp_GetPoisoning_Vitals","spInsertUpdatePoisoning_Vitals","Poisoning_Vitals")
                ,new TableForms("PO_PAAir" ,"sp_GetPoisoning_PA_Airway","spInsertUpdatePoisoning_PA_Airway","Poisoning_PA_Airway")
                ,new TableForms("PO_PABreat" ,"sp_GetPoisoning_PA_Breathing","spInsertUpdatePoisoning_PA_Breathing","Poisoning_PA_Breathing")
                ,new TableForms("PO_PACir" ,"sp_GetPoisoning_PA_Cerculation","spInsertUpdatePoisoning_PA_Cerculation","Poisoning_PA_Cerculation")
                ,new TableForms("PO_PADisa" ,"sp_GetPoisoning_PA_Disability","spInsertUpdatePoisoning_PA_Disability","Poisoning_PA_Disability")
                ,new TableForms("PO_PAExpo" ,"sp_GetPoisoning_PA_Exposure","spInsertUpdatePoisoning_PA_Exposure","Poisoning_PA_Exposure")
                ,new TableForms("PO_DetEvnt" ,"sp_GetPoisoning_EventDet","spInsertUpdatePoisoning_EventDet","Poisoning_EventDet")
                ,new TableForms("PO_AmplHist" ,"sp_GetPoisoning_AmpleHistory","spInsertUpdatePoisoning_AmpleHistory","Poisoning_AmpleHistory")
                ,new TableForms("PO_SupCare" ,"sp_GetPoisoning_SuppCare","spInsertUpdatePoisoning_SuppCare","Poisoning_SuppCare")
                ,new TableForms("PO_PHExam" ,"sp_GetPoisoning_Examinations","spInsertUpdatePoisoning_Examinations","Poisoning_Examinations")
                ,new TableForms("PO_PoiCat" ,"sp_GetPoisioning_Categoty","spInsertUpdatePoisioning_Categoty","Poisioning_Categoty")
                ,new TableForms("PO_Inves" ,"sp_GetPoisoning_Investigations","spInsertUpdatePoisoning_Investigations","Poisoning_Investigations")
                ,new TableForms("PO_Dispo" ,"sp_GetPoisoning_Disposition","spInsertUpdatePoisoning_Disposition","Poisoning_Disposition")
                ,new TableForms("PO_Drugs" ,"sp_GetPoisoning_Drug","spInsertUpdatePoisoning_Drug","Poisoning_Drug")
                ,new TableForms("PO_DrugsChrts" ,"sp_GetPoisoning_DrugRecon","spInsertUpdatePoisoning_DrugRecon","Poisoning_DrugRecon")

                //trauma
                ,new TableForms("Trm_VitalsPop" ,"sp_GetTrauma_Vitals","spInsertUpdateTrauma_Vitals","Trauma_Vitals")
                ,new TableForms("Trm_vitals" ,"sp_GetTrauma_Vitals","spInsertUpdateTrauma_Vitals","Trauma_Vitals")
                ,new TableForms("Trm_PreHosp" ,"sp_GetTrauma_PreHospital","spInsertUpdateTrauma_PreHospital","Trauma_PreHospital")
                ,new TableForms("Trm_TraIncid" ,"sp_GetTrauma_IncidentDet","spInsertUpdateTrauma_IncidentDet","Trauma_IncidentDet")
                ,new TableForms("Trm_PSAir" ,"sp_GetTrauma_PA_Airway","spInsertUpdateTrauma_PA_Airway","Trauma_PA_Airway")
                ,new TableForms("Trm_PSBreat" ,"sp_GetTrauma_PA_Breathing","spInsertUpdateTrauma_PA_Breathing","Trauma_PA_Breathing")
                ,new TableForms("Trm_PSCir" ,"sp_GetTrauma_PA_Cerculation","spInsertUpdateTrauma_PA_Cerculation","Trauma_PA_Cerculation")
                ,new TableForms("Trm_PSDisa" ,"sp_GetTrauma_PA_Disability","spInsertUpdateTrauma_PA_Disability","Trauma_PA_Disability")
                ,new TableForms("Trm_PSExpo" ,"sp_GetTrauma_PA_Exposure","spInsertUpdateTrauma_PA_Exposure","Trauma_PA_Exposure")
                ,new TableForms("Trm_SecServ" ,"sp_GetTrauma_SecondSurvey","spInsertUpdateTrauma_SecondSurvey","Trauma_SecondSurvey")
                ,new TableForms("Trm_AmplHist" ,"sp_GetTrauma_AmpleHistory","spInsertUpdateTrauma_AmpleHistory","Trauma_AmpleHistory")
                ,new TableForms("Trm_TraTm" ,"sp_GetTrauma_Team","spInsertUpdateTrauma_Team","Trauma_Team")
                ,new TableForms("Trm_Inves" ,"sp_GetTrauma_Investigations","spInsertUpdateTrauma_Investigations","Trauma_Investigations")
                ,new TableForms("Trm_Dispo" ,"sp_GetTrauma_Disposition","spInsertUpdateTrauma_Disposition","Trauma_Disposition")
                ,new TableForms("Trm_BldRec" ,"sp_GetTrauma_Blood","spInsertUpdateTrauma_Blood","Trauma_Blood")
                ,new TableForms("Trm_Drugs" ,"sp_GetTrauma_Drug","spInsertUpdateTrauma_Drug","Trauma_Drug")
                ,new TableForms("Trm_DrugsChrts" ,"sp_GetTrauma_DrugRecon","spInsertUpdateTrauma_DrugRecon","Trauma_DrugRecon")

                //seizures
                ,new TableForms("SZ_VitalsPop" ,"sp_GetSeizures_Vitals","spInsertUpdateSeizures_Vitals","Seizures_Vitals")
                ,new TableForms("SZ_Moa" ,"sp_GetSeizuresMaster","spInsertUpdateSeizuresMaster","SeizuresMaster")
                ,new TableForms("SZ_vitals" ,"sp_GetSeizures_Vitals","spInsertUpdateSeizures_Vitals","Seizures_Vitals")
                ,new TableForms("SZ_ChSei" ,"sp_GetSeizures_Charecters","spInsertUpdateSeizures_Charecters","Seizures_Charecters")
                ,new TableForms("SZ_PSAir" ,"sp_GetSeizures_PA_Airway","spInsertUpdateSeizures_PA_Airway","Seizures_PA_Airway")
                ,new TableForms("SZ_PSBreat" ,"sp_GetSeizures_PA_Breathing","spInsertUpdateSeizures_PA_Breathing","Seizures_PA_Breathing")
                ,new TableForms("SZ_PSCir" ,"sp_GetSeizures_PA_Cerculation","spInsertUpdateSeizures_PA_Cerculation","Seizures_PA_Cerculation")
                ,new TableForms("SZ_PSDisa" ,"sp_GetSeizures_PA_Disability","spInsertUpdateSeizures_PA_Disability","Seizures_PA_Disability")
                ,new TableForms("SZ_PSExpo" ,"sp_GetSeizures_PA_Exposure","spInsertUpdateSeizures_PA_Exposure","Seizures_PA_Exposure")
                ,new TableForms("SZ_Exams" ,"sp_GetSeizures_Examinations","spInsertUpdateSeizures_Examinations","Seizures_Examinations")
                ,new TableForms("SZ_Invs" ,"sp_GetSeizures_Investigations","spInsertUpdateSeizures_Investigations","Seizures_Investigations")
                ,new TableForms("SZ_Refs" ,"sp_GetSeizures_Ref","spInsertUpdateSeizures_Ref","Seizures_Ref")
                ,new TableForms("SZ_Dispo" ,"sp_GetSeizures_Disposition","spInsertUpdateSeizures_Disposition","Seizures_Disposition")
                ,new TableForms("SZ_Drugs" ,"sp_GetSeizures_Drug","spInsertUpdateSeizures_Drug","Seizures_Drug")
                ,new TableForms("SZ_DrugsChrts" ,"sp_GetSeizures_DrugRecon","spInsertUpdateSeizures_DrugRecon","Seizures_DrugRecon")

            };
        }
        private TableForms GetTableFrom(string id)
        {
            return Froms().SingleOrDefault(x => x.FOMRID == id);
        }
       private Dictionary<string, object>GetData<T>(string spNamem, int Id) where T:class
        {
            return da.GetDictionaryFromClass(da.GetRecord<T>("sp_GetChestpain", Id) ?? (T)Activator.CreateInstance(typeof(T)));
        }
        public Dictionary<string, object> GetData(string secName, int Id)
        {
            var _ = new Dictionary<string, object>();
            switch (secName)
            {
               // case "Chestpain": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetChestpain_Result>("sp_GetChestpain", Id) ?? new sp_GetChestpain_Result()); break;
                case "Chestpain": _ = GetData<sp_GetChestpain_Result>("sp_GetCP_Master", Id); break;
                case "CP_Moa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Master_Result>("sp_GetCP_Master", Id) ?? new sp_GetCP_Master_Result()); break;
                case "CP_CoMor_RiskFactors": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_CoMor_RiskFactors_Result>("sp_GetCP_CoMor_RiskFactors", Id) ?? new sp_GetCP_CoMor_RiskFactors_Result()); break;
                case "CP_Complaints": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Complaints_Result>("sp_GetCP_Complaints", Id) ?? new sp_GetCP_Complaints_Result()); break;
                case "CP_Drug": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Drug_Result>("sp_GetCP_Drug", Id) ?? new sp_GetCP_Drug_Result()); break;
                case "CP_Ecg": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Ecg_Result>("sp_GetCP_Ecg", Id) ?? new sp_GetCP_Ecg_Result()); break;
                case "CP_Investgations": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Investgations_Result>("sp_GetCP_Investgations", Id) ?? new sp_GetCP_Investgations_Result()); break;
                case "CP_NonST": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_NonST_Result>("sp_GetCP_NonST", Id) ?? new sp_GetCP_NonST_Result()); break;
                case "CP_PhysicalExamination": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_PhysicalExamination_Result>("sp_GetCP_PhysicalExamination", Id) ?? new sp_GetCP_PhysicalExamination_Result()); break;
                case "CP_PrimeAssmnt_Airway": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_PrimeAssmnt_Airway_Result>("sp_GetCP_PrimeAssmnt_Airway", Id) ?? new sp_GetCP_PrimeAssmnt_Airway_Result()); break;
                case "CP_PrimeAssmnt_Breathing": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_PrimeAssmnt_Breathing_Result>("sp_GetCP_PrimeAssmnt_Breathing", Id) ?? new sp_GetCP_PrimeAssmnt_Breathing_Result()); break;
                case "CP_PrimeAssmnt_Cerculation": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_PrimeAssmnt_Cerculation_Result>("sp_GetCP_PrimeAssmnt_Cerculation", Id) ?? new sp_GetCP_PrimeAssmnt_Cerculation_Result()); break;
                case "CP_PrimeAssmnt_Disablty": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Disability_Result>("sp_GetCP_Disability", Id) ?? new sp_GetCP_Disability_Result()); break;
                case "CP_PrimeAssmnt_Expo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Exposure_Result>("sp_GetCP_Exposure", Id) ?? new sp_GetCP_Exposure_Result()); break;
                case "CP_ST": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_ST_Result>("sp_GetCP_ST", Id) ?? new sp_GetCP_ST_Result()); break;
                case "CP_STPharmPCI": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_STPharmPCI_Result>("sp_GetCP_STPharmPCI", Id) ?? new sp_GetCP_STPharmPCI_Result()); break;
                case "CP_Vitals": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Vitals_Result>("sp_GetCP_Vitals", Id) ?? new sp_GetCP_Vitals_Result()); break;
                //case "ST_DISP": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Vitals_Result>("sp_GetST_DISP", Id) ?? new sp_GetCP_Vitals_Result()); break;
                case "CP_DISP": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Disposition_Result>("sp_GetPoisoning_Disposition", Id) ?? new sp_GetPoisoning_Disposition_Result()); break;
                case "CP_INF": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetCP_Inference_Result>("sp_GetCP_Inference", Id) ?? new sp_GetCP_Inference_Result()); break;

                //stroke
                case "STRK_preHospt": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrokeMaster_Result>("sp_GetStrokeMaster", Id) ?? new sp_GetStrokeMaster_Result()); break;
                //case "STRK_emegRoom":_ = da.GetDictionaryFromClass(da.GetRecord<>("", Id) ?? new s()); break;
                case "STRK_vitalsOnArri": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Vitals_Result>("sp_GetStrk_Vitals", Id) ?? new sp_GetStrk_Vitals_Result()); break;
                case "STRK_psAirWay": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_PA_Airway_Result>("sp_GetStrk_PA_Airway", Id) ?? new sp_GetStrk_PA_Airway_Result()); break;
                case "STRK_psBreath": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_PA_Breathing_Result>("sp_GetStrk_PA_Breathing", Id) ?? new sp_GetStrk_PA_Breathing_Result()); break;
                case "STRK_psCirc": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_PA_Cerculation_Result>("sp_GetStrk_PA_Cerculation", Id) ?? new sp_GetStrk_PA_Cerculation_Result()); break;
                case "STRK_psDisab": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_PA_Disability_Result>("sp_GetStrk_PA_Disability", Id) ?? new sp_GetStrk_PA_Disability_Result()); break;
                case "STRK_psExpo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_PA_Exposure_Result>("sp_GetStrk_PA_Exposure", Id) ?? new sp_GetStrk_PA_Exposure_Result()); break;
                case "STRK_strkEval": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Evaluation_Result>("sp_GetStrk_Evaluation", Id) ?? new sp_GetStrk_Evaluation_Result()); break;
                case "STRK_strkTeam": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Team_Result>("sp_GetStrk_Team", Id) ?? new sp_GetStrk_Team_Result()); break;
                case "STRK_crMorbds": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Comorbids_Result>("sp_GetStrk_Comorbids", Id) ?? new sp_GetStrk_Comorbids_Result()); break;
                case "STRK_invesgt": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Investigations_Result>("sp_GetStrk_Investigations", Id) ?? new sp_GetStrk_Investigations_Result()); break;
                case "STRK_invesgtTimes": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Investigations_Times_Result>("sp_GetStrk_Investigations_Times", Id) ?? new sp_GetStrk_Investigations_Times_Result()); break;
                case "STRK_planCare": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_PlanOfCare_Result>("sp_GetStrk_PlanOfCare", Id) ?? new sp_GetStrk_PlanOfCare_Result()); break;
                case "STRK_strk_FibriList": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_FibrinolyticChkList_Result>("sp_GetStrk_FibrinolyticChkList", Id) ?? new sp_GetStrk_FibrinolyticChkList_Result()); break;
                case "STRK_strk_Port": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Protocol_Result>("sp_GetStrk_Protocol", Id) ?? new sp_GetStrk_Protocol_Result()); break;
                case "STRK_Strk_Dispo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Disposition_Result>("sp_GetStrk_Disposition", Id) ?? new sp_GetStrk_Disposition_Result()); break;
                case "STRK_vitalPop": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Vitals_Result>("sp_GetStrk_Vitals", Id) ?? new sp_GetStrk_Vitals_Result()); break;
                case "STRK_Drugs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_Drug_Result>("sp_GetStrk_Drug", Id) ?? new sp_GetStrk_Drug_Result()); break;
                case "STRK_DrugsER": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetStrk_DrugRecon_Result>("sp_GetStrk_DrugRecon", Id) ?? new sp_GetStrk_DrugRecon_Result()); break;

                //Abdomen
                case "AB_moa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomenMaster_Result>("sp_GetAbdomenMaster", Id) ?? new sp_GetAbdomenMaster_Result()); break;
                case "AB_PAAir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_PA_Airway_Result>("sp_GetAbdomen_PA_Airway", Id) ?? new sp_GetAbdomen_PA_Airway_Result()); break;
                case "AB_PABreat": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_PA_Breathing_Result>("sp_GetAbdomen_PA_Breathing", Id) ?? new sp_GetAbdomen_PA_Breathing_Result()); break;
                case "AB_PACir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_PA_Cerculation_Result>("sp_GetAbdomen_PA_Cerculation", Id) ?? new sp_GetAbdomen_PA_Cerculation_Result()); break;
                case "AB_VitalPop": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Vitals_Result>("sp_GetAbdomen_Vitals", Id) ?? new sp_GetAbdomen_Vitals_Result()); break;
                case "AB_PADisa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_PA_Disability_Result>("sp_GetAbdomen_PA_Disability", Id) ?? new sp_GetAbdomen_PA_Disability_Result()); break;
                case "AB_PAExpo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_PA_Exposure_Result>("sp_GetAbdomen_PA_Exposure", Id) ?? new sp_GetAbdomen_PA_Exposure_Result()); break;
                case "AB_PrCp": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_PresentCompl_Result>("sp_GetAbdomen_PresentCompl", Id) ?? new sp_GetAbdomen_PresentCompl_Result()); break;
                case "AB_Cmrbds": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Comorbids_Result>("sp_GetAbdomen_Comorbids", Id) ?? new sp_GetAbdomen_Comorbids_Result()); break;
                case "AB_ABIncid": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Incidents_Result>("sp_GetAbdomen_Incidents", Id) ?? new sp_GetAbdomen_Incidents_Result()); break;
                case "AB_Exams": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Examinations_Result>("sp_GetAbdomen_Examinations", Id) ?? new sp_GetAbdomen_Examinations_Result()); break;
                case "AB_Invs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Investigations_Result>("sp_GetAbdomen_Investigations", Id) ?? new sp_GetAbdomen_Investigations_Result()); break;
                case "AB_Refs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Referels_Result>("sp_GetAbdomen_Referels", Id) ?? new sp_GetAbdomen_Referels_Result()); break;
                case "AB_DISP": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Disposition_Result>("sp_GetAbdomen_Disposition", Id) ?? new sp_GetAbdomen_Disposition_Result()); break;
                case "AB_Drugs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_Drug_Result>("sp_GetAbdomen_Drug", Id) ?? new sp_GetAbdomen_Drug_Result()); break;
                case "AB_DrugsChrts": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetAbdomen_DrugRecon_Result>("sp_GetAbdomen_DrugRecon", Id) ?? new sp_GetAbdomen_DrugRecon_Result()); break;

                //GI
                case "GI_VitalsPop": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Vitals_Result>("sp_GetGI_Bleed_Vitals", Id) ?? new sp_GetGI_Bleed_Vitals_Result()); break;
                case "GI_PreHosp": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PreHospital_Result>("sp_GetGI_Bleed_PreHospital", Id) ?? new sp_GetGI_Bleed_PreHospital_Result()); break;
                case "GI_vitals2": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Vitals_Result>("sp_GetGI_Bleed_Vitals", Id) ?? new sp_GetGI_Bleed_Vitals_Result()); break;
                case "GI_PAAir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PA_Airway_Result>("sp_GetGI_Bleed_PA_Airway", Id) ?? new sp_GetGI_Bleed_PA_Airway_Result()); break;
                case "GI_PABreat": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PA_Breathing_Result>("sp_GetGI_Bleed_PA_Breathing", Id) ?? new sp_GetGI_Bleed_PA_Breathing_Result()); break;
                case "GI_PACir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PA_Cerculation_Result>("sp_GetGI_Bleed_PA_Cerculation", Id) ?? new sp_GetGI_Bleed_PA_Cerculation_Result()); break;
                case "GI_PADisa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PA_Disability_Result>("sp_GetGI_Bleed_PA_Disability", Id) ?? new sp_GetGI_Bleed_PA_Disability_Result()); break;
                case "GI_PAExpo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PA_Exposure_Result>("sp_GetGI_Bleed_PA_Exposure", Id) ?? new sp_GetGI_Bleed_PA_Exposure_Result()); break;
                case "GI_CFShock": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_PA_ClacificShock_Result>("sp_GetGI_Bleed_PA_ClacificShock", Id) ?? new sp_GetGI_Bleed_PA_ClacificShock_Result()); break;
                case "GI_PreCompl": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Complaints_Result>("sp_GetGI_Bleed_Complaints", Id) ?? new sp_GetGI_Bleed_Complaints_Result()); break;
                case "GI_Exams": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Examinations_Result>("sp_GetGI_Bleed_Examinations", Id) ?? new sp_GetGI_Bleed_Examinations_Result()); break;
                //case "GI_Intrven":_ = da.GetDictionaryFromClass(da.GetRecord<>("", Id) ?? new ()); break;
                case "GI_Cmrbds": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_AmpleHistory_Result>("sp_GetGI_Bleed_AmpleHistory", Id) ?? new sp_GetGI_Bleed_AmpleHistory_Result()); break;
                case "GI_RiskStrf": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_RiskStratification_Result>("sp_GetGI_Bleed_RiskStratification", Id) ?? new sp_GetGI_Bleed_RiskStratification_Result()); break;
                case "GI_Invesg": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Investigations_Result>("sp_GetGI_Bleed_Investigations", Id) ?? new sp_GetGI_Bleed_Investigations_Result()); break;
                case "GI_Refs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Referels_Result>("sp_GetGI_Bleed_Referels", Id) ?? new sp_GetGI_Bleed_Referels_Result()); break;
                case "GI_EndPlan": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Planning_Result>("sp_GetGI_Bleed_Planning", Id) ?? new sp_GetGI_Bleed_Planning_Result()); break;
                case "GI_Dispo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Disposition_Result>("sp_GetGI_Bleed_Disposition", Id) ?? new sp_GetGI_Bleed_Disposition_Result()); break;
                case "GI_Drugs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_Drug_Result>("sp_GetGI_Bleed_Drug", Id) ?? new sp_GetGI_Bleed_Drug_Result()); break;
                case "GI_DrugsChrts": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetGI_Bleed_DrugRecon_Result>("sp_GetGI_Bleed_DrugRecon", Id) ?? new sp_GetGI_Bleed_DrugRecon_Result()); break;

                //poision
                case "PO_VitalsPop": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Vitals_Result>("sp_GetPoisoning_Vitals", Id) ?? new sp_GetPoisoning_Vitals_Result()); break;
                case "PO_Moa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoningMaster_Result>("sp_GetPoisoningMaster", Id) ?? new sp_GetPoisoningMaster_Result()); break;
                case "PO_vitals": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Vitals_Result>("sp_GetPoisoning_Vitals", Id) ?? new sp_GetPoisoning_Vitals_Result()); break;
                case "PO_PAAir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_PA_Airway_Result>("sp_GetPoisoning_PA_Airway", Id) ?? new sp_GetPoisoning_PA_Airway_Result()); break;
                case "PO_PABreat": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_PA_Breathing_Result>("sp_GetPoisoning_PA_Breathing", Id) ?? new sp_GetPoisoning_PA_Breathing_Result()); break;
                case "PO_PACir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_PA_Cerculation_Result>("sp_GetPoisoning_PA_Cerculation", Id) ?? new sp_GetPoisoning_PA_Cerculation_Result()); break;
                case "PO_PADisa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_PA_Disability_Result>("sp_GetPoisoning_PA_Disability", Id) ?? new sp_GetPoisoning_PA_Disability_Result()); break;
                case "PO_PAExpo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_PA_Exposure_Result>("sp_GetPoisoning_PA_Exposure", Id) ?? new sp_GetPoisoning_PA_Exposure_Result()); break;
                case "PO_DetEvnt": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_EventDet_Result>("sp_GetPoisoning_EventDet", Id) ?? new sp_GetPoisoning_EventDet_Result()); break;
                case "PO_AmplHist": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_AmpleHistory_Result>("sp_GetPoisoning_AmpleHistory", Id) ?? new sp_GetPoisoning_AmpleHistory_Result()); break;
                case "PO_SupCare": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_SuppCare_Result>("sp_GetPoisoning_SuppCare", Id) ?? new sp_GetPoisoning_SuppCare_Result()); break;
                case "PO_PHExam": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Examinations_Result>("sp_GetPoisoning_Examinations", Id) ?? new sp_GetPoisoning_Examinations_Result()); break;
                case "PO_PoiCat": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisioning_Categoty_Result>("sp_GetPoisioning_Categoty", Id) ?? new sp_GetPoisioning_Categoty_Result()); break;
                case "PO_Inves": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Investigations_Result>("sp_GetPoisoning_Investigations", Id) ?? new sp_GetPoisoning_Investigations_Result()); break;
                case "PO_Dispo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Disposition_Result>("sp_GetPoisoning_Disposition", Id) ?? new sp_GetPoisoning_Disposition_Result()); break;
                case "PO_Drugs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_Drug_Result>("sp_GetPoisoning_Drug", Id) ?? new sp_GetPoisoning_Drug_Result()); break;
                case "PO_DrugsChrts": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetPoisoning_DrugRecon_Result>("sp_GetPoisoning_DrugRecon", Id) ?? new sp_GetPoisoning_DrugRecon_Result()); break;

                //trauma
                case "Trm_VitalsPop": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Vitals_Result>("sp_GetTrauma_Vitals", Id) ?? new sp_GetTrauma_Vitals_Result()); break;
                case "Trm_vitals": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Vitals_Result>("sp_GetTrauma_Vitals", Id) ?? new sp_GetTrauma_Vitals_Result()); break;
                case "Trm_PreHosp": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PreHospital_Result>("sp_GetTrauma_PreHospital", Id) ?? new sp_GetTrauma_PreHospital_Result()); break;
                case "Trm_TraIncid": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_IncidentDet_Result>("sp_GetTrauma_IncidentDet", Id) ?? new sp_GetTrauma_IncidentDet_Result()); break;
                case "Trm_PSAir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Airway_Result>("sp_GetTrauma_PA_Airway", Id) ?? new sp_GetTrauma_PA_Airway_Result()); break;
                case "Trm_PSBreat": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Breathing_Result>("sp_GetTrauma_PA_Breathing", Id) ?? new sp_GetTrauma_PA_Breathing_Result()); break;
                case "Trm_PSCir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Cerculation_Result>("sp_GetTrauma_PA_Cerculation", Id) ?? new sp_GetTrauma_PA_Cerculation_Result()); break;
                case "Trm_PSDisa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Disability_Result>("sp_GetTrauma_PA_Disability", Id) ?? new sp_GetTrauma_PA_Disability_Result()); break;
                case "Trm_PSExpo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Exposure_Result>("sp_GetTrauma_PA_Exposure", Id) ?? new sp_GetTrauma_PA_Exposure_Result()); break;
                case "Trm_SecServ": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_SecondSurvey_Result>("sp_GetTrauma_SecondSurvey", Id) ?? new sp_GetTrauma_SecondSurvey_Result()); break;
                case "Trm_AmplHist": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_AmpleHistory_Result>("sp_GetTrauma_AmpleHistory", Id) ?? new sp_GetTrauma_AmpleHistory_Result()); break;
                case "Trm_TraTm": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Team_Result>("sp_GetTrauma_Team", Id) ?? new sp_GetTrauma_Team_Result()); break;
                case "Trm_Inves": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Investigations_Result>("sp_GetTrauma_Investigations", Id) ?? new sp_GetTrauma_Investigations_Result()); break;
                case "Trm_Dispo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Disposition_Result>("sp_GetTrauma_Disposition", Id) ?? new sp_GetTrauma_Disposition_Result()); break;
                case "Trm_BldRec": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Blood_Result>("sp_GetTrauma_Blood", Id) ?? new sp_GetTrauma_Blood_Result()); break;
                case "Trm_Drugs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_Drug_Result>("sp_GetTrauma_Drug", Id) ?? new sp_GetTrauma_Drug_Result()); break;
                case "Trm_DrugsChrts": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_DrugRecon_Result>("sp_GetTrauma_DrugRecon", Id) ?? new sp_GetTrauma_DrugRecon_Result()); break;

                //seizures
                case "SZ_VitalsPop": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Vitals_Result>("sp_GetSeizures_Vitals", Id) ?? new sp_GetSeizures_Vitals_Result()); break;
                case "SZ_Moa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizuresMaster_Result>("sp_GetSeizuresMaster", Id) ?? new sp_GetSeizuresMaster_Result()); break;
                case "SZ_vitals": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Vitals_Result>("sp_GetSeizures_Vitals", Id) ?? new sp_GetSeizures_Vitals_Result()); break;
                case "SZ_ChSei": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Charecters_Result>("sp_GetSeizures_Charecters", Id) ?? new sp_GetSeizures_Charecters_Result()); break;
                case "SZ_PSAir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_PA_Airway_Result>("sp_GetSeizures_PA_Airway", Id) ?? new sp_GetSeizures_PA_Airway_Result()); break;
                case "SZ_PSBreat": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_PA_Breathing_Result>("sp_GetSeizures_PA_Breathing", Id) ?? new sp_GetSeizures_PA_Breathing_Result()); break;
                case "SZ_PSCir": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Cerculation_Result>("sp_GetTrauma_PA_Cerculation", Id) ?? new sp_GetTrauma_PA_Cerculation_Result()); break;
                case "SZ_PSDisa": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Disability_Result>("sp_GetTrauma_PA_Disability", Id) ?? new sp_GetTrauma_PA_Disability_Result()); break;
                case "SZ_PSExpo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetTrauma_PA_Exposure_Result>("sp_GetTrauma_PA_Exposure", Id) ?? new sp_GetTrauma_PA_Exposure_Result()); break;
                case "SZ_Exams": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Examinations_Result>("sp_GetSeizures_Examinations", Id) ?? new sp_GetSeizures_Examinations_Result()); break;
                case "SZ_Invs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Investigations_Result>("sp_GetSeizures_Investigations", Id) ?? new sp_GetSeizures_Investigations_Result()); break;
                case "SZ_Refs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Ref_Result>("sp_GetSeizures_Ref", Id) ?? new sp_GetSeizures_Ref_Result()); break;
                case "SZ_Dispo": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Disposition_Result>("sp_GetSeizures_Disposition", Id) ?? new sp_GetSeizures_Disposition_Result()); break;
                case "SZ_Drugs": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_Drug_Result>("sp_GetSeizures_Drug", Id) ?? new sp_GetSeizures_Drug_Result()); break;
                case "SZ_DrugsChrts": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetSeizures_DrugRecon_Result>("sp_GetSeizures_DrugRecon", Id) ?? new sp_GetSeizures_DrugRecon_Result()); break;
            }
            return _;
        }
        public bool SaveData(string secName, Dictionary<string, object> data)
        {
            try
            {
                var metadata = GetTableFrom(secName);
                switch (secName)
                {
                    case "Chestpain": da.TransactRecord(da.GetClassFromDictionary<sp_GetChestpain_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_Moa": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Master_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_CoMor_RiskFactors": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_CoMor_RiskFactors_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_Complaints": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Complaints_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_Drug": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Drug_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_Ecg": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Ecg_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_Investgations": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Investgations_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_NonST": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_NonST_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_PhysicalExamination": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_PhysicalExamination_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_PrimeAssmnt_Airway": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_PrimeAssmnt_Airway_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_PrimeAssmnt_Breathing": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_PrimeAssmnt_Breathing_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_PrimeAssmnt_Cerculation": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_PrimeAssmnt_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_PrimeAssmnt_Disablty": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Disability_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_PrimeAssmnt_Expo": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Exposure_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_ST": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_ST_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_STPharmPCI": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_STPharmPCI_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_Vitals": da.TransactRecord(da.GetClassFromDictionary<sp_GetCP_Vitals_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    //case "ST_DISP": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Disposition_Result>(data), metadata.TRANS, metadata.TYPE); break;
                    case "CP_DISP": da.TransactRecord(da.GetClassFromDictionary<sp_GetPoisoning_Disposition_Result>(data), metadata.TRANS, metadata.TYPE); break;


                    //stroke
                    case "STRK_preHospt": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrokeMaster_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    //case "STRK_emegRoom": da.TransactRecordWithId(da.GetClassFromDictionary<>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_vitalsOnArri": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_psAirWay": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_PA_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_psBreath": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_PA_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_psCirc": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_PA_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_psDisab": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_PA_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_psExpo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_PA_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_strkEval": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Evaluation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_strkTeam": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Team_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_crMorbds": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Comorbids_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_invesgt": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Investigations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_invesgtTimes": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Investigations_Times_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_planCare": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_PlanOfCare_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_strk_FibriList": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_FibrinolyticChkList_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_strk_Port": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Protocol_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_Strk_Dispo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_vitalPop": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_Drugs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "STRK_DrugsER": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetStrk_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;


                    //Abdomen
                    case "AB_moa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomenMaster_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_PAAir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_PA_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_PABreat": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_PA_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_PACir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_PA_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_VitalPop": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_PADisa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_PA_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_PAExpo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_PA_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_PrCp": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_PresentCompl_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_Cmrbds": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Comorbids_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_ABIncid": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Incidents_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_Exams": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Examinations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_Invs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Investigations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_Refs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Referels_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_DISP": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_Drugs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "AB_DrugsChrts": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetAbdomen_DrugRecon_Result>(data), metadata.TRANS, metadata.TYPE, false); break;

                    //GI
                    case "GI_VitalsPop": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PreHosp": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PreHospital_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_vitals2": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PAAir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PA_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PABreat": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PA_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PACir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PA_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PADisa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PA_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PAExpo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PA_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_CFShock": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_PA_ClacificShock_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_PreCompl": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Complaints_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_Exams": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Examinations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    //case "GI_Intrven": da.TransactRecordWithId(da.GetClassFromDictionary<>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_Cmrbds": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_AmpleHistory_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_RiskStrf": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_RiskStratification_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_Invesg": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Investigations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_Refs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Referels_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_EndPlan": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Planning_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_Dispo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_Drugs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "GI_DrugsChrts": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetGI_Bleed_DrugRecon_Result>(data), metadata.TRANS, metadata.TYPE, false); break;

                    //poision
                    case "PO_VitalsPop": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_Moa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoningMaster_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_vitals": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PAAir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_PA_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PABreat": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_PA_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PACir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_PA_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PADisa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_PA_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PAExpo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_PA_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_DetEvnt": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_EventDet_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_AmplHist": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_AmpleHistory_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_SupCare": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_SuppCare_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PHExam": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Examinations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_PoiCat": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisioning_Categoty_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_Inves": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Investigations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_Dispo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_Drugs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "PO_DrugsChrts": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_DrugRecon_Result>(data), metadata.TRANS, metadata.TYPE, false); break;

                    //trauma
                    case "Trm_VitalsPop": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_vitals": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_PreHosp": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_PreHospital_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_TraIncid": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_IncidentDet_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_PSAir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_PA_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_PSBreat": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_PA_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_PSCir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_PA_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_PSDisa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_PA_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_PSExpo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_PA_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_SecServ": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_SecondSurvey_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_AmplHist": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_AmpleHistory_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_TraTm": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Team_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_Inves": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Investigations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_Dispo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_BldRec": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Blood_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_Drugs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "Trm_DrugsChrts": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetTrauma_DrugRecon_Result>(data), metadata.TRANS, metadata.TYPE, false); break;

                    //seizures
                    case "SZ_VitalsPop": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_Moa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizuresMaster_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_vitals": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_ChSei": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Charecters_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_PSAir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_PA_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_PSBreat": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_PA_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_PSCir": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_PA_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_PSDisa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_PA_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_PSExpo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_PA_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_Exams": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Examinations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_Invs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Investigations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_Refs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Ref_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_Dispo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_Drugs": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "SZ_DrugsChrts": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetSeizures_DrugRecon_Result>(data), metadata.TRANS, metadata.TYPE, false); break;

                }
                return true;
            }
            catch (Exception e) { return false; }
        }

    }
}