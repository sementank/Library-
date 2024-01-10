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
using System.Windows.Shapes;

namespace libary
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Допустим, у нас есть простая проверка учетных данных 
            string username = txtUsername.Text;
            string password = pwdPassword.Password;
            string role = ((ComboBoxItem)cmbRole.SelectedItem)?.Content as string;

            if (password == "")
            {
                if (role == "Читатель")
                {
                    // Логика для входа читателя
                    ReaderView readerView = new ReaderView();
                    readerView.Show();
                }
                else if (role == "Сотрудник библиотеки")
                {
                    // Логика для входа сотрудника библиотеки
                    LibraryStaffView libraryStaffView = new LibraryStaffView();
                    libraryStaffView.Show();
                }
                this.Close(); // Закрыть окно входа после успешного входа
            }
            else
            {
                MessageBox.Show("Неверный пароль или имя пользователя", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            // Открытие окна регистрации
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }

    }
}
