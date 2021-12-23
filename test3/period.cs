using System;
using System.Windows.Forms;

namespace test3
{
    public partial class periodform : Form
    {
        public mainform mainform;
        public periodform()
        {
            InitializeComponent();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            string from = fromdTP.Text, to = todTP.Text;
            mainform.Show();
            mainform.show(ShoW.show(from, to));
            this.Hide();
        }

        private void periodform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            mainform.Show();
        }
    }
}
