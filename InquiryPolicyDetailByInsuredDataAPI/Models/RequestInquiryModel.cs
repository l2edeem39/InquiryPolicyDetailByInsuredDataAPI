using System.ComponentModel.DataAnnotations;

namespace InquiryPolicyDetailByInsuredDataAPI.Models
{
    public class RequestInquiryModel
    {
        [Required]
        [StringLength(20)]
        public string PolicyNumber { get; set; }
        [Required]
        [StringLength(13)]
        public string IdentityNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string InsuredFirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string InsuredLastName { get; set; }
    }
}
