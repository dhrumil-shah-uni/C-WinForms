using Microsoft.Data.SqlClient;
using System.Data;

namespace Together_Culture
{
    public partial class ShopManager : Form
    {
        public ShopManager()
        {
            InitializeComponent();
        }

        private void add_item(object sender, EventArgs e)
        {
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            string insertQuery = "INSERT INTO Shop (ItemName, ItemType, ItemPrice, Marketplace) " +
                                 "VALUES (@ItemName, @ItemType, @ItemPrice, @Marketplace)";

            SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@ItemName", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@ItemType", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@ItemPrice", decimal.Parse(textBox1.Text));
            sqlCommand.Parameters.AddWithValue("@Marketplace", textBox4.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK);

                // Show only the added item in dataGridView1
                string selectQuery = "SELECT ItemID, ItemName, ItemType, ItemPrice, Marketplace " +
                                     "FROM Shop WHERE ItemName = @ItemName";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                selectCommand.Parameters.AddWithValue("@ItemName", textBox2.Text);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to add the item.", "Error", MessageBoxButtons.OK);
            }

            sqlConnection.Close();
        }

        private void show_all(object sender, EventArgs e)
        {
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            string selectQuery = "SELECT ItemID, ItemName, ItemType, ItemPrice, Marketplace FROM Shop";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}