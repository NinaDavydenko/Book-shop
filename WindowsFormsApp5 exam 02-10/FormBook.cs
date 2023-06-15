using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_shop
{
    public partial class FormBook : Form
    {
        bool checkContinuation = false;
        public bool Creating = true;
        public FormBook()
        {
            InitializeComponent();
            UpdateListbox();
        }
        void UpdateListbox()
        {
            try
            {
                using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                {
                    listBoxAuthors.DataSource = db.Authors.ToList();
                    listBoxAuthors.DisplayMember = "SurnameAuthor";
                    listBoxAuthors.ValueMember = "ID";

                    listBoxPublishHouse.DataSource = db.PublishHouses.ToList();
                    listBoxPublishHouse.DisplayMember = "NamePublishHouse";
                    listBoxPublishHouse.ValueMember = "ID";

                    listBoxTheme.DataSource = db.Themes.ToList();
                    listBoxTheme.DisplayMember = "NameTheme";
                    listBoxTheme.ValueMember = "ID";           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor formAuthor = new FormAuthor();

            if (formAuthor.ShowDialog() == DialogResult.OK)
            {
                if (formAuthor.textBoxName.Text != "" && formAuthor.textBoxSurname.Text != "")
                {
                    try
                    {
                        using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                        {
                            UpdateListbox();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAddPublishHouse_Click(object sender, EventArgs e)
        {
            FormPublishHouse formPublishHouse = new FormPublishHouse();

            if (formPublishHouse.ShowDialog() == DialogResult.OK)
            {
                if (formPublishHouse.textBoxNamePublishHouse.Text != "")
                {
                    try
                    {
                        using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                        {
                            UpdateListbox();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAddTheme_Click(object sender, EventArgs e)
        {
            FormTheme formTheme = new FormTheme();

            if (formTheme.ShowDialog() == DialogResult.OK)
            {
                if (formTheme.textBoxNameTheme.Text != "")
                {
                    try
                    {
                        using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                        {
                            UpdateListbox();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonLoadAvailableBooks_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                {
                    listBoxAvailableBooks.DataSource = db.Books.ToList();
                    listBoxAvailableBooks.DisplayMember = "NameBook";
                    listBoxAvailableBooks.ValueMember = "ID";

                    checkContinuation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                {
                    if (Creating)
                    {
                        bool temp = false;
                        foreach (var b in db.Books)
                        {
                            if (b.NameBook == textBoxNameBook.Text)
                            {
                                temp = true;
                                throw new Exception("Such a book already exists");
                            }
                        }
                        if (!temp)
                        {
                            if (textBoxNameBook.Text != "" && textBoxPages.Text != "" && textBoxPublishYear.Text != ""
                                && textBoxPrice.Text != "" && textBoxPriceForSale.Text != "" && textBoxAmount.Text != "")
                            {
                                Book book = new Book();
                                book.NameBook = textBoxNameBook.Text;
                                book.Pages = Convert.ToInt32(textBoxPages.Text);
                                book.PublishYear = Convert.ToInt32(textBoxPublishYear.Text);
                                book.Price = Convert.ToDecimal(textBoxPrice.Text);
                                book.PriceForSale = Convert.ToDecimal(textBoxPriceForSale.Text);
                                book.Amount = Convert.ToInt32(textBoxAmount.Text);
                                book.IsActive = true;
                                if (checkContinuation)
                                {
                                    book.Continuation = Convert.ToInt32(listBoxAvailableBooks.SelectedValue);
                                    checkContinuation = false;
                                }

                                Theme th = (Theme)listBoxTheme.SelectedItem;
                                db.Themes.Attach(th);
                                th.Books.Add(book);

                                Author a = (Author)listBoxAuthors.SelectedItem;
                                db.Authors.Attach(a);
                                a.Books.Add(book);

                                PublishHouse ph = (PublishHouse)listBoxPublishHouse.SelectedItem;
                                db.PublishHouses.Attach(ph);
                                ph.Books.Add(book);

                                db.Books.Add(book);
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
