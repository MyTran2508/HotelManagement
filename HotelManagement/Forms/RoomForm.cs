using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelManage.Forms
{
    public partial class RoomForm : Form
    {

        
        public RoomForm()
        {
            InitializeComponent();
           
        }


        // Fill ComboBox KindOfRooms
        private void FillComboBoxKindOfRooms()
        {
        }

        // Fill ComboBox RoomStatus
        private void FillComboBoxRoomStatus()
        {
            
        }

        // Fill Data Grid View
        private void FillDataGridViewRooms()
        {
           
        }

        private void FillTextBox()
        {
            
        }

        // Form Load
        private void RoomForm_Load(object sender, EventArgs e)
        {
            this.FillComboBoxKindOfRooms();
            this.FillComboBoxRoomStatus();
            this.FillDataGridViewRooms();
            this.FillTextBox();
        }

        // Event handler
        // Remove Room
        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        // Edit Room
        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void GridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FillTextBox();
        }
    }
}
