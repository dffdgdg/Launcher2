using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows;

namespace Launcher2.View
{
    public partial class MainPage : Page
    {
        public MainPage() => InitializeComponent();
        private void Button_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new View.OW());
        private void Button_Click_1(object sender, RoutedEventArgs e) => NavigationService.Navigate(new View.WOW());
    }
}