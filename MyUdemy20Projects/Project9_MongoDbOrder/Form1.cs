using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        OrderOperation operation = new OrderOperation();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCity.Text,
                CustomerName = txtConsumerName.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
                OrderId = txtId.Text,
            };
            operation.AddOrder(order);
            MessageBox.Show("Ekleme işlemi yapıldı");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> order = operation.GetAllOrders();
            dataGridView1.DataSource = order;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            operation.DeleteOrder(orderId);
            MessageBox.Show("Silme işlemi yapıldı");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var updateOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtConsumerName.Text,
                District = txtDistrict.Text,
                OrderId = id,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
            };
            operation.UpdateOrder(updateOrder);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Order orders = operation.GetOrderById(id);
            dataGridView1.DataSource = new List<Order> { orders };
        }
    }
}
