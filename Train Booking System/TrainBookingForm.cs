using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Train_Booking_System
{
    public partial class TrainBookingFormStep1 : Form
    {
        public TrainBookingFormStep1()
        {
            //set
            
            InitializeComponent();
        }

        private void CheckBoxRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRoundTrip.Checked)
            {
                ComboBoxReturn.Enabled = true;
                DateTimePickerReturnDate.Enabled = true;
            }
            else
            {
                ComboBoxReturn.Enabled = false;
                DateTimePickerReturnDate.Enabled = false;
            }
        }
    }
}
