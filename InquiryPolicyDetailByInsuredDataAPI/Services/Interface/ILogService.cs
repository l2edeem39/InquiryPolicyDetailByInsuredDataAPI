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
        public void WriteLog<T>(LogEnum.Level level, T requestData, ResponseModel response, int status_code, string controller, string action);
        public void WriteLogError<T>(T requestData, ResponseModel response, Exception ex, int status_code, string controller, string action);
    }
}
