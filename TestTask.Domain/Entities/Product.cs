using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProduceDate { get; set; }

        //public string ManufacturePhone { get; set; }    // this filed related to Manufacturer entity and exist there
        //public string ManufactureEmail { get; set; }    // this filed related to Manufacturer entity and exist there
        public bool IsAvailable { get; set; }
        public string ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
