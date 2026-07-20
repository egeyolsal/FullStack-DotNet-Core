using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

// course 
public class CourseController : Controller {
    
    // course
    // course/index
    // public IActionResult Index() {

    //     var course = new Course() { 
    //         Id = 1, 
    //         Title = "ASP.NET Core Course",
    //         description = "This is a course about ASP.NET Core.",
    //         Image = "1.png"
    //     };
    
    //     return View(course);
    // }

     public IActionResult Details(int? id) {

        if(id == null) {
            // return Redirect("/Course/List");
            return RedirectToAction("List", "Course");
        }
        var course = Repository.GetCourseById(id);
        return View(course);
    }
    
    // course/list
     public IActionResult List() {

        return View("CourseList", Repository.Courses); // it will look for a view called CourseList.cshtml otherwise it will look for a view called List.cshtml.
    }

}