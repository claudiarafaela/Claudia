using DataLibrary.Service;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Repository.ProductionActionsRepository;

namespace ProyectoBase.Controllers
{
    public class ProductionActionsController : Controller
    {

        private IProductionActionsService ProductionActionsService { get; }
        public ProductionActionsController(IProductionActionsService service)
        {

            this.ProductionActionsService = service;

        }

        public ActionResult ViewProductionActions()
        {
            ViewBag.Message = "Catalogo de Acciones de Producción";
            List<ProductionActionsModel> ProductionActions = ProductionActionsService.GetProductionActionsCatalog();

            ViewBag.ProductionActionsCatalog = ProductionActions;
            return View();
        }

        public ActionResult RptProductionActions()
        {
            List<ProductionActionsModel> ProductionActions = ProductionActionsService.GetProductionActionsCatalog();

            ViewBag.ProductionActionsCatalog = ProductionActions;

            return PartialView("_ViewProductionActionsPartial", ProductionActions);
        }

        [HttpPost]
        public ActionResult DeleteProductionActions(int id)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = ProductionActionsService.DeleteProductionActions(id);

            return RedirectToAction("ViewProductionActions");
        }

        //POST:

        [HttpPost]
        public ActionResult AddProductionActions(ProductionActionsModel ProductionActions)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = ProductionActionsService.CreateProductionActions(ProductionActions);

            return RedirectToAction("ViewProductionActions");
        }

        [HttpPost]
        public ActionResult UpdateProductionActions(ProductionActionsModel ProductionActions)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = ProductionActionsService.UpdateProductionActions(ProductionActions);

            return RedirectToAction("ViewProductionActions");
        }



    }
}