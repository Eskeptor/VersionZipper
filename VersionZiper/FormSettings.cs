using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionZiper
{
    public partial class FormSettings : Form
    {
        public delegate void DelegateChangeTheme(bool bSet);

        public event DelegateChangeTheme DelegateTheme;

        public FormSettings()
        {
            InitializeComponent();
            InitControls();
        }

        public void InitControls()
        {
            int nTheme;

            if (string.IsNullOrEmpty(AppConfigMgr.GetAppConfig(Program.APP_KEY_PROGRAM_THEME)) == false)
                nTheme = int.Parse(AppConfigMgr.GetAppConfig(Program.APP_KEY_PROGRAM_THEME));
            else
                nTheme = 0;

            if (nTheme == (int)ThemeMode.Light)
                tgDarkMode.Checked = false;
            else
                tgDarkMode.Checked = true;
        }

        public void SetDarkMode(bool bSet)
        {
            if (bSet)
            {
                BackColor = Color.FromArgb(17, 17, 17);

                lblTitleDarkMode.Theme = MetroFramework.MetroThemeStyle.Dark;
                tgDarkMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                BackColor = Color.White;

                lblTitleDarkMode.Theme = MetroFramework.MetroThemeStyle.Light;
                tgDarkMode.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void TgDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (tgDarkMode.Checked)
            {
                if (DelegateTheme != null)
                    DelegateTheme(true);
            }
            else
            {
                if (DelegateTheme != null)
                    DelegateTheme(false);
            }
        }
    }
}
