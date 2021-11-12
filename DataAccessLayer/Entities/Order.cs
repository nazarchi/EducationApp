using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.DataAccessLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public int PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public EStatus Status { get; set; }
        public IList<OrderItem>? OrderItems { get; set; }

    }

    
}
