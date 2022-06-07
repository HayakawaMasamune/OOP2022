
namespace Sample0603 {
    partial class form1 {
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
            this.btPush = new System.Windows.Forms.Button();
            this.btSuu1 = new System.Windows.Forms.TextBox();
            this.btSuu2 = new System.Windows.Forms.TextBox();
            this.puls = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.nudSuu1 = new System.Windows.Forms.DomainUpDown();
            this.nudSuu2 = new System.Windows.Forms.DomainUpDown();
            this.nudAns = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // btPush
            // 
            this.btPush.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btPush.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPush.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPush.Location = new System.Drawing.Point(147, 120);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(247, 155);
            this.btPush.TabIndex = 0;
            this.btPush.Text = "押せ！";
            this.btPush.UseVisualStyleBackColor = false;
            this.btPush.Click += new System.EventHandler(this.button1_Click);
            this.btPush.MouseHover += new System.EventHandler(this.btPush_MouseHover);
            // 
            // btSuu1
            // 
            this.btSuu1.Location = new System.Drawing.Point(55, 29);
            this.btSuu1.Name = "btSuu1";
            this.btSuu1.Size = new System.Drawing.Size(65, 19);
            this.btSuu1.TabIndex = 1;
            // 
            // btSuu2
            // 
            this.btSuu2.Location = new System.Drawing.Point(190, 29);
            this.btSuu2.Name = "btSuu2";
            this.btSuu2.Size = new System.Drawing.Size(66, 19);
            this.btSuu2.TabIndex = 2;
            // 
            // puls
            // 
            this.puls.AutoSize = true;
            this.puls.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.puls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.puls.Location = new System.Drawing.Point(132, 29);
            this.puls.Name = "puls";
            this.puls.Size = new System.Drawing.Size(42, 29);
            this.puls.TabIndex = 3;
            this.puls.Text = "＋";
            this.puls.Click += new System.EventHandler(this.puls_Click);
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(329, 29);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(77, 19);
            this.Ans.TabIndex = 4;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.Location = new System.Drawing.Point(280, 29);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(42, 29);
            this.equal.TabIndex = 5;
            this.equal.Text = "＝";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(0, 0);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 19);
            this.domainUpDown1.TabIndex = 6;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // nudSuu1
            // 
            this.nudSuu1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSuu1.Location = new System.Drawing.Point(78, 335);
            this.nudSuu1.Name = "nudSuu1";
            this.nudSuu1.Size = new System.Drawing.Size(65, 31);
            this.nudSuu1.TabIndex = 7;
            this.nudSuu1.Text = "0";
            // 
            // nudSuu2
            // 
            this.nudSuu2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSuu2.Location = new System.Drawing.Point(239, 335);
            this.nudSuu2.Name = "nudSuu2";
            this.nudSuu2.Size = new System.Drawing.Size(66, 31);
            this.nudSuu2.TabIndex = 8;
            this.nudSuu2.Text = "0";
            this.nudSuu2.SelectedItemChanged += new System.EventHandler(this.domainUpDown3_SelectedItemChanged);
            // 
            // nudAns
            // 
            this.nudAns.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAns.Location = new System.Drawing.Point(390, 335);
            this.nudAns.Name = "nudAns";
            this.nudAns.Size = new System.Drawing.Size(42, 31);
            this.nudAns.TabIndex = 9;
            this.nudAns.Text = "0";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(562, 453);
            this.Controls.Add(this.nudAns);
            this.Controls.Add(this.nudSuu2);
            this.Controls.Add(this.nudSuu1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.puls);
            this.Controls.Add(this.btSuu2);
            this.Controls.Add(this.btSuu1);
            this.Controls.Add(this.btPush);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "form1";
            this.Tag = "";
            this.Text = "押す";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.TextBox btSuu1;
        private System.Windows.Forms.TextBox btSuu2;
        private System.Windows.Forms.Label puls;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown nudSuu1;
        private System.Windows.Forms.DomainUpDown nudSuu2;
        private System.Windows.Forms.DomainUpDown nudAns;
    }
}

