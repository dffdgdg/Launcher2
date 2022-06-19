using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Launcher2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainWindow.WindowState == WindowState.Maximized) this.MainWindow.WindowState = WindowState.Normal;
            else this.MainWindow.WindowState = WindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.MainWindow.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
