using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Together_Culture
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();

            //To define a rounded border. See Title.cs for more details
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panel2.BorderStyle = BorderStyle.None;
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }

        public Homepage Homepage
        {
            get => default;
            set
            {
            }
        }

        public VisitorForm VisitorForm
        {
            get => default;
            set
            {
            }
        }

        private Point mouseLocation;
        private bool isAdmin = false; //checks if the user is admin, and sends the parameter to Homepage

        //Parameters for border
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

        //To allow dragging the window
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Globals refresh_globals = new Globals(); 
                refresh_globals.global_var();  //Refresh the connection string in Global class

                //Start a new SQL Connection to the database
                SqlConnection conn = new SqlConnection(refresh_globals.Conn_string); //using the connection string from Global class
                conn.Open();

                //SQL query for checking if the email and password match with the database
                String querytext = "SELECT COUNT(*) FROM Members WHERE Email=@email AND Password=@pass";
                SqlCommand sqlcmd = new SqlCommand(querytext, conn);
                sqlcmd.Parameters.AddWithValue("@email", emailbox.Text); //shares the data in variable to the sql query
                sqlcmd.Parameters.AddWithValue("@pass", passbox.Text);

                int checker = (int)sqlcmd.ExecuteScalar(); //calls the SQL command

                if (checker != 0)
                {
                    //Checks if the user is admin
                    String checkadmin_query = "SELECT MembershipType FROM Members WHERE Email=@email";
                    SqlCommand admincheck = new SqlCommand(checkadmin_query, conn);
                    admincheck.Parameters.AddWithValue("@email", emailbox.Text);
                    String checkAdmin = (string)admincheck.ExecuteScalar();
                    if (checkAdmin == "Admin")
                    {
                        isAdmin = true;
                    }
                    errorlabel.Text = "Login Successful";
                    Homepage Home = new Homepage(isAdmin); //sends admin status to Homepage, and opens the Homepage form
                    Home.Show();
                    this.Close();
                }
                else
                {
                    errorlabel.Text = "Invalid Login"; //if wrong credentials
                }

                conn.Close();
            }
            catch (Exception)
            {
                //to handle database error
                MessageBox.Show("Database Error", "Database Failure, Please check if database exists", MessageBoxButtons.OK);

                throw;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            errorlabel.Text = "Email Sent"; //this can later be scaled to send an actual e-mail
        }

        //handles Enter-key press to submit the credentials
        private void enter_pressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
                e.Handled = true;
            }
        }

        //To move to password input box
        private void enter_pressed_email(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passbox.Select();
                e.Handled = true;
            }
        }

        //End the application
        private void exit_clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Shows visitor form to apply to be a member user
        private void visitorLink_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitorForm visitorForm = new VisitorForm();
            visitorForm.Show();
        }
    }
}