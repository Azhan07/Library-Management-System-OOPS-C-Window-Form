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
    public partial class return_book : Form
    {
      
        Int64 rowid;
        public return_book()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            operation op = new operation();
            op.connectdb();
            op.viewdata("select * from IRBook where std_enroll ='" + enrollno.Text + "'and book_return_date is null");
          
            if (op.dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = op.dt;
            }
            else {
                MessageBox.Show("Invalid Id or No book issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)

            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bookname.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bookissuedate.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            operation op = new operation();
            op.connectdb();
            op.updatedata("update IRBook set book_return_date = '" + dateTimePicker1.Text + "'where std_enroll='" + enrollno.Text + "'and id = " + rowid + "");
            MessageBox.Show("Return Successfull", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return_book_Load(this, null);
        }

        private void return_book_Load(object sender, EventArgs e)
        {
           
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            enrollno.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will Delete your unsaved data", "Are You Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
     

       
    }
}
