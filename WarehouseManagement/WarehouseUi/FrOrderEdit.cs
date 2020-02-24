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
        public string loadedOrderId;
        public string loadedCustomer;
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

            dataGridPartsInOrder.DataSource = CreateDataTable();
            FillAvailablePartsrDataTable();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridAvalaibleParts.Rows.Count > 0)
            {
                if (dataGridAvalaibleParts.CurrentRow.Selected)
                {
                    AddPartToOrder(dataGridAvalaibleParts.CurrentRow.Cells["Id"].Value.ToString());
                    Program.orderController.AddPart(orderid, Program.partRepository.Retrieve(partId));
                    FillAvailablePartsrDataTable();
                }
            }            
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if(dataGridPartsInOrder.Rows.Count > 0)
            {
                if (dataGridPartsInOrder.CurrentRow.Selected)
                {
                    string selectedPartId = dataGridPartsInOrder.CurrentRow.Cells["Id"].Value.ToString();
                    Program.orderController.RemovePart(orderid, Convert.ToInt64(selectedPartId));
                    dataTableOrder.Clear();
                    dataGridPartsInOrder.DataSource = dataTableOrder;
                    FillOrderDataTable(orderid);
                    FillAvailablePartsrDataTable();
                }
            }
        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            if(Program.orderController.Retrieve(orderid).Parts.Count < 1)
            {
                MessageBox.Show("Parts List is empty! Order cannot be closed!");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Do You really want to close Order?",
                    "Close Order", MessageBoxButtons.YesNo);

                if(dialog == DialogResult.Yes)
                {
                    Program.orderController.CloseOrder(orderid, Program.partRepository);
                    Close();
                }
                else if(dialog == DialogResult.No)
                {
                    return;
                }

                
            }          
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You really want to delete Order?",
                   "Delete Order", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Program.orderController.CancelOrder(orderid);
                Close();
            }
            else if (dialog == DialogResult.No)
            {
                return;
            }           
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

        private void FillOrderDataTable(Int64 id)
        {
            foreach (var part in Program.orderController.Retrieve(id).Parts)
            {
                FillPartsInOrderDataRows(dataTableOrder, part);
            }
        }

        private void AddPartToOrder(string Id)
        {
            partId = Convert.ToInt64(Id);
            Program.orderController.AddPart(orderid, Program.partRepository.Retrieve(partId));
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

        private void InitializeLoadedData(Int64 loadedId, string customer)
        {
            orderid = loadedId;
            label2.Text = $"Parts in Order {orderid} {customer}";
        }

        private void FrOrderEdit_Load(object sender, EventArgs e)
        {
            InitializeLoadedData(Convert.ToInt64(loadedOrderId), loadedCustomer);
            FillOrderDataTable(Convert.ToInt64(loadedOrderId));
        }

        
    }
}
