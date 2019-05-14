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
    public partial class UserFind : Form
    {
        public UserFind()
        {
            InitializeComponent();
           
        }

        private void FindUserBtn_Click(object sender, EventArgs e)
        {
            if (FindUserTbox.Text.Equals(""))
            {
                MessageBox.Show("이름이 입력되지않았습니다! 이름을 입력해주세요!", "경고", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                new UserUpdate(FindUserTbox.Text).ShowDialog();
                this.Close();
            }
        }
    }
}
