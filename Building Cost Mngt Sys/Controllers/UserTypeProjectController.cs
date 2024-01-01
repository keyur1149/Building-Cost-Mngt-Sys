using Building_Cost_Mngt_Sys.Data.Services;
using Building_Cost_Mngt_Sys.Models.Project;
using Building_Cost_Mngt_Sys.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace Building_Cost_Mngt_Sys.Controllers
{
    public class UserTypeProjectController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly IProjectServices _projectServices;
        private readonly IUserTypeServices _userTypeServices;
        private readonly IUserTypeProjectServices _userTypeProjectServices;

        public UserTypeProjectController(IUserServices userServices, IProjectServices projectServices, IUserTypeServices userTypeServices,IUserTypeProjectServices userTypeProjectServices)
        {
            _userServices = userServices;
            _projectServices = projectServices;
            _userTypeServices = userTypeServices;
            _userTypeProjectServices= userTypeProjectServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Projects> project = await _projectServices.GetAllProjectsAsync();
            List<Users> users =await _userServices.GetUsersAsync();
            List<User_Type> upt = await _userTypeServices.GetUserTypesAsync();
            return View(project);
        }
        [HttpGet]
        public async Task<IActionResult> Add() { 
            var project = await _projectServices.GetAllProjectsAsync();
            List<Users> users = await _userServices.GetUsersAsync();
            List<User_Type> upt = await _userTypeServices.GetUserTypesAsync();
            UserProjectTypeViewModel t = new UserProjectTypeViewModel
            {
                Users = users,
                Projects = project,
                User_Types = upt,
            };
            return View(t);
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserProjectTypeViewModel u) {
            User_Project_Type n= new User_Project_Type()
            {
                Id=Guid.NewGuid(),
                project_Id=u.send_project,
                users_Id=u.send_user,
                user_type_Id=u.send_user_type,
            };
            await _userTypeProjectServices.Add(n);
            return RedirectToAction("Dashbord","User");
        }
    }
}
