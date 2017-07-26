using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServerSideDemo.Models;
using System.Threading;

namespace ServerSideDemo.Controllers
{
    public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
            base.OnActionExecuting(filterContext);
        }
    }

    public class ToDoController : Controller
    {
        private TodoDb db = new TodoDb();

        [AllowCrossSiteJson]
        public ActionResult List()
        {
            Thread.Sleep(2000);
            return Json(db.Todos.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowCrossSiteJson]
        public ActionResult Create(ToDo toDo)
        {
            Thread.Sleep(2000);
            if (ModelState.IsValid)
            {
                db.Todos.Add(toDo);
                db.SaveChanges();
                return Json(db.Todos.ToList());
            }

            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
        }


        [HttpPost, ActionName("Delete")]
        [AllowCrossSiteJson]
        public ActionResult DeleteConfirmed(int id)
        {
            ToDo toDo = db.Todos.Find(id);
            db.Todos.Remove(toDo);
            db.SaveChanges();
            return new HttpStatusCodeResult(200);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
