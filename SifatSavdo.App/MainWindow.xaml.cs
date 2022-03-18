using SifatSavdo.Domain.Models.Entities;
using System.Windows;
using System;
using SifatSavdo.Data.Repositories;
using System.Threading.Tasks;
using SifatSavdo.Service.Services;
using SifatSavdo.Service.ViewModels;

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
            if (textBoxName.Text != null && textBoxPassword != null)
            {
                ClientService clientService = new ClientService();
                ClientViewModel model = new ClientViewModel()
                {
                    FirstName = textBoxName.Text,
                    LastName = textBoxSurname.Text,
                    PhoneNumber = textBoxPhoneNumber.Text,
                    Login = textBoxLogin.Text,
                    Password = textBoxPassword.Text
                };

                clientService.CreateAsync(model).Wait();

                InProgress.Visibility = Visibility.Visible;

                mainTabControl.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Null ma'lumotlar!");
            }

        }
    }
}
