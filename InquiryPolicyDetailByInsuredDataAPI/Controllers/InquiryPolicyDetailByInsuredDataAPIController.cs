using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository;
using InquiryPolicyDetailByInsuredDataAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Controllers
{
    [Route("CmiSearchPolicy")]
    [ApiController]
    public class InquiryPolicyDetailByInsuredDataAPIController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IRepository _repoService;
        public InquiryPolicyDetailByInsuredDataAPIController(IConfiguration config, IRepository repository)
        {
            _config = config;
            _repoService = repository;
        }
        [Route("api/1.0/SearchInsuredData")]
        [HttpPost]
        public IActionResult SearchInsuredData([FromBody] RequestInquiryModel request)
        {
            try
            {
                return Ok("Completed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("getproductbyid")]
        public async Task<IEnumerable<InsuredData>> GetProductByIdAsync(int Id)
        {
            try
            {
                var response = await _repoService.GetProductByIdAsync(Id);
                var aaa = await _repoService.GetCarcolorCodeListAsync();
                var dd = aaa.Where(x => x.carcolor_name == "").Select(x=>x.carcolor_name_e).ToList();
                if (response == null)
                {
                    return null;
                }

                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
