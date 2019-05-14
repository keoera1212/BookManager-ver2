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
    public partial class UserService : Form
    {
        MainHome Mh;

        public UserService()
        {
            InitializeComponent();
        }
        //메인폼 데이터 제어를 위한 생성자
        public UserService(MainHome Mh)
        {
            InitializeComponent();
            this.Mh = Mh;
        }

        private void UserService_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'bookManagerDataSet6.Customer' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.customerTableAdapter.Fill(this.bookManagerDataSet6.Customer);

        }
        //추가버튼 이벤트함수
        private void UserAddBtn_Click(object sender, EventArgs e)
        {
            if (IDTbox.Text.Equals("") || NameTbox.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지 않았습니다!", "경고!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
            Data.AddUser(IDTbox.Text, NameTbox.Text);
            this.customerTableAdapter.Fill(this.bookManagerDataSet6.Customer);

            Mh.customerTableAdapter.Fill(Mh.usersDatas.Customer);
            }
        }
        //수정버튼 이벤트함수
        private void UserUdtBtn_Click(object sender, EventArgs e)
        {
            //수정폼 호출
            new UserFind().ShowDialog();
            this.customerTableAdapter.Fill(this.bookManagerDataSet6.Customer);

            Mh.customerTableAdapter.Fill(Mh.usersDatas.Customer);
        }
        //삭제버튼 이벤트함수
        private void UserDelBtn_Click(object sender, EventArgs e)
        {
            if (IDTbox.Text.Equals("") || NameTbox.Text.Equals(""))
            {
                MessageBox.Show("정보가 다 입력되지 않았습니다!", "경고!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
            Data.DeleteUser(IDTbox.Text, NameTbox.Text);
            this.customerTableAdapter.Fill(this.bookManagerDataSet6.Customer);

            Mh.customerTableAdapter.Fill(Mh.usersDatas.Customer);
            }
        }
    }
}
