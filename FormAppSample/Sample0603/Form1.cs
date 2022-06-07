using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class form1 : Form {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //ボタンクリックハンドラ
        private void button1_Click(object sender, EventArgs e)
        {
            //btPush.Text = "７７７";

            //var S1 = int.Parse(btSuu1.Text);

            //var S2 = int.Parse(btSuu2.Text);

            //var anser = S1 + S2;

            //Ans.Text = anser.ToString();

           // nudAns.Value = nudSuu1.Value + nudSuu2.Value;

        }
        private void btPush_MouseHover(object sender, EventArgs e)
        {
           // btPush.Text = "逃げちゃだめだ";
          
        }

        private void puls_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown3_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
