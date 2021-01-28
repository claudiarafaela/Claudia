using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBase.Models
{
    public class BranchesModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Restricted { get; set; }
        
    }
}