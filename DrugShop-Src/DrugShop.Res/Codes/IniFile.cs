using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DrugShop.Res
{
    /// <summary>
    /// Ini文件读写类。
    /// </summary>
    class IniFile
    {
        #region API

        class API
        {
            /// <summary>
            /// 写Ini文件。
            /// </summary>
            /// <param name="section"></param>
            /// <param name="key"></param>
            /// <param name="val"></param>
            /// <param name="filePath"></param>
            /// <returns></returns>
            [DllImport("kernel32")]
            public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            /// <summary>
            /// 读Ini文件。
            /// </summary>
            /// <param name="section"></param>
            /// <param name="key"></param>
            /// <param name="def"></param>
            /// <param name="retVal"></param>
            /// <param name="size"></param>
            /// <param name="filePath"></param>
            /// <returns></returns>
            [DllImport("kernel32")]
            public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        }

        #endregion

        private string path = string.Empty;

        internal IniFile()
        {
        }

        internal IniFile(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// 路径。
        /// </summary>
        internal string FilePath
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        /// <summary>
        /// 写入Ini指定配置节指定配置键的值。
        /// </summary>
        /// <param name="section">节。</param>
        /// <param name="key">键。</param>
        /// <param name="value">值。</param>
        internal void WriteValue(string section, string key, string value)
        {
            API.WritePrivateProfileString(section, key, value, this.path);
        }

        /// <summary>
        /// 读取Ini指定配置节指定配置键的值
        /// </summary>
        /// <param name="section">节。</param>
        /// <param name="key">键。</param>
        /// <returns></returns>
        internal string ReadValue(string section, string key)
        {
            StringBuilder dataBuffer = new StringBuilder(1024 * 10);
            int i = API.GetPrivateProfileString(section, key, string.Empty, dataBuffer, 1024 * 10, this.path);
            return dataBuffer.ToString();
        }
    }
}
