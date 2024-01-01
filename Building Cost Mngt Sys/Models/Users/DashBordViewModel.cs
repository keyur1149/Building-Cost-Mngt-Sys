using Building_Cost_Mngt_Sys.Models.Project;
using Building_Cost_Mngt_Sys.Models.Users;

namespace Building_Cost_Mngt_Sys.Models.Users
{
    public class DashBordViewModel
    {
        public List<Projects> as_partner { get; set; }
        public List<Projects> as_operator { get; set; }

        public Guid Project_Id { get; set; }

    }
}
