using System;
using System.Configuration;

namespace XYMS.Common.Model
{
    /// <summary>
    /// 数据库配置模型
    /// </summary>
    public class DataBaseConfigModel
    {
        /// <summary>
        /// 配置对象
        /// </summary>
        private static DataBaseConfigModel _dataBaseConfigModel;
        /// <summary>
        /// 获得配置
        /// </summary>
        /// <returns></returns>
        public static DataBaseConfigModel GetDataBaseConfig()
        {
            return _dataBaseConfigModel ?? (_dataBaseConfigModel = new DataBaseConfigModel());
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        private DataBaseConfigModel()
        {
            Reload();
        }
        /// <summary>
        /// IP地址
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string Port { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 账号数据库名称
        /// </summary>
        public string AuthName { get; set; }
        /// <summary>
        /// 角色数据库名称
        /// </summary>
        public string CharacterName { get; set; }
        /// <summary>
        /// 世界数据库名称
        /// </summary>
        public string WorldName { get; set; }
        /// <summary>
        /// 账号连接字符串
        /// </summary>
        /// <returns></returns>
        public string AuthConnectionString => $"Server={IP};Port={Port};Database={AuthName};Uid={Account};Pwd={Password};";
        /// <summary>
        /// 角色连接字符串
        /// </summary>
        /// <returns></returns>
        public string CharacterConnectionString => $"Server={IP};Port={Port};Database={CharacterName};Uid={Account};Pwd={Password};";
        /// <summary>
        /// 世界连接字符串
        /// </summary>
        /// <returns></returns>
        public string WorldConnectionString => $"Server={IP};Port={Port};Database={WorldName};Uid={Account};Pwd={Password};";
        /// <summary>
        /// 账户配置名称
        /// </summary>
        private const string AccoutnConfigName = "DataBaseAccount";
        /// <summary>
        /// 账号配置名称
        /// </summary>
        private const string AuthConfigName = "DataBaseAuth";
        /// <summary>
        /// 角色配置名称
        /// </summary>
        private const string CharactersConfigName = "DataBaseCharacters";
        /// <summary>
        /// IP配置名称
        /// </summary>
        private const string IPConfigName = "DataBaseIP";
        /// <summary>
        /// 密码配置名称
        /// </summary>
        private const string PasswordConfigName = "DataBasePassword";
        /// <summary>
        /// 端口号配置名称
        /// </summary>
        private const string PortConfigName = "DataBasePort";
        /// <summary>
        /// 世界配置名称
        /// </summary>
        private const string WorldConfigName = "DataBaseWorld";
        /// <summary>
        /// 保存配置
        /// </summary>
        public void SaveConfig()
        {
            ConfigurationManager.AppSettings.Set(AccoutnConfigName, Account);
            ConfigurationManager.AppSettings.Set(AuthConfigName, AuthName);
            ConfigurationManager.AppSettings.Set(CharactersConfigName, CharacterName);
            ConfigurationManager.AppSettings.Set(IPConfigName, IP);
            ConfigurationManager.AppSettings.Set(PasswordConfigName, Password);
            ConfigurationManager.AppSettings.Set(PortConfigName, Port);
            ConfigurationManager.AppSettings.Set(WorldConfigName, WorldName);
            Reload();
        }
        /// <summary>
        /// 重新加载
        /// </summary>
        public void Reload()
        {
            Account = ConfigurationManager.AppSettings[AccoutnConfigName];
            AuthName = ConfigurationManager.AppSettings[AuthConfigName];
            CharacterName = ConfigurationManager.AppSettings[CharactersConfigName];
            IP = ConfigurationManager.AppSettings[IPConfigName];
            Password = ConfigurationManager.AppSettings[PasswordConfigName];
            Port = ConfigurationManager.AppSettings[PortConfigName];
            WorldName = ConfigurationManager.AppSettings[WorldConfigName];
        }
    }
}
