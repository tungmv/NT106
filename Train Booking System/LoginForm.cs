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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Mainform bookingForm = new Mainform();
            bookingForm.Show();

        }
            
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
