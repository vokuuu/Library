namespace biblioteka
{
    partial class LendingBooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendingBooksForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookscatalogdgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addnewbookbutton = new System.Windows.Forms.Button();
            this.createnewreadticketbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.returndatapicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.issuedatapicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberreadercardtb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookscatalogdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.bookscatalogdgv);
            this.panel1.Controls.Add(this.addnewbookbutton);
            this.panel1.Controls.Add(this.createnewreadticketbutton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.returndatapicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.issuedatapicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numberreadercardtb);
            this.panel1.Location = new System.Drawing.Point(26, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 303);
            this.panel1.TabIndex = 2;
            // 
            // bookscatalogdgv
            // 
            this.bookscatalogdgv.AllowUserToAddRows = false;
            this.bookscatalogdgv.AllowUserToDeleteRows = false;
            this.bookscatalogdgv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.bookscatalogdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookscatalogdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.AuthorColumn,
            this.StatusColumn});
            this.bookscatalogdgv.Location = new System.Drawing.Point(360, 57);
            this.bookscatalogdgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookscatalogdgv.Name = "bookscatalogdgv";
            this.bookscatalogdgv.ReadOnly = true;
            this.bookscatalogdgv.RowHeadersVisible = false;
            this.bookscatalogdgv.RowHeadersWidth = 51;
            this.bookscatalogdgv.RowTemplate.Height = 33;
            this.bookscatalogdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookscatalogdgv.ShowCellErrors = false;
            this.bookscatalogdgv.ShowCellToolTips = false;
            this.bookscatalogdgv.ShowEditingIcon = false;
            this.bookscatalogdgv.ShowRowErrors = false;
            this.bookscatalogdgv.Size = new System.Drawing.Size(300, 142);
            this.bookscatalogdgv.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название книги";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.HeaderText = "Автор";
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // addnewbookbutton
            // 
            this.addnewbookbutton.Location = new System.Drawing.Point(34, 239);
            this.addnewbookbutton.Name = "addnewbookbutton";
            this.addnewbookbutton.Size = new System.Drawing.Size(140, 23);
            this.addnewbookbutton.TabIndex = 11;
            this.addnewbookbutton.Text = "Добавить новые книги";
            this.addnewbookbutton.UseVisualStyleBackColor = true;
            this.addnewbookbutton.Click += new System.EventHandler(this.addnewbookbutton_Click);
            // 
            // createnewreadticketbutton
            // 
            this.createnewreadticketbutton.Location = new System.Drawing.Point(33, 268);
            this.createnewreadticketbutton.Name = "createnewreadticketbutton";
            this.createnewreadticketbutton.Size = new System.Drawing.Size(175, 23);
            this.createnewreadticketbutton.TabIndex = 10;
            this.createnewreadticketbutton.Text = "Зарегистрировать студента ";
            this.createnewreadticketbutton.UseVisualStyleBackColor = true;
            this.createnewreadticketbutton.Click += new System.EventHandler(this.createnewreadticketbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(551, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Выдать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.lendBookButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(357, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Список книг";
            // 
            // returndatapicker
            // 
            this.returndatapicker.Location = new System.Drawing.Point(141, 131);
            this.returndatapicker.Margin = new System.Windows.Forms.Padding(2);
            this.returndatapicker.Name = "returndatapicker";
            this.returndatapicker.Size = new System.Drawing.Size(102, 20);
            this.returndatapicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата возврата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата выдачи";
            // 
            // issuedatapicker
            // 
            this.issuedatapicker.Location = new System.Drawing.Point(141, 94);
            this.issuedatapicker.Margin = new System.Windows.Forms.Padding(2);
            this.issuedatapicker.Name = "issuedatapicker";
            this.issuedatapicker.Size = new System.Drawing.Size(102, 20);
            this.issuedatapicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Читательский билет №";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выдача книг";
            // 
            // numberreadercardtb
            // 
            this.numberreadercardtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberreadercardtb.Location = new System.Drawing.Point(216, 57);
            this.numberreadercardtb.Margin = new System.Windows.Forms.Padding(2);
            this.numberreadercardtb.Name = "numberreadercardtb";
            this.numberreadercardtb.Size = new System.Drawing.Size(40, 23);
            this.numberreadercardtb.TabIndex = 0;
            // 
            // LendingBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 373);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "ы";
            this.Load += new System.EventHandler(this.LendingBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookscatalogdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberreadercardtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker issuedatapicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker returndatapicker;
        private System.Windows.Forms.Button addnewbookbutton;
        private System.Windows.Forms.Button createnewreadticketbutton;
        private System.Windows.Forms.DataGridView bookscatalogdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}