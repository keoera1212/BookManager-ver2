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
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();

            AllBooklb.Text = Data.AllBooks();
            AllUserlb.Text = Data.Allusers();
            BorrowedBooklb.Text = Data.Borrowed();
            OverBooklb.Text = Data.OverBorrowed();
        }
        //도서관리 폼 띄우기메뉴 함수
        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookService bs = new BookService(this);

            bs.Show();
        }
        //사용자 관리 폼 띄우기메뉴 함수
        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserService us = new UserService(this);

            us.Show();
        }
        //메인 폼 실행시 데이터띄우기 함수
        private void MainHome_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'usersDatas.Customer' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.customerTableAdapter.Fill(this.usersDatas.Customer);
            // TODO: 이 코드는 데이터를 'booksDatas.Book' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bookTableAdapter.Fill(this.booksDatas.Book);

        }
        //대여버튼 함수
        private void BorrowedBtn_Click(object sender, EventArgs e)
        {
            if (IsbnTbox.Text.Equals("") || BookNameTbox.Text.Equals("") || UserTbox.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지않았습니다! 다시 확인해주세요!", "경고!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else
            {
            Data.BorrowedBook(int.Parse(IsbnTbox.Text), BookNameTbox.Text, UserTbox.Text);

            this.bookTableAdapter.Fill(this.booksDatas.Book);
            }
        }
        //반납버튼 함수
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (IsbnTbox.Text.Equals("") || BookNameTbox.Text.Equals("") || UserTbox.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지않았습니다! 다시 확인해주세요!", "경고!",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                Data.ReturnBook(int.Parse(IsbnTbox.Text), BookNameTbox.Text, UserTbox.Text);

                this.bookTableAdapter.Fill(this.booksDatas.Book);
            }
        }
    }
}
