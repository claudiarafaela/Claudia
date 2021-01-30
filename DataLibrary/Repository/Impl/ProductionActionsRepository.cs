using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class ProductionActionsRepository : IProductionActionsRepository
    {

        public List<ProductionActionsEntity> GetAll()
        {
            string sql = @"SELECT Acc_Clave, Acc_Descripcion, Acc_Cancelado FROM dbo.Cot_Acciones WHERE Acc_Cancelado = 'N';";

            return SqlDataAccess.LoadData<ProductionActionsEntity>(sql);
        }

        public int Delete(object Id)
        {
            string sql = @"DELETE FROM dbo.Cot_Acciones WHERE Acc_Clave = " + Id.ToString() + ";";

            return SqlDataAccess.SaveData(sql);
        }

        public ProductionActionsEntity GetById(int Id)
        {
            string sql = @"SELECT Acc_Clave, Acc_Descripcion, Acc_Cancelado FROM dbo.Cot_Acciones
            where Acc_Clave = " + Id + ";";

            return SqlDataAccess.LoadData<ProductionActionsEntity>(sql).First();
        }

        public List<ProductionActionsEntity> GetByDescription(string description)
        {
            string sql = @"SELECT Acc_Clave, Acc_Descripcion, Acc_Cancelado 
                            FROM dbo.Cot_Acciones
                            WHERE UPPER(Acc_Descripcion) = UPPER('" + description + "');";

            return SqlDataAccess.LoadData<ProductionActionsEntity>(sql);
        }

        public int Insert(ProductionActionsEntity entity)
        {
            string sql = @"INSERT INTO dbo.Cot_Acciones (Acc_Descripcion, Acc_Cancelado)
                            VALUES (@Acc_Descripcion, @Acc_Cancelado);";

            return SqlDataAccess.SaveData(sql, entity);
        }

        public int Update(ProductionActionsEntity entity)
        {
            string sql = @"UPDATE dbo.Cot_Acciones SET 
                                Acc_Descripcion = @Acc_Descripcion,
                                Acc_Cancelado = @Acc_Cancelado
                            WHERE Acc_Clave = @Acc_Clave;";

            return SqlDataAccess.SaveData(sql, entity);
        }

    }
}
