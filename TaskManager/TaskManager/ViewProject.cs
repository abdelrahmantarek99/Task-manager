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
    public partial class ViewProject : UserControl
    {
        private AdminActionForm adminActionForm;
        private ViewProjectForm ViewProjectForm;
        private UserActionForm userActionForm;
        private Boolean Admin;
        int userId = -1;

        public ViewProject()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, ViewProjectForm viewProjectForm, Boolean Admin)
        {
            this.adminActionForm = adminActionForm;
            this.ViewProjectForm = viewProjectForm;
            this.Admin = Admin;
        }

        public void initialize(UserActionForm userActionForm, ViewProjectForm viewProjectForm, int userId)
        {
            this.userActionForm = userActionForm;
            this.ViewProjectForm = viewProjectForm;
            this.userId = userId;
        }

        private void ViewProject_Load(object sender, EventArgs e)
        {
            Project.readProjects();

            if (Admin)
            {
                foreach (Project project in Project.projects)
                {
                    ProjectID.Items.Add(project.id);
                }
            }
            else
            {
                foreach (Project project in Project.projects)
                {
                    if (Tools.getEmployee(project.id, userId) != null)
                    {
                        ProjectID.Items.Add(project.id);
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks.Text = "";
            name.Text = "";
            Description.Text = "";
            ViewTask.Enabled = false;
            ViewTaskHistory.Enabled = false;
            Employees.Items.Clear();
            Tasks.Items.Clear();        
            String selected = ProjectID.SelectedItem.ToString();
            int projectId = Tools.getId(selected);
            Project project = Tools.getProject(projectId);
            name.Text = project.name;
            Description.Text = project.description;

            foreach (Employee employee in project.emploees)
            {
                Employees.Items.Add(employee.name + "(" + employee.id + ")");
                
                foreach(EmpTask empTask in employee.tasksOfEmp)
                {
                    Tasks.Items.Add(empTask.name + "(" + empTask.id + ")");
                }
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if(Admin)
            {
                adminActionForm.Show();
            }
            else
            {
                userActionForm.Show();
            }

            ViewProjectForm.Dispose();
        }

        private void Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewTask.Enabled = true;

            if (Admin)
                ViewTaskHistory.Enabled = true;
        }

        private void ViewTask_Click(object sender, EventArgs e)
        {
            if (ProjectID.SelectedItem == null || Tasks.SelectedItem == null)
            {
                MessageBox.Show("All FiledsAre Requierd");
                return;
            }

            String selected = Tasks.SelectedItem.ToString().ToString();
            int id = Tools.getId(selected);
            if (Admin)
            {
                ViewTaskForm viewTaskForm = new ViewTaskForm(adminActionForm, id);
                viewTaskForm.Show();
                adminActionForm.Hide();
            }
            else
            {
                ViewTaskForm viewTaskForm = new ViewTaskForm(userActionForm, id);
                viewTaskForm.Show();
                adminActionForm.Hide();
            }
        }

        private void ViewTaskHistory_Click(object sender, EventArgs e)
        {
            if (ProjectID.SelectedItem == null || Tasks.SelectedItem == null)
            {
                MessageBox.Show("All FiledsAre Requierd");
                return;
            }

            String selected = Tasks.SelectedItem.ToString().ToString();
            int id = Tools.getId(selected);
            ViewTaskHistoryForm viewTaskHistoryForm = new ViewTaskHistoryForm(adminActionForm, id);
            viewTaskHistoryForm.Show();
            adminActionForm.Hide();
        }
    }
}
