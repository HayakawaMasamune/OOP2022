using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        
        int ans = GetRandom();

        public MainWindow()
        {
            InitializeComponent();
            infoDisp.Text = "スタート";
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;       
            

            if(bt.Content.ToString() == ans.ToString()) {
                infoDisp.Text = "あたり";
                bt.Background = Brushes.Red;

            } else {
                infoDisp.Text = int.Parse((string)bt.Content) < ans ? "もっと大きい" : "もっと小さい"; //"はずれ";

                bt.Background = int.Parse((string)bt.Content) < ans ? Brushes.Blue : Brushes.Green ;
            }

        }
        private static int GetRandom()//正解ナンバー
        {
            Random rnd = new Random();
            var r =  rnd.Next(1, 26);
            return r;
        }
    }
}
