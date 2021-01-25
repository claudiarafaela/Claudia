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
    public class CraneService : ICraneService
    {
        private ICraneRepository CraneRepository { get; }
        public CraneService(ICraneRepository repository) {

           this.CraneRepository = repository;

        }

        public List<CraneModel> GetCraneCatalog() {

            var data = CraneRepository.GetAll();
            List<CraneModel> Crane = new List<CraneModel>();

            foreach (var row in data)
            {
                Crane.Add(new CraneModel
                {
                    Id = row.Gru_Clave,
                    Description = row.Gru_Descripcion,
                    Status = row.Gru_Cancelado
                });
            }

            return Crane;
        }

        public int CreateCrane(CraneModel CraneModel) {

            CraneEntity CraneEntity = new CraneEntity
            {

                Gru_Descripcion = CraneModel.Description,
                Gru_Cancelado = "N"
            };

            List <CraneEntity> existingEntity = CraneRepository.GetByDescription(CraneEntity.Gru_Descripcion);

            if (existingEntity.Count > 0) {
                throw new Exception("Grua ya existente.");
            }

            int result = CraneRepository.Insert(CraneEntity);

            return result;
        }

        public int UpdateCrane(CraneModel CraneModel)
        {

            CraneEntity CraneEntity = new CraneEntity
            {
                Gru_Clave = CraneModel.Id,
                Gru_Descripcion = CraneModel.Description,
                Gru_Cancelado = "N"
            };

            int result = CraneRepository.Update(CraneEntity);

            return result;
        }

        public int DeleteCrane(int id) {

            CraneEntity CraneEntity = CraneRepository.GetById(id);

            if (CraneEntity == null)
            {
                throw new Exception("Id inexistente.");
            }

            CraneEntity.Gru_Cancelado = "S";

            int result = CraneRepository.Update(CraneEntity);

            return result;

        }


    }
}
