using DataLibrary.Service;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Repository.TruckBrandRepository;

namespace ProyectoBase.Controllers
{
    public class TruckBrandController : Controller
    {

        private ITruckBrandService truckBrandService { get; }
        public TruckBrandController(ITruckBrandService service)
        {

            this.truckBrandService = service;

        }

        public ActionResult ViewTruckBrands()
        {
            ViewBag.Message = "Catalogo de marcas.";
            List<TruckBrandModel> models = truckBrandService.GetTruckBrandCatalog();

            ViewBag.truckBrandCatalog = models;
            return View();
        }

        public ActionResult RptTruckBrands()
        {
            List<TruckBrandModel> models = truckBrandService.GetTruckBrandCatalog();

            ViewBag.truckBrandCatalog = models;

            return PartialView("_ViewTruckBrandsPartial", models);
        }

        [HttpPost]
        public ActionResult DeleteTruckBrand(int id)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = truckBrandService.DeleteTruckBrand(id);

            return RedirectToAction("ViewTruckBrands");
        }

        //POST:

        [HttpPost]
        public ActionResult AddTruckBrand(TruckBrandModel truckBrand)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = truckBrandService.CreateTruckBrand(truckBrand);

            return RedirectToAction("ViewTruckBrands");
        }

        [HttpPost]
        public ActionResult UpdateTruckBrand(TruckBrandModel truckBrand)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = truckBrandService.UpdateTruckBrand(truckBrand);

            return RedirectToAction("ViewTruckBrands");
        }



    }
}