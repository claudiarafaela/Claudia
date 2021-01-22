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
    public class TruckBrandService : ITruckBrandService
    {
        private ITruckBrandRepository truckBrandRepository { get; }
        public TruckBrandService(ITruckBrandRepository repository) {

           this.truckBrandRepository = repository;

        }

        public List<TruckBrandModel> GetTruckBrandCatalog() {

            var data = truckBrandRepository.GetAll();
            List<TruckBrandModel> models = new List<TruckBrandModel>();

            foreach (var row in data)
            {
                models.Add(new TruckBrandModel
                {
                    id = row.Mar_Clave,
                    description = row.Mar_Descripcion,
                    status = row.Mar_Cancelado,
                    type = row.Mar_Tipo,
                    preffix = row.Mar_Prefijo
                });
            }

            return models;
        }

        public int CreateTruckBrand(TruckBrandModel truckBrandModel) {

            TruckBrandEntity truckBrandEntity = new TruckBrandEntity
            {

                Mar_Descripcion = truckBrandModel.description,
                Mar_Cancelado = "N",
                Mar_Tipo = truckBrandModel.type,
                Mar_Prefijo = truckBrandModel.preffix
         
            };

            List <TruckBrandEntity> existingEntity = truckBrandRepository.GetByDescription(truckBrandEntity.Mar_Descripcion);

            if (existingEntity.Count > 0) {
                throw new Exception("Marca ya existente.");
            }

            int result = truckBrandRepository.Insert(truckBrandEntity);

            return result;
        }

        public int UpdateTruckBrand(TruckBrandModel truckBrandModel)
        {

            TruckBrandEntity truckBrandEntity = new TruckBrandEntity
            {
                Mar_Clave = truckBrandModel.id,
                Mar_Descripcion = truckBrandModel.description,
                Mar_Cancelado = "N",
                Mar_Tipo = truckBrandModel.type,
                Mar_Prefijo = truckBrandModel.preffix

            };

            int result = truckBrandRepository.Update(truckBrandEntity);

            return result;
        }

        public int DeleteTruckBrand(int id) {

            TruckBrandEntity truckBrandEntity = truckBrandRepository.GetById(id);

            if (truckBrandEntity == null)
            {
                throw new Exception("Id inexistente.");
            }

            truckBrandEntity.Mar_Cancelado = "S";

            int result = truckBrandRepository.Update(truckBrandEntity);

            return result;

        }


    }
}
