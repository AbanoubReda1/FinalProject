using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace StudentService.Views
{
    public class FiltrController : Controller
    {
        // GET: Filtr
        StudentServiceEntities db = new StudentServiceEntities();

        public ActionResult Index(String deo)
        {
            ViewBag.DepartmentCode = db.Departments.ToList();

            ViewBag.course = db.Courses.Where(a=>a.DepartmentCode== deo).ToList();


            return View();
           
          

        }


    }
}