using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseUi
{
    public partial class FrNewOrder : Form
    {
        public FrNewOrder()
        {
            InitializeComponent();
            List<string> orderCustomerList = new List<string>();

            foreach (var order in Program.orderController.Retrieve())
            {
                if (!CheckOrCustomerEgsist(orderCustomerList, order.Customer))
                {
                    orderCustomerList.Add(order.Customer);
                }
            }

            comboBox1.DataSource = orderCustomerList;
        }

        private bool CheckOrCustomerEgsist(List<string> orderCustomerList, string orderCustomer)
        {
            bool result = false;
            foreach (var customer in orderCustomerList)
            {
                if (orderCustomer == customer)
                {
                    result = true;
                }
            }

            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.orderController.CreateNewOrder(comboBox1.Text);
            FrOrder frOrder = new FrOrder();
            frOrder.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();      
        }
    }
}
