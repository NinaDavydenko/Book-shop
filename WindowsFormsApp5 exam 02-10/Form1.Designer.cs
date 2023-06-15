
namespace Book_shop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEnter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowAllBooks = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonSetDiscount = new System.Windows.Forms.Button();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxThemes = new System.Windows.Forms.ListBox();
            this.buttonOkDiscount = new System.Windows.Forms.Button();
            this.buttonCancelDiscount = new System.Windows.Forms.Button();
            this.buttonFindBook = new System.Windows.Forms.Button();
            this.radioButtonNameBook = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthor = new System.Windows.Forms.RadioButton();
            this.radioButtonTheme = new System.Windows.Forms.RadioButton();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonCancelFind = new System.Windows.Forms.Button();
            this.buttonOkFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewBooksList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPopularBooksList = new System.Windows.Forms.Button();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.buttonPopularAuthorsList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPopularThemesList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFind.SuspendLayout();
            this.groupBoxPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEnter.Location = new System.Drawing.Point(12, 12);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(111, 36);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "Log in";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 223);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonShowAllBooks
            // 
            this.buttonShowAllBooks.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonShowAllBooks.Enabled = false;
            this.buttonShowAllBooks.Location = new System.Drawing.Point(129, 12);
            this.buttonShowAllBooks.Name = "buttonShowAllBooks";
            this.buttonShowAllBooks.Size = new System.Drawing.Size(156, 36);
            this.buttonShowAllBooks.TabIndex = 11;
            this.buttonShowAllBooks.Text = "Show all books";
            this.buttonShowAllBooks.UseVisualStyleBackColor = true;
            this.buttonShowAllBooks.Click += new System.EventHandler(this.buttonShowAllBooks_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(13, 285);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 52);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(13, 343);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 52);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit book";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(13, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 52);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete book";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Enabled = false;
            this.buttonArchive.Location = new System.Drawing.Point(13, 459);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(100, 52);
            this.buttonArchive.TabIndex = 16;
            this.buttonArchive.Text = "Transfer to the archive";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Enabled = false;
            this.buttonBuy.Location = new System.Drawing.Point(13, 517);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(100, 52);
            this.buttonBuy.TabIndex = 17;
            this.buttonBuy.Text = "Buy book";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Enabled = false;
            this.buttonReserve.Location = new System.Drawing.Point(13, 575);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(100, 52);
            this.buttonReserve.TabIndex = 18;
            this.buttonReserve.Text = "Reserve a book";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonSetDiscount
            // 
            this.buttonSetDiscount.Enabled = false;
            this.buttonSetDiscount.Location = new System.Drawing.Point(141, 285);
            this.buttonSetDiscount.Name = "buttonSetDiscount";
            this.buttonSetDiscount.Size = new System.Drawing.Size(120, 52);
            this.buttonSetDiscount.TabIndex = 19;
            this.buttonSetDiscount.Text = "Set a discount";
            this.buttonSetDiscount.UseVisualStyleBackColor = true;
            this.buttonSetDiscount.Click += new System.EventHandler(this.buttonSetDiscount_Click);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Enabled = false;
            this.textBoxDiscount.Location = new System.Drawing.Point(141, 373);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(120, 22);
            this.textBoxDiscount.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Input discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Choose the genre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxThemes
            // 
            this.listBoxThemes.FormattingEnabled = true;
            this.listBoxThemes.ItemHeight = 16;
            this.listBoxThemes.Location = new System.Drawing.Point(141, 424);
            this.listBoxThemes.Name = "listBoxThemes";
            this.listBoxThemes.Size = new System.Drawing.Size(120, 84);
            this.listBoxThemes.TabIndex = 23;
            // 
            // buttonOkDiscount
            // 
            this.buttonOkDiscount.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkDiscount.Enabled = false;
            this.buttonOkDiscount.Location = new System.Drawing.Point(141, 517);
            this.buttonOkDiscount.Name = "buttonOkDiscount";
            this.buttonOkDiscount.Size = new System.Drawing.Size(120, 52);
            this.buttonOkDiscount.TabIndex = 24;
            this.buttonOkDiscount.Text = "Ok";
            this.buttonOkDiscount.UseVisualStyleBackColor = true;
            this.buttonOkDiscount.Click += new System.EventHandler(this.buttonOkDiscount_Click);
            // 
            // buttonCancelDiscount
            // 
            this.buttonCancelDiscount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelDiscount.Enabled = false;
            this.buttonCancelDiscount.Location = new System.Drawing.Point(141, 576);
            this.buttonCancelDiscount.Name = "buttonCancelDiscount";
            this.buttonCancelDiscount.Size = new System.Drawing.Size(120, 52);
            this.buttonCancelDiscount.TabIndex = 25;
            this.buttonCancelDiscount.Text = "Cancel";
            this.buttonCancelDiscount.UseVisualStyleBackColor = true;
            this.buttonCancelDiscount.Click += new System.EventHandler(this.buttonCancelDiscount_Click);
            // 
            // buttonFindBook
            // 
            this.buttonFindBook.Enabled = false;
            this.buttonFindBook.Location = new System.Drawing.Point(285, 285);
            this.buttonFindBook.Name = "buttonFindBook";
            this.buttonFindBook.Size = new System.Drawing.Size(120, 52);
            this.buttonFindBook.TabIndex = 26;
            this.buttonFindBook.Text = "Book search";
            this.buttonFindBook.UseVisualStyleBackColor = true;
            this.buttonFindBook.Click += new System.EventHandler(this.buttonFindBook_Click);
            // 
            // radioButtonNameBook
            // 
            this.radioButtonNameBook.AutoSize = true;
            this.radioButtonNameBook.Location = new System.Drawing.Point(7, 22);
            this.radioButtonNameBook.Name = "radioButtonNameBook";
            this.radioButtonNameBook.Size = new System.Drawing.Size(54, 20);
            this.radioButtonNameBook.TabIndex = 0;
            this.radioButtonNameBook.TabStop = true;
            this.radioButtonNameBook.Text = "Title";
            this.radioButtonNameBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuthor
            // 
            this.radioButtonAuthor.AutoSize = true;
            this.radioButtonAuthor.Location = new System.Drawing.Point(7, 60);
            this.radioButtonAuthor.Name = "radioButtonAuthor";
            this.radioButtonAuthor.Size = new System.Drawing.Size(66, 20);
            this.radioButtonAuthor.TabIndex = 1;
            this.radioButtonAuthor.TabStop = true;
            this.radioButtonAuthor.Text = "Author";
            this.radioButtonAuthor.UseVisualStyleBackColor = true;
            // 
            // radioButtonTheme
            // 
            this.radioButtonTheme.AutoSize = true;
            this.radioButtonTheme.Location = new System.Drawing.Point(6, 100);
            this.radioButtonTheme.Name = "radioButtonTheme";
            this.radioButtonTheme.Size = new System.Drawing.Size(65, 20);
            this.radioButtonTheme.TabIndex = 2;
            this.radioButtonTheme.TabStop = true;
            this.radioButtonTheme.Text = "Genre";
            this.radioButtonTheme.UseVisualStyleBackColor = true;
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Controls.Add(this.radioButtonTheme);
            this.groupBoxFind.Controls.Add(this.radioButtonAuthor);
            this.groupBoxFind.Controls.Add(this.radioButtonNameBook);
            this.groupBoxFind.Enabled = false;
            this.groupBoxFind.Location = new System.Drawing.Point(285, 344);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(120, 136);
            this.groupBoxFind.TabIndex = 27;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Search";
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(282, 486);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(115, 16);
            this.labelFind.TabIndex = 29;
            this.labelFind.Text = "Search parameter";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Enabled = false;
            this.textBoxFind.Location = new System.Drawing.Point(282, 514);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(120, 22);
            this.textBoxFind.TabIndex = 28;
            // 
            // buttonCancelFind
            // 
            this.buttonCancelFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelFind.Enabled = false;
            this.buttonCancelFind.Location = new System.Drawing.Point(282, 588);
            this.buttonCancelFind.Name = "buttonCancelFind";
            this.buttonCancelFind.Size = new System.Drawing.Size(120, 40);
            this.buttonCancelFind.TabIndex = 31;
            this.buttonCancelFind.Text = "Cancel";
            this.buttonCancelFind.UseVisualStyleBackColor = true;
            this.buttonCancelFind.Click += new System.EventHandler(this.buttonCancelFind_Click);
            // 
            // buttonOkFind
            // 
            this.buttonOkFind.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkFind.Enabled = false;
            this.buttonOkFind.Location = new System.Drawing.Point(282, 544);
            this.buttonOkFind.Name = "buttonOkFind";
            this.buttonOkFind.Size = new System.Drawing.Size(120, 38);
            this.buttonOkFind.TabIndex = 30;
            this.buttonOkFind.Text = "Ok";
            this.buttonOkFind.UseVisualStyleBackColor = true;
            this.buttonOkFind.Click += new System.EventHandler(this.buttonOkFind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "List of novelties of the current year";
            // 
            // buttonNewBooksList
            // 
            this.buttonNewBooksList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNewBooksList.Enabled = false;
            this.buttonNewBooksList.Location = new System.Drawing.Point(663, 287);
            this.buttonNewBooksList.Name = "buttonNewBooksList";
            this.buttonNewBooksList.Size = new System.Drawing.Size(120, 38);
            this.buttonNewBooksList.TabIndex = 33;
            this.buttonNewBooksList.Text = "Show";
            this.buttonNewBooksList.UseVisualStyleBackColor = true;
            this.buttonNewBooksList.Click += new System.EventHandler(this.buttonNewBooksList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "The most popular books";
            // 
            // buttonPopularBooksList
            // 
            this.buttonPopularBooksList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPopularBooksList.Enabled = false;
            this.buttonPopularBooksList.Location = new System.Drawing.Point(663, 352);
            this.buttonPopularBooksList.Name = "buttonPopularBooksList";
            this.buttonPopularBooksList.Size = new System.Drawing.Size(120, 38);
            this.buttonPopularBooksList.TabIndex = 35;
            this.buttonPopularBooksList.Text = "Show";
            this.buttonPopularBooksList.UseVisualStyleBackColor = true;
            this.buttonPopularBooksList.Click += new System.EventHandler(this.buttonPopularBooksList_Click);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.radioButtonMonth);
            this.groupBoxPeriod.Controls.Add(this.radioButtonWeek);
            this.groupBoxPeriod.Controls.Add(this.radioButtonDay);
            this.groupBoxPeriod.Location = new System.Drawing.Point(816, 345);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(120, 136);
            this.groupBoxPeriod.TabIndex = 28;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Time period";
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Location = new System.Drawing.Point(6, 100);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(64, 20);
            this.radioButtonMonth.TabIndex = 2;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Month";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Location = new System.Drawing.Point(7, 60);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(64, 20);
            this.radioButtonWeek.TabIndex = 1;
            this.radioButtonWeek.TabStop = true;
            this.radioButtonWeek.Text = "Week";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(7, 22);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(53, 20);
            this.radioButtonDay.TabIndex = 0;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Day";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // buttonPopularAuthorsList
            // 
            this.buttonPopularAuthorsList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPopularAuthorsList.Enabled = false;
            this.buttonPopularAuthorsList.Location = new System.Drawing.Point(663, 396);
            this.buttonPopularAuthorsList.Name = "buttonPopularAuthorsList";
            this.buttonPopularAuthorsList.Size = new System.Drawing.Size(120, 38);
            this.buttonPopularAuthorsList.TabIndex = 37;
            this.buttonPopularAuthorsList.Text = "Show";
            this.buttonPopularAuthorsList.UseVisualStyleBackColor = true;
            this.buttonPopularAuthorsList.Click += new System.EventHandler(this.buttonPopularAuthorsList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "The most popular authors";
            // 
            // buttonPopularThemesList
            // 
            this.buttonPopularThemesList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPopularThemesList.Enabled = false;
            this.buttonPopularThemesList.Location = new System.Drawing.Point(663, 440);
            this.buttonPopularThemesList.Name = "buttonPopularThemesList";
            this.buttonPopularThemesList.Size = new System.Drawing.Size(120, 38);
            this.buttonPopularThemesList.TabIndex = 39;
            this.buttonPopularThemesList.Text = "Show";
            this.buttonPopularThemesList.UseVisualStyleBackColor = true;
            this.buttonPopularThemesList.Click += new System.EventHandler(this.buttonPopularThemesList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "The most popular genres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 640);
            this.Controls.Add(this.buttonPopularThemesList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPopularAuthorsList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.buttonPopularBooksList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonNewBooksList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelFind);
            this.Controls.Add(this.buttonOkFind);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.buttonFindBook);
            this.Controls.Add(this.buttonCancelDiscount);
            this.Controls.Add(this.buttonOkDiscount);
            this.Controls.Add(this.listBoxThemes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.buttonSetDiscount);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonShowAllBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonShowAllBooks;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonSetDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxThemes;
        private System.Windows.Forms.Button buttonOkDiscount;
        private System.Windows.Forms.Button buttonCancelDiscount;
        private System.Windows.Forms.Button buttonFindBook;
        private System.Windows.Forms.RadioButton radioButtonNameBook;
        private System.Windows.Forms.RadioButton radioButtonAuthor;
        private System.Windows.Forms.RadioButton radioButtonTheme;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonCancelFind;
        private System.Windows.Forms.Button buttonOkFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNewBooksList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPopularBooksList;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.Button buttonPopularAuthorsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPopularThemesList;
        private System.Windows.Forms.Label label6;
    }
}

