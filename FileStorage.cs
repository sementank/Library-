using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace libary
{
    public class FileStorage
    {
        private string readersFilePath = "readers.json"; // Путь к файлу с данными о читателях
        private string booksFilePath = "books.json"; // Путь к файлу с данными о книгах

        // Загрузка данных о читателях из файла
        public List<Reader> LoadReaders()
        {
            try
            {
                if (File.Exists(readersFilePath))
                {
                    string json = File.ReadAllText(readersFilePath);
                    return JsonConvert.DeserializeObject<List<Reader>>(json);
                }
                return new List<Reader>();
            }
            catch
            {
                // Обработка ошибок
                return new List<Reader>();
            }
        }

        // Сохранение данных о читателях в файл
        public void SaveReaders(List<Reader> readers)
        {
            try
            {
                string json = JsonConvert.SerializeObject(readers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(readersFilePath, json);
            }
            catch
            {
                // Обработка ошибок
            }
        }

        // Загрузка данных о книгах из файла
        public List<Book> LoadBooks()
        {
            try
            {
                if (File.Exists(booksFilePath))
                {
                    string json = File.ReadAllText(booksFilePath);
                    return JsonConvert.DeserializeObject<List<Book>>(json);
                }
                return new List<Book>();
            }
            catch
            {
                // Обработка ошибок
                return new List<Book>();
            }
        }

        // Сохранение данных о книгах в файл
        public void SaveBooks(List<Book> books)
        {
            try
            {
                string json = JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(booksFilePath, json);
            }
            catch
            {
                // Обработка ошибок
            }
        }
    }
}
