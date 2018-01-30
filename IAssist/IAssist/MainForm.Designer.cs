namespace IAssist
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SldrRed = new System.Windows.Forms.TrackBar();
            this.LblRed = new System.Windows.Forms.Label();
            this.LblGreen = new System.Windows.Forms.Label();
            this.SldrGreen = new System.Windows.Forms.TrackBar();
            this.LblBlue = new System.Windows.Forms.Label();
            this.SldrBlue = new System.Windows.Forms.TrackBar();
            this.LblRedAmount = new System.Windows.Forms.Label();
            this.LblGreenAmount = new System.Windows.Forms.Label();
            this.LblBlueAmount = new System.Windows.Forms.Label();
            this.BtnSetColourTemperature = new System.Windows.Forms.Button();
            this.BtnResetColourTemperature = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tryIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SldrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SldrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SldrBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // SldrRed
            // 
            this.SldrRed.Location = new System.Drawing.Point(57, 9);
            this.SldrRed.Maximum = 255;
            this.SldrRed.Minimum = 1;
            this.SldrRed.Name = "SldrRed";
            this.SldrRed.Size = new System.Drawing.Size(248, 45);
            this.SldrRed.TabIndex = 4;
            this.SldrRed.Value = 1;
            this.SldrRed.ValueChanged += new System.EventHandler(this.SldrRed_ValueChanged);
            // 
            // LblRed
            // 
            this.LblRed.AutoSize = true;
            this.LblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRed.Location = new System.Drawing.Point(23, 9);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(43, 20);
            this.LblRed.TabIndex = 5;
            this.LblRed.Text = "Red:";
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreen.Location = new System.Drawing.Point(8, 42);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(58, 20);
            this.LblGreen.TabIndex = 7;
            this.LblGreen.Text = "Green:";
            // 
            // SldrGreen
            // 
            this.SldrGreen.Location = new System.Drawing.Point(57, 42);
            this.SldrGreen.Maximum = 255;
            this.SldrGreen.Minimum = 1;
            this.SldrGreen.Name = "SldrGreen";
            this.SldrGreen.Size = new System.Drawing.Size(248, 45);
            this.SldrGreen.TabIndex = 6;
            this.SldrGreen.Value = 1;
            this.SldrGreen.ValueChanged += new System.EventHandler(this.SldrGreen_ValueChanged);
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBlue.Location = new System.Drawing.Point(21, 78);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(45, 20);
            this.LblBlue.TabIndex = 9;
            this.LblBlue.Text = "Blue:";
            // 
            // SldrBlue
            // 
            this.SldrBlue.Location = new System.Drawing.Point(57, 78);
            this.SldrBlue.Maximum = 255;
            this.SldrBlue.Minimum = 1;
            this.SldrBlue.Name = "SldrBlue";
            this.SldrBlue.Size = new System.Drawing.Size(248, 45);
            this.SldrBlue.TabIndex = 8;
            this.SldrBlue.Value = 1;
            this.SldrBlue.ValueChanged += new System.EventHandler(this.SldrBlue_ValueChanged);
            // 
            // LblRedAmount
            // 
            this.LblRedAmount.AutoSize = true;
            this.LblRedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRedAmount.Location = new System.Drawing.Point(302, 9);
            this.LblRedAmount.Name = "LblRedAmount";
            this.LblRedAmount.Size = new System.Drawing.Size(36, 20);
            this.LblRedAmount.TabIndex = 10;
            this.LblRedAmount.Text = "255";
            // 
            // LblGreenAmount
            // 
            this.LblGreenAmount.AutoSize = true;
            this.LblGreenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreenAmount.Location = new System.Drawing.Point(302, 42);
            this.LblGreenAmount.Name = "LblGreenAmount";
            this.LblGreenAmount.Size = new System.Drawing.Size(36, 20);
            this.LblGreenAmount.TabIndex = 11;
            this.LblGreenAmount.Text = "255";
            // 
            // LblBlueAmount
            // 
            this.LblBlueAmount.AutoSize = true;
            this.LblBlueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBlueAmount.Location = new System.Drawing.Point(302, 78);
            this.LblBlueAmount.Name = "LblBlueAmount";
            this.LblBlueAmount.Size = new System.Drawing.Size(36, 20);
            this.LblBlueAmount.TabIndex = 12;
            this.LblBlueAmount.Text = "255";
            // 
            // BtnSetColourTemperature
            // 
            this.BtnSetColourTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetColourTemperature.Location = new System.Drawing.Point(8, 114);
            this.BtnSetColourTemperature.Name = "BtnSetColourTemperature";
            this.BtnSetColourTemperature.Size = new System.Drawing.Size(165, 29);
            this.BtnSetColourTemperature.TabIndex = 13;
            this.BtnSetColourTemperature.Text = "Set";
            this.BtnSetColourTemperature.UseVisualStyleBackColor = true;
            this.BtnSetColourTemperature.Click += new System.EventHandler(this.BtnSetColourTemperature_Click);
            // 
            // BtnResetColourTemperature
            // 
            this.BtnResetColourTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetColourTemperature.Location = new System.Drawing.Point(179, 114);
            this.BtnResetColourTemperature.Name = "BtnResetColourTemperature";
            this.BtnResetColourTemperature.Size = new System.Drawing.Size(165, 29);
            this.BtnResetColourTemperature.TabIndex = 14;
            this.BtnResetColourTemperature.Text = "Reset";
            this.BtnResetColourTemperature.UseVisualStyleBackColor = true;
            this.BtnResetColourTemperature.Click += new System.EventHandler(this.BtnResetColourTemperature_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Light Blue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClickLightBlue);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(179, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Turquoise";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClickTurquoise);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(8, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Green";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClickGreen);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(179, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "Light Yellow";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClickLightYellow);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(8, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 28);
            this.button5.TabIndex = 19;
            this.button5.Text = "Yellow";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClickYellow);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumPurple;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(179, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 28);
            this.button6.TabIndex = 20;
            this.button6.Text = "Purple";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClickPurple);
            // 
            // tryIcon
            // 
            this.tryIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("tryIcon.Icon")));
            this.tryIcon.Tag = "IAssist";
            this.tryIcon.Text = "notifyIcon";
            this.tryIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tryIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 252);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnResetColourTemperature);
            this.Controls.Add(this.BtnSetColourTemperature);
            this.Controls.Add(this.LblBlueAmount);
            this.Controls.Add(this.LblGreenAmount);
            this.Controls.Add(this.LblRedAmount);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.SldrBlue);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.SldrGreen);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.SldrRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IAssist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SldrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SldrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SldrBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar SldrRed;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.TrackBar SldrGreen;
        private System.Windows.Forms.Label LblBlue;
        private System.Windows.Forms.TrackBar SldrBlue;
        private System.Windows.Forms.Label LblRedAmount;
        private System.Windows.Forms.Label LblGreenAmount;
        private System.Windows.Forms.Label LblBlueAmount;
        private System.Windows.Forms.Button BtnSetColourTemperature;
        private System.Windows.Forms.Button BtnResetColourTemperature;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NotifyIcon tryIcon;
    }
}

