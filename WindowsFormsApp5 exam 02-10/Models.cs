using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_shop
{
    public class Enter
    {
        [Key]
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
    public class Theme
    {
        [Key]
        public int ID { get; set; }
        public string NameTheme { get; set; }
        //Connection Theme-Book is One_to_Many
        public virtual ICollection<Book> Books { get; set; }
        public Theme()
        {
            Books = new List<Book>();
        }
    }
    public class Author
    {
        [Key]
        public int ID { get; set; }
        public string NameAuthor { get; set; }
        public string SurnameAuthor { get; set; }
        //Connection Author-Book is One_to_Many
        public virtual ICollection<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
    }
    public class PublishHouse
    {
        [Key]
        public int ID { get; set; }
        public string NamePublishHouse { get; set; }
        //Connection PublishHouse-Book is One_to_Many
        public virtual ICollection<Book> Books { get; set; }
        public PublishHouse()
        {
            Books = new List<Book>();
        }        
    }
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string NameBook { get; set; }
        public int Pages { get; set; }
        public int PublishYear { get; set; }
        public decimal Price { get; set; }
        public decimal PriceForSale { get; set; }
        public int Continuation { get; set; }
        public int Amount { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
        //Connection Book-Sale is One_to_Many
        public virtual ICollection<Sale> Sales { get; set; }
        //Connection Book-Reserve is One_to_Many
        public virtual ICollection<Reserve> Reserves { get; set; }
        public Book()
        {            
            Sales = new List<Sale>();
            Reserves = new List<Reserve>();
        }
        //Connection Author-Book is One_to_Many
        public int? ID_Author { get; set; }
        [ForeignKey("ID_Author")]
        public virtual Author Author { get; set; }
        //Connection PublishHouse-Book is One_to_Many
        public int? ID_PublishHouse { get; set; }
        [ForeignKey("ID_PublishHouse")]
        public virtual PublishHouse PublishHouse { get; set; }
        //Connection Theme-Book is One_to_Many
        public int? ID_Theme { get; set; }
        [ForeignKey("ID_Theme")]
        public virtual Theme Theme { get; set; }
    }
    public class Sale
    {
        [Key]
        public int ID { get; set; }
        public int AmountForSale { get; set; }
        public DateTime DateOfSale { get; set; }
        //Connection Book-Sale is One_to_Many
        public int? ID_Book { get; set; }
        [ForeignKey("ID_Book")]
        public virtual Book Book { get; set; }
    }

    public class Reserve
    {
        [Key]
        public int ID { get; set; }
        public string NameCustomer { get; set; }
        public int Amount { get; set; }
        //Connection Book-Reserve is One_to_Many
        public int? ID_Book { get; set; }
        [ForeignKey("ID_Book")]
        public virtual Book Book { get; set; }
    }

    public class ExamDatabaseAdoNet : DbContext
    {
        public DbSet<Enter> Enters { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PublishHouse> PublishHouses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Reserve> Reserves { get; set; }

        public ExamDatabaseAdoNet() : base("ExamDatabaseAdoNet") { }
        static ExamDatabaseAdoNet()
        {
            Database.SetInitializer(new MyInit());
        }
        public class MyInit : DropCreateDatabaseIfModelChanges<ExamDatabaseAdoNet>
        {
            protected override void Seed(ExamDatabaseAdoNet context)
            {
                Enter e1 = new Enter { Login = "User1", Password = "1234" };
                Enter e2 = new Enter { Login = "User2", Password = "4321" };
                Enter e3 = new Enter { Login = "User3", Password = "5678" };
                Enter e4 = new Enter { Login = "User4", Password = "8765" };

                context.Enters.AddRange(new List<Enter>() { e1, e2, e3, e4 });

                context.SaveChanges();
                base.Seed(context);
            }
        }
    }
}
