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
    public partial class BookService : Form
    {
        MainHome Mh;

        public BookService()
        {
            InitializeComponent();
        }
        //메인폼 데이터를 제어하기위한 생성자
        public BookService(MainHome Mh)
        {
            this.Mh = Mh;
            InitializeComponent();
            
        }
        //2번째폼 데이터로드 함수
        private void BookService_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'bookManagerDataSet2.Book' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bookTableAdapter.Fill(this.bookManagerDataSet2.Book);

        }
        //추가버튼 이벤트함수
        private void AddBookbtn_Click(object sender, EventArgs e)
        {
            if (BookIsbntbx.Text.Equals("") || BookNametbx.Text.Equals("") || Pubtbx.Text.Equals("") || Pagetbx.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지않았습니다! 다시 확인해주세요!", "경고!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
            int Isbn = int.Parse(BookIsbntbx.Text);
            string Name = BookNametbx.Text;
            int Page = int.Parse(Pagetbx.Text);
            string Publisher = Pubtbx.Text;

            Data.Booksave(Isbn, Name, Page, Publisher);

            this.bookTableAdapter.Fill(this.bookManagerDataSet2.Book);

            Mh.bookTableAdapter.Fill(Mh.booksDatas.Book); 
            }
        }
        //수정 이벤트함수
        private void BookUpdatebtn_Click(object sender, EventArgs e)
        {
            //수정대화상자폼 호출
            FindForm find = new FindForm();
            find.ShowDialog();

            this.bookTableAdapter.Fill(this.bookManagerDataSet2.Book);

            Mh.bookTableAdapter.Fill(Mh.booksDatas.Book);
        }
        //삭제 이벤트함수
        private void BookDeletebtn_Click(object sender, EventArgs e)
        {
            if (BookIsbntbx.Text.Equals("") || BookNametbx.Text.Equals("") || Pubtbx.Text.Equals("") || Pagetbx.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지않았습니다! 다시 확인해주세요!", "경고!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
            int Isbn = int.Parse(BookIsbntbx.Text);
            string Name = BookNametbx.Text;
            int Page = int.Parse(Pagetbx.Text);
            string Publisher = Pubtbx.Text;

            Data.BookDelete(Isbn, Name, Publisher, Page);

            this.bookTableAdapter.Fill(this.bookManagerDataSet2.Book);

            Mh.bookTableAdapter.Fill(Mh.booksDatas.Book);
            }
        }
    }
}
