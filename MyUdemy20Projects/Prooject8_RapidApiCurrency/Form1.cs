﻿using Newtonsoft.Json.Linq;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Prooject8_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal dollar = 0;
        decimal euro = 0;
        decimal pound = 0;
        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Dollar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "36c4a561d3msh98a5808fce60b22p1014d9jsn6a4f5ff0c4c0" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDolar.Text = "Dolar: "+value;
                dollar = decimal.Parse(value);
                //  Console.WriteLine(body);
            }
            #endregion
            #region Euro
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "36c4a561d3msh98a5808fce60b22p1014d9jsn6a4f5ff0c4c0" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text ="Euro: " + value2;
                euro = decimal.Parse(value2);
                //Console.WriteLine(body2);
            }
            #endregion
            #region Pound
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "36c4a561d3msh98a5808fce60b22p1014d9jsn6a4f5ff0c4c0" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblPound.Text = "Pound: "+value3;
                pound = decimal.Parse(value3);
                //Console.WriteLine(body2);
            }
            #endregion
            txtTotalPrice.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);

            decimal totalPrice = 0;

            if (rdbDolar.Checked)
            {
                totalPrice = unitPrice * dollar;
            }
            if (rdbEuro.Checked)
            {
                totalPrice = unitPrice * euro;
            }
            if (rdbPound.Checked)
            {
                totalPrice = unitPrice * pound;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
