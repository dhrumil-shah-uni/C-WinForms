using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class approvemembers : Form
    {
        private string connectionString;
        public approvemembers()
        {
            InitializeComponent();
            InitializeConnectionString();
            LoadAllMembers();
        }
        private void InitializeConnectionString()
        {
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();
            connectionString = refresh_globals.Conn_string;
        }

        private void LoadAllMembers()
        {
            string query = "SELECT MemberId, First_Name, Last_Name, Email, Status FROM Members";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ApproveMember(int memberId)
        {
            string updateQuery = "UPDATE Members SET Status = 'Approved' WHERE MemberId = @MemberId";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MemberId", memberId);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Member approved successfully.");
                    LoadAllMembers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CancelMember(int memberId)
        {
            string updateQuery = "UPDATE Members SET Status = 'Canceled' WHERE MemberId = @MemberId";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MemberId", memberId);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Member canceled successfully.");
                    LoadAllMembers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberId"].Value);
                ApproveMember(memberId);
            }
            else
            {
                MessageBox.Show("Please select a member to approve.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberId"].Value);
                CancelMember(memberId);
            }
            else
            {
                MessageBox.Show("Please select a member to cancel.");
            }
        }
      
    }
}
