using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;
using Microsoft.Data.SqlClient;


namespace Together_Culture
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private Point mouseLocation;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void Loginpage_Load(object sender, EventArgs e)
        {
            errorlabel.Text = "";
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point mousePose = Control.MousePosition;

                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"Z:\\C# WinForms\\Together Culture\\Together Culture\\Databases\\logindb.mdf\";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            String querytext = "SELECT * FROM Login WHERE email=@email AND pass=@pass";
            SqlCommand sqlcmd = new SqlCommand(querytext, conn);
            sqlcmd.Parameters.AddWithValue("@email", emailbox.Text);
            sqlcmd.Parameters.AddWithValue("@pass", passbox.Text);

            String checker = (string)sqlcmd.ExecuteScalar();

            if (checker != null)
            {
                errorlabel.Text = "Login Successful";
                Homepage Home = new Homepage();
                Home.Show();
                this.Close();
            }
            else
            {
                errorlabel.Text = "Invalid Login";
            }


            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
