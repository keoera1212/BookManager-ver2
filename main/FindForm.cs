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
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
            

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (FindTbox.Text.Equals(""))
            {
                MessageBox.Show("Isbn이 입력되지 않았습니다!", "경고!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                UpdateBook update = new UpdateBook(FindTbox.Text);
                update.ShowDialog();

                this.Close();
            }
        }
    }
}
