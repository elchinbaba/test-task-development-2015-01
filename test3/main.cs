using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test3
{
    public partial class mainform : Form
    {
        public SqlConnection connection;
        public void show(DataTable dt)
        {
            orderdGV.DataSource = dt;
        }

        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            SqlConnect.connect(ref connection);
        }

        private void insbtn_Click(object sender, EventArgs e)
        {
            insorupdform insorupdform = new insorupdform();
            insorupdform.mainform = this;
            insorupdform.isupd = false;
            insorupdform.Show();
            this.Hide();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            delorupdform delorupdform = new delorupdform();
            delorupdform.isupd = false;
            delorupdform.mainform = this;
            delorupdform.Show();
            this.Hide();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            delorupdform delorupdform = new delorupdform();
            delorupdform.isupd = true;
            delorupdform.mainform = this;
            delorupdform.Show();
            this.Hide();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(ShoW.show("select * from orders"));
        }

        private void lastDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderdGV.DataSource = ShoW.show(ShoW.AddDays);
        }

        private void lastWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderdGV.DataSource = ShoW.show(ShoW.AddWeek);
        }

        private void lastMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderdGV.DataSource = ShoW.show(DateTime.Now.AddMonths);
        }
        private void lastYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderdGV.DataSource = ShoW.show(DateTime.Now.AddYears);
        }

        private void enterPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            periodform periodform = new periodform();
            periodform.mainform = this;
            periodform.Show();
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(ShoW.show("select * from order_item"));
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addform addform = new addform();
            addform.mainform = this;
            addform.Show();
            this.Hide();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delorupdform delorupdform = new delorupdform();
            delorupdform.isupd = false;
            delorupdform.isitem = true;
            delorupdform.mainform = this;
            delorupdform.Show();
            this.Hide();
        }
    }
}
