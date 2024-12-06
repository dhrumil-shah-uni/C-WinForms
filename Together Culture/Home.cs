namespace Together_Culture
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for signing up for our e-newsletter. \nWelcome to Together Culture.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage? pForm = this.FindForm() as Homepage;

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
            Homepage? pForm = this.FindForm() as Homepage;

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
            Homepage? pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                pForm.Navlist.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }
    }
}