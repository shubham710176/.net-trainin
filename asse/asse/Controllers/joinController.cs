using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.MobileControls;
using asse.Models;

namespace asse.Controllers
{
    public class joinController : Controller
    {
        // GET: join
        public ActionResult Index()
        {
            dbfirstdemoEntities db = new dbfirstdemoEntities();
            Employeedeparment emp = new Employeedeparment();
             emp.employeedeparments = (from d in db.departments 
                                      join e in db.Employees
                             on d.ID equals e.ID
                             select new Employeedeparment()
                             {
                                 EmployeeFName = e.FirstName,
                                 EmployeelName = e.lastName,
                                  DepartmentName = d.Name,
                                 DepartmentLocation=d.location,
                                 
                               
                             }).ToList();
           
           
                
            
            return View(emp);
        }

        
    }
}