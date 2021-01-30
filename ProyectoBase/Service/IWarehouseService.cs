using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface IWarehouseService
    {
        List<WarehouseModel> GetWarehouseCatalog();
        int CreateWarehouse(WarehouseModel WarehouseModel);
        int UpdateWarehouse(WarehouseModel WarehouseModel);
        int DeleteWarehouse(int id);

    }
    
}
