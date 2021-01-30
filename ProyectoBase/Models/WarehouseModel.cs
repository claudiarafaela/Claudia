using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBase.Models
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Direction1 { get; set; }
        public string Direction2 { get; set; }
        public string Responsable { get; set; }
        public string City { get; set; }
        public string Prefix { get; set; }
        public string Status { get; set; }
        public int IsInMainBranch { get; set; }
        public int BranchId { get; set; }
        public string Email { get; set; }
        public int MonthMovements { get; set; }
        public int YearMovements { get; set; }
        public string TableStocks { get; set; }
    }
}