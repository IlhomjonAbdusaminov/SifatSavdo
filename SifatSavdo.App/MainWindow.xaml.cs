using SifatSavdo.App.Pages;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
            InProgress.Visibility = Visibility.Hidden;
            mainTabControl.SelectedIndex = 1;
        }

        private void SignInBtn(object sender, RoutedEventArgs e)
        {
            
        }

        private void AboutUsBtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tayyor emas");
        }

        private void TasdiqlashBtn(object sender, RoutedEventArgs e)
        {
            

            InProgress.Visibility = Visibility.Visible;

            mainTabControl.SelectedIndex = 0;
        }
    }
}
