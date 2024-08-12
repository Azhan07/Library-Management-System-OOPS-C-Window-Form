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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "" && Bookpd.Text != "")
            {
                operation op = new operation();
                op.connectdb();
                op.insertdata("insert into addbook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values('" + txtbookname.Text + "','" + txtAuthor.Text + "','" + txtPublication.Text + "','" + Bookpd.Text + "',' " + txtPrice.Text + " ',' " + txtQuantity.Text + "')");
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Empty Field Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("This will Delete your unsaved data", "Are You Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
           {
            this.Close();
           }
           
        }

        private void txtbookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Book_Load(object sender, EventArgs e)
        {

        }

     

     
    }
}