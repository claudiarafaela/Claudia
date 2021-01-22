using DataLibrary.Service;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Repository.TruckTypeRepository;

namespace ProyectoBase.Controllers
{
    public class TruckTypeController : Controller
    {

        private ITruckTypeService TruckTypeService { get; }
        public TruckTypeController(ITruckTypeService service)
        {

            this.TruckTypeService = service;

        }

        public ActionResult ViewTruckType()
        {
            ViewBag.Message = "Catalogo de Tipos de Camiones.";
            List<TruckTypeModel> models = TruckTypeService.GetTruckTypeCatalog();

            ViewBag.TruckTypeCatalog = models;
            return View();
        }

        public ActionResult RptTruckType()
        {
            List<TruckTypeModel> models = TruckTypeService.GetTruckTypeCatalog();

            ViewBag.TruckTypeCatalog = models;

            return PartialView("_ViewTruckTypePartial", models);
        }

        [HttpPost]
        public ActionResult DeleteTruckType(int Id)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = TruckTypeService.DeleteTruckType(Id);

            return RedirectToAction("ViewTruckType");
        }

        //POST:

        [HttpPost]
        public ActionResult AddTruckType(TruckTypeModel TruckType)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = TruckTypeService.CreateTruckType(TruckType);

            return RedirectToAction("ViewTruckType");
        }

        [HttpPost]
        public ActionResult UpdateTruckType(TruckTypeModel TruckType)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = TruckTypeService.UpdateTruckType(TruckType);

            return RedirectToAction("ViewTruckType");
        }



    }
}