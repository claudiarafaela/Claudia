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
    public class TruckTypeService : ITruckTypeService
    {
        private ITruckTypeRepository TruckTypeRepository { get; }
        public TruckTypeService(ITruckTypeRepository repository) {

           this.TruckTypeRepository = repository;

        }

        public List<TruckTypeModel> GetTruckTypeCatalog() {

            var data = TruckTypeRepository.GetAll();
            List<TruckTypeModel> models = new List<TruckTypeModel>();

            foreach (var row in data)
            {
                models.Add(new TruckTypeModel
                {
                    Id = row.TU_Clave,
                    Description = row.TU_Descripcion,
                    Preffix = row.TU_Prefijo,
                    Cancel = row.TU_Cancelado
                });
            }

            return models;
        }

        public int CreateTruckType(TruckTypeModel TruckTypeModel) {

            TruckTypeEntity TruckTypeEntity = new TruckTypeEntity
            {

                TU_Descripcion = TruckTypeModel.Description,
                TU_Prefijo = TruckTypeModel.Preffix,
                TU_Cancelado = "N"
                
            };

            List <TruckTypeEntity> existingEntity = TruckTypeRepository.GetByDescription(TruckTypeEntity.TU_Descripcion);

            if (existingEntity.Count > 0) {
                throw new Exception("Tipo de Camión ya existente");
            }

            int result = TruckTypeRepository.Insert(TruckTypeEntity);

            return result;
        }

        public int UpdateTruckType(TruckTypeModel TruckTypeModel)
        {

            TruckTypeEntity TruckTypeEntity = new TruckTypeEntity
            {
                TU_Clave = TruckTypeModel.Id,
                TU_Descripcion = TruckTypeModel.Description,
                TU_Prefijo = TruckTypeModel.Preffix,
                TU_Cancelado = "N"
            };

            int result = TruckTypeRepository.Update(TruckTypeEntity);

            return result;
        }

        public int DeleteTruckType(int Id) {

            TruckTypeEntity TruckTypeEntity = TruckTypeRepository.GetById(Id);

            if (TruckTypeEntity == null)
            {
                throw new Exception("Id inexistente.");
            }

            TruckTypeEntity.TU_Cancelado = "S";

            int result = TruckTypeRepository.Update(TruckTypeEntity);

            return result;

        }


    }
}
