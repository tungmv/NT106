using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Booking_System
{

    public partial class TrainBookingFormStep2 : Form
    {
        public string id_user { get; set; } // id user
        public string origin { get; set; }
        public string destination { get; set; }
        public string TrainId { get; set; }
        
        private const string TrainIdUrl = "http://localhost:5009/api/Train/";
        public string ghe;

        private Mainform mainform;
        public TrainBookingFormStep2(Mainform mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            InitializeKryptonButtons();
        }
        private KryptonButton selectedButton;



        private void ButtonNext_Click(object sender, EventArgs e)
        {
            //open the next form
            TrainBookingFormStep3 trainBookingFormStep3 = new TrainBookingFormStep3(mainform);
            //reference to mainform
            trainBookingFormStep3.MdiParent = mainform;
            trainBookingFormStep3.Dock = DockStyle.Fill;
            // Pass args
            trainBookingFormStep3.id_user = id_user; // id_Khachhang
            trainBookingFormStep3.get_ghe = ghe;
            trainBookingFormStep3.origin = origin;
            trainBookingFormStep3.destination = destination;
            // MB debug
            //MessageBox.Show(trainBookingFormStep3.get_ghe);
            //MessageBox.Show(trainBookingFormStep3.origin);
            //MessageBox.Show(trainBookingFormStep3.destination);
            
            trainBookingFormStep3.Show();
        }

        private void InitializeKryptonButtons()
        {
            for (int i = 1; i <= 40; i++)
            {
                //KryptonButton button = this.Controls.Find($"g{i}", true).FirstOrDefault() as KryptonButton;
                KryptonButton button = this.Controls.Find($"g{i:00}", true).FirstOrDefault() as KryptonButton;
                if (button != null)
                {
                    button.Click += KryptonButton_Click;
                }
            }
        }

        private void KryptonButton_Click(object sender, EventArgs e)
        {
            KryptonButton clickedButton = sender as KryptonButton;

            if (clickedButton != null)
            {
                // Deselect the previously selected button
                if (selectedButton != null && selectedButton != clickedButton)
                {
                    selectedButton.StateNormal.Back.Color1 = SystemColors.Control; // default color
                }

                // Select the new button
                clickedButton.StateNormal.Back.Color1 = Color.LightBlue; // selected color
                selectedButton = clickedButton;
                ghe = clickedButton.Name.Substring(1);
                

                MessageBox.Show($"Ghe {ghe} was selected.", "Button Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TrainBookingFormStep2_Load(object sender, EventArgs e)
        {

        }
    }
}
