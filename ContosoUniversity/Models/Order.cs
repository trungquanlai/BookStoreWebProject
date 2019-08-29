using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Order
    {
        public int ID { get; set; }
        public double SubTotal { get; set; }
        public double GST { get; set; }
        public double GrandTotal { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-DD}", ApplyFormatInEditMode =true)]
        public DateTime ShippingDate { get; set; }
        public int Quantity { get; set; }

        public Account Account { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
