﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities
{
    public class PolicyDetailByInsuredData
    {
		public decimal SEQUENCE { get; set; }
		public string COMPANY_NAME { get; set; }
		public string MEMBER_STATUS { get; set; }
		public string TITLE { get; set; }
		public string NAME_THAI { get; set; }
		public string SURNAME_THAI { get; set; }
		public string NAME_ENG { get; set; }
		public string SURNAME_ENG { get; set; }
		public string GENDER { get; set; }
		public string MARITAL_STATUS { get; set; }
		public string NATIONALITY { get; set; }
		public string MEMBER_TYPE { get; set; }
		public string PRINCIPLE_REFERENCE_NUMBER { get; set; }
		public string PRINCIPLE_REFERENCE_FIELD_NAME { get; set; }
		public string CITIZEN_ID { get; set; }
		public string OTHER_ID { get; set; }
		public DateTime DATE_OF_BIRTH { get; set; }
		public string AGE { get; set; }
		public string BUILDING_NO { get; set; }
		public string VILLAGE_NO { get; set; }
		public string LANE_ALLEY { get; set; }
		public string ROAD { get; set; }
		public string SUB_DISTRICT { get; set; }
		public string DISTRICT { get; set; }
		public string PROVINCE { get; set; }
		public string POST_CODE { get; set; }
		public string COUNTRY { get; set; }
		public string CONTACT_PERSON_NAME { get; set; }
		public string OFFICE_TEL_NO { get; set; }
		public string HOME_TEL_NO { get; set; }
		public string MOBILE_NO { get; set; }
		public string EMAIL { get; set; }
		public string FAX_NO { get; set; }
		public string STAFF_NO { get; set; }
		public DateTime JOIN_DATE { get; set; }
		public DateTime EMPLOYMENT_DATE { get; set; }
		public string APPLICATION_NUMBER { get; set; }
		public string POLICY_NUMBER { get; set; }
		public string Previous_POLICY_NUMBER { get; set; }
		public decimal POLICY_YEAR { get; set; }
		public DateTime POLICY_ISSUE_Date { get; set; }
		public DateTime POLICY_EXPIRED_DATE { get; set; }
		public string POLICY_STATUS { get; set; }
		public DateTime RENEWAL_DATE { get; set; }
		public string CERTIFICATE_NO { get; set; }
		public string INSURER_CARD_NO {get; set;}
		public string INSURER_PREVIOUS_CARD_NO { get; set; }
		public DateTime Member_Terminate_Date { get; set; }
		public DateTime Member_Reinstatement_Date { get; set; }
		public DateTime Member_Suspension_Date { get; set; }
		public DateTime Member_Suspension_To_Date { get; set; }
		public string PLAN { get; set; }
		public DateTime PLAN_ISSUE_DATE { get; set; }
		public DateTime PLAN_CONTRACT_DATE { get; set; }
		public DateTime PLAN_EFFECTIVE_FROM_DATE { get; set; }
		public DateTime PLAN_EFFECTIVE_TO_DATE { get; set; }
		public DateTime PLAN_PAID_DATE { get; set; }
		public DateTime PLAN_Paid_to_date { get; set; }
		public DateTime PLAN_Next_Due_Date { get; set; }
		public string PLAN_Status { get; set; }
		public string PLAN_RIDER { get; set; }
		public DateTime RIDER_ISSUE_DATE { get; set; }
		public DateTime RIDER_CONTRACT_DATE { get; set; }
		public DateTime RIDER_EFFECTIVE_FROM_DATE { get; set; }
		public DateTime RIDER_EFFECTIVE_TO_DATE { get; set; }
		public DateTime RIDER_Terminate_Date { get; set; }
		public DateTime RIDER_Reinstatement_Date { get; set; }
		public DateTime Rider_Suspension_Date { get; set; }
		public DateTime RIDER_PAID_DATE { get; set; }
		public DateTime RIDER_Paid_to_date { get; set; }
		public DateTime RIDER_Next_Due_Date { get; set; }
		public string RIDER_Status { get; set; }
		public DateTime LIFE_CONTRACT_DATE { get; set; }
		public DateTime VALIDITY_DATE { get; set; }
		public string CONDITION_DETAIL { get; set; }
		public string PREMIUM_FREQUENCY { get; set; }
		public decimal MEMBER_PREMIUM { get; set; }
		public decimal PREMIUM_IPD { get; set; }
		public decimal PREMIUM_OPD { get; set; }
		public decimal Sum_Insured { get; set; }
		public string SOCIAL_SECURITY_HOSPITAL { get; set; }
		public string BANK { get; set; }
		public string BANK_ACCOUNT_NO { get; set; }
		public string PAYEE_NAME { get; set; }
		public string Payee_Citizen_ID { get; set; }
		public string BU { get; set; }
		public string BRANCH { get; set; }
		public string COST_CENTER { get; set; }
		public string AGENT_CODE { get; set; }
		public string AGENT_LEADER_CODE { get; set; }
		public string REMARK_1 { get; set; }
		public string REMARK_2 { get; set; }
		public string REMARK_3 { get; set; }
		public string REMARK_4 { get; set; }
		public string REMARK_5 { get; set; }
		public string REMARK_6 { get; set; }
		public string REMARK_7 { get; set; }
		public string REMARK_8 { get; set; }
		public string REMARK_9 { get; set; }
		public string REMARK_10 { get; set; }
		public string Insurer_Action_Type { get; set; }
		public DateTime Insurer_Update_Date { get; set; }
		public DateTime Cancel_Date { get; set; }
		public string PATTERN_CODE { get; set; }
		public string Sponsor { get; set; }
		public string Reason { get; set; }
		public string VIP { get; set; }
		public string Broker { get; set; }
		public string CustomerGroup { get; set; }
		public string VDBNO { get; set; }
		public DateTime Insurer_Export_Date { get; set; }
		public string Sub_Sales_Chanel { get; set; }
		public string ENDORSE_NO { get; set; }
		public string END_TYPE { get; set; }
		public string FLEET_SEQ { get; set; }
		public string FAM_SEQ { get; set; }
		public string SUB_SEQ { get; set; }
		public string UNIQUE_NO { get; set; }
		public string STS_FLAG { get; set; }
		public string CANCEL_FLAG { get; set; }
		public string Product_Code { get; set; }
		public string Product_Type { get; set; }
		public string Coverage_Option { get; set; }
		public string Progressive_Code { get; set; }
		public string Coverage_Status { get; set; }
		public DateTime Date_of_Birth_Payer { get; set; }
		public string Gender_Payer { get; set; }
		public string Address1_Payer { get; set; }
		public string Address2_Payer { get; set; }
		public string Address3_Payer { get; set; }
		public string Address4_Payer { get; set; }
		public string Address5_Payer { get; set; }
		public string Address6_Payer { get; set; }
		public string Campaign_code { get; set; }
		public string Product_code_type { get; set; }
		public string Rate_Scale { get; set; }
		public string Coverage_Code { get; set; }
		public string CVR { get; set; }
		public string Claim_Type { get; set; }
		public string Payment_Status { get; set; }
		public string Member_Code { get; set; }
		public string TransType { get; set; }
		public string Old_Member_Code { get; set; }
		public string Card_Type { get; set; }
		public string Preferred_Language { get; set; }
	}
}
