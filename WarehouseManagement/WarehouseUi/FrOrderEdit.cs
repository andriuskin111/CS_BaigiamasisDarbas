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
    public partial class FrOrderEdit : Form
    {
        private bool orderCreated = false;
        private Int64 orderid;
        private Int64 partId;
        private DataTable dataTableOrder = new DataTable();
        public FrOrderEdit()
        {
            InitializeComponent();

            dataTableOrder.Columns.Add("Id", typeof(Int64));
            dataTableOrder.Columns.Add("Brand", typeof(string));
            dataTableOrder.Columns.Add("Model", typeof(string));
            dataTableOrder.Columns.Add("Description", typeof(string));

            List<string> orderCustomerList = new List<string>();

            foreach (var order in Program.orderController.Retrieve())
            {
                if (!CheckOrCustomerEgsist(orderCustomerList, order.Customer))
                {
                    orderCustomerList.Add(order.Customer);
                }
            }

            cbCustomer.DataSource = orderCustomerList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Program.orderController.GetAvailableParts(Program.partRepository).Count > 0)
            {
                if (dataGridAvalaibleParts.CurrentRow.Selected)
                {
                    AddPartToOrder(dataGridAvalaibleParts.CurrentRow.Cells["Id"].Value.ToString());
                    Program.orderController.AddPart(orderid, Program.partRepository.Retrieve(partId));
                    FillAvailablePartsrDataTable();
                }
            }            
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

        private DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(Int64));
            dataTable.Columns.Add("Brand", typeof(string));
            dataTable.Columns.Add("Model", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));           
            return dataTable;
        }

        private void FillOrderDataTable()
        {
            DataTable dataTable = CreateDataTable();

            foreach (var part in Program.parts)
            {
                FillPartsInOrderDataRows(dataTable, part);
            }
        }

        private void AddPartToOrder(string Id)
        {
            partId = Convert.ToInt64(Id);

            Part part = Program.partRepository.Retrieve(partId);

            dataTableOrder.Rows.Add(part.Id,
                                part.Brand,
                                part.Model,
                                part.Description);

            dataGridPartsInOrder.DataSource = dataTableOrder;
        }

        private void FillPartsInOrderDataRows(DataTable dataTable, Part part)
        {
            dataTable.Rows.Add(part.Id,
                                part.Brand,
                                part.Model,
                                part.Description);

             dataGridPartsInOrder.DataSource = dataTable;
        }

        private void FillAvailablePartsrDataTable()
        {
            DataTable dataTable = CreateDataTable();

            if(Program.orderController.GetAvailableParts(Program.partRepository).Count < 1)
            {
                dataGridAvalaibleParts.DataSource = CreateDataTable();
            }
            else
            {
                foreach (var part in Program.orderController.GetAvailableParts(Program.partRepository))
                {
                    FillPartsAvailableDataRows(dataTable, part);
                }
            }           
        }

        private void FillPartsAvailableDataRows(DataTable dataTable, Part part)
        {
            dataTable.Rows.Add(part.Id,
                                part.Brand,
                                part.Model,
                                part.Description);

            dataGridAvalaibleParts.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!orderCreated && cbCustomer.Text !="")
            {
                orderid = GenerateOrderId();

                Program.orderController.CreateNewOrder(orderid, cbCustomer.Text);

                dataGridPartsInOrder.DataSource = CreateDataTable();
                FillAvailablePartsrDataTable();

                btnCreateOrder.Hide();
                label3.Hide();
                label2.Text = $"PARTS IN ORDER {orderid} {cbCustomer.Text}";

                cbCustomer.Hide();
            }          
            
        }

        private Int64 GenerateOrderId()
        {
            string date = (DateTime.Now.ToString());
            string[] separator = { ":", " ", "-" };
            string[] resultArray = date.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (var item in resultArray)
            {
                result += item;
            }

            return Convert.ToInt64(result);
        }
    }
}
