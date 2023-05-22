using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository
{
    public interface IRepository
    {
        public Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync(string PolicyNumber, string IdentityNumber, string InsuredFirstName, string InsuredLastName);
        public bool GetCredentialAsync(string user, string password);
        public int GetSequenceLogDeatilAsync(string uuid);
        public Task<int> InsertLog(string Id, string IPaddress, string ApiOperation, string ReferenceCode, string PolicyNumber, string Request);
        public Task<int> InsertLogDetail(string Id, string Event, string StatusCode, string Message);
        public Task<int> UpdateLog(string uuid, string msg);
    }
    
}
