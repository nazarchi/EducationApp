using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.DataAccessLayer.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int PrintingEditionId { get; set; }
        public PrintingEdition? PrintingEdition { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int Amount { get; set; }
        public int Count { get; set; }
        public string? Currency { get; set; }
    }
}
