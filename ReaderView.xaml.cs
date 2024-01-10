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
    /// Логика взаимодействия для ReaderView.xaml
    /// </summary>
    public partial class ReaderView : Window
    {
        public ReaderView()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            LoadBooksData();
            LoadReaderInfo();
            txtSearch.TextChanged += TxtSearch_TextChanged; // Подписываемся на событие изменения текста
            UpdatePlaceholderVisibility();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePlaceholderVisibility();
        }

        private void UpdatePlaceholderVisibility()
        {
            txtPlaceholder.Visibility = string.IsNullOrEmpty(txtSearch.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void LoadBooksData()
        {
            // Загрузить и отобразить список книг в DataGrid

        }

        private void LoadReaderInfo()
        {
            // Загрузить и отобразить информацию о читателе
 
        }

        private void SearchBooks_Click(object sender, RoutedEventArgs e)
        {
            // Логика поиска книг

        }

        // Методы для кнопок управления книгами
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
        }
    }
}
