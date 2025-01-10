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
    public partial class VadatKniga : Form
    {
        public VadatKniga()
        {
            InitializeComponent();
        }

        private void createnewreadticketbutton_Click(object sender, EventArgs e)
        {
            new CreateNewtTicketForm().Show();
        }

        private void addnewbookbutton_Click(object sender, EventArgs e)
        {
            new AddBook().Show();
        }
    }
}
