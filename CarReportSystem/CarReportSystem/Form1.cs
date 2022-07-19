using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        Settings settings = new Settings();
        
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        int mode = 0;
        public Form1()
        {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //アプリケーションの終了
            Application.Exit();
        }


        private List<CarReport.MakerGroup> GetRdioBoxGroup()
        {
            var listGroup = new List<CarReport.MakerGroup>();

            if (rb1.Checked) {
                listGroup.Add(CarReport.MakerGroup. トヨタ);
            }
            if (rb2.Checked) {
                listGroup.Add(CarReport.MakerGroup.日産);
            }
            if (rb3.Checked) {
                listGroup.Add(CarReport.MakerGroup.ホンダ);
            }
            if (rb4.Checked) {
                listGroup.Add(CarReport.MakerGroup.スバル);
            }
            if (rb5.Checked) {
                listGroup.Add(CarReport.MakerGroup.外国車);
            }
            if (rb6.Checked) {
                listGroup.Add(CarReport.MakerGroup.その他);
            }
            
            return listGroup;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbReport.Text)) {
                MessageBox.Show(" 入力してください ");
                return;
            }
            CarReport newCarReport = new CarReport {
                Date = dtTime.Value,
                Auther = cbAuther.Text,
                Maker = GetRdioBoxGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };
            listCarReport.Add(newCarReport);
            dgvCarReport.Rows[dgvCarReport.RowCount - 1].Selected = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveFileDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            listCarReport.RemoveAt(dgvCarReport.CurrentRow.Index);

            if (listCarReport.Count() == 0) {
                EnabledCheck();//マスク処理呼び出し
            }

        }
        //更新・削除ボタンのマスク処理を行う（マスク判定含む）
        private void EnabledCheck()
        {
            btUpdate.Enabled = btDelete.Enabled = listCarReport.Count() > 0 ? true : false;

        }

        private void Form_Load(object sander, EventArgs e)
        {
            EnabledCheck();//マスク処理呼び出し
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnabledCheck();//マスク処理呼び出し
        }
        //修正
        private void btUpdate_Click(object sender, EventArgs e)
        {
            listCarReport[dgvCarReport.CurrentRow.Index].Date = dtTime.Value;
            listCarReport[dgvCarReport.CurrentRow.Index].Auther = cbAuther.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Maker = GetRdioBoxGroup();
            listCarReport[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReport.Refresh();//データグリッドビュー

        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpenFileDialog.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(ofdOpenFileDialog.FileName);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void btOpenNews_Click(object sender, EventArgs e)
        {
            if (sfdSaveFileDialog.ShowDialog() == DialogResult.OK) {

                try {
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
                    }
                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ファイルFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 色の設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
            EnabledCheck();//マスク処理呼び出し
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            using (var writer = XmlWriter.Create("settings.xml"))
                {
                var color = new XmlSerializer(settings.GetType());

                serializer.Serialize(writer, settings);
            };
        }
    }
}