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
    public partial class CreateTaskForm : Form
    {
        private AdminActionForm adminActionForm;

        public CreateTaskForm()
        {
            InitializeComponent();
        }

        public CreateTaskForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            createTask1.initialize(adminActionForm, this);
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
