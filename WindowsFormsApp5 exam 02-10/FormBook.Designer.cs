
namespace Book_shop
{
    partial class FormBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.listBoxPublishHouse = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTheme = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxPublishYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPriceForSale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxAvailableBooks = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonAddPublishHouse = new System.Windows.Forms.Button();
            this.buttonAddTheme = new System.Windows.Forms.Button();
            this.buttonLoadAvailableBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "The title of the book";
            // 
            // textBoxNameBook
            // 
            this.textBoxNameBook.Location = new System.Drawing.Point(164, 7);
            this.textBoxNameBook.Name = "textBoxNameBook";
            this.textBoxNameBook.Size = new System.Drawing.Size(218, 22);
            this.textBoxNameBook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authors";
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 16;
            this.listBoxAuthors.Location = new System.Drawing.Point(164, 35);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(218, 84);
            this.listBoxAuthors.TabIndex = 3;
            // 
            // listBoxPublishHouse
            // 
            this.listBoxPublishHouse.FormattingEnabled = true;
            this.listBoxPublishHouse.ItemHeight = 16;
            this.listBoxPublishHouse.Location = new System.Drawing.Point(164, 125);
            this.listBoxPublishHouse.Name = "listBoxPublishHouse";
            this.listBoxPublishHouse.Size = new System.Drawing.Size(218, 84);
            this.listBoxPublishHouse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publishing house";
            // 
            // listBoxTheme
            // 
            this.listBoxTheme.FormattingEnabled = true;
            this.listBoxTheme.ItemHeight = 16;
            this.listBoxTheme.Location = new System.Drawing.Point(164, 215);
            this.listBoxTheme.Name = "listBoxTheme";
            this.listBoxTheme.Size = new System.Drawing.Size(218, 84);
            this.listBoxTheme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of pages";
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(563, 8);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(218, 22);
            this.textBoxPages.TabIndex = 9;
            // 
            // textBoxPublishYear
            // 
            this.textBoxPublishYear.Location = new System.Drawing.Point(563, 36);
            this.textBoxPublishYear.Name = "textBoxPublishYear";
            this.textBoxPublishYear.Size = new System.Drawing.Size(218, 22);
            this.textBoxPublishYear.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Year of publication";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(563, 64);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(218, 22);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Purchase price";
            // 
            // textBoxPriceForSale
            // 
            this.textBoxPriceForSale.Location = new System.Drawing.Point(563, 92);
            this.textBoxPriceForSale.Name = "textBoxPriceForSale";
            this.textBoxPriceForSale.Size = new System.Drawing.Size(218, 22);
            this.textBoxPriceForSale.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Selling price";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(563, 120);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(218, 22);
            this.textBoxAmount.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantity of books";
            // 
            // listBoxAvailableBooks
            // 
            this.listBoxAvailableBooks.FormattingEnabled = true;
            this.listBoxAvailableBooks.ItemHeight = 16;
            this.listBoxAvailableBooks.Location = new System.Drawing.Point(563, 148);
            this.listBoxAvailableBooks.Name = "listBoxAvailableBooks";
            this.listBoxAvailableBooks.Size = new System.Drawing.Size(218, 148);
            this.listBoxAvailableBooks.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Continuation of the book";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(591, 316);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(92, 45);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(689, 316);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 45);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(164, 316);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(92, 45);
            this.buttonAddAuthor.TabIndex = 22;
            this.buttonAddAuthor.Text = "Add author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonAddPublishHouse
            // 
            this.buttonAddPublishHouse.Location = new System.Drawing.Point(262, 316);
            this.buttonAddPublishHouse.Name = "buttonAddPublishHouse";
            this.buttonAddPublishHouse.Size = new System.Drawing.Size(118, 45);
            this.buttonAddPublishHouse.TabIndex = 23;
            this.buttonAddPublishHouse.Text = "Add publisher";
            this.buttonAddPublishHouse.UseVisualStyleBackColor = true;
            this.buttonAddPublishHouse.Click += new System.EventHandler(this.buttonAddPublishHouse_Click);
            // 
            // buttonAddTheme
            // 
            this.buttonAddTheme.Location = new System.Drawing.Point(386, 316);
            this.buttonAddTheme.Name = "buttonAddTheme";
            this.buttonAddTheme.Size = new System.Drawing.Size(92, 45);
            this.buttonAddTheme.TabIndex = 24;
            this.buttonAddTheme.Text = "Add genre";
            this.buttonAddTheme.UseVisualStyleBackColor = true;
            this.buttonAddTheme.Click += new System.EventHandler(this.buttonAddTheme_Click);
            // 
            // buttonLoadAvailableBooks
            // 
            this.buttonLoadAvailableBooks.Location = new System.Drawing.Point(415, 168);
            this.buttonLoadAvailableBooks.Name = "buttonLoadAvailableBooks";
            this.buttonLoadAvailableBooks.Size = new System.Drawing.Size(137, 45);
            this.buttonLoadAvailableBooks.TabIndex = 25;
            this.buttonLoadAvailableBooks.Text = "Download the list of books";
            this.buttonLoadAvailableBooks.UseVisualStyleBackColor = true;
            this.buttonLoadAvailableBooks.Click += new System.EventHandler(this.buttonLoadAvailableBooks_Click);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.buttonLoadAvailableBooks);
            this.Controls.Add(this.buttonAddTheme);
            this.Controls.Add(this.buttonAddPublishHouse);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxAvailableBooks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPriceForSale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPublishYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxTheme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxPublishHouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxAuthors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameBook);
            this.Controls.Add(this.label1);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox textBoxNameBook;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.ListBox listBoxAuthors;
        protected internal System.Windows.Forms.ListBox listBoxPublishHouse;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.ListBox listBoxTheme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox textBoxPages;
        protected internal System.Windows.Forms.TextBox textBoxPublishYear;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.TextBox textBoxPriceForSale;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.ListBox listBoxAvailableBooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonAddPublishHouse;
        private System.Windows.Forms.Button buttonAddTheme;
        private System.Windows.Forms.Button buttonLoadAvailableBooks;
    }
}