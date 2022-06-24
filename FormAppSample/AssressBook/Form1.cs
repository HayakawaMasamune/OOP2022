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

namespace AddressBook {
    public partial class Form1 : Form {

        BindingList<Person> listPerson = new BindingList<Person>();
        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;

        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }

        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;

            }
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                Registration = dateTimePicker1.Value,
                KindNumber = GetRadioButtonKindNumber(),
                TellNumber = tbTellNumber.Text,
                


            };

            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            EnabledCheck();

            setCbCompany(cbCompany.Text);

            /* if (cbCompany.FindStringExact(cbCompany.Text) == -1) { 

                 //コンボボックスに会社名を登録する
                 cbCompany.Items.Add(cbCompany.Text);
             }*/

            
        
        }

        private Person.KindNumberType GetRadioButtonKindNumber()
        {
            var listGroup = Person.KindNumberType.その他;

            if (cbHome.Checked) {
                listGroup = Person.KindNumberType.自宅;
            }
            if (cbMobile.Checked) {
                listGroup = Person.KindNumberType.携帯;
            }
            return listGroup;
        }

        


        //コンボボックスに会社名を登録する
        private void setCbCompany(string company)
        {

            if (!cbCompany.Items.Contains(company)) {

                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値リストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup()
        {
            var listGroup = new List<Person.GroupType>();

            if (cbHome.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbMobile.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }


            return listGroup;

        }



        

        private void btPictureClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }
        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;
            int index = dgvPersons.CurrentRow.Index;

            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;
            dateTimePicker1.Value =
                listPerson[index].Registration.Year > 1900 ? listPerson[index].Registration : DateTime.Today;
            tbTellNumber.Text = listPerson[index].TellNumber;

            groupCheckBoxAllClear();

           
                foreach (var group in listPerson[index].listGroup) {

                    switch (group) {
                        case Person.GroupType.家族:
                            cbHome.Checked = true;
                            break;
                        case Person.GroupType.友人:
                            cbMobile.Checked = true;
                            break;
                        case Person.GroupType.仕事:
                            cbWork.Checked = true;
                            break;
                        case Person.GroupType.その他:
                            cbOther.Checked = true;
                            break;
                        default:
                            break;
                    }
                }
            

            //番号種別チェック処理
            switch (listPerson[index].KindNumber) {
                case Person.KindNumberType.自宅:
                    rbHome.Checked = true;
                    break;
                case Person.KindNumberType.携帯:
                    rbMobile.Checked = true;
                    break;
                case Person.KindNumberType.その他:
                    break;
                default:
                    break;
            }
        }
        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            cbHome.Checked = cbMobile.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btupdata_Click(object sender, EventArgs e)
        {
            

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            dgvPersons.Refresh();//データグリッドビュー


        }
        //  削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e)
        {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

            if (listPerson.Count() == 0) {
                EnabledCheck();//マスク処理呼び出し
            }

        }
        //更新・削除ボタンのマスク処理を行う（マスク判定含む）
        private void EnabledCheck()
        {
            btupdata.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;

        }

        private void Form_Load(object sander, EventArgs e)
        {
            EnabledCheck();//マスク処理呼び出し
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnabledCheck();//マスク処理呼び出し
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e)
        {
            if(sfdSavaDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                   
                    using(FileStream fs = File.Open(sfdSavaDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }
      
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                try {
                    var bf = new BinaryFormatter();

                    using(FileStream fs = File.Open(ofdFileOpenDialog.FileName,FileMode.Open,FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>) bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
                //コンボボックスへ登録
                foreach (var item in listPerson.Select(p => p.Company)) {
                    setCbCompany(item);//存在する会社を登録
                }

            }

            EnabledCheck();//マスク処理呼び出し

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbHome_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    //例
    //tbName.Text = listPerson[0].Name:

    //①選択されているインデックスを取得する

    //②インデックスが取得出来たら、リスト（listPerson）の該当するインデックスに
    // アクセスし、リストの各項目を各テキストボックスへ表示する







    
}
