using System;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[0].Source = new Uri("Styles/Dark.xaml", UriKind.Relative);
            Button1.Content = "OK";
        }

        private void BrightModeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[0].Source = new Uri("Styles/Bright.xaml", UriKind.Relative);
        }
    }
}
