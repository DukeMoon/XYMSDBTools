using System.Windows;

namespace XYMS.WPFCommon
{
    public class ApplicationManager
    {
        /// <summary>
        /// 显示消息窗体
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="title">标题</param>
        public static void ShowMessageBox(string message, string title="提示")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /// <summary>
        /// 显示错误窗体
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="title">标题</param>
        public static void ShowErrorBox(string message, string title = "错误")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// 显示警告窗体
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="title">标题</param>
        public static void ShowWarningBox(string message, string title = "警告")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
