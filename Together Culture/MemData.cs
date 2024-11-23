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
    public partial class MemData : Form
    {
        public MemData()
        {
            InitializeComponent();

            SqlConnection memdatasql = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"Z:\\C# WinForms\\Together Culture\\Together Culture\\Databases\\memberdb.mdf\";Integrated Security=True;Connect Timeout=30");
            memdatasql.Open();
            String cmdnew1 = "SELECT * FROM MemDataSet";

            SqlDataAdapter sqlacc = new SqlDataAdapter(cmdnew1,memdatasql);


            DataTable dataT = new DataTable();
            sqlacc.Fill(dataT);
            dataGridView1.DataSource = dataT;
            
           
        }

        
    }
}
