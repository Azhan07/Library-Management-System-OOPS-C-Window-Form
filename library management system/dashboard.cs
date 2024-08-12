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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure You want To Log Out", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes){
                Application.Exit();
            }
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Book a1 = new Add_Book();
            a1.Show();
        }

        private void vIEWBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();
            vb.Show();
        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstudent ad = new addstudent();
            ad.Show();
        }

        private void vIEWSTUDENTINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent vs = new viewstudent();
            vs.Show();
        }

        private void iSSUEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebook ib = new issuebook();
            ib.Show();

        }

        private void rETURNBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return_book rb = new return_book();
            rb.Show();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cOMPLETEBOOKSDETAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completedata cd = new completedata();
            cd.Show();

        }
    }
}
