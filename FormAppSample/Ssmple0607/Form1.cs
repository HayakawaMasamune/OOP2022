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
    public partial class nudNum : Form {
        public nudNum()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (nudNum2.Value != 0) {

                nudAns.Value = nudNum1.Value / nudNum2.Value;

                nudAma.Value = nudNum1.Value % nudNum2.Value;

            } else {
                MessageBox.Show("0で割り切れません", "エラー",

               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void btnum1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudNum2_Load(object sender, EventArgs e)
        {

        }
    }
}
