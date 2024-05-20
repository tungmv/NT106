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
        private Mainform mainform;

        public TrainBookingFormStep1(Mainform mainform)
        {
            //accept reference to mainform
            this.mainform = mainform;

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

        private void ButtonNext(object sender, EventArgs e)
        {
            // insert check here







            //open TrainBookingFormStep2
            TrainBookingFormStep2 trainBookingFormStep2 = new TrainBookingFormStep2(mainform);
            //reference to mainform
            trainBookingFormStep2.MdiParent = mainform;
            trainBookingFormStep2.Dock = DockStyle.Fill;
            trainBookingFormStep2.Show();

        }
    }
}
