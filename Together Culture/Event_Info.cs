namespace Together_Culture
{
    public partial class Event_Info : Form
    {
        public Event_Info(String event_name, String event_desc, String event_info)
        {
            //gets information from the parameters and sets it respectively
            InitializeComponent();
            label1.Text = event_name;
            label2.Text = event_desc;
            label3.Text = event_info;
        }

        private void ticket_book(object sender, EventArgs e)
        {
            //Feedback for booking an event - can also be added to db
            MessageBox.Show("Booked Successfully", "Success", MessageBoxButtons.OK);
        }
    }
}