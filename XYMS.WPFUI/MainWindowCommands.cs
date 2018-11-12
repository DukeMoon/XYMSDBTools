using System.Windows.Input;

namespace XYMS.WPFUI
{
    public static class MainWindowCommands
    {
        /// <summary>
        /// 打开数据库设置窗体
        /// </summary>
        public static RoutedUICommand OpenDataBaseSettingWindow { get; }
        /// <summary>
        /// 构造方法
        /// </summary>
        static MainWindowCommands()
        {
            OpenDataBaseSettingWindow = new RoutedUICommand(
                "数据库配置",
                nameof(OpenDataBaseSettingWindow),
                typeof(MainWindowCommands));
        }
    }
}
