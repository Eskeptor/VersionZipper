namespace VersionZiper
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new MetroFramework.Controls.MetroTabControl();
            this.mainTabMain = new MetroFramework.Controls.MetroTabPage();
            this.mainTabVerCreate = new MetroFramework.Controls.MetroTabPage();
            this.mainTabSettings = new MetroFramework.Controls.MetroTabPage();
            this.mainBack = new MetroFramework.Controls.MetroTile();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.mainTabMain);
            this.mainTab.Controls.Add(this.mainTabVerCreate);
            this.mainTab.Controls.Add(this.mainTabSettings);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.ItemSize = new System.Drawing.Size(10000, 1);
            this.mainTab.Location = new System.Drawing.Point(20, 60);
            this.mainTab.Multiline = true;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(754, 373);
            this.mainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTab.Style = MetroFramework.MetroColorStyle.White;
            this.mainTab.TabIndex = 0;
            // 
            // mainTabMain
            // 
            this.mainTabMain.HorizontalScrollbarBarColor = true;
            this.mainTabMain.Location = new System.Drawing.Point(4, 7);
            this.mainTabMain.Name = "mainTabMain";
            this.mainTabMain.Size = new System.Drawing.Size(746, 362);
            this.mainTabMain.TabIndex = 0;
            this.mainTabMain.Text = "metroTabPage1";
            this.mainTabMain.VerticalScrollbarBarColor = true;
            // 
            // mainTabVerCreate
            // 
            this.mainTabVerCreate.HorizontalScrollbarBarColor = true;
            this.mainTabVerCreate.Location = new System.Drawing.Point(4, 6);
            this.mainTabVerCreate.Name = "mainTabVerCreate";
            this.mainTabVerCreate.Size = new System.Drawing.Size(746, 363);
            this.mainTabVerCreate.TabIndex = 1;
            this.mainTabVerCreate.Text = "metroTabPage2";
            this.mainTabVerCreate.VerticalScrollbarBarColor = true;
            // 
            // mainTabSettings
            // 
            this.mainTabSettings.HorizontalScrollbarBarColor = true;
            this.mainTabSettings.Location = new System.Drawing.Point(4, 7);
            this.mainTabSettings.Name = "mainTabSettings";
            this.mainTabSettings.Size = new System.Drawing.Size(746, 362);
            this.mainTabSettings.TabIndex = 2;
            this.mainTabSettings.Text = "metroTabPage3";
            this.mainTabSettings.VerticalScrollbarBarColor = true;
            // 
            // mainBack
            // 
            this.mainBack.Location = new System.Drawing.Point(172, 25);
            this.mainBack.Name = "mainBack";
            this.mainBack.Size = new System.Drawing.Size(27, 27);
            this.mainBack.TabIndex = 1;
            this.mainBack.Text = "←";
            this.mainBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainBack.Click += new System.EventHandler(this.MainBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 453);
            this.Controls.Add(this.mainBack);
            this.Controls.Add(this.mainTab);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "VersionZipper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTab;
        private MetroFramework.Controls.MetroTabPage mainTabMain;
        private MetroFramework.Controls.MetroTabPage mainTabVerCreate;
        private MetroFramework.Controls.MetroTabPage mainTabSettings;
        private MetroFramework.Controls.MetroTile mainBack;
    }
}

