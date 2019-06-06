using Dennkind.Framework.DemoApp.UI.Pages;
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
        private static string _exIco01Res = $"{_ressources}exIco01.png";
        private static string _exIco02Res = $"{_ressources}exIco02.png";
        private static string _exIco03Res = $"{_ressources}exIco03.png";

        private ImageSource _exIco01;
        private ImageSource _exIco02;
        private ImageSource _exIco03;

        public MainWindow()
        {
            InitializeComponent();

            _exIco01 = new BitmapImage((new Uri(_exIco01Res, UriKind.Absolute)));
            _exIco02 = new BitmapImage((new Uri(_exIco02Res, UriKind.Absolute)));
            _exIco03 = new BitmapImage((new Uri(_exIco03Res, UriKind.Absolute)));
        }

        private void ApplicationFrameControl_Loaded(object sender, RoutedEventArgs e)
        {
            applicationFrameControl.AddPage(new Page1(), _exIco01);
            applicationFrameControl.AddPage(new Page2(), _exIco02);
            applicationFrameControl.AddPage(new Page3(), _exIco03);

            applicationFrameControl.DisplayPage("page1");
        }
    }
}
