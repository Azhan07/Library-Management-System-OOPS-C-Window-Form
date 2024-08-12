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
    public partial class completedata : Form
    {
        public completedata()
        {
            InitializeComponent();
        }

        private void completedata_Load(object sender, EventArgs e)
        {
            operation op = new operation();
            op.connectdb();
            op.viewdata("select * from IRBook where book_return_date is null");
            dataGridView1.DataSource = op.dt;

            op.viewdata("select * from IRBook where book_return_date is not null");
            dataGridView2.DataSource = op.dt;

        }
    }
}
