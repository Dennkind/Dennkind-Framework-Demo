using Dennkind.Framework.DemoApp.UI.Pages;
using Dennkind.Framework.WPF.Controls;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dennkind.Framework.DemoApp.UI.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string _ressources = "pack://application:,,,/Dennkind.Framework.DemoApp;component/Resources/";
        private static string _exIco01Res = $"{_ressources}homeIcon001_24x24.png";
        private static string _exIco02Res = $"{_ressources}userIcon001_24x24.png";
        private static string _exIco03Res = $"{_ressources}configIcon001_24x24.png";

        private ImageSource _homeIconImage;
        private ImageSource _userIconImage;
        private ImageSource _conigIconImage;

        public ApplicationFrameControl ApplicationFrameControl
        {
            get { return applicationFrameControl; }
        }

        public MainWindow()
        {
            InitializeComponent();

            _homeIconImage = new BitmapImage((new Uri(_exIco01Res, UriKind.Absolute)));
            _userIconImage = new BitmapImage((new Uri(_exIco02Res, UriKind.Absolute)));
            _conigIconImage = new BitmapImage((new Uri(_exIco03Res, UriKind.Absolute)));
        }

        private void ApplicationFrameControl_Loaded(object sender, RoutedEventArgs e)
        {
            applicationFrameControl.Navigation.IsCollapsed = false;

            applicationFrameControl.AddPage(new Page1(), _homeIconImage);
            applicationFrameControl.AddPage(new Page2(), _userIconImage);
            applicationFrameControl.AddPage(new Page3(), _conigIconImage);

            applicationFrameControl.DisplayPage("page1");
        }
    }
}
