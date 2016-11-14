using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFForms
{
    public partial class Form1 : Form
    {
        NORTHWNDEntities ctx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (var ctx = new NORTHWNDEntities())
            //{
                dataGridView1.DataSource = (from cust in ctx.Customers
                                            where cust.Orders.Count > 10
                                            orderby cust.Orders.Count
                                            select new
                                            {
                                                cust.ContactName,
                                                cust.ContactTitle,
                                                cust.Country,
                                                cust.Orders.Count
                                            }
                                            ).ToList();

                /*dataGridView2.DataSource = (from orderDetails in ctx.Order_Details
                                            select new
                                            {
                                                orderDetails.OrderID,
                                                orderDetails.ProductID,
                                                orderDetails.UnitPrice,
                                                orderDetails.Quantity,
                                                orderDetails.Discount
                                            }
                                            ).ToList();*/
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
