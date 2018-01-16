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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 155);
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
    }
}

