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

    public partial class TrainBookingFormStep2 : Form
    {
        public string DataProperty { get; set; }
        public string PData1 { get; set; }
        private Mainform mainform;
        public TrainBookingFormStep2(Mainform mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            //open the next form
            TrainBookingFormStep3 trainBookingFormStep3 = new TrainBookingFormStep3(mainform);
            //reference to mainform
            trainBookingFormStep3.MdiParent = mainform;
            trainBookingFormStep3.Dock = DockStyle.Fill;
            // Pass args
            trainBookingFormStep3.PData2 = PData1; // id_Khachhang
            // MB debug
            //MessageBox.Show(trainBookingFormStep3.PData2);
            
            trainBookingFormStep3.Show();


        }

        private void TrainBookingFormStep2_Load(object sender, EventArgs e)
        {

        }
    }
}
