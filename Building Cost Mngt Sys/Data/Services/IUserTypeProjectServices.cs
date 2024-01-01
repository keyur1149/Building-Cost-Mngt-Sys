using Building_Cost_Mngt_Sys.Models.Users;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public interface IUserTypeProjectServices
    {
        Task Add(User_Project_Type u);
        Task<List<User_Project_Type>> GetByUserId(Guid x);
    }
}
