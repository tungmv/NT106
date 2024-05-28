
using System;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace Train_Booking_System
{
    public partial class AdminLogin : Form
    {
        private const string url = "http://localhost:5009/api/Auth/adminlogin";

        public AdminLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            // Read input user from textbox
            //string id = textBox1.Text;
            //string password = textBox2.Text;

            string id = "sudo"; // Replace "string" with actual value
            string password = "iusearchbtw"; // Replace "string" with actual value

            // Create JSON request body
            string jsonBody = $"{{\"id\":\"{id}\",\"password\":\"{password}\"}}";

            using (var client = new HttpClient())
            {
                // Define request content
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    // Send POST request
                    var response = await client.PostAsync(url, content);

                    // Check if request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Response: " + responseContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { // Catch error
                        MessageBox.Show("Request failed with status code " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) { // Catch error
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
