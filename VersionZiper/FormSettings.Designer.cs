namespace VersionZiper
{
    partial class FormSettings
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
            this.tgDarkMode = new MetroFramework.Controls.MetroToggle();
            this.lblTitleDarkMode = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tgDarkMode
            // 
            this.tgDarkMode.AutoSize = true;
            this.tgDarkMode.Location = new System.Drawing.Point(104, 25);
            this.tgDarkMode.Name = "tgDarkMode";
            this.tgDarkMode.Size = new System.Drawing.Size(80, 16);
            this.tgDarkMode.TabIndex = 0;
            this.tgDarkMode.Text = "Off";
            this.tgDarkMode.UseVisualStyleBackColor = true;
            this.tgDarkMode.CheckedChanged += new System.EventHandler(this.TgDarkMode_CheckedChanged);
            // 
            // lblTitleDarkMode
            // 
            this.lblTitleDarkMode.AutoSize = true;
            this.lblTitleDarkMode.Location = new System.Drawing.Point(22, 24);
            this.lblTitleDarkMode.Name = "lblTitleDarkMode";
            this.lblTitleDarkMode.Size = new System.Drawing.Size(69, 19);
            this.lblTitleDarkMode.TabIndex = 1;
            this.lblTitleDarkMode.Text = "다크 모드";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(753, 360);
            this.Controls.Add(this.lblTitleDarkMode);
            this.Controls.Add(this.tgDarkMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle tgDarkMode;
        private MetroFramework.Controls.MetroLabel lblTitleDarkMode;
    }
}