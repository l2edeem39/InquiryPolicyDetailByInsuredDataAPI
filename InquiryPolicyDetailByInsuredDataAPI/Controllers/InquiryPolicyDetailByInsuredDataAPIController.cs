using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.Log;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using InquiryPolicyDetailByInsuredDataAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static InquiryPolicyDetailByInsuredDataAPI.Log.LogEnum;

namespace InquiryPolicyDetailByInsuredDataAPI.Controllers
{
    [Authorize]
    [Route("CmiSearchPolicy")]
    [ApiController]
    public class InquiryPolicyDetailByInsuredDataAPIController : Controller
    {
        ResponseModel response = new ResponseModel();
        private readonly IInquiryPolicyDetailService _service;
        private readonly ILogService _logService;
        public InquiryPolicyDetailByInsuredDataAPIController(IInquiryPolicyDetailService service, ILogService log)
        {
            _service = service;
            _logService = log;
        }
        [HttpPost("api/1.0/SearchInsuredData")]
        public async Task<IActionResult> GetSearchInsuredDataAsync([FromBody] RequestInquiryModel request)
        {
            var controller = this.ControllerContext.RouteData.Values["controller"].ToString();
            var action = this.ControllerContext.RouteData.Values["action"].ToString();
            try
            {
                var responses = new List<PolicyDetailByInsuredData>();

                #region Validate Request
                if (string.IsNullOrEmpty(request.PolicyNo.Trim().ToString()) || string.IsNullOrEmpty(request.CardId.Trim().ToString()))
                {
                    if (string.IsNullOrEmpty(request.PolicyNo.Trim().ToString()) && string.IsNullOrEmpty(request.CardId.Trim().ToString()))
                    {
                        response.ErrorMessage = String.Format("{0}, {1}", MessageError.PolicyNo_NotFound, MessageError.CardId_NotFound);
                    }
                    else if (string.IsNullOrEmpty(request.PolicyNo.Trim().ToString()))
                    {
                        response.ErrorMessage = MessageError.PolicyNo_NotFound;
                    }
                    else if (string.IsNullOrEmpty(request.CardId.Trim().ToString()))
                    {
                        response.ErrorMessage = MessageError.CardId_NotFound;
                    }
                    response.StatusCode = StatusCodes.ValidateFail;
                    _logService.WriteLogError(request, response, new Exception(), StatusCodes.ValidateFail, controller, action);
                    return StatusCode(StatusCodes.ValidateFail, new { response, data = new List<PolicyDetailByInsuredData>() });
                }
                #endregion

                #region Call Service
                var result = await _service.GetPolicyDetailByInsuredDataAsync(request);

                if (result.Count == 0)
                {
                    response.ErrorMessage = MessageError.Field_NotFound;
                    response.StatusCode = StatusCodes.NotFound;
                    _logService.WriteLog(LogEnum.Level.Information, request, response, StatusCodes.NotFound, controller, action);
                    return StatusCode(StatusCodes.NotFound, new { response, data = new List<PolicyDetailByInsuredData>() });
                }
                #endregion

                response.StatusCode = StatusCodes.Success;
                _logService.WriteLog(LogEnum.Level.Information, request, response, StatusCodes.Success, controller, action);
                return StatusCode(StatusCodes.Success, new { response, data = result });
            }
            catch(Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.StatusCode = StatusCodes.Error;
                _logService.WriteLogError(request, response, ex, StatusCodes.Error, controller, action);
                return StatusCode(StatusCodes.Error, new { response, data = new List<PolicyDetailByInsuredData>() });
            }
        }
    }
}
