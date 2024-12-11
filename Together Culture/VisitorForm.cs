namespace Together_Culture
{
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            //Uses Visitor.cs user-defined Control
            InitializeComponent();
        }

        public Visitor Visitor
        {
            get => default;
            set
            {
            }
        }
    }
}