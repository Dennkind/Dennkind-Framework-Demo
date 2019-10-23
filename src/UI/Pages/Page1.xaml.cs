using System.Windows.Controls;

namespace Dennkind.Framework.DemoApp.UI.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void FadeOutHeaderButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Header.FadeOut();
        }

        private void FadeInHeaderButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Header.FadeIn();
        }

        private void FadeOutNavigationButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Navigation.FadeOut();
        }

        private void FadeInNavigationButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Navigation.FadeIn();
        }

        private void CollapseNavigationButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Navigation.Collapse();
        }

        private void ExpandNavigationButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Navigation.Expand();
        }

        private void FadeOutFooterButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Footer.FadeOut();
        }

        private void FadeInFooterButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.MainWindow.ApplicationFrameControl.Footer.FadeIn();
        }
    }
}