using DataLibrary.Service;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Repository.WarehouseRepository;

namespace ProyectoBase.Controllers
{
    public class WarehouseController : Controller
    {

        private IWarehouseService WarehouseService { get; }
        public WarehouseController(IWarehouseService service)
        {

            this.WarehouseService = service;

        }

        public ActionResult ViewWarehouse()
        {
            ViewBag.Message = "Catalogo de Almacenes";
            List<WarehouseModel> Warehouse = WarehouseService.GetWarehouseCatalog();

            ViewBag.WarehouseCatalog = Warehouse;
            return View();
        }

        public ActionResult RptWarehouse()
        {
            List<WarehouseModel> Warehouse = WarehouseService.GetWarehouseCatalog();

            ViewBag.WarehouseCatalog = Warehouse;

            return PartialView("_ViewWarehousePartial", Warehouse);
        }

        [HttpPost]
        public ActionResult DeleteWarehouse(int id)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = WarehouseService.DeleteWarehouse(id);

            return RedirectToAction("ViewWarehouse");
        }

        //POST:

        [HttpPost]
        public ActionResult AddWarehouse(WarehouseModel Warehouse)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = WarehouseService.CreateWarehouse(Warehouse);

            return RedirectToAction("ViewWarehouse");
        }

        [HttpPost]
        public ActionResult UpdateWarehouse(WarehouseModel Warehouse)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = WarehouseService.UpdateWarehouse(Warehouse);

            return RedirectToAction("ViewWarehouse");
        }



    }
}