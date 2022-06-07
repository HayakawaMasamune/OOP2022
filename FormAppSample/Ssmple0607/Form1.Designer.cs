
namespace Ssmple0607 {
    partial class nudNum {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Waru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.nudNum1 = new System.Windows.Forms.NumericUpDown();
            this.nudNum2 = new System.Windows.Forms.NumericUpDown();
            this.nudAns = new System.Windows.Forms.NumericUpDown();
            this.nudAma = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Waru
            // 
            this.Waru.AutoSize = true;
            this.Waru.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Waru.Location = new System.Drawing.Point(300, 99);
            this.Waru.Name = "Waru";
            this.Waru.Size = new System.Drawing.Size(54, 37);
            this.Waru.TabIndex = 5;
            this.Waru.Text = "÷";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(499, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "＝";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(721, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "あまり";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button.Location = new System.Drawing.Point(432, 203);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(171, 78);
            this.button.TabIndex = 6;
            this.button.Text = "計算";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // nudNum1
            // 
            this.nudNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum1.Location = new System.Drawing.Point(145, 100);
            this.nudNum1.Name = "nudNum1";
            this.nudNum1.Size = new System.Drawing.Size(120, 44);
            this.nudNum1.TabIndex = 7;
            this.nudNum1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudNum2
            // 
            this.nudNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum2.Location = new System.Drawing.Point(360, 103);
            this.nudNum2.Name = "nudNum2";
            this.nudNum2.Size = new System.Drawing.Size(120, 44);
            this.nudNum2.TabIndex = 8;
            // 
            // nudAns
            // 
            this.nudAns.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAns.Location = new System.Drawing.Point(595, 103);
            this.nudAns.Name = "nudAns";
            this.nudAns.Size = new System.Drawing.Size(120, 44);
            this.nudAns.TabIndex = 9;
            // 
            // nudAma
            // 
            this.nudAma.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAma.Location = new System.Drawing.Point(860, 103);
            this.nudAma.Name = "nudAma";
            this.nudAma.Size = new System.Drawing.Size(120, 44);
            this.nudAma.TabIndex = 10;
            // 
            // nudNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 525);
            this.Controls.Add(this.nudAma);
            this.Controls.Add(this.nudAns);
            this.Controls.Add(this.nudNum2);
            this.Controls.Add(this.nudNum1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Waru);
            this.Controls.Add(this.label1);
            this.Name = "nudNum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.nudNum2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Waru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.NumericUpDown nudNum1;
        private System.Windows.Forms.NumericUpDown nudNum2;
        private System.Windows.Forms.NumericUpDown nudAns;
        private System.Windows.Forms.NumericUpDown nudAma;
    }
}

