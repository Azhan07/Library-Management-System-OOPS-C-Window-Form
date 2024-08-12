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
    public partial class viewstudent : Form
    {
        public viewstudent()
        {
            InitializeComponent();
        }

        private void viewstudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            operation op = new operation();
            op.connectdb();
            op.viewdata("select * from NewStudent");
            dataGridView1.DataSource = op.dt;
            op.conn.Close();
        }

        private void searching_TextChanged(object sender, EventArgs e)
        {
            if (searching.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:/Users/lenovo/Downloads/Liberay Management System Icon and Images/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
                operation op = new operation();
                op.connectdb();
                op.viewdata("select * from NewStudent where enroll LIKE '" +searching.Text+"%'");
                dataGridView1.DataSource = op.dt;
                op.conn.Close();
            }
            else {
                label1.Visible = true;
                Image image = Image.FromFile("C:/Users/lenovo/Downloads/Liberay Management System Icon and Images/Liberay Management System/search.gif");
                pictureBox1.Image = image;
                operation op = new operation();
                op.connectdb();
                op.viewdata("select * from NewStudent");
                dataGridView1.DataSource = op.dt;
                op.conn.Close();
            }
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            operation op2 = new operation();
            op2.connectdb();
            op2.viewdata("select * from NewStudent where stuid=" + bid + "");
            rowid = Int64.Parse(op2.dt.Rows[0][0].ToString());

            studentname.Text = op2.dt.Rows[0][1].ToString();
            txtenroll.Text = op2.dt.Rows[0][2].ToString();
            txtdept.Text = op2.dt.Rows[0][3].ToString();
            txtstsem.Text = op2.dt.Rows[0][4].ToString();
            txtstcont.Text = op2.dt.Rows[0][5].ToString();
            txtstemail.Text = op2.dt.Rows[0][6].ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated. confirmed?", "success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                operation op4 = new operation();
                op4.connectdb();
                op4.updatedata("update NewStudent set sname='" + studentname.Text + "',enroll='" + txtenroll.Text + "',dept='" + txtdept.Text + "',semester='" + txtstsem.Text + "',contact='" + txtstcont.Text + "',email='" + txtstemail.Text + "'where bid=" + rowid + " ");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("unsaved data will be lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. confirmed?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                operation op5 = new operation();
                op5.connectdb();
                op5.deletedata("delete from NewStudent where stuid=" + rowid + "");
            }
        }
    }
}
