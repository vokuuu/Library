using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteka;

namespace biblioteka
{
    public partial class AddBook : Form
    {
        private List<Book> books;
        private int nextId = 1; // Счетчик для ID книг

        public AddBook()
        {
            InitializeComponent();
            books = new List<Book>();
            dataGridViewBooks.DataSource = books;

            // Подписка на события кнопок
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string status = textBoxStatus.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Создание новой книги с уникальным ID и статусом
            books.Add(new Book { Id = nextId++, Title = title, Author = author, Status = status });
            dataGridViewBooks.DataSource = null; // Сброс привязки
            dataGridViewBooks.DataSource = books; // Привязка к обновленному списку

            ClearInputFields();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                books.RemoveAt(dataGridViewBooks.CurrentRow.Index);
                dataGridViewBooks.DataSource = null; // Сброс привязки
                dataGridViewBooks.DataSource = books; // Привязка к обновленному списку
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.");
            }
        }

        private void ClearInputFields()
        {
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxStatus.Clear(); // Очистка поля статуса
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; } // Новый статус книги
    }
}

    
