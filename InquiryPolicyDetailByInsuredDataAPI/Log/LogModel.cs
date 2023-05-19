using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Models
{
    public class LogModel
    {
        public string Id { get; set; }
        public string IPaddress { get; set; }
        public string ApiOperation { get; set; }
        public DateTime CreateDate { get; set; }
        public string ReferenceCode { get; set; }
        public string PolicyNumber { get; set; }
        public string Request { get; set; }
    }
    public class LogDetailModel
    {
        public int Sequence { get; set; }
        public string Event { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public string LogId { get; set; }
    }
    public class LogUpdateModel
    {
        public string Id { get; set; }
        public string response { get; set; }
    }
    public enum Level
    {
        Information, Warnning, Error, Success
    }
}
