using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBase.Controllers
{
    public class UnitController : Controller
    {
        //GET: Units/getUnits
        public ActionResult GetUnits()
        {
            var unit = new Unit() { Company = 1, WarrantyApplied = false, InDate = new DateTime() };
            
            return View("UnitsReport", unit);
        }
    }
}