
using Building_Cost_Mngt_Sys.Models.Users;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public interface IUserTypeServices
    {
        Task<List<User_Type>> GetUserTypesAsync();

        Task<string> GetUserTypeById(Guid i);
    }
}
