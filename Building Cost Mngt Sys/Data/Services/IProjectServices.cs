using Building_Cost_Mngt_Sys.Models.Project;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public interface IProjectServices
    {
        Task<List<Projects>> GetAllProjectsAsync();
        Task<Projects> GetProjectById(Guid id);
        Task Add(Projects project);
        Task Removeactive(Guid id);
    }
}
