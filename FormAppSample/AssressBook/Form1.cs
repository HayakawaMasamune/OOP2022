using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


            if (listPerson.Count() == 0) {
                btDelete.Enabled = false;
                btupdata.Enabled = false;
            }
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),

                 

            };

            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;
        }

        //チェックボックスにセットされている値リストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup()
        {
            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
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
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllClear();

            foreach (var group in listPerson[index].listGroup) {

                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
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
        }
        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btupdata_Click(object sender, EventArgs e)
        {
            

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = tbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            dgvPersons.Refresh();


        }
        //  削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e)
        {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

            //if(listPerson.Count() == 0) {
            //    btDelete.Enabled = false;
             //   btupdata.Enabled = false;
           // }

        }

        private void Form_Load(object sander, EventArgs e)
        {
           if(listPerson.Count() == 0) btDelete.Enabled = false; //  削除ボタンをマスク
            btupdata.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btDelete.Enabled = false;
            btupdata.Enabled = false;
        }
    }

    //例
    //tbName.Text = listPerson[0].Name:

    //①選択されているインデックスを取得する

    //②インデックスが取得出来たら、リスト（listPerson）の該当するインデックスに
    // アクセスし、リストの各項目を各テキストボックスへ表示する







    
}
