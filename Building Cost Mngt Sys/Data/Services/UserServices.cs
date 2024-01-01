using Building_Cost_Mngt_Sys.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public class UserServices : IUserServices
    {
        private readonly BuildingDbContext _context;
        public UserServices(BuildingDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Users users)
        {
            await _context.users.AddAsync(users);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Users>> GetUsersAsync()
        {
            List<Users> users = await _context.users.ToListAsync();
            return users;
        }

        public async Task<Users> Login(LoginViewModel n)
        {
           Users u=await _context.users.FirstOrDefaultAsync(x => x.User_Name == n.UserName && x.Password == n.Password);
            return u;
        }
    }
}
