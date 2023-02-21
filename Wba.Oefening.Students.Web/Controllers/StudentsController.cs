using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wba.Oefening.Students.Core.Entities;
using Wba.Oefening.Students.Web.Models;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentRepository _studentRepository = new();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id) 
        {
            //get the data
            var student = _studentRepository
                .Students()
                .FirstOrDefault(s => s.Id == id);
            //check for null
            if(student == null) 
            {
                return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            //fill the model
            var studentsDetailsViewModel = new StudentsDetailsViewModel
            { 
                Id = student.Id,
                Name = $"{student.Firstname} {student.Lastname}",
                Course = student.Course,
            };
            return View(studentsDetailsViewModel);
        }
    }
}
