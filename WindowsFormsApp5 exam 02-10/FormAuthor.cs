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
    public partial class FormAuthor : Form
    {
        //ExamDatabaseAdoNet db = null;
        public FormAuthor()
        {
            InitializeComponent();
            //db = new ExamDatabaseAdoNet();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                {
                    bool temp = false;
                    foreach (var a in db.Authors)
                    {
                        if (a.NameAuthor == textBoxName.Text && a.SurnameAuthor == textBoxSurname.Text)
                        {
                            temp = true;
                            throw new Exception("Such an author already exists");
                        }
                    }
                    if (!temp)
                    {
                        Author author = new Author();
                        author.SurnameAuthor = textBoxSurname.Text;
                        author.NameAuthor = textBoxName.Text;
                        db.Authors.Add(author);
                        db.SaveChanges();
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
