using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HotelManage.Resources.Utils;

namespace HotelManage.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void ClearAllTextBox()
        {
            TBId.ResetText();
            TBName.ResetText();
            TBAddress.ResetText();  
            TBPhone.ResetText();    
            TBCustomerId.ResetText();   
            TBId.Focus();
        }

        // Get datatable fill in DataGrid
        private void FillDataGrid()
        {
            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.ClearAllTextBox();
            this.FillDataGrid();
        }

        // Event handler

        private void BtnInsert_Click(object sender, EventArgs e)
        {

        }

        private void GridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
