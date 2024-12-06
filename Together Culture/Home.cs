namespace Together_Culture
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MainHomePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void fgfgj(object sender, EventArgs e)
        {
        }

        private void slogen_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for signing up for our e-newsletter. \nWelcome to Together Culture.");
        }

        private void welcome_Click(object sender, EventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                pForm.Navlist.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }

        private void blogs_button_click(object sender, EventArgs e)
        {
            Homepage pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                pForm.Navlist.SelectedIndex = 4;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }

        private void on_shop_click(object sender, EventArgs e)
        {
            Homepage pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                pForm.Navlist.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }

        private void on_shop(object sender, EventArgs e)
        {
        }
    }
}