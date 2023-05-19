using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities
{
    [Table("LogDetail")]
    public class LogDetail
    {
       public Guid Id { get; set; }
       public int Sequence { get; set; }
       public string Event { get; set; }
       public string StatusCode { get; set; }
       public string Message { get; set; }
       public DateTime CreateDate { get; set; }
       public Guid Log_Id { get; set; }
    }
}
