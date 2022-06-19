using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Input;
using Launcher2.View;
using System.Windows;
using System;

namespace Launcher2
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void MainMenu_Click(object sender, RoutedEventArgs e) => mf.NavigationService.Navigate(new MainPage());
        private void OWB_Click(object sender, RoutedEventArgs e) => mf.NavigationService.Navigate(new OW());
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
        private void WOWB_Click(object sender, RoutedEventArgs e) => mf.Navigate(new WOW());

        private void mf_Navigated(object sender, NavigationEventArgs e)
        {
            if (mf.Content.ToString() == "Launcher2.View.OW")
            {
                OWB.IsChecked = true;
                Backg.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Resources/OVBack.png"));
            }
            else if (mf.Content.ToString() == "Launcher2.View.WOW")
            {
                WOWB.IsChecked = true;
                Backg.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Resources/WOWBack.png"));
            }
            else
            {
                MainMenu.IsChecked = true;
                Backg.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Resources/Menu.png"));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((bool)LogoButton.IsChecked) Menu1.Visibility = Visibility.Visible;
            else Menu1.Visibility = Visibility.Collapsed;
        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if ((bool)Opg.IsChecked) { Grids.Width = 300; ChatsAndGroups.Width = 203; }
            else { Grids.Width = 175; ChatsAndGroups.Width = 40; }
        }
    }
}
