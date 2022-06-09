using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ssmple0607 {
    public partial class Form2 : Form {

        private int randomNumber;

        private Random r = new Random();

        

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            randomNumber = r.Next(1,(int)nudNum1.Value);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudNam1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
          if(randomNumber > nudNum2.Value) {

                ans.Text = "大きい値";
            } else {
                if(randomNumber < nudNum2.Value) {
                    ans.Text = "小さい値";
                } else {
                    ans.Text = "等しい";
                }
            }
        }

        
    }
}
