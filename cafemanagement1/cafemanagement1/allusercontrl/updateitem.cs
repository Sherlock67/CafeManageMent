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
    public partial class updateitem : UserControl
    {
        String query;
        function fn = new function();
        public updateitem()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateitem_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void searchitem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '"+searchitem.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());// fetching data into textbox
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            updatecategory.Text = category;
            updateitemname.Text = name;
            updateprice.Text = price.ToString();
            
        
        
        
        }

        private void btnupdatepage_Click(object sender, EventArgs e)
        {
            query = "update items set name ='"+updateitemname.Text+ '",category ='string v = "+updateitemname.Text+'"; ";
        }
    }
}
