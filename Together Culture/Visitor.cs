namespace Together_Culture
{
    public partial class Visitor : UserControl
    {
        public Visitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitorForm? form = this.FindForm() as VisitorForm;

            if (form != null)
            {
                MessageBox.Show("Registered Successfully. Please wait for confirmation email", "Success", MessageBoxButtons.OK);
                form.Close();
            }
            else
            {
                MessageBox.Show("Parent form is not VisitorForm");
            }
        }
    }
}