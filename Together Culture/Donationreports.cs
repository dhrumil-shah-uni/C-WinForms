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
    public partial class Form1 : Form
    {
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            InitializeConnectionString();
            LoadDonationData();
        }
        private void InitializeConnectionString()
        {
            Globals globals = new Globals();
            globals.global_var();
            connectionString = globals.Conn_string;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

       
        private void LoadDonationData()
        {
            string query = @"
        SELECT Donations.DonationId, Donations.MemberId, Donations.DonationAmount, Donations.DonationDate, 
               Members.First_Name, Members.Last_Name, Members.Email
        FROM Donations
        JOIN Members ON Donations.MemberId = Members.MemberId";

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
        private void ExportToCSV(DataGridView dgv, string filePath)
        {
            StringBuilder csvContent = new StringBuilder();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                csvContent.Append(column.HeaderText + ",");
            }
            csvContent.AppendLine();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csvContent.Append(cell.Value?.ToString() + ",");
                }
                csvContent.AppendLine();
            }

            File.WriteAllText(filePath, csvContent.ToString());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Save Donation Report as CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Data exported successfully.");
            }
        }
    }
    }

