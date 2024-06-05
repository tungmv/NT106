
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Train_Booking_System
{
    public partial class TicketForm : Form
    {
        public string TicketUrl = "http://localhost:5009/api/User/ticketHistory/";
        public string token_user { get; set; }
        public string email { get; set; }

        public TicketForm()
        {
            InitializeComponent();
            // GetTickets();
            this.Load += new EventHandler(TicketForm_Load);
        }

        // This method will be called when the form is loaded
        private void TicketForm_Load(object sender, EventArgs e)
        {
            // Call the ButtonRefresh_Click method to refresh the data
            ButtonRefresh_Click(this, EventArgs.Empty);
        }

        private async void GetTickets()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token_user);

                try
                {
                    var response = await client.GetAsync(TicketUrl + email);
                    string result = await response.Content.ReadAsStringAsync();

                    var contentType = response.Content.Headers.ContentType?.MediaType;

                    if (contentType == "application/json")
                    {
                        var userData = JsonConvert.DeserializeObject<UserData>(result);
                        if (userData != null && userData.VeNgoi.Count > 0)
                        {
                            // Clear the existing rows
                            this.DataGridViewTrainList.Rows.Clear();

                            // Add the new rows from the ticket data
                            foreach (var ticket in userData.VeNgoi)
                            {
                                this.DataGridViewTrainList.Rows.Add(
                                    ticket.ID_VeNgoi,
                                    ticket.ID_LichTrinh,
                                    //ticket.ID_Ghe,
                                    //ticket.ID_Toa,
                                    ticket.XuatPhat,
                                    ticket.DiemDen,
                                    ticket.ExpireDate,
                                    ticket.DonGia);
                            }

                            MessageBox.Show("Tickets loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No tickets found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Response content is not valid JSON\n" + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // to cancel selected tickets
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            // refresh the ticket list
            GetTickets();
        }

        private void DataGridViewTrainList_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        public class UserData
        {
            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("veNgoi")]
            public List<VeNgoi> VeNgoi { get; set; }

            [JsonProperty("veNam")]
            public List<object> VeNam { get; set; }
        }

        public class VeNgoi
        {
            [JsonProperty("iD_VeNgoi")]
            public string ID_VeNgoi { get; set; }

            [JsonProperty("iD_LichTrinh")]
            public string ID_LichTrinh { get; set; }

            [JsonProperty("iD_Ghe")]
            public string ID_Ghe { get; set; }

            [JsonProperty("iD_Toa")]
            public string ID_Toa { get; set; }

            [JsonProperty("donGia")]
            public int DonGia { get; set; }

            [JsonProperty("hoTen")]
            public string HoTen { get; set; }

            [JsonProperty("namSinh")]
            public int NamSinh { get; set; }

            [JsonProperty("xuatPhat")]
            public string XuatPhat { get; set; }

            [JsonProperty("diemDen")]
            public string DiemDen { get; set; }

            [JsonProperty("ghe")]
            public object Ghe { get; set; }

            [JsonProperty("lichTrinh")]
            public object LichTrinh { get; set; }

            [JsonProperty("expireDate")]
            public string ExpireDate { get; set; }
        }
    }
}
