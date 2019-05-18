using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class ViewTask : UserControl
    {
        private Form form;
        private ViewTaskForm ViewTaskForm;
        private int id;

        public ViewTask()
        {
            InitializeComponent();
        }

        public void initialize(Form form, ViewTaskForm viewTaskForm, int id)
        {
            this.form = form;
            this.ViewTaskForm = viewTaskForm;
            this.id = id;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewTask_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            form.Show();
            ViewTaskForm.Dispose();
        }
    }
}
