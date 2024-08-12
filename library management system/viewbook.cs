using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace library_management_system
{
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            
        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            operation op1 = new operation();
            op1.connectdb();
            op1.viewdata("select * from addbook");
            dataGridView1.DataSource = op1.dt;
            op1.conn.Close();
        }
        int bid;
        Int64 rowid; 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                 bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            
            operation op2 = new operation();
            op2.connectdb();
            op2.viewdata("select * from addbook where bid=" + bid + "");
            rowid = Int64.Parse(op2.dt.Rows[0][0].ToString());

            textbookname.Text = op2.dt.Rows[0][1].ToString();
            textbookauthor.Text = op2.dt.Rows[0][2].ToString();
            textbpublication.Text = op2.dt.Rows[0][3].ToString();
            bookpurchasedate.Text = op2.dt.Rows[0][4].ToString();
            bookprice.Text = op2.dt.Rows[0][5].ToString();
            bookquantity.Text = op2.dt.Rows[0][6].ToString();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textbook_TextChanged(object sender, EventArgs e)
        {
            if (textbook.Text != "")
            {

                operation op3 = new operation();
                op3.connectdb();
                op3.viewdata("select * from addbook where bName LIKE '" + textbook.Text + "%'");
                dataGridView1.DataSource = op3.dt;
                op3.conn.Close();
            }
            else {
                operation op3 = new operation();
                op3.connectdb();
                op3.viewdata("select * from addbook ");
                dataGridView1.DataSource = op3.dt;
                op3.conn.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            textbook.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated. confirmed?", "success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                operation op4 = new operation();
                op4.connectdb();
                op4.updatedata("update addbook set bName='" + textbookname.Text + "',bAuthor='" + textbookauthor.Text + "',bPubl='" + textbpublication.Text + "',bPDate='" + bookpurchasedate.Text + "',bPrice='" + bookprice.Text + "',bQuan='" + bookquantity.Text + "'where bid=" + rowid + " ");
            }
         

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. confirmed?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                operation op5 = new operation();
                op5.connectdb();
                op5.deletedata("delete from addbook where bid="+rowid +"");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
