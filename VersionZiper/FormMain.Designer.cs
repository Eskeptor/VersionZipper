namespace VersionZiper
{
    partial class FormMain
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
            this.tileZipper = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.tileExit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileZipper
            // 
            this.tileZipper.Location = new System.Drawing.Point(12, 12);
            this.tileZipper.Name = "tileZipper";
            this.tileZipper.Size = new System.Drawing.Size(356, 335);
            this.tileZipper.TabIndex = 0;
            this.tileZipper.Text = "Version Zipper";
            this.tileZipper.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileZipper.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileZipper.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // tileSettings
            // 
            this.tileSettings.Location = new System.Drawing.Point(374, 12);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(366, 156);
            this.tileSettings.TabIndex = 1;
            this.tileSettings.Text = "Settings";
            this.tileSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSettings.Click += new System.EventHandler(this.MetroTile2_Click);
            // 
            // tileExit
            // 
            this.tileExit.Location = new System.Drawing.Point(374, 174);
            this.tileExit.Name = "tileExit";
            this.tileExit.Size = new System.Drawing.Size(366, 173);
            this.tileExit.TabIndex = 2;
            this.tileExit.Text = "Exit";
            this.tileExit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileExit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileExit.Click += new System.EventHandler(this.MetroTile3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(753, 360);
            this.Controls.Add(this.tileExit);
            this.Controls.Add(this.tileSettings);
            this.Controls.Add(this.tileZipper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormVerCreate";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileZipper;
        private MetroFramework.Controls.MetroTile tileSettings;
        private MetroFramework.Controls.MetroTile tileExit;
    }
}