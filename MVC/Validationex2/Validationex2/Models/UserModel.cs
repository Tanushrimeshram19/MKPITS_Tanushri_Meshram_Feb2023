using System.ComponentModel.DataAnnotations;

namespace Validationex2.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        public string UserName { get; set; }
        
    }
}
