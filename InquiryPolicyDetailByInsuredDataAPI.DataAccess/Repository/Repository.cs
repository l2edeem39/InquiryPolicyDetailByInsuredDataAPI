using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Context;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository
{
    public class Repository : IRepository
    {
        private readonly DbContextClass _dbContext;
        public Repository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CarcolorCode>> GetCarcolorCodeListAsync()
        {
            return await _dbContext.CarcolorCode.ToListAsync();
        }
        public async Task<IEnumerable<InsuredData>> GetProductByIdAsync(int InsuredDataId)
        {
            var param = new SqlParameter("@InsuredDataId", InsuredDataId);

            var productDetails = await Task.Run(() => _dbContext.InsuredData
                            .FromSqlRaw(@"exec InsuredDataByID @InsuredDataId", param).ToListAsync());

            return productDetails;
        }
    }
}
