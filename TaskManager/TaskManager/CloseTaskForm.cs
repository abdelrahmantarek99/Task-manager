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
    public partial class CloseTaskForm : Form
    {
        AdminActionForm adminActionForm;
        public CloseTaskForm()
        {
            InitializeComponent();
        }

        public CloseTaskForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            closeTask1.initialize(adminActionForm, this);
        }

        private void CloseTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
