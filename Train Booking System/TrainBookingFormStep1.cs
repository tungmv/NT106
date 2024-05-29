using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.AccessControl;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace Train_Booking_System
{
    public partial class TrainBookingFormStep1 : Form
    {
        private Mainform mainform;
        private const string fetchStationUrl = "http://localhost:5009/api/Route/fetchStation";


        public TrainBookingFormStep1(Mainform mainform)
        {
            //accept reference to mainform
            this.mainform = mainform;
            GetStationInfo();

            InitializeComponent();
        }

        private async void GetStationInfo()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "text/plain");
                try
                {
                    // Send GET request
                    var response = await client.GetAsync(fetchStationUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content
                        string responseContent = await response.Content.ReadAsStringAsync();


                        // Parse JSON response
                        var jsonResponse = JObject.Parse(responseContent);
                        var stationsArray = (JArray)jsonResponse["station"];

                        // Deserialize JSON string to StationData object
                        List<Tram> Stations = stationsArray.ToObject<List<Tram>>();
                        foreach (Tram Station in Stations )
                        {
                            //MessageBox.Show(Station.name + Station.city + Station.province);
                            ComboBoxDeparture.Items.Add($"{Station.name} - {Station.city} - {Station.province}");
                        }
                        foreach (Tram Station in Stations )
                        {
                            //MessageBox.Show(Station.name + Station.city + Station.province);
                            ComboBoxReturn.Items.Add($"{Station.name} - {Station.city} - {Station.province}");
                        }

                        //var stationData = JsonConvert.DeserializeObject<StationData>(stationsArray.ToString());
                        // MB debug
                        //MessageBox.Show("Fetch successful: " + stationsArray, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Read response content for error message
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Fetch failed: " + responseContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        } 

        private void CheckBoxRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRoundTrip.Checked)
            {
                ComboBoxReturn.Enabled = true;
                DateTimePickerReturnDate.Enabled = true;
            }
            else
            {
                ComboBoxReturn.Enabled = false;
                DateTimePickerReturnDate.Enabled = false;
            }
        }

        private void ButtonNext(object sender, EventArgs e)
        {
            // insert check here







            //open TrainBookingFormStep2
            TrainBookingFormStep2 trainBookingFormStep2 = new TrainBookingFormStep2(mainform);
            //reference to mainform
            trainBookingFormStep2.MdiParent = mainform;
            trainBookingFormStep2.Dock = DockStyle.Fill;
            trainBookingFormStep2.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Tram
        {
            [JsonProperty("id_Tram")]
            public string id { get; set; }
            [JsonProperty("tenTram")]
            public string name { get; set; }
            [JsonProperty("thanhpho")]
            public string  city { get; set; }
            [JsonProperty("tinh")]
            public string province { get; set; }
            
        }

        private void ComboBoxReturn_SelectedIndexChanged(object sender, EventArgs e) {
            //GetStationInfo();
        }

        private void ComboBoxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBoxReturn.Items.Remove(ComboBoxDeparture.SelectedIndex);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string d1 = ComboBoxDeparture.SelectedIndex.ToString();
            string d2 = ComboBoxReturn.SelectedIndex.ToString();

            // Tokenize the input strings based on the delimiter
            string delimiter = " - ";

            string[] t1 = d1.Split(delimiter.ToCharArray());
            string[] t2 = d2.Split(delimiter.ToCharArray());


        }
    }
}
