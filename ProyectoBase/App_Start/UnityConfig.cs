using DataLibrary.Repository;
using DataLibrary.Service;
using DataLibrary.Service.Impl;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ProyectoBase
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ITruckBrandRepository, TruckBrandRepository>();
            container.RegisterType<ITruckBrandService, TruckBrandService>();

            container.RegisterType<ITruckTypeRepository, TruckTypeRepository>();
            container.RegisterType<ITruckTypeService, TruckTypeService>();

            container.RegisterType<ICraneRepository, CraneRepository>();
            container.RegisterType<ICraneService, CraneService>();

            container.RegisterType<IBranchesRepository, BranchesRepository>();
            container.RegisterType<IBranchesService, BranchesService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}