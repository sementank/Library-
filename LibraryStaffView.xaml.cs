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
    /// Логика взаимодействия для LibraryStaffView.xaml
    /// </summary>
    public partial class LibraryStaffView : Window
    {
        public LibraryStaffView()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            // Инициализация списка книг и привязка к ListView
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            // Логика для добавления новой книги
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            // Логика для удаления выбранной книги
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            // Логика для редактирования выбранной книги
        }

        private void LendBook_Click(object sender, RoutedEventArgs e)
        {
            // Логика для выдачи книги читателю
        }

        private void ReceiveBook_Click(object sender, RoutedEventArgs e)
        {
            // Логика для приема книги от читателя
            // Проверка наличия заявок на книгу и отображение уведомления
        }

    }
}
