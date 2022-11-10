using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    /// 
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor>();

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
            setColor();
           // colorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
        }

        //テキストボックスの値を元に色を設定
        private void setColor()
        {
           var r = byte.Parse(rValue.Text);
           var g = byte.Parse(gValue.Text);
           var b = byte.Parse(bValue.Text);
           Color color = Color.FromRgb(r, g, b);
            colorLabel.Background = new SolidColorBrush(color);
           //var mycolor = (MyColor)((ComboBox).).SelectedItem;
           //var color = mycolor.Color;
           //var name = mycolor.Name;
          // colorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
        }


        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

          
            RedSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            GreenSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            BlueSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            setColor();


        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            MyColor mycolor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            mycolor.Color = Color.FromRgb(r, g, b);
    

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                        .Where(c => c.Color.R == mycolor.Color.R &&
                                                    c.Color.G == mycolor.Color.G &&
                                                    c.Color.B == mycolor.Color.B).FirstOrDefault();


            StockList.Items.Insert(0, colorName?.Name ?? "R:" + r + "G;" + g + "B:" + b);
            colorList.Insert(0,mycolor);
            //    foreach (var item in colors) {
            //        StockList.Items.Add(item);
            //    }
            //}
            //private void Delete_Click(object sender, RoutedEventArgs e)
            //{
            //    StockList.Items.RemoveAt(0);
            //}

        }
        private MyColor getMyColor(byte r,byte g, byte b)
        {
            return new MyColor {
                Color = Color.FromRgb(r, g, b),
                Name = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == r &&
                                            c.Color.G == g &&
                                            c.Color.B == b)
                                .Select(c => c.Name).FirstOrDefault(),
            };
        }

        private void stockList_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            if (StockList.SelectedIndex == -1) return;
            RedSlider.Value = colorList[StockList.SelectedIndex].Color.R;
            GreenSlider.Value = colorList[StockList.SelectedIndex].Color.G;
            BlueSlider.Value = colorList[StockList.SelectedIndex].Color.B;
            setColor();
        }

        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }
        //DELETE
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var delIndex = StockList.SelectedIndex;
            if (StockList.SelectedIndex == -1) return;

            StockList.Items.RemoveAt(StockList.SelectedIndex);
            colorList.RemoveAt(delIndex);
        }
    }
}
