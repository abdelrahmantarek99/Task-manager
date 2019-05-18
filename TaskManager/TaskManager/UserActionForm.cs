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
    public partial class UserActionForm : Form
    {
        private Form1 form1;
        private AdminActionForm adminActionForm;
        private string id;

        public UserActionForm()
        {
            adminActionForm = null;
            form1 = null;
            InitializeComponent();
        }
        public UserActionForm(Form1 form1, string id) : this()
        {
            this.form1 = form1;
            this.id = id;
            userAction1.initilize(form1, this, id);
        }
        public UserActionForm(Form1 form1) : this()
        {
            this.form1 = form1;
            userAction1.initilize(form1, this);
        }

        public UserActionForm(AdminActionForm adminActionForm) : this()
        {
            this.adminActionForm = adminActionForm;
            userAction1.initilize(adminActionForm, this);
        }

        private void UserActionsFormcs_Load(object sender, EventArgs e)
        {
           
        }

        private void userAction1_Load(object sender, EventArgs e)
        {

        }
    } 
}
