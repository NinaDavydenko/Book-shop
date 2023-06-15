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
    public partial class FormPublishHouse : Form
    {
        public FormPublishHouse()
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
                    foreach (var ph in db.PublishHouses)
                    {
                        if (ph.NamePublishHouse == textBoxNamePublishHouse.Text)
                        {
                            temp = true;
                            throw new Exception("Such a publishing house already exists");
                        }
                    }
                    if (!temp)
                    {
                        PublishHouse publishHouse = new PublishHouse();
                        publishHouse.NamePublishHouse = textBoxNamePublishHouse.Text;
                        db.PublishHouses.Add(publishHouse);
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
