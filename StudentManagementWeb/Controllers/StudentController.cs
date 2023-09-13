using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementWeb.Models;
using System.Collections.Generic;
using System.Reflection;

namespace StudentManagementWeb.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();

        public StudentController() 
        {
            // Create a list of students with 4 sample data
            listStudents = new List<Student>() 
            {
                new Student() { Id = 101, Name = "Marc Levy", Branch = Branch.IT,
                Gender = Gender.Male, IsRegular=true,
                Address = "A1-2018", Email = "marclevy@g.com" },

                new Student() { Id = 102, Name = "Justin Bieber", Branch = Branch.BE,
                Gender = Gender.Male, IsRegular=true,
                Address = "A1-2019", Email = "JBieber@g.com" },

                new Student() { Id = 103, Name = "Kendrick Lamar", Branch = Branch.CE,
                Gender = Gender.Male, IsRegular=false,
                Address = "A1-2020", Email = "kendricklamar@g.com" },

                new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                Gender = Gender.Female, IsRegular = false,
                Address = "A1-2021", Email = "mai@g.com" }
            };
        }

        public IActionResult Index()
        {
            // Returns View Index.cshtml with Model as a list of sv listStudents
            return View(listStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //lấy danh sách các giá trị Gender để hiển thị radio button trên form
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();

            //lấy danh sách các giá trị Branch để hiển thị select-option trên form
            //Để hiển thị select-option trên View cần dùng List<SelectListItem>
            ViewBag.AllBranches = new List<SelectListItem>()
            {
            new SelectListItem { Text = "IT", Value = "1" },
            new SelectListItem { Text = "BE", Value = "2" },
            new SelectListItem { Text = "CE", Value = "3" },
            new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }
    }
}
