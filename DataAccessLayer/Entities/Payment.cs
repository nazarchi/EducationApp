using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.DataAccessLayer.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public Order? Order { get; set; }
    }
}
