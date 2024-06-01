using Newtonsoft.Json.Linq;
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
    public partial class TrainBookingFormStep3 : Form
    {
        // get string id_user
        private const string GenticketUrl = "http://localhost:5009/api/Train/GenerateTicket";
        public string id_user { get; set; }
        public string get_ghe {  get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        private Mainform mainform;
        public TrainBookingFormStep3(Mainform mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            //MessageBox.Show(id_user);
        }

        private void TextBoxPhoneNumber_TextChanged(object sender, EventArgs e) { }

        private async void ButtonFinish_Click(object sender, EventArgs e)
        {
            var name = TextBoxFullName.Text;
            var pnumber = TextBoxPhoneNumber.Text;
            var email = TextBoxEmail.Text;
            var passwd = TextBoxPassword.Text;
            var nsinh = TextBoxBirthday.Text;
            // Check if any field is null or empty
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

            // Prepare JSON body
            var jsonBody = new JObject
            {
                { "iD_KhachHang", id_user },
                { "isVeNam", 0 },
                { "iD_LichTrinh", "HN-HCM9" }, // Replace with actual data if needed
                { "iD_PhongorToa", "SH1S02" }, // Replace with actual data if needed
                { "iD_GiuongorGhe", get_ghe },
                { "hoTen", name },
                { "namSinh", nsinh },
                { "xuatPhat", origin },
                { "diemDen", destination }
            };

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "*/*");
                var content = new StringContent(jsonBody.ToString(), Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(GenticketUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Ticket generation successful: " + responseContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Request failed: " + errorContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
