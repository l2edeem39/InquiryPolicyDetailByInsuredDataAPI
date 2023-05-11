using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Models
{
    public class LogModel
    {
        public string Message { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Response { get; set; }
        public DateTime TimeStamp { get; set; }
        public Exception Exception { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Application { get; set; }
        public string HttpStatus { get; set; }
    }
    public enum Level
    {
        Information, Warnning, Error, Success
    }
}
