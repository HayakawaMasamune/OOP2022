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

            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{tbArea.Text}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbpublishingOffice.Text = json.publishingOffice;
            tbWeatherInfo.Text = json.text;
            tbDateTime.Text = json.reportDatetime.ToString();

        }

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArea.Text == "北海道地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        tbArea.Text = "011000";
                        break;
                    case 1:
                        tbArea.Text = "012000";
                        break;
                    case 2:
                        tbArea.Text = "013000";
                        break;
                    case 4:
                        tbArea.Text = "014030";
                        break;
                    case 5:
                        tbArea.Text = "014100";
                        break;
                    case 6:
                        tbArea.Text = "015000";
                        break;
                    case 7:
                        tbArea.Text = "016000";
                        break;
                    case 8:
                        tbArea.Text = "01000";
                        break;
                }

            } else if (cbArea.Text == "東北地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        tbArea.Text = "020000";
                        break;
                    case 1:
                        tbArea.Text = "030000";
                        break;
                    case 2:
                        tbArea.Text = "040000";
                        break;
                    case 4:
                        tbArea.Text = "050000";
                        break;
                    case 5:
                        tbArea.Text = "060000";
                        break;
                    case 6:
                        tbArea.Text = "070000";
                        break;
                }

            } else if (cbArea.Text == "関東甲信地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        tbArea.Text = "080000";
                        break;
                    case 1:
                        tbArea.Text = "090000";
                        break;
                    case 2:
                        tbArea.Text = "100000";
                        break;
                    case 3:
                        tbArea.Text = "110000";
                        break;
                    case 4:
                        tbArea.Text = "120000";
                        break;
                    case 5:
                        tbArea.Text = "130000";
                        break;
                    case 6:
                        tbArea.Text = "140000";
                        break;
                    case 7:
                        tbArea.Text = "190000";
                        break;
                    case 8:
                        tbArea.Text = "200000";
                        break;
                }

            } else if (cbArea.Text == "東海地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        tbArea.Text = "210000";
                        break;
                    case 1:
                        tbArea.Text = "220000";
                        break;
                    case 2:
                        tbArea.Text = "230000";
                        break;
                    case 3:
                        tbArea.Text = "240000";
                        break;
                }

            } else if (cbArea.Text == "北陸地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        tbArea.Text = "150000";
                        break;
                    case 1:
                        tbArea.Text = "160000";
                        break;
                    case 2:
                        tbArea.Text = "170000";
                        break;
                    case 3:
                        tbArea.Text = "180000";
                        break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbArea.Items.Add("北海道地方");//0
            cbArea.Items.Add("東北地方");//1
            cbArea.Items.Add("関東甲信地方");//2
            cbArea.Items.Add("東海地方");//3
            cbArea.Items.Add("北陸地方");//4
            cbArea.Items.Add("近畿地方");//5
            cbArea.Items.Add("中国地方");//6
            cbArea.Items.Add("四国地方");//7
            cbArea.Items.Add("九州北部地方");//8
            cbArea.Items.Add("九州南部・奄美地方");//9
            cbArea.Items.Add("沖縄地方");//10
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {        
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            cbPlace.Items.Clear();//初期化

            switch (cbArea.SelectedIndex) {
                case 0:
                    cbPlace.Items.Add("宗谷地方");//0 
                    cbPlace.Items.Add("上川・留萌地方");//1
                    cbPlace.Items.Add("網走・北見・紋別地方");//2
                    cbPlace.Items.Add("十勝地方");//3
                    cbPlace.Items.Add("釧路・根室地方");//4
                    cbPlace.Items.Add("胆振・日高地方");//5
                    cbPlace.Items.Add("石狩・空知・後志地方");//6
                    cbPlace.Items.Add("渡島・檜山地方");//7
                    break;
                case 1:
                    cbPlace.Items.Add("青森県");//0
                    cbPlace.Items.Add("岩手県");//1
                    cbPlace.Items.Add("宮城県");//2
                    cbPlace.Items.Add("秋田県");//3
                    cbPlace.Items.Add("山形県");//4
                    cbPlace.Items.Add("福島県");//5
                    break;
                case 2:
                    cbPlace.Items.Add("茨城県");//0
                    cbPlace.Items.Add("栃木県");//1
                    cbPlace.Items.Add("群馬県");//2
                    cbPlace.Items.Add("埼玉県");//3
                    cbPlace.Items.Add("千葉県");//4
                    cbPlace.Items.Add("東京都");//5
                    cbPlace.Items.Add("神奈川県");//6
                    cbPlace.Items.Add("山梨県");//7
                    cbPlace.Items.Add("長野県");//8
                    break;
                case 3:
                    cbPlace.Items.Add("岐阜県");//0
                    cbPlace.Items.Add("静岡県");//1
                    cbPlace.Items.Add("愛知県");//2
                    cbPlace.Items.Add("三重県");//3
                    break;
                case 4:
                    cbPlace.Items.Add("新潟県");//0
                    cbPlace.Items.Add("富山県");//1
                    cbPlace.Items.Add("石川県");//2
                    cbPlace.Items.Add("福井県");//3
                    break;
                case 5:
                    cbPlace.Items.Add("滋賀県");//0
                    cbPlace.Items.Add("京都府");//1
                    cbPlace.Items.Add("大阪府");//2
                    cbPlace.Items.Add("兵庫県");//3
                    cbPlace.Items.Add("奈良県");//4
                    cbPlace.Items.Add("和歌山県");//5
                    break;
                case 6:
                    cbPlace.Items.Add("鳥取県");//0
                    cbPlace.Items.Add("島根県");//1
                    cbPlace.Items.Add("岡山県");//2
                    cbPlace.Items.Add("広島県");//3
                    break;
                case 7:
                    cbPlace.Items.Add("徳島県");//0
                    cbPlace.Items.Add("香川県");//1
                    cbPlace.Items.Add("愛媛県");//2
                    cbPlace.Items.Add("高知県");//3
                    break;
                case 8:
                    cbPlace.Items.Add("山口県");//0
                    cbPlace.Items.Add("福島県");//1
                    cbPlace.Items.Add("佐賀県");//2
                    cbPlace.Items.Add("長崎県");//3
                    cbPlace.Items.Add("熊本県");//4
                    cbPlace.Items.Add("大分県");//5
                    cbPlace.Items.Add("宮崎県");//6
                    cbPlace.Items.Add("鹿児島県");//7
                    break;
                case 9:
                    cbPlace.Items.Add("沖縄本島地方");//0
                    cbPlace.Items.Add("大東島地方");//1
                    cbPlace.Items.Add("宮古島地方");//2
                    cbPlace.Items.Add("八重山地方");//3
                    break;
            }
        }
    }
}
       
