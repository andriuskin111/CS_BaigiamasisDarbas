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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("Time", typeof(string));
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataGridOrders.DataSource = dataTable;


            foreach (var order in Program.orderController.Retrieve())
            {
                dataTable.Rows.Add(order.Id,
                    order.Date.ToShortDateString(),
                    order.Date.ToShortTimeString(),
                    order.Customer,
                    order.Status);

                dataGridOrders.DataSource = dataTable;
            }          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
