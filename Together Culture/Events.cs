namespace Together_Culture
{
    public partial class Events : UserControl
    {
        public Events()
        {
            InitializeComponent();
        }

        public Event_Info Event_Info
        {
            get => default;
            set
            {
            }
        }

        private void event1_click(object sender, EventArgs e)
        {
            String event_name = "null", event_desc = "null", event_info = "null";
            switch ((sender as Panel)?.Name)
            {
                case "panel4":
                    event_name = "Art gathering";
                    event_desc = "Join us for an inspiring evening celebrating art and community! Discover diverse artworks, connect with local artists, and immerse yourself in creativity. Featuring live demonstrations, interactive workshops, and vibrant exhibitions, this gathering is perfect for art enthusiasts and creators alike. Don’t miss the chance to explore and celebrate the power of artistic expression!";
                    event_info = "Venue: Together Culture, FItzroy Street\r\n\r\nTIme: 11 December 2024, 11 AM - 12.30 PM\r\n\r\nNo restrictions";
                    break;

                case "panel5":
                    event_name = "Yoga Session";
                    event_desc = "Join us for a rejuvenating yoga gathering, where mindfulness meets community. Connect with others, explore various yoga styles, and embrace the balance of body, mind, and spirit. Suitable for all levels, this event promises guided sessions, meditation, and moments of serenity. Experience the power of collective wellness!";
                    event_info = "Venue: Together Culture, FItzroy Street\r\n\r\nTIme: 13 December 2024, 10 AM - 12 PM\r\n\r\nFemale only";
                    break;

                case "panel6":
                    event_name = "Dinner Meeting";
                    event_desc = "Join us for a delightful dinner meeting where meaningful discussions meet great food. Network, share ideas, and collaborate in a relaxed, welcoming atmosphere. A perfect blend of connection and cuisine awaits!";
                    event_info = "Venue: Together Culture, FItzroy Street\r\n\r\nTIme: 15 December 2024, 8 AM - 11 PM\r\n\r\nNo restrictions";
                    break;

                default:
                    break;
            }

            Event_Info event_Info = new Event_Info(event_name, event_desc, event_info);
            event_Info.Show();
        }
    }
}