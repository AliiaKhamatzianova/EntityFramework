using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF
{
    public class SalesPeople
    {
        [Key]
        public int Snum { get; set; }
        [MaxLength(30)]
        public string Sname { get; set; }
        [MaxLength(30)]
        public string City { get; set; }

        public decimal Comm { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
