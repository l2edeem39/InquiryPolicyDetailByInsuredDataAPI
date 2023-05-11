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
    [Table("product_fch")]
    public class ProductFch
    {
        public string class_code { get; set; }
        public string subclass_code { get; set; }
        public string product_code { get; set; }
        public string product_name { get; set; }
    }
}
