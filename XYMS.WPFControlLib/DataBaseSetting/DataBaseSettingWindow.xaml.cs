using System.Windows;
using System.Windows.Input;
using XYMS.WPFCommon;

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
            ApplicationManager.ShowMessageBox("保存成功", "保存结果");
            CloseWindowCommand_Executed(sender, e);
        }

        private void SaveConfigCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ViewModel.IsTest && ViewModel.TestResult;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.OnConnectionTestSuccess += ViewModel_OnConnectionTestSuccess;
            ViewModel.OnConnectionTestFail += ViewModel_OnConnectionTestFail;
            ViewModel.Init();
        }

        private void ViewModel_OnConnectionTestFail(string message)
        {
            ApplicationManager.ShowErrorBox(message);
        }

        private void ViewModel_OnConnectionTestSuccess(string message)
        {
            ApplicationManager.ShowMessageBox(message);
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ViewModel.TestResult = false;
        }
    }
}
