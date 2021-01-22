using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Entity
{
    public class TruckBrandEntity
    {

        public int Mar_Clave { get; set; }
        public string Mar_Descripcion { get; set; }
        public string Mar_Cancelado { get; set; }
        public string Mar_Tipo { get; set; }
        public string Mar_Prefijo { get; set; }
        public int id_tipoUso { get; set; }


    }
}
