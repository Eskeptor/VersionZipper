namespace VersionZiper
{
    partial class FormVerCreate
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
            this.tboxTargetPath = new MetroFramework.Controls.MetroTextBox();
            this.btnTargetPath = new MetroFramework.Controls.MetroButton();
            this.lblTitleTargetPath = new MetroFramework.Controls.MetroLabel();
            this.lblTitleCreatePath = new MetroFramework.Controls.MetroLabel();
            this.tboxCreatePath = new MetroFramework.Controls.MetroTextBox();
            this.btnCreatePath = new MetroFramework.Controls.MetroButton();
            this.lblTitleFileName = new MetroFramework.Controls.MetroLabel();
            this.tboxCreateFileName = new MetroFramework.Controls.MetroTextBox();
            this.btnZip = new MetroFramework.Controls.MetroButton();
            this.lblMark = new MetroFramework.Controls.MetroLabel();
            this.cboxLevel = new MetroFramework.Controls.MetroComboBox();
            this.cboxMethod = new MetroFramework.Controls.MetroComboBox();
            this.lblTitleLevel = new MetroFramework.Controls.MetroLabel();
            this.lblTitleMethod = new MetroFramework.Controls.MetroLabel();
            this.lblLevel = new MetroFramework.Controls.MetroLabel();
            this.lblMethod = new MetroFramework.Controls.MetroLabel();
            this.progCompress = new MetroFramework.Controls.MetroProgressSpinner();
            this.rBtnNameExNone = new MetroFramework.Controls.MetroRadioButton();
            this.rBtnNameExDate1 = new MetroFramework.Controls.MetroRadioButton();
            this.rBtnNameExDate2 = new MetroFramework.Controls.MetroRadioButton();
            this.tboxCreatedName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tboxTargetPath
            // 
            this.tboxTargetPath.Location = new System.Drawing.Point(90, 12);
            this.tboxTargetPath.Name = "tboxTargetPath";
            this.tboxTargetPath.ReadOnly = true;
            this.tboxTargetPath.Size = new System.Drawing.Size(491, 29);
            this.tboxTargetPath.TabIndex = 0;
            // 
            // btnTargetPath
            // 
            this.btnTargetPath.Location = new System.Drawing.Point(604, 12);
            this.btnTargetPath.Name = "btnTargetPath";
            this.btnTargetPath.Size = new System.Drawing.Size(137, 29);
            this.btnTargetPath.TabIndex = 1;
            this.btnTargetPath.Text = "찾아보기";
            this.btnTargetPath.Click += new System.EventHandler(this.BtnTargetPath_Click);
            // 
            // lblTitleTargetPath
            // 
            this.lblTitleTargetPath.AutoSize = true;
            this.lblTitleTargetPath.Location = new System.Drawing.Point(14, 17);
            this.lblTitleTargetPath.Name = "lblTitleTargetPath";
            this.lblTitleTargetPath.Size = new System.Drawing.Size(69, 19);
            this.lblTitleTargetPath.TabIndex = 99;
            this.lblTitleTargetPath.Text = "타겟 경로";
            // 
            // lblTitleCreatePath
            // 
            this.lblTitleCreatePath.AutoSize = true;
            this.lblTitleCreatePath.Location = new System.Drawing.Point(14, 59);
            this.lblTitleCreatePath.Name = "lblTitleCreatePath";
            this.lblTitleCreatePath.Size = new System.Drawing.Size(69, 19);
            this.lblTitleCreatePath.TabIndex = 99;
            this.lblTitleCreatePath.Text = "생성 경로";
            // 
            // tboxCreatePath
            // 
            this.tboxCreatePath.Location = new System.Drawing.Point(90, 54);
            this.tboxCreatePath.Name = "tboxCreatePath";
            this.tboxCreatePath.ReadOnly = true;
            this.tboxCreatePath.Size = new System.Drawing.Size(491, 29);
            this.tboxCreatePath.TabIndex = 2;
            // 
            // btnCreatePath
            // 
            this.btnCreatePath.Location = new System.Drawing.Point(604, 54);
            this.btnCreatePath.Name = "btnCreatePath";
            this.btnCreatePath.Size = new System.Drawing.Size(137, 29);
            this.btnCreatePath.TabIndex = 3;
            this.btnCreatePath.Text = "찾아보기";
            this.btnCreatePath.Click += new System.EventHandler(this.BtnCreatePath_Click);
            // 
            // lblTitleFileName
            // 
            this.lblTitleFileName.AutoSize = true;
            this.lblTitleFileName.Location = new System.Drawing.Point(14, 103);
            this.lblTitleFileName.Name = "lblTitleFileName";
            this.lblTitleFileName.Size = new System.Drawing.Size(51, 19);
            this.lblTitleFileName.TabIndex = 99;
            this.lblTitleFileName.Text = "파일명";
            // 
            // tboxCreateFileName
            // 
            this.tboxCreateFileName.Location = new System.Drawing.Point(90, 98);
            this.tboxCreateFileName.Name = "tboxCreateFileName";
            this.tboxCreateFileName.Size = new System.Drawing.Size(329, 29);
            this.tboxCreateFileName.TabIndex = 4;
            this.tboxCreateFileName.TextChanged += new System.EventHandler(this.TboxCreateFileName_TextChanged);
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(604, 139);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(137, 29);
            this.btnZip.TabIndex = 10;
            this.btnZip.Text = "압축하기";
            this.btnZip.Click += new System.EventHandler(this.BtnZip_Click);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(623, 332);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(118, 19);
            this.lblMark.TabIndex = 99;
            this.lblMark.Text = "Powered by LZMA";
            // 
            // cboxLevel
            // 
            this.cboxLevel.FormattingEnabled = true;
            this.cboxLevel.ItemHeight = 23;
            this.cboxLevel.Location = new System.Drawing.Point(90, 184);
            this.cboxLevel.Name = "cboxLevel";
            this.cboxLevel.Size = new System.Drawing.Size(160, 29);
            this.cboxLevel.TabIndex = 8;
            this.cboxLevel.SelectedIndexChanged += new System.EventHandler(this.CboxLevel_SelectedIndexChanged);
            // 
            // cboxMethod
            // 
            this.cboxMethod.FormattingEnabled = true;
            this.cboxMethod.ItemHeight = 23;
            this.cboxMethod.Location = new System.Drawing.Point(90, 232);
            this.cboxMethod.Name = "cboxMethod";
            this.cboxMethod.Size = new System.Drawing.Size(160, 29);
            this.cboxMethod.TabIndex = 9;
            this.cboxMethod.SelectedIndexChanged += new System.EventHandler(this.CboxMethod_SelectedIndexChanged);
            // 
            // lblTitleLevel
            // 
            this.lblTitleLevel.AutoSize = true;
            this.lblTitleLevel.Location = new System.Drawing.Point(14, 188);
            this.lblTitleLevel.Name = "lblTitleLevel";
            this.lblTitleLevel.Size = new System.Drawing.Size(69, 19);
            this.lblTitleLevel.TabIndex = 99;
            this.lblTitleLevel.Text = "압축 레벨";
            // 
            // lblTitleMethod
            // 
            this.lblTitleMethod.AutoSize = true;
            this.lblTitleMethod.Location = new System.Drawing.Point(14, 236);
            this.lblTitleMethod.Name = "lblTitleMethod";
            this.lblTitleMethod.Size = new System.Drawing.Size(69, 19);
            this.lblTitleMethod.TabIndex = 99;
            this.lblTitleMethod.Text = "압축 방식";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(257, 188);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(23, 19);
            this.lblLevel.TabIndex = 99;
            this.lblLevel.Text = "ㅇ";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(257, 237);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(23, 19);
            this.lblMethod.TabIndex = 99;
            this.lblMethod.Text = "ㅇ";
            // 
            // progCompress
            // 
            this.progCompress.Location = new System.Drawing.Point(569, 139);
            this.progCompress.Maximum = 100;
            this.progCompress.Name = "progCompress";
            this.progCompress.Size = new System.Drawing.Size(29, 29);
            this.progCompress.TabIndex = 99;
            // 
            // rBtnNameExNone
            // 
            this.rBtnNameExNone.AutoSize = true;
            this.rBtnNameExNone.Location = new System.Drawing.Point(90, 146);
            this.rBtnNameExNone.Name = "rBtnNameExNone";
            this.rBtnNameExNone.Size = new System.Drawing.Size(47, 15);
            this.rBtnNameExNone.TabIndex = 5;
            this.rBtnNameExNone.TabStop = true;
            this.rBtnNameExNone.Text = "없음";
            this.rBtnNameExNone.UseVisualStyleBackColor = true;
            this.rBtnNameExNone.CheckedChanged += new System.EventHandler(this.RBtnNameExNone_CheckedChanged);
            // 
            // rBtnNameExDate1
            // 
            this.rBtnNameExDate1.AutoSize = true;
            this.rBtnNameExDate1.Location = new System.Drawing.Point(170, 146);
            this.rBtnNameExDate1.Name = "rBtnNameExDate1";
            this.rBtnNameExDate1.Size = new System.Drawing.Size(91, 15);
            this.rBtnNameExDate1.TabIndex = 6;
            this.rBtnNameExDate1.TabStop = true;
            this.rBtnNameExDate1.Text = "날짜(년월일)";
            this.rBtnNameExDate1.UseVisualStyleBackColor = true;
            this.rBtnNameExDate1.CheckedChanged += new System.EventHandler(this.RBtnNameExDate1_CheckedChanged);
            // 
            // rBtnNameExDate2
            // 
            this.rBtnNameExDate2.AutoSize = true;
            this.rBtnNameExDate2.Location = new System.Drawing.Point(292, 146);
            this.rBtnNameExDate2.Name = "rBtnNameExDate2";
            this.rBtnNameExDate2.Size = new System.Drawing.Size(120, 15);
            this.rBtnNameExDate2.TabIndex = 7;
            this.rBtnNameExDate2.TabStop = true;
            this.rBtnNameExDate2.Text = "날짜(년월일_시분)";
            this.rBtnNameExDate2.UseVisualStyleBackColor = true;
            this.rBtnNameExDate2.CheckedChanged += new System.EventHandler(this.RBtnNameExDate2_CheckedChanged);
            // 
            // tboxCreatedName
            // 
            this.tboxCreatedName.Location = new System.Drawing.Point(425, 98);
            this.tboxCreatedName.Name = "tboxCreatedName";
            this.tboxCreatedName.ReadOnly = true;
            this.tboxCreatedName.Size = new System.Drawing.Size(316, 29);
            this.tboxCreatedName.TabIndex = 99;
            // 
            // FormVerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(753, 360);
            this.Controls.Add(this.tboxCreatedName);
            this.Controls.Add(this.rBtnNameExDate2);
            this.Controls.Add(this.rBtnNameExDate1);
            this.Controls.Add(this.rBtnNameExNone);
            this.Controls.Add(this.progCompress);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTitleMethod);
            this.Controls.Add(this.lblTitleLevel);
            this.Controls.Add(this.cboxMethod);
            this.Controls.Add(this.cboxLevel);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.tboxCreateFileName);
            this.Controls.Add(this.lblTitleFileName);
            this.Controls.Add(this.btnCreatePath);
            this.Controls.Add(this.tboxCreatePath);
            this.Controls.Add(this.lblTitleCreatePath);
            this.Controls.Add(this.lblTitleTargetPath);
            this.Controls.Add(this.btnTargetPath);
            this.Controls.Add(this.tboxTargetPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerCreate";
            this.Text = "FormVerCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tboxTargetPath;
        private MetroFramework.Controls.MetroButton btnTargetPath;
        private MetroFramework.Controls.MetroLabel lblTitleTargetPath;
        private MetroFramework.Controls.MetroLabel lblTitleCreatePath;
        private MetroFramework.Controls.MetroTextBox tboxCreatePath;
        private MetroFramework.Controls.MetroButton btnCreatePath;
        private MetroFramework.Controls.MetroLabel lblTitleFileName;
        private MetroFramework.Controls.MetroTextBox tboxCreateFileName;
        private MetroFramework.Controls.MetroButton btnZip;
        private MetroFramework.Controls.MetroLabel lblMark;
        private MetroFramework.Controls.MetroComboBox cboxLevel;
        private MetroFramework.Controls.MetroComboBox cboxMethod;
        private MetroFramework.Controls.MetroLabel lblTitleLevel;
        private MetroFramework.Controls.MetroLabel lblTitleMethod;
        private MetroFramework.Controls.MetroLabel lblLevel;
        private MetroFramework.Controls.MetroLabel lblMethod;
        private MetroFramework.Controls.MetroProgressSpinner progCompress;
        private MetroFramework.Controls.MetroRadioButton rBtnNameExNone;
        private MetroFramework.Controls.MetroRadioButton rBtnNameExDate1;
        private MetroFramework.Controls.MetroRadioButton rBtnNameExDate2;
        private MetroFramework.Controls.MetroTextBox tboxCreatedName;
    }
}