using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void adressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202219DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Validate();
            this.adressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202219DataSet);

        }

        private void btConect_Click(object sender, EventArgs e)
        {
            this.adressTableTableAdapter.Fill(this.infosys202219DataSet.AdressTable);
        }     


        private void btUpdate_Click(object sender, EventArgs e)
        {
            //各テキストボックスからデータグリッドビューへ設定
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            //addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);


            //データセットの中をデータベースへ反映（保存）
            // TODO: このコード行はデータを 'infosys202219DataSet.AdressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.Validate();
            this.adressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202219DataSet);

        }

        private void btImageOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = infosys202219DataSet.AdressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;

            infosys202219DataSet.AdressTable.Rows.Add(newRow);
            this.adressTableTableAdapter.Update(this.infosys202219DataSet.AdressTable);

        }

        private void addressTableDataGridView_Click(object sender, EventArgs e)
        {
            if (addressTableDataGridView.CurrentRow == null)
                return;

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTel.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!DBNull.Value.Equals(addressTableDataGridView.CurrentRow.Cells[6].Value))
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            else
                pbImage.Image = null;
        }

        private void addressTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btNameSerch_Click(object sender, EventArgs e)
        {
            adressTableTableAdapter.FillByName(infosys202219DataSet.AdressTable, tbSerchName.Text);

        }
    }
}
