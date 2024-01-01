using Building_Cost_Mngt_Sys.Models.Users;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public interface IUserServices
    {
        Task<List<Users>> GetUsersAsync();
        Task AddAsync(Users users);
        Task<Users> Login(LoginViewModel x);

    } 
}
