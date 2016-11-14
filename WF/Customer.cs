using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int Cnum { get; set; }
        //[MaxLength(30)]
        public string Cname { get; set; }
        //[MaxLength(30)]
        public string City { get; set; }
        public int Rating { get; set; }


        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
