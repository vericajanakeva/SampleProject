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
        public ActionResult Index()
        {
            SampleDatabaseEntities Data = new SampleDatabaseEntities();
            List<Table_1> properties = Data.Table_1.ToList();
            return View(properties);
        }
    }
}