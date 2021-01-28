using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class BranchesRepository : IBranchesRepository
    {

        public List<BranchesEntity> GetAll()
        {
            string sql = @"SELECT Pla_Clave, Pla_Nombre, Pla_Cancelado, Pla_Restringido FROM dbo.Sis_Plazas WHERE Pla_Cancelado = 'N';";

            return SqlDataAccess.LoadData<BranchesEntity>(sql);
        }

        public int Delete(object Id)
        {
            string sql = @"DELETE FROM dbo.Sis_Plazas WHERE Pla_Clave = " + Id.ToString() + ";";

            return SqlDataAccess.SaveData(sql);
        }

        public BranchesEntity GetById(int Id)
        {
            string sql = @"SELECT Pla_Clave, Pla_Nombre, Pla_Cancelado,Pla_Restringido FROM dbo.Sis_Plazas
            where Pla_Clave = " + Id + ";";

            return SqlDataAccess.LoadData<BranchesEntity>(sql).First();
        }

        public List<BranchesEntity> GetByDescription(string description)
        {
            string sql = @"SELECT Pla_Clave, Pla_Nombre, Pla_Cancelado, Pla_Restringido FROM dbo.Sis_Plazas
            where UPPER(Pla_Nombre) = UPPER('" + description + "');";

            return SqlDataAccess.LoadData<BranchesEntity>(sql);
        }

        public int Insert(BranchesEntity entity)
        {
            string sql = @"INSERT INTO dbo.Sis_Plazas (Pla_Nombre, Pla_Cancelado, Pla_Restringido)
                            values (@Pla_Nombre, @Pla_Cancelado, @Pla_Restringido);";

            return SqlDataAccess.SaveData(sql, entity);
        }

        public int Update(BranchesEntity entity)
        {
            string sql = @"UPDATE dbo.Sis_Plazas SET 
                            Pla_Nombre = @Pla_Nombre,
                            Pla_Cancelado = @Pla_Cancelado,
                            Pla_Restringido = @Pla_Restringido
                         WHERE Pla_Clave = @Pla_Clave;";

            return SqlDataAccess.SaveData(sql, entity);
        }

    }
}
