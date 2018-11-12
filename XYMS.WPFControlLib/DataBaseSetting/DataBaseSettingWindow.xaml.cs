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
            ViewModel.ConnectionTest();
        }

        private void TestConnectionCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ViewModel.IsTest;
        }

        private void SaveConfigCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ViewModel.SaveConfig();
            MessageBox.Show("保存成功", "保存配置");
            CloseWindowCommand_Executed(sender, e);
        }

        private void SaveConfigCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ViewModel.IsTest && ViewModel.TestResult;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.OnMessage += ViewModel_OnMessage;
            ViewModel.Init();
        }

        private void ViewModel_OnMessage(string message)
        {
            MessageBox.Show(message, "提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ViewModel.TestResult = false;
        }
    }
}
