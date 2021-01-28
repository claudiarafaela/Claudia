using DataLibrary.Service;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Repository.BranchesRepository;

namespace ProyectoBase.Controllers
{
    public class BranchesController : Controller
    {

        private IBranchesService BranchesService { get; }
        public BranchesController(IBranchesService service)
        {

            this.BranchesService = service;

        }

        public ActionResult ViewBranches()
        {
            ViewBag.Message = "Catalogo de Sucursales";
            List<BranchesModel> Branches = BranchesService.GetBranchesCatalog();

            ViewBag.BranchesCatalog = Branches;
            return View();
        }

        public ActionResult RptBranches()
        {
            List<BranchesModel> Branches = BranchesService.GetBranchesCatalog();

            ViewBag.BranchesCatalog = Branches;

            return PartialView("_ViewBranchesPartial", Branches);
        }

        [HttpPost]
        public ActionResult DeleteBranches(int id)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = BranchesService.DeleteBranches(id);

            return RedirectToAction("ViewBranches");
        }

        //POST:

        [HttpPost]
        public ActionResult AddBranches(BranchesModel Branches)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = BranchesService.CreateBranches(Branches);

            return RedirectToAction("ViewBranches");
        }

        [HttpPost]
        public ActionResult UpdateBranches(BranchesModel Branches)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = BranchesService.UpdateBranches(Branches);

            return RedirectToAction("ViewBranches");
        }



    }
}