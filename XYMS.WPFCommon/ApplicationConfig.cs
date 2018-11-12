using System.Configuration;
using XYMS.WPFCommon.Model;

namespace XYMS.WPFCommon
{
    /// <summary>
    /// 应用程序配置对象
    /// </summary>
    public static class ApplicationConfig
    {
        private static DataBaseConfigModel _dataBaseConfig;

        /// <summary>
        /// 数据库配置
        /// </summary>
        public static DataBaseConfigModel DataBaseConfig => _dataBaseConfig;

        /// <summary>
        /// 构造方法
        /// </summary>
        static ApplicationConfig()
        {
            Reload();
        }
        /// <summary>
        /// 重新加载
        /// </summary>
        public static void Reload()
        {
            ReloadDataBaseConfig();
        }
        /// <summary>
        /// 重新加载数据库配置
        /// </summary>
        public static void ReloadDataBaseConfig()
        {
            if (_dataBaseConfig == null) _dataBaseConfig = new DataBaseConfigModel();
            _dataBaseConfig.Account = ConfigurationManager.AppSettings["DataBaseAccount"];
            _dataBaseConfig.AuthName = ConfigurationManager.AppSettings["DataBaseAuth"];
            _dataBaseConfig.CharacterName = ConfigurationManager.AppSettings["DataBaseCharacters"];
            _dataBaseConfig.IP = ConfigurationManager.AppSettings["DataBaseIP"];
            _dataBaseConfig.Password = ConfigurationManager.AppSettings["DataBasePassword"];
            _dataBaseConfig.Port = ConfigurationManager.AppSettings["DataBasePort"];
            _dataBaseConfig.WorldName = ConfigurationManager.AppSettings["DataBaseWorld"];
        }
    }
}
