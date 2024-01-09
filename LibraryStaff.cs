using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libary
{
    public class LibraryStaff
    {
        // Уникальный идентификатор сотрудника библиотеки
        public int StaffId { get; set; }

        // Имя сотрудника
        public string Name { get; set; }

        // Должность сотрудника
        public string Position { get; set; }

        // Конструктор без параметров
        public LibraryStaff()
        {
            // Инициализация свойств по умолчанию
        }

        // Конструктор с параметрами для инициализации данных сотрудника
        public LibraryStaff(int staffId, string name, string position)
        {
            StaffId = staffId;
            Name = name;
            Position = position;
        }

        // Метод для добавления книги
        public void AddBook(Book book, List<Book> books)
        {
            books.Add(book);
        }

        // Метод для удаления книги
        public void RemoveBook(Book book, List<Book> books)
        {
            books.Remove(book);
        }

        // Метод для редактирования информации о книге
        public void EditBook(Book book, string newTitle, string newAuthor, string newEditionCode, string newDescription)
        {
            book.Title = newTitle;
            book.Author = newAuthor;
            book.EditionCode = newEditionCode;
            book.Description = newDescription;
        }

        // Метод для выдачи книги читателю
        public void LendBook(Book book, Reader reader)
        {
            if (book.IsAvailable)
            {
                book.CheckOut();
                reader.BorrowBook(book);
            }
        }

        // Метод для приема возвращенной книги от читателя
        public void ReceiveReturnedBook(Book book, Reader reader)
        {
            reader.ReturnBook(book);
            book.CheckIn();
        }

        // Другие методы, связанные с управлением библиотекой
    }

}
