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
    public partial class CreateEmployeeForm : Form
    {
        private AdminActionForm adminActionForm;

        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        public CreateEmployeeForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            create_Employee1.initialize(adminActionForm, this);
        }
        
    }
}
