using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface ITruckBrandService
    {
        List<TruckBrandModel> GetTruckBrandCatalog();
        int CreateTruckBrand(TruckBrandModel truckBrandModel);
        int UpdateTruckBrand(TruckBrandModel truckBrandModel);
        int DeleteTruckBrand(int id);

    }
    
}
