using cafemanagement1.allusercontrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafemanagement1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();
            if(user == "Guest")
            {
                btnadditems.Hide();
                btnupdate.Hide();
                btnremove.Hide();
            }
            else if(user=="Admin")
            {
                btnadditems.Show();
                btnupdate.Show();
                btnremove.Show();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            additemusercontrol1.Visible = false;
            placeorderusercontrol1.Visible = false;
            updateitem1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            updateitem1.Visible = true;
            updateitem1.BringToFront();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //placeorderclick
            userwelcome1.SendToBack();
            guna2Transition1.ShowSync(placeorderusercontrol1);
            placeorderusercontrol1.Visible = true;
            placeorderusercontrol1.BringToFront();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          


        }

        private void btnlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnadditems_Click(object sender, EventArgs e)
        {
            //additemclick 
            additemusercontrol1.Visible = true;
            additemusercontrol1.BringToFront();

        }
    }
}
