using DataLibrary.DataAccess;
using DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class WarehouseRepository : IWarehouseRepository
    {

        public List<WarehouseEntity> GetAll()
        {
            string sql = @"SELECT AAl_Clave,
                            AAl_Almacen,
                            AAl_Direccion1,
                            AAl_Direccion2,
                            AAl_Responsable,
                            AAl_Localidad,
                            AAl_PrefijoAlmacen,
                            AAl_Cancelado,
                            AAl_Matriz,
                            AAl_Pla_Clave,
                            AAl_Email,
                            AAl_Mes_Movimientos,
                            AAl_Ano_Movimientos,
                            AAl_TablaExistencias
                        FROM dbo.Alm_Almacenes 
                        WHERE AAl_Localidad = 'N';";

            return SqlDataAccess.LoadData<WarehouseEntity>(sql);
        }

        public int Delete(object Id)
        {
            string sql = @"DELETE FROM dbo.Alm_Almacenes WHERE AAl_Clave = " + Id.ToString() + ";";

            return SqlDataAccess.SaveData(sql);
        }

        public WarehouseEntity GetById(int Id)
        {
            string sql = @"SELECT AAl_Clave,
                            AAl_Almacen,
                            AAl_Direccion1,
                            AAl_Direccion2,
                            AAl_Responsable,
                            AAl_Localidad,
                            AAl_PrefijoAlmacen,
                            AAl_Cancelado,
                            AAl_Matriz,
                            AAl_Pla_Clave,
                            AAl_Email,
                            AAl_Mes_Movimientos,
                            AAl_Ano_Movimientos,
                            AAl_TablaExistencias
                        FROM dbo.Alm_Almacenes
                        WHERE AAl_Clave = " + Id + ";";

            return SqlDataAccess.LoadData<WarehouseEntity>(sql).First();
        }

        public List<WarehouseEntity> GetByDescription(string description)
        {
            string sql = @"SELECT AAl_Clave,
                            AAl_Almacen,
                            AAl_Direccion1,
                            AAl_Direccion2,
                            AAl_Responsable,
                            AAl_Localidad,
                            AAl_PrefijoAlmacen,
                            AAl_Cancelado,
                            AAl_Matriz,
                            AAl_Pla_Clave,
                            AAl_Email,
                            AAl_Mes_Movimientos,
                            AAl_Ano_Movimientos,
                            AAl_TablaExistencias 
                        FROM dbo.Alm_Almacenes
                        WHERE UPPER(AAl_Almacen) = UPPER('" + description + "');";

            return SqlDataAccess.LoadData<WarehouseEntity>(sql);
        }

        public int Insert(WarehouseEntity entity)
        {
            string sql = @"INSERT INTO dbo.Alm_Almacenes (AAl_Almacen,
                              AAl_Direccion1,
                              AAl_Direccion2,
                              AAl_Responsable,
                              AAl_Localidad,
                              AAl_PrefijoAlmacen,
                              AAl_Cancelado,
                              AAl_Matriz,
                              AAl_Pla_Clave,
                              AAl_Email,
                              AAl_Mes_Movimientos,
                              AAl_Ano_Movimientos,
                              AAl_TablaExistencias)
                            VALUES (@AAl_Almacen,                        
                                @AAl_Direccion1,
                                @AAl_Direccion2,
                                @AAl_Responsable,
                                @AAl_Localidad,
                                @AAl_PrefijoAlmacen,
                                @AAl_Cancelado,
                                @AAl_Matriz,
                                @AAl_Pla_Clave,
                                @AAl_Email,
                                @AAl_Mes_Movimientos,
                                @AAl_Ano_Movimientos,
                                @AAl_TablaExistencias);";

            return SqlDataAccess.SaveData(sql, entity);
        }

        public int Update(WarehouseEntity entity)
        {
            string sql = @"UPDATE dbo.Alm_Almacenes 
                            SET AAl_Almacen = @AAl_Almacen,
                                AAl_Direccion1 @AAl_Direccion1,
                                AAl_Direccion2 @AAl_Direccion2,
                                AAl_Responsable @AAl_Responsable,
                                AAl_Localidad @AAl_Localidad,
                                AAl_PrefijoAlmacen @AAl_PrefijoAlmacen,
                                AAl_Cancelado @AAl_Cancelado,
                                AAl_Matriz @AAl_Matriz,
                                AAl_Pla_Clave @AAl_Pla_Clave,
                                AAl_Email @AAl_Email,
                                AAl_Mes_Movimientos @AAl_Mes_Movimientos,
                                AAl_Ano_Movimientos @AAl_Ano_Movimientos,
                                AAl_TablaExistencias @AAl_TablaExistencias
                         WHERE AAl_Clave = @AAl_Clave;";

            return SqlDataAccess.SaveData(sql, entity);
        }

    }
}
