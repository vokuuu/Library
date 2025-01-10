using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace biblioteka
{
    [Serializable]
    public class Books : IEnumerable<Book>
    {
        private static List<Book> listbooks = new List<Book>(); // Инициализация списка
        [NonSerialized]
        private readonly string filepath = "books.dat"; // Путь к файлу

        public Books()
        {
            Deserialize(); // Загружаем данные из файла при создании объекта
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return listbooks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listbooks.GetEnumerator();
        }

        public void Add(Book book)
        {
            listbooks.Add(book); // Добавляем книгу в список
            Serialize(); // Сохраняем изменения
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < listbooks.Count)
            {
                listbooks.RemoveAt(index); // Удаляем книгу по индексу
                Serialize(); // Сохраняем изменения
            }
        }

        public void Serialize()
        {
            // Сериализация списка книг в файл
            using (FileStream fs = new FileStream(filepath, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listbooks); // Сохраняем только список книг
            }
        }

        private void Deserialize()
        {
            // Если файл существует и не пуст, загружаем данные
            if (File.Exists(filepath) && new FileInfo(filepath).Length > 0)
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    listbooks = (List<Book>)bf.Deserialize(fs); // Загружаем список книг
                }
            }
            else
            {
                listbooks = new List<Book>(); // Если файл отсутствует или пуст, создаём новый список
            }
        }
    }

    [Serializable]
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Уникальный идентификатор
        public string Title { get; set; } // Название книги
        public string Author { get; set; } // Автор книги
        public string Status { get; set; } // Статус книги (например, "Доступна", "Занята")
    }
}
