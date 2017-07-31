using MVCDemo.DbFirstModel;
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
            //ViewData["Students"] = students;
            //ViewBag.Students = students;
            return View(students);
        }

        //[HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Create(FormCollection form)
        //public ActionResult Create(string name, string family, int age)
        public ActionResult Create(Student student)
        {
            //var name = Request.QueryString["Name"];

            //var name = Request.Form["Name"];
            //var family = Request.Form["Family"];

            //var name = Request["Name"];
            //var family = Request["Family"];

            //var name = form["Name"];
            //var family = form["Family"];
            //var age = int.Parse(form["Age"]);

            //StudentRepository.CreateStudent(name, family);
            StudentRepository.CreateStudent(student);
            TempData["Message"] = $"دانشجو {student.Name} {student.Family} با موفقیت افزوده شد.";
            return RedirectToAction("Index");
        }


    }
}
