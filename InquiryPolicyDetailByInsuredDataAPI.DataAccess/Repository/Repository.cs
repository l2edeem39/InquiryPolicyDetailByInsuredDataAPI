﻿using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Context;
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
        public async Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync(string PolNo, string CardId)
        {
            var result = await Task.Run(() => _dbContext.PolicyDetailByInsuredData
                            .FromSqlRaw(@"exec sp_TPA_VIB {0},{1}", PolNo, CardId).ToListAsync());
            
            return result;
        }
        public bool GetCredentialAsync(string user, string password)
        {
            //var result = _dbContext.User.Where(x => x.UserName.Trim().ToString() == user.Trim().ToString() && x.Password.Trim().ToString() == password.Trim().ToString()).ToList();
            var result = new List<User>()
            {
                new User()
                {
                    UserName = "usertest",
                    Password = "123456"
                }
            };

            result = result.Where(x => x.UserName.Trim().ToString() == user.Trim().ToString() && x.Password.Trim().ToString() == password.Trim().ToString()).ToList();

            if (result.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
