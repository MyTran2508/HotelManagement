using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Controllers;
using DTO.Entities;
using DTO;
using HotelManage.Resources.Utils;

namespace HotelManage.Forms
{
    public partial class ServiceForm : Form
    {
        // Make service controller
        ServiceController sc = null;
        public ServiceForm()
        {
            InitializeComponent();
            this.sc = new ServiceController();
        }

        // Get datatable fill in DataGrid
        private void FillDataGrid()
        {
            string error = "";
            var services = sc.GetAllServices(ref error);

            if (services != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã Dịch Vụ",
                    "Tên Dịch Vụ",
                    "Đơn Giá"
                    );

                foreach (var sv in services)
                {

                    dt.Rows.Add(sv.Id, sv.Name, sv.Price );

                }
                this.GridViewService.DataSource = dt;

                this.GridViewService.Columns[0].Width = 100;
                this.GridViewService.Columns[1].Width = 180;
                this.GridViewService.Columns[2].Width = 150;
            }
        }

        private void ClearAllTextBox()
        {
            TextBoxId.ResetText();
            TextBoxName.ResetText();
            TextBoxPrice.ResetText();
            TextBoxId.Focus();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id =Common.GetValueTextBox(TextBoxId);
                string Name = Common.GetValueTextBox(TextBoxName);
                float Price = float.Parse(Common.GetValueTextBox(TextBoxPrice));

                string error = "";
                bool isCreated = sc.AddNewService(id, Name, Price, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.FillDataGrid();

                    // Clear Text Box If Insert success
                    this.ClearAllTextBox();
                }
                
                MessageBox.Show(error);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.GridViewService);
                // Get Id
                string Id = Common.
                    GetValueOfCellGridView(this.GridViewService, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = sc.RemoveServiceById(Id,ref error );
                if (isDeleted)
                {
                    this.FillDataGrid();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.ClearAllTextBox();
            this.FillDataGrid();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.GridViewService);

                // Get Values
                string id = Common.
                    GetValueOfCellGridView(this.GridViewService, rowIndex, 0);
                string Name = Common.GetValueTextBox(TextBoxName);
                float Price = float.Parse(Common.GetValueTextBox(TextBoxPrice));
              
                string error = "";
                bool isUpdated = sc.UpdateServiceById(id, Name, Price, ref error);
                if (isUpdated)
                {
                    // Refresh Data
                    this.FillDataGrid();

                    // Clear Text Box If Insert success
                    this.ClearAllTextBox();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            this.FillDataGrid();
        }

        private void DataGridService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = Common.GetCurrentRowSelected(this.GridViewService);

            // Get Values
            string id = Common.
                GetValueOfCellGridView(this.GridViewService, rowIndex, 0);
            string Name = Common.GetValueOfCellGridView(this.GridViewService, rowIndex, 1);
            string Price = Common.GetValueOfCellGridView(this.GridViewService, rowIndex, 2);

            this.TextBoxId.Text = id;
            this.TextBoxName.Text = Name;
            this.TextBoxPrice.Text = Price;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string NameSearch = Common.GetValueTextBox(TBSearch);

                string error = "";
                var services = sc.GetAllServicesByName(NameSearch, ref error);

                if (services != null)
                {
                    DataTable dt = Common.GetDataTable(
                        "Mã Dịch Vụ",
                        "Tên Dịch Vụ",
                        "Đơn Giá"
                        );

                    foreach (var sv in services)
                    {

                        dt.Rows.Add(sv.Id, sv.Name, sv.Price);

                    }
                    this.GridViewService.DataSource = dt;

                    this.GridViewService.Columns[0].Width = 100;
                    this.GridViewService.Columns[1].Width = 180;
                    this.GridViewService.Columns[2].Width = 150;

                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearAllTextBox();
            this.FillDataGrid();
        }
    }
}
