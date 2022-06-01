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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        // Fill ComboBox KindOfRooms
        private void FillComboBoxKindOfRooms()
        {
            
        }

        // Event handler
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            this.FillComboBoxKindOfRooms();
        }
    }
}
