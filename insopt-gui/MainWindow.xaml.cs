using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace WinCust
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            if (Directory.Exists(@"C:\Program Files\wincust"))
            {
                install.IsEnabled = false;
                reinstall.IsEnabled = true;
                uninstall.IsEnabled = true;
            }
            else
            {
                install.IsEnabled = true;
                reinstall.IsEnabled = false;
                uninstall.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\wincust\insopt\installerwincust.bat");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\wincust\insopt\reinstallwincust.bat");
        }

        private void uninstall_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\wincust\insopt\uninstallwincust.bat");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
