using Building_Cost_Mngt_Sys.Models.Account;
using Building_Cost_Mngt_Sys.Models.Project;
using Building_Cost_Mngt_Sys.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Building_Cost_Mngt_Sys.Data
{
    public class BuildingDbContext: DbContext 
    {
        public BuildingDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Users> users { get; set; }

        public DbSet<User_Type> user_Types { get; set; }

       public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User_Project_Type> User_Project_Type { get; set; }

    }
}
