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
            //Shows feedback for signing up
            //can be expanded to send a request or add to database
            MessageBox.Show("Thanks for signing up for our e-newsletter. \nWelcome to Together Culture.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Finds the parent form, as its implemented as a user control
            Homepage? pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                //sets to Events page
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
                //Sets to Blogs page
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
                //Sets to shop page
                pForm.Navlist.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }
    }
}