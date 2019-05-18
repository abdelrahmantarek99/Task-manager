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
    public partial class CloseProjectForm : Form
    {
        private AdminActionForm adminActionForm;

        public CloseProjectForm()
        {
            InitializeComponent();
        }

        public CloseProjectForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            closeProject1.initialize(adminActionForm, this);
        }

        private void CloseProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
