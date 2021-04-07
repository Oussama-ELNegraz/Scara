using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Inverse_Kinematics : Form
    {
        public Inverse_Kinematics()
        {
            InitializeComponent();
        }

        // Filter For Numbers
        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //panel text percentage
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Track5.Value = 90;
            Per5.Text = Track5.Value.ToString() + "%";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Track5.Value = 10;
            Per5.Text = Track5.Value.ToString() + "%";
        }

        // Track Scroll
        private void Track5_Scroll(object sender, ScrollEventArgs e)
        {
            Per5.Text = Track5.Value.ToString() + "%";
        }
    }
}
