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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Security.Policy;
using System.IO;

namespace Train_Booking_System
{
    public partial class TrainBookingFormStep1 : Form
    {
        private Mainform mainform;
        private const string fetchStationUrl = "http://localhost:5009/api/Route/fetchStation";
        private const string FindRoutesUrl = "http://localhost:5009/api/Route/FindRoutes";
        private const string RouteIdUrl = "http://localhost:5009/api/Route/";


        public TrainBookingFormStep1(Mainform mainform)
        {
            //accept reference to mainform
            this.mainform = mainform;
            GetStationInfo();
            InitializeComponent();
            ComboBoxDeparture.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxReturn.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_date.DropDownStyle = ComboBoxStyle.DropDownList;
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
                        foreach (Tram Station in Stations)
                        {
                            //MessageBox.Show(Station.name + Station.city + Station.province);
                            ComboBoxDeparture.Items.Add($"{Station.name}-{Station.city}-{Station.province}");
                        }
                        foreach (Tram Station in Stations)
                        {
                            //MessageBox.Show(Station.name + Station.city + Station.province);
                            ComboBoxReturn.Items.Add($"{Station.name}-{Station.city}-{Station.province}");
                        }

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
        
/* Comment rountrip && old date combobox
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
*/
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
      
        private void ComboBoxReturn_SelectedIndexChanged(object sender, EventArgs e) {
            //GetStationInfo();

        }

        private void ComboBoxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBoxReturn.Items.Remove(ComboBoxDeparture.SelectedIndex);
        }


        // FIND button
        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            // Clear select combobox
            combobox_date.Items.Clear();

            // Tokenize the input strings based on the delimiter
            string d1 = ComboBoxDeparture.SelectedItem.ToString();
            string d2 = ComboBoxReturn.SelectedItem.ToString();

            string[] t1 = d1.Split('-');
            string[] t2 = d2.Split('-');


            string destination = t1[0];
            string origin = t2[0];


            // Client request 

            // Create JSON request body
            string jsonBody = $"{{\"destination\":\"{destination}\",\"origin\":\"{origin}\"}}";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "text/plain");
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                try
                {
                    var response = await client.PostAsync(FindRoutesUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        // Parse JSON response
                        var jsonResponse = JObject.Parse(responseContent);
                        var routesArray = (JArray)jsonResponse["routes"];

                        // using regex to match id route
                        string pattern = @"[A-Z]{2}-[A-Z]{3}";
                        Regex regex = new Regex(pattern);
                        Match match = regex.Match(routesArray.ToString());

                        // If match success convert into result route
                        if (match.Success)
                        {
                            string resRoute = match.Value;
                            using (HttpClient client1 = new HttpClient())
                            {
                                // Set the Accept header
                                client.DefaultRequestHeaders.Add("accept", "text/plain");
                                try
                                {
                                    // Send the GET request
                                    HttpResponseMessage response1 = await client.GetAsync(RouteIdUrl+resRoute);

                                    // Check if the request was successful
                                    if (response1.IsSuccessStatusCode)
                                    {
                                        // Read and display the response content
                                        string response1Content = await response1.Content.ReadAsStringAsync();

                                        // Parse JSON response
                                        var jsonResponse1 = JObject.Parse(response1Content);
                                        var routeidarray = (JArray)jsonResponse1["lichtrinh"];
                                        List<LichTrinh> lt = routeidarray.ToObject<List<LichTrinh>>();
                                        foreach (var ltt in lt)
                                        {
                                             combobox_date.Items.Add($"{ltt.idlt}--Train:{ltt.idtau}--Time:{ltt.gio}--Thu':{ltt.thu}");
                                            // MB debug
                                            //MessageBox.Show($"{ltt.idlt}--Train:{ltt.idtau}--Time:{ltt.gio}--Thu':{ltt.thu}");
                                        }
                                        MessageBox.Show("Get data success!");

                                        // MB debug
                                        //MessageBox.Show("Response Content: " + response1Content);

                                    }
                                    else
                                    {
                                        // Handle the error response
                                        string error1Content = await response1.Content.ReadAsStringAsync();
                                        MessageBox.Show("Error: " + error1Content);
                                    }
                                }
                                catch (Exception ex1)
                                {
                                    // Handle any exceptions that occur
                                    MessageBox.Show("Exception: " + ex1.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            
                            // MB debug
                            //MessageBox.Show(resRoute, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                        MessageBox.Show("Invalid request!! Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // MB debug
            //MessageBox.Show(t1[0] + t2[0]);
        }
        public class Tram
        {
            [JsonProperty("id_Tram")]
            public string id { get; set; }
            [JsonProperty("tenTram")]
            public string name { get; set; }
            [JsonProperty("thanhpho")]
            public string city { get; set; }
            [JsonProperty("tinh")]
            public string province { get; set; }

        }
        public class LichTrinh 
        {
            [JsonProperty("iD_LichTrinh")]
            public string idlt { get; set; } 
            [JsonProperty("iD_Tau")]
            public string idtau { get; set; }
            [JsonProperty("gio")]
            public string gio { get; set; }
            [JsonProperty("thu")]
            public int thu { get; set; }
            [JsonProperty("chieu")]
            public int chieu { get; set; }
        }

        private void LabelDepatureDate_Paint(object sender, PaintEventArgs e) { }
    }
}
