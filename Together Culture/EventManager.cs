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
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            string insertQuery = "INSERT INTO Events (EventName, EventDesc, EventInfo, EventSchedule) " +
                                 "VALUES (@EventName, @EventDesc, @EventInfo, @EventSchedule)";

            SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@EventName", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@EventDesc", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@EventInfo", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@EventSchedule", dateTimePicker3.Value);

            sqlCommand.ExecuteNonQuery();

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
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            string filterQuery = "SELECT EventID, EventName, EventDesc, EventInfo, EventSchedule " +
                                 "FROM Events " +
                                 "WHERE EventSchedule BETWEEN @StartDate AND @EndDate";

            SqlCommand sqlCommand = new SqlCommand(filterQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void show_all(object sender, EventArgs e)
        {
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            string selectQuery = "SELECT EventID, EventName, EventDesc, EventInfo, EventSchedule FROM Events";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}