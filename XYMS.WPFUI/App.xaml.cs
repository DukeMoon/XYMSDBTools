using System.Windows;
using XYMS.Common;

namespace XYMS.WPFUI
{
    /// <inheritdoc />
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            XYMSHelper.RegisterCustomerService();
            XYMSHelper.BuildService();
        }
    }
}
