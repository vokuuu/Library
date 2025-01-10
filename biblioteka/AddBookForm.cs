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
        Books bookCatalog;
        Action parrentrefresh;
        public AddBook(Books Books,Action refreslistbox)
        {
            parrentrefresh = refreslistbox;
            this.bookCatalog = Books;
            InitializeComponent();
            RefreshDataGrid();

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
            bookCatalog.Add(new Book { Id = new Guid(), Title = title, Author = author, Status = status });
            RefreshDataGrid();
            ClearInputFields();
            parrentrefresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                bookCatalog.Remove(dataGridViewBooks.CurrentRow.Index);
                RefreshDataGrid();
                parrentrefresh();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.");
            }
        }
        public void RefreshDataGrid()
        {
            dataGridViewBooks.Rows.Clear();
            foreach (var book in bookCatalog)
            {
                dataGridViewBooks.Rows.Add(book.Id,book.Title, book.Author,book.Status);
            }
        }

        private void ClearInputFields()
        {
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxStatus.Clear(); 
        }
    }
}

    
