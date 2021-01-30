using DataLibrary.Repository;
using DataLibrary.Service;
using DataLibrary.Service.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddArquitecture(this IServiceCollection services) {

            services.AddTransient<ITruckBrandRepository, TruckBrandRepository>();

            services.AddTransient<ITruckBrandService, TruckBrandService>();


            services.AddTransient<ITruckTypeRepository, TruckTypeRepository>();

            services.AddTransient<ITruckTypeService, TruckTypeService>();


            services.AddTransient<ICraneRepository, CraneRepository>();

            services.AddTransient<ICraneService, CraneService>();


            services.AddTransient<IBranchesRepository, BranchesRepository>();

            services.AddTransient<IBranchesService, BranchesService>();

            services.AddTransient<IProductionActionsRepository, ProductionActionsRepository>();

            services.AddTransient<IProductionActionsService, ProductionActionsService>();

            return services;
        }

    }
}
