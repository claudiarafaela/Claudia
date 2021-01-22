using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public interface ITruckTypeRepository : IGenericRepository<TruckTypeEntity>
    {
        List<TruckTypeEntity> GetByDescription(string Description);
    }
}
