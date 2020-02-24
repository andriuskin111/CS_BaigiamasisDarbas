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

        private void SetOrderId(Int64 loadedId)
        {
            orderid = loadedId;
        }

        private void FrOrderEdit_Load(object sender, EventArgs e)
        {
            SetOrderId(Convert.ToInt64(loadedOrderId));
            FillOrderDataTable(Convert.ToInt64(loadedOrderId));
        }
    }
}
