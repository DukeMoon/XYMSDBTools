using Materal.ConvertHelper;
using XYMS.WPFCommon;
using XYMS.WPFCommon.Model;

namespace XYMS.WPFControlLib.DataBaseSetting
{
    public class DataBaseSettingViewModel
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public DataBaseSettingViewModel()
        {
            DBConfig = ApplicationConfig.DataBaseConfig.Clone();
        }

        /// <summary>
        /// 数据库配置
        /// </summary>
        public DataBaseConfigModel DBConfig { get; set; }
    }
}
