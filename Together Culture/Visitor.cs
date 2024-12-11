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
            //References parent form i.e. VisitorForm.cs
            VisitorForm? form = this.FindForm() as VisitorForm;

            //This can be expanded to accept user input into a table in database
            
            //Following code checks if the form is selected correctly
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