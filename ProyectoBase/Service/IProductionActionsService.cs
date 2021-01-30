using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface IProductionActionsService
    {
        List<ProductionActionsModel> GetProductionActionsCatalog();
        int CreateProductionActions(ProductionActionsModel ProductionActions);
        int UpdateProductionActions(ProductionActionsModel ProductionActions);
        int DeleteProductionActions(int Id);

    }
    
}
