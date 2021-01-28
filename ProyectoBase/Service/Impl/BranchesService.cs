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
    public class BranchesService : IBranchesService
    {
        private IBranchesRepository BranchesRepository { get; }
        public BranchesService(IBranchesRepository repository) {

           this.BranchesRepository = repository;

        }

        public List<BranchesModel> GetBranchesCatalog() {

            var data = BranchesRepository.GetAll();
            List<BranchesModel> Branches = new List<BranchesModel>();

            foreach (var row in data)
            {
                Branches.Add(new BranchesModel
                {
                    Id = row.Pla_Clave,
                    Description = row.Pla_Nombre,
                    Status = row.Pla_Cancelado,
                    Restricted = row.Pla_Restringido
                });
            }

            return Branches;
        }

        public int CreateBranches(BranchesModel BranchesModel) {

            BranchesEntity BranchesEntity = new BranchesEntity
            {

                Pla_Nombre = BranchesModel.Description,
                Pla_Cancelado = "N",
                Pla_Restringido = BranchesModel.Restricted
            };

            List <BranchesEntity> existingEntity = BranchesRepository.GetByDescription(BranchesEntity.Pla_Nombre);

            if (existingEntity.Count > 0) {
                throw new Exception("Plaza ya existente.");
            }

            int result = BranchesRepository.Insert(BranchesEntity);

            return result;
        }

        public int UpdateBranches(BranchesModel BranchesModel)
        {

            BranchesEntity BranchesEntity = new BranchesEntity
            {
                Pla_Clave = BranchesModel.Id,
                Pla_Nombre = BranchesModel.Description,
                Pla_Cancelado = "N",
                Pla_Restringido = BranchesModel.Restricted
            };

            int result = BranchesRepository.Update(BranchesEntity);

            return result;
        }

        public int DeleteBranches(int id) {

            BranchesEntity BranchesEntity = BranchesRepository.GetById(id);

            if (BranchesEntity == null)
            {
                throw new Exception("Id inexistente.");
            }

            BranchesEntity.Pla_Cancelado = "S";

            int result = BranchesRepository.Update(BranchesEntity);

            return result;

        }


    }
}
