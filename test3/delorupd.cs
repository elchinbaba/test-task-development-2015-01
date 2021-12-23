using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test3
{
    public partial class delorupdform : Form
    {
        SqlConnection connection = SqlConnect.connect();
        public mainform mainform;
        public bool isupd, isitem;
        public delorupdform()
        {
            InitializeComponent();
        }

        private void delorupdbtn_Click(object sender, EventArgs e)
        {
            if (numtxtB.Text == "")
            {
                MessageBox.Show("Fill the textbox!");
                return;
            }
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string query;
            SqlCommand command;
            if (isupd)
            {
                insorupdform insorupdform = new insorupdform();
                insorupdform.mainform = this.mainform;
                insorupdform.isupd = true;
                query = "select * from orders where Number=" + numtxtB.Text;
                try
                {
                    DataTable dt = ShoW.show(query);
                    insorupdform.assign(dt.Rows[0]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                insorupdform.Show();
                this.Hide();
            }
            else
            {
                string table = isitem ? "order_item" : "orders";
                query = "delete from " + table + " where Number=" + numtxtB.Text;
                command = new SqlCommand(query, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this.Hide();
                mainform.Show();
            }
            connection.Close();
        }

        private void delorupdform_Load(object sender, EventArgs e)
        {
            this.Text = isupd ? "Update" : "Delete";
            if (!isupd) this.Text = isitem ? "Remove" : "Delete";
            delorupdbtn.Text = this.Text;
        }

        private void delorupdform_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
