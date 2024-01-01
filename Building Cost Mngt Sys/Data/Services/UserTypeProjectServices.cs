using Building_Cost_Mngt_Sys.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public class UserTypeProjectServices:IUserTypeProjectServices
    {
        private readonly BuildingDbContext _Context;
        public UserTypeProjectServices(BuildingDbContext context)
        {
            _Context = context;
        }

        public async Task Add(User_Project_Type u)
        {
            await _Context.User_Project_Type.AddAsync(u);
            await _Context.SaveChangesAsync();
        }

        public async Task<List<User_Project_Type>> GetByUserId(Guid n)
        {
            List<User_Project_Type> user_Project_Types = await _Context.User_Project_Type.Where(x => x.users_Id == n).ToListAsync();
            return user_Project_Types;
        }
    }
}
