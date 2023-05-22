using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository;
using InquiryPolicyDetailByInsuredDataAPI.Log;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using InquiryPolicyDetailByInsuredDataAPI.Services.Interface;
using InquiryPolicyDetailByInsuredDataAPI.Share.EnvironmentShared;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Services
{
    public class LogService : ILogService
    {
        public static IConfiguration _configuration;
        DateTime requestDate;
        SqlConnection connection;

        private readonly IRepository _repo;

        public LogService(IRepository repo)
        {
            _repo = repo;
        }
        public static string GetConnectionString()
        {
            return _configuration.GetConnectionString("DbLocal");
        }

        private async Task<int> Insert(LogModel model)
        {
            int result = 0;
            try
            {
                result = await _repo.InsertLog(model.Id, model.IPaddress, model.ApiOperation, model.ReferenceCode, model.PolicyNumber, model.Request);
                //string sql = @"Insert into [Log]([Id],[IPaddress],[ApiOperation],[CreateDate],[ReferenceCode],[PolicyNumber],[Request])
                //                          VALUES(@Id, @IPaddress, @ApiOperation, @CreateDate, @ReferenceCode, @PolicyNumber, @Request)";

                //SqlParameter[] param = new SqlParameter[]
                //{
                //    new SqlParameter("@Id", string.IsNullOrEmpty(model.Id) ? string.Empty : model.Id),
                //    new SqlParameter("@IPaddress", string.IsNullOrEmpty(model.IPaddress) ? string.Empty : model.IPaddress),
                //    new SqlParameter("@ApiOperation", string.IsNullOrEmpty(model.ApiOperation) ? string.Empty : model.ApiOperation),
                //    new SqlParameter("@CreateDate", model.CreateDate),
                //    new SqlParameter("@ReferenceCode", string.IsNullOrEmpty(model.ReferenceCode) ? string.Empty : model.ReferenceCode),
                //    new SqlParameter("@PolicyNumber", string.IsNullOrEmpty(model.PolicyNumber) ? string.Empty : model.PolicyNumber),
                //    new SqlParameter("@Request", string.IsNullOrEmpty(model.Request) ? string.Empty : model.Request)
                //};
                //using (connection = new SqlConnection(GetConnectionString()))
                //{
                //    await connection.OpenAsync();
                //    using (SqlCommand command = new SqlCommand(sql, connection))
                //    {
                //        command.CommandType = System.Data.CommandType.Text;
                //        command.Parameters.AddRange(param);
                //        result = await command.ExecuteNonQueryAsync();
                //    }
                //    await connection.CloseAsync();
                //}
            }
            catch (Exception ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    await connection.CloseAsync();
                }
                throw ex;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    await connection.CloseAsync();
                }
            }
            return result;
        }
        private async Task<int> UpdateLog(LogUpdateModel model)
        {
            int result = 0;
            try
            {
                result = await _repo.UpdateLog(model.Id, model.response);
                //string sql = @"UPDATE [Log] SET [Response] = @Response WHERE [Id] = @Id";

                //SqlParameter[] param = new SqlParameter[]
                //{
                //    new SqlParameter("@Id", string.IsNullOrEmpty(model.Id) ? string.Empty : model.Id),
                //    new SqlParameter("@Response", string.IsNullOrEmpty(model.response) ? string.Empty : model.response)
                //};
                //using (connection = new SqlConnection(GetConnectionString()))
                //{
                //    await connection.OpenAsync();
                //    using (SqlCommand command = new SqlCommand(sql, connection))
                //    {
                //        command.CommandType = System.Data.CommandType.Text;
                //        command.Parameters.AddRange(param);
                //        result = await command.ExecuteNonQueryAsync();
                //    }
                //    await connection.CloseAsync();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        private async Task<int> InsertLogDetail(LogDetailModel model)
        {
            int result = 0;
            try
            {
                result = await _repo.InsertLogDetail(model.LogId, model.Event, model.StatusCode, model.Message, model.Sequence);
                //model.Sequence = _repo.GetSequenceLogDeatilAsync(model.LogId) + 1;
                //string sql = @"Insert into [LogDetail]
                //                  ([Id]
                //                  ,[Sequence]
                //                  ,[Event]
                //                  ,[StatusCode]
                //                  ,[Message]
                //                  ,[CreateDate]
                //                  ,[Log_Id]) VALUES (NEWID(), @Sequence, @Event, @StatusCode, @Message, @CreateDate, @Log_Id)";

                //SqlParameter[] param = new SqlParameter[]
                //{
                //    new SqlParameter("@Sequence", model.Sequence),
                //    new SqlParameter("@Event", string.IsNullOrEmpty(model.Event) ? string.Empty : model.Event),
                //    new SqlParameter("@StatusCode", string.IsNullOrEmpty(model.StatusCode) ? string.Empty : model.StatusCode),
                //    new SqlParameter("@Message", string.IsNullOrEmpty(model.Message) ? string.Empty : model.Message),
                //    new SqlParameter("@CreateDate", model.CreateDate),
                //    new SqlParameter("@Log_Id", model.LogId)
                //};
                //using (connection = new SqlConnection(GetConnectionString()))
                //{
                //    await connection.OpenAsync();
                //    using (SqlCommand command = new SqlCommand(sql, connection))
                //    {
                //        command.CommandType = System.Data.CommandType.Text;
                //        command.Parameters.AddRange(param);
                //        result = await command.ExecuteNonQueryAsync();
                //    }
                //    await connection.CloseAsync();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public async void WriteLog<T>(T requestData, string uuid, string policyNumber)
        {
            requestDate = DateTime.Now;
            var log = new LogModel
            {
                Id = uuid,
                IPaddress = EnvironmentShared.GetIpAddress(),
                ApiOperation = EnvironmentShared.GetProjectName(),
                CreateDate = requestDate,
                ReferenceCode = "",
                PolicyNumber = policyNumber,
                Request = JsonConvert.SerializeObject(requestData)
            };

            await Insert(log);
        }
        public async void WriteLogUpdateResponse<T>(T response, string uuid)
        {
            requestDate = DateTime.Now;
            var log = new LogUpdateModel
            {
                Id = uuid,
                response = JsonConvert.SerializeObject(response)
            };
            await UpdateLog(log);
        }
        public async void WriteLogDetail(string refId, string eventAction, string status, string eventMsg, int Sequence)
        {
            requestDate = DateTime.Now;
            var log = new LogDetailModel
            {
                Event = eventAction,
                StatusCode = status,
                Message = eventMsg,
                CreateDate = requestDate,
                LogId = refId,
                Sequence = Sequence
            };
            await InsertLogDetail(log);
        }
    }
}
