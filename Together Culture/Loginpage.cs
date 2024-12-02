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

            panel2.BorderStyle = BorderStyle.None;
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));

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

        private void button1_Click(object sender, EventArgs e, string text)
        {
            
            try
            {
                Globals refresh_globals = new Globals();
                refresh_globals.global_var();
                SqlConnection conn = new SqlConnection(refresh_globals.Conn_string);
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
            catch (Exception)
            {
                
                throw;
            }
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            errorlabel.Text = "Email Sent";
        }

        private void enter_pressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e, "Database Error");
                e.Handled = true;
            }
        }

        private void enter_pressed_email(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passbox.Select();
                e.Handled = true;
            }
        }

        private void exit_clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visitorLink_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitorForm visitorForm = new VisitorForm();
            visitorForm.Show();
        }
    }
}
