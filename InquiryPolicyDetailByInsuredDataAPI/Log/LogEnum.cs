using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Log
{
    public class LogEnum
    {
        public enum Level
        {
            Information, Warnning, Error, Success
        }
        public class CodeStatus
        {
            public const int Success = 200;
            public const int Error = 500;
            public const int NotFound = 404;
            public const int Code400 = 404;
        }
        public class SystemStatusCode
        {
            public const string Success = "0";
            public const string Fail = "1";
            public const string FunctionalError4xx = "4xx";
            public const string SystemError = "500";
        }
    }
}
