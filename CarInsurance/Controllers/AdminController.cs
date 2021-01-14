using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin() 
        {
             using (InsuranceEntities db = new InsuranceEntities())
            {
                return View(db.Insurees.ToList());
            }
        }
    }
}