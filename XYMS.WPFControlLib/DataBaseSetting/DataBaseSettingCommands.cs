using System.Windows.Input;

namespace XYMS.WPFControlLib.DataBaseSetting
{
    public static class DataBaseSettingCommands
    {
        /// <summary>
        /// 关闭窗体
        /// </summary>
        public static RoutedUICommand CloseWindow { get; }
        /// <summary>
        /// 测试链接
        /// </summary>
        public static RoutedUICommand TestConnection { get; }
        /// <summary>
        /// 保存配置
        /// </summary>
        public static RoutedUICommand SaveConfig { get; }
        /// <summary>
        /// 构造方法
        /// </summary>
        static DataBaseSettingCommands()
        {
            CloseWindow = new RoutedUICommand(
                "关闭窗体",
                nameof(CloseWindow),
                typeof(DataBaseSettingCommands));
            TestConnection = new RoutedUICommand(
                "测试链接",
                nameof(TestConnection),
                typeof(DataBaseSettingCommands));
            SaveConfig = new RoutedUICommand(
                "summary",
                nameof(SaveConfig),
                typeof(DataBaseSettingCommands));
        }
    }
}
