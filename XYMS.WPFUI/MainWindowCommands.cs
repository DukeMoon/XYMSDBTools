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
        /// 切换关于控件
        /// </summary>
        public static RoutedUICommand SwitchAboutControl { get; }
        /// <summary>
        /// 构造方法
        /// </summary>
        static MainWindowCommands()
        {
            OpenDataBaseSettingWindow = new RoutedUICommand(
                "数据库配置",
                nameof(OpenDataBaseSettingWindow),
                typeof(MainWindowCommands));
            SwitchAboutControl = new RoutedUICommand(
                "关于",
                nameof(SwitchAboutControl),
                typeof(MainWindowCommands));
        }
    }
}
