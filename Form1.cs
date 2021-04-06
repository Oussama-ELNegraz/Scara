using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Testing
{
    public partial class Form1 : Form
    {
        //    int mov, movX, movY;
        int mouseX, mouseY;
        int mouseDown;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // label1.Text = track.Value.ToString();

            this.Location = Screen.AllScreens[1].WorkingArea.Location;
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
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }


        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = 0;
        }


        /*
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        */

        /*       private void progressBar_Click(object sender, EventArgs e)
               {
                   // Get mouse position(x) minus the width of the progressbar (so beginning of the progressbar is mousepos = 0 //
                   float absoluteMouse = (PointToClient(MousePosition).X - track.Bounds.X);
                   // Calculate the factor for converting the position (progbarWidth/100) //
                   float calcFactor = track.Width / (float)track.Maximum;
                   // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
                   float relativeMouse = absoluteMouse / calcFactor;

                   // Set the calculated relative value to the progressbar //
                   //progressBar.Value = Convert.ToInt32(relativeMouse);
                   if(progressBar.Value < Convert.ToInt32(relativeMouse))
                       for (int i = progressBar.Value; i <= Convert.ToInt32(relativeMouse); i++)
                       {
                           progressBar.Value = i;
                           Thread.Sleep(1000);
                       }
                   else
                       for (int i = progressBar.Value; i >= Convert.ToInt32(relativeMouse); i--)
                       {
                           progressBar.Value = i;
                           Thread.Sleep(1000);
                       }
                   label1.Text = progressBar.Value.ToString();
               }
        *//*
        private void button2_Click(object sender, EventArgs e)
        {
            if (track.Value + numericUpDown1.Value <= 360) {
                track.Value += (int) numericUpDown1.Value;
                label1.Text = track.Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (track.Value - numericUpDown1.Value >= 1)
            {
                track.Value -= (int) numericUpDown1.Value;
                label1.Text = track.Value.ToString();
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = track.Value.ToString();
        }*/
    }
}
/*
            ProgressBar pr = sender as ProgressBar;
            // Get mouse position(x) minus the width of the progressbar (so beginning of the progressbar is mousepos = 0 //
            float absoluteMouse = (PointToClient(MousePosition).X - pr.Bounds.X);
            float a = PointToClient(MousePosition).X;
            MessageBox.Show(a.ToString());
            // Calculate the factor for converting the position (progbarWidth/100) //
            float calcFactor = pr.Width / (float)pr.Maximum;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
            float relativeMouse = absoluteMouse / calcFactor;

            // Set the calculated relative value to the progressbar //
            pr.Value = Convert.ToInt32(relativeMouse);
 */