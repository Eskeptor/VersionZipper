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
    enum PAGE
    {
        Main, VerCreate, Setting
    }

    public partial class FormMain : Form
    {
        public delegate void DelegateChangePage(int nPage);

        public event DelegateChangePage DelegatePage;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 다크 모드 활성화
        /// </summary>
        /// <param name="bSet">다크 모드 활성화 유무</param>
        public void SetDarkMode(bool bSet)
        {
            if (bSet)
            {
                BackColor = Color.FromArgb(17, 17, 17);
                tileZipper.Theme = MetroFramework.MetroThemeStyle.Dark;
                tileSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
                tileExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                BackColor = Color.White;
                tileZipper.Theme = MetroFramework.MetroThemeStyle.Light;
                tileSettings.Theme = MetroFramework.MetroThemeStyle.Light;
                tileExit.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void FormVerCreate_Load(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            DelegatePage((int)PAGE.VerCreate);
        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            DelegatePage((int)PAGE.Setting);
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
