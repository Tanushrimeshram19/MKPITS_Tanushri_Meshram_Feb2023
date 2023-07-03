using System.ComponentModel.DataAnnotations;

namespace Validex4.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "UserName is Required.")]
        public string UserName { get; set; }



        [Required(ErrorMessage = "Mobile Number is Required")]
        public string MobileNumber { get; set; }
    }
}
