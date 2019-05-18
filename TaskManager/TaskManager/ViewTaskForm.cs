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
    public partial class ViewTaskForm : Form
    {
        Form form;
        int id;
        public ViewTaskForm()
        {
            InitializeComponent();
        }

        public ViewTaskForm(Form form, int id) : this()
        {
            this.form = form;
            this.id = id;
            viewTask1.initialize(form, this, id);
        }

        private void VewTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
