using DGVPrinterHelper;
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
    public partial class Placeorderusercontrol : UserControl
    {
        function fn = new function();
        String query;
        public Placeorderusercontrol()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String category = ComboCategory.Text;
            query = "select name from items where category='"+category+"'";
            showitemlist(query);
           
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
            String category = ComboCategory.Text;
            query = "select name from items where category='" + category + "' and name like'"+txtsearch.Text+"%'";
            showitemlist(query);
        }
        private void showitemlist(string query)
        {
            itemshow.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                itemshow.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            

            }
        }

        private void itemshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantityupdown.ResetText();
            txttotal.Clear();
            String text = itemshow.GetItemText(itemshow.SelectedItem);
            txtitemnameadd.Text = text;
            query = "select price from items where name ='"+text+"'";
            DataSet ds = fn.getData(query);

            txtprice.Text = ds.Tables[0].Rows[0][0].ToString();



        }

        private void txtquantityupdown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtquantityupdown.Value.ToString());
            Int64 price = Int64.Parse(txtprice.Text);
            txttotal.Text = (quan * price).ToString();

        }
        protected int n, total = 0;


        int amount; 
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {///catcing the price.
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.SelectedRows[0].Index);//selecting the row which i want to delete.

            }
            catch
            {

            }
            total -= amount;
            labeltotalamount.Text = "Tk. " + total;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("DATE: {0}",DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumber = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable Amount : " + labeltotalamount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);
            total = 0;
            guna2DataGridView1.Rows.Clear();
            labeltotalamount.Text = "TK "+ total;
        }

        private void Placeorderusercontrol_Load(object sender, EventArgs e)
        {

        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (txttotal.Text != "0" && txttotal.Text != "")//handling the exception generate when the quantity is 0 and the addtocart btn pressed
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtitemnameadd.Text;//adding the item description in the gridview
                guna2DataGridView1.Rows[n].Cells[1].Value = txtprice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtquantityupdown.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txttotal.Text;
                total = total + int.Parse(txttotal.Text);
                labeltotalamount.Text = "TK. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
