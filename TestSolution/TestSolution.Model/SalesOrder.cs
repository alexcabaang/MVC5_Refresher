using System;
using System.ComponentModel.DataAnnotations;

namespace TestSolution.Model
{
    public class SalesOrder
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PoNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}