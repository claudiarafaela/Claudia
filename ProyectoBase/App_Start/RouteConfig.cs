using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoBase
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
        //PRIMARIO
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //RUTEOS

            //TRUCKBRAND
            routes.MapRoute(
                "AddTruckBrand",
                "truckBrands/addTruckBrand",
                new { controller = "TruckBrand", action = "AddTruckBrand" }
            );
            routes.MapRoute(
                "UpdateTruckBrand",
                "truckBrands/updateTruckBrand",
                new { controller = "TruckBrand", action = "UpdateTruckBrand" }
            );
            routes.MapRoute(
                "DeleteTruckBrand",
                "truckBrands/deleteTruckBrand",
                new { controller = "TruckBrand", action = "DeleteTruckBrand" }
            );
            routes.MapRoute(
                "ViewTruckBrands",
                "truckBrands/viewTruckBrands",
                new { controller = "TruckBrand", action = "ViewTruckBrands" }
            );
            routes.MapRoute(
                "RptTruckBrands",
                "truckBrands/rptTruckBrands",
                new { controller = "TruckBrand", action = "RptTruckBrands" }
            );


            //TRUCKTYPE
            routes.MapRoute(
                "AddTruckType",
                "TruckTypeController/addTruckType",
                new { controller = "TruckType", action = "AddTruckType" }
            );
            routes.MapRoute(
                "UpdateTruckType",
                "TruckTypeController/UpdateTruckType",
                new { controller = "TruckType", action = "UpdateTruckType" }
            );
            routes.MapRoute(
                "DeleteTruckType",
                "TruckTypeController/DeleteTruckType",
                new { controller = "TruckType", action = "DeleteTruckType" }
            );
            routes.MapRoute(
                "ViewTruckType",
                "TruckTypeController/ViewTruckType",
                new { controller = "TruckType", action = "ViewTruckType" }
            );
            routes.MapRoute(
                "RptTruckType",
                "TruckTypeController/RptTruckType",
                new { controller = "TruckType", action = "RptTruckType" }
            );


            //CRANE
            routes.MapRoute(
                "AddCrane",
                "CraneController/AddCrane",
                new { controller = "Crane", action = "AddCrane" }
            );
            routes.MapRoute(
                "UpdateCrane",
                "CraneController/UpdateCrane",
                new { controller = "Crane", action = "UpdateCrane" }
            );
            routes.MapRoute(
                "DeleteCrane",
                "CraneController/DeleteCrane",
                new { controller = "Crane", action = "DeleteCrane" }
            );
            routes.MapRoute(
                "ViewCrane",
                "CraneController/ViewTruckCrane",
                new { controller = "Crane", action = "ViewCrane" }
            );
            routes.MapRoute(
                "RptCrane",
                "CraneController/RptCrane",
                new { controller = "Crane", action = "RptCrane" }
            );



            //TRUCKMODEL
            routes.MapRoute(
                "AddTruckModel",
                "truckModels/addTruckModel",
                new { controller = "TruckModel", action = "AddTruckModel" }
            );

            routes.MapRoute(
                "ViewTruckModels",
                "truckModels/viewTruckModels",
                new { controller = "TruckModel", action = "ViewTruckModels" }
            );

            routes.MapRoute(
                "GetUnits",
                "units/getUnits",
                new { controller = "Unit", action = "GetUnits" }
            );


        //DEFAULT
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
