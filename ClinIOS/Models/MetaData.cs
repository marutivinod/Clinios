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
                new TableForms(){FOMRID="CP_Complaints", GET="sp_GetCP_Complaints",TRANS="spInsertUpdateCP_Complaints",TYPE="CP_Complaints"}
                ,new TableForms(){FOMRID="CP_Moa", GET="sp_GetCP_Master",TRANS="spInsertUpdateCP_Master",TYPE="CP_Master"}
                ,new TableForms(){FOMRID="Chestpain" ,GET="sp_GetChestpain",TRANS="spInsertUpdateChestpain",TYPE="ChestPain"}
                ,new TableForms(){FOMRID="CP_CoMor_RiskFactors" ,GET="sp_GetCP_CoMor_RiskFactors",TRANS="spInsertUpdateCP_CoMor_RiskFactors",TYPE="CP_CoMor_RiskFactors"}
                ,new TableForms(){FOMRID="CP_Drug" ,GET="sp_GetCP_Drug",TRANS="spInsertUpdateCP_Drug",TYPE="CP_Drug"}
                ,new TableForms(){FOMRID="CP_Ecg" ,GET="sp_GetCP_Ecg",TRANS="spInsertUpdateCP_Ecg",TYPE="CP_Ecg"}
                ,new TableForms(){FOMRID="CP_Investgations" ,GET="sp_GetCP_Investgations",TRANS="spInsertUpdateCP_Investgations",TYPE="CP_Investgations"}
                ,new TableForms(){FOMRID="CP_NonST" ,GET="sp_GetCP_NonST",TRANS="spInsertUpdateCP_NonST",TYPE="CP_NonST"}
                ,new TableForms(){FOMRID="CP_PhysicalExamination" ,GET="sp_GetCP_PhysicalExamination",TRANS="spInsertUpdateCP_PhysicalExamination",TYPE="CP_PhysicalExamination"}
                ,new TableForms(){FOMRID="CP_PrimeAssmnt_Airway" ,GET="sp_GetCP_PrimeAssmnt_Airway",TRANS="spInsertUpdateCP_PrimeAssmnt_Airway",TYPE="CP_PrimeAssmnt_Airway"}
                ,new TableForms(){FOMRID="CP_PrimeAssmnt_Breathing" ,GET="sp_GetCP_PrimeAssmnt_Breathing",TRANS="spInsertUpdateCP_PrimeAssmnt_Breathing",TYPE="CP_PrimeAssmnt_Breathing"}
                ,new TableForms(){FOMRID="CP_PrimeAssmnt_Cerculation" ,GET="sp_GetCP_PrimeAssmnt_Cerculation",TRANS="spInsertUpdateCP_PrimeAssmnt_Cerculation",TYPE="CP_PrimeAssmnt_Cerculation"}
                ,new TableForms(){FOMRID="CP_PrimeAssmnt_Disablty" ,GET="sp_GetCP_Disability",TRANS="spInsertUpdateCP_PrimeAssmnt_Disability",TYPE="CP_PrimeAssmnt_Disability"}
                ,new TableForms(){FOMRID="CP_PrimeAssmnt_Expo" ,GET="sp_GetCP_Exposure",TRANS="spInsertUpdateCP_PrimeAssmnt_Exposure",TYPE="CP_PrimeAssmnt_Exposure"}
                ,new TableForms(){FOMRID="CP_ST" ,GET="sp_GetCP_ST",TRANS="spInsertUpdateCP_ST",TYPE="CP_ST"}
                ,new TableForms(){FOMRID="CP_STPharmPCI" ,GET="sp_GetCP_STPharmPCI",TRANS="spInsertUpdateCP_STPharmPCI",TYPE="CP_STPharmPCI"}
                ,new TableForms(){FOMRID="CP_Vitals" ,GET="sp_GetCP_Vitals",TRANS="spInsertUpdateCP_Vitals",TYPE="CP_Vitals"}
                ,new TableForms(){FOMRID="CP_DISP" ,GET="sp_GetCP_Disposition",TRANS="spInsertUpdateCP_Disposition",TYPE="CP_Disposition"}
               
                //stroke
                ,new TableForms(){FOMRID="STRK_preHospt" ,GET="sp_GetStrokeMaster",TRANS="spInsertUpdateStrokeMaster",TYPE="StrokeMaster"}
                //,new TableForms(){FOMRID="STRK_emegRoom" ,GET="",TRANS="",TYPE=""}
                ,new TableForms(){FOMRID="STRK_vitalsOnArri" ,GET="sp_GetStrk_Vitals",TRANS="spInsertUpdateStrk_Vitals",TYPE="Strk_Vitals"}
                ,new TableForms(){FOMRID="STRK_psAirWay" ,GET="sp_GetStrk_PA_Airway",TRANS="spInsertUpdateStrk_PA_Airway",TYPE="Strk_PA_Airway"}
                ,new TableForms(){FOMRID="STRK_psBreath" ,GET="sp_GetStrk_PA_Breathing",TRANS="spInsertUpdateStrk_PA_Breathing",TYPE="Strk_PA_Breathing"}
                ,new TableForms(){FOMRID="STRK_psCirc" ,GET="sp_GetStrk_PA_Cerculation",TRANS="spInsertUpdateStrk_PA_Cerculation",TYPE="Strk_PA_Cerculation"}
                ,new TableForms(){FOMRID="STRK_psDisab" ,GET="sp_GetStrk_PA_Disability",TRANS="spInsertUpdateStrk_PA_Disability",TYPE="Strk_PA_Disability"}
                ,new TableForms(){FOMRID="STRK_psExpo" ,GET="sp_GetStrk_PA_Exposure",TRANS="spInsertUpdateStrk_PA_Exposure",TYPE="Strk_PA_Exposure"}
                ,new TableForms(){FOMRID="STRK_strkEval" ,GET="sp_GetStrk_Evaluation",TRANS="spInsertUpdateStrk_Evaluation",TYPE="Strk_Evaluation"}
                ,new TableForms(){FOMRID="STRK_strkTeam" ,GET="sp_GetStrk_Team",TRANS="spInsertUpdateStrk_Team",TYPE="Strk_Team"}
                ,new TableForms(){FOMRID="STRK_crMorbds" ,GET="sp_GetStrk_Comorbids",TRANS="spInsertUpdateStrk_Comorbids",TYPE="Strk_Comorbids"}
                ,new TableForms(){FOMRID="STRK_invesgt" ,GET="sp_GetStrk_Investigations",TRANS="spInsertUpdateStrk_Investigations",TYPE="Strk_Investigations"}
                ,new TableForms(){FOMRID="STRK_invesgtTimes" ,GET="sp_GetStrk_Investigations_Times",TRANS="spInsertUpdateStrk_Investigations_Times",TYPE="Strk_Investigations_Times"}
                ,new TableForms(){FOMRID="STRK_planCare" ,GET="sp_GetStrk_PlanOfCare",TRANS="spInsertUpdateStrk_PlanOfCare",TYPE="Strk_PlanOfCare"}
                ,new TableForms(){FOMRID="STRK_strk_FibriList" ,GET="sp_GetStrk_FibrinolyticChkList",TRANS="spInsertUpdateStrk_FibrinolyticChkList",TYPE="Strk_FibrinolyticChkList"}
                ,new TableForms(){FOMRID="STRK_strk_Port" ,GET="sp_GetStrk_Protocol",TRANS="spInsertUpdateStrk_Protocol",TYPE="Strk_Protocol"}
                ,new TableForms(){FOMRID="STRK_Strk_Dispo" ,GET="sp_GetStrk_Disposition",TRANS="spInsertUpdateStrk_Disposition",TYPE="Strk_Disposition"}
                ,new TableForms(){FOMRID="STRK_vitalPop" ,GET="sp_GetStrk_Vitals",TRANS="spInsertUpdateStrk_Vitals",TYPE="Strk_Vitals"}
                ,new TableForms(){FOMRID="STRK_Drugs" ,GET="spInsertUpdateStrk_Drug",TRANS="spInsertUpdateTrauma_Drug",TYPE="Strk_Drug"}
                ,new TableForms(){FOMRID="STRK_DrugsER" ,GET="spInsertUpdateStrk_DrugRecon",TRANS="spInsertUpdateTrauma_DrugRecon",TYPE="Strk_DrugRecon"}


                //Abdomen
                ,new TableForms(){FOMRID="AB_moa" ,GET="sp_GetAbdomenMaster",TRANS="spInsertUpdateAbdomenMaster",TYPE="AbdomenMaster"}
                ,new TableForms(){FOMRID="AB_PAAir" ,GET="sp_GetAbdomen_PA_Airway",TRANS="spInsertUpdateAbdomen_PA_Airway",TYPE="Abdomen_PA_Airway"}
                ,new TableForms(){FOMRID="AB_PABreat" ,GET="sp_GetAbdomen_PA_Breathing",TRANS="spInsertUpdateAbdomen_PA_Breathing",TYPE="Abdomen_PA_Breathing"}
                ,new TableForms(){FOMRID="AB_PACir" ,GET="sp_GetAbdomen_PA_Cerculation",TRANS="spInsertUpdateAbdomen_PA_Cerculation",TYPE="Abdomen_PA_Cerculation"}
                ,new TableForms(){FOMRID="AB_VitalPop" ,GET="sp_GetAbdomen_Vitals",TRANS="spInsertUpdateAbdomen_Vitals",TYPE="Abdomen_Vitals"}
                ,new TableForms(){FOMRID="AB_PADisa" ,GET="sp_GetAbdomen_PA_Disability",TRANS="spInsertUpdateAbdomen_PA_Disability",TYPE="Abdomen_PA_Disability"}
                ,new TableForms(){FOMRID="AB_PAExpo" ,GET="sp_GetAbdomen_PA_Exposure",TRANS="spInsertUpdateAbdomen_PA_Exposure",TYPE="Abdomen_PA_Exposure"}
                ,new TableForms(){FOMRID="AB_PrCp" ,GET="sp_GetAbdomen_PresentCompl",TRANS="spInsertUpdateAbdomen_PresentCompl",TYPE="Abdomen_PresentCompl"}
                ,new TableForms(){FOMRID="AB_Cmrbds" ,GET="sp_GetAbdomen_Comorbids",TRANS="spInsertUpdateAbdomen_Comorbids",TYPE="Abdomen_Comorbids"}
                ,new TableForms(){FOMRID="AB_ABIncid" ,GET="sp_GetAbdomen_Incidents",TRANS="spInsertUpdateAbdomen_Incidents",TYPE="Abdomen_Incidents"}
                ,new TableForms(){FOMRID="AB_Exams" ,GET="sp_GetAbdomen_Examinations",TRANS="spInsertUpdateAbdomen_Examinations",TYPE="Abdomen_Examinations"}
                ,new TableForms(){FOMRID="AB_Invs" ,GET="sp_GetAbdomen_Investigations",TRANS="spInsertUpdateAbdomen_Investigations",TYPE="Abdomen_Investigations"}
                ,new TableForms(){FOMRID="AB_Refs" ,GET="sp_GetAbdomen_Referels",TRANS="spInsertUpdateAbdomen_Referels",TYPE="Abdomen_Referels"}
                ,new TableForms(){FOMRID="AB_DISP" ,GET="sp_GetAbdomen_Disposition",TRANS="spInsertUpdateAbdomen_Disposition",TYPE="Abdomen_Disposition"}
                ,new TableForms(){FOMRID="AB_Drugs" ,GET="sp_GetAbdomen_Drug",TRANS="spInsertUpdateAbdomen_Drug",TYPE="Abdomen_Drug"}
                ,new TableForms(){FOMRID="AB_DrugsChrts" ,GET="sp_GetAbdomen_DrugRecon",TRANS="spInsertUpdateAbdomen_DrugRecon",TYPE="Abdomen_DrugRecon"}

                //GI
                ,new TableForms(){FOMRID="GI_VitalsPop" ,GET="sp_GetGI_Bleed_Vitals",TRANS="spInsertUpdateGI_Bleed_Vitals",TYPE="GI_Bleed_Vitals"}
                ,new TableForms(){FOMRID="GI_PreHosp" ,GET="sp_GetGI_Bleed_PreHospital",TRANS="spInsertUpdateGI_Bleed_PreHospital",TYPE="GI_Bleed_PreHospital"}
                ,new TableForms(){FOMRID="GI_vitals2" ,GET="sp_GetGI_Bleed_Vitals",TRANS="spInsertUpdateGI_Bleed_Vitals",TYPE="GI_Bleed_Vitals"}
                ,new TableForms(){FOMRID="GI_PAAir" ,GET="sp_GetGI_Bleed_PA_Airway",TRANS="spInsertUpdateGI_Bleed_PA_Airway",TYPE="GI_Bleed_PA_Airway"}
                ,new TableForms(){FOMRID="GI_PABreat" ,GET="sp_GetGI_Bleed_PA_Breathing",TRANS="spInsertUpdateGI_Bleed_PA_Breathing",TYPE="GI_Bleed_PA_Breathing"}
                ,new TableForms(){FOMRID="GI_PACir" ,GET="sp_GetGI_Bleed_PA_Cerculation",TRANS="spInsertUpdateGI_Bleed_PA_Cerculation",TYPE="GI_Bleed_PA_Cerculation"}
                ,new TableForms(){FOMRID="GI_PADisa" ,GET="sp_GetGI_Bleed_PA_Disability",TRANS="spInsertUpdateGI_Bleed_PA_Disability",TYPE="GI_Bleed_PA_Disability"}
                ,new TableForms(){FOMRID="GI_PAExpo" ,GET="sp_GetGI_Bleed_PA_Exposure",TRANS="spInsertUpdateGI_Bleed_PA_Exposure",TYPE="GI_Bleed_PA_Exposure"}
                ,new TableForms(){FOMRID="GI_CFShock" ,GET="sp_GetGI_Bleed_PA_ClacificShock",TRANS="spInsertUpdateGI_Bleed_PA_ClacificShock",TYPE="GI_Bleed_PA_ClacificShock"}
                ,new TableForms(){FOMRID="GI_PreCompl" ,GET="sp_GetGI_Bleed_Complaints",TRANS="spInsertUpdateGI_Bleed_Complaints",TYPE="GI_Bleed_Complaints"}
                ,new TableForms(){FOMRID="GI_Exams" ,GET="sp_GetGI_Bleed_Examinations",TRANS="spInsertUpdateGI_Bleed_Examinations",TYPE="GI_Bleed_Examinations"}
                //,new TableForms(){FOMRID="GI_Intrven" ,GET="",TRANS="",TYPE=""}
                ,new TableForms(){FOMRID="GI_Cmrbds" ,GET="sp_GetGI_Bleed_AmpleHistory",TRANS="spInsertUpdateGI_Bleed_AmpleHistory",TYPE="GI_Bleed_AmpleHistory"}
                ,new TableForms(){FOMRID="GI_RiskStrf" ,GET="sp_GetGI_Bleed_RiskStratification",TRANS="spInsertUpdateGI_Bleed_RiskStratification",TYPE="GI_Bleed_RiskStratification"}
                ,new TableForms(){FOMRID="GI_Invesg" ,GET="sp_GetGI_Bleed_Investigations",TRANS="spInsertUpdateGI_Bleed_Investigations",TYPE="GI_Bleed_Investigations"}
                ,new TableForms(){FOMRID="GI_Refs" ,GET="sp_GetGI_Bleed_Referels",TRANS="spInsertUpdateGI_Bleed_Referels",TYPE="GI_Bleed_Referels"}
                ,new TableForms(){FOMRID="GI_EndPlan" ,GET="sp_GetGI_Bleed_Planning",TRANS="spInsertUpdateGI_Bleed_Planning",TYPE="GI_Bleed_Planning"}
                ,new TableForms(){FOMRID="GI_Dispo" ,GET="sp_GetGI_Bleed_Disposition",TRANS="spInsertUpdateGI_Bleed_Disposition",TYPE="GI_Bleed_Disposition"}
                ,new TableForms(){FOMRID="GI_Drugs" ,GET="sp_GetGI_Bleed_Drug",TRANS="spInsertUpdateGI_Bleed_Drug",TYPE="GI_Bleed_Drug"}
                ,new TableForms(){FOMRID="GI_DrugsChrts" ,GET="sp_GetGI_Bleed_DrugRecon",TRANS="spInsertUpdateGI_Bleed_DrugRecon",TYPE="GI_Bleed_DrugRecon"}

                //poision
                ,new TableForms(){FOMRID="PO_VitalsPop" ,GET="sp_GetPoisoning_Vitals",TRANS="spInsertUpdatePoisoning_Vitals",TYPE="Poisoning_Vitals"}
                ,new TableForms(){FOMRID="PO_Moa" ,GET="sp_GetPoisoningMaster",TRANS="spInsertUpdatePoisoningMaster",TYPE="PoisoningMaster"}
                ,new TableForms(){FOMRID="PO_vitals" ,GET="sp_GetPoisoning_Vitals",TRANS="spInsertUpdatePoisoning_Vitals",TYPE="Poisoning_Vitals"}
                ,new TableForms(){FOMRID="PO_PAAir" ,GET="sp_GetPoisoning_PA_Airway",TRANS="spInsertUpdatePoisoning_PA_Airway",TYPE="Poisoning_PA_Airway"}
                ,new TableForms(){FOMRID="PO_PABreat" ,GET="sp_GetPoisoning_PA_Breathing",TRANS="spInsertUpdatePoisoning_PA_Breathing",TYPE="Poisoning_PA_Breathing"}
                ,new TableForms(){FOMRID="PO_PACir" ,GET="sp_GetPoisoning_PA_Cerculation",TRANS="spInsertUpdatePoisoning_PA_Cerculation",TYPE="Poisoning_PA_Cerculation"}
                ,new TableForms(){FOMRID="PO_PADisa" ,GET="sp_GetPoisoning_PA_Disability",TRANS="spInsertUpdatePoisoning_PA_Disability",TYPE="Poisoning_PA_Disability"}
                ,new TableForms(){FOMRID="PO_PAExpo" ,GET="sp_GetPoisoning_PA_Exposure",TRANS="spInsertUpdatePoisoning_PA_Exposure",TYPE="Poisoning_PA_Exposure"}
                ,new TableForms(){FOMRID="PO_DetEvnt" ,GET="sp_GetPoisoning_EventDet",TRANS="spInsertUpdatePoisoning_EventDet",TYPE="Poisoning_EventDet"}
                ,new TableForms(){FOMRID="PO_AmplHist" ,GET="sp_GetPoisoning_AmpleHistory",TRANS="spInsertUpdatePoisoning_AmpleHistory",TYPE="Poisoning_AmpleHistory"}
                ,new TableForms(){FOMRID="PO_SupCare" ,GET="sp_GetPoisoning_SuppCare",TRANS="spInsertUpdatePoisoning_SuppCare",TYPE="Poisoning_SuppCare"}
                ,new TableForms(){FOMRID="PO_PHExam" ,GET="sp_GetPoisoning_Examinations",TRANS="spInsertUpdatePoisoning_Examinations",TYPE="Poisoning_Examinations"}
                ,new TableForms(){FOMRID="PO_PoiCat" ,GET="sp_GetPoisioning_Categoty",TRANS="spInsertUpdatePoisioning_Categoty",TYPE="Poisioning_Categoty"}
                ,new TableForms(){FOMRID="PO_Inves" ,GET="sp_GetPoisoning_Investigations",TRANS="spInsertUpdatePoisoning_Investigations",TYPE="Poisoning_Investigations"}
                ,new TableForms(){FOMRID="PO_Dispo" ,GET="sp_GetPoisoning_Disposition",TRANS="spInsertUpdatePoisoning_Disposition",TYPE="Poisoning_Disposition"}
                ,new TableForms(){FOMRID="PO_Drugs" ,GET="sp_GetPoisoning_Drug",TRANS="spInsertUpdatePoisoning_Drug",TYPE="Poisoning_Drug"}
                ,new TableForms(){FOMRID="PO_DrugsChrts" ,GET="sp_GetPoisoning_DrugRecon",TRANS="spInsertUpdatePoisoning_DrugRecon",TYPE="Poisoning_DrugRecon"}

                //trauma
                ,new TableForms(){FOMRID="Trm_VitalsPop" ,GET="sp_GetTrauma_Vitals",TRANS="spInsertUpdateTrauma_Vitals",TYPE="Trauma_Vitals"}
                ,new TableForms(){FOMRID="Trm_vitals" ,GET="sp_GetTrauma_Vitals",TRANS="spInsertUpdateTrauma_Vitals",TYPE="Trauma_Vitals"}
                ,new TableForms(){FOMRID="Trm_PreHosp" ,GET="sp_GetTrauma_PreHospital",TRANS="spInsertUpdateTrauma_PreHospital",TYPE="Trauma_PreHospital"}
                ,new TableForms(){FOMRID="Trm_TraIncid" ,GET="sp_GetTrauma_IncidentDet",TRANS="spInsertUpdateTrauma_IncidentDet",TYPE="Trauma_IncidentDet"}
                ,new TableForms(){FOMRID="Trm_PSAir" ,GET="sp_GetTrauma_PA_Airway",TRANS="spInsertUpdateTrauma_PA_Airway",TYPE="Trauma_PA_Airway"}
                ,new TableForms(){FOMRID="Trm_PSBreat" ,GET="sp_GetTrauma_PA_Breathing",TRANS="spInsertUpdateTrauma_PA_Breathing",TYPE="Trauma_PA_Breathing"}
                ,new TableForms(){FOMRID="Trm_PSCir" ,GET="sp_GetTrauma_PA_Cerculation",TRANS="spInsertUpdateTrauma_PA_Cerculation",TYPE="Trauma_PA_Cerculation"}
                ,new TableForms(){FOMRID="Trm_PSDisa" ,GET="sp_GetTrauma_PA_Disability",TRANS="spInsertUpdateTrauma_PA_Disability",TYPE="Trauma_PA_Disability"}
                ,new TableForms(){FOMRID="Trm_PSExpo" ,GET="sp_GetTrauma_PA_Exposure",TRANS="spInsertUpdateTrauma_PA_Exposure",TYPE="Trauma_PA_Exposure"}
                ,new TableForms(){FOMRID="Trm_SecServ" ,GET="sp_GetTrauma_SecondSurvey",TRANS="spInsertUpdateTrauma_SecondSurvey",TYPE="Trauma_SecondSurvey"}
                ,new TableForms(){FOMRID="Trm_AmplHist" ,GET="sp_GetTrauma_AmpleHistory",TRANS="spInsertUpdateTrauma_AmpleHistory",TYPE="Trauma_AmpleHistory"}
                ,new TableForms(){FOMRID="Trm_TraTm" ,GET="sp_GetTrauma_Team",TRANS="spInsertUpdateTrauma_Team",TYPE="Trauma_Team"}
                ,new TableForms(){FOMRID="Trm_Inves" ,GET="sp_GetTrauma_Investigations",TRANS="spInsertUpdateTrauma_Investigations",TYPE="Trauma_Investigations"}
                ,new TableForms(){FOMRID="Trm_Dispo" ,GET="sp_GetTrauma_Disposition",TRANS="spInsertUpdateTrauma_Disposition",TYPE="Trauma_Disposition"}
                ,new TableForms(){FOMRID="Trm_BldRec" ,GET="sp_GetTrauma_Blood",TRANS="spInsertUpdateTrauma_Blood",TYPE="Trauma_Blood"}
                ,new TableForms(){FOMRID="Trm_Drugs" ,GET="sp_GetTrauma_Drug",TRANS="spInsertUpdateTrauma_Drug",TYPE="Trauma_Drug"}
                ,new TableForms(){FOMRID="Trm_DrugsChrts" ,GET="sp_GetTrauma_DrugRecon",TRANS="spInsertUpdateTrauma_DrugRecon",TYPE="Trauma_DrugRecon"}

                //seizures
                ,new TableForms(){FOMRID="SZ_VitalsPop" ,GET="sp_GetSeizures_Vitals",TRANS="spInsertUpdateSeizures_Vitals",TYPE="Seizures_Vitals"}
                ,new TableForms(){FOMRID="SZ_Moa" ,GET="sp_GetSeizuresMaster",TRANS="spInsertUpdateSeizuresMaster",TYPE="SeizuresMaster"}
                ,new TableForms(){FOMRID="SZ_vitals" ,GET="sp_GetSeizures_Vitals",TRANS="spInsertUpdateSeizures_Vitals",TYPE="Seizures_Vitals"}
                ,new TableForms(){FOMRID="SZ_ChSei" ,GET="sp_GetSeizures_Charecters",TRANS="spInsertUpdateSeizures_Charecters",TYPE="Seizures_Charecters"}
                ,new TableForms(){FOMRID="SZ_PSAir" ,GET="sp_GetSeizures_PA_Airway",TRANS="spInsertUpdateSeizures_PA_Airway",TYPE="Seizures_PA_Airway"}
                ,new TableForms(){FOMRID="SZ_PSBreat" ,GET="sp_GetSeizures_PA_Breathing",TRANS="spInsertUpdateSeizures_PA_Breathing",TYPE="Seizures_PA_Breathing"}
                ,new TableForms(){FOMRID="SZ_PSCir" ,GET="sp_GetSeizures_PA_Cerculation",TRANS="spInsertUpdateSeizures_PA_Cerculation",TYPE="Seizures_PA_Cerculation"}
                ,new TableForms(){FOMRID="SZ_PSDisa" ,GET="sp_GetSeizures_PA_Disability",TRANS="spInsertUpdateSeizures_PA_Disability",TYPE="Seizures_PA_Disability"}
                ,new TableForms(){FOMRID="SZ_PSExpo" ,GET="sp_GetSeizures_PA_Exposure",TRANS="spInsertUpdateSeizures_PA_Exposure",TYPE="Seizures_PA_Exposure"}
                ,new TableForms(){FOMRID="SZ_Exams" ,GET="sp_GetSeizures_Examinations",TRANS="spInsertUpdateSeizures_Examinations",TYPE="Seizures_Examinations"}
                ,new TableForms(){FOMRID="SZ_Invs" ,GET="sp_GetSeizures_Investigations",TRANS="spInsertUpdateSeizures_Investigations",TYPE="Seizures_Investigations"}
                ,new TableForms(){FOMRID="SZ_Refs" ,GET="sp_GetSeizures_Ref",TRANS="spInsertUpdateSeizures_Ref",TYPE="Seizures_Ref"}
                ,new TableForms(){FOMRID="SZ_Dispo" ,GET="sp_GetSeizures_Disposition",TRANS="spInsertUpdateSeizures_Disposition",TYPE="Seizures_Disposition"}
                ,new TableForms(){FOMRID="SZ_Drugs" ,GET="sp_GetSeizures_Drug",TRANS="spInsertUpdateSeizures_Drug",TYPE="Seizures_Drug"}
                ,new TableForms(){FOMRID="SZ_DrugsChrts" ,GET="sp_GetSeizures_DrugRecon",TRANS="spInsertUpdateSeizures_DrugRecon",TYPE="Seizures_DrugRecon"}

            };
        }
        private TableForms GetTableFrom(string id)
        {
            return Froms().SingleOrDefault(x => x.FOMRID == id);
        }

        public Dictionary<string, object> GetData(string secName, int Id)
        {
            var _ = new Dictionary<string, object>();
            switch (secName)
            {
                case "Chestpain": _ = da.GetDictionaryFromClass(da.GetRecord<sp_GetChestpain_Result>("sp_GetChestpain", Id) ?? new sp_GetChestpain_Result()); break;
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
                    case "Chestpain": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetChestpain_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_Moa": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Master_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_CoMor_RiskFactors": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_CoMor_RiskFactors_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_Complaints": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Complaints_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_Drug": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Drug_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_Ecg": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Ecg_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_Investgations": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Investgations_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_NonST": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_NonST_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_PhysicalExamination": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_PhysicalExamination_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_PrimeAssmnt_Airway": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_PrimeAssmnt_Airway_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_PrimeAssmnt_Breathing": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_PrimeAssmnt_Breathing_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_PrimeAssmnt_Cerculation": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_PrimeAssmnt_Cerculation_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_PrimeAssmnt_Disablty": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Disability_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_PrimeAssmnt_Expo": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Exposure_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_ST": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_ST_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_STPharmPCI": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_STPharmPCI_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_Vitals": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetCP_Vitals_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    //case "ST_DISP": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;
                    case "CP_DISP": da.TransactRecordWithId(da.GetClassFromDictionary<sp_GetPoisoning_Disposition_Result>(data), metadata.TRANS, metadata.TYPE, false); break;


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