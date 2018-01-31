namespace IAssist
{
    partial class FrmWelcome
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
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.Location = new System.Drawing.Point(92, 165);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(75, 23);
            this.BtnLaunch.TabIndex = 0;
            this.BtnLaunch.Text = "button1";
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.BtnLaunch);
            this.Name = "FrmWelcome";
            this.Text = "FrmWelcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLaunch;
    }
}