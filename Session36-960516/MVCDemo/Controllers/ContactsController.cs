using MVCDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult ShowStudentContacts(int id)//Student ID
        {
            var contacts = StudentRepository.GetStudentContacts(id);
            return View(contacts);
        }
    }
}