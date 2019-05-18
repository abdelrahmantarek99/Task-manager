using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class AdminActionForm : Form
    {
        private Form form;

        public AdminActionForm()
        {
            InitializeComponent();
        }

        public AdminActionForm(Form form) : this()
        {
            this.form = form;
            adminAction1.initialize(this, form);
        }

        private void adminAction1_Load(object sender, EventArgs e)
        {

        }

        private void AdminActionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
