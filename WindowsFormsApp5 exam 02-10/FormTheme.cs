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
    public partial class FormTheme : Form
    {
        public FormTheme()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExamDatabaseAdoNet db = new ExamDatabaseAdoNet())
                {
                    bool temp = false;
                    foreach (var th in db.Themes)
                    {
                        if (th.NameTheme == textBoxNameTheme.Text)
                        {
                            temp = true;
                            throw new Exception("Such a genre already exists");
                        }
                    }
                    if (!temp)
                    {
                        Theme theme = new Theme();
                        theme.NameTheme = textBoxNameTheme.Text;
                        db.Themes.Add(theme);
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
