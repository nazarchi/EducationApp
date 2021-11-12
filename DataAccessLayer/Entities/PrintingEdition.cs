using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.DataAccessLayer.Entities
{
    public class PrintingEdition
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public bool? IsRemoved { get; set; }
        public EType Types { get; set; }
        public ECurrency Currency { get; set; }
        public IList<AuthorInPrintingEdition>? AuthorInPrintingEditions { get; set; }
        public IList<OrderItem>? OrderItems { get; set; }



    }
}
