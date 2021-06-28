using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafemanagement1.allusercontrl
{
    public partial class userwelcome : UserControl
    {
        public userwelcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelbanner.Location = new Point(94, 567);
                labelbanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                labelbanner.Location = new Point(166, 367);
                labelbanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelbanner.Location = new Point(268, 367);
                labelbanner.ForeColor = Color.Red;
                num = 0;
            }
        }

        private void userwelcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
