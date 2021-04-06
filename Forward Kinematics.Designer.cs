
namespace Testing
{
    partial class Forward_Kinematics
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Track1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.Track2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Track3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Track4 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Per1 = new System.Windows.Forms.Label();
            this.NumUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton4 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.NumUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2GradientCircleButton5 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton6 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.NumUpDown3 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2GradientCircleButton7 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton8 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.NumUpDown4 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Per4 = new System.Windows.Forms.Label();
            this.Per3 = new System.Windows.Forms.Label();
            this.Per2 = new System.Windows.Forms.Label();
            this.Per5 = new System.Windows.Forms.Label();
            this.Track5 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forward Kinematics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Joint Angle 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Track1
            // 
            this.Track1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Track1.HoverState.Parent = this.Track1;
            this.Track1.IndicateFocus = false;
            this.Track1.Location = new System.Drawing.Point(314, 133);
            this.Track1.Maximum = 360;
            this.Track1.Name = "Track1";
            this.Track1.Size = new System.Drawing.Size(300, 30);
            this.Track1.TabIndex = 2;
            this.Track1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.Track1.Value = 180;
            this.Track1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Track1_Scroll);
            // 
            // Track2
            // 
            this.Track2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Track2.HoverState.Parent = this.Track2;
            this.Track2.IndicateFocus = false;
            this.Track2.Location = new System.Drawing.Point(314, 215);
            this.Track2.Maximum = 360;
            this.Track2.Name = "Track2";
            this.Track2.Size = new System.Drawing.Size(300, 30);
            this.Track2.TabIndex = 4;
            this.Track2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.Track2.Value = 180;
            this.Track2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Track2_Scroll);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Joint Angle 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Track3
            // 
            this.Track3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Track3.HoverState.Parent = this.Track3;
            this.Track3.IndicateFocus = false;
            this.Track3.Location = new System.Drawing.Point(314, 297);
            this.Track3.Maximum = 360;
            this.Track3.Name = "Track3";
            this.Track3.Size = new System.Drawing.Size(300, 30);
            this.Track3.TabIndex = 6;
            this.Track3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.Track3.Value = 180;
            this.Track3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Track3_Scroll);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Joint Angle 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Track4
            // 
            this.Track4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Track4.HoverState.Parent = this.Track4;
            this.Track4.IndicateFocus = false;
            this.Track4.Location = new System.Drawing.Point(314, 379);
            this.Track4.Maximum = 360;
            this.Track4.Name = "Track4";
            this.Track4.Size = new System.Drawing.Size(300, 30);
            this.Track4.TabIndex = 8;
            this.Track4.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.Track4.Value = 180;
            this.Track4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Track4_Scroll);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Z Axis";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Per1
            // 
            this.Per1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per1.Location = new System.Drawing.Point(620, 133);
            this.Per1.Name = "Per1";
            this.Per1.Size = new System.Drawing.Size(74, 30);
            this.Per1.TabIndex = 11;
            this.Per1.Text = "50°";
            this.Per1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumUpDown1
            // 
            this.NumUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.NumUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumUpDown1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumUpDown1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumUpDown1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumUpDown1.DisabledState.Parent = this.NumUpDown1;
            this.NumUpDown1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumUpDown1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumUpDown1.FocusedState.Parent = this.NumUpDown1;
            this.NumUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumUpDown1.Location = new System.Drawing.Point(423, 169);
            this.NumUpDown1.Name = "NumUpDown1";
            this.NumUpDown1.ShadowDecoration.Parent = this.NumUpDown1;
            this.NumUpDown1.Size = new System.Drawing.Size(80, 30);
            this.NumUpDown1.TabIndex = 16;
            this.NumUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.CheckedState.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.CustomImages.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.HoverState.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(325, 169);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.ShadowDecoration.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton2.TabIndex = 19;
            this.guna2GradientCircleButton2.Text = "-";
            this.guna2GradientCircleButton2.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton2.Click += new System.EventHandler(this.guna2GradientCircleButton2_Click);
            // 
            // guna2GradientCircleButton3
            // 
            this.guna2GradientCircleButton3.CheckedState.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.CustomImages.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton3.HoverState.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(571, 251);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.ShadowDecoration.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton3.TabIndex = 23;
            this.guna2GradientCircleButton3.Text = "+";
            this.guna2GradientCircleButton3.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton3.Click += new System.EventHandler(this.guna2GradientCircleButton3_Click);
            // 
            // guna2GradientCircleButton4
            // 
            this.guna2GradientCircleButton4.CheckedState.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.CustomImages.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton4.HoverState.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.Location = new System.Drawing.Point(325, 251);
            this.guna2GradientCircleButton4.Name = "guna2GradientCircleButton4";
            this.guna2GradientCircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton4.ShadowDecoration.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton4.TabIndex = 22;
            this.guna2GradientCircleButton4.Text = "-";
            this.guna2GradientCircleButton4.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton4.Click += new System.EventHandler(this.guna2GradientCircleButton4_Click);
            // 
            // NumUpDown2
            // 
            this.NumUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.NumUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumUpDown2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumUpDown2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumUpDown2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumUpDown2.DisabledState.Parent = this.NumUpDown2;
            this.NumUpDown2.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumUpDown2.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumUpDown2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumUpDown2.FocusedState.Parent = this.NumUpDown2;
            this.NumUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumUpDown2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumUpDown2.Location = new System.Drawing.Point(423, 251);
            this.NumUpDown2.Name = "NumUpDown2";
            this.NumUpDown2.ShadowDecoration.Parent = this.NumUpDown2;
            this.NumUpDown2.Size = new System.Drawing.Size(80, 30);
            this.NumUpDown2.TabIndex = 21;
            this.NumUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2GradientCircleButton5
            // 
            this.guna2GradientCircleButton5.CheckedState.Parent = this.guna2GradientCircleButton5;
            this.guna2GradientCircleButton5.CustomImages.Parent = this.guna2GradientCircleButton5;
            this.guna2GradientCircleButton5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton5.HoverState.Parent = this.guna2GradientCircleButton5;
            this.guna2GradientCircleButton5.Location = new System.Drawing.Point(571, 333);
            this.guna2GradientCircleButton5.Name = "guna2GradientCircleButton5";
            this.guna2GradientCircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton5.ShadowDecoration.Parent = this.guna2GradientCircleButton5;
            this.guna2GradientCircleButton5.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton5.TabIndex = 26;
            this.guna2GradientCircleButton5.Text = "+";
            this.guna2GradientCircleButton5.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton5.Click += new System.EventHandler(this.guna2GradientCircleButton5_Click);
            // 
            // guna2GradientCircleButton6
            // 
            this.guna2GradientCircleButton6.CheckedState.Parent = this.guna2GradientCircleButton6;
            this.guna2GradientCircleButton6.CustomImages.Parent = this.guna2GradientCircleButton6;
            this.guna2GradientCircleButton6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton6.HoverState.Parent = this.guna2GradientCircleButton6;
            this.guna2GradientCircleButton6.Location = new System.Drawing.Point(325, 333);
            this.guna2GradientCircleButton6.Name = "guna2GradientCircleButton6";
            this.guna2GradientCircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton6.ShadowDecoration.Parent = this.guna2GradientCircleButton6;
            this.guna2GradientCircleButton6.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton6.TabIndex = 25;
            this.guna2GradientCircleButton6.Text = "-";
            this.guna2GradientCircleButton6.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton6.Click += new System.EventHandler(this.guna2GradientCircleButton6_Click);
            // 
            // NumUpDown3
            // 
            this.NumUpDown3.BackColor = System.Drawing.Color.Transparent;
            this.NumUpDown3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumUpDown3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumUpDown3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumUpDown3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumUpDown3.DisabledState.Parent = this.NumUpDown3;
            this.NumUpDown3.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumUpDown3.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumUpDown3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumUpDown3.FocusedState.Parent = this.NumUpDown3;
            this.NumUpDown3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumUpDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumUpDown3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumUpDown3.Location = new System.Drawing.Point(423, 333);
            this.NumUpDown3.Name = "NumUpDown3";
            this.NumUpDown3.ShadowDecoration.Parent = this.NumUpDown3;
            this.NumUpDown3.Size = new System.Drawing.Size(80, 30);
            this.NumUpDown3.TabIndex = 24;
            this.NumUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2GradientCircleButton7
            // 
            this.guna2GradientCircleButton7.CheckedState.Parent = this.guna2GradientCircleButton7;
            this.guna2GradientCircleButton7.CustomImages.Parent = this.guna2GradientCircleButton7;
            this.guna2GradientCircleButton7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton7.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton7.HoverState.Parent = this.guna2GradientCircleButton7;
            this.guna2GradientCircleButton7.Location = new System.Drawing.Point(571, 415);
            this.guna2GradientCircleButton7.Name = "guna2GradientCircleButton7";
            this.guna2GradientCircleButton7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton7.ShadowDecoration.Parent = this.guna2GradientCircleButton7;
            this.guna2GradientCircleButton7.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton7.TabIndex = 29;
            this.guna2GradientCircleButton7.Text = "+";
            this.guna2GradientCircleButton7.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton7.Click += new System.EventHandler(this.guna2GradientCircleButton7_Click);
            // 
            // guna2GradientCircleButton8
            // 
            this.guna2GradientCircleButton8.CheckedState.Parent = this.guna2GradientCircleButton8;
            this.guna2GradientCircleButton8.CustomImages.Parent = this.guna2GradientCircleButton8;
            this.guna2GradientCircleButton8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton8.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton8.HoverState.Parent = this.guna2GradientCircleButton8;
            this.guna2GradientCircleButton8.Location = new System.Drawing.Point(325, 415);
            this.guna2GradientCircleButton8.Name = "guna2GradientCircleButton8";
            this.guna2GradientCircleButton8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton8.ShadowDecoration.Parent = this.guna2GradientCircleButton8;
            this.guna2GradientCircleButton8.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton8.TabIndex = 28;
            this.guna2GradientCircleButton8.Text = "-";
            this.guna2GradientCircleButton8.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton8.Click += new System.EventHandler(this.guna2GradientCircleButton8_Click);
            // 
            // NumUpDown4
            // 
            this.NumUpDown4.BackColor = System.Drawing.Color.Transparent;
            this.NumUpDown4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumUpDown4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumUpDown4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumUpDown4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumUpDown4.DisabledState.Parent = this.NumUpDown4;
            this.NumUpDown4.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumUpDown4.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumUpDown4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumUpDown4.FocusedState.Parent = this.NumUpDown4;
            this.NumUpDown4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumUpDown4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumUpDown4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumUpDown4.Location = new System.Drawing.Point(423, 415);
            this.NumUpDown4.Name = "NumUpDown4";
            this.NumUpDown4.ShadowDecoration.Parent = this.NumUpDown4;
            this.NumUpDown4.Size = new System.Drawing.Size(80, 30);
            this.NumUpDown4.TabIndex = 27;
            this.NumUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Per4
            // 
            this.Per4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per4.Location = new System.Drawing.Point(620, 379);
            this.Per4.Name = "Per4";
            this.Per4.Size = new System.Drawing.Size(74, 30);
            this.Per4.TabIndex = 30;
            this.Per4.Text = "50°";
            this.Per4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Per3
            // 
            this.Per3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per3.Location = new System.Drawing.Point(620, 297);
            this.Per3.Name = "Per3";
            this.Per3.Size = new System.Drawing.Size(74, 30);
            this.Per3.TabIndex = 31;
            this.Per3.Text = "50°";
            this.Per3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Per2
            // 
            this.Per2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per2.Location = new System.Drawing.Point(620, 215);
            this.Per2.Name = "Per2";
            this.Per2.Size = new System.Drawing.Size(74, 30);
            this.Per2.TabIndex = 32;
            this.Per2.Text = "50°";
            this.Per2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Per5
            // 
            this.Per5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per5.Location = new System.Drawing.Point(620, 464);
            this.Per5.Name = "Per5";
            this.Per5.Size = new System.Drawing.Size(74, 30);
            this.Per5.TabIndex = 35;
            this.Per5.Text = "50 %";
            this.Per5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Track5
            // 
            this.Track5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Track5.HoverState.Parent = this.Track5;
            this.Track5.IndicateFocus = false;
            this.Track5.Location = new System.Drawing.Point(314, 464);
            this.Track5.Name = "Track5";
            this.Track5.Size = new System.Drawing.Size(300, 30);
            this.Track5.TabIndex = 34;
            this.Track5.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.Track5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Track5_Scroll);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 33;
            this.label7.Text = "Gripper";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(325, 500);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(100, 30);
            this.guna2GradientButton1.TabIndex = 36;
            this.guna2GradientButton1.Text = "CLOSE";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(501, 500);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(100, 30);
            this.guna2GradientButton2.TabIndex = 37;
            this.guna2GradientButton2.Text = "OPEN";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(571, 169);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton1.TabIndex = 20;
            this.guna2GradientCircleButton1.Text = "+";
            this.guna2GradientCircleButton1.TextOffset = new System.Drawing.Point(1, -1);
            this.guna2GradientCircleButton1.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // Forward_Kinematics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 570);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.Per5);
            this.Controls.Add(this.Track5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Per2);
            this.Controls.Add(this.Per3);
            this.Controls.Add(this.Per4);
            this.Controls.Add(this.guna2GradientCircleButton7);
            this.Controls.Add(this.guna2GradientCircleButton8);
            this.Controls.Add(this.NumUpDown4);
            this.Controls.Add(this.guna2GradientCircleButton5);
            this.Controls.Add(this.guna2GradientCircleButton6);
            this.Controls.Add(this.NumUpDown3);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Controls.Add(this.guna2GradientCircleButton4);
            this.Controls.Add(this.NumUpDown2);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.NumUpDown1);
            this.Controls.Add(this.Per1);
            this.Controls.Add(this.Track4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Track3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Track2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Track1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forward_Kinematics";
            this.Text = "50";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TrackBar Track1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar Track4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TrackBar Track3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TrackBar Track2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumUpDown1;
        private System.Windows.Forms.Label Per1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private System.Windows.Forms.Label Per2;
        private System.Windows.Forms.Label Per3;
        private System.Windows.Forms.Label Per4;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton7;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton8;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumUpDown4;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton5;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton6;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumUpDown3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton4;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumUpDown2;
        private System.Windows.Forms.Label Per5;
        private Guna.UI2.WinForms.Guna2TrackBar Track5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
    }
}