using MeetingApp.Models; 
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {

        // localhost/home
        // localhost/home/index
        // localhost 
        public IActionResult Index()
        {
            int dt = DateTime.Now.Hour;
            // ViewBag.Greeting = dt > 12 ? "Good Afternoon" : "Good Morning";
            // ViewBag.UserName = "Ege";

            ViewData["Greeting"] = dt > 12 ? "Good Afternoon" : "Good Morning";
            int _NumberOfPeople = Repository.Users.Where(i=>i.AttendanceStatus == true).Count();
            // ViewData["UserName"] = "Ege";

            var meetingInfo = new Models.MeetingInfo
            {
                Id = 1,
                Location = "Ostim Prestij Conference Room A, Ankara",
                Date = new DateTime(2026, 07, 21, 14, 30, 0),
                NumberOfPeople = _NumberOfPeople
            };

            return View(meetingInfo);
        }
    }
}