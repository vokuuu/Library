using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class CreateLibraryCard : Form
    {
        LibraryCards libraryCards;
        public CreateLibraryCard(LibraryCards libraryCards)
        {
            this.libraryCards = libraryCards;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ticketNumber = txtTicketNumber.Text;
            string fullName = txtFullName.Text;
            string facultyGroup = txtFacultyGroup.Text;
            string phone = txtPhone.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(ticketNumber) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(facultyGroup) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            libraryCards.Add(new LibraryCard(int.Parse(ticketNumber),fullName,facultyGroup,phone));
            // Здесь можно добавить логику для сохранения данных
            MessageBox.Show("Регистрация успешна!");
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtTicketNumber.Clear();
            txtFullName.Clear();
            txtFacultyGroup.Clear();
            txtPhone.Clear();
        }
    }
}


