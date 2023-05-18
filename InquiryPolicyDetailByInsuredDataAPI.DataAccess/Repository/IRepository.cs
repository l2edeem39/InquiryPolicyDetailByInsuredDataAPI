using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository
{
    public interface IRepository
    {
        public Task<List<ProductFch>> GetCarcolorCodeListAsync();
        public Task<IEnumerable<InsuredData>> GetProductByIdAsync(int Id);
        public Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync(string PolicyNumber, string IdentityNumber, string InsuredFirstName, string InsuredLastName);
        public bool GetCredentialAsync(string user, string password);
    }
}
