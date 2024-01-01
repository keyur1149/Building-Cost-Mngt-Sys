using System.ComponentModel.DataAnnotations;
using Building_Cost_Mngt_Sys.Models.Project;

namespace Building_Cost_Mngt_Sys.Models.Users
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        public string User_Name { get; set;}
        public string EmailID { get; set;}
        public string Password { get; set;}
        public string PasswordModified { get; set;}
        //public ICollection<User_Project_Type> User_Project_Types { get; set; }

    }
}
