using Building_Cost_Mngt_Sys.Models.Account;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public interface IAccountServices
    {
        public  Task Add(Account a);

        public Task<List<Account>> GetAllByids(Guid project_id);

    }
}
