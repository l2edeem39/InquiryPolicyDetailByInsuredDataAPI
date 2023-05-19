using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Context;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository
{
    public class Repository : IRepository
    {
        private readonly DbContextClass _dbContext;
        private readonly DbContextLogin _dbContextLogin;
        public Repository(DbContextClass dbContext, DbContextLogin dbContextLogin)
        {
            _dbContext = dbContext;
            _dbContextLogin = dbContextLogin;
        }
        public async Task<List<PolicyDetailByInsuredData>> GetPolicyDetailByInsuredDataAsync(string PolicyNumber, string IdentityNumber, string InsuredFirstName, string InsuredLastName)
        {
            var paramPolicyNumber = new SqlParameter("@PolicyNumber", PolicyNumber);
            var paramIdentityNumber = new SqlParameter("@IdentityNumber", IdentityNumber);
            var paramInsuredFirstName = new SqlParameter("@InsuredFirstName", InsuredFirstName);
            var paramInsuredLastName = new SqlParameter("@InsuredLastName", InsuredLastName);
            var result = await Task.Run(() => _dbContext.PolicyDetailByInsuredData
                            .FromSqlRaw(@"exec sp_TPA_VIB @PolicyNumber, @IdentityNumber, @InsuredFirstName, @InsuredLastName", paramPolicyNumber, paramIdentityNumber, paramInsuredFirstName, paramInsuredLastName)
                            .ToListAsync());

            return result;
        }
        public bool GetCredentialAsync(string user, string password)
        {
            var result = _dbContextLogin.UserLogin
                .Where(x => x.Username.Trim() == user.Trim() && x.Password.Trim() == password.Trim() && x.IsActive == true)
                .ToList();

            return result.Count > 0 ? true : false;
        }
        public int GetSequenceLogDeatilAsync(string uuid)
        {
            var result = _dbContextLogin.LogDetail
                .Where(x => x.Log_Id.ToString() == uuid)
                .ToList();

            return result.Count > 0 ? result.Max(x => x.Sequence) : 0;
        }

        public async Task<int> UpdateLog(string uuid,string msg)
        {
            var data = _dbContextLogin.Log.FirstOrDefault(a => a.Id == Guid.Parse(uuid));
            data.Response = msg;
            return await _dbContextLogin.SaveChangesAsync();
        }
        public async Task<int> InsertLog(string Id, string IPaddress, string ApiOperation, string ReferenceCode, string PolicyNumber, string Request)
        {
            _dbContextLogin.Log.Add(new Log()
            {
                Id = Guid.Parse(Id),
                IPaddress = IPaddress,
                ApiOperation = ApiOperation,
                CreateDate = DateTime.Now,
                ReferenceCode = ReferenceCode,
                PolicyNumber = PolicyNumber,
                Request = Request
            });
            return await _dbContextLogin.SaveChangesAsync();
        }
        public async Task<int> InsertLogDetail(string Id, string Event, string StatusCode, string Message)
        {
            var sequence = GetSequenceLogDeatilAsync(Id) + 1;
            _dbContextLogin.LogDetail.Add(new LogDetail()
            {
                Id = new Guid(),
                Sequence = sequence,
                Event = Event,
                StatusCode = StatusCode,
                Message = Message,
                CreateDate = DateTime.Now,
                Log_Id = Guid.Parse(Id)
            });
            return await _dbContextLogin.SaveChangesAsync();
        }
    }
}
