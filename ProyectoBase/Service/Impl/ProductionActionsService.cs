using DataLibrary.Entity;
using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service.Impl
{
    public class ProductionActionsService : IProductionActionsService
    {
        private IProductionActionsRepository ProductionActionsRepository { get; }
        public ProductionActionsService(IProductionActionsRepository repository) {

           this.ProductionActionsRepository = repository;

        }

        public List<ProductionActionsModel> GetProductionActionsCatalog() {

            var data = ProductionActionsRepository.GetAll();
            List<ProductionActionsModel> ProductionActions = new List<ProductionActionsModel>();

            foreach (var row in data)
            {
                ProductionActions.Add(new ProductionActionsModel
                {
                    Id = row.Acc_Clave,
                    Description = row.Acc_Descripcion,
                    Status = row.Acc_Cancelado
                });
            }

            return ProductionActions;
        }

        public int CreateProductionActions(ProductionActionsModel ProductionActions) {

            ProductionActionsEntity ProductionActionsEntity = new ProductionActionsEntity
            {

                Acc_Descripcion = ProductionActions.Description,
                Acc_Cancelado = "N"
            };

            List <ProductionActionsEntity> existingEntity = ProductionActionsRepository.GetByDescription(ProductionActionsEntity.Acc_Descripcion);

            if (existingEntity.Count > 0) {
                throw new Exception("Accion ya existente.");
            }

            int result = ProductionActionsRepository.Insert(ProductionActionsEntity);

            return result;
        }

        public int UpdateProductionActions(ProductionActionsModel ProductionActions)
        {

            ProductionActionsEntity ProductionActionsEntity = new ProductionActionsEntity
            {
                Acc_Clave = ProductionActions.Id,
                Acc_Descripcion = ProductionActions.Description,
                Acc_Cancelado = "N"
            };

            int result = ProductionActionsRepository.Update(ProductionActionsEntity);

            return result;
        }

        public int DeleteProductionActions(int id) {

            ProductionActionsEntity ProductionActionsEntity = ProductionActionsRepository.GetById(id);

            if (ProductionActionsEntity == null)
            {
                throw new Exception("Id inexistente.");
            }

            ProductionActionsEntity.Acc_Cancelado = "S";

            int result = ProductionActionsRepository.Update(ProductionActionsEntity);

            return result;

        }


    }
}
