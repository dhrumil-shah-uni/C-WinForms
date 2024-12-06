using Microsoft.Data.SqlClient;
using System.Data;

namespace Together_Culture
{
    public partial class MemberManager : Form
    {
        public MemberManager()
        {
            InitializeComponent();
            this.Select();

            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            List<String> TagList = new List<String>();
            List<String> MemList = new List<String>();

            string query1 = "SELECT Tag_Name FROM Tags";
            string query2 = "SELECT (First_Name+' '+Last_Name) AS Full_Name FROM Members";

            SqlCommand sqlcmd1 = new SqlCommand(query1, sqlConnection);
            SqlCommand sqlcmd2 = new SqlCommand(query2, sqlConnection);

            SqlDataReader reader = sqlcmd1.ExecuteReader();
            while (reader.Read())
            {
                TagList.Add(reader["Tag_Name"].ToString());
            }
            reader.Close();

            SqlDataReader reader2 = sqlcmd2.ExecuteReader();
            while (reader2.Read())
            {
                MemList.Add(reader2["Full_Name"].ToString());
            }
            reader2.Close();

            sqlConnection.Close();

            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource.AddRange(TagList.ToArray());
            textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox4.AutoCompleteCustomSource.AddRange(TagList.ToArray());

            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.AutoCompleteCustomSource.AddRange(MemList.ToArray());
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource.AddRange(MemList.ToArray());
        }

        private void new_mem_click(object sender, EventArgs e)
        {
            VisitorForm visitorForm = new VisitorForm();
            visitorForm.ShowDialog();
        }

        private void new_tag_clicked(object sender, EventArgs e)
        {
            AddTag addTag = new AddTag();
            addTag.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            // Open SQL connection
            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            // Query to get all members
            string query = "SELECT MemberId, First_Name, Last_Name, Email FROM Members";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            // Use SqlDataAdapter to fill data into a DataTable
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Assign the data to DataGridView to display
            dataGridView1.DataSource = dataTable;

            // Close the SQL connection
            sqlConnection.Close();
        }

        private void on_go_click(object sender, EventArgs e)
        {
            // Get the tag and member inputs from the textboxes
            string tagName = textBox2.Text.Trim();
            string memberName = textBox3.Text.Trim();

            // Initialize the connection string through the Globals class
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            // Open SQL connection
            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            // Check if either the tag or member input is empty
            if (string.IsNullOrEmpty(tagName) || string.IsNullOrEmpty(memberName))
            {
                MessageBox.Show("Tag and Member fields cannot be empty.");
                sqlConnection.Close();
                return;
            }

            // Query to check if the tag exists
            string checkTagQuery = "SELECT TagID FROM Tags WHERE Tag_Name = @TagName";
            SqlCommand checkTagCommand = new SqlCommand(checkTagQuery, sqlConnection);
            checkTagCommand.Parameters.AddWithValue("@TagName", tagName);

            SqlDataReader tagReader = checkTagCommand.ExecuteReader();
            if (!tagReader.HasRows)
            {
                tagReader.Close();
                MessageBox.Show("Tag does not exist.");
                sqlConnection.Close();
                return;
            }
            tagReader.Close();

            // Query to check if the member exists
            string checkMemberQuery = "SELECT MemberId FROM Members WHERE First_Name + ' ' + Last_Name = @MemberName";
            SqlCommand checkMemberCommand = new SqlCommand(checkMemberQuery, sqlConnection);
            checkMemberCommand.Parameters.AddWithValue("@MemberName", memberName);

            SqlDataReader memberReader = checkMemberCommand.ExecuteReader();
            if (!memberReader.HasRows)
            {
                memberReader.Close();
                MessageBox.Show("Member does not exist.");
                sqlConnection.Close();
                return;
            }
            memberReader.Close();

            // Retrieve the TagID and MemberID
            int tagID = (int)checkTagCommand.ExecuteScalar();
            int memberID = (int)checkMemberCommand.ExecuteScalar();

            // Insert the member-tag relationship into the MemberTags table
            string insertQuery = "INSERT INTO MemberTags (MemberID, TagID) VALUES (@MemberID, @TagID)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.Parameters.AddWithValue("@MemberID", memberID);
            insertCommand.Parameters.AddWithValue("@TagID", tagID);

            insertCommand.ExecuteNonQuery();

            // Refresh the DataGridView to show the updated data
            string selectQuery = "SELECT m.First_Name, m.Last_Name, t.Tag_Name " +
                                 "FROM MemberTags mt " +
                                 "JOIN Members m ON mt.MemberID = m.MemberId " +
                                 "JOIN Tags t ON mt.TagID = t.TagID";

            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            // Close the SQL connection
            sqlConnection.Close();

            // Notify the user that the tag has been successfully assigned to the member
            MessageBox.Show("Tag successfully assigned to member.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Initialize the connection string (assumed through the Globals class)
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            // Open SQL connection
            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            // Query to get all tags
            string query = "SELECT TagID, Tag_Name FROM Tags";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            // Use SqlDataAdapter to fill data into a DataTable
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Assign the data to DataGridView to display
            dataGridView1.DataSource = dataTable;

            // Close the SQL connection
            sqlConnection.Close();
        }

        private void Enter_Down_mem(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = textBox1.Text.Trim();

                // Check if the input is empty
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }

                // Initialize the connection string (assumed through the Globals class)
                Globals refresh_globals = new Globals();
                refresh_globals.global_var();

                // Open SQL connection
                SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
                sqlConnection.Open();

                // Query to search for members by any of the fields matching the input text
                string query = "SELECT MemberId, First_Name, Last_Name, Email FROM Members " +
                               "WHERE First_Name LIKE @SearchText OR Last_Name LIKE @SearchText OR Email LIKE @SearchText";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                // Use SqlDataAdapter to fill data into a DataTable
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // If no records found, show a message
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No member found matching the search criteria.");
                }
                else
                {
                    // Display the data in the DataGridView
                    dataGridView1.DataSource = dataTable;
                }

                // Close the SQL connection
                sqlConnection.Close();

                e.Handled = true;
            }
        }

        private void Enter_down_tag(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = textBox4.Text.Trim(); // Get the text entered by the user

                // Check if the input is empty
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a tag name to search for members.");
                    return;
                }

                // Initialize the connection string (assumed through the Globals class)
                Globals refresh_globals = new Globals();
                refresh_globals.global_var();

                // Open SQL connection
                SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
                sqlConnection.Open();

                // Query to search for members who have the entered tag name (join Members, MemberTags, and Tags)
                string query = @"SELECT m.MemberId, m.First_Name, m.Last_Name, m.Email
                         FROM Members m
                         JOIN MemberTags mt ON m.MemberId = mt.MemberID
                         JOIN Tags t ON mt.TagID = t.TagID
                         WHERE t.Tag_Name LIKE @SearchText";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%"); // Use wildcards for partial matching

                // Use SqlDataAdapter to fill data into a DataTable
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // If no records found, show a message
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No members found with the specified tag.");
                }
                else
                {
                    // Display the data in the DataGridView
                    dataGridView1.DataSource = dataTable;
                }

                // Close the SQL connection
                sqlConnection.Close();

                e.Handled = true;
            }
        }
    }
}