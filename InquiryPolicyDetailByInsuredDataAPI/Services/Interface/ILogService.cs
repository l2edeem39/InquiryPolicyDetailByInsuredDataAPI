using InquiryPolicyDetailByInsuredDataAPI.Log;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Services.Interface
{
    public interface ILogService
    {
        public void WriteLog<T>(T requestData, string uuid, string policyNumber);
        public void WriteLogUpdateResponse<T>(T response, string uuid);
        public void WriteLogDetail(string refId, string eventAction, string status, string eventMsg);
    }
}
