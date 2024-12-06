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
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
            this.Select();
        }

        private void fo_clicked(object sender, EventArgs e)
        {
            Globals refresh_globals = new Globals();
            refresh_globals.global_var();

            SqlConnection sqlConnection = new SqlConnection(refresh_globals.Conn_string);
            sqlConnection.Open();

            string query1 = "INSERT INTO Tags ([Tag_Name]) VALUES (@Tag_Name)";
            SqlCommand sqlcmd = new SqlCommand(query1, sqlConnection);
            sqlcmd.Parameters.AddWithValue("@Taf_Name",textBox1.Text);

            int rowsAffected = sqlcmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Tag Created Successfully");
            } else
            {
                MessageBox.Show("Failed to add Tag");
            }
            sqlConnection.Close();
            MemberManager memberManager = new MemberManager();
            memberManager.Show();
            this.Close();
        }

        private void cancel_clicked(object sender, EventArgs e)
        {
            MemberManager memberManager = new MemberManager();
            memberManager.Show();
            this.Close();
        }
    }
}
