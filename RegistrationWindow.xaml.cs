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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Здесь должна быть логика регистрации читателя
            // Например, проверка введенных данных и их сохранение

            // Предположим, что данные введены верно и сохранение прошло успешно
            MessageBox.Show("Читатель зарегистрирован", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close(); // Закрываем окно регистрации
        }
    }
}
