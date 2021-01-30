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
    public class WarehouseService : IWarehouseService
    {
        private IWarehouseRepository WarehouseRepository { get; }
        public WarehouseService(IWarehouseRepository repository) {

           this.WarehouseRepository = repository;
        }

        public List<WarehouseModel> GetWarehouseCatalog() {

            var data = WarehouseRepository.GetAll();
            List<WarehouseModel> Warehouse = new List<WarehouseModel>();

            foreach (var row in data)
            {
                Warehouse.Add(new WarehouseModel
                {
                    Id = row.AAl_Clave,
                    Description = row.AAl_Almacen,
                    Direction1 = row.AAl_Direccion1,
                    Direction2 = row.AAl_Direccion2,
                    Responsable = row.AAl_Responsable,
                    City = row.AAl_Localidad,
                    Prefix = row.AAl_PrefijoAlmacen,
                    Status = row.AAl_Cancelado,
                    IsInMainBranch = row.AAl_Matriz,
                    BranchId = row.AAl_Pla_Clave,
                    Email = row.AAl_Email,
                    MonthMovements = row.AAl_Mes_Movimientos,
                    YearMovements = row.AAl_Ano_Movimientos,
                    TableStocks = row.AAl_TablaExistencias
                });
            }

            return Warehouse;
        }

        public int CreateWarehouse(WarehouseModel WarehouseModel) {

            WarehouseEntity WarehouseEntity = new WarehouseEntity
            {
                AAl_Clave = WarehouseModel.Id,
                AAl_Almacen = WarehouseModel.Description,
                AAl_Direccion1 = WarehouseModel.Direction1,
                AAl_Direccion2 = WarehouseModel.Direction2,
                AAl_Responsable = WarehouseModel.Responsable,
                AAl_Localidad = WarehouseModel.City,
                AAl_PrefijoAlmacen = WarehouseModel.Prefix,
                AAl_Cancelado = WarehouseModel.Status,
                AAl_Matriz = WarehouseModel.IsInMainBranch,
                AAl_Pla_Clave = WarehouseModel.BranchId,
                AAl_Email = WarehouseModel.Email,
                AAl_Mes_Movimientos = WarehouseModel.MonthMovements,
                AAl_Ano_Movimientos = WarehouseModel.YearMovements,
                AAl_TablaExistencias = WarehouseModel.TableStocks
            };

            List <WarehouseEntity> existingEntity = WarehouseRepository.GetByDescription(WarehouseEntity.AAl_Almacen);

            if (existingEntity.Count > 0) {
                throw new Exception("Almacen ya existente.");
            }

            int result = WarehouseRepository.Insert(WarehouseEntity);

            return result;
        }

        public int UpdateWarehouse(WarehouseModel WarehouseModel)
        {

            WarehouseEntity WarehouseEntity = new WarehouseEntity
            {
                AAl_Clave = WarehouseModel.Id,
                AAl_Almacen = WarehouseModel.Description,
                AAl_Direccion1 = WarehouseModel.Direction1,
                AAl_Direccion2 = WarehouseModel.Direction2,
                AAl_Responsable = WarehouseModel.Responsable,
                AAl_Localidad = WarehouseModel.City,
                AAl_PrefijoAlmacen = WarehouseModel.Prefix,
                AAl_Cancelado = WarehouseModel.Status,
                AAl_Matriz = WarehouseModel.IsInMainBranch,
                AAl_Pla_Clave = WarehouseModel.BranchId,
                AAl_Email = WarehouseModel.Email,
                AAl_Mes_Movimientos = WarehouseModel.MonthMovements,
                AAl_Ano_Movimientos = WarehouseModel.YearMovements,
                AAl_TablaExistencias = WarehouseModel.TableStocks

            };

            int result = WarehouseRepository.Update(WarehouseEntity);

            return result;
        }

        public int DeleteWarehouse(int id) {

            WarehouseEntity WarehouseEntity = WarehouseRepository.GetById(id);

            if (WarehouseEntity == null)
            {
                throw new Exception("Id inexistente.");
            }

            WarehouseEntity.AAl_Almacen = "S";

            int result = WarehouseRepository.Update(WarehouseEntity);

            return result;

        }


    }
}
