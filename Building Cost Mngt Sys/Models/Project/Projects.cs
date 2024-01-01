using Building_Cost_Mngt_Sys.Models.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Building_Cost_Mngt_Sys.Models.Project
{
    public class Projects
    {

        [Key]
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Address { get; set; }
        public int no_of_floors { get; set; }
        public int no_of_house_per_floor { get; set; }

       
        public bool isActive { get; set; }
        //public ICollection<User_Project_Type> User_Project_Types { get; set; }




    }
}
