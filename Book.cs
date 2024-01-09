using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace libary
{
    public class Book
    {
        // Уникальный идентификатор книги
        public int BookId { get; set; }

        // Название книги
        public string Title { get; set; }

        // Автор книги
        public string Author { get; set; }

        // Код издания книги
        public string EditionCode { get; set; }

        // Описание книги
        public string Description { get; set; }

        // Флаг, показывающий, доступна ли книга для выдачи (не находится ли она у кого-то на руках)
        public bool IsAvailable { get; set; }

        // Конструктор без параметров
        public Book()
        {
            // Инициализация свойств по умолчанию
            IsAvailable = true; // По умолчанию книга доступна
        }

        // Конструктор с параметрами для инициализации основных данных книги
        public Book(int bookId, string title, string author, string editionCode, string description)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            EditionCode = editionCode;
            Description = description;
            IsAvailable = true; // По умолчанию книга доступна
        }

        // Метод для установки статуса книги как "выдана"
        public void CheckOut()
        {
            IsAvailable = false;
        }

        // Метод для установки статуса книги как "возвращена"
        public void CheckIn()
        {
            IsAvailable = true;
        }

        // Метод для вывода информации о книге
        public override string ToString()
        {
            return $"Книга: {Title}, Автор: {Author}, Код издания: {EditionCode}, Описание: {Description}, Доступность: {IsAvailable}";
        }

        // Другие методы, связанные с управлением данными книги, можно добавить здесь
    }

}