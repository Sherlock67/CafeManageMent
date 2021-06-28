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
    public partial class additemusercontrol : UserControl
    {
        function fn = new function();
        String query;
        public additemusercontrol()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "insert into items(name , category , price) values ('"+ txtitemname.Text+ "','"+ txtcategory.Text+ "',"+txtprice.Text+")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtcategory.SelectedIndex = -1;
            txtitemname.Clear();
            txtprice.Clear();
        }

        private void additemusercontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
