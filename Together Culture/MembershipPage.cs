namespace Together_Culture
{
    public partial class MembershipPage : UserControl
    {
        public MembershipPage()
        {
            InitializeComponent();
        }

        private void join_click(object sender, EventArgs e)
        {
            //demo code
            //easily implement database requests
            MessageBox.Show("Thanks for showing interest in our community. \n\nAn e-mail has been sent on your registered e-mail address. \n\nPlease follow the next steps as mentioned.", "Success", MessageBoxButtons.OK);
        }
    }
}