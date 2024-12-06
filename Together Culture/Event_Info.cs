﻿using System;
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
    public partial class Event_Info : Form
    {

        //private String event_name;
        //private String event_desc;
        //private String event_info;


        public Event_Info(String event_name, String event_desc, String event_info)
        {

            InitializeComponent();
            label1.Text = event_name;
            label2.Text = event_desc;
            label3.Text = event_info;
        }

        private void ticket_book(object sender, EventArgs e)
        {
            MessageBox.Show("Booked Successfully", "Success", MessageBoxButtons.OK);
        }
    }
}
