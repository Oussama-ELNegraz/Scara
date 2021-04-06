using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace Testing
{
    public partial class Form2 : Form
    {
        int mouseX, mouseY;
        int mouseDown;
        
        public Form2()
        {
            InitializeComponent();
            FormInPanel(new Manage());


        }


        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 127, b.Location.Y - 30);
            imgSlide.SendToBack();
        }

        private void FormInPanel(object Child)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = Child as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        private void Forward_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            FormInPanel(new Forward_Kinematics());
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            FormInPanel(new Inverse_Kinematics());
        }
        private void Manage_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            FormInPanel(new Manage());
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            FormInPanel(new Settings());
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = 1;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX - 180, MousePosition.Y - mouseY);
            }
        }
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = 0;
        }

        
    }
}
