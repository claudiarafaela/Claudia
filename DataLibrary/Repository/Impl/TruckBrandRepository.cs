using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class TruckBrandRepository : ITruckBrandRepository
    {

        public List<TruckBrandEntity> GetAll()
        {
            string sql = @"SELECT Mar_Clave, Mar_Descripcion, Mar_Cancelado, Mar_Tipo, Mar_Prefijo, id_tipoUso FROM dbo.Alm_Marcas WHERE Mar_Cancelado = 'N';";

            return SqlDataAccess.LoadData<TruckBrandEntity>(sql);
        }

        public int Delete(object Id)
        {
            string sql = @"DELETE FROM dbo.Alm_Marcas WHERE Mar_Clave = " + Id.ToString() + ";";

            return SqlDataAccess.SaveData(sql);
        }

        public TruckBrandEntity GetById(int Id)
        {
            string sql = @"SELECT Mar_Clave, Mar_Descripcion, Mar_Cancelado, Mar_Tipo, Mar_Prefijo, id_tipoUso FROM dbo.Alm_Marcas
            where Mar_Clave = " + Id + ";";

            return SqlDataAccess.LoadData<TruckBrandEntity>(sql).First();
        }

        public List<TruckBrandEntity> GetByDescription(string description)
        {
            string sql = @"SELECT Mar_Clave, Mar_Descripcion, Mar_Cancelado, Mar_Tipo, Mar_Prefijo, id_tipoUso FROM dbo.Alm_Marcas
            where UPPER(Mar_Descripcion) = UPPER('" + description + "');";

            return SqlDataAccess.LoadData<TruckBrandEntity>(sql);
        }

        public int Insert(TruckBrandEntity entity)
        {
            string sql = @"INSERT INTO dbo.Alm_Marcas (Mar_Descripcion, Mar_Cancelado, Mar_Tipo, Mar_Prefijo)
                            values (@Mar_Descripcion, @Mar_Cancelado, @Mar_Tipo, @Mar_Prefijo);";

            return SqlDataAccess.SaveData(sql, entity);
        }

        public int Update(TruckBrandEntity entity)
        {
            string sql = @"UPDATE dbo.Alm_Marcas SET 
                            Mar_Descripcion = @Mar_Descripcion,
                            Mar_Cancelado = @Mar_Cancelado,
                            Mar_Tipo = @Mar_Tipo,
                            Mar_Prefijo = @Mar_Prefijo
                         WHERE Mar_Clave = @Mar_Clave;";

            return SqlDataAccess.SaveData(sql, entity);
        }

    }
}
