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
    public partial class nudNum : Form 
        
        {

        Random r = new Random();
        public nudNum()
        {
            InitializeComponent();
        }
        private void nud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

          num1.Value = r.Next(minValue: (int)minNum.Value, maxValue: (int)maxNum.Value + 1);

           
        }
    }
}
