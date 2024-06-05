using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Web.Caching;

namespace Train_Booking_System
{
    public partial class TicketForm : Form
    {
        public string TicketUrl = "http://localhost:5009/api/User/ticketHistory/";
        public string token_user { get; set; }
        public string email { get; set;}
        public TicketForm()
        {
            InitializeComponent();
            //GetTickets();
        }

        private async void GetTickets()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token_user);

                MessageBox.Show(email, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    var response = await client.GetAsync(TicketUrl+email);
                    string result = await response.Content.ReadAsStringAsync();

                    var contentType = response.Content.Headers.ContentType?.MediaType;

                    if (contentType == "application/json")
                    {
                        var jsonResponse = JToken.Parse(result);
                        MessageBox.Show(jsonResponse.ToString(), "Ticket History", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
