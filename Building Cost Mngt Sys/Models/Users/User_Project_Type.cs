using Building_Cost_Mngt_Sys.Models.Project;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Building_Cost_Mngt_Sys.Models.Users
{
    public class User_Project_Type
    {
        [Key]
        public Guid Id { get; set; }

        public Guid project_Id { get; set; }

        public Guid user_type_Id { get; set; }

        public Guid users_Id { get; set; }
       
       
        
    }
}
