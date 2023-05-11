using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.Log;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using InquiryPolicyDetailByInsuredDataAPI.Services.Interface;
using InquiryPolicyDetailByInsuredDataAPI.Share.EnvironmentShared;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Services
{
    public class LogService : ILogService
    {
        public static IConfiguration _configuration;
        DateTime requestDate;

        public static string GetConnectionString()
        {
            return _configuration.GetConnectionString("TESTDB");
        }

        public static async Task<int> LogInformation(LogModel model)
        {
            int insert_row = -1;
            try
            {
                insert_row = await Insert(LogEnum.Level.Information, model);
            }
            catch (Exception)
            {

            }
            return insert_row;
        }
        public static async Task<int> LogWarnning(LogModel model)
        {
            int insert_row = -1;
            try
            {
                insert_row = await Insert(LogEnum.Level.Warnning, model);
            }
            catch (Exception)
            {

            }
            return insert_row;
        }
        public static async Task<int> LogError(LogModel model)
        {
            int insert_row = -1;
            try
            {
                insert_row = await Insert(LogEnum.Level.Error, model);
            }
            catch (Exception)
            {

            }
            return insert_row;
        }
        public static async Task<int> LogSuccess(LogModel model)
        {
            int insert_row = -1;
            try
            {
                insert_row = await Insert(LogEnum.Level.Success, model);
            }
            catch (Exception)
            {

            }
            return insert_row;
        }
        private static async Task<int> Insert(LogEnum.Level level, LogModel model)
        {
            int result = 0;
            try
            {
                string exception = string.Empty;
                if (model.Exception != null)
                {
                    exception = JsonConvert.SerializeObject(model.Exception);
                }
                string sql = @"Insert into Log_CPSD(Message, Header, Body, Response, Level, TimeStamp, Exception, Description1, Description2, Description3, ProjectCode, HttpStatus) 
                                        VALUES(@Message, @Header, @Body, @Response, @Level, @TimeStamp, @Exception, @Description1, @Description2, @Description3, @ProjectCode, @HttpStatus)";

                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@Message",string.IsNullOrEmpty(model.Message)?string.Empty:model.Message),
                new SqlParameter("@Header",string.IsNullOrEmpty(model.Header)?string.Empty:model.Header),
                new SqlParameter("@Body",string.IsNullOrEmpty(model.Body)?string.Empty:model.Body),
                new SqlParameter("@Response",string.IsNullOrEmpty(model.Response)?string.Empty:model.Response),
                new SqlParameter("@Level",level.ToString()),
                new SqlParameter("@TimeStamp",model.TimeStamp),
                new SqlParameter("@Exception",string.IsNullOrEmpty(exception)?string.Empty:exception),
                new SqlParameter("@Description1",string.IsNullOrEmpty(model.Description1)?string.Empty:model.Description1),
                new SqlParameter("@Description2",string.IsNullOrEmpty(model.Description2)?string.Empty:model.Description2),
                new SqlParameter("@Description3",string.IsNullOrEmpty(model.Description3)?string.Empty:model.Description3),
                new SqlParameter("@ProjectCode",string.IsNullOrEmpty(model.Application)?string.Empty:model.Application),
                new SqlParameter("@HttpStatus",string.IsNullOrEmpty(model.HttpStatus)?string.Empty:model.HttpStatus)
                };
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddRange(param);
                        result = await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public async void WriteLog<T>(LogEnum.Level level, T requestData, ResponseModel response, int status_code, string controller, string action)
        {
            requestDate = DateTime.Now;
            var log = new LogModel
            {
                Application = EnvironmentShared.GetProjectName(),
                TimeStamp = requestDate,
                Body = JsonConvert.SerializeObject(requestData),
                Response = JsonConvert.SerializeObject(response),
                HttpStatus = status_code.ToString(),
                Message = response.ErrorMessage,
                Description1 = controller.ToString(),
                Description2 = action.ToString()
            };
            if (level.Equals(LogEnum.Level.Information))
                await LogInformation(log);
            else if (level.Equals(LogEnum.Level.Success))
                await LogSuccess(log);
        }
        public async void WriteLogError<T>(T requestData, ResponseModel response, Exception ex, int status_code, string controller, string action)
        {
            requestDate = DateTime.Now;
            var log = new LogModel
            {
                Application = EnvironmentShared.GetProjectName(),
                TimeStamp = requestDate,
                Body = JsonConvert.SerializeObject(requestData),
                Response = JsonConvert.SerializeObject(response),
                Exception = ex,
                HttpStatus = status_code.ToString(),
                Message = response.ErrorMessage,
                Description1 = controller.ToString(),
                Description2 = action.ToString()
            };
            await LogError(log);
        }
    }
}
