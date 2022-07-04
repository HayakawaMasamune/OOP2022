
namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btRssGet = new System.Windows.Forms.Button();
            this.lbRssTitel = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btForward = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(24, 12);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(593, 20);
            this.cbRssUrl.TabIndex = 0;
            // 
            // btRssGet
            // 
            this.btRssGet.Location = new System.Drawing.Point(623, 10);
            this.btRssGet.Name = "btRssGet";
            this.btRssGet.Size = new System.Drawing.Size(75, 23);
            this.btRssGet.TabIndex = 1;
            this.btRssGet.Text = "取得";
            this.btRssGet.UseVisualStyleBackColor = true;
            this.btRssGet.Click += new System.EventHandler(this.btRssGet_Click);
            // 
            // lbRssTitel
            // 
            this.lbRssTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRssTitel.FormattingEnabled = true;
            this.lbRssTitel.ItemHeight = 12;
            this.lbRssTitel.Location = new System.Drawing.Point(24, 47);
            this.lbRssTitel.Name = "lbRssTitel";
            this.lbRssTitel.Size = new System.Drawing.Size(261, 592);
            this.lbRssTitel.TabIndex = 2;
            this.lbRssTitel.SelectedIndexChanged += new System.EventHandler(this.lbRssTitel_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(291, 47);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(475, 592);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // btForward
            // 
            this.btForward.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForward.Location = new System.Drawing.Point(758, 7);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(30, 31);
            this.btForward.TabIndex = 4;
            this.btForward.Text = "→";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(722, 7);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(30, 31);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // wvBrowser
            // 
            this.wvBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wvBrowser.Location = new System.Drawing.Point(291, 47);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(461, 592);
            this.wvBrowser.TabIndex = 5;
            this.wvBrowser.DOMContentLoaded += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(this.wvBrowser_DOMContentLoaded);
            this.wvBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrowser_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lbRssTitel);
            this.Controls.Add(this.btRssGet);
            this.Controls.Add(this.cbRssUrl);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btRssGet;
        private System.Windows.Forms.ListBox lbRssTitel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btBack;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

