using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            this.Select();
        }

        public MemberManager MemberManager
        {
            get => default;
            set
            {
            }
        }

        public AddTag AddTag
        {
            get => default;
            set
            {
            }
        }

        public Announce Announce
        {
            get => default;
            set
            {
            }
        }

        public EventManager EventManager
        {
            get => default;
            set
            {
            }
        }

        public ShopManager ShopManager
        {
            get => default;
            set
            {
            }
        }

        private void exit_clicked(object sender, EventArgs e)
        {
            //handles exit, finds parent form as this is implemented as a User Control
            Homepage? pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                //goes to default home page
                pForm.Navlist.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }

        private void ver_info_click(object sender, EventArgs e)
        {
            //Shows demo info
            MessageBox.Show("Together Culture\nVersion 1.0 \n\nCreated by: Dhrumil, Jose, Ali, Dhruv, Gagan\nFor Software Engineering Assignment");
        }

        private void mem_click(object sender, EventArgs e)
        {
            //Open form to manage members and tags
            MemberManager memberManager = new MemberManager();
            memberManager.Show();
        }

        private void manage_events_click(object sender, EventArgs e)
        {
            //opens form to manage events
            EventManager eventManager = new EventManager();
            eventManager.Show();
        }

        private void announce(object sender, EventArgs e)
        {

            //opens form to make new announcements
            Announce announce = new Announce();
            announce.Show();
        }

        private void shop_manage(object sender, EventArgs e)
        {
            //opens form to manage digital shop items
            ShopManager shopManager = new ShopManager();
            shopManager.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}