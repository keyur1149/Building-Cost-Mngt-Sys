using Building_Cost_Mngt_Sys.Data;
using Building_Cost_Mngt_Sys.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public class UserTypeServices:IUserTypeServices
    {
        private readonly BuildingDbContext _context;
        public UserTypeServices(BuildingDbContext context)
        {
            _context = context;
        }

        public async Task<string> GetUserTypeById(Guid i)
        {
            User_Type s = await _context.user_Types.FirstOrDefaultAsync(x => x.Id == i);
            return s.User_Type_Name;
        }

        public async Task<List<User_Type>> GetUserTypesAsync()
        {
            List<Models.Users.User_Type> users = await _context.user_Types.ToListAsync();
            return users;
        }

        
    }
}
