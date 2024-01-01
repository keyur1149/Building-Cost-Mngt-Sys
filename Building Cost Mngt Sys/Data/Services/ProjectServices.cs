using Building_Cost_Mngt_Sys.Models.Project;
using Microsoft.EntityFrameworkCore;

namespace Building_Cost_Mngt_Sys.Data.Services
{
    public class ProjectServices : IProjectServices
    {
        private readonly BuildingDbContext _context;
        public ProjectServices(BuildingDbContext context)
        {
            _context = context;
        }
        public async Task Add(Projects project)
        {

            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Projects>> GetAllProjectsAsync()
        {
            List<Projects> result = await _context.Projects.ToListAsync();
            return result;
        }

        public async Task<Projects> GetProjectById(Guid id)
        {
            Projects p=await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
            return p;
        }

        public async Task Removeactive(Guid id)
        {
            Projects p = await _context.Projects.FirstOrDefaultAsync(n => n.Id == id);
            if (p!= null)
            {
                p.isActive= false;
               await _context.SaveChangesAsync();
            }
        }
    }
}
