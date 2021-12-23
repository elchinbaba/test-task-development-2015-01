using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test3
{
    public partial class insorupdform : Form
    {
        SqlConnection connection = SqlConnect.connect();
        public mainform mainform;
        public bool isupd;
        public string id;
        
        public void assign(DataRow dr)
        {
            datedTP.Value = Convert.ToDateTime(dr[0].ToString());
            numtxtB.Text = dr[1].ToString();
            fnamecltxtB.Text = dr[2].ToString();
            totamotxtB.Text = dr[3].ToString();
            listitemtxtB.Text = dr[4].ToString();
        }

        public insorupdform()
        {
            InitializeComponent();
        }

        private void insorupdbtn_Click(object sender, EventArgs e)
        {
            string query;
            SqlCommand command;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            if (isupd)
            {
                query = "update orders set Date=@Date, Number=@Number, Full_name_Client=@Full_name_Client, total_amount=@total_amount, list_items=@list_items where Number=@id";
            }
            else
            {
                query = "insert into orders values(@Date, @Number, @Full_name_Client, @total_amount, @list_items)";
            }
            command = new SqlCommand(query, connection);
            if (isupd) command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Date", datedTP.Text);
            command.Parameters.AddWithValue("@Number", numtxtB.Text);
            command.Parameters.AddWithValue("@Full_name_Client", fnamecltxtB.Text);
            command.Parameters.AddWithValue("@total_amount", totamotxtB.Text);
            command.Parameters.AddWithValue("@list_items", listitemtxtB.Text);
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

        private void insorupdform_Load(object sender, EventArgs e)
        {
            id = numtxtB.Text;
            this.Text = isupd ? "Update" : "Insert";
            insorupdbtn.Text = this.Text;
        }

        private void insorupdform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            mainform.Show();
        }
    }
}
