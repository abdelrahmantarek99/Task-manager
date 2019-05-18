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
    public partial class ViewTaskHistoryForm : Form
    {
        Form form;
        int id;
        public ViewTaskHistoryForm()
        {
            InitializeComponent();
        }

        public ViewTaskHistoryForm(Form form, int id) : this()
        {
            this.form = form;
            viewTaskHistory1.initialize(form, this, id);
        }

        private void ViewTaskHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void viewTaskHistory1_Load(object sender, EventArgs e)
        {

        }
    }
}
