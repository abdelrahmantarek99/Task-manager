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
    public partial class CreateProjectForm : Form
    {
        private AdminActionForm adminActionForm;
        public CreateProjectForm()
        {
            InitializeComponent();
        }

        public CreateProjectForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            create_Project1.initialize(adminActionForm, this);
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
