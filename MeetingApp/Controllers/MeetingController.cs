using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        // localhost/meeting
        // localhost/meeting/index
        // [HttpGet]
        // public IActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if(ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewData["NumberOfPeople"] = Repository.Users.Where(i=>i.AttendanceStatus == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }

        // meeting/details/id
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));

        }
    }
}

