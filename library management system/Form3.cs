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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void user_MouseClick(object sender, MouseEventArgs e)
        {
            if (user.Text == "UserName")
            {
                user.Clear();
            }
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Clear();
                pass.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation op = new operation();
            op.connectdb();
            op.viewdata("select * from logintable where username='" + user.Text + "'and pass ='" + pass.Text + "'");

            if (op.dt.Rows.Count != 0)
            {
                dashboard db = new dashboard();
                db.Show();
            }
            else {
                MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      
      
    }
}
