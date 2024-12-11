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
    public partial class Announce : Form
    {
        public Announce()
        {
            InitializeComponent();
            this.Select();
        }

        private void announce_go(object sender, EventArgs e)
        {
            //Following code refreshes connection string, and starts a new SQL connection
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            //Query to add an announcement to the database, by taking user input
            string insertQuery = "INSERT INTO Announcements (Title, Content, Scheduled) " +
                                 "VALUES (@Title, @Content, @Scheduled)";

            SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Title", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@Content", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Scheduled", dateTimePicker3.Value);

            int rowsAffected = sqlCommand.ExecuteNonQuery(); //Execute query

            sqlConnection.Close();

            //Confirm
            if (rowsAffected > 0)
            {
                MessageBox.Show("Announcement added successfully!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed to add the announcement.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}