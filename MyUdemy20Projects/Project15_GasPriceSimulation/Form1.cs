using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dieselPrice = 0;
        double gasolinePrice = 0;
        double lpgPrice = 0;
        double gasAmount = 0;
        double dieselAmount = 0;
        double lpgAmount = 0;
        double totalPrice = 0;
        int count = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = count.ToString();
            if (rdbGasoline.Checked)
            {
                count++;
                if (count <= gasAmount)
                {
                    totalPrice += gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }

            if (rdbLPG.Checked)
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            int euro = 47;

            txtDieselPrice.Text = dieselPrice.ToString() + " ₺";
            txtGasolinePrice.Text = gasolinePrice.ToString() + " ₺";
            txtLPGPrice.Text = lpgPrice.ToString() + " ₺";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://gas-price.p.rapidapi.com/europeanCountries"),
                Headers =
    {
        { "x-rapidapi-key", "36c4a561d3msh98a5808fce60b22p1014d9jsn6a4f5ff0c4c0" },
        { "x-rapidapi-host", "gas-price.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var lpgValue = json["results"][42]["lpg"].ToString();
                var dieselValue = json["results"][42]["diesel"].ToString();
                var gasolineValue = json["results"][42]["gasoline"].ToString();
                dieselPrice = double.Parse(dieselValue) * euro;
                gasolinePrice = double.Parse(gasolineValue) * euro;
                lpgPrice = double.Parse(lpgValue) * euro;

                txtDieselPrice.Text = dieselPrice.ToString("0.00") + " ₺";
                txtGasolinePrice.Text = gasolinePrice.ToString("0.00") + " ₺";
                txtLPGPrice.Text = lpgPrice.ToString("0.00") + " ₺";

            }
        }
    }
}
