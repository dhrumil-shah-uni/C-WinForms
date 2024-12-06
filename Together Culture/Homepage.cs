using System.Runtime.InteropServices;

namespace Together_Culture
{
    public partial class Homepage : Form
    {
        public ListBox Navlist
        {
            get { return navlist; }
        }

        public Homepage(bool isAdmin)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panel2.BorderStyle = BorderStyle.None;
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));

            this.Select();

            if (!isAdmin)
            {
                navlist.Items.Remove("Admin");
                textBox1.AutoCompleteCustomSource.Remove("Admin");
            }

            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void Homepage_Load(object sender, EventArgs e)
        {
            navlist.SelectedIndex = 0;
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
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

        private void quit_clicked(object sender, EventArgs e)
        {
            Loginpage login_new = new Loginpage();
            login_new.Show();
            this.Close();
        }

        private void onSelectedChange(object sender, EventArgs e)
        {
            shop1.Visible = false;
            home1.Visible = false;
            events1.Visible = false;
            membershipPage1.Visible = false;
            blogs1.Visible = false;
            admin1.Visible = false;

            switch (navlist.SelectedIndex)
            {
                case 0:
                    home1.Dock = DockStyle.Fill;
                    home1.Visible = true;
                    break;

                case 1:
                    events1.Dock = DockStyle.Fill;
                    events1.Visible = true;
                    break;

                case 2:
                    membershipPage1.Dock = DockStyle.Fill;
                    membershipPage1.Visible = true;
                    break;

                case 3:
                    shop1.Dock = DockStyle.Fill;
                    shop1.Visible = true;
                    break;

                case 4:
                    blogs1.Dock = DockStyle.Fill;
                    blogs1.Visible = true;
                    break;

                case 5:
                    admin1.Dock = DockStyle.Fill;
                    admin1.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void on_Enter_press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Search

                switch (textBox1.Text.Trim().ToLower())
                {
                    case "home":
                        navlist.SelectedIndex = 0;
                        break;

                    case "events":
                        navlist.SelectedIndex = 1;
                        break;

                    case "membership":
                        navlist.SelectedIndex = 2;
                        break;

                    case "shop":
                        navlist.SelectedIndex = 3;
                        break;

                    case "blogs":
                        navlist.SelectedIndex = 4;
                        break;

                    case "admin":
                        if (navlist.Items.Count > 5) { navlist.SelectedIndex = 5; } else { MessageBox.Show("Invalid input."); }
                        break;

                    default:
                        MessageBox.Show("Invalid input.");
                        break;
                }

                textBox1.Text = "";

                e.Handled = true;
            }
            this.Select();
        }
    }
}