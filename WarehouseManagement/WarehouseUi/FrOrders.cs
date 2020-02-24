using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinesLogic;

namespace WarehouseUi
{
    public partial class FrOrders : Form
    {
        public FrOrders()
        {
            InitializeComponent();

            List<Int64> orderIdList = new List<Int64>();
            List<string> orderCustomerList = new List<string>();

            foreach (var order in Program.orderController.Retrieve())
            {
                orderIdList.Add(order.Id);

                if(!CheckOrCustomerEgsist(orderCustomerList, order.Customer))
                {
                    orderCustomerList.Add(order.Customer);
                }                
            }          

            comboBox2.DataSource = orderIdList;
            comboBox3.DataSource = orderCustomerList;

            FillOrderDataTable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOrderFilter();
        }

        private void CheckOrderFilter()
        {
            if (comboBox1.Text == "All")
            {
                FillOrderDataTable();
            }
            else if (comboBox1.Text == "Order Id")
            {
                FillOrderDataTable(Convert.ToInt64(comboBox2.Text));
            }
            else if (comboBox1.Text == "Date")
            {
                FillOrderDataTable(dateTimePicker1.Value);
            }
            else if (comboBox1.Text == "Customer")
            {
                FillOrderDataTable(comboBox3.Text);
            }
            else if (comboBox1.Text == "Status")
            {
                FillOrderDataTableByStatus(comboBox4.Text);
            }
            else
            {
                CreateDataTable();
            }
        }

        private void FillOrderDataTable()
        {
            DataTable dataTable = CreateDataTable();

            foreach (var order in Program.orderController.Retrieve())
            {
                FillOrderDataRows(dataTable, order);
            }
        }

        private void FillOrderDataTable(Int64 orderId)
        {
            DataTable dataTable = CreateDataTable();

            Order order = Program.orderController.Retrieve(orderId);

            FillOrderDataRows(dataTable, order);
        }

        private void FillOrderDataTable(string customer)
        {
            DataTable dataTable = CreateDataTable();

            foreach (var order in Program.orderController.Retrieve())
            {
                if(customer == order.Customer)
                {
                    FillOrderDataRows(dataTable, order);
                }               
            }
        }

        private void FillOrderDataTable(DateTime date)
        {
            DataTable dataTable = CreateDataTable();

            foreach (var order in Program.orderController.Retrieve())
            {
                if (date.ToShortDateString() == order.Date.ToShortDateString())
                {
                    FillOrderDataRows(dataTable, order);
                }
            }
        }

        private void FillOrderDataTableByStatus(string orderStatus)
        {
            DataTable dataTable = CreateDataTable();

            foreach (var order in Program.orderController.Retrieve())
            {
                if (orderStatus == order.Status)
                {
                    FillOrderDataRows(dataTable, order);
                }
            }
        }

        private void FillOrderDataRows(DataTable dataTable, Order order)
        {
            dataTable.Rows.Add(order.Id,
                                order.Date.ToShortDateString(),
                                order.Date.ToLongTimeString(),
                                order.Customer,
                                order.Status);

            dataGridOrders.DataSource = dataTable;
        }

        private DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("Time", typeof(string));
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataGridOrders.DataSource = dataTable;
            return dataTable;
        }

        public bool CheckOrCustomerEgsist(List<string> orderCustomerList, string orderCustomer)
        {
            bool result = false;
            foreach (var customer in orderCustomerList)
            {
                if(orderCustomer == customer)
                {
                    result = true;
                }
            }

            return result;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            FrOrder newOrder = new FrOrder();
            newOrder.ShowDialog();
            CheckOrderFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.RowCount > 0)
            {              
                using (FrOrderOpen frOrderEdit = new FrOrderOpen())
                {
                    string orderId = dataGridOrders.CurrentRow.Cells["Id"].Value.ToString();

                    DateTime dateTime = Program.orderController.Retrieve(Convert.ToInt64(orderId)).Date;

                    frOrderEdit.loadedOrderId = orderId;
                    frOrderEdit.loadedCustomer = dataGridOrders.CurrentRow.Cells["Customer"].Value.ToString();
                    frOrderEdit.loadedStatus = dataGridOrders.CurrentRow.Cells["Status"].Value.ToString();
                    frOrderEdit.loadedOrderDate = dateTime;
                    frOrderEdit.ShowDialog();
                    CheckOrderFilter();
                }               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridOrders.RowCount > 0)
            {
                if (dataGridOrders.CurrentRow.Cells["Status"].Value.ToString() == "Closed")
                {
                    MessageBox.Show("Order cannot be edited! Order Closed!");
                }
                else
                {
                    using (FrOrderEdit frOrderEdit = new FrOrderEdit())
                    {
                        frOrderEdit.loadedOrderId = dataGridOrders.CurrentRow.Cells["Id"].Value.ToString();
                        frOrderEdit.loadedCustomer = dataGridOrders.CurrentRow.Cells["Customer"].Value.ToString();
                        frOrderEdit.ShowDialog();
                        CheckOrderFilter();
                    }
                }
            }                
        }
    }
}
