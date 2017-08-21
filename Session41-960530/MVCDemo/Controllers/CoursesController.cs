using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.ViewModels;

namespace MVCDemo.Controllers
{
    public class CoursesController : Controller
    {
        private StudentPortalDb ctx = new StudentPortalDb();

        // GET: Courses
        public ActionResult Index()
        {
            return View(ctx.Courses.ToList());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = ctx.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Duration")] Course course)
        {
            if (ModelState.IsValid)
            {
                ctx.Courses.Add(course);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = ctx.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            //ViewBag.Students = ctx.Students.ToList();
            ViewBag.StudentIds = new MultiSelectList(ctx.Students, "Id", "Name", course.Students.Select(s => s.Id));
            var viewModel = new CourseEditViewModel()
            {
                Id = course.Id,
                Duration = course.Duration,
                Title = course.Title
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CourseEditViewModel viewModel)
        {
            var course = new Course()
            {
                Id = viewModel.Id,
                Title = viewModel.Title,
                Duration = viewModel.Duration
            };
           
            if (ModelState.IsValid)
            {
                ctx.Entry(course).State = EntityState.Modified;
                course.Students = new List<Student>();
                course.Students.Clear();
                foreach (var studentId in viewModel.StudentIds)
                {
                    var student = ctx.Students.Find(studentId);
                    course.Students.Add(student);
                }
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = ctx.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = ctx.Courses.Find(id);
            ctx.Courses.Remove(course);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
