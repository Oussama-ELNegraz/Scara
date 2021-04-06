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
    public partial class Edit : Form
    {
        public int xEdit, yEdit, zEdit, gripEdit;
        
        public Edit(int x , int y ,int z ,int gripperVal)
        {
            InitializeComponent();
            editX.Text = x.ToString();
            editY.Text = y.ToString();
            editZ.Text = z.ToString();
            editTrack.Value = gripperVal;
            Per5.Text = editTrack.Value.ToString() + " %";

        }


        private void editTrack_Scroll(object sender, ScrollEventArgs e)
        {
            Per5.Text = editTrack.Value.ToString() + " %";
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            xEdit           = Convert.ToInt32(editX.Text);
            yEdit           = Convert.ToInt32(editY.Text);
            zEdit           = Convert.ToInt32(editZ.Text);
            gripEdit        = Convert.ToInt32(editTrack.Value);
            DialogResult    = DialogResult.OK;
            this.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
