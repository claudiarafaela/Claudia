using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface ITruckTypeService
    {
        List<TruckTypeModel> GetTruckTypeCatalog();
        int CreateTruckType(TruckTypeModel TruckTypeModel);
        int UpdateTruckType(TruckTypeModel TruckTypeModel);
        int DeleteTruckType(int id);

    }
    
}
