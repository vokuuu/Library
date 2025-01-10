using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class LendingBooksForm : Form
    {
        Books books;
        LibraryCards libraryCards;
        public LendingBooksForm()
        {
            InitializeComponent();
        }

        public LendingBooksForm(Books books, LibraryCards libraryCards)
        {
            InitializeComponent();
            this.books = books;
            this.libraryCards = libraryCards;
        }

        private void createnewreadticketbutton_Click(object sender, EventArgs e)
        {
            new CreateLibraryCard(libraryCards).Show();
        }

        private void addnewbookbutton_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBook(books, RefreshDataGrid);
            addBookForm.Show();
        }

        private void LendingBooksForm_Load(object sender, EventArgs e)
        {
            books = new Books();
            libraryCards = new LibraryCards();
            RefreshDataGrid();
        }
        public void RefreshDataGrid()
        {
            bookscatalogdgv.Rows.Clear();
            foreach (var book in books)
            {
                bookscatalogdgv.Rows.Add(book.Id, book.Title, book.Author, book.Status);
            }
        }

        private void lendBookButton_Click(object sender, EventArgs e)
        {
            if (bookscatalogdgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну книгу для выдачи.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(numberreadercardtb.Text))
            {
                MessageBox.Show("Пожалуйста, введите номер читательского билета.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(numberreadercardtb.Text, out int cardNumber))
            {
                MessageBox.Show("Неверный формат номера читательского билета.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var libraryCard = libraryCards.FirstOrDefault(card => card.CardNumber == cardNumber);
            if (libraryCard == null)
            {
                MessageBox.Show($"Читательский билет №{cardNumber} не найден.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var selectedRow = bookscatalogdgv.SelectedRows[0];
            var bookId = (Guid)selectedRow.Cells[0].Value;
            var bookToLend = books.FirstOrDefault(book => book.Id == bookId);

            if (bookToLend == null)
            {
                MessageBox.Show("Выбранная книга не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookToLend.Status == "Занята")
            {
                MessageBox.Show($"Книга \"{bookToLend.Title}\" уже занята.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bookToLend.Status = "Занята";
            books.Serialize();

            MessageBox.Show($"Книга \"{bookToLend.Title}\" выдана читателю с билетом №{cardNumber}.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshDataGrid();
        }
    }
}