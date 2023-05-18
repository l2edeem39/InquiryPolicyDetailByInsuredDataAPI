using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities
{
    public class PolicyDetailByInsuredData
    {
		[JsonPropertyName("SEQUENCE")]
		public decimal SEQUENCE { get; set; }
		[JsonPropertyName("COMPANY NAME")]
		public string COMPANY_NAME { get; set; }
		[JsonPropertyName("MEMBER STATUS")]
		public string MEMBER_STATUS { get; set; }
		[JsonPropertyName("TITLE")]
		public string TITLE { get; set; }
		[JsonPropertyName("NAME THAI")]
		public string NAME_THAI { get; set; }
		[JsonPropertyName("SURNAME THAI")]
		public string SURNAME_THAI { get; set; }
		[JsonPropertyName("NAME ENG")]
		public string NAME_ENG { get; set; }
		[JsonPropertyName("SURNAME ENG")]
		public string SURNAME_ENG { get; set; }
		[JsonPropertyName("GENDER")]
		public string GENDER { get; set; }
		[JsonPropertyName("MARITAL STATUS")]
		public string MARITAL_STATUS { get; set; }
		[JsonPropertyName("NATIONALITY")]
		public string NATIONALITY { get; set; }
		[JsonPropertyName("MEMBER TYPE")]
		public string MEMBER_TYPE { get; set; }
		[JsonPropertyName("PRINCIPLE REFERENCE NUMBER")]
		public string PRINCIPLE_REFERENCE_NUMBER { get; set; }
		[JsonPropertyName("PRINCIPLE REFERENCE FIELD NAME")]
		public string PRINCIPLE_REFERENCE_FIELD_NAME { get; set; }
		[JsonPropertyName("CITIZEN ID")]
		public string CITIZEN_ID { get; set; }
		[JsonPropertyName("OTHER ID")]
		public string OTHER_ID { get; set; }
		[JsonPropertyName("DATE OF BIRTH")]
		public string DATE_OF_BIRTH { get; set; }
		[JsonPropertyName("AGE")]
		public decimal AGE { get; set; }
		[JsonPropertyName("BUILDING NO")]
		public string BUILDING_NO { get; set; }
		[JsonPropertyName("VILLAGE NO")]
		public string VILLAGE_NO { get; set; }
		[JsonPropertyName("LANE ALLEY")]
		public string LANE_ALLEY { get; set; }
		[JsonPropertyName("ROAD")]
		public string ROAD { get; set; }
		[JsonPropertyName("SUB DISTRICT")]
		public string SUB_DISTRICT { get; set; }
		[JsonPropertyName("DISTRICT")]
		public string DISTRICT { get; set; }
		[JsonPropertyName("PROVINCE")]
		public string PROVINCE { get; set; }
		[JsonPropertyName("POST CODE")]
		public string POST_CODE { get; set; }
		[JsonPropertyName("COUNTRY")]
		public string COUNTRY { get; set; }
		[JsonPropertyName("CONTACT PERSON NAME")]
		public string CONTACT_PERSON_NAME { get; set; }
		[JsonPropertyName("OFFICE TEL NO")]
		public string OFFICE_TEL_NO { get; set; }
		[JsonPropertyName("HOME TEL NO")]
		public string HOME_TEL_NO { get; set; }
		[JsonPropertyName("MOBILE NO")]
		public string MOBILE_NO { get; set; }
		[JsonPropertyName("EMAIL")]
		public string EMAIL { get; set; }
		[JsonPropertyName("FAX NO")]
		public string FAX_NO { get; set; }
		[JsonPropertyName("STAFF NO")]
		public string STAFF_NO { get; set; }
		[JsonPropertyName("JOIN DATE")]
		public string JOIN_DATE { get; set; }
		[JsonPropertyName("EMPLOYMENT DATE")]
		public string EMPLOYMENT_DATE { get; set; }
		[JsonPropertyName("APPLICATION NUMBER")]
		public string APPLICATION_NUMBER { get; set; }
		[JsonPropertyName("POLICY NUMBER")]
		public string POLICY_NUMBER { get; set; }
		[JsonPropertyName("Previous POLICY NUMBER")]
		public string Previous_POLICY_NUMBER { get; set; }
		[JsonPropertyName("POLICY YEAR")]
		public decimal POLICY_YEAR { get; set; }
		[JsonPropertyName("POLICY ISSUE Date")]
		public string POLICY_ISSUE_Date { get; set; }
		[JsonPropertyName("POLICY EXPIRED DATE")]
		public string POLICY_EXPIRED_DATE { get; set; }
		[JsonPropertyName("POLICY STATUS")]
		public string POLICY_STATUS { get; set; }
		[JsonPropertyName("RENEWAL DATE")]
		public string RENEWAL_DATE { get; set; }
		[JsonPropertyName("CERTIFICATE NO.")]
		public string CERTIFICATE_NO { get; set; }
		[JsonPropertyName("INSURER'S CARD NO.")]
		public string INSURER_CARD_NO {get; set;}
		[JsonPropertyName("INSURER'S PREVIOUS CARD NO")]
		public string INSURER_PREVIOUS_CARD_NO { get; set; }
		[JsonPropertyName("Member Terminate Date")]
		public string Member_Terminate_Date { get; set; }
		[JsonPropertyName("Member  Reinstatement Date")]
		public string Member_Reinstatement_Date { get; set; }
		[JsonPropertyName("Member Suspension Date")]
		public string Member_Suspension_Date { get; set; }
		[JsonPropertyName("Member Suspension To Date")]
		public string Member_Suspension_To_Date { get; set; }
		[JsonPropertyName("PLAN")]
		public string PLAN { get; set; }
		[JsonPropertyName("PLAN ISSUE DATE")]
		public string PLAN_ISSUE_DATE { get; set; }
		[JsonPropertyName("PLAN CONTRACT DATE")]
		public string PLAN_CONTRACT_DATE { get; set; }
		[JsonPropertyName("PLAN EFFECTIVE FROM DATE")]
		public string PLAN_EFFECTIVE_FROM_DATE { get; set; }
		[JsonPropertyName("PLAN EFFECTIVE TO DATE")]
		public string PLAN_EFFECTIVE_TO_DATE { get; set; }
		[JsonPropertyName("PLAN PAID DATE")]
		public string PLAN_PAID_DATE { get; set; }
		[JsonPropertyName("PLAN Paid to date")]
		public string PLAN_Paid_to_date { get; set; }
		[JsonPropertyName("PLAN Next Due Date")]
		public string PLAN_Next_Due_Date { get; set; }
		[JsonPropertyName("PLAN Status")]
		public string PLAN_Status { get; set; }
		[JsonPropertyName("PLAN RIDER")]
		public string PLAN_RIDER { get; set; }
		[JsonPropertyName("RIDER ISSUE DATE")]
		public string RIDER_ISSUE_DATE { get; set; }
		[JsonPropertyName("RIDER CONTRACT DATE")]
		public string RIDER_CONTRACT_DATE { get; set; }
		[JsonPropertyName("RIDER EFFECTIVE FROM DATE")]
		public string RIDER_EFFECTIVE_FROM_DATE { get; set; }
		[JsonPropertyName("RIDER EFFECTIVE TO DATE")]
		public string RIDER_EFFECTIVE_TO_DATE { get; set; }
		[JsonPropertyName("RIDER Terminate Date")]
		public string RIDER_Terminate_Date { get; set; }
		[JsonPropertyName("RIDER Reinstatement Date")]
		public string RIDER_Reinstatement_Date { get; set; }
		[JsonPropertyName("Rider Suspension Date")]
		public string Rider_Suspension_Date { get; set; }
		[JsonPropertyName("RIDER PAID DATE")]
		public string RIDER_PAID_DATE { get; set; }
		[JsonPropertyName("RIDER Paid to date")]
		public string RIDER_Paid_to_date { get; set; }
		[JsonPropertyName("RIDER Next Due Date")]
		public string RIDER_Next_Due_Date { get; set; }
		[JsonPropertyName("RIDER Status")]
		public string RIDER_Status { get; set; }
		[JsonPropertyName("LIFE CONTRACT DATE")]
		public string LIFE_CONTRACT_DATE { get; set; }
		[JsonPropertyName("VALIDITY DATE")]
		public string VALIDITY_DATE { get; set; }
		[JsonPropertyName("CONDITION DETAIL")]
		public string CONDITION_DETAIL { get; set; }
		[JsonPropertyName("PREMIUM FREQUENCY")]
		public string PREMIUM_FREQUENCY { get; set; }
		[JsonPropertyName("MEMBER PREMIUM")]
		public decimal MEMBER_PREMIUM { get; set; }
		[JsonPropertyName("PREMIUM (IPD)")]
		public decimal PREMIUM_IPD { get; set; }
		[JsonPropertyName("PREMIUM (OPD)")]
		public decimal PREMIUM_OPD { get; set; }
		[JsonPropertyName("Sum Insured")]
		public decimal Sum_Insured { get; set; }
		[JsonPropertyName("SOCIAL SECURITY HOSPITAL")]
		public string SOCIAL_SECURITY_HOSPITAL { get; set; }
		[JsonPropertyName("BANK")]
		public string BANK { get; set; }
		[JsonPropertyName("BANK ACCOUNT NO.")]
		public string BANK_ACCOUNT_NO { get; set; }
		[JsonPropertyName("PAYEE NAME")]
		public string PAYEE_NAME { get; set; }
		[JsonPropertyName("Payee Citizen ID")]
		public string Payee_Citizen_ID { get; set; }
		[JsonPropertyName("BU")]
		public string BU { get; set; }
		[JsonPropertyName("BRANCH")]
		public string BRANCH { get; set; }
		[JsonPropertyName("COST CENTER")]
		public string COST_CENTER { get; set; }
		[JsonPropertyName("AGENT CODE")]
		public string AGENT_CODE { get; set; }
		[JsonPropertyName("AGENT LEADER CODE")]
		public string AGENT_LEADER_CODE { get; set; }
		[JsonPropertyName("REMARK 1")]
		public string REMARK_1 { get; set; }
		[JsonPropertyName("REMARK 2")]
		public string REMARK_2 { get; set; }
		[JsonPropertyName("REMARK 3")]
		public string REMARK_3 { get; set; }
		[JsonPropertyName("REMARK 4")]
		public string REMARK_4 { get; set; }
		[JsonPropertyName("REMARK 5")]
		public string REMARK_5 { get; set; }
		[JsonPropertyName("REMARK 6")]
		public string REMARK_6 { get; set; }
		[JsonPropertyName("REMARK 7")]
		public string REMARK_7 { get; set; }
		[JsonPropertyName("REMARK 8")]
		public string REMARK_8 { get; set; }
		[JsonPropertyName("REMARK 9")]
		public string REMARK_9 { get; set; }
		[JsonPropertyName("REMARK 10")]
		public string REMARK_10 { get; set; }
		[JsonPropertyName("Insurer Action Type")]
		public string Insurer_Action_Type { get; set; }
		[JsonPropertyName("Insurer Update Date")]
		public string Insurer_Update_Date { get; set; }
		[JsonPropertyName("Cancel Date")]
		public string Cancel_Date { get; set; }
		[JsonPropertyName("PATTERN_CODE")]
		public string PATTERN_CODE { get; set; }
		[JsonPropertyName("Sponsor")]
		public string Sponsor { get; set; }
		[JsonPropertyName("Reason")]
		public string Reason { get; set; }
		[JsonPropertyName("VIP")]
		public string VIP { get; set; }
		[JsonPropertyName("Broker")]
		public string Broker { get; set; }
		[JsonPropertyName("CustomerGroup")]
		public string CustomerGroup { get; set; }
		[JsonPropertyName("VDBNO")]
		public string VDBNO { get; set; }
		[JsonPropertyName("Insurer Export Date")]
		public string Insurer_Export_Date { get; set; }
		[JsonPropertyName("Sub_Sales_Chanel")]
		public string Sub_Sales_Chanel { get; set; }
		[JsonPropertyName("ENDORSE_NO")]
		public string ENDORSE_NO { get; set; }
		[JsonPropertyName("END_TYPE")]
		public string END_TYPE { get; set; }
		[JsonPropertyName("FLEET_SEQ")]
		public string FLEET_SEQ { get; set; }
		[JsonPropertyName("FAM_SEQ")]
		public string FAM_SEQ { get; set; }
		[JsonPropertyName("SUB_SEQ")]
		public string SUB_SEQ { get; set; }
		[JsonPropertyName("UNIQUE_NO")]
		public string UNIQUE_NO { get; set; }
		[JsonPropertyName("STS_FLAG")]
		public string STS_FLAG { get; set; }
		[JsonPropertyName("CANCEL_FLAG")]
		public string CANCEL_FLAG { get; set; }
		[JsonPropertyName("Product Code")]
		public string Product_Code { get; set; }
		[JsonPropertyName("Product Type")]
		public string Product_Type { get; set; }
		[JsonPropertyName("Coverage Option")]
		public string Coverage_Option { get; set; }
		[JsonPropertyName("Progressive Code")]
		public string Progressive_Code { get; set; }
		[JsonPropertyName("Coverage Status")]
		public string Coverage_Status { get; set; }
		[JsonPropertyName("Date of Birth Payer")]
		public string Date_of_Birth_Payer { get; set; }
		[JsonPropertyName("Gender Payer")]
		public string Gender_Payer { get; set; }
		[JsonPropertyName("Address1 Payer")]
		public string Address1_Payer { get; set; }
		[JsonPropertyName("Address2 Payer")]
		public string Address2_Payer { get; set; }
		[JsonPropertyName("Address3 Payer")]
		public string Address3_Payer { get; set; }
		[JsonPropertyName("Address4 Payer")]
		public string Address4_Payer { get; set; }
		[JsonPropertyName("Address5 Payer")]
		public string Address5_Payer { get; set; }
		[JsonPropertyName("Address6 Payer")]
		public string Address6_Payer { get; set; }
		[JsonPropertyName("Campaign code")]
		public string Campaign_code { get; set; }
		[JsonPropertyName("Product code type")]
		public string Product_code_type { get; set; }
		[JsonPropertyName("Rate Scale")]
		public string Rate_Scale { get; set; }
		[JsonPropertyName("Coverage Code")]
		public string Coverage_Code { get; set; }
		[JsonPropertyName("CVR")]
		public string CVR { get; set; }
		[JsonPropertyName("Claim Type")]
		public string Claim_Type { get; set; }
		[JsonPropertyName("Payment Status")]
		public string Payment_Status { get; set; }
		[JsonPropertyName("Member Code")]
		public string Member_Code { get; set; }
		[JsonPropertyName("TransType")]
		public string TransType { get; set; }
		[JsonPropertyName("Old Member Code")]
		public string Old_Member_Code { get; set; }
		[JsonPropertyName("Card Type")]
		public string Card_Type { get; set; }
		[JsonPropertyName("Preferred Language")]
		public string Preferred_Language { get; set; }
	}
}
