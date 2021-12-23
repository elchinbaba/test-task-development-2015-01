using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test3
{
    public partial class addform : Form
    {
        SqlConnection connection = SqlConnect.connect();
        public mainform mainform;
        public addform()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string query = "insert into order_item values(@Product_Name, @price, @number, @value)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Product_Name", prodnametxtB.Text);
            command.Parameters.AddWithValue("@price", pricetxtB.Text);
            command.Parameters.AddWithValue("@number", numtxtB.Text);
            command.Parameters.AddWithValue("@value", valuetxtB.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            connection.Close();
            this.Hide();
            mainform.Show();
        }

        private void addform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            mainform.Show();
        }
    }
}
