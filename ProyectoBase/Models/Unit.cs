using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBase.Models
{
    public class Unit
    {
        public int Company { get; set; }
        public bool WarrantyApplied { get; set; }
        public DateTime InDate { get; set; }
    }
}