using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Booking_System
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }
        private const string createAccountUrl = "http://localhost:5009/api/User/createAccount";

        private async void button1_Click(object sender, EventArgs e)
        {
            // get data
            string email = textBox1.Text;
            string password = textBox2.Text;
            string hoTen = textBox3.Text;
            int namSinh;
            // Validate namSinh is an integer
            if (!int.TryParse(textBox4.Text, out namSinh))
            {
                MessageBox.Show("Please enter a valid year of birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create JSON request body
            string jsonBody = $"{{\"email\":\"{email}\",\"password\":\"{password}\",\"hoTen\":\"{hoTen}\",\"namSinh\":{namSinh}}}";
            using (var client = new HttpClient())
            {
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    // Send POST request
                    var response = await client.PostAsync(createAccountUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        // Read response content for error message
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Account creation failed: " + responseContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
