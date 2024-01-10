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
    /// Логика взаимодействия для AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            // Здесь код для добавления книги в систему

            MessageBox.Show("Книга добавлена успешно!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close(); // Закрыть окно после добавления книги
        }
    }
}
