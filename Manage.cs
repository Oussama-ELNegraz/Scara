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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            
        }
        // Filter to number integer
        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Add Position
        private void Add_Click(object sender, EventArgs e)
        {
            // Validate That Not Empty 
            bool IsValid = true;
            if (guna2TextBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(guna2TextBox1, "Please Check That The Input It Not Empty");
                IsValid = false;
            }
            if (guna2TextBox2.Text.Trim() == "")
            {
                errorProvider1.SetError(guna2TextBox2, "Please Check That The Input It Not Empty");
                IsValid = false;
            }
            if (guna2TextBox3.Text.Trim() == "")
            {
                errorProvider1.SetError(guna2TextBox3, "Please Check That The Input It Not Empty");
                IsValid = false;
            }
            if (IsValid)
            {
                errorProvider1.Clear();
                int x           = Convert.ToInt32(guna2TextBox1.Text);
                int y           = Convert.ToInt32(guna2TextBox2.Text);
                int z           = Convert.ToInt32(guna2TextBox3.Text);
                int rang        = Convert.ToInt32(guna2DataGridView1.Rows.Count + 1);
                int gripper     = Track5.Value;
                object[] data    = { rang, x, y, z, gripper };
                guna2DataGridView1.Rows.Add(data);
            }            
        }

        // print the value of track bar
        private void Track5_Scroll(object sender, ScrollEventArgs e)
        {
            Per5.Text = Track5.Value.ToString() + "%";
        }

        // Edit Position
        public int xValue, yValue, zValue, gripValue;
        private void edit(object sender, EventArgs e)
        {
            if(guna2DataGridView1.CurrentRow != null)
            {
                xValue      = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value);
                yValue      = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[2].Value);
                zValue      = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[3].Value);
                gripValue   = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[4].Value);

                Edit frm = new Edit(xValue, yValue, zValue, gripValue);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    guna2DataGridView1.CurrentRow.Cells[1].Value = frm.xEdit;
                    guna2DataGridView1.CurrentRow.Cells[2].Value = frm.yEdit;
                    guna2DataGridView1.CurrentRow.Cells[3].Value = frm.zEdit;
                    guna2DataGridView1.CurrentRow.Cells[4].Value = frm.gripEdit;
                }
            }            
        }
         
        // Clear The Grid View
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
        }


        // Click on edit Button
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            edit(sender, e);
        }
        // Double Click on the Row
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 0)
                edit(sender, e);
        }

        // Remove Row
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null) { 
               
                guna2DataGridView1.Rows.Remove(guna2DataGridView1.CurrentRow);

                this.guna2DataGridView1.Sort(guna2DataGridView1.Columns[0], ListSortDirection.Ascending);

                int index = guna2DataGridView1.CurrentRow.Index;

                for(int i = index ; i < guna2DataGridView1.RowCount; i++)
                {
                    guna2DataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }
    }
}
