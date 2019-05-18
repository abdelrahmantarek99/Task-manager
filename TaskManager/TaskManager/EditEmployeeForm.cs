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
    public partial class EditEmployeeForm : Form
    {
        private AdminActionForm adminActionForm;

        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public EditEmployeeForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            editEmployee1.initialize(adminActionForm, this);
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
