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
        public class Sequence
        {
            public const int First = 1;
        }
        public class StatusCodes
        {
            public const int Success = 200;
            public const int NotFound = 201;
            public const int Error = 500;
            public const int ValidateFail = 400;
            public const int AutherizeFail = 401;
        }
        public class SystemStatusCode
        {
            public const string FunctionalError4xx = "4xx";
            public const string SystemError = "500";
        }
        public class MessageError
        {
            public const string PolicyNo_NotFound = "Require field PolicyNo";
            public const string CardId_NotFound = "Require field CardId";
            public const string Field_NotFound = "Field Not Found";
            public const string Unauthorized = "Unauthorized : UserName or Password is invalid.";
        }
        public class Message
        {
            public const string GetPolicyDetail = "GetPolicyDetailByInsuredDataAsync";
            public const string Msg_GetPolicyDetail = "Get Data Policy Detail By Insured";
        }
    }
}
