using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository
{
    public interface IRepository
    {
        public Task<List<CarcolorCode>> GetCarcolorCodeListAsync();
        public Task<IEnumerable<InsuredData>> GetProductByIdAsync(int Id);
    }
}
