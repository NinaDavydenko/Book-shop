using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Book_shop
{
    public partial class Form1 : Form
    {
        public ExamDatabaseAdoNet db = null;
        public Form1()
        {
            InitializeComponent();
            db = new ExamDatabaseAdoNet();
            CheckEnter();
        }
        void CheckEnter()
        {
            FormEnter formEnter = new FormEnter();
            if (formEnter.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bool temp = false;
                    foreach (var enters in db.Enters)
                    {
                        if (enters.Login == formEnter.textBoxLogin.Text 
                            && enters.Password == formEnter.textBoxPassword.Text)
                        {
                            temp = true;
                            buttonShowAllBooks.Enabled = true;
                        }
                    }
                    if (!temp)
                    {
                        throw new Exception("Such a user does NOT exist");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }
        void LoadAllData()
        {
            var book = (from b in db.Books
                        where b.IsActive == true && b.Amount > 0
                        select new
                        {
                            ID = b.ID,
                            NameBook = b.NameBook,
                            NameAuthor = b.Author.NameAuthor,
                            SurnameAuthor = b.Author.SurnameAuthor,
                            NameTheme = b.Theme.NameTheme,
                            Pages = b.Pages,
                            PublishHouse = b.PublishHouse.NamePublishHouse,
                            PublishYear = b.PublishYear,
                            Price = b.Price,
                            PriceForSale = b.PriceForSale,
                            Amount = b.Amount,
                            Discount = b.Discount,
                        }).ToList();

            dataGridView1.DataSource = book;

            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            buttonArchive.Enabled = true;
            buttonBuy.Enabled = true;
            buttonReserve.Enabled = true;
            buttonSetDiscount.Enabled = true;
            buttonFindBook.Enabled = true;
            buttonNewBooksList.Enabled = true;
            buttonPopularBooksList.Enabled = true;
            buttonPopularAuthorsList.Enabled = true;
            buttonPopularThemesList.Enabled = true;
        }

        private void buttonShowAllBooks_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook();
            formBook.Creating = true;

            if (formBook.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadAllData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook();
            formBook.Creating = false;

            int id_book = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            try
            {
                Book book = db.Books.Find(id_book);

                List<Author> authors = db.Authors.ToList();
                List<PublishHouse> publishHouses = db.PublishHouses.ToList();
                List<Theme> themes = db.Themes.ToList();

                formBook.textBoxNameBook.Text = book.NameBook;
                formBook.textBoxPages.Text = book.Pages.ToString();
                formBook.textBoxPublishYear.Text = book.PublishYear.ToString();
                formBook.textBoxPrice.Text = book.Price.ToString();
                formBook.textBoxPriceForSale.Text = book.PriceForSale.ToString();
                formBook.textBoxAmount.Text = book.Amount.ToString();

                formBook.listBoxAuthors.SelectedItem = authors;
                formBook.listBoxPublishHouse.SelectedItem = publishHouses;
                formBook.listBoxTheme.SelectedItem = themes;

                if (formBook.ShowDialog() == DialogResult.OK)
                {

                    book.NameBook = formBook.textBoxNameBook.Text;
                    book.Pages = Convert.ToInt32(formBook.textBoxPages.Text);
                    book.PublishYear = Convert.ToInt32(formBook.textBoxPublishYear.Text);
                    book.Price = Convert.ToDecimal(formBook.textBoxPrice.Text);
                    book.PriceForSale = Convert.ToDecimal(formBook.textBoxPriceForSale.Text);
                    book.Amount = Convert.ToInt32(formBook.textBoxAmount.Text);

                    foreach (var a in db.Authors)
                    {
                        if (a.SurnameAuthor == ((Author)formBook.listBoxAuthors.SelectedItem).SurnameAuthor)
                        {
                            db.Authors.Attach(a);
                            db.Books.Attach(book);
                            book.Author = a;
                            break;
                        }
                    }
                    foreach (var ph in db.PublishHouses)
                    {
                        if (ph.NamePublishHouse == ((PublishHouse)formBook.listBoxPublishHouse.SelectedItem).NamePublishHouse)
                        {
                            db.PublishHouses.Attach(ph);
                            db.Books.Attach(book);
                            book.PublishHouse = ph;
                            break;
                        }
                    }
                    foreach (var th in db.Themes)
                    {
                        if (th.NameTheme == ((Theme)formBook.listBoxTheme.SelectedItem).NameTheme)
                        {
                            db.Themes.Attach(th);
                            db.Books.Attach(book);
                            book.Theme = th;
                            break;
                        }
                    }
                    
                    db.Entry(book).State = EntityState.Modified;

                    db.SaveChanges();
                    LoadAllData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_book = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                try
                {
                    Book book = db.Books.Find(id_book);

                    db.Entry(book).State = EntityState.Deleted;
                    db.Books.Remove(book);

                    db.SaveChanges();
                    LoadAllData();

                    MessageBox.Show("The book has been deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during deletion: " + ex.Message);
                }
            }
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_book = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                try
                {
                    Book book = db.Books.Find(id_book);
                    book.IsActive = false;

                    db.Entry(book).State = EntityState.Modified;
                    db.SaveChanges();
                    LoadAllData();

                    MessageBox.Show("The book has been transfered to the archieve");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during transferring: " + ex.Message);
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            FormAmount formAmount = new FormAmount();
            if (formAmount.ShowDialog() == DialogResult.OK)
            { 
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id_book = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    try
                    {
                        Book book = db.Books.Find(id_book);
                        if (book.Amount >= Convert.ToInt32(formAmount.textBoxAmount.Text))
                        {
                            book.Amount = book.Amount - Convert.ToInt32(formAmount.textBoxAmount.Text);

                            db.Entry(book).State = EntityState.Modified;

                            Sale s = new Sale();
                            s.AmountForSale = Convert.ToInt32(formAmount.textBoxAmount.Text);
                            s.DateOfSale = DateTime.Now.Date;
                            book.Sales.Add(s);

                            db.SaveChanges();
                            LoadAllData();

                            decimal p = Convert.ToInt32(formAmount.textBoxAmount.Text) * book.PriceForSale -
                                Convert.ToInt32(formAmount.textBoxAmount.Text) * book.PriceForSale * book.Discount / 100;
                            MessageBox.Show("The book is sold. To pay: " + p + " UAH");
                        }
                        else
                        {
                            MessageBox.Show("This quantity is not available");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Selling error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            FormReserve formReserve = new FormReserve();
            if (formReserve.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id_book = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    try
                    {
                        Book book = db.Books.Find(id_book);
                        if (book.Amount >= Convert.ToInt32(formReserve.textBoxAmount.Text))
                        {
                            book.Amount = book.Amount - Convert.ToInt32(formReserve.textBoxAmount.Text);

                            db.Entry(book).State = EntityState.Modified;

                            Reserve r = new Reserve();
                            r.Amount = Convert.ToInt32(formReserve.textBoxAmount.Text);
                            r.NameCustomer = formReserve.textBoxSurname.Text;
                            book.Reserves.Add(r);

                            db.SaveChanges();
                            LoadAllData();

                            MessageBox.Show("The book is reserved");
                        }
                        else
                        {
                            MessageBox.Show("This quantity is not available");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Reservation error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonSetDiscount_Click(object sender, EventArgs e)
        {
            textBoxDiscount.Enabled = true;

            listBoxThemes.DataSource = db.Themes.ToList();
            listBoxThemes.DisplayMember = "NameTheme";
            listBoxThemes.ValueMember = "ID";

            buttonOkDiscount.Enabled = true;
            buttonCancelDiscount.Enabled = true;
        }

        private void buttonCancelDiscount_Click(object sender, EventArgs e)
        {
            listBoxThemes.Items.Clear();
            buttonOkDiscount.Enabled = false;
            buttonCancelDiscount.Enabled = false;
        }

        private void buttonOkDiscount_Click(object sender, EventArgs e)
        {
            int id_theme = Convert.ToInt32(listBoxThemes.SelectedValue);           

            foreach(Book b in db.Books)
            {
                if (b.ID_Theme == id_theme)
                {
                    b.Discount = Convert.ToInt32(textBoxDiscount.Text);
                    db.Entry(b).State = EntityState.Modified;                    
                }
            }
            db.SaveChanges();
            LoadAllData();
        }

        private void buttonFindBook_Click(object sender, EventArgs e)
        {
            groupBoxFind.Enabled = true;
            textBoxFind.Enabled = true;
            buttonOkFind.Enabled = true;
            buttonCancelFind.Enabled = true;
        }

        private void buttonCancelFind_Click(object sender, EventArgs e)
        {
            groupBoxFind.Enabled = false;
            textBoxFind.Enabled = false;
            buttonOkFind.Enabled = false;
            buttonCancelFind.Enabled = false;

            LoadAllData();
        }

        private void buttonOkFind_Click(object sender, EventArgs e)
        {
            if(radioButtonNameBook.Checked && textBoxFind.Text != "")
            {
                var book = (from b in db.Books
                            where b.NameBook == textBoxFind.Text
                            select new
                            {
                                ID = b.ID,
                                NameBook = b.NameBook,
                                NameAuthor = b.Author.NameAuthor,
                                SurnameAuthor = b.Author.SurnameAuthor,
                                NameTheme = b.Theme.NameTheme,
                                Pages = b.Pages,
                                PublishHouse = b.PublishHouse.NamePublishHouse,
                                PublishYear = b.PublishYear,
                                Price = b.Price,
                                PriceForSale = b.PriceForSale,
                                Amount = b.Amount,
                                Discount = b.Discount,
                            }).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonAuthor.Checked && textBoxFind.Text != "")
            {
                var book = (from b in db.Books
                            where b.Author.SurnameAuthor == textBoxFind.Text
                            select new
                            {
                                ID = b.ID,
                                NameBook = b.NameBook,
                                NameAuthor = b.Author.NameAuthor,
                                SurnameAuthor = b.Author.SurnameAuthor,
                                NameTheme = b.Theme.NameTheme,
                                Pages = b.Pages,
                                PublishHouse = b.PublishHouse.NamePublishHouse,
                                PublishYear = b.PublishYear,
                                Price = b.Price,
                                PriceForSale = b.PriceForSale,
                                Amount = b.Amount,
                                Discount = b.Discount,
                            }).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonTheme.Checked && textBoxFind.Text != "")
            {
                var book = (from b in db.Books
                            where b.Theme.NameTheme == textBoxFind.Text
                            select new
                            {
                                ID = b.ID,
                                NameBook = b.NameBook,
                                NameAuthor = b.Author.NameAuthor,
                                SurnameAuthor = b.Author.SurnameAuthor,
                                NameTheme = b.Theme.NameTheme,
                                Pages = b.Pages,
                                PublishHouse = b.PublishHouse.NamePublishHouse,
                                PublishYear = b.PublishYear,
                                Price = b.Price,
                                PriceForSale = b.PriceForSale,
                                Amount = b.Amount,
                                Discount = b.Discount,
                            }).ToList();

                dataGridView1.DataSource = book;
            }
        }

        private void buttonNewBooksList_Click(object sender, EventArgs e)
        {
            var book = (from b in db.Books
                        where b.PublishYear == DateTime.Now.Year
                        select new
                        {
                            ID = b.ID,
                            NameBook = b.NameBook,
                            NameAuthor = b.Author.NameAuthor,
                            SurnameAuthor = b.Author.SurnameAuthor,
                            NameTheme = b.Theme.NameTheme,
                            Pages = b.Pages,
                            PublishHouse = b.PublishHouse.NamePublishHouse,
                            PublishYear = b.PublishYear,
                            Price = b.Price,
                            PriceForSale = b.PriceForSale,
                            Amount = b.Amount,
                            Discount = b.Discount,
                        }).ToList();

            dataGridView1.DataSource = book;
        }

        private void buttonPopularBooksList_Click(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                var book = db.Sales.Include("Books")
                    .Where(s => s.DateOfSale.Day == DateTime.Now.Day)
                    .GroupBy(s => s.Book.NameBook)
                    .Select(ss => new { Name = ss.Key, 
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)})
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonWeek.Checked)
            {
                var book = db.Sales.Include("Books")
                    .Where(s => s.DateOfSale.Day <= DateTime.Now.Day && s.DateOfSale.Day >= DateTime.Now.Day - 7)
                    .GroupBy(s => s.Book.NameBook)
                    .Select(ss => new {
                        Name = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonMonth.Checked)
            {
                var book = db.Sales.Include("Books")
                    .Where(s => s.DateOfSale.Month <= DateTime.Now.Month 
                        && s.DateOfSale.Month >= DateTime.Now.Month - 1)
                    .GroupBy(s => s.Book.NameBook)
                    .Select(ss => new {
                        Name = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
        }

        private void buttonPopularAuthorsList_Click(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                var book = db.Sales.Include("Books").Include("Authors")
                    .Where(s => s.DateOfSale.Day == DateTime.Now.Day)
                    .GroupBy(s => s.Book.Author.SurnameAuthor)
                    .Select(ss => new {
                        SurnameAuthor = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonWeek.Checked)
            {
                var book = db.Sales.Include("Books").Include("Authors")
                    .Where(s => s.DateOfSale.Day <= DateTime.Now.Day && s.DateOfSale.Day >= DateTime.Now.Day - 7)
                    .GroupBy(s => s.Book.Author.SurnameAuthor)
                    .Select(ss => new {
                        SurnameAuthor = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonMonth.Checked)
            {
                var book = db.Sales.Include("Books").Include("Authors")
                    .Where(s => s.DateOfSale.Month <= DateTime.Now.Month
                        && s.DateOfSale.Month >= DateTime.Now.Month - 1)
                    .GroupBy(s => s.Book.Author.SurnameAuthor)
                    .Select(ss => new {
                        SurnameAuthor = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
        }

        private void buttonPopularThemesList_Click(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                var book = db.Sales.Include("Books").Include("Themes")
                    .Where(s => s.DateOfSale.Day == DateTime.Now.Day)
                    .GroupBy(s => s.Book.Theme.NameTheme)
                    .Select(ss => new {
                        SurnameAuthor = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonWeek.Checked)
            {
                var book = db.Sales.Include("Books").Include("Themes")
                    .Where(s => s.DateOfSale.Day <= DateTime.Now.Day && s.DateOfSale.Day >= DateTime.Now.Day - 7)
                    .GroupBy(s => s.Book.Theme.NameTheme)
                    .Select(ss => new {
                        SurnameAuthor = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
            if (radioButtonMonth.Checked)
            {
                var book = db.Sales.Include("Books").Include("Themes")
                    .Where(s => s.DateOfSale.Month <= DateTime.Now.Month
                        && s.DateOfSale.Month >= DateTime.Now.Month - 1)
                    .GroupBy(s => s.Book.Theme.NameTheme)
                    .Select(ss => new {
                        SurnameAuthor = ss.Key,
                        AmountBooks = ss.Sum(sss => sss.AmountForSale)
                    })
                    .OrderByDescending(a => a.AmountBooks).ToList();

                dataGridView1.DataSource = book;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
