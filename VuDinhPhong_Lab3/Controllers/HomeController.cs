using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VuDinhPhong_Lab3.Models;
using System.Data.Entity;
namespace VuDinhPhong_Lab3.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        private ApplicationDbContext _dbContext;

        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            return View(upcommingCourses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}