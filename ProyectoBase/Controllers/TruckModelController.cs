using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using PagedList;
using ProyectoBase.Models;
using static DataLibrary.Repository.TruckModelRepository;

namespace ProyectoBase.Controllers
{
    public class TruckModelController : Controller
    {

        //GET: truckModels/viewTruckModels
        public ActionResult ViewTruckModels(int? page, int? pageSize) //Agregamos un nuevo parametro "page" que es la pagina actual
        {                                       //Usar ? nos permite decir que page puede ser NULL
            int pageSizeReal = pageSize ?? 5;
            ViewBag.Message = "Catalogo de modelos.";
            ViewBag.pageSize = pageSizeReal;

            var data = GetAll();
            List<TruckModelsModel> models = new List<TruckModelsModel>();

            foreach(var row in data)
            {
                models.Add(new TruckModelsModel
                {
                    id = row.Mar_Clave,
                    description = row.Mar_Descripcion,
                    status = row.Mar_Cancelado
                });
            }
            int pageNumber = (page ?? 1); // ?? es lo mismo que un operador ternario como ( page != null ? page : 1 )
            return View(models.ToPagedList(pageNumber, pageSizeReal));
        }

        //POST:

        [HttpPost]
        public ActionResult AddTruckModel(TruckModelsModel truckModel)
        { //TODO: Evaluar si es necesaria una validacion de nombre ya existente.
            int recordsCreated = CreateTruckModel(truckModel.description);
            return null;
        }

    }
}
