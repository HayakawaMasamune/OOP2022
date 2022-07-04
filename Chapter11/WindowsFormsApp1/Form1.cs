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
using System.Xml.Linq;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {

        IEnumerable<string> xTitel,xLink;

        public Form1()
        {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssUrl.Text);


                var xdoc = XDocument.Load(stream);
                var xNews = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));

                foreach (var date in xNews) {
                    lbRssTitel.Items.Add(date);
                }
                
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btForward_Click(object sender, EventArgs e)
        {
            wvBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackFrowardMaskCheck();


        }

        private void btBack_Click(object sender, EventArgs e)
        {
            wvBrowser.GoBack();
        }

        private void wvBrowser_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {

        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            BackFrowardMaskCheck();

        }
        private void BackFrowardMaskCheck()
        {
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }
            

        private void lbRssTitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbRssTitel.SelectedIndex;
            if (index == 1) return;
            //選択したインデックスを取得（0～）

            var url = xLink.ElementAt(index);

            wvBrowser.Source = new Uri(url);
        }
    }
}
