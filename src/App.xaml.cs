using Dennkind.Framework.DemoApp.UI.Windows;
using System.Windows;

namespace Dennkind.Framework.DemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            new MainWindow().Show();
        }
    }
}
