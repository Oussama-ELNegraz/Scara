
namespace Testing
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Setting = new Guna.UI2.WinForms.Guna2Button();
            this.Manage = new Guna.UI2.WinForms.Guna2Button();
            this.Inverse = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.Forward = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Setting);
            this.panel1.Controls.Add(this.Manage);
            this.panel1.Controls.Add(this.Inverse);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Controls.Add(this.Forward);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ensaté";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Club Mecatronique";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scara Arm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.Transparent;
            this.Setting.BorderRadius = 22;
            this.Setting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Setting.CheckedState.FillColor = System.Drawing.Color.White;
            this.Setting.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Setting.CheckedState.Parent = this.Setting;
            this.Setting.CustomImages.Parent = this.Setting;
            this.Setting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.HoverState.Parent = this.Setting;
            this.Setting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Setting.ImageOffset = new System.Drawing.Point(10, 0);
            this.Setting.Location = new System.Drawing.Point(15, 410);
            this.Setting.Name = "Setting";
            this.Setting.ShadowDecoration.Parent = this.Setting;
            this.Setting.Size = new System.Drawing.Size(163, 43);
            this.Setting.TabIndex = 4;
            this.Setting.Text = "Settings";
            this.Setting.UseTransparentBackground = true;
            this.Setting.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Manage
            // 
            this.Manage.BackColor = System.Drawing.Color.Transparent;
            this.Manage.BorderRadius = 22;
            this.Manage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Manage.CheckedState.FillColor = System.Drawing.Color.White;
            this.Manage.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Manage.CheckedState.Parent = this.Manage;
            this.Manage.CustomImages.Parent = this.Manage;
            this.Manage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Manage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Manage.ForeColor = System.Drawing.Color.White;
            this.Manage.HoverState.Parent = this.Manage;
            this.Manage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Manage.ImageOffset = new System.Drawing.Point(10, 0);
            this.Manage.Location = new System.Drawing.Point(15, 340);
            this.Manage.Name = "Manage";
            this.Manage.ShadowDecoration.Parent = this.Manage;
            this.Manage.Size = new System.Drawing.Size(163, 43);
            this.Manage.TabIndex = 3;
            this.Manage.Text = "Manage Position";
            this.Manage.UseTransparentBackground = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // Inverse
            // 
            this.Inverse.BackColor = System.Drawing.Color.Transparent;
            this.Inverse.BorderRadius = 22;
            this.Inverse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Inverse.CheckedState.FillColor = System.Drawing.Color.White;
            this.Inverse.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Inverse.CheckedState.Parent = this.Inverse;
            this.Inverse.CustomImages.Parent = this.Inverse;
            this.Inverse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Inverse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Inverse.ForeColor = System.Drawing.Color.White;
            this.Inverse.HoverState.Parent = this.Inverse;
            this.Inverse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Inverse.ImageOffset = new System.Drawing.Point(10, 0);
            this.Inverse.Location = new System.Drawing.Point(15, 270);
            this.Inverse.Name = "Inverse";
            this.Inverse.ShadowDecoration.Parent = this.Inverse;
            this.Inverse.Size = new System.Drawing.Size(163, 43);
            this.Inverse.TabIndex = 2;
            this.Inverse.Text = "Inverse Kinematics";
            this.Inverse.UseTransparentBackground = true;
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(142, 170);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 100);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.Transparent;
            this.Forward.BorderRadius = 22;
            this.Forward.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Forward.Checked = true;
            this.Forward.CheckedState.FillColor = System.Drawing.Color.White;
            this.Forward.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Forward.CheckedState.Parent = this.Forward;
            this.Forward.CustomImages.Parent = this.Forward;
            this.Forward.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Forward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Forward.ForeColor = System.Drawing.Color.White;
            this.Forward.HoverState.Parent = this.Forward;
            this.Forward.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Forward.ImageOffset = new System.Drawing.Point(10, 0);
            this.Forward.Location = new System.Drawing.Point(15, 200);
            this.Forward.Name = "Forward";
            this.Forward.ShadowDecoration.Parent = this.Forward;
            this.Forward.Size = new System.Drawing.Size(163, 43);
            this.Forward.TabIndex = 0;
            this.Forward.Text = "Forward Kinematics ";
            this.Forward.UseTransparentBackground = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(892, 609);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1072, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Forward;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button Setting;
        private Guna.UI2.WinForms.Guna2Button Manage;
        private Guna.UI2.WinForms.Guna2Button Inverse;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}