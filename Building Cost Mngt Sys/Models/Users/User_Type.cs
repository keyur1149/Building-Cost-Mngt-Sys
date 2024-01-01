using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Building_Cost_Mngt_Sys.Models.Users
{
    public class User_Type
    {
        [Key]
        public Guid Id { get; set; }
        public string User_Type_Name { get;set; }

        //public ICollection<User_Project_Type> User_Project_Types { get; set; }

    }
}
