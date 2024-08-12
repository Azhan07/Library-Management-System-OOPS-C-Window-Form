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
   
    public partial class issuebook : Form
    {
        
        public issuebook()
        {
            InitializeComponent();
        }

        private void combobookbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void issuebook_Load(object sender, EventArgs e)
        {
            operation op = new operation();
            op.connectdb();
            op.viewdata("select bName from addbook");
            combobookbox.DataSource = op.dt;
            combobookbox.DisplayMember = "bName";
        }
        int count2;
        private void searchstbtn_Click(object sender, EventArgs e)
        {
   
            operation op = new operation();
            op.connectdb();
            if (txtenrollment.Text != "")
            {
               
                op.viewdata("select * from NewStudent where enroll = '"+txtenrollment.Text+"'" );

              
                if (op.dt.Rows.Count != 0)
                {
                    txtstname.Text = op.dt.Rows[0][1].ToString();
                    txtdept.Text = op.dt.Rows[0][3].ToString();
                    txtstsem.Text = op.dt.Rows[0][4].ToString();
                    txtstcont.Text = op.dt.Rows[0][5].ToString();
                    txtstemail.Text = op.dt.Rows[0][6].ToString();
                }
                else {
                    MessageBox.Show("Invalid Enrollment No","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            if (txtenrollment.Text != "")
            {
                op.viewdata("select count (std_enroll) from IRBook where std_enroll= '" + txtenrollment.Text + "'and book_return_date is null");
                count2 = int.Parse(op.dt.Rows[0][0].ToString());
            }
          
        }

        private void issuebookbtn_Click(object sender, EventArgs e)
        {
            if (combobookbox.SelectedIndex != -1 && count2 <= 2)
            {
                operation op = new operation();
                op.connectdb();
                op.insertdata("insert into IRBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + txtenrollment.Text + "','" + txtstname.Text + "','" + txtdept.Text + "','" + txtstsem.Text + "','" + txtstcont.Text + "','" + txtstemail.Text + "','" + combobookbox.Text + "','" + bookissuedate.Text + "')");
                MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("Select Book . OR maximum number of book has been issued", "No book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            txtenrollment.Clear();   
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtenrollment_TextChanged(object sender, EventArgs e)
        {

        }
        
      
    }
}
