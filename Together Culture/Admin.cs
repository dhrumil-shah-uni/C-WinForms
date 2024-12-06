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

        private void exit_clicked(object sender, EventArgs e)
        {
            Homepage? pForm = this.FindForm() as Homepage;

            if (pForm != null)
            {
                pForm.Navlist.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Parent form is not Homepage");
            }
        }

        private void ver_info_click(object sender, EventArgs e)
        {
            MessageBox.Show("Together Culture\nVersion 1.0 \n\nCreated by: Dhrumil, Jose, Ali, Dhruv, Gagan\nFor Software Engineering Assignment");
        }

        private void mem_click(object sender, EventArgs e)
        {
            MemberManager memberManager = new MemberManager();
            memberManager.Show();
        }

        private void manage_events_click(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            eventManager.Show();
        }

        private void announce(object sender, EventArgs e)
        {
            Announce announce = new Announce();
            announce.Show();
        }

        private void shop_manage(object sender, EventArgs e)
        {
            ShopManager shopManager = new ShopManager();
            shopManager.Show();
        }
    }
}
