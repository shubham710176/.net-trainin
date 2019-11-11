using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cascad.Models;

namespace cascad.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           dbfirstdemoEntities entity = new dbfirstdemoEntities();
            ViewBag.Countries = new SelectList(GetCountries(), "ID", "Name");
            return View();
        }

        public List<tblCountry> GetCountries()
        {
            dbfirstdemoEntities entity = new dbfirstdemoEntities();
            List<tblCountry> countries = entity.tblCountries.ToList();
            return countries;
        }

        public ActionResult GetStates(int cid)
        {
            dbfirstdemoEntities entity = new dbfirstdemoEntities();
            List<tblstates2> states = entity.tblstates2.Where(x => x.coun_id1 == cid).ToList();
            ViewBag.States = new SelectList(states, "coun_id1", "states1");
            return PartialView("GetStates");
        }
    }
}