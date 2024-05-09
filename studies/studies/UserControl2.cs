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
    public partial class UserControl2 : UserControl
    {
        StudiesContext studiesContext = new StudiesContext();

        public UserControl2()
        {
            InitializeComponent();

            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from c in studiesContext.Courses
                                   where c.Name.Contains(textBox1.Text)
                                   select c).ToList();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course selectedCourse = listBox1.SelectedItem as Course;

            var courses = (from l in studiesContext.Lessons
                           where l.CourseFk == selectedCourse.CourseSk
                           select new
                           {
                               Nap = l.DayFkNavigation.Name,
                               Sáv = l.TimeFkNavigation.Name,
                               Oktató = l.InstructorFkNavigation.Name
                           });
            dataGridView1.DataSource = courses.ToList();
        }
    }
}
