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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 690)
            {
                timer1.Stop();
                Form3 f2 = new Form3();
                f2.Show();
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
