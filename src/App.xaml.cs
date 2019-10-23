using Dennkind.Framework.DemoApp.UI.Windows;
using System.Windows;

namespace Dennkind.Framework.DemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static MainWindow MainWindow { get; private set; }

        public App()
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}
