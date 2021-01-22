using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public static class TruckModelRepository
    {

        public static int CreateTruckModel(string description)
        {
            TruckModelsEntity data = new TruckModelsEntity
            {
                Mar_Descripcion = description,
                Mar_Cancelado = "N"
            };

            string sql = @"INSERT INTO dbo.Alm_Modelos (Mar_Descripcion, Mar_Cancelado)
                            values (@Mar_Descripcion, @Mar_Cancelado);";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<TruckModelsEntity> GetAll()
        {
            string sql = @"SELECT Mar_Clave, Mar_Descripcion, Mar_Cancelado FROM dbo.Alm_Modelos;";

            return SqlDataAccess.LoadData<TruckModelsEntity>(sql);
        }

    }
}
