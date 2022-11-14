using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        //取得クリック
        private void btWeatherGet_Click(object sender, EventArgs e)
        {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{textBox1.Text}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbpublishingOffice.Text = json.publishingOffice;
            tbWeatherInfo.Text = json.text;
            tbDateTime.Text = json.reportDatetime.ToString();

              
        }

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();

            cb.Items.Add("北海道");
            cb.Items.Add("東京");
        }
    }
}//
