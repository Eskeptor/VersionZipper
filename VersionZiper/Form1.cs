using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace VersionZiper
{
    public partial class Form1 : MetroForm
    {
        private FormMain m_fromMain = null;
        private FormVerCreate m_formVerCreate = null;
        private FormSettings m_formSettings = null;

        public Form1()
        {
            InitializeComponent();
            InitControls();
            ThemeChanger();
        }

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls()
        {
            SetTabPage();
            SetButton();

            mainTab.SelectedTab = mainTabMain;
        }

        /// <summary>
        /// App.Config를 읽어서 테마를 적용
        /// </summary>
        private void ThemeChanger()
        {
            int nTheme;

            if (string.IsNullOrEmpty(AppConfigMgr.GetAppConfig(Program.APP_KEY_PROGRAM_THEME)) == false)
                nTheme = int.Parse(AppConfigMgr.GetAppConfig(Program.APP_KEY_PROGRAM_THEME));
            else
                nTheme = 0;

            if (nTheme == (int)ThemeMode.Light)     // 라이트 모드
            {
                SetDarkMode(false);
                m_fromMain.SetDarkMode(false);
                m_formVerCreate.SetDarkMode(false);
                m_formSettings.SetDarkMode(false);
            }
            else                                    // 다크 모드
            {
                SetDarkMode(true);
                m_fromMain.SetDarkMode(true);
                m_formVerCreate.SetDarkMode(true);
                m_formSettings.SetDarkMode(true);
            }
        }

        private void ThemeChanger(bool bSet)
        {
            if (bSet == false)     // 라이트 모드
            {
                SetDarkMode(false);
                m_fromMain.SetDarkMode(false);
                m_formVerCreate.SetDarkMode(false);
                m_formSettings.SetDarkMode(false);

                AppConfigMgr.SetAppConfig(Program.APP_KEY_PROGRAM_THEME, 0);
            }
            else                                    // 다크 모드
            {
                SetDarkMode(true);
                m_fromMain.SetDarkMode(true);
                m_formVerCreate.SetDarkMode(true);
                m_formSettings.SetDarkMode(true);

                AppConfigMgr.SetAppConfig(Program.APP_KEY_PROGRAM_THEME, 1);
            }
        }

        /// <summary>
        /// 다크 모드 활성화
        /// </summary>
        /// <param name="bSet">다크 모드 활성화 유무</param>
        public void SetDarkMode(bool bSet)
        {
            if (bSet)
            {
                Theme = MetroFramework.MetroThemeStyle.Dark;

                mainBack.Theme = MetroFramework.MetroThemeStyle.Dark;
                mainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
                mainTab.Style = MetroFramework.MetroColorStyle.Black;
                mainTabMain.Theme = MetroFramework.MetroThemeStyle.Dark;
                mainTabVerCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
                mainTabSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                Theme = MetroFramework.MetroThemeStyle.Light;

                mainBack.Theme = MetroFramework.MetroThemeStyle.Light;
                mainTab.Theme = MetroFramework.MetroThemeStyle.Light;
                mainTab.Style = MetroFramework.MetroColorStyle.White;
                mainTabMain.Theme = MetroFramework.MetroThemeStyle.Light;
                mainTabVerCreate.Theme = MetroFramework.MetroThemeStyle.Light;
                mainTabSettings.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        /// <summary>
        /// 탭 페이지 설정
        /// </summary>
        private void SetTabPage()
        {
            m_fromMain = new FormMain();
            m_fromMain.TopLevel = false;
            m_fromMain.TopMost = true;
            m_fromMain.DelegatePage += new FormMain.DelegateChangePage(ChangePage);
            mainTabMain.Controls.Clear();
            mainTabMain.Controls.Add(m_fromMain);
            m_fromMain.Location = new Point(0, 0);
            m_fromMain.Show();

            m_formVerCreate = new FormVerCreate();
            m_formVerCreate.TopLevel = false;
            m_formVerCreate.TopMost = true;
            mainTabVerCreate.Controls.Clear();
            mainTabVerCreate.Controls.Add(m_formVerCreate);
            m_formVerCreate.Location = new Point(0, 0);
            m_formVerCreate.Show();

            m_formSettings = new FormSettings();
            m_formSettings.TopLevel = false;
            m_formSettings.TopMost = true;
            m_formSettings.DelegateTheme += new FormSettings.DelegateChangeTheme(ThemeChanger);
            mainTabSettings.Controls.Clear();
            mainTabSettings.Controls.Add(m_formSettings);
            m_formSettings.Location = new Point(0, 0);
            m_formSettings.Show();
        }

        /// <summary>
        /// 버튼 셋팅
        /// </summary>
        private void SetButton()
        {
            mainBack.Hide();
        }

        /// <summary>
        /// 탭페이지 변경
        /// </summary>
        /// <param name="nPage">변경할 페이지</param>
        private void ChangePage(int nPage)
        {
            switch (nPage)
            {
                case (int)PAGE.Main:
                    mainTab.SelectedTab = mainTabMain;
                    mainBack.Hide();
                    break;
                case (int)PAGE.Setting:
                    mainTab.SelectedTab = mainTabSettings;
                    mainBack.Show();
                    break;
                case (int)PAGE.VerCreate:
                    mainTab.SelectedTab = mainTabVerCreate;
                    mainBack.Show();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 뒤로가기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBack_Click(object sender, EventArgs e)
        {
            ChangePage((int)PAGE.Main);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_formVerCreate.FormClose();
        }
    }
}
