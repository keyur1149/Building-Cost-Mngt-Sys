using System.ComponentModel.DataAnnotations;

namespace Building_Cost_Mngt_Sys.Models.Users
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
