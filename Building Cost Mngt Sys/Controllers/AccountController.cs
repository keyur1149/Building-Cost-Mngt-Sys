using Building_Cost_Mngt_Sys.Data.Services;
using Building_Cost_Mngt_Sys.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace Building_Cost_Mngt_Sys.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountServices _accountServices;
        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        
        [HttpGet]
        public IActionResult Addexp(String name)
        {
            @ViewBag.Name = name;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addexp(Account v) {
            v.Id= Guid.NewGuid();
            var n = HttpContext.Session.GetString("user_id");
            Guid guid;
            Guid.TryParse(n, out guid);
            v.user_id = guid;
            var p = HttpContext.Session.GetString("project_id");
            Guid p_guid;
            Guid.TryParse(p, out p_guid);
            v.project_id = p_guid;
            await _accountServices.Add(v);
            return RedirectToAction("Project_DashBord","Project",new {id=p_guid,name=ViewBag.Name});
            

        }
    }
}
