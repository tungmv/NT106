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
        // get string id_user
        public string PData2 { get; set; }
        private Mainform mainform;
        public TrainBookingFormStep3(Mainform mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            string id_user = PData2;
            MessageBox.Show(id_user);
        }

        private void TextBoxPhoneNumber_TextChanged(object sender, EventArgs e) { }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            var name = TextBoxFullName.Text;
            var pnumber = TextBoxPhoneNumber.Text;
            var email = TextBoxEmail.Text;
            var passwd = TextBoxPassword.Text;
            var nsinh = TextBoxBirthday.Text;
            // Check if any field is/**/ null or empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pnumber))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nsinh))
            {
                MessageBox.Show("Birthday is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
