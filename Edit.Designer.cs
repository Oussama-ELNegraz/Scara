
namespace Testing
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Per5 = new System.Windows.Forms.Label();
            this.editTrack = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.editY = new Guna.UI2.WinForms.Guna2TextBox();
            this.editZ = new Guna.UI2.WinForms.Guna2TextBox();
            this.editX = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // Per5
            // 
            this.Per5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per5.Location = new System.Drawing.Point(459, 103);
            this.Per5.Name = "Per5";
            this.Per5.Size = new System.Drawing.Size(74, 30);
            this.Per5.TabIndex = 71;
            this.Per5.Text = "50 %";
            this.Per5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editTrack
            // 
            this.editTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.editTrack.HoverState.Parent = this.editTrack;
            this.editTrack.IndicateFocus = false;
            this.editTrack.Location = new System.Drawing.Point(153, 103);
            this.editTrack.Name = "editTrack";
            this.editTrack.Size = new System.Drawing.Size(300, 30);
            this.editTrack.TabIndex = 70;
            this.editTrack.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.editTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.editTrack_Scroll);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 69;
            this.label7.Text = "Gripper";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editY
            // 
            this.editY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editY.DefaultText = "";
            this.editY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editY.DisabledState.Parent = this.editY;
            this.editY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editY.FocusedState.Parent = this.editY;
            this.editY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editY.HoverState.Parent = this.editY;
            this.editY.Location = new System.Drawing.Point(278, 43);
            this.editY.MaxLength = 3;
            this.editY.Name = "editY";
            this.editY.PasswordChar = '\0';
            this.editY.PlaceholderText = "";
            this.editY.SelectedText = "";
            this.editY.ShadowDecoration.Parent = this.editY;
            this.editY.Size = new System.Drawing.Size(40, 40);
            this.editY.TabIndex = 68;
            // 
            // editZ
            // 
            this.editZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editZ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editZ.DefaultText = "";
            this.editZ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editZ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editZ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editZ.DisabledState.Parent = this.editZ;
            this.editZ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editZ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editZ.FocusedState.Parent = this.editZ;
            this.editZ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editZ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editZ.HoverState.Parent = this.editZ;
            this.editZ.Location = new System.Drawing.Point(430, 43);
            this.editZ.MaxLength = 3;
            this.editZ.Name = "editZ";
            this.editZ.PasswordChar = '\0';
            this.editZ.PlaceholderText = "";
            this.editZ.SelectedText = "";
            this.editZ.ShadowDecoration.Parent = this.editZ;
            this.editZ.Size = new System.Drawing.Size(40, 40);
            this.editZ.TabIndex = 67;
            // 
            // editX
            // 
            this.editX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editX.DefaultText = "";
            this.editX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editX.DisabledState.Parent = this.editX;
            this.editX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editX.FocusedState.Parent = this.editX;
            this.editX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editX.HoverState.Parent = this.editX;
            this.editX.Location = new System.Drawing.Point(124, 43);
            this.editX.MaxLength = 3;
            this.editX.Name = "editX";
            this.editX.PasswordChar = '\0';
            this.editX.PlaceholderText = "";
            this.editX.SelectedText = "";
            this.editX.ShadowDecoration.Parent = this.editX;
            this.editX.Size = new System.Drawing.Size(40, 40);
            this.editX.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 65;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 64;
            this.label2.Text = "Z";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelx
            // 
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.Location = new System.Drawing.Point(39, 52);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(107, 30);
            this.labelx.TabIndex = 63;
            this.labelx.Text = "X";
            this.labelx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(106, 180);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(135, 45);
            this.guna2GradientButton1.TabIndex = 72;
            this.guna2GradientButton1.Text = "Save";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(319, 180);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(135, 45);
            this.guna2GradientButton2.TabIndex = 73;
            this.guna2GradientButton2.Text = "Cancel";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 262);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.Per5);
            this.Controls.Add(this.editTrack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editY);
            this.Controls.Add(this.editZ);
            this.Controls.Add(this.editX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Per5;
        private Guna.UI2.WinForms.Guna2TrackBar editTrack;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox editY;
        private Guna.UI2.WinForms.Guna2TextBox editZ;
        private Guna.UI2.WinForms.Guna2TextBox editX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelx;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}