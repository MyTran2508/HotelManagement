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
    public partial class KindOfRoomForm : Form
    {
        public KindOfRoomForm()
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

        private void KindOfRoomForm_Load(object sender, EventArgs e)
        {
            this.ClearAllTextBox();
            this.FillDataGrid();
        }
    }
}
