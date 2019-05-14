using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class UserUpdate : Form
    {
        public UserUpdate(string Id)
        {
            InitializeComponent();

            FindIdLb.Text = Id;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (IdTbox.Text.Equals("") || NameTbox.Text.Equals(""))
            {
                MessageBox.Show("아이디와 이름이 입력되지않았습니다! 아이디와 이름을 입력해주세요!", "경고", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);     
            }
            else
            {
            Data.UpdateUser(FindIdLb.Text, IdTbox.Text, NameTbox.Text);

            this.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
