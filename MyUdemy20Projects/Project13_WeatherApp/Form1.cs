using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project13_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city?city=İstanbul&lang=EN"),
                Headers =
                {
                    { "x-rapidapi-key", "36c4a561d3msh98a5808fce60b22p1014d9jsn6a4f5ff0c4c0" },
                    { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
                 },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var fahrenheit = json["main"]["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                lblFahrenheit.Text = fahrenheit;
                lblHumidity.Text = humidity;
                lblWindSpeed.Text = windSpeed;
                double celsius = (double.Parse(fahrenheit) - 32);
                double celciusValue = celsius / 1.8;
                lblCelsius.Text = celciusValue.ToString("0.00");
                var weather = json["weather"][0]["main"].ToString();
                string filePath = "C:\\Users\\esind\\Desktop\\20-Projects-with-CSharp\\MyUdemy20Projects\\Project13_WeatherApp\\images\\";
                string fileName = "";

                switch (weather)
                {
                    case "Clouds":
                        fileName = "cloud.png";
                        break;
                    case "Clear":
                        fileName = "sun.png";
                        break;
                    case "Snow":
                        fileName = "snow.png";
                        break;
                    case "Rain":
                        fileName = "rainy.png";
                        break;

                }

                string imagePath = Path.Combine(filePath, fileName);

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
