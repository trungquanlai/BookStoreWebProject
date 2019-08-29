using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public string CookieGUID { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
