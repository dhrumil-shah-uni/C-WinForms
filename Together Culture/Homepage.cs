using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panel2.BorderStyle = BorderStyle.None;
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));

            this.Select();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemData memData = new MemData();
            memData.Show();
            this.Hide();
        }

        private void quit_clicked(object sender, EventArgs e)
        {
            Loginpage login_new = new Loginpage();
            login_new.Show();
            this.Close();
        }

        private void onSelectedChange(object sender, EventArgs e)
        {
            switch (navlist.SelectedIndex)
            {
                case 0:
                    events1.Visible = false;
                    membershipPage1.Visible = false;
                    home1.Dock = DockStyle.Fill;
                    home1.Visible = true;
                    break;
                case 1:
                    home1.Visible = false;
                    membershipPage1.Visible=false;
                    events1.Dock = DockStyle.Fill;
                    events1.Visible = true;
                    break;
                case 2:
                    home1.Visible = false;
                    events1.Visible = false;
                    membershipPage1.Dock = DockStyle.Fill;
                    membershipPage1.Visible = true;
                    break;
                case 3:
                case 4:
                case 5:
                default:
                    break;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
