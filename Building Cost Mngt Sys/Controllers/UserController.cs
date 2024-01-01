using Building_Cost_Mngt_Sys.Data;
using Building_Cost_Mngt_Sys.Data.Services;
using Building_Cost_Mngt_Sys.Models.Project;
using Building_Cost_Mngt_Sys.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Mail;

namespace Building_Cost_Mngt_Sys.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices userServices;
        private readonly IUserTypeProjectServices userTypeProjectServices;
        private readonly IProjectServices projectServices;
        private readonly IUserTypeServices userTypeServices;
        public UserController(IUserServices _userServices, IUserTypeProjectServices userTypeProjectServices,IProjectServices projectServices, IUserTypeServices userTypeServices)
        {
            this.projectServices = projectServices;
            userServices = _userServices;
            this.userTypeProjectServices = userTypeProjectServices;
            this.userTypeServices = userTypeServices;
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<IActionResult> DashBord_Index()
        {
            var n=HttpContext.Session.GetString("user_id");
            ViewBag.Id = HttpContext.Session.GetString("user_id");
            ViewBag.Name = HttpContext.Session.GetString("user_name");
            ViewBag.Email = HttpContext.Session.GetString("user_mailid");

            Guid guid;
            Guid.TryParse(n, out guid);
            List<User_Project_Type> UPT = await userTypeProjectServices.GetByUserId(guid);
            List<Projects> as_partner=new List<Projects>();
            List<Projects> as_operator = new List<Projects>();
            foreach (User_Project_Type v in UPT)
            {
                string temp = await userTypeServices.GetUserTypeById(v.user_type_Id);
                Projects project = await projectServices.GetProjectById(v.project_Id);
                if (temp == "Partner")
                {
                    as_partner.Add(project);
                }
                else
                {
                    as_operator.Add(project);
                }
            }
            DashBordViewModel d = new DashBordViewModel
            {
                as_partner = as_partner,
                as_operator = as_operator,
            };
            return View(d);
        }

        public IActionResult Dashbord()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Adduser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adduser(Building_Cost_Mngt_Sys.Models.Users.AdduserViewModel u)
        {
            var User = new Users()
            {
                Id = Guid.NewGuid(),
                User_Name = u.User_Name,
                EmailID = u.EmailID,
                Password = u.Password,
                PasswordModified = "no",
            };
            userServices.AddAsync(User);
           /*MailMessage mm = new MailMessage("20ceuog027@ddu.ac.in", u.EmailID);
            mm.Subject = "Username and password";
            mm.Body = "Your User Name :- " + u.User_Name + "\nYour Password :- " + u.Password;
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl=true;

                    NetworkCredential cred = new NetworkCredential("20ceuog027@ddu.ac.in", "nugvllcacxrnhfwq");
                    smtp.UseDefaultCredentials= true;
                    smtp.Credentials = cred;
                    smtp.Port = 587;
                    smtp.Send(mm);
               */
            return RedirectToAction("Dashbord");
        }
        
        [HttpGet]
        public async Task<IActionResult> Login()
        {
           var id=HttpContext.Session.GetString("user_id");

            if (id != null)
            {
                return RedirectToAction("DashBord_Index");
            }
            HttpContext.Session.Clear();

            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Login(LoginViewModel users)
        {
            Users n =await userServices.Login(users);
            if (n != null && users.UserName=="Admin")
            {
                HttpContext.Session.SetString("user_id", n.Id.ToString());
                HttpContext.Session.SetString("user_name", n.User_Name.ToString());
                HttpContext.Session.SetString("user_mailid", n.EmailID.ToString());
                return RedirectToAction("Dashbord");
            }else if (n != null) { 
                HttpContext.Session.SetString("user_id", n.Id.ToString());
                HttpContext.Session.SetString("user_name", n.User_Name.ToString());
                HttpContext.Session.SetString("user_mailid",n.EmailID.ToString());
                return RedirectToAction("DashBord_Index"); 
            }
            
            return RedirectToAction("Login");
        }
    }
}
