using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities
{
    [Table("Log")]
    public class Log
    {
      public Guid Id { get; set; }
      public string IPaddress { get; set; }
      public string ApiOperation { get; set; }
      public DateTime CreateDate { get; set; }
      public string ReferenceCode { get; set; }
      public string PolicyNumber { get; set; }
      public string Request { get; set; }
      public string Response { get; set; }
    }
}
