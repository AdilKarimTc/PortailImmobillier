using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace PortailImmobillier.Web.Models
{
    public class RegisterModel
    {
        [DisplayName("Name")]
        [Required]
        public string FullName{ get; set;}

        [DisplayName("Email Address")]
        [Required]
        [EmailAddress]
        public string Email{ get; set; }
        
        [DisplayName("Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password{ get; set;}

        [DisplayName("Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword{ get; set;}

    }
}