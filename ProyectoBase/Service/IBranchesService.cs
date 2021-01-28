using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface IBranchesService
    {
        List<BranchesModel> GetBranchesCatalog();
        int CreateBranches(BranchesModel BranchesModel);
        int UpdateBranches(BranchesModel BranchesModel);
        int DeleteBranches(int id);

    }
    
}
