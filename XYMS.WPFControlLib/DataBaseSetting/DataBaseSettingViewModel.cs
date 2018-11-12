using Materal.DBHelper;
using Materal.StringHelper;
using Materal.WPFCommon;
using System;
using XYMS.Common;
using XYMS.Common.Model;

namespace XYMS.WPFControlLib.DataBaseSetting
{
    public class DataBaseSettingViewModel : NotifyPropertyChanged
    {
        private DataBaseConfigModel _dbConfig;

        /// <summary>
        /// 数据库配置
        /// </summary>
        public DataBaseConfigModel DBConfig
        {
            get => _dbConfig;
            set
            {
                _dbConfig = value;
                OnPropertyChanged(nameof(DBConfig));
            }
        }
        /// <summary>
        /// 是否可以测试
        /// </summary>
        public bool IsTest => DBConfig != null &&
                              !string.IsNullOrEmpty(DBConfig.Account) && 
                              !string.IsNullOrEmpty(DBConfig.AuthName) && 
                              !string.IsNullOrEmpty(DBConfig.CharacterName) && 
                              !string.IsNullOrEmpty(DBConfig.IP) &&
                              DBConfig.IP.IsIPv4() &&
                              !string.IsNullOrEmpty(DBConfig.Password) && 
                              !string.IsNullOrEmpty(DBConfig.Port) &&
                              DBConfig.Port.IsIntegerPositive() &&
                              !string.IsNullOrEmpty(DBConfig.WorldName);
        /// <summary>
        /// 测试结果
        /// </summary>
        public bool TestResult { get; set; }
        /// <summary>
        /// 连接测试成功
        /// </summary>
        public event Action<string> OnConnectionTestSuccess;
        /// <summary>
        /// 连接测试失败
        /// </summary>
        public event Action<string> OnConnectionTestFail;
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            DBConfig = ApplicationConfig.DataBaseConfig;
        }
        /// <summary>
        /// 连接测试
        /// </summary>
        public void ConnectionTest()
        {
            var mySqlHelper = new MySqlHelper();
            bool authTestResult = mySqlHelper.ConnectionTest(DBConfig.AuthConnectionString);
            bool characterTestResult = mySqlHelper.ConnectionTest(DBConfig.CharacterConnectionString);
            bool worldTestResult = mySqlHelper.ConnectionTest(DBConfig.WorldConnectionString);
            TestResult = authTestResult && characterTestResult && worldTestResult;
            if (TestResult)
            {
                OnConnectionTestSuccess?.Invoke("数据库连接成功");
            }
            else
            {
                if (!authTestResult) OnConnectionTestFail?.Invoke("账户数据库连接失败");
                if (!characterTestResult) OnConnectionTestFail?.Invoke("角色数据库连接失败");
                if (!worldTestResult) OnConnectionTestFail?.Invoke("世界数据库连接失败");
            }
        }
        /// <summary>
        /// 保存配置
        /// </summary>
        public void SaveConfig()
        {
            DBConfig.SaveConfig();
        }
    }
}
