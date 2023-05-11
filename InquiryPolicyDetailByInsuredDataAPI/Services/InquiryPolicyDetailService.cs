using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository;
using InquiryPolicyDetailByInsuredDataAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Services
{
    public class InquiryPolicyDetailService : IInquiryPolicyDetailService
    {
        #region Inject
        private readonly IRepository _repo;
        public InquiryPolicyDetailService(IRepository repo)
        {
            _repo = repo;
        }
        #endregion
        public async Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync()
        {
            try
            {
                var result = new List<PolicyDetailByInsuredData>();
                result = await _repo.GetPolicyDetailByInsuredDataAsync();
                //resultList = result.Where(x => x.subclass_code == "30").Select(x => new { x.product_code, x.product_name, x.subclass_code }).ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
