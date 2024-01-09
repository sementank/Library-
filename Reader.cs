using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace libary
{
    public class Reader
    {
        // Идентификатор читателя, уникальный для каждого читателя
        public int ReaderId { get; set; }

        // Фамилия читателя
        public string LastName { get; set; }

        // Имя читателя
        public string FirstName { get; set; }

        // Отчество читателя
        public string MiddleName { get; set; }

        // Дата рождения читателя
        public DateTime DateOfBirth { get; set; }

        // Номер телефона читателя
        public string PhoneNumber { get; set; }

        // Список книг, которые в данный момент находятся у читателя
        public List<Book> BorrowedBooks { get; set; }

        // Список книг, которые читатель уже вернул
        public List<Book> ReturnedBooks { get; set; }

        // Конструктор без параметров
        public Reader()
        {
            // Инициализация списков книг при создании нового читателя
            BorrowedBooks = new List<Book>();
            ReturnedBooks = new List<Book>();
        }

        // Конструктор с параметрами для инициализации основных данных читателя
        public Reader(int readerId, string lastName, string firstName, string middleName, DateTime dateOfBirth, string phoneNumber)
        {
            ReaderId = readerId;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            BorrowedBooks = new List<Book>();
            ReturnedBooks = new List<Book>();
        }

        // Метод для добавления книги в список взятых
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        // Метод для перемещения книги из списка взятых в список возвращенных
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Remove(book))
            {
                ReturnedBooks.Add(book);
            }
        }

        // Метод для вывода информации о читателе
        public override string ToString()
        {
            return $"Читатель: {ReaderId}, {LastName} {FirstName} {MiddleName}, Дата рождения: {DateOfBirth.ToShortDateString()}, Телефон: {PhoneNumber}";
        }

        // Другие методы, связанные с управлением данными читателя, можно добавить здесь
    }

}