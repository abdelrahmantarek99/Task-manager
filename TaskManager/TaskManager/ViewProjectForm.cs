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
    public partial class ViewProjectForm : Form
    {
        private AdminActionForm adminActionForm;
        private UserActionForm userActionForm;

        public ViewProjectForm()
        {
            InitializeComponent();
        }

        public ViewProjectForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            viewProject1.initialize(adminActionForm, this, true);
        }

        public ViewProjectForm(UserActionForm userActionForm, int userId)
        {
            this.userActionForm = userActionForm;
            viewProject1.initialize(userActionForm, this, userId);
        }

        private void ViewProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void viewProject1_Load(object sender, EventArgs e)
        {

        }
    }
}
