using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class AdminAction : UserControl
    {
        private AdminActionForm adminActionForm;
        private Form form;

        public AdminAction()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, Form form)
        {
            this.adminActionForm = adminActionForm;
            this.form = form;
        }

        private void EditProject_Click(object sender, EventArgs e)
        {
            EditProjectForm editProjectForm = new EditProjectForm(adminActionForm);
            editProjectForm.Show();
            adminActionForm.Hide();
        }

        private void CloseProject_Click(object sender, EventArgs e)
        {
            CloseProjectForm closeProjectForm = new CloseProjectForm(adminActionForm);
            closeProjectForm.Show();
            adminActionForm.Hide();
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            CreateProjectForm createProjectForm = new CreateProjectForm(adminActionForm);
            createProjectForm.Show();
            adminActionForm.Hide();
        }

        private void CloseTask_Click(object sender, EventArgs e)
        {
            CloseTaskForm closeTaskForm = new CloseTaskForm(adminActionForm);
            closeTaskForm.Show();
            adminActionForm.Hide();
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            UserActionForm userActionForm = new UserActionForm(adminActionForm);
            userActionForm.Show();
            adminActionForm.Hide();
        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            CreateTaskForm createTaskForm = new CreateTaskForm(adminActionForm);
            createTaskForm.Show();
            adminActionForm.Hide();
        }

        private void CreateEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm createEmployeeForm = new CreateEmployeeForm(adminActionForm);
            createEmployeeForm.Show();
            adminActionForm.Hide();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(adminActionForm);
            editEmployeeForm.Show();
            adminActionForm.Hide();
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            RemoveEmployeeForm removeEmployeeForm = new RemoveEmployeeForm(adminActionForm);
            removeEmployeeForm.Show();
            adminActionForm.Hide();
        }

        private void ViewProject_Click(object sender, EventArgs e)
        {
            ViewProjectForm viewProjectForm = new ViewProjectForm(adminActionForm);
            viewProjectForm.Show();
            adminActionForm.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            form.Show();
            adminActionForm.Dispose();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addemployee = new AddEmployeeForm();
            adminActionForm.Hide();
            addemployee.Show();
        }
    }
}
