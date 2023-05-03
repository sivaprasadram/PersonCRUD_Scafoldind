using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonCRUD_Scafoldind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TutorialsCS _context = new TutorialsCS();
            var listofData = _context.persons.ToList();
            return View(listofData);

        }
    }
} 

