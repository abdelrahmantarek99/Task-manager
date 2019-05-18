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
    public partial class RemoveEmployeeForm : Form
    {
        private AdminActionForm adminActionForm;

        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }

        public RemoveEmployeeForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            removeEmployee1.initialize(adminActionForm, this);
        }

        private void RemoveEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
