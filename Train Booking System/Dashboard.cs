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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            comboBox1.Items.Add("Normal user");
            comboBox1.Items.Add("Addmin");

            comboBox1.SelectedIndex = 0;

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item text
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Display the selected item in the label
            if (selectedItem == "Normal user")
            {
                LoginForm user = new LoginForm();
                user.Show();
            }
            else
            {
                //Application.Run(new AdminLogin());
                AdminLogin adminlogin = new AdminLogin();
                adminlogin.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
