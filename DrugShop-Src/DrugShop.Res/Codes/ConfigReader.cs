using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DrugShop.Res
{
    class ConfigReader
    {
        #region 单例模型

        private static ConfigReader instance;
        private static readonly object _lock = new object();

        ConfigReader()
        {
            this.m_IniFile = new IniFile();
            this.m_IniFile.FilePath = FilePath;
        }

       public  static ConfigReader Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                            instance = new ConfigReader();
                    }
                }

                return instance;
            }
        }

        #endregion

        IniFile m_IniFile = new IniFile();
        string m_Section = "DrugShop";
        
        string FilePath
        {
            get
            {
                return Path.Combine(System.Windows.Forms.Application.StartupPath, "eas.client.ini");
            }
        }

        /// <summary>
        /// 写入Ini指定配置节指定配置键的值。
        /// </summary>
        /// <param name="key">键。</param>
        /// <param name="value">值。</param>
        public void Write(string key, string value)
        {
            this.m_IniFile.WriteValue(m_Section, key, value);
        }

        /// <summary>
        /// 读取Ini指定配置节指定配置键的值
        /// </summary>
        /// <param name="key">键。</param>
        /// <returns></returns>
        public string Read(string key)
        {
            return this.m_IniFile.ReadValue(m_Section, key);
        }
    }
}
