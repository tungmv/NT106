using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Booking_System
{
    public partial class TrainBookingFormStep3 : Form
    {
        private Mainform mainform;
        public TrainBookingFormStep3(Mainform mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }
    }
}
