using System.Windows;
using System.Windows.Input;

namespace XYMS.WPFControlLib.DataBaseSetting
{
    /// <summary>
    /// DataBaseSettingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataBaseSettingWindow : Window
    {
        public DataBaseSettingWindow()
        {
            InitializeComponent();
        }

        private void CloseWindowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void TestConnectionCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void TestConnectionCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void SaveConfigCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void SaveConfigCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
