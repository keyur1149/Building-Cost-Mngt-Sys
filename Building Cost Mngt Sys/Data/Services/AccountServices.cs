using Building_Cost_Mngt_Sys.Models.Account;
using Microsoft.EntityFrameworkCore;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly BuildingDbContext _context;

        public AccountServices(BuildingDbContext context)
        {
            _context = context;
        }
        public async Task Add(Account a)
        {
            await _context.Accounts.AddAsync(a);
            _context.SaveChanges();
        }

        public async Task<List<Account>> GetAllByids(Guid project_id)
        {
            List<Account> result = await _context.Accounts.Where(x => x.project_id == project_id ).ToListAsync();
            return result;
        }
    }
}
