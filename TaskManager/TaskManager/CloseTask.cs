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
    public partial class CloseTask : UserControl
    {
        private AdminActionForm adminActionForm;
        private CloseTaskForm closeTaskForm;

        public CloseTask()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, CloseTaskForm closeTaskForm)
        {
            this.adminActionForm = adminActionForm;
            this.closeTaskForm = closeTaskForm;
        }

        private void loadData()
        {
            TaskID.Items.Clear();
            TaskID.Text = "";

            Project.readProjects();

            foreach (Project project in Project.projects)
            {
                ProjectID.Items.Add(project.name + "(" + project.id + ")");
            }
        }

        private void CloseTask_Load(object sender, EventArgs e)
        {
            loadData();
        }
        
        private void UserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskID.Items.Clear();
            String selectedUser = UserID.SelectedItem.ToString();
            String selectedProj = ProjectID.SelectedItem.ToString();
            int userId = Tools.getId(selectedUser);
            int projectId = Tools.getId(selectedProj);
            Employee employee = Tools.getEmployee(projectId, userId);

            foreach (EmpTask empTask in employee.tasksOfEmp)
            {
                if(!empTask.close)
                    TaskID.Items.Add(empTask.name + "(" + empTask.id + ")");
            }
        }

        private void ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserID.Items.Clear();
            TaskID.Items.Clear();
            String selected = ProjectID.SelectedItem.ToString();
            int id = Tools.getId(selected);
            List<Employee> employees = Tools.GetEmployeesAtProject(id);

            foreach (Employee employee in employees)
            {
                UserID.Items.Add(employee.name + "(" + employee.id + ")");
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            if(ProjectID.SelectedItem == null  || UserID.SelectedItem == null ||TaskID.SelectedItem == null)
            {
                MessageBox.Show("All Fields Are Requierd");
                return;
            }
            
            int projectId = Tools.getId(ProjectID.SelectedItem.ToString());
            int employeeId = Tools.getId(UserID.SelectedItem.ToString());
            int taskId = Tools.getId(TaskID.SelectedItem.ToString());
            EmpTask empTask = Tools.getTask(projectId, employeeId, taskId);
            empTask.close = true;
            Project.writeProjects();
            MessageBox.Show("Task: " + taskId + " Has Been Closed");
            loadData();
            Employee employee = Tools.getEmployee(projectId, employeeId);

            foreach (EmpTask empTask2 in employee.tasksOfEmp)
            {
                if (!empTask2.close)
                    TaskID.Items.Add(empTask2.name + "(" + empTask2.id + ")");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            closeTaskForm.Dispose();
        }
    }
}