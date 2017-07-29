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

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string name,string family)
        {
            //ViewBag.Message = "دانشجوی جدید با موفقیت ثبت شد";
            TempData["Message"] = "دانشجوی جدید با موفقیت ثبت شد";
            return RedirectToAction("Index");
        }
    }
}
