using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Booking_System {
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        static string HashPasswordSHA256(string password) {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            // Retrieve the password entered by the user
            string password = textBox2.Text;
            string hashedPassword = HashPasswordSHA256(password);

            // DEBUG
            MessageBox.Show($"Password entered: {password} and hashed pwd: {hashedPassword}");
        }
    }
}
