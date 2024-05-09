using studies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studies
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext studiesContext = new StudiesContext();

        public UserControl1()
        {
            InitializeComponent();

            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource() //Szervezd ki a lekérdezést és az adatforrás feltöltését egy külön metódusba, amit aztán hívj meg a konstruktorból és a TextChanged eseménykezelőből is
        {
            listBox1.DataSource = (from i in studiesContext.Instructors
                                   where i.Name.Contains(textBox1.Text) //A Contains() helyett használható még a StartsWith() metódus is, ha csak név eleji egyezésekre akarunk összpontosítani.
                                   select i).ToList();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor selectedInstructor = listBox1.SelectedItem as Instructor;

            var lessons = from l in studiesContext.Lessons
                          where l.InstructorFk == selectedInstructor.InstructorSk
                          select new
                          {
                              Kurzus = l.CourseFkNavigation.Name,
                              Nap = l.DayFkNavigation.Name,
                              Sáv = l.TimeFkNavigation.Name
                          };

            dataGridView1.DataSource = lessons.ToList();
        }
    }
}
