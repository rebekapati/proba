using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutoVersenyzok
{
    public partial class FormAddNew : Form
    {
        public Versenyző ÚjVersenyző = new Versenyző();

        public FormAddNew()
        {
            InitializeComponent();
        }

        private void FormAddNew_Load(object sender, EventArgs e)
        {
            versenyzőBindingSource.DataSource = ÚjVersenyző;
        }
    }
}
