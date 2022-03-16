using SifatSavdo.App.Pages;
using System.Windows;

namespace SifatSavdo.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpBtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tayyor emas");
        }

        private void SignInBtn(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new SignIn();
        }

        private void AboutUsBtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tayyor emas");
        }
    }
}
