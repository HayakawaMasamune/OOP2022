﻿using System.Linq;
using System.Reflection;
using System.Windows;
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

        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //colorLabel.Background = new SolidColorBrush(colorbox.SelectedItem);
        }
    }
}
