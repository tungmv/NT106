using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;

namespace Train_Booking_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password entered by the user
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Create an IronPython engine
            ScriptEngine engine = Python.CreateEngine();

            // Create a scope (a namespace) for the script to run in
            ScriptScope scope = engine.CreateScope();

            // Set the parameter value in the scope
            scope.SetVariable("url", "https://9696-2402-800-6312-4844-392a-e065-739a-694f.ngrok-free.app/api/Auth/adminlogin");
            scope.SetVariable("username", username);
            scope.SetVariable("password", password);
            string pythonScript = @"
import http.client
import json

# Headers
headers = {
    'accept': '*/*',
    'Content-Type': 'application/json'
}

payload = {
    ""id"": username,
    ""password"": password
}

# Make the POST request
conn = http.client.HTTPSConnection(url)
json_payload = json.dumps(payload)
conn.request(""POST"", ""/api/Auth/adminlogin"", body=json_payload, headers=headers)
response = conn.getresponse()
data = response.read()
conn.close()

# Check if the request was successful (status code 200)
if response.status == 200:
    print('OK')
    print(data.decode())
else:
    print(f""Failed to retrieve data: {response.status}"")
";
            try
            {
                // Execute the Python script
                engine.Execute(pythonScript, scope);

                // Access the result from the Python script
                string result = scope.GetVariable<string>("result");
                MessageBox.Show(result); // Output: Hello, John
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            // DEBUG
            MessageBox.Show($"Password entered: {password}");
        }
    }
}
