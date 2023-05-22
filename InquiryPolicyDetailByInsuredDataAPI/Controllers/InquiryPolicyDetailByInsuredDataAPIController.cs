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
using System.Threading;

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
            Guid uuid = Guid.NewGuid();
            string uuidAsString = uuid.ToString().ToUpper();
            //uuidAsString = "6BA2DFE8-35C3-4297-89B6-1CBFFC60594C";
            try
            {
                _logService.WriteLog(request, uuidAsString, request.PolicyNumber);
                //Thread.Sleep(5000);
                var responses = new List<PolicyDetailByInsuredData>();

                #region Call Service
                var status = "0";
                var result = await _service.GetPolicyDetailByInsuredDataAsync(request);
                
                if (result.Count == 0)
                {
                    response.ErrorMessage = MessageError.Field_NotFound;
                    response.StatusCode = StatusCodes.NotFound;
                    return StatusCode(StatusCodes.NotFound, new { response, data = new List<PolicyDetailByInsuredData>() });
                }
                else
                {
                    status = "1";
                }
                _logService.WriteLogDetail(uuidAsString, Message.GetPolicyDetail, status, Message.Msg_GetPolicyDetail, Sequence.First);
                #endregion

                response.StatusCode = StatusCodes.Success;
                _logService.WriteLogUpdateResponse(response, uuidAsString);
                return StatusCode(StatusCodes.Success, new { response, data = result });
            }
            catch(Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.StatusCode = StatusCodes.Error;
                _logService.WriteLogUpdateResponse(response, uuidAsString);
                return StatusCode(StatusCodes.Error, new { response, data = new List<PolicyDetailByInsuredData>() });
            }
        }
    }
}
