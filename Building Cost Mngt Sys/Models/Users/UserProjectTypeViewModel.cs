using Building_Cost_Mngt_Sys.Models.Project;

namespace Building_Cost_Mngt_Sys.Models.Users
{
    public class UserProjectTypeViewModel
    {
        public List<Users> Users { get; set; }
        public List<Projects> Projects { get; set; }

        public List<User_Type> User_Types { get; set; }

        public Guid send_user { get; set; }
        public Guid send_project{ get; set; }
        public Guid send_user_type{ get; set;}
    }
}
