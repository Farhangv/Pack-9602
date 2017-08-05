using MVCDemo.Models;
using MVCDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult Index()
        {
            var students = StudentRepository.GetAllStudents();
            return View(students);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            StudentRepository.CreateStudent(student);
            TempData["Message"] = $"دانشجو {student.Name} {student.Family} با موفقیت افزوده شد.";
            return RedirectToAction("Index");
        }


    }
}
