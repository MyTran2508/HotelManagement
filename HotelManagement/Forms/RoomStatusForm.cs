using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelManage
{
    public partial class RoomStatusForm : Form
    {
        
        public RoomStatusForm()
        {
            InitializeComponent();
        }

        private void ClearAllTextBox()
        {
            TBId.ResetText();
            TBName.ResetText();
            TBId.Focus();
        }

        // Get datatable fill in DataGrid
        private void FillDataGrid()
        {
            
        }

        private void RoomStatusForm_Load(object sender, EventArgs e)
        {
            this.ClearAllTextBox();
            this.FillDataGrid();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void GridViewRoomStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        private void RoomStatusForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
