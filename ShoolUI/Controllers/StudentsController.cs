using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RuxSchool;

namespace ShoolUI.Controllers
{
    public class StudentsController : Controller
    {
        private StudentDB db = new StudentDB();

        // GET: Students
        public ActionResult Index()
        {
            var students = School.RetrieveStudentProfile(HttpContext.User.Identity.Name);
            return View(students);
            
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.StudentDetails.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
    }
}
