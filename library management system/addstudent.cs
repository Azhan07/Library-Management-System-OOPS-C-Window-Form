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
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmed?", "Alter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtstname.Clear();
            txtstemail.Clear();
            txtenroll.Clear();
            txtdept.Clear();
            txtstsem.Clear();
            txtstcont.Clear();
        }

        private void savebtrn_Click(object sender, EventArgs e)
        {
            if (txtstname.Text != "" && txtenroll.Text != "" && txtdept.Text != "" && txtstsem.Text != "" && txtstcont.Text != "" && txtstemail.Text != "")
            {
                operation op = new operation();
                op.connectdb();
                op.insertdata("insert into NewStudent (sname,enroll,dept,semester,contact,email) values ('" + txtstname.Text + "','" + txtenroll.Text + "','" + txtdept.Text + "','" + txtstsem.Text + "',' " + txtstcont.Text + " ',' " + txtstemail.Text + "')");
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void txtstname_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
