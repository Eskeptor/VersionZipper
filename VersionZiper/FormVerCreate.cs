using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZip;
using System.Threading;

namespace VersionZiper
{
    //https://stackoverflow.com/questions/43468496/fast-compression-with-sevenzipsharp
    public partial class FormVerCreate : Form
    {
        private Thread m_thZip = null;

        public FormVerCreate()
        {
            InitializeComponent();

            InitControls();
        }

        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls()
        {
            string[] arrStrLevel = { "None", "Fast", "Low", "Normal", "High", "Ultra" };    // 압축 레벨
            string[] arrStrMethod = { "LZMA", "LZMA2", "PPMd", "BZip2" };                   // 압축 방식

            cboxLevel.Items.AddRange(arrStrLevel);              // 압축 레벨에 아이템 등록
            cboxMethod.Items.AddRange(arrStrMethod);            // 압축 방식에 아이템 등록

            lblLevel.Text = "";                                 // 압축 레벨 설명 초기화
            lblMethod.Text = "";                                // 압축 방식 설명 초기화

            progCompress.Visible = false;                       // 압축 진행바 초기화 (안보이기)

            // =====================================================================================================
            // App.config 파일 불러오기
            tboxTargetPath.Text = AppConfigMgr.GetAppConfig(Program.APP_KEY_TARGET_PATH);           // 타겟 경로
            tboxCreatePath.Text = AppConfigMgr.GetAppConfig(Program.APP_KEY_CREATE_PATH);           // 생성 경로
            tboxCreateFileName.Text = AppConfigMgr.GetAppConfig(Program.APP_KEY_CREATE_FILE_NAME);  // 파일명

            // 압축 레벨
            if (string.IsNullOrEmpty(AppConfigMgr.GetAppConfig(Program.APP_KEY_COMPRESS_LEVEL)) == false)
                cboxLevel.SelectedIndex = int.Parse(AppConfigMgr.GetAppConfig(Program.APP_KEY_COMPRESS_LEVEL));
            else
                cboxLevel.SelectedIndex = 0;

            // 압축 방식
            if (string.IsNullOrEmpty(AppConfigMgr.GetAppConfig(Program.APP_KEY_COMPRESS_METHOD)) == false)
                cboxMethod.SelectedIndex = int.Parse(AppConfigMgr.GetAppConfig(Program.APP_KEY_COMPRESS_METHOD));
            else
                cboxMethod.SelectedIndex = 0;

            // 파일명 추가적 기능
            if (string.IsNullOrEmpty(AppConfigMgr.GetAppConfig(Program.APP_KEY_CREATE_FILE_NAME_EX)) == false)
            {
                FileNameEx eNameEx = (FileNameEx)Enum.ToObject(typeof(FileNameEx), int.Parse(AppConfigMgr.GetAppConfig(Program.APP_KEY_CREATE_FILE_NAME_EX)));

                switch (eNameEx)
                {
                    case FileNameEx.None:
                        rBtnNameExNone.Checked = true;
                        tboxCreatedName.Text = tboxCreateFileName.Text + ".zip";
                        break;
                    case FileNameEx.Date_YMD:
                        rBtnNameExDate1.Checked = true;
                        tboxCreatedName.Text = tboxCreateFileName.Text + "_" + DateTime.Now.ToString("yyyyMMdd") + ".7z";
                        break;
                    case FileNameEx.Date_YMD_HM:
                        rBtnNameExDate2.Checked = true;
                        tboxCreatedName.Text = tboxCreateFileName.Text + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".7z";
                        break;
                    default:
                        rBtnNameExNone.Checked = true;
                        tboxCreatedName.Text = tboxCreateFileName.Text + ".zip";
                        break;
                }
            }
            else
            {
                rBtnNameExNone.Checked = true;
            }
            // =====================================================================================================
        }

        /// <summary>
        /// 다크 모드 활성화
        /// </summary>
        /// <param name="bSet">다크 모드 활성화 유무</param>
        public void SetDarkMode(bool bSet)
        {
            if (bSet)       // 다크 모드
            {
                BackColor = Color.FromArgb(17, 17, 17);

                lblTitleTargetPath.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblTitleCreatePath.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblTitleFileName.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblTitleLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblTitleMethod.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblMethod.Theme = MetroFramework.MetroThemeStyle.Dark;
                lblMark.Theme = MetroFramework.MetroThemeStyle.Dark;

                tboxTargetPath.Theme = MetroFramework.MetroThemeStyle.Dark;
                tboxCreatePath.Theme = MetroFramework.MetroThemeStyle.Dark;
                tboxCreateFileName.Theme = MetroFramework.MetroThemeStyle.Dark;
                tboxCreatedName.Theme = MetroFramework.MetroThemeStyle.Dark;

                rBtnNameExNone.Theme = MetroFramework.MetroThemeStyle.Dark;
                rBtnNameExDate1.Theme = MetroFramework.MetroThemeStyle.Dark;
                rBtnNameExDate2.Theme = MetroFramework.MetroThemeStyle.Dark;

                cboxLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
                cboxMethod.Theme = MetroFramework.MetroThemeStyle.Dark;

                progCompress.Theme = MetroFramework.MetroThemeStyle.Dark;

                btnTargetPath.Theme = MetroFramework.MetroThemeStyle.Dark;
                btnCreatePath.Theme = MetroFramework.MetroThemeStyle.Dark;
                btnZip.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else            // 라이트 모드
            {
                BackColor = Color.White;

                lblTitleTargetPath.Theme = MetroFramework.MetroThemeStyle.Light;
                lblTitleCreatePath.Theme = MetroFramework.MetroThemeStyle.Light;
                lblTitleFileName.Theme = MetroFramework.MetroThemeStyle.Light;
                lblTitleLevel.Theme = MetroFramework.MetroThemeStyle.Light;
                lblTitleMethod.Theme = MetroFramework.MetroThemeStyle.Light;
                lblLevel.Theme = MetroFramework.MetroThemeStyle.Light;
                lblMethod.Theme = MetroFramework.MetroThemeStyle.Light;
                lblMark.Theme = MetroFramework.MetroThemeStyle.Light;

                tboxTargetPath.Theme = MetroFramework.MetroThemeStyle.Light;
                tboxCreatePath.Theme = MetroFramework.MetroThemeStyle.Light;
                tboxCreateFileName.Theme = MetroFramework.MetroThemeStyle.Light;
                tboxCreatedName.Theme = MetroFramework.MetroThemeStyle.Light;

                rBtnNameExNone.Theme = MetroFramework.MetroThemeStyle.Light;
                rBtnNameExDate1.Theme = MetroFramework.MetroThemeStyle.Light;
                rBtnNameExDate2.Theme = MetroFramework.MetroThemeStyle.Light;

                cboxLevel.Theme = MetroFramework.MetroThemeStyle.Light;
                cboxMethod.Theme = MetroFramework.MetroThemeStyle.Light;

                progCompress.Theme = MetroFramework.MetroThemeStyle.Light;

                btnTargetPath.Theme = MetroFramework.MetroThemeStyle.Light;
                btnCreatePath.Theme = MetroFramework.MetroThemeStyle.Light;
                btnZip.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        /// <summary>
        /// 압축할 타겟 폴더
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTargetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            string selectedFolder = folderBrowserDialog.SelectedPath;

            if (string.IsNullOrEmpty(selectedFolder) == false)
                tboxTargetPath.Text = selectedFolder;
        }

        /// <summary>
        /// 압축한 파일이 저장될 경로
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreatePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            string selectedFolder = folderBrowserDialog.SelectedPath;

            if (string.IsNullOrEmpty(selectedFolder) == false)
                tboxCreatePath.Text = selectedFolder;
        }


        /// <summary>
        /// 압축 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnZip_Click(object sender, EventArgs e)
        {
            // 타겟 경로 체크
            if (string.IsNullOrEmpty(tboxTargetPath.Text))
            {
                MessageBox.Show("타겟 경로를 선택하세요.");
                return;
            }

            // 생성 경로 체크
            if (string.IsNullOrEmpty(tboxCreatePath.Text))
            {
                MessageBox.Show("생성 경로를 선택하세요.");
                return;
            }

            // 파일명 체크
            if (string.IsNullOrEmpty(tboxCreateFileName.Text))
            {
                MessageBox.Show("파일명을 입력하세요.");
                return;
            }

            // 압축 레벨 체크
            if (cboxLevel.SelectedIndex == -1)
            {
                MessageBox.Show("압축 레벨을 선택하세요.");
                return;
            }

            // 압축 방식 체크
            if (cboxMethod.SelectedIndex == -1)
            {
                MessageBox.Show("압축 방식을 선택하세요.");
                return;
            }

            if (m_thZip == null)
            {
                string strTargetPath = tboxTargetPath.Text;
                string strCreatePath = tboxCreatePath.Text;
                string strCreateFileName = tboxCreatedName.Text;
                int nLevel = cboxLevel.SelectedIndex;
                int nMethod = cboxMethod.SelectedIndex;

                btnZip.Enabled = false;
                progCompress.Visible = true;

                m_thZip = new Thread(() => ThreadZipFunc(strTargetPath, strCreatePath, strCreateFileName, nLevel, nMethod));
                m_thZip.Start();
            }
        }

        /// <summary>
        /// 압축하는 기능
        /// </summary>
        /// <param name="strTargetFolder">타겟 폴더 경로</param>
        /// <param name="strCreateFolder">생성 위치 폴더 경로</param>
        /// <param name="strCreateFileName">생성 파일명</param>
        /// <param name="eLevel">압축 레벨</param>
        /// <param name="eMethod">압축 방식</param>
        /// <returns>성공 유무</returns>
        private bool CompressFileLZMA(string strTargetFolder, string strCreateFolder, string strCreateFileName, CompressionLevel eLevel, CompressionMethod eMethod)
        {
            bool bResult;

            try
            {
                Progress<byte> hProgress = new Progress<byte>(percentDont => {
                    if (progCompress.InvokeRequired)
                    {
                        progCompress.Invoke(new MethodInvoker(delegate ()
                        {
                            progCompress.Value = percentDont;
                        }));
                    }
                    else
                        progCompress.Value = percentDont;
                });
                IProgress<byte> iProgress = hProgress as IProgress<byte>;

                string strPath;
                if (IntPtr.Size == 8)
                    strPath = Application.StartupPath + @"\7z64.dll";
                else
                    strPath = Application.StartupPath + @"\7z.dll";
                //string strFileName = strCreateFileName + ".7z";
                SevenZipCompressor.SetLibraryPath(strPath);
                SevenZipCompressor sevenZipCompressor = new SevenZipCompressor();
                sevenZipCompressor.Compressing += (sender, args) =>
                {
                    iProgress.Report(args.PercentDone);
                };
                sevenZipCompressor.CompressionFinished += (sender, args) =>
                {
                    if (progCompress.InvokeRequired)
                    {
                        progCompress.Invoke(new MethodInvoker(delegate
                        {
                            progCompress.Visible = false;
                        }));
                    }
                    else
                        progCompress.Visible = false;

                    if (btnZip.InvokeRequired)
                    {
                        btnZip.Invoke(new MethodInvoker(delegate
                        {
                            btnZip.Enabled = true;
                        }));
                    }
                    else
                        btnZip.Enabled = true;
                };
                sevenZipCompressor.CompressionLevel = eLevel;
                sevenZipCompressor.CompressionMethod = eMethod;
                // Compress the directory and save the file in a yyyyMMdd_project-files.7z format (eg. 20141024_project-files.7z
                sevenZipCompressor.CompressDirectory(strTargetFolder, Path.Combine(strCreateFolder, strCreateFileName));
                bResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                bResult = false;
            }

            return bResult;
        }


        /// <summary>
        /// 압축 레벨 선택 체인지
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompressionLevel eLevel = (CompressionLevel)Enum.ToObject(typeof(CompressionLevel), cboxLevel.SelectedIndex);

            switch (eLevel)
            {
                case CompressionLevel.None:
                    lblLevel.Text = "압축하지 않음(일반 저장)";
                    break;
                case CompressionLevel.Fast:
                    lblLevel.Text = "매우 낮은 압축률(가장 빠름)";
                    break;
                case CompressionLevel.Low:
                    lblLevel.Text = "낮은 압축률(빠름)";
                    break;
                case CompressionLevel.Normal:
                    lblLevel.Text = "일반 압축률(보통)";
                    break;
                case CompressionLevel.High:
                    lblLevel.Text = "높은 압축률(느림)";
                    break;
                case CompressionLevel.Ultra:
                    lblLevel.Text = "매우 높은 압축률(매우 느림)";
                    break;
                default:
                    lblLevel.Text = "압축 레벨을 선택하세요.";
                    break;
            }
        }


        /// <summary>
        /// 압축 방식 선택 체인지
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nSelected = cboxMethod.SelectedIndex;

            switch (nSelected)
            {
                case 0:         // LZMA
                    lblMethod.Text = "LZMA method based on Lempel-Ziv algorithm\nit is default for 7-zip.";
                    break;
                case 1:         // LZMA2
                    lblMethod.Text = "LZMA version 2\nLZMA with improved multithreading and usually slight archive size decrease.";
                    break;
                case 2:         // PPMd
                    lblMethod.Text = "PPMd method based on Dmitry Shkarin's PPMdH source code\nvery efficient for compressing texts.";
                    break;
                case 3:         // BZip2
                    lblMethod.Text = "Bzip2 method.";
                    break;
                default:
                    break;
            }
        }

        
        private void ThreadZipFunc(string strTargetPath, string strCreatePath, string strCreateFileName, int nLevel, int nMethod)
        {
            CompressionLevel eLevel = (CompressionLevel)Enum.ToObject(typeof(CompressionLevel), nLevel);
            CompressionMethod eMethod = CompressionMethod.Lzma;
            switch (nMethod)
            {
                case 0:     // LZMA
                    eMethod = CompressionMethod.Lzma;
                    break;
                case 1:     // LZMA2
                    eMethod = CompressionMethod.Lzma2;
                    break;
                case 2:     // PPMd
                    eMethod = CompressionMethod.Ppmd;
                    break;
                case 3:     // BZip2
                    eMethod = CompressionMethod.BZip2;
                    break;
                default:
                    break;
            }

            // LZMA 압축
            bool bResult = CompressFileLZMA(strTargetPath, strCreatePath, strCreateFileName, eLevel, eMethod);

            m_thZip = null;
        }


        public void FormClose()
        {
            if (m_thZip != null)
            {
                m_thZip.Join();
            }

            // =============================================================================================================
            // App.config 파일 저장

            AppConfigMgr.SetAppConfig(Program.APP_KEY_TARGET_PATH, tboxTargetPath.Text);                        // 타겟 경로
            AppConfigMgr.SetAppConfig(Program.APP_KEY_CREATE_PATH, tboxCreatePath.Text);                        // 생성 경로
            AppConfigMgr.SetAppConfig(Program.APP_KEY_CREATE_FILE_NAME, tboxCreateFileName.Text);               // 파일명
            AppConfigMgr.SetAppConfig(Program.APP_KEY_COMPRESS_LEVEL, cboxLevel.SelectedIndex.ToString());      // 압축 레벨
            AppConfigMgr.SetAppConfig(Program.APP_KEY_COMPRESS_METHOD, cboxMethod.SelectedIndex.ToString());    // 압축 방식

            // 파일명 추가적 기능
            if (rBtnNameExNone.Checked)
                AppConfigMgr.SetAppConfig(Program.APP_KEY_CREATE_FILE_NAME_EX, (int)FileNameEx.None);
            else if (rBtnNameExDate1.Checked)
                AppConfigMgr.SetAppConfig(Program.APP_KEY_CREATE_FILE_NAME_EX, (int)FileNameEx.Date_YMD);
            else if (rBtnNameExDate2.Checked)
                AppConfigMgr.SetAppConfig(Program.APP_KEY_CREATE_FILE_NAME_EX, (int)FileNameEx.Date_YMD_HM);
            else
                AppConfigMgr.SetAppConfig(Program.APP_KEY_CREATE_FILE_NAME_EX, (int)FileNameEx.None);
            // =============================================================================================================
        }


        private void TboxCreateFileName_TextChanged(object sender, EventArgs e)
        {
            if (rBtnNameExNone.Checked)
                tboxCreatedName.Text = tboxCreateFileName.Text + ".zip";
            else if (rBtnNameExDate1.Checked)
                tboxCreatedName.Text = tboxCreateFileName.Text + "_" + DateTime.Now.ToString("yyyyMMdd") + ".7z";
            else if (rBtnNameExDate2.Checked)
                tboxCreatedName.Text = tboxCreateFileName.Text + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".7z";
        }


        private void RBtnNameExNone_CheckedChanged(object sender, EventArgs e)
        {
            tboxCreatedName.Text = tboxCreateFileName.Text + ".zip";
        }

        private void RBtnNameExDate1_CheckedChanged(object sender, EventArgs e)
        {
            tboxCreatedName.Text = tboxCreateFileName.Text + "_" + DateTime.Now.ToString("yyyyMMdd") + ".7z";
        }

        private void RBtnNameExDate2_CheckedChanged(object sender, EventArgs e)
        {
            tboxCreatedName.Text = tboxCreateFileName.Text + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".7z";
        }
    }
}
