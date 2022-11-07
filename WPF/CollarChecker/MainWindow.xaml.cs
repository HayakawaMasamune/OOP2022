using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    /// 
    public partial class MainWindow : Window {
        //コンストラクタ
        public MainWindow()
        {
            InitializeComponent();

            DataContext = GetColorList(); //←追加
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList()
        {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
        }

        //テキストボックスの値を元に色を設定
        private void setColor(object sender)
        {

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            colorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
        }


        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            colorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
            RedSlider.Value = color.R;
            GreenSlider.Value = color.G;
            //BlueSlider.Value = color.B;

            

        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            var mycolor = (MyColor)colorbox.SelectedItem;
            var color = mycolor.Color;
            var colorR = RedSlider.Value;
            var colorG = GreenSlider.Value;
            var colorB = BlueSlider.Value;
            var colorRGB = "R:" + colorR + "G:" +  colorG + "B:" +  colorB;
            List<string> colors = new List<string>();
            colors.Add(colorRGB);

            foreach (var item in colors) {
                StockList.Items.Add(item);
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            StockList.Items.RemoveAt(0);
        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
