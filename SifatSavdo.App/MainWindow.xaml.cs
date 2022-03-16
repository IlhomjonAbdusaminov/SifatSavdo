using SifatSavdo.Domain.Models.Entities;
using System.Windows;
using System;
using SifatSavdo.Data.Repositories;
using System.Threading.Tasks;

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

        private void TasdiqlashBtnAsync(object sender, RoutedEventArgs e)
        {
            Client client = new Client()
            {
                FirstName = textBoxName.Text,
                LastName = textBoxName.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                CreatedAt = DateTime.Now,
            };

            ClientRepository clientRepository = new ClientRepository();

            clientRepository.Create(client);

            InProgress.Visibility = Visibility.Visible;

            mainTabControl.SelectedIndex = 0;
        }
    }
}
