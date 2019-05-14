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
    public partial class UpdateBook : Form
    {
        public UpdateBook(string Isbn)
        {
            InitializeComponent();

            OldLB.Text = Isbn;
        }
        //수정버튼 이벤트함수
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (IsbnTbox.Text.Equals("") || NameTbox.Text.Equals("") || PubTbox.Text.Equals("") || PageTbox.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지 않았습니다!", "경고!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                int TextIsbn = int.Parse(OldLB.Text);

                Data.UpdateBook(TextIsbn, int.Parse(IsbnTbox.Text), NameTbox.Text, PubTbox.Text, int.Parse(PageTbox.Text));

                this.Close();
            }
        }
        //취소버튼 이벤트 함수
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
