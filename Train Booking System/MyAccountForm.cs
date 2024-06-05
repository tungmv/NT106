using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Train_Booking_System
{
    public partial class MyAccountForm : Form
    {
        // Define a string for the API URL to update user details
        public string UpdateApiUrl = "http://localhost:5009/api/User/details/update";
        public string token_user { get; set; }

        public MyAccountForm()
        {
            InitializeComponent();
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            // Create an anonymous object with the user's details
            var user = new
            {
                email = TextBoxEmail.Text,
                password = TextBoxPassword.Text,
                hoTen = TextBoxHoTen.Text,
                namSinh = int.Parse(TextBoxBirthday.Text)
            };

            // Serialize the user object to a JSON string
            var json = JsonConvert.SerializeObject(user);

            // Create a new instance of StringContent with the JSON data
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                // Set the default request headers for the HttpClient instance to include the bearer token
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token_user);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

                try
                {
                    var response = await client.PostAsync(UpdateApiUrl, data);
                    string result = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(response.StatusCode.ToString());

                    // Check if response content is in JSON format
                    if (response.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        var jsonResponse = JsonConvert.DeserializeObject(result);
                        MessageBox.Show(jsonResponse.ToString(), "SUCCESS", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
                catch (Exception ex)
                {
                    // Show the exception message if the request fails
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
