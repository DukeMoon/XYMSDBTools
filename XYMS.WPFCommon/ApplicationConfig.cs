using System.Configuration;
using XYMS.WPFCommon.Model;

namespace XYMS.WPFCommon
{
    /// <summary>
    /// 应用程序配置对象
    /// </summary>
    public static class ApplicationConfig
    {
        /// <summary>
        /// 数据库配置
        /// </summary>
        public static DataBaseConfigModel DataBaseConfig { get; }

        /// <summary>
        /// 构造方法
        /// </summary>
        static ApplicationConfig()
        {
            DataBaseConfig = DataBaseConfigModel.GetDataBaseConfig();
        }
    }
}
