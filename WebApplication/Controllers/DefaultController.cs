using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(string search)
        {
            SampleDatabaseEntities Data = new SampleDatabaseEntities();
            var properts = from prop in Data.Table_1 select prop;
            if (!String.IsNullOrEmpty(search))
            {
                properts = properts.Where(prop => prop.Naziv.Contains(search));
            }
            // List < Table_1 > properties = Data.Table_1.ToList();
            // return View(properties);
            return View(properts.ToList());
        }
        public ActionResult Index1()
        {
            SampleDatabaseEntities Data = new SampleDatabaseEntities();
            List<Table_1> properties1 = Data.Table_1.ToList();
            return PartialView("_DisplayData", properties1);
        }
    }
}