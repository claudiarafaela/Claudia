using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class TruckTypeRepository : ITruckTypeRepository
    {

        public List<TruckTypeEntity> GetAll()
        {
            string sql = @"SELECT TU_Clave, TU_Descripcion, TU_Prefijo, TU_Cancelado FROM dbo.Cot_TipoUnidad WHERE TU_Cancelado = 'N';";

            return SqlDataAccess.LoadData<TruckTypeEntity>(sql);
        }

        public int Delete(object Id)
        {
            string sql = @"DELETE FROM dbo.Cot_TipoUnidad WHERE TU_Clave = " + Id.ToString() + ";";

            return SqlDataAccess.SaveData(sql);
        }

        public TruckTypeEntity GetById(int Id)
        {
            string sql = @"SELECT TU_Clave, TU_Descripcion, TU_Prefijo, TU_Cancelado FROM dbo.Cot_TipoUnidad
            where TU_Clave = " + Id + ";";

            return SqlDataAccess.LoadData<TruckTypeEntity>(sql).First();
        }

        public List<TruckTypeEntity> GetByDescription(string Description)
        {
            string sql = @"SELECT TU_Clave, TU_Descripcion,  TU_Prefijo, TU_Cancelado FROM dbo.Cot_TipoUnidad
            where UPPER(TU_Descripcion) = UPPER('" + Description + "');";

            return SqlDataAccess.LoadData<TruckTypeEntity>(sql);
        }

        public int Insert(TruckTypeEntity entity)
        {
            string sql = @"INSERT INTO dbo.Cot_TipoUnidad (TU_Descripcion, TU_Prefijo, TU_Cancelado)
                            values (@TU_Descripcion, @TU_Prefijo, @TU_Cancelado);";

            return SqlDataAccess.SaveData(sql, entity);
        }

        public int Update(TruckTypeEntity entity)
        {
            string sql = @"UPDATE dbo.Cot_TipoUnidad SET 
                            TU_Descripcion = @TU_Descripcion,
                            TU_Prefijo = @TU_Prefijo,
                            TU_Cancelado = @TU_Cancelado
                         WHERE TU_Clave = @TU_Clave;";

            return SqlDataAccess.SaveData(sql, entity);
        }

    }
}
