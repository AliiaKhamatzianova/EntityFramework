using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WF
{
    public class DBInitializer : DropCreateDatabaseAlways<DB>
    {
        public DBInitializer(DB context)
        {
            this.Seed(context);
        }
        protected override void Seed(DB context)
        {
            context.SalesPeoples.Add(new SalesPeople()
            {
                Snum = 1001,
                Sname = "Peel",
                City = "London",
                Comm = 0.12m
            });
            context.SalesPeoples.Add(new SalesPeople()
            {
                Snum = 1002,
                Sname = "Serres",
                City = "San Jose",
                Comm = 0.13m
            });

            context.SalesPeoples.Add(new SalesPeople()
            {
                Snum = 1004,
                Sname = "Motika",
                City = "London",
                Comm = 0.11m
            });

            context.SalesPeoples.Add(new SalesPeople()
            {
                Snum = 1007,
                Sname = "Rifkin",
                City = "Barcelona",
                Comm = 0.15m
            });

            context.SalesPeoples.Add(new SalesPeople()
            {
                Snum = 1003,
                Sname = "Axelrod",
                City = "New York",
                Comm = 0.10m
            });

            context.SaveChanges();
        }
    }
    public class DB : DbContext
    {
        static DB()
        {
            Database.SetInitializer<DB>(new DBInitializer());
        }

        public DB():base("EntityDB")
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SalesPeople> SalesPeoples { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
