using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        
        public string areaCode; //エリアコード


        //天気取得
        private void WeatherGet(string areacode)
        {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{areacode}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            publishingOffice.Text = json.publishingOffice;
            tbWeatherInfo.Text = json.text;
            DateTime1.Text = json.reportDatetime.ToString();
        }

        //地域からエリアコード
        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbArea.Text == "北海道地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "011000";
                        break;
                    case 1:
                        areaCode = "012000";
                        break;
                    case 2:
                        areaCode = "013000";
                        break;
                    case 3:
                        areaCode = "014030";
                        break;
                    case 4:
                        areaCode = "014100";
                        break;
                    case 5:
                        areaCode = "015000";
                        break;
                    case 6:
                        areaCode = "016000";
                        break;
                    case 7:
                        areaCode = "017000";
                        break;
                }

                WeatherGet(areaCode);

            } else if (cbArea.Text == "東北地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "020000";
                        break;
                    case 1:
                        areaCode = "030000";
                        break;
                    case 2:
                        areaCode = "040000";
                        break;
                    case 4:
                        areaCode = "050000";
                        break;
                    case 5:
                        areaCode = "060000";
                        break;
                    case 6:
                        areaCode = "070000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "関東甲信地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "080000";
                        break;
                    case 1:
                        areaCode = "090000";
                        break;
                    case 2:
                        areaCode = "100000";
                        break;
                    case 3:
                        areaCode = "110000";
                        break;
                    case 4:
                        areaCode = "120000";
                        break;
                    case 5:
                        areaCode = "130000";
                        break;
                    case 6:
                        areaCode = "140000";
                        break;
                    case 7:
                        areaCode = "190000";
                        break;
                    case 8:
                        areaCode = "200000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "東海地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "210000";
                        break;
                    case 1:
                        areaCode = "220000";
                        break;
                    case 2:
                        areaCode = "230000";
                        break;
                    case 3:
                        areaCode = "240000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "北陸地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "150000";
                        break;
                    case 1:
                        areaCode = "160000";
                        break;
                    case 2:
                        areaCode = "170000";
                        break;
                    case 3:
                        areaCode = "180000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "近畿地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "250000";
                        break;
                    case 1:
                        areaCode = "260000";
                        break;
                    case 2:
                        areaCode = "270000";
                        break;
                    case 3:
                        areaCode = "280000";
                        break;
                    case 4:
                        areaCode = "290000";
                        break;
                    case 5:
                        areaCode = "300000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "中国地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "310000";
                        break;
                    case 1:
                        areaCode = "320000";
                        break;
                    case 2:
                        areaCode = "330000";
                        break;
                    case 3:
                        areaCode = "340000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "九州北部地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "350000";
                        break;
                    case 1:
                        areaCode = "400000";
                        break;
                    case 2:
                        areaCode = "410000";
                        break;
                    case 3:
                        areaCode = "420000";
                        break;
                    case 4:
                        areaCode = "430000";
                        break;
                    case 5:
                        areaCode = "440000";
                        break;
                }
                WeatherGet(areaCode);

            } else if (cbArea.Text == "九州南部・奄美地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "450000";
                        break;
                    case 1:
                        areaCode = "460000";
                        break;
                    case 2:
                        areaCode = "460100";
                        break;
                }
                WeatherGet(areaCode);
            } 
            else if (cbArea.Text == "沖縄地方") {
                switch (cbPlace.SelectedIndex) {
                    case 0:
                        areaCode = "471000";
                        break;
                    case 1:
                        areaCode = "472000";
                        break;
                    case 2:
                        areaCode = "473000";
                        break;
                    case 3:
                        areaCode = "474000";
                        break;
                }
                WeatherGet(areaCode);
            }         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //背景
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile("東京.jpg");

            //地方コンボボックス
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

            cbArea.SelectedIndex = 2;
            cbPlace.SelectedIndex = 5;
            WeatherGet(areaCode);
        }
     //地域コンボボックス
        private void Select_Click(object sender, EventArgs e)
        {
            //初期化
            cbPlace.Items.Clear();
            cbPlace.Text = null;

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
       
