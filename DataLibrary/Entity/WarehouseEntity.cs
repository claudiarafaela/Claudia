using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Entity
{
    public class WarehouseEntity
    {
        public int  AAl_Clave { get; set; }
        public string AAl_Almacen { get; set; }
        public string AAl_Direccion1 { get; set; }
        public string AAl_Direccion2 { get; set; }
        public string AAl_Responsable { get; set; }
        public string AAl_Localidad { get; set; }
        public string AAl_PrefijoAlmacen { get; set; }
        public string AAl_Cancelado { get; set; }
        public int AAl_Matriz { get; set; }
        public int AAl_Pla_Clave { get; set; }
        public string AAl_Email { get; set; }
        public int AAl_Mes_Movimientos { get; set; }
        public int AAl_Ano_Movimientos { get; set; }
        public string AAl_TablaExistencias { get; set; }
    }
}
