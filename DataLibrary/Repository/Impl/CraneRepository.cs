using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class CraneRepository : ICraneRepository
    {

        public List<CraneEntity> GetAll()
        {
            string sql = @"SELECT Gru_Clave, Gru_Descripcion, Gru_Cancelado FROM dbo.Cot_Gruas WHERE Gru_Cancelado = 'N';";

            return SqlDataAccess.LoadData<CraneEntity>(sql);
        }

        public int Delete(object Id)
        {
            string sql = @"DELETE FROM dbo.Cot_Gruas WHERE Gru_Clave = " + Id.ToString() + ";";

            return SqlDataAccess.SaveData(sql);
        }

        public CraneEntity GetById(int Id)
        {
            string sql = @"SELECT Gru_Clave, Gru_Descripcion, Gru_Cancelado FROM dbo.Cot_Gruas
            where Gru_Clave = " + Id + ";";

            return SqlDataAccess.LoadData<CraneEntity>(sql).First();
        }

        public List<CraneEntity> GetByDescription(string Description)
        {
            string sql = @"SELECT Gru_Clave, Gru_Descripcion, Gru_Cancelado FROM dbo.Cot_Gruas
            where UPPER(Gru_Descripcion) = UPPER('" + Description + "');";

            return SqlDataAccess.LoadData<CraneEntity>(sql);
        }

        public int Insert(CraneEntity entity)
        {
            string sql = @"INSERT INTO dbo.Cot_Gruas (Gru_Descripcion, Gru_Cancelado)
                            values (@Gru_Descripcion, @Gru_Cancelado);";

            return SqlDataAccess.SaveData(sql, entity);
        }

        public int Update(CraneEntity entity)
        {
            string sql = @"UPDATE dbo.Cot_Gruas SET 
                            Gru_Descripcion = @Gru_Descripcion,
                            Gru_Cancelado = @Gru_Cancelado
                         WHERE Gru_Clave = @Gru_Clave;";

            return SqlDataAccess.SaveData(sql, entity);
        }

    }
}
