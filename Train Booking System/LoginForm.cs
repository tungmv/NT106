using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Train_Booking_System
{
    public partial class LoginForm : Form
    {
        private const string loginUrl = "http://localhost:5009/api/Auth/login";
        public LoginForm()
        {
            InitializeComponent();
            //Mainform bookingForm = new Mainform();
            //bookingForm.Show();
            TextBoxPassword.PasswordChar = '*';


        }

                private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string password = TextBoxPassword.Text;

            //string email = "22521115@gm.uit.edu.vn";
            //string password = "password"; 

            // Create JSON request body
            string jsonBody = $"{{\"email\":\"{email}\",\"password\":\"{password}\"}}";
            using (var client = new HttpClient())
            {
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    // Send POST request
                    var response = await client.PostAsync(loginUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content
                        string responseContent = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show("Login successful: " + responseContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open mainform
                        Mainform bookingForm = new Mainform();
                        bookingForm.Show();
                    }
                    else
                    {
                        // Read response content for error message
                        string responseContent = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show("Login failed: " + responseContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Login failed: Invalid email and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void kryptonButton1_Click(object sender, EventArgs e) {
            UserReg f = new UserReg();
            f.Show();
        } 
        private void TextBoxEmail_TextChanged(object sender, EventArgs e) { } 

        private void TextBoxPassword_TextChanged(object sender, EventArgs e) { }
    }
}
