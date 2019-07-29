using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionZiper
{
    static class Program
    {
        public const string APP_KEY_TARGET_PATH = "TargetPath";
        public const string APP_KEY_CREATE_PATH = "CreatePath";
        public const string APP_KEY_CREATE_FILE_NAME = "CreateFileName";
        public const string APP_KEY_COMPRESS_LEVEL = "CompressLevel";
        public const string APP_KEY_COMPRESS_METHOD = "CompressMethod";
        public const string APP_KEY_CREATE_FILE_NAME_EX = "CreateFileNameEx";
        public const string APP_KEY_PROGRAM_THEME = "ProgramTheme";

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    enum FileNameEx
    {
       None, Date_YMD, Date_YMD_HM
    }

    enum ThemeMode
    {
        Light, Dark
    }
}
