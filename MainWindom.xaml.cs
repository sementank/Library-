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
    /// Логика взаимодействия для MainWindom.xaml
    /// </summary>
    public partial class MainWindom : Window
    {
        public MainWindom()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private void btnReader_Click(object sender, RoutedEventArgs e)
        {
            // Создаем и отображаем форму читателя
            ReaderView readerView = new ReaderView();
            readerView.Show();
        }
        private void btnLibraryStaff_Click(object sender, RoutedEventArgs e)
        {
            // Создаем и отображаем форму сотрудника библиотеки
            LibraryStaffView libraryStaffView = new LibraryStaffView();
            libraryStaffView.Show();
        }

    }
}
