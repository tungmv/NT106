using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Train_Booking_System.TrainBookingFormStep1;

namespace Train_Booking_System
{

    public partial class TrainBookingFormStep2 : Form
    {
        public string id_user { get; set; } // id user
        public string origin { get; set; }
        public string destination { get; set; }
        public string TrainId { get; set; }
        
        private const string TrainIdUrl = "http://localhost:5009/api/Train/";
        public string ghe;

        private Mainform mainform;
        public TrainBookingFormStep2(Mainform mainform, string _trainId)
        {
            this.mainform = mainform;
            TrainId = _trainId;
            InitializeComponent();
            InitializeKryptonButtons();
        }
        private KryptonButton selectedButton;



        private void ButtonNext_Click(object sender, EventArgs e)
        {
            //open the next form
            TrainBookingFormStep3 trainBookingFormStep3 = new TrainBookingFormStep3(mainform);
            //reference to mainform
            trainBookingFormStep3.MdiParent = mainform;
            trainBookingFormStep3.Dock = DockStyle.Fill;
            // Pass args
            trainBookingFormStep3.id_user = id_user; // id_Khachhang
            trainBookingFormStep3.get_ghe = ghe;
            trainBookingFormStep3.origin = origin;
            trainBookingFormStep3.destination = destination;
            // MB debug
            //MessageBox.Show(trainBookingFormStep3.get_ghe);
            //MessageBox.Show(trainBookingFormStep3.origin);
            //MessageBox.Show(trainBookingFormStep3.destination);
            
            trainBookingFormStep3.Show();
        }

        private async void InitializeKryptonButtons()
        {
            // Send a get request to train endpoint to fetch in available seats
            string url = ngrokURL.Url + "/api/Train/" + TrainId;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "text/plain");
                List<string> availableIDs = new List<string>();
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    // We get the IDs for Cars only:
                    string responseContent = await response.Content.ReadAsStringAsync();
                    // Parse to JSOn
                    var jsonResponse = JObject.Parse(responseContent);
                    var carIDarray = (JArray)jsonResponse["cars"];
                    List<Car> listCar = carIDarray.ToObject<List<Car>>();
                    // manually assign each car's ID to the car UI picturebox's tag
                    pictureBox20.Tag = listCar[0].ID_Toa;
                    pictureBox19.Tag = listCar[1].ID_Toa;
                    pictureBox18.Tag = listCar[2].ID_Toa;
                    pictureBox17.Tag = listCar[3].ID_Toa;
                    pictureBox20_Click(pictureBox20, EventArgs.Empty);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error while loading seats/beds: {ex.Message}");
                }
            }
        }

        private void KryptonButton_Click(object sender, EventArgs e)
        {
            KryptonButton clickedButton = sender as KryptonButton;

            if (clickedButton != null)
            {
                // Deselect the previously selected button
                if (selectedButton != null && selectedButton != clickedButton)
                {
                    selectedButton.StateNormal.Back.Color1 = SystemColors.Control; // default color
                }

                // Select the new button
                clickedButton.StateNormal.Back.Color1 = Color.LightBlue; // selected color
                selectedButton = clickedButton;
                ghe = clickedButton.Name.Substring(1);
                

                MessageBox.Show($"Ghe {ghe} was selected.", "Button Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TrainBookingFormStep2_Load(object sender, EventArgs e)
        {

        }

        public class Car
        {
            [JsonProperty("iD_Toa")]
            public string ID_Toa { get; set; }
        }

        public class Ghe
        {
            [JsonProperty("ghe")]
            public string ID_Ghe { get; set; }
        }

        private async void pictureBox20_Click(object sender, EventArgs e)
        {
            List<Ghe> listGhe = new List<Ghe>();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("accept", "text/plain");
                List<string> availableIDs = new List<string>();
                try
                {
                    HttpResponseMessage response = await client.GetAsync(ngrokURL.Url + "/api/Train/car/" + pictureBox20.Tag.ToString());
                    // We get the available seats for the current car when user click the picturebox representing it
                    string responseContent = await response.Content.ReadAsStringAsync();
                    // Parse to JSOn
                    var jsonResponse = JObject.Parse(responseContent);
                    JArray responseArray = (JArray)jsonResponse["response"];
                    foreach (JObject car in responseArray)
                    {
                        // Get the ghe array
                        JArray gheArray = (JArray)car["ghe"];

                        // Convert each item in the ghe array to a Ghe object
                        foreach (JToken gheToken in gheArray)
                        {
                            Ghe ghe = new Ghe { ID_Ghe = gheToken.ToString() };
                            listGhe.Add(ghe);
                        }
                    }

                    // manually assign each car's ID to the car UI picturebox's tag


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while loading seats/beds for car {pictureBox20.Tag.ToString()}: {ex.Message}");
                }
            }

            for (int i = 1; i <= 40; i++)
            {
                HashSet<string> availableSeatIDs = new HashSet<string>(listGhe.Select(seat => seat.ID_Ghe));
                string seatIndex = i.ToString("00"); // format i as a 2 digit numbers for ease of mind
             
                KryptonButton button = this.Controls.Find($"g{seatIndex}", true).FirstOrDefault() as KryptonButton;
                if (button != null)
                {
                    if (availableSeatIDs.Contains(seatIndex))
                    {
                        // Seat is available, assign the click event
                        button.Click += KryptonButton_Click;
                    }
                    else
                    {
                        // Seat is not available, change its color to gray
                        button.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
                        button.Enabled = false; // Optional: disable the button
                    }
                }
            }
        }
    }
    }
