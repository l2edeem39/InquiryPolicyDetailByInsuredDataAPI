using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Services.Interface
{
    public interface IInquiryPolicyDetailService
    {
        public Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync(RequestInquiryModel request);
    }
}
