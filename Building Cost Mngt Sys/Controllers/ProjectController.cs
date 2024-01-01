using Building_Cost_Mngt_Sys.Data.Services;
using Building_Cost_Mngt_Sys.Models.Account;
using Building_Cost_Mngt_Sys.Models.Project;
using Microsoft.AspNetCore.Mvc;

namespace Building_Cost_Mngt_Sys.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectServices _projectServices;
        private readonly IAccountServices _accountServices;
        public ProjectController(IProjectServices projectServices, IAccountServices accountServices)
        {
            _projectServices = projectServices;
            _accountServices = accountServices;
        }
        [HttpGet]
        public async Task<IActionResult> Inactive(Guid id)
        {
             await _projectServices.Removeactive(id);
            return RedirectToAction("DashBord_Index","User");
            //return View();
        }
        [HttpGet]
        public async Task<IActionResult> Project_Dashbord(Guid id,string name)
        {
            HttpContext.Session.Remove("project_id");
            Projects p=await _projectServices.GetProjectById(id);
            HttpContext.Session.SetString("project_id",id.ToString());
            ViewBag.Id = id.ToString();
            ViewBag.projectname = p.ProjectName;
            ViewBag.address=p.Address;
            ViewBag.no_of_floor = p.no_of_floors;
            ViewBag.no_of_house_per_floor = p.no_of_house_per_floor;
            ViewBag.as_a = name;
           
            List<Account> a = await _accountServices.GetAllByids(id);
            AccViewModel v = new AccViewModel()
            {
                Accounts = a,
            };
            return View(v);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Addproject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addproject(ProjectViewModel p)
        {
            Projects project = new Projects()
            {
                Id = Guid.NewGuid(),
                ProjectName=p.ProjectName,
                Address=p.Address,
                no_of_floors=p.no_of_floors,
                no_of_house_per_floor=p.no_of_house_per_floor,
                isActive=true,
                
            };
            _projectServices.Add(project);
            return RedirectToAction("Dashbord","User");
        }
    }
}
