using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities
{
    public class InsuredData
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
    [Table("carcolor")]
    public class CarcolorCode
    {
        public string carcolor_name { get; set; }
        public string carcolor_name_e { get; set; }
        public string active_row { get; set; }
        public string key_login { get; set; }
        public DateTime? key_datetime { get; set; }
        public string update_login { get; set; }
        public DateTime? update_datetime { get; set; }
    }
}
