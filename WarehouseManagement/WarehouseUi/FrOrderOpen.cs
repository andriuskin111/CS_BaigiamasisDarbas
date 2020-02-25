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
    public partial class FrOrderOpen : Form
    {
        public string loadedOrderId;
        public string loadedCustomer;
        public string loadedStatus;
        public DateTime loadedOrderDate;
        private Int64 orderid;
        private DataTable dataTableOrder = new DataTable();
        public FrOrderOpen()
        {
            InitializeComponent();

            dataTableOrder.Columns.Add("Id", typeof(Int64));
            dataTableOrder.Columns.Add("Code", typeof(string));
            dataTableOrder.Columns.Add("Brand", typeof(string));
            dataTableOrder.Columns.Add("Model", typeof(string));
            dataTableOrder.Columns.Add("Description", typeof(string));

            dataTableOrder.Columns.Add("Category Id", typeof(int));
            dataTableOrder.Columns.Add("Category Code", typeof(string));
            dataTableOrder.Columns.Add("Category Description", typeof(string));

            dataTableOrder.Columns.Add("Location Id", typeof(int));
            dataTableOrder.Columns.Add("Location Code", typeof(string));
            dataTableOrder.Columns.Add("Location Description", typeof(string));
        }

        private void FillOrderDataTable(Int64 id)
        {
            foreach (var part in Program.orderController.Retrieve(id).Parts)
            {
                FillPartsInOrderDataRows(dataTableOrder, part);
            }
        }

        private void FillPartsInOrderDataRows(DataTable dataTable, Part part)
        {
            dataTable.Rows.Add(part.Id,
                                part.Code,
                                part.Brand,
                                part.Model,
                                part.Description,
                                part.Category.Id,
                                part.Category.Code,
                                part.Category.Decription,
                                part.Location.Id,
                                part.Location.Code,
                                part.Location.Description);

            dataGridPartsInOrder.DataSource = dataTable;
        }

        private void InitializeLoadedData(Int64 loadedId, string customer, string status, DateTime date)
        {
            orderid = loadedId;
            label2.Text = $"Order {orderid} {customer} {date.ToString()} {status}";
        }

        private void FrOrderEdit_Load(object sender, EventArgs e)
        {
            InitializeLoadedData(Convert.ToInt64(loadedOrderId), loadedCustomer, loadedStatus, loadedOrderDate);
            FillOrderDataTable(Convert.ToInt64(loadedOrderId));
        }

        
    }
}
