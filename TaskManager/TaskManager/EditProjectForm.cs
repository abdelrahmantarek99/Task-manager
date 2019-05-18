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
    public partial class EditProjectForm : Form
    {
        private AdminActionForm adminActionForm;

        public EditProjectForm()
        {
            InitializeComponent();
        }

        public EditProjectForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            editProject1.initialize(adminActionForm, this);
        }

        private void EditProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
