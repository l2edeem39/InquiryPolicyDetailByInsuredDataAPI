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
        public async Task<List<ProductFch>> GetCarcolorCodeListAsync()
        {
            return await _dbContext.ProductFch.ToListAsync();
        }
        public async Task<IEnumerable<InsuredData>> GetProductByIdAsync(int InsuredDataId)
        {
            var param = new SqlParameter("@InsuredDataId", InsuredDataId);

            var result = await Task.Run(() => _dbContext.InsuredData
                            .FromSqlRaw(@"exec InsuredDataByID @InsuredDataId", param).ToListAsync());

            return result;
        }
        public async Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync()
        {
            var polyr = new SqlParameter("@polyr", "23");
            var polbr = new SqlParameter("@polbr", "181");
            var polpre = new SqlParameter("@polpre", "581");
            var polno = new SqlParameter("@polno", "000015");

            var result = await Task.Run(() => _dbContext.PolicyDetailByInsuredData
                            .FromSqlRaw(@"exec sp_TPA_VIB {0},{1},{2},{3}", polyr, polbr, polpre, polno).ToListAsync());

            return result;
        }
    }
}
