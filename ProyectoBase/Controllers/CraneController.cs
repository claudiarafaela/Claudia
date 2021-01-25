using DataLibrary.Service;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Repository.CraneRepository;

namespace ProyectoBase.Controllers
{
    public class CraneController : Controller
    {

        private ICraneService CraneService { get; }
        public CraneController(ICraneService service)
        {

            this.CraneService = service;

        }

        public ActionResult ViewCrane()
        {
            ViewBag.Message = "Catalogo de gruas.";
            List<CraneModel> Crane = CraneService.GetCraneCatalog();

            ViewBag.CraneCatalog = Crane;
            return View();
        }

        public ActionResult RptCrane()
        {
            List<CraneModel> Crane = CraneService.GetCraneCatalog();

            ViewBag.CraneCatalog = Crane;

            return PartialView("_ViewCranePartial", Crane);
        }

        [HttpPost]
        public ActionResult DeleteCrane(int id)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = CraneService.DeleteCrane(id);

            return RedirectToAction("ViewCrane");
        }

        //POST:

        [HttpPost]
        public ActionResult AddCrane(CraneModel Crane)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = CraneService.CreateCrane(Crane);

            return RedirectToAction("ViewCrane");
        }

        [HttpPost]
        public ActionResult UpdateCrane(CraneModel Crane)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = CraneService.UpdateCrane(Crane);

            return RedirectToAction("ViewCrane");
        }



    }
}