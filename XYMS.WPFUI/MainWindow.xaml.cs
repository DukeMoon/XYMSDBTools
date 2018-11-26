using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using XYMS.WPFControlLib.DataBaseSetting;

namespace XYMS.WPFUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region 命令实现
        private void OpenDataBaseSettingWindowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var dataBaseSettingWindow = new DataBaseSettingWindow();
            dataBaseSettingWindow.ShowDialog();
        }
        #endregion
        #region 私有方法
        /// <summary>
        /// 当前的控件
        /// </summary>
        private UserControl _nowControl;
        /// <summary>
        /// 加载用户控件
        /// </summary>
        /// <param name="userControl"></param>
        private void LoadUserControl(UserControl userControl)
        {
            if (_nowControl?.GetType().GUID == userControl.GetType().GUID) return;
            MainPanel.Children.Clear();
            userControl.VerticalAlignment = VerticalAlignment.Stretch;
            userControl.HorizontalAlignment = HorizontalAlignment.Stretch;
            MainPanel.Children.Add(userControl);
            _nowControl = userControl;
        }
        #endregion
    }
}
