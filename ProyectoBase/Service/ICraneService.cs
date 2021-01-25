using DataLibrary.Repository;
using ProyectoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface ICraneService
    {
        List<CraneModel> GetCraneCatalog();
        int CreateCrane(CraneModel CraneModel);
        int UpdateCrane(CraneModel CraneModel);
        int DeleteCrane(int id);

    }
    
}
