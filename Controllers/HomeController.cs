using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace StudentService.Controllers
{
    public class HomeController : Controller
    {
        private StudentServiceEntities db = new StudentServiceEntities();

       

        public ActionResult Index()
        {
            List<Department> Departmentlist = db.Departments.ToList();

            ViewBag.Departmentlist = new SelectList(Departmentlist, "DepartmentCode", "DepartmentName");

            var tasks = db.Tasks.ToList();

            return View(tasks);
        }

        [HttpPost]
        public ActionResult Index(string CourseCode, string Type)
        {
            List<Department> Departmentlist = db.Departments.ToList();
            ViewBag.Departmentlist = new SelectList(Departmentlist, "DepartmentCode", "DepartmentName");

            var courses = db.Tasks.Where(a => a.CourseCode == CourseCode).Where(b => b.Type == Type).ToList();


            return View(courses);

        }
        public JsonResult GetTask(string DepartmentCode)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Course> courselist = db.Courses.Where(x => x.DepartmentCode == DepartmentCode).ToList();

            return Json(courselist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetType(string CourseCode)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Models.Task> types = db.Tasks.Where(x => x.CourseCode == CourseCode).ToList() ;

            
           
           
            return Json(types, JsonRequestBehavior.AllowGet);
           
        }

        public JsonResult Getmaterials(string CourseCode)
        {
            db.Configuration.ProxyCreationEnabled = false;
          
            List<Material> materials = db.Materials.Where(x => x.CourseCode == CourseCode).ToList();


            return Json(materials, JsonRequestBehavior.AllowGet);

        }


        public ActionResult About()
        {
            List<Department> Departmentlist = db.Departments.ToList();
            ViewBag.Departmentlist = new SelectList(Departmentlist, "DepartmentCode", "DepartmentName");
            var courses = db.Courses.ToList();
            return View(courses.ToList());
        }
        [HttpPost]
        public ActionResult About(string CourseCode)
        {
            List<Department> Departmentlist = db.Departments.ToList();
            ViewBag.Departmentlist = new SelectList(Departmentlist, "DepartmentCode", "DepartmentName");

            var courses = db.Courses.Where(a => a.CourseCode == CourseCode).ToList();

            return View(courses);
        }
        public JsonResult GetCourse(string DepartmentCode)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Course> courselist = db.Courses.Where(x => x.DepartmentCode == DepartmentCode).ToList();

            return Json(courselist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetType2(string CourseCode)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Models.Task> types = db.Tasks.Where(x => x.CourseCode == CourseCode).ToList(); ;


            return Json(types, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}