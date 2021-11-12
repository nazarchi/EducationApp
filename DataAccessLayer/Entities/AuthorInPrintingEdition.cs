using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.DataAccessLayer.Entities
{
    public class AuthorInPrintingEdition
    {
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        public int PrintingEditionId { get; set; }
        public PrintingEdition? PrintingEdition { get; set; }

        /// нахуя дата тут???
        public DateTime Date { get; set; }
    }
}
