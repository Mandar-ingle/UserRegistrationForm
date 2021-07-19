using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRegistrationForm.Models;

namespace UserRegistrationForm.Controllers
{
    public class RegistrationFormController : Controller
    {
        [HttpGet]
        public IActionResult GetFormDetails()
        {
            Student s = new Student();
            return View(s);
        }
        [HttpPost]
        public IActionResult GetFromDetails(Student s)
        {
            List<Student> list = new List<Student>();
            list.Add(s);
            //ViewBag.Students1=s;
            return View("ShowDetails", list);
        }
    }
}
