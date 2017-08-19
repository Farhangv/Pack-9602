using MVCDemo.Models;
using MVCDemo.Repository;
using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
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
        public ActionResult Create(StudentCreateViewModel viewModel)
        {
            try
            {
                if (viewModel.Name == "جان" && viewModel.Family == "دو")
                {
                    ModelState.AddModelError("", "نام جان دو مجاز نیست");
                }
                var photo = viewModel.PostedPhoto;
                var extension = Path.GetExtension(photo.FileName).ToLower();
                var size = (photo.ContentLength / 1024);

                if (!(extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif"))
                {
                    ModelState.AddModelError("PostedPhoto", "فایل ارسالی مجاز نیست");
                }
                if(size > 150)
                {
                    ModelState.AddModelError("PostedPhoto", "سایز عکس باید کمتر از ۱۵۰ کیلو بایت باشد");
                }

                if (ModelState.IsValid)//بررسی صحت اطلاعات مدل
                {
                    StudentRepository.CreateStudent(viewModel);
                    TempData["Message"] = $"دانشجو {viewModel.Name} {viewModel.Family} با موفقیت افزوده شد.";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(viewModel);
                }
            }
            catch(Exception ex)
            {
                //return Content(ex.Message);
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }

        public ActionResult ConfirmDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            using (var ctx = new StudentPortalDb())
            {
                var student = ctx.Students.Find(id);
                if (student == null)
                {
                    return HttpNotFound();
                }
                return View(student);
            }

        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            using (var ctx = new StudentPortalDb())
            {
                var student = ctx.Students.Find(id);//.Where(s => s.Id == id).FirstOrDefault();
                if (student == null)
                {
                    //return new HttpStatusCodeResult(404);
                    return HttpNotFound();
                }
                ctx.Students.Remove(student);
                ctx.SaveChanges();
            }
            TempData["Message"] = $"دانشجوی انتخاب شده با موفقیت حذف شد";
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)//استخراج رکورد از پایگاه و انتقال آن به ویوو
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            using (var ctx = new StudentPortalDb())
            {
                var student = ctx.Students.Find(id);//.Where(s => s.Id == id).FirstOrDefault();
                if (student == null)
                {
                    //return new HttpStatusCodeResult(404);
                    return HttpNotFound();
                }
                return View(student);
            }
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            using (var ctx = new StudentPortalDb())
            {
                //(I)
                //var oldStudent = ctx.Students.Find(student.Id);
                //oldStudent.Name = student.Name;
                //oldStudent.Family = student.Family;
                //(II)
                student.BirthDate = DateTime.Now;
                //ctx.Students.Attach(student);
                ctx.Entry(student).State = EntityState.Modified;
                ctx.SaveChanges();
                TempData["Message"] = $"دانشجوی انتخاب شده با موفقیت ویرایش شد";
                return RedirectToAction("Index");

            }
        }

        [ChildActionOnly]
        public ActionResult StudentBox(int id)
        {
            using (var ctx = new StudentPortalDb())
            {
                var student = ctx.Students.Find(id);
                return PartialView("~/Views/Students/_StudentBox.cshtml", student);
            }
        }
    }
}
