using System.Windows;
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

        private void OpenDataBaseSettingWindowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var dataBaseSettingWindow = new DataBaseSettingWindow();
            dataBaseSettingWindow.ShowDialog();
        }

        private void OpenDataBaseSettingWindowCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
