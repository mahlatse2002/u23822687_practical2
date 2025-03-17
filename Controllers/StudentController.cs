using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Practical2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GroupList()
        {

            List<Models.StudentModel> ClassList = new List<Models.StudentModel>();


            ClassList.Add(new Models.StudentModel { FirstName = "Mahlatse", LastName = "Ndzumeni", StudentNumber = "23822687", Email = "U23822687@Tuks.co.za" });
            ClassList.Add(new Models.StudentModel { FirstName = "Terry", LastName = "Ntimane", StudentNumber = "24827643", Email = "u24827643@Tuks.co.za" });
            ClassList.Add(new Models.StudentModel { FirstName = "Ethan", LastName = "Carlson", StudentNumber = "23628654", Email = "u23628654@Tuks.co.za" });
            ClassList.Add(new Models.StudentModel { FirstName = "priyanka", LastName = "maharaj", StudentNumber = "25972883", Email = "u25972883@Tuks.co.za" });
            ClassList.Add(new Models.StudentModel { FirstName = "Lebogang", LastName = "Mokoena", StudentNumber = "22829627", Email = "u22829627@Tuks.co.za" });

            return View(ClassList);






        }
    }
}

