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
    public partial class FrParts : Form
    {
        private DataTable dataTableParts = new DataTable();

        public FrParts()
        {
            InitializeComponent();

            FillPartsDataTable();


        }


        private void FillPartsDataTable()
        {
            if (cbParts.Text == "All Parts")
            {
                DataTable dataTable = CreateDataTable();

                if (Program.partRepository.Retrieve().Count < 1)
                {
                    dataGridParts.DataSource = CreateDataTable();
                }
                else
                {
                    foreach (var part in Program.partRepository.Retrieve())
                    {
                        FillPartsDataRows(dataTable, part);
                    }
                }
            }
            else if (cbParts.Text == "Available Parts")
            {
                DataTable dataTable = CreateDataTable();

                if (Program.orderController.GetAvailableParts(Program.partRepository).Count < 1)
                {
                    dataGridParts.DataSource = CreateDataTable();
                }
                else
                {
                    foreach (var part in Program.orderController.GetAvailableParts(Program.partRepository))
                    {
                        FillPartsDataRows(dataTable, part);
                    }
                }
            }
            else if (cbParts.Text == "Reserved Parts")
            {
                DataTable dataTable = CreateDataTable();

                if (Program.orderController.GetReservedParts(Program.partRepository).Count < 1)
                {
                    dataGridParts.DataSource = CreateDataTable();
                }
                else
                {
                    foreach (var part in Program.orderController.GetReservedParts(Program.partRepository))
                    {
                        FillPartsDataRows(dataTable, part);
                    }
                }
            }
            else
            {
                dataGridParts.DataSource = CreateDataTable();
            }

            
        }

        private DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(Int64));
            dataTable.Columns.Add("Code", typeof(string));
            dataTable.Columns.Add("Brand", typeof(string));
            dataTable.Columns.Add("Model", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            dataTable.Columns.Add("Category Id", typeof(int));
            dataTable.Columns.Add("Category Code", typeof(string));
            dataTable.Columns.Add("Category Description", typeof(string));

            dataTable.Columns.Add("Location Id", typeof(int));
            dataTable.Columns.Add("Location Code", typeof(string));
            dataTable.Columns.Add("Location Description", typeof(string));
            return dataTable;
        }

        private void FillPartsDataRows(DataTable dataTable, Part part)
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

            dataGridParts.DataSource = dataTable;
        }

        private Int64 GeneratePartId()
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

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if(tbPartCode.Text == "" ||
                tbPartBrand.Text == "" ||
                tbPartModel.Text == "" ||
                tbPartDescription.Text == "" ||
                tbPartCategoryId.Text == "" ||
                tbPartCategoryCode.Text =="" ||
                tbPartCategoryDescription.Text == "" ||
                tbPartLocationId.Text == "" ||
                tbPartLocationCode.Text == "" ||
                tbPartLocationDescription.Text == "")
            {
                MessageBox.Show("Please fill all Fields");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Do You really want to add new Part?",
                   "Add Part", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    Program.partRepository.AddNewPart(new Part(GeneratePartId(),
                    tbPartCode.Text,
                    tbPartBrand.Text,
                    tbPartModel.Text,
                    tbPartDescription.Text,
                    new PartCategory(Convert.ToInt32(tbPartCategoryId.Text), tbPartCategoryCode.Text, tbPartCategoryDescription.Text),
                    new PartLocation(Convert.ToInt32(tbPartLocationId.Text), tbPartLocationCode.Text, tbPartLocationDescription.Text)));

                    ClearDataFields();

                    FillPartsDataTable();

                    MessageBox.Show("Part added");
                }
                else if (dialog == DialogResult.No)
                {
                    return;
                }
            }                   
        }

        private void ClearDataFields()
        {
            tbPartCode.Clear();
            tbPartBrand.Clear();
            tbPartModel.Clear();
            tbPartDescription.Clear();
            tbPartCategoryId.Clear();
            tbPartCategoryCode.Clear();
            tbPartCategoryDescription.Clear();
            tbPartLocationId.Clear();
            tbPartLocationCode.Clear();
            tbPartLocationDescription.Clear();
        }

        private void tbPartCategoryId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPartLocationId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPartsDataTable();
        }
    }
}
