using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository;
using InquiryPolicyDetailByInsuredDataAPI.Log;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using InquiryPolicyDetailByInsuredDataAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static InquiryPolicyDetailByInsuredDataAPI.Log.LogEnum;

namespace InquiryPolicyDetailByInsuredDataAPI.Controllers
{
    [Route("CmiSearchPolicy")]
    [ApiController]
    public class InquiryPolicyDetailByInsuredDataAPIController : Controller
    {
        ResponseModel response = new ResponseModel();

        private readonly IRepository _repoService;
        private readonly ILogService _logService;
        public InquiryPolicyDetailByInsuredDataAPIController(IRepository repository, ILogService log)
        {
            _repoService = repository;
            _logService = log;
        }
        [HttpPost("api/1.0/SearchInsuredData")]
        public async Task<IActionResult> GetSearchInsuredDataAsync([FromBody] RequestInquiryModel request)
        {
            try
            {
                var responses = new List<PolicyDetailByInsuredData>();
                //var response = await _repoService.GetProductByIdAsync(Id);
                var result = await _repoService.GetCarcolorCodeListAsync();
                //var response = await _repoService.GetPolicyDetailByInsuredDataAsync();
                //var dd = aaa.Where(x => x.carcolor_name == "").Select(x=>x.carcolor_name_e).ToList();
                this.ControllerContext.RouteData.Values["action"].ToString();
                if (response == null)
                {
                    return null;
                }

                response.ErrorCode = "";
                response.ErrorMessage = "";
                response.Status = "0";
                _logService.WriteLog(LogEnum.Level.Information, request, response, CodeStatus.Success, this.ControllerContext.RouteData.Values["controller"].ToString(), this.ControllerContext.RouteData.Values["action"].ToString());
                return StatusCode(CodeStatus.Success, new { response, data = result });
            }
            catch(Exception ex)
            {
                response.ErrorCode = SystemStatusCode.SystemError;
                response.ErrorMessage = ex.Message;
                response.Status = "1";
                _logService.WriteLogError(request, response, ex, CodeStatus.Error, this.ControllerContext.RouteData.Values["controller"].ToString(), this.ControllerContext.RouteData.Values["action"].ToString());
                return StatusCode(CodeStatus.Success, new { response, data = new PolicyDetailByInsuredData() });
            }
        }
    }
}
