using Microsoft.Data.SqlClient;
using System.Data;

namespace Together_Culture
{
    public partial class EventManager : Form
    {
        public EventManager()
        {
            InitializeComponent();
        }

        private void go_clicked(object sender, EventArgs e)
        {
            //Refresh connection string, start a new SQL connection

            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            //Query to add new events to the database, according to user input
            string insertQuery = "INSERT INTO Events (EventName, EventDesc, EventInfo, EventSchedule) " +
                                 "VALUES (@EventName, @EventDesc, @EventInfo, @EventSchedule)";

            SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            //User inputs to SQL query
            sqlCommand.Parameters.AddWithValue("@EventName", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@EventDesc", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@EventInfo", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@EventSchedule", dateTimePicker3.Value);

            sqlCommand.ExecuteNonQuery(); //Execute SQL query

            // Refresh the DataGridView to show updated data
            string selectQuery = "SELECT EventID, EventName, EventDesc, EventInfo, EventSchedule FROM Events";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void filter_clicked(object sender, EventArgs e)
        {
            //Refresh connection String, start a new SQL Connection
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            //Query to filter and show events according to user parameters
            string filterQuery = "SELECT EventID, EventName, EventDesc, EventInfo, EventSchedule " +
                                 "FROM Events " +
                                 "WHERE EventSchedule BETWEEN @StartDate AND @EndDate";

            //User input
            SqlCommand sqlCommand = new SqlCommand(filterQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);

            //Update the data view
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void show_all(object sender, EventArgs e)
        {
            //Refresh connection string, new SQL connection
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            //query to show all, and reset filters
            string selectQuery = "SELECT EventID, EventName, EventDesc, EventInfo, EventSchedule FROM Events";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //update data view
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}