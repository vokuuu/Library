using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    [Serializable]
    public class LibraryCards : IEnumerable<LibraryCard>
    {
        static List<LibraryCard> libraryCards;
        [NonSerialized]
        static string filepath = "librarycards.dat";

        public LibraryCards()
        {
            Deserialize();
        }

        public IEnumerator<LibraryCard> GetEnumerator()
        {
            return ((IEnumerable<LibraryCard>)libraryCards).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)libraryCards).GetEnumerator();
        }
        private void Serialize()
        {
            // Сериализация списка читательских билетов в файл
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, libraryCards); // Сохраняем только список читательских билетов
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки сериализации
                Console.WriteLine($"Ошибка при сериализации читательских билетов: {ex.Message}");
                // Можно добавить логирование ошибки или другие действия по обработке
            }
        }
        public void Add(LibraryCard libraryCard)
        {
            if (libraryCards == null)
            {
                libraryCards = new List<LibraryCard>();
            }
            libraryCards.Add(libraryCard); // Добавляем читательский билет в список
            Serialize(); // Сохраняем изменения
        }

        private void Deserialize()
        {
            // Если файл существует и не пуст, загружаем данные
            if (File.Exists(filepath) && new FileInfo(filepath).Length > 0)
            {
                try
                {
                    using (FileStream fs = new FileStream(filepath, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        libraryCards = (List<LibraryCard>)bf.Deserialize(fs); // Загружаем список читательских билетов
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибки десериализации
                    Console.WriteLine($"Ошибка при десериализации читательских билетов: {ex.Message}");
                    // В случае ошибки десериализации, создаем новый пустой список
                    libraryCards = new List<LibraryCard>();
                }
            }
            else
            {
                libraryCards = new List<LibraryCard>(); // Если файл отсутствует или пуст, создаём новый список
            }
        }
    }
    [Serializable]
    public class LibraryCard
    {
        public int CardNumber { get; set; } // Номер читательского билета
        public string FullName { get; set; } // ФИО
        public string FacultyAndGroup { get; set; } // Факультет и группа
        public string PhoneNumber { get; set; } // Телефон

        public LibraryCard(int cardNumber, string fullName, string facultyAndGroup, string phoneNumber)
        {
            CardNumber = cardNumber;
            FullName = fullName;
            FacultyAndGroup = facultyAndGroup;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Читательский билет №{CardNumber}|ФИО: {FullName}|Факультет, группа: {FacultyAndGroup}|Телефон: {PhoneNumber}";
        }
    }

}