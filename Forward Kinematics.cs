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
    public partial class Forward_Kinematics : Form
    {
        public Forward_Kinematics()
        {
            InitializeComponent();
            Per1.Text = Track1.Value.ToString() + "°";
            Per2.Text = Track2.Value.ToString() + "°";
            Per3.Text = Track3.Value.ToString() + "°";
            Per4.Text = Track4.Value.ToString() + "°";
            Per5.Text = Track5.Value.ToString() + "%";

        }
        private void buttonAdd(Guna2NumericUpDown Num, Guna2TrackBar track , Label percentage)
        {
            if (track.Value + Num.Value <= 360)
            {
                track.Value += (int)Num.Value;
                percentage.Text = track.Value.ToString() + "°";
            }
        }

        private void buttonMinus(Guna2NumericUpDown Num, Guna2TrackBar track, Label percentage)
        {
            if (track.Value - Num.Value >= 1)
            {
                track.Value -= (int)Num.Value;
                percentage.Text = track.Value.ToString() + "°";
            }
        }

        private void TrackBarScroll(Guna2TrackBar track, Label percentage)
        {
            percentage.Text = track.Value.ToString() + "°";
        }

        private void Track1_Scroll(object sender, ScrollEventArgs e)
        {
            TrackBarScroll(Track1, Per1);
        }
       

        private void Track2_Scroll(object sender, ScrollEventArgs e)
        {
            TrackBarScroll(Track2, Per2);
        }

        private void Track3_Scroll(object sender, ScrollEventArgs e)
        {
            TrackBarScroll(Track3, Per3);
        }

        private void Track4_Scroll(object sender, ScrollEventArgs e)
        {
            TrackBarScroll(Track4, Per4);
        }
        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            buttonAdd(NumUpDown1, Track1, Per1);
        }
        
        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            buttonAdd(NumUpDown2, Track2, Per2);
         }

        private void guna2GradientCircleButton5_Click(object sender, EventArgs e)
        {
            buttonAdd(NumUpDown3, Track3, Per3);
         }

        private void guna2GradientCircleButton7_Click(object sender, EventArgs e)
        {
            buttonAdd(NumUpDown4, Track4, Per4);
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            buttonMinus(NumUpDown1, Track1, Per1);
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            buttonMinus(NumUpDown2, Track2, Per2);
        }

        private void guna2GradientCircleButton6_Click(object sender, EventArgs e)
        {
            buttonMinus(NumUpDown3, Track3, Per3);
        }

        private void guna2GradientCircleButton8_Click(object sender, EventArgs e)
        {
            buttonMinus(NumUpDown4, Track4, Per4);
        }

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

        private void Track5_Scroll(object sender, ScrollEventArgs e)
        {
            Per5.Text = Track5.Value.ToString() + "%";
        }
    }
}
